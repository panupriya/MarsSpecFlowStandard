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
    class Skill
    {
            //Add Skill
             private static IWebElement SkillBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
             private static IWebElement AddNewSkillBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
             private static IWebElement AddSkillBox =>  Driver.driver.FindElement(By.Name("name"));
             private static IWebElement AddSkill =>  Driver.driver.FindElement(By.Name("name"));
             private static IWebElement AddSkillLevel =>  Driver.driver.FindElement(By.Name("level"));
             private static IWebElement AddSkillBtn =>  Driver.driver.FindElement(By.XPath("//input[@value='Add']"));

            //Edit Skill
             private static IWebElement SkillToSel =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
             private static IWebElement EditSkill =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
             private static IWebElement UpdateSkillBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
             

            //Delete Skill
             private static IWebElement DeleteSkillBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            
        #region Add Skill
        internal void EnterSkill()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();
            //Click on skill
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 10000);
            SkillBtn.Click();

            //Click on add new skill
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 10000);
            AddNewSkillBtn.Click();

            //Add new skill

            WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "name", 10000);
            AddSkillBox.Click();
            AddSkill.SendKeys(ExcelLibHelper.ReadData(2, "Skill"));

            //Add skill level
            AddSkillLevel.Click();
            new SelectElement(AddSkillLevel).SelectByText(ExcelLibHelper.ReadData(2, "SkillLevel"));
        }

        internal void AddSkills()
        {
            //Click on add skill
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//input[@value='Add']", 10000);
            AddSkillBtn.Click();
            //CommonMethods.test.Log(LogStatus.Info, "Added skill successfully");
        }

        internal void VerifySkill()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();
            try
            {

                //Jump to Skill tab

                //Click on skill
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 10000);
                SkillBtn.Click();

                //Verify Skill Name
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                var lastRowSkillName = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;
                Assert.That(lastRowSkillName, Is.EqualTo(ExcelLibHelper.ReadData(2, "Skill")));

                //Verify Skill Level
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 10000);
                var lastRowSkillLevel = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
                Assert.That(lastRowSkillLevel, Is.EqualTo(ExcelLibHelper.ReadData(2, "SkillLevel")));
               //CommonMethods.test.Log(LogStatus.Pass, "Added skill verified successfully");
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to verify Entering Skills", ex.Message);
                //CommonMethods.test.Log(LogStatus.Fail, "Added skill is not verified successfully");
            }
        }
        #endregion

        #region Edit Skill
        internal void EditSkills()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();

            //Click on skill
            //Click on skill
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 10000);
            SkillBtn.Click();

            //Click on skill to be edited
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
            SkillToSel.Click();

            //Click on Edit skill
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i", 10000);
            EditSkill.Click();

            //Edit the skill
            //Add skill level
            WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "level", 10000);
            AddSkillLevel.Click();
            new SelectElement(AddSkillLevel).SelectByText(ExcelLibHelper.ReadData(3, "SkillLevel"));
        }

        internal void UpodateSkills()
        {
            //Click on update
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]", 10000);
            UpdateSkillBtn.Click();
            //CommonMethods.test.Log(LogStatus.Info, "Skill edited successfully");
        }

        internal void VerifyEditedSkill()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();
            //Verify updated skill
            try
            {

                //Jump to Skill tab

                //Click on skill
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 10000);
                SkillBtn.Click();

                //Verify Skill Level
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 10000);
                var lastRowSkillLevel = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
                Assert.That(lastRowSkillLevel, Is.EqualTo(ExcelLibHelper.ReadData(3, "SkillLevel")));
                //CommonMethods.test.Log(LogStatus.Pass, "Skill edited verified successfully");
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to verify updated Skills", ex.Message);
                //CommonMethods.test.Log(LogStatus.Fail, "Skill edited is not verified successfully");
            }
        }
        #endregion

        #region Delete Skill
        internal void DeleteSkill()
        {
            // Refresh the page
            Driver.driver.Navigate().Refresh();
            //Delete Skill

            try
            {

                //Click on skill
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 10000);
                SkillBtn.Click();

                //Click on skill to be deleted
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                SkillToSel.Click();

                //Click on Delete skill
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i", 20000);
                DeleteSkillBtn.Click();
                //CommonMethods.test.Log(LogStatus.Pass, "Skill deleted successfully");

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to Delete Skill", ex.Message);
                //CommonMethods.test.Log(LogStatus.Fail, "Skill is deleted successfully");
            }
        }
        #endregion
    }
}
