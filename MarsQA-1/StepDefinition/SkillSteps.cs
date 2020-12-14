using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public sealed class SkillSteps
    {
        //Add Skill
        [Given(@"User try to add new Skill on profile page")]
        public void GivenUserTryToAddNewSkillOnProfilePage()
        {
            //Add Skill
            Skill skillobj = new Skill();
            skillobj.EnterSkill();
            
        }
        [When(@"User click on Add Skill button")]
        public void WhenUserClickOnAddSkillButton()
        {
            //Add Skill
            Skill skillobj = new Skill();
            skillobj.AddSkills();
           
        }
        [Then(@"User should able to add new skill successfully")]
        public void ThenUserShouldAbleToAddNewSkillSuccessfully()
        {
            //Verify added Skill
            Skill skillobj = new Skill();
            skillobj.VerifySkill();
        }

        //Edit skill
        [Given(@"User try to edit the Skill record")]
        public void GivenUserTryToEditTheSkillRecord()
        {
            //Edit Skill
            Skill skillobj = new Skill();
            skillobj.EditSkills();
            

        }
        [When(@"User click on update skill button")]
        public void WhenUserClickOnUpdateSkillButton()
        {
            //Edit Skill
            Skill skillobj = new Skill();
            skillobj.UpodateSkills();
           
        }
        [Then(@"User should able to edit skill successfully")]
        public void ThenUserShouldAbleToEditSkillSuccessfully()
        {
            //Verify Edited Skill
            Skill skillobj = new Skill();
            skillobj.VerifyEditedSkill();
        }


        //Delete Skill
        [Given(@"User should able to Delete Skill sucessfully")]
        public void GivenUserShouldAbleToDeleteSkillSucessfully()
        {
            //Delete Skill
            Skill skillobj = new Skill();
            skillobj.DeleteSkill();

        }

    }
}
