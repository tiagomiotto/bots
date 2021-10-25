using Microsoft.Extensions.Configuration;
using Microsoft.Graph;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using TrainingOnboarding.Models;

namespace TrainingOnboarding.Tests
{
    [TestClass]
    public class CoursesMetadataTests
    {
        #region Stuff

        public IConfiguration _configuration;

        [TestInitialize]
        public void Init()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(System.AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            _configuration = builder.Build();
        }
        async Task<GraphServiceClient> GetClient()
        {
            var token = await AuthHelper.GetToken(_configuration["TenantId"], _configuration["MicrosoftAppId"], _configuration["MicrosoftAppPassword"]);
            return AuthHelper.GetAuthenticatedClient(token);
        }
        #endregion

        /// <summary>
        /// Basic load test
        /// </summary>
        [TestMethod]
        public async Task CoursesMetadataLoad()
        {
            var graphClient = await GetClient();
            var meta = await CoursesMetadata.LoadTrainingSPData(graphClient, _configuration["SharePointSiteId"]);
            Assert.IsNotNull(meta);

            Assert.IsTrue(meta.Courses.Count > 0);
            Assert.IsTrue(meta.Courses[0].Attendees.Count > 0);
        }

        /// <summary>
        /// Tests we can save a CourseTasksUpdateInfo
        /// </summary>
        [TestMethod]
        public async Task CourseTasksUpdateInfoSave()
        {
            var graphClient = await GetClient();

            var testInvalidUpdate = new CourseTasksUpdateInfo { UserAadObjectId = _configuration["TestUserAadObjectId"] };
            testInvalidUpdate.ConfirmedTaskIds.Add(233331);
            await Assert.ThrowsExceptionAsync<ArgumentOutOfRangeException>(() => testInvalidUpdate.SaveChanges(graphClient, _configuration["SharePointSiteId"]));

            var testUpdate = new CourseTasksUpdateInfo { UserAadObjectId = _configuration["TestUserAadObjectId"] };
            testUpdate.ConfirmedTaskIds.Add(1);

            await testUpdate.SaveChanges(graphClient, _configuration["SharePointSiteId"]);
        }

        /// <summary>
        /// Tests we can save CourseAttendance
        /// </summary>
        [TestMethod]
        public async Task CourseAttendanceSave()
        {
            var graphClient = await GetClient();

            var a = new CourseAttendance 
            { 
                BotContacted = true, CourseId = "1", ID = "1", QACountry = "1232", QAMobilePhoneNumber = "345", QARole = "567", QASpareTimeActivities = "9898",
                User = new SiteUser { Email = "AdeleV@M365x352268.OnMicrosoft.com", Name = "Adele" }
            };

            await a.SaveChanges(graphClient, _configuration["SharePointSiteId"]);
        }
    }
}