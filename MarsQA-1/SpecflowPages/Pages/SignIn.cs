using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Pages
{
    public static class SignIn
    {
        private static IWebElement SignInBtn =>  Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("//INPUT[@type='password']"));
        private static IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
        #region SignIn
        public static void SigninStep()
        {
            Driver.NavigateUrl();
            SignInBtn.Click();
            Email.SendKeys(ExcelLibHelper.ReadData(2,"Username"));
            Password.SendKeys(ExcelLibHelper.ReadData(2, "Password"));
            LoginBtn.Click();

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("SignIn to Mars");

                WaitHelpers.WaitForElement(Driver.driver, "XPath", "//*[contains(text(),'Ishaan Sandeep')]", 10000);
                // check login is successfull
                var loginCheck = "test";
                loginCheck = Driver.driver.FindElement(By.XPath("//*[contains(text(),'Ishaan Sandeep')]")).GetAttribute("innerText");

                if (loginCheck == "Ishaan Sandeep")
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Login Passed");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Login Passed");
                    Assert.IsTrue(true);
                }
                else 
                {
                    CommonMethods.test.Log(LogStatus.Fail, "Login failed");
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
               

            }
        }
        #endregion

    }
}