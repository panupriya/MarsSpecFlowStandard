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
    class Notification
    {
            private static IWebElement ClickNotification => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/div"));
            private static IWebElement ClickSeeAll => Driver.driver.FindElement(By.LinkText("See All..."));
            private static IWebElement SelectAll => Driver.driver.FindElement(By.XPath("//div[@data-tooltip='Select all']"));
            private static IWebElement UnSelectAll => Driver.driver.FindElement(By.XPath("//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[2]"));
            private static IWebElement SelectOne => Driver.driver.FindElement(By.XPath("//*[@id='notification-section']/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input"));
            private static IWebElement MarkSelection => Driver.driver.FindElement(By.XPath("//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[4]"));
            private static IWebElement Delete => Driver.driver.FindElement(By.XPath("//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[3]/i"));

        #region notification
        internal void Notifications()
        {
            //Click on Notification tab
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[2]/div/div", 10000);
            ClickNotification.Click();
        }

        internal void NotificationSellAll()
        {
            //Click on See all
            WaitHelpers.WaitForElementVisibility(Driver.driver, "LinkText", "See All...", 10000);
            ClickSeeAll.Click();
        }

        internal void NotificationSelectAll()
        {
            //Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.extent.StartTest("Notification Select All");
            //Click on select all
            // Wait 
            WaitHelpers.WaitForElementClickable(Driver.driver, "XPath", "//*[@id='notification-section']//" +
                "div[last()-1]/div/div/div[3]/input", 1000);
            // GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@data-tooltip='Select all']", 10000);
            SelectAll.Click();
            Thread.Sleep(1000);
            CommonMethods.test.Log(LogStatus.Info, "Successfully selected all notifications");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "SelectAllNotification");
        }

        internal void NotificationUnSelectAll()
        {
            //Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.extent.StartTest("UnSelect All");
            //UnSelect All
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[2]", 10000);
            UnSelectAll.Click();
            CommonMethods.test.Log(LogStatus.Info, "Successfully Unselected all notifications");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "UnSelectAllNotification");
        }

        
        internal void NotificationSelect()
        {
            //Select one
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='notification-section']/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input", 10000);
            SelectOne.Click();
        }


        internal void NotificationMark()
        {
            //Mark Selction as read
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[4]", 10000);
            MarkSelection.Click();
        }

        internal void NotificationDelete()
        {
            //Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.extent.StartTest("Delete Notification");
            //Delete Notification
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[3]/i", 10000);
            Delete.Click();
            Thread.Sleep(2000);
            CommonMethods.test.Log(LogStatus.Info, "Delete notification successfull");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "NotificationDelete");
        }
        #endregion
    }
}
