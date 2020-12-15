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
    class Education
    {
            //Add Education
             private static IWebElement EducationBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
             private static IWebElement AddNewEducationBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
             private static IWebElement SelectCountry =>  Driver.driver.FindElement(By.Name("country"));
             private static IWebElement SelectTitle =>  Driver.driver.FindElement(By.Name("title"));
             private static IWebElement YearOfGraduation =>  Driver.driver.FindElement(By.Name("yearOfGraduation"));
             private static IWebElement InstitName =>  Driver.driver.FindElement(By.Name("instituteName"));
             private static IWebElement Degree =>  Driver.driver.FindElement(By.Name("degree"));
             private static IWebElement AddEdu =>  Driver.driver.FindElement(By.XPath("//input[@value='Add']"));

            //Edit Education
             private static IWebElement EduToSel =>  Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
             private static IWebElement EditEduBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]/i"));
             private static IWebElement UpdateEduBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));

            //Delete Education
             private static IWebElement DeleteEduBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]/i"));
        #region Add Education
        internal void EnterEducation()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();
            //Click on Education button
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 10000);
            EducationBtn.Click();

            //Click on add new education
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div", 10000);
            AddNewEducationBtn.Click();

            //Choose country
            WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "country", 10000);
            SelectCountry.Click();
            new SelectElement(SelectCountry).SelectByText(ExcelLibHelper.ReadData(2, "Country"));

            //Choose title
            WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "title", 10000);
            SelectTitle.Click();
            new SelectElement(SelectTitle).SelectByText(ExcelLibHelper.ReadData(2, "Title"));

            //Choose year
            WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "yearOfGraduation", 10000);
            YearOfGraduation.Click();
            new SelectElement(YearOfGraduation).SelectByText(ExcelLibHelper.ReadData(2, "YearOfGraduation"));

            //Choose institute name
            WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "instituteName", 10000);
            InstitName.SendKeys(ExcelLibHelper.ReadData(2, "University"));

            //Choose degree
            WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "degree", 10000);
            Degree.SendKeys(ExcelLibHelper.ReadData(2, "Degree"));
            Thread.Sleep(1000);
        }
       

        internal void AddEducation()
        {

            //Click on add education
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//input[@value='Add']", 10000);
            AddEdu.Click();
            
        }

        internal void VerifyEducation()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            //// Refresh the page
            //Driver.driver.Navigate().Refresh();
            //verify education
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add Education");

                //Jump to Education tab
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 10000);
                EducationBtn.Click();

                //Verify Education Country
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                var lastRowEducationCountry = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;
                Assert.That(lastRowEducationCountry, Is.EqualTo(ExcelLibHelper.ReadData(2, "Country")));

                //Verify Education Name
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 10000);
                var lastRowEducationName = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
                Assert.That(lastRowEducationName, Is.EqualTo(ExcelLibHelper.ReadData(2, "University")));

                //Verify Education Title
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]", 10000);
                var lastRowEducationTitle = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]")).Text;
                Assert.That(lastRowEducationTitle, Is.EqualTo(ExcelLibHelper.ReadData(2, "Title")));

                //Verify Education Degree
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]", 10000);
                var lastRowEducationDegree = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]")).Text;
                Assert.That(lastRowEducationDegree, Is.EqualTo(ExcelLibHelper.ReadData(2, "Degree")));

                //Verify Education Graduation Year
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[5]", 10000);
                var lastRowEducationGraduationYear = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[5]")).Text;
                Assert.That(lastRowEducationGraduationYear, Is.EqualTo(ExcelLibHelper.ReadData(2, "YearOfGraduation")));
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Education Added Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationAdded");
            }
            catch (Exception ex)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", ex.Message);

            }

        }
        #endregion

        #region Edit Education
        internal void EditEducation()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();

            //Click on education
            //Click on Education button
           WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 10000);
            EducationBtn.Click();

            //Click on education to be edit
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
            EduToSel.Click();

            //Click on edit education button
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]/i", 10000);
            EditEduBtn.Click();

            //Update education
            WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "title", 10000);
            SelectTitle.Click();
            new SelectElement(SelectTitle).SelectByText(ExcelLibHelper.ReadData(3, "Title"));
            Thread.Sleep(1000);
        }

        internal void UpdateEducation()
        {
            //Click on update education button 
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]", 10000);

            UpdateEduBtn.Click();
           
        }

        internal void VerifyEditedEducation()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();


            //verify updated education
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Updated Education");

                //Jump to Education tab
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 10000);
                EducationBtn.Click();

                //Verify Education Title
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]", 10000);
                var lastRowEducationTitle = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]")).Text;
                Assert.That(lastRowEducationTitle, Is.EqualTo(ExcelLibHelper.ReadData(3, "Title")));
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Education Updated Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationUpdated");
            }
            catch (Exception ex)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", ex.Message);

            }
        }
        #endregion

        #region Delete Education
        internal void DeleteEducation()
        {
            // Refresh the page
            Driver.driver.Navigate().Refresh();
            //Delete Education
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Delete Education");

                //Click on education
                //Click on Education button
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 10000);
                EducationBtn.Click();

                //Click on education to be deleted
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                EduToSel.Click();

                //Click on  delete education button
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]/i", 20000);
                DeleteEduBtn.Click();
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Education Deleted Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationDeleted");

            }
            catch (Exception ex)
            {

                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", ex.Message);
            }
        }
        #endregion
    }
}
