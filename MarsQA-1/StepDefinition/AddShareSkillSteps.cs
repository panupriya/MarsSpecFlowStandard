using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public sealed class AddShareSkillSteps
    {
        [Given(@"I open Share Skill page")]
        public void GivenIOpenShareSkillPage()
        {
            //Add Share Skill
            ShareSkill shareSkillObj = new ShareSkill();
            shareSkillObj.GotoShareSkill();
            

        }
        [When(@"I list my Selenium skill for trade")]
        public void WhenIListMySeleniumSkillForTrade()
        {
            //Add Share Skill
            ShareSkill shareSkillObj = new ShareSkill();
            shareSkillObj.AddShareSkill();
           
        }
        [Then(@"Selenium is found in my managed listings")]
        public void ThenSeleniumIsFoundInMyManagedListings()
        {
            //Verify Share Skill
            ShareSkill shareSkillObj = new ShareSkill();
            shareSkillObj.VerifySkill();

        }


    }
}
