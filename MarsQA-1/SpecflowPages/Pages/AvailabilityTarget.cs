using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class AvailabilityTarget
    {
        private static IWebElement AvailabilityTimeEdit  =>  Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
        private static IWebElement AvailabilityTime =>  Driver.driver.FindElement(By.Name("availabiltyType"));
        private static IWebElement HourEdit =>  Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
        private static IWebElement AvailabilityHour =>  Driver.driver.FindElement(By.Name("availabiltyHour"));

        private static IWebElement SalaryEdit =>  Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
        private static IWebElement SalarySelect =>  Driver.driver.FindElement(By.Name("availabiltyTarget"));

        internal void EnterDetails()
        {
           
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");

            #region Availability
           
                //Click on availability edit
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i", 10000);
                AvailabilityTimeEdit.Click();

                //Click on availability dropdown
                AvailabilityTime.Click();

                WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "availabiltyType", 10000);
                //select availability time
                new SelectElement(AvailabilityTime).SelectByText(ExcelLibHelper.ReadData(2, "AvailableTime"));
                CommonMethods.test.Log(LogStatus.Info, "Select the available time");
           
            #endregion

            #region Hour

            //click on hour edit
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i", 10000);
            HourEdit.Click();

            //click on houredit dropdown
            AvailabilityHour.Click();

            WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "availabiltyHour", 10000);
            //select availability hour
            new SelectElement(AvailabilityHour).SelectByText(ExcelLibHelper.ReadData(2, "Hours"));
            CommonMethods.test.Log(LogStatus.Info, "Added hour successfully");

            #endregion

            #region EarnTarget
            //click on Target edit
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i", 10000);
            SalaryEdit.Click();

            //click on Target salary dropdown
            SalarySelect.Click();

            WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "availabiltyTarget", 10000);
            //select salary
            new SelectElement(SalarySelect).SelectByText(ExcelLibHelper.ReadData(2, "EarnTarget"));
            CommonMethods.test.Log(LogStatus.Info, "Added Target successfully");
            Thread.Sleep(1000);
            #endregion

        }
    }
}
