﻿using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Schema;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TrainingOnboarding.Bot.Cards;
using TrainingOnboarding.Bot.Helpers;
using TrainingOnboarding.Models;

namespace TrainingOnboarding.Bot.Dialogues
{
    public class UpdateProfileDialog : LogoutDialog
    {
        protected readonly ILogger Logger;

        private BotHelper _botHelper;
        public UpdateProfileDialog(BotHelper botHelper, BotConfig botConfig, ILogger<UpdateProfileDialog> logger)
            : base(nameof(UpdateProfileDialog), botConfig.BotOAuthConnectionName)
        {
            Logger = logger;
            _botHelper = botHelper;

            AddDialog(new OAuthPrompt(
                nameof(OAuthPrompt),
                new OAuthPromptSettings
                {
                    ConnectionName = botConfig.BotOAuthConnectionName,
                    Text = "Please Sign In",
                    Title = "Sign In",
                    Timeout = 300000, // User has 5 minutes to login (1000 * 60 * 5)
                }));
            AddDialog(new TextPrompt(nameof(TextPrompt)));
            AddDialog(new WaterfallDialog(nameof(WaterfallDialog), new WaterfallStep[]
            {
                PromptStepAsync,
                SaveProfileAsync,
                LoginStepAsync,
                DisplayTokenPhase1Async,
                DisplayTokenPhase2Async,
            }));

            // The initial child Dialog to run.
            InitialDialogId = nameof(WaterfallDialog);
        }

        private async Task<DialogTurnResult> PromptStepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var courseAttendance = (CourseAttendance)stepContext.Options;
            if (courseAttendance == null)
            {
                throw new ArgumentNullException(nameof(courseAttendance));
            }

            // Create the text prompt
            var opts = new PromptOptions
            {
                Prompt = new Activity
                {
                    Attachments = new List<Attachment>() { new AttendeeFixedQuestionsInputCard(courseAttendance).GetCard() },
                    Type = ActivityTypes.Message,
                    Text = "waiting for user input...", // You can comment this out if you don't want to display any text. Still works.
                }
            };

            // Display a Text Prompt and wait for input
            return await stepContext.PromptAsync(nameof(TextPrompt), opts);
        }

        private async Task<DialogTurnResult> SaveProfileAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var courseAttendance = (CourseAttendance)stepContext.Options;
            if (courseAttendance == null)
            {
                throw new ArgumentNullException(nameof(courseAttendance));
            }

            await _botHelper.HandleCardResponse(stepContext, stepContext.Context.Activity.Value?.ToString(), cancellationToken);
            return await stepContext.BeginDialogAsync(nameof(OAuthPrompt), null, cancellationToken);
        }

        private async Task<DialogTurnResult> LoginStepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            // Get the token from the previous step. Note that we could also have gotten the
            // token directly from the prompt itself. There is an example of this in the next method.
            var tokenResponse = (TokenResponse)stepContext.Result;
            if (tokenResponse?.Token != null)
            {
                await stepContext.Context.SendActivityAsync($"Niiiiiiiiiiiiiiiiiiiiiceeeee");
            }

            await stepContext.Context.SendActivityAsync(MessageFactory.Text("Login was not successful please try again."), cancellationToken);
            return await stepContext.EndDialogAsync(cancellationToken: cancellationToken);
        }

        private async Task<DialogTurnResult> DisplayTokenPhase1Async(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            await stepContext.Context.SendActivityAsync(MessageFactory.Text("Thank you."), cancellationToken);

            var result = (bool)stepContext.Result;
            if (result)
            {
                // Call the prompt again because we need the token. The reasons for this are:
                // 1. If the user is already logged in we do not need to store the token locally in the bot and worry
                // about refreshing it. We can always just call the prompt again to get the token.
                // 2. We never know how long it will take a user to respond. By the time the
                // user responds the token may have expired. The user would then be prompted to login again.
                //
                // There is no reason to store the token locally in the bot because we can always just call
                // the OAuth prompt to get the token or get a new token if needed.
                return await stepContext.BeginDialogAsync(nameof(OAuthPrompt), cancellationToken: cancellationToken);
            }

            return await stepContext.EndDialogAsync(cancellationToken: cancellationToken);
        }

        private async Task<DialogTurnResult> DisplayTokenPhase2Async(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var tokenResponse = (TokenResponse)stepContext.Result;
            if (tokenResponse != null)
            {
                await stepContext.Context.SendActivityAsync(MessageFactory.Text($"Here is your token {tokenResponse.Token}"), cancellationToken);
            }

            return await stepContext.EndDialogAsync(cancellationToken: cancellationToken);
        }
    }

}