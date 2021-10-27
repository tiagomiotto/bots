﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrainingOnboarding.Bot.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TrainingOnboarding.Bot.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;type&quot;: &quot;AdaptiveCard&quot;,
        ///  &quot;version&quot;: &quot;1.3&quot;,
        ///  &quot;body&quot;: [
        ///    {
        ///      &quot;type&quot;: &quot;ColumnSet&quot;,
        ///      &quot;columns&quot;: [
        ///        {
        ///          &quot;type&quot;: &quot;Column&quot;,
        ///          &quot;width&quot;: &quot;auto&quot;,
        ///          &quot;items&quot;: [
        ///            {
        ///              &quot;type&quot;: &quot;TextBlock&quot;,
        ///              &quot;text&quot;: &quot;Introduction&quot;,
        ///              &quot;wrap&quot;: true
        ///            }
        ///          ],
        ///          &quot;spacing&quot;: &quot;None&quot;
        ///        }
        ///      ]
        ///    },
        ///    {
        ///      &quot;type&quot;: &quot;TextBlock&quot;,
        ///      &quot;text&quot;: &quot;Hi, ${AttendeeName} please answer the questions t [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AttendeeFixedQuestionsInput {
            get {
                return ResourceManager.GetString("AttendeeFixedQuestionsInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;type&quot;: &quot;AdaptiveCard&quot;,
        ///  &quot;version&quot;: &quot;1.3&quot;,
        ///  &quot;body&quot;: [
        ///    {
        ///      &quot;type&quot;: &quot;ColumnSet&quot;,
        ///      &quot;columns&quot;: [
        ///        {
        ///          &quot;type&quot;: &quot;Column&quot;,
        ///          &quot;width&quot;: &quot;auto&quot;,
        ///          &quot;items&quot;: [
        ///            {
        ///              &quot;type&quot;: &quot;TextBlock&quot;,
        ///              &quot;text&quot;: &quot;${AttendeeName} has joined the learning group&quot;,
        ///              &quot;wrap&quot;: true
        ///            }
        ///          ],
        ///          &quot;spacing&quot;: &quot;None&quot;
        ///        }
        ///      ]
        ///    },
        ///    {
        ///      &quot;type&quot;: &quot;TextBlock&quot;,
        ///      &quot;text&quot;: &quot;Hi, my name is $ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AttendeeFixedQuestionsPublication {
            get {
                return ResourceManager.GetString("AttendeeFixedQuestionsPublication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;type&quot;: &quot;AdaptiveCard&quot;,
        ///  &quot;version&quot;: &quot;1.3&quot;,
        ///  &quot;body&quot;: [
        ///    {
        ///      &quot;type&quot;: &quot;ColumnSet&quot;,
        ///      &quot;columns&quot;: [
        ///        {
        ///          &quot;type&quot;: &quot;Column&quot;,
        ///          &quot;width&quot;: &quot;auto&quot;,
        ///          &quot;spacing&quot;: &quot;None&quot;,
        ///          &quot;items&quot;: [
        ///            {
        ///              &quot;type&quot;: &quot;TextBlock&quot;,
        ///              &quot;wrap&quot;: true,
        ///              &quot;text&quot;: &quot;\&quot;${BotName}\&quot;&quot;
        ///            }
        ///          ]
        ///        }
        ///      ]
        ///    },
        ///    {
        ///      &quot;type&quot;: &quot;TextBlock&quot;,
        ///      &quot;text&quot;: &quot;Hi, I&apos;m the \&quot;${BotName}\&quot;. You have been added [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string BotIntroduction {
            get {
                return ResourceManager.GetString("BotIntroduction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;type&quot;: &quot;AdaptiveCard&quot;,
        ///    &quot;version&quot;: &quot;1.5&quot;,
        ///    &quot;body&quot;: [
        ///        {
        ///            &quot;type&quot;: &quot;TextBlock&quot;,
        ///            &quot;wrap&quot;: true,
        ///            &quot;text&quot;: &quot;Digital Training Assistant&quot;
        ///        },
        ///        {
        ///            &quot;type&quot;: &quot;TextBlock&quot;,
        ///            &quot;text&quot;: &quot;Welcome to ${CourseName}&quot;,
        ///            &quot;size&quot;: &quot;Medium&quot;,
        ///            &quot;weight&quot;: &quot;Bolder&quot;,
        ///            &quot;wrap&quot;: true
        ///        },
        ///        {
        ///            &quot;type&quot;: &quot;Image&quot;,
        ///            &quot;altText&quot;: &quot;Take picture from admin app&quot;,
        ///            &quot;hor [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CourseWelcome {
            get {
                return ResourceManager.GetString("CourseWelcome", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;type&quot;: &quot;AdaptiveCard&quot;,
        ///    &quot;version&quot;: &quot;1.3&quot;,
        ///    &quot;body&quot;: [
        ///        {
        ///            &quot;type&quot;: &quot;TextBlock&quot;,
        ///            &quot;text&quot;: &quot;Meet and greet your colleagues in the program&quot;,
        ///            &quot;wrap&quot;: true
        ///        },
        ///        {
        ///            &quot;type&quot;: &quot;ActionSet&quot;,
        ///            &quot;actions&quot;: [
        ///              {
        ///                &quot;type&quot;: &quot;Action.Submit&quot;,
        ///                &quot;title&quot;: &quot;Introduce Yourself&quot;,
        ///                &quot;data&quot;: {
        ///                  &quot;action&quot;: &quot;StartIntroduction&quot;,
        ///                  &quot;SPID&quot;: &quot;${Share [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string IntroduceYourself {
            get {
                return ResourceManager.GetString("IntroduceYourself", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;type&quot;: &quot;AdaptiveCard&quot;,
        ///    &quot;version&quot;: &quot;1.3&quot;,
        ///    &quot;body&quot;: [
        ///        {
        ///            &quot;type&quot;: &quot;ColumnSet&quot;,
        ///            &quot;columns&quot;: [
        ///                {
        ///                    &quot;type&quot;: &quot;Column&quot;,
        ///                    &quot;width&quot;: &quot;auto&quot;,
        ///                    &quot;items&quot;: [
        ///                        {
        ///                            &quot;type&quot;: &quot;TextBlock&quot;,
        ///                            &quot;text&quot;: &quot;Introduction&quot;,
        ///                            &quot;wrap&quot;: true
        ///                        }
        ///                    ],
        ///                     [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LearnerQuestions {
            get {
                return ResourceManager.GetString("LearnerQuestions", resourceCulture);
            }
        }
    }
}
