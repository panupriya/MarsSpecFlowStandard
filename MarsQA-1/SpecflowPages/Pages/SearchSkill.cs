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
    class SearchSkill
    {

             private static IWebElement SearchButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[1]/input"));
             private static IWebElement ClickSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[1]/i"));
             private static IWebElement searchSkill => Driver.driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[2]/input"));
             private static IWebElement ClickSearckSkill => Driver.driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[2]/i"));
             private static IWebElement SearchUser => Driver.driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[1]/input"));
             private static IWebElement ClickSearchUser => Driver.driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div[1]/div/span"));
        #region Search Category
        internal void Search_skill()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "SearchSkill");

            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[1]/input", 10000);
            SearchButton.Click();
            SearchButton.SendKeys(ExcelLibHelper.ReadData(2, "SearchSkill"));
        }

        internal void SearchCategory()
        {
           

            //Enter search skill
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[1]/i", 10000);
            ClickSkill.Click();

           
        }

        internal void SearchSucessfull()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "SearchSkill");
            //Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.extent.StartTest("Search By Category");

            // search skill catagory
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[2]/input", 10000);
            searchSkill.Click();
            searchSkill.SendKeys(ExcelLibHelper.ReadData(2, "SearchSkillCategory"));

            CommonMethods.test.Log(LogStatus.Info, "Skill search using category is successfull");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "SearchCategory");

        }
        #endregion

        #region Search Name
        internal void Search_Skill()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "SearchSkill");

            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[1]/input", 10000);
            SearchButton.Click();
            SearchButton.SendKeys(ExcelLibHelper.ReadData(2, "SearchSkill"));

            //Enter search skill
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[1]/i", 10000);
            ClickSkill.Click();
        }

        internal void SearchName()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "SearchSkill");

            //Click search skill
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[2]/i", 10000);
            ClickSearckSkill.Click();


            //Search user
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[1]/input", 10000);
            SearchUser.Click();
            SearchUser.SendKeys(ExcelLibHelper.ReadData(2, "UserName"));
            //SearchUser.SendKeys("zorawar badhan");
            Thread.Sleep(2000);
        }

        internal void SearchNameSuccesfull()
        {
            //Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.extent.StartTest("Search By Name");

            //click Search user
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div[1]/div/span", 10000);
            ClickSearchUser.Click();
            Thread.Sleep(2000);
            CommonMethods.test.Log(LogStatus.Info, "Skill search using name is successfull");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "SearchByName");
        }
        #endregion
    }
}
