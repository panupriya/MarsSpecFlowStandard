using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
    class Certification
    {
            //Add Certification
            private static IWebElement CertificationBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            private static IWebElement AddNewCertiBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            private static IWebElement CertifiBtn =>  Driver.driver.FindElement(By.Name("certificationName"));
            private static IWebElement CertifiName =>  Driver.driver.FindElement(By.Name("certificationName"));
            private static IWebElement CertiFromBtn =>  Driver.driver.FindElement(By.Name("certificationFrom"));
            private static IWebElement CertifiFrom =>  Driver.driver.FindElement(By.Name("certificationFrom"));
            private static IWebElement CertiYear =>  Driver.driver.FindElement(By.Name("certificationYear"));
            private static IWebElement AddCerBtn =>  Driver.driver.FindElement(By.XPath("//input[@value='Add']"));

            //Edit Certification
            private static IWebElement CertiToSel =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            private static IWebElement EditCertiBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i"));
            private static IWebElement UpdateCertiBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));

            //Delete Certification
            private static IWebElement DeleteCertiBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]"));

        #region Add Certification
        internal void EnterCertification()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();

            //Click on Certifications
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10000);
            CertificationBtn.Click();

            //Click on add new certifications
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div", 10000);
            AddNewCertiBtn.Click();

            //Input Certification
            WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "certificationName", 10000);
            CertifiBtn.Click();
            CertifiName.SendKeys(ExcelLibHelper.ReadData(2, "Certificate"));

            //Input certification from
            WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "certificationFrom", 10000);
            CertiFromBtn.Click();
            CertifiFrom.SendKeys(ExcelLibHelper.ReadData(2, "CertifiedFrom"));

            //Select year from drop down
            WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "certificationYear", 10000);
            CertiYear.Click();
            new SelectElement(CertiYear).SelectByText(ExcelLibHelper.ReadData(2, "YearOfCertification")); ;
            Thread.Sleep(1000);
        }

        internal void AddNewCertification()
        {
            //Click on add certification
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//input[@value='Add']", 10000);
            AddCerBtn.Click();
            
        }

        internal void VerifyCertification()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();

            //verify certification
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add Certification");
                //Jump to Certification tab

                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10000);
                CertificationBtn.Click();

                //Verify Certificate Name
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                var lastRowCertificateName = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;
                Assert.That(lastRowCertificateName, Is.EqualTo(ExcelLibHelper.ReadData(2, "Certificate")));

                //Verify Certificate Issuing Place
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]", 10000);
                var lastRowCertificateFrom = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
                Assert.That(lastRowCertificateFrom, Is.EqualTo(ExcelLibHelper.ReadData(2, "CertifiedFrom")));

                //Verify Certificate Year
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]", 10000);
                var lastRowCertificateYear = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]")).Text;
                Assert.That(lastRowCertificateYear, Is.EqualTo(ExcelLibHelper.ReadData(2, "YearOfCertification")));
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Certification Added Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "CertificationAdded");
            }
            catch (Exception ex)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", ex.Message);
            }

        }
        #endregion

        #region Edit Certification
        internal void EditCertification()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();

            //Click on certification
            //Click on Certifications
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10000);
            CertificationBtn.Click();

            //Click on certification to be edit
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
            CertiToSel.Click();

            //Click on edit certification button
           WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i", 10000);
            EditCertiBtn.Click();

            //Update certification
            WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "certificationYear", 10000);
            CertiYear.Click();
            new SelectElement(CertiYear).SelectByText(ExcelLibHelper.ReadData(3, "YearOfCertification")); ;
            Thread.Sleep(1000);
        }

        internal void UpdateCertification()
        {

            //Click on update certification button            
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]", 10000);
            UpdateCertiBtn.Click();
            
        }

        internal void VerifyEditedCertification()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();
            //verify updated certification
            //verify certification
            try
            {

                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Update Certification");


                //Jump to Certification tab
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10000);
                CertificationBtn.Click();

                //Verify Certificate Year
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]", 10000);
                var lastRowCertificateYear = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]")).Text;
                Assert.That(lastRowCertificateYear, Is.EqualTo(ExcelLibHelper.ReadData(3, "YearOfCertification")));
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Certification Updated Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "CertificationUpdated");
            }
            catch (Exception ex)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", ex.Message);
            }


        }
        #endregion

        #region Delete Certification
        internal void DeleteCertification()
        {
            // Refresh the page
            Driver.driver.Navigate().Refresh();

            //Delete Certification

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Delete Certification");
                //Click on certification
                //Click on Certifications
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10000);
                CertificationBtn.Click();

                //Click on certification to be deleted
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                CertiToSel.Click();

                //Click on delete certification button
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]", 20000);
                DeleteCertiBtn.Click();
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Certification Deleted Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "CertificationDeleted");

            }

            catch (Exception ex)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", ex.Message);
            }
        }
        #endregion
    }
}
