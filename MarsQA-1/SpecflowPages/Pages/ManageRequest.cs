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

namespace MarsQA_1.SpecflowPages.Pages
{
    class ManageRequest
    {
            private static IWebElement ManageReqTab =>  Driver.driver.FindElement(By.XPath("//div[text()='Manage Requests']"));
            private static IWebElement ReceivedReqSel =>  Driver.driver.FindElement(By.LinkText("Received Requests"));
            private static IWebElement AcceptRequest =>  Driver.driver.FindElement(By.XPath("//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[1]"));
            private static IWebElement DeclineRequest =>  Driver.driver.FindElement(By.XPath("//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[2]"));
            private static IWebElement CompleteRequest =>  Driver.driver.FindElement(By.XPath("//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/button"));


            private static IWebElement SentReqstSel =>  Driver.driver.FindElement(By.LinkText("Sent Requests"));
            private static IWebElement Searchicon =>  Driver.driver.FindElement(By.XPath("//*[@id='sent-request-section']/div[1]/div[1]/i"));
            private static IWebElement SearchNameicon =>  Driver.driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[1]/input"));
            private static IWebElement SearchName =>  Driver.driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div[1]/div/span"));
            private static IWebElement SelName =>  Driver.driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[last()]/a/img"));
            private static IWebElement textArea =>  Driver.driver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div/div[1]/textarea"));
            private static IWebElement SelRequest =>  Driver.driver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div/div[3]"));
            private static IWebElement Yes =>  Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[3]/button[1]"));

        #region Received request
        internal void ManageRequests()
        {
            //Click on ManageRequest Tab
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[text()='Manage Requests']", 10000);
            ManageReqTab.Click();
        }

        internal void ReceviedRequests()
        {
            //Select Recieved Request
            WaitHelpers.WaitForElementVisibility(Driver.driver, "LinkText", "Received Requests", 10000);
            ReceivedReqSel.Click();

        }

        internal void ResponseRequests()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ManageRequest");
            // Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.extent.StartTest("Accept Or Decline");
            //Accept or Declane request

            if (ExcelLibHelper.ReadData(2, "ReceviedRequest") == "Accept")
            {
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[1]", 10000);
                AcceptRequest.Click();
            }
            else if (ExcelLibHelper.ReadData(2, "ReceviedRequest") == "Decline")
            {
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[2]", 10000);
                DeclineRequest.Click();

            }

            //Complete request
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='received-request-section']/div[2]/div[1]/table/tbody/tr[3]/td[8]/button", 10000);
            CompleteRequest.Click();
            CommonMethods.test.Log(LogStatus.Info, "Responded to received request successfully");
        }


        #endregion

        #region Sent request
        internal void MangRequests()
        {
            //Click on manage request tab
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[text()='Manage Requests']", 10000);
            ManageReqTab.Click();
        }

        internal void SentRequests()
        {
            //Click on sent request
            WaitHelpers.WaitForElementVisibility(Driver.driver, "LinkText", "Sent Requests", 10000);
            SentReqstSel.Click();
        }

        internal void SentARequest()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ManageRequest");
            // Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.extent.StartTest("Sent Request");

            //Click on search icon
            Searchicon.Click();
            Thread.Sleep(1000);
            //Enter name
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[1]/input", 10000);
            SearchNameicon.SendKeys(ExcelLibHelper.ReadData(2, "SearchName"));
            //SearchNameicon.SendKeys("kimi wang");
            Thread.Sleep(1000);

            //Select name
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div[1]/div/span", 10000);
            SearchName.Click();

            //Click on image
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-search-section']/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[last()]/a/img", 10000);
            SelName.Click();

            //Enter text data
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-detail-section']/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div/div[1]/textarea", 10000);
            SearchNameicon.SendKeys(ExcelLibHelper.ReadData(2, "Text"));
            //textArea.SendKeys("I am interested on your skills");

            //Click on request
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-detail-section']/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div/div[3]", 10000);
            SelRequest.Click();
            Thread.Sleep(1000);

            //select ok
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "/html/body/div[4]/div/div[3]/button[1]", 10000);
            Yes.Click();
            CommonMethods.test.Log(LogStatus.Info, "Request sent successfully");
        }
        #endregion

    }
}
