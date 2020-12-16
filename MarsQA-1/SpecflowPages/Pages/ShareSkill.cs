using AutoIt;
using AutoItX3Lib;
using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ShareSkill
    {
            private static IWebElement ShareSkillButton =>  Driver.driver.FindElement(By.LinkText("Share Skill"));
            private static IWebElement Title =>  Driver.driver.FindElement(By.Name("title"));
            private static IWebElement Description =>  Driver.driver.FindElement(By.Name("description"));
            private static IWebElement CategoryDropDown =>  Driver.driver.FindElement(By.Name("categoryId"));
            private static IWebElement SubCategoryDropDown =>  Driver.driver.FindElement(By.Name("subcategoryId"));
            private static IWebElement Tags =>  Driver.driver.FindElement(By.XPath("//input[@value='']"));
            private static IWebElement ServiceTypeOptions =>  Driver.driver.FindElement(By.XPath("//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']"));
            private static IWebElement ServicetypeHourly =>  Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
            private static IWebElement ServicetypeOneOff =>  Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
            private static IWebElement LocationTypeOption =>  Driver.driver.FindElement(By.XPath("//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']"));
            private static IWebElement LocationSelOnsite =>  Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
            private static IWebElement LocationSelOnline =>  Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
            private static IWebElement StartDateDropDown =>  Driver.driver.FindElement(By.Name("startDate"));
            private static IWebElement EndDateDropDown =>  Driver.driver.FindElement(By.Name("endDate"));
            private static IWebElement Days =>  Driver.driver.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]"));
            private static IWebElement Mon =>  Driver.driver.FindElement(By.XPath("(//input[@name='Available'])[2]"));
            private static IWebElement Tue =>  Driver.driver.FindElement(By.XPath("(//input[@name='Available'])[3]"));
            private static IWebElement Wed =>  Driver.driver.FindElement(By.XPath("(//input[@name='Available'])[4]"));
            private static IWebElement Thurs =>  Driver.driver.FindElement(By.XPath("(//input[@name='Available'])[5]"));
            private static IWebElement StartTimeM =>  Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input"));
            private static IWebElement StartTimeDropDownM =>  Driver.driver.FindElement(By.XPath("(//input[@name='StartTime'])[2]"));
            private static IWebElement StartTimeT =>  Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input"));
            private static IWebElement StartTimeDropDownT =>  Driver.driver.FindElement(By.XPath("(//input[@name='StartTime'])[3]"));
            private static IWebElement StartTimeW =>  Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input"));
            private static IWebElement StartTimeDropDownW =>  Driver.driver.FindElement(By.XPath("(//input[@name='StartTime'])[4]"));
            private static IWebElement StartTimeTh =>  Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[2]/input"));            
            private static IWebElement StartTimeDropDownTh =>  Driver.driver.FindElement(By.XPath("(//input[@name='StartTime'])[5]"));
            private static IWebElement EndTimeM =>  Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input"));
            private static IWebElement EndTimeDropDownM =>  Driver.driver.FindElement(By.XPath("(//input[@name='EndTime'])[2]"));
            private static IWebElement EndTimeT =>  Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input"));
            private static IWebElement EndTimeDropDownT =>  Driver.driver.FindElement(By.XPath("(//input[@name='EndTime'])[3]"));
            private static IWebElement EndTimeW =>  Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input"));
            private static IWebElement EndTimeDropDownW =>  Driver.driver.FindElement(By.XPath("(//input[@name='EndTime'])[4]"));
            private static IWebElement EndTimeTh =>  Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[3]/input"));
            private static IWebElement EndTimeDropDownTh =>  Driver.driver.FindElement(By.XPath("(//input[@name='EndTime'])[5]"));
            private static IWebElement SkillTradeOption =>  Driver.driver.FindElement(By.XPath("//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']"));
            private static IWebElement SkillExchange =>  Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
            private static IWebElement CreditBtn =>  Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
            private static IWebElement CreditAmount =>  Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input                                                                           "));
            private static IWebElement FileUpload =>  Driver.driver.FindElement(By.XPath("//i[@class='huge plus circle icon padding-25']"));
            private static IWebElement ActiveOption =>  Driver.driver.FindElement(By.XPath("//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']"));
            private static IWebElement HiddenOpt =>  Driver.driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input"));
            private static IWebElement Save =>  Driver.driver.FindElement(By.XPath("//input[@value='Save']"));
            private static IWebElement Cancel =>  Driver.driver.FindElement(By.XPath("//input[@value='Cancel']"));
            private static IWebElement ManageLis =>  Driver.driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[2]/button[2]"));




        #region Add Shareskill

        internal void GotoShareSkill()
        {
            // Click on Share skill button
            WaitHelpers.WaitForElementVisibility(Driver.driver, "LinkText", "Share Skill", 10000);
            ShareSkillButton.Click();
        }

        internal void AddShareSkill()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ShareSkill");
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add ShareSkill");

               

                #region Enter Title 
                //Enter the Title in textbox
                WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "title", 10000);
                Title.Click();
                Title.Clear();
                Title.SendKeys(ExcelLibHelper.ReadData(2, "Title"));
                #endregion

                #region Enter Description
                //Enter the Description in textbox
                WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "description", 10000);
                Description.Click();
                Description.Clear();
                Description.SendKeys(ExcelLibHelper.ReadData(2, "Description"));
                #endregion

                #region Category Drop Down
                //Select catagory from drop down
                WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "categoryId", 10000);
                CategoryDropDown.Click();
                new SelectElement(CategoryDropDown).SelectByText(ExcelLibHelper.ReadData(2, "Category"));

                //Select catagory from drop down
                WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "subcategoryId", 10000);
                SubCategoryDropDown.Click();
                new SelectElement(SubCategoryDropDown).SelectByText(ExcelLibHelper.ReadData(2, "SubCategory"));
                #endregion

                #region Tags
                //Enter Tag names in textbox
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//input[@value='']", 10000);
                Tags.Click();
                Tags.Clear();
                Tags.SendKeys(ExcelLibHelper.ReadData(2, "Tags"));
                Tags.SendKeys(Keys.Enter);
                #endregion

                #region Service Type Selection
                //Select service type
                if (ExcelLibHelper.ReadData(2, "ServiceType") == "Hourly basis service")
                {
                    WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']", 10000);
                    ServiceTypeOptions.Click();
                    ServicetypeHourly.Click();
                }
                else if (ExcelLibHelper.ReadData(2, "ServiceType") == "One-off service")
                {
                   WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']", 10000);
                    ServiceTypeOptions.Click();
                    ServicetypeOneOff.Click();
                }
                #endregion

                #region Select Location Type
                //Select the Location Type
                if (ExcelLibHelper.ReadData(2, "LocationType") == "On-site")
                {
                    WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']", 10000);
                    LocationTypeOption.Click();
                    LocationSelOnsite.Click();
                }
                else if (ExcelLibHelper.ReadData(2, "LocationType") == "Online")
                {
                    WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']", 10000);
                    LocationTypeOption.Click();
                    LocationSelOnline.Click();
                }

                #endregion


                #region Select Available Dates from Calendar
                //Add start date
                StartDateDropDown.Click();
                // StartDateDropDown.Clear();
                //StartDateDropDown.SendKeys(ExcelLibHelper.ReadData(2, "Startdate"));
                StartDateDropDown.SendKeys("01/01/2021");
                //Add End date
                EndDateDropDown.Click();
                //EndDateDropDown.Clear();
                //EndDateDropDown.SendKeys(ExcelLibHelper.ReadData(2, "Enddate"));
                EndDateDropDown.SendKeys("01/10/2021");

                //Select available days
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]", 10000);
                Days.Click();
                Mon.Click();
                Tue.Click();
                Wed.Click();
                Thurs.Click();

                //Select start time and enter the time
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input", 10000);
                StartTimeM.Click();

                StartTimeDropDownM.Click();

                StartTimeM.SendKeys(DateTime.Parse(ExcelLibHelper.ReadData(2, "Starttime")).ToString("hh:mmtt"));

                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input", 10000);
                StartTimeT.Click();

                StartTimeDropDownT.Click();

                StartTimeT.SendKeys(DateTime.Parse(ExcelLibHelper.ReadData(2, "Starttime")).ToString("hh:mmtt"));

                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input", 10000);
                StartTimeW.Click();

                StartTimeDropDownW.Click();

                StartTimeW.SendKeys(DateTime.Parse(ExcelLibHelper.ReadData(2, "Starttime")).ToString("hh:mmtt"));

                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[2]/input", 10000);
                StartTimeTh.Click();

                StartTimeDropDownTh.Click();

                StartTimeTh.SendKeys(DateTime.Parse(ExcelLibHelper.ReadData(2, "Starttime")).ToString("hh:mmtt"));



                //Select end time from box
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input", 10000);
                EndTimeM.Click();

                EndTimeDropDownM.Click();

                EndTimeM.SendKeys(DateTime.Parse(ExcelLibHelper.ReadData(2, "Endtime")).ToString("hh:mmtt"));

                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input", 10000);
                EndTimeT.Click();

                EndTimeDropDownT.Click();

                EndTimeT.SendKeys(DateTime.Parse(ExcelLibHelper.ReadData(2, "Endtime")).ToString("hh:mmtt"));

                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input", 10000);
                EndTimeW.Click();

                EndTimeDropDownW.Click();

                EndTimeW.SendKeys(DateTime.Parse(ExcelLibHelper.ReadData(2, "Endtime")).ToString("hh:mmtt"));

                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[3]/input", 10000);
                EndTimeTh.Click();

                EndTimeDropDownTh.Click();

                EndTimeTh.SendKeys(DateTime.Parse(ExcelLibHelper.ReadData(2, "Endtime")).ToString("hh:mmtt"));
                Thread.Sleep(1000);
                #endregion

                #region Select Skill Trade
                //Click on Skill trade option

                if (ExcelLibHelper.ReadData(2, "SkillTrade") == "Skill-Exchange")
                {
                    WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//form/div[8]/div[@class='twelve wide column']/div/div[@class='field']", 10000);
                    SkillTradeOption.Click();

                    //Add Skill exchange tag
                    WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input", 10000);
                    SkillExchange.Click();
                    SkillExchange.Clear();
                    SkillExchange.SendKeys(ExcelLibHelper.ReadData(2, "Skill-Exchange"));
                    SkillExchange.SendKeys(Keys.Enter);


                }
                else if (ExcelLibHelper.ReadData(2, "SkillTrade") == "Credit")
                {

                    WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//form/div[8]/div[@class='twelve wide column']/div/div[@class='field']", 10000);
                    SkillTradeOption.Click();
                    CreditBtn.Click();

                    //Addcredit amount
                    WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input", 10000);
                    CreditAmount.Click();
                    CreditAmount.Clear();
                    CreditAmount.SendKeys(ExcelLibHelper.ReadData(2, "AmountInExchange"));
                    CreditAmount.SendKeys(Keys.Enter);
                }

                #endregion

                #region Add Work Sample


                FileUpload.Click();

                AutoItX3 autoIt = new AutoItX3();
                AutoItX.WinWait("Open", "File Upload", 1);
                autoIt.WinActivate("Open");
                Thread.Sleep(2000);
                var SampleWorkPath = ConstantHelpers.SampleWorkPath;
                autoIt.Send(Path.GetFullPath(SampleWorkPath));
                Thread.Sleep(2000);
                autoIt.Send("{Enter}");
                Thread.Sleep(5000);



                #endregion

                #region Select User Status
                //Select option Active or Hidden
                if (ExcelLibHelper.ReadData(2, "UserStatus") == "Active")
                {
                    WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']", 10000);
                    ActiveOption.Click();
                }
                else if (ExcelLibHelper.ReadData(2, "UserStatus") == "Hidden")
                {
                    WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']", 10000);
                    ActiveOption.Click();
                    HiddenOpt.Click();

                }
                Thread.Sleep(1000);
                #endregion


                #region Save / Cancel Skill
                // Save or Cancel New Skill

                if (ExcelLibHelper.ReadData(2, "SaveOrCancel") == "Save")
                {
                    WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//input[@value='Save']", 10000);
                    Save.Click();
                }
                else if (ExcelLibHelper.ReadData(2, "SaveOrCancel") == "Cancel")
                {
                    Cancel.Click();
                }
                #endregion
                Thread.Sleep(1000);
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, ShareSkill Added Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "ShareSkillAdded");
            }

            catch (Exception ex)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", ex.Message);
            }


        }

        internal void VerifySkill()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ShareSkill");
            //Verify share skill details

           WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[2]/button[2]", 10000);
            ManageLis.Click();
            Driver.driver.Navigate().Refresh();
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Verify ShareSkill");

                WaitHelpers.WaitForElement(Driver.driver, "XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]", 10000);
                var categorycheck = Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]")).GetAttribute("textContent");
                Assert.That(categorycheck, Is.EqualTo(ExcelLibHelper.ReadData(2, "Category")));

                WaitHelpers.WaitForElement(Driver.driver, "XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]", 10000);
                var titlecheck = Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]")).GetAttribute("textContent");
                Assert.That(titlecheck, Is.EqualTo(ExcelLibHelper.ReadData(2, "Title")));
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, ShareSkill Verified Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "ShareSkillVerified");
            }
            catch (Exception ex)
            {

                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", ex.Message);
            }
        }
        #endregion
    }
}
