using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Pages
{
    class SearchByFilters
    {
            private static IWebElement ClickSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[1]/input"));
            private static IWebElement SearchSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[1]/i"));
            private static IWebElement Filteronline => Driver.driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[5]/button[1]"));
            private static IWebElement FilterOnsite => Driver.driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[5]/button[2]"));
            private static IWebElement FilterShowall => Driver.driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[5]/button[3]"));

        internal void SearchSkills()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "SearchSkill");

            //Click on search skill
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[1]/input", 10000);
            ClickSkill.Click();
            ClickSkill.SendKeys(ExcelLibHelper.ReadData(2, "SearchFilter"));
        }

        internal void Search()
        {
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[1]/i", 10000);
            SearchSkill.Click();
        }


        #region search using Filters
        internal void FilterOnline()
        {
            //Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.extent.StartTest("Filter Online");

            //Search by Filter online
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[5]/button[1]", 10000);
            Filteronline.Click();
            Thread.Sleep(2000);
            CommonMethods.test.Log(LogStatus.Info, "Skill search using Online is successfull");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "FilterOnline");
        }

        internal void FilterOnSite()
        {
            //Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.extent.StartTest("Filter Onsite");

            //Search by filter onsite
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[5]/button[2]", 10000);
            FilterOnsite.Click();
            Thread.Sleep(2000);
            CommonMethods.test.Log(LogStatus.Info, "Skill search using Onsite is successfull");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "FilterOnsite");
        }

        internal void FilterShowAll()
        {
            //Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.extent.StartTest("Filter Show All");

            //Search by filter ShowAll
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[5]/button[3]", 10000);
            FilterShowall.Click();
            Thread.Sleep(2000);
            CommonMethods.test.Log(LogStatus.Info, "Skill search using Showall is successfull");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "FilterShowAll");
        }
        #endregion
    }
}
