using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Language
    {
        //Add Language
        private static IWebElement LangBtn =>  Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        private static IWebElement AddNewLangBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement AddLangText =>  Driver.driver.FindElement(By.Name("name"));
        private static IWebElement ChooseLang =>  Driver.driver.FindElement(By.Name("name"));
        private static IWebElement ChooseLevel =>  Driver.driver.FindElement(By.Name("level"));
        private static IWebElement AddLang =>  Driver.driver.FindElement(By.XPath("//input[@value='Add']"));

        //Edit Language
        private static IWebElement LangToSel =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        private static IWebElement EditLangBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
        private static IWebElement UpdateLangBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));

        //Delete Action
        private static IWebElement DeleteLangBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
       
        #region Add language
        internal void EnterLanguage()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");

            //Click on language add new
            LangBtn.Click();
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 10000);
            AddNewLangBtn.Click();

            //Add new language
            AddLangText.Click();
            ChooseLang.SendKeys(ExcelLibHelper.ReadData(2, "Language"));

            //Select language level
            ChooseLevel.Click();
            new SelectElement(ChooseLevel).SelectByText(ExcelLibHelper.ReadData(2, "LanguageLevel"));
        }

        internal void AddLanguage()
        {
            
            //Add Language
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//input[@value='Add']", 10000);
            AddLang.Click();
            //CommonMethods.test.Log(LogStatus.Info, "Added Language successfully");
        }

        internal void VerifyLanguage()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();
            //verify language
            try
            {
                //Verify Language Name
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 10000);
                LangBtn.Click();
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                var lastRowLanguageName = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;
                Assert.That(lastRowLanguageName, Is.EqualTo(ExcelLibHelper.ReadData(2, "Language")));

                //Verify Language Level
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 10000);
                var lastRowLanguageLevel = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
                Assert.That(lastRowLanguageLevel, Is.EqualTo(ExcelLibHelper.ReadData(2, "LanguageLevel")));
                //CommonMethods.test.Log(LogStatus.Pass, "Added Language verified successfully");
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to verify Entering Language", ex.Message);
                //CommonMethods.test.Log(LogStatus.Fail, "Added Language is not verified successfully");
            }
        }
        #endregion

        #region Edit language
        internal void EditLanguage()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();
            //Click on language
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 10000);
            LangBtn.Click();

            //Click on language to edit
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
            LangToSel.Click();

            //Click on edit language button
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i", 10000);
            EditLangBtn.Click();

            //Update the language
            //Update language level
            WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "level", 10000);
            ChooseLevel.Click();

            new SelectElement(ChooseLevel).SelectByText(ExcelLibHelper.ReadData(3, "LanguageLevel"));

           
        }

        internal void UpdateLanguage()
        {
            //Click on update
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]", 10000);
            UpdateLangBtn.Click();
            //CommonMethods.test.Log(LogStatus.Info, "Language edited successfully");
        }

        internal void VerifyEditedLanguage()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();

            //verify updated language
            try
            {
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 10000);
                LangBtn.Click();
                //Verify Language Level
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 10000);
                var lastRowLanguageLevel = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
                Assert.That(lastRowLanguageLevel, Is.EqualTo(ExcelLibHelper.ReadData(3, "LanguageLevel")));
                //CommonMethods.test.Log(LogStatus.Pass, "Language edited verified successfully");
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to update Language", ex.Message);
                //CommonMethods.test.Log(LogStatus.Fail, "Language edited is not verified successfully");
            }
        }

        #endregion

        #region Delete language
        internal void DeleteLanguage()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            try
            {
                //Click on language
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 10000);
                LangBtn.Click();

                //Click on language to delete
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                LangToSel.Click();

                //Click on delete language
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i", 20000);
                DeleteLangBtn.Click();
               // CommonMethods.test.Log(LogStatus.Pass, "Language deleted successfully");
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to delete Language", ex.Message);
                //CommonMethods.test.Log(LogStatus.Fail, "Language is not deleted successfully");
            }
        }

        #endregion
    }
}
