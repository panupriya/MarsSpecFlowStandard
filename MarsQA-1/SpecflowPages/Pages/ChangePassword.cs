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
    class ChangePassword
    {
            private static IWebElement NameBtn =>  Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
            private static IWebElement ChgPwdBtn =>  Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span/div/a[2]"));
            private static IWebElement CurrentPwd =>  Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[1]/input"));
            private static IWebElement NewPwd =>  Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[2]/input"));
            private static IWebElement ConfirmNewPwd =>  Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[3]/input"));
            private static IWebElement SaveBtn =>  Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[4]/button"));
        #region change password
        internal void changePassword()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "SignIn");
            //Click on Name
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span", 10000);
            NameBtn.Click();

            //Click on change password
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span/div/a[2]", 10000);
            ChgPwdBtn.Click();

            //Enter old password
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "/html/body/div[4]/div/div[2]/form/div[1]/input", 10000);
            CurrentPwd.Click();
            CurrentPwd.SendKeys(ExcelLibHelper.ReadData(2, "Password"));


            //Enter new password
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "/html/body/div[4]/div/div[2]/form/div[2]/input", 10000);
            NewPwd.Click();
            NewPwd.SendKeys(ExcelLibHelper.ReadData(2, "NewPassword"));

            //Confirm new password
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "/html/body/div[4]/div/div[2]/form/div[3]/input", 10000);
            ConfirmNewPwd.Click();
            ConfirmNewPwd.SendKeys(ExcelLibHelper.ReadData(2, "NewPassword"));
            Thread.Sleep(1000);
        }

        internal void SavePassword()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Change Password");
                //Click on save button
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "/html/body/div[4]/div/div[2]/form/div[4]/button", 10000);
                SaveBtn.Click();
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Password changed Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "PasswordChanged");

            }
            catch
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
            }
        }
        #endregion

        #region set old password
        internal void SetPassword()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "SignIn");
            //Click on Name
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span", 10000);
            NameBtn.Click();

            //Click on change password
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span/div/a[2]", 10000);
            ChgPwdBtn.Click();
            Thread.Sleep(1000);
            //Enter old password
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "/html/body/div[4]/div/div[2]/form/div[1]/input", 10000);
            CurrentPwd.Click();
            CurrentPwd.SendKeys(ExcelLibHelper.ReadData(2, "NewPassword"));


            //Enter new password
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "/html/body/div[4]/div/div[2]/form/div[2]/input", 10000);
            NewPwd.Click();
            NewPwd.SendKeys(ExcelLibHelper.ReadData(2, "Password"));

            //Confirm new password
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "/html/body/div[4]/div/div[2]/form/div[3]/input", 10000);
            ConfirmNewPwd.Click();
            ConfirmNewPwd.SendKeys(ExcelLibHelper.ReadData(2, "Password"));
            Thread.Sleep(1000);

        }

        internal void SaveSetPassword()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Set old Password");
                //Click on save button
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "/html/body/div[4]/div/div[2]/form/div[4]/button", 10000);
                SaveBtn.Click();
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Password set Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "SetPassword");
            }
            catch
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
            }
        }
        #endregion
    }
}
