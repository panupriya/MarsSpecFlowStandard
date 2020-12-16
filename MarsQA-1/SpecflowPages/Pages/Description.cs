using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
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
    class Description
    {
            private static IWebElement DescriptionEdit =>  Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            private static IWebElement DescriptionBox =>  Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            private static IWebElement SaveDescription =>  Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
       
        #region add description
        internal void EnterDescription()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();

            //Click on edit Description
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 10000);
            DescriptionEdit.Click();

            //Click on Description Text and clear the details
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea", 10000);
            Thread.Sleep(1000);
            DescriptionBox.Clear();
            DescriptionBox.SendKeys(ExcelLibHelper.ReadData(2, "Description"));

            //Click on Save button
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button", 10000);
            SaveDescription.Click();
            CommonMethods.test.Log(LogStatus.Info, "Description Added successfully");
        }

        internal void VerifyDescription()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            

            //Verify Description
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add Description");

                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span", 10000);
                var description = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span")).Text;
                Assert.That(description, Is.EqualTo(ExcelLibHelper.ReadData(2, "Description")));
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Description Added Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "DescriptionAdded");
            }
            catch (Exception ex)
            {

                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", ex.Message);
            }
        }
        #endregion

        #region edit description
        internal void EditDescription()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();

            //Click on edit Description
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 10000);
            DescriptionEdit.Click();

            //Click on Description Text and clear the details
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea", 10000);
            Thread.Sleep(2000);
            DescriptionBox.Clear();
            DescriptionBox.SendKeys(ExcelLibHelper.ReadData(3, "Description"));

            //Click on Save button
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button", 10000);
            SaveDescription.Click();
            
        }

        internal void VerifyEditedDescription()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            

            //Verify edited description
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Edit Description");

                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span", 10000);
                var description = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span")).Text;
                Assert.That(description, Is.EqualTo(ExcelLibHelper.ReadData(3, "Description")));
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Description Edited Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "DescriptionEdited");
            }
            catch (Exception ex)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", ex.Message);

            }
        }
        #endregion
    }
}
