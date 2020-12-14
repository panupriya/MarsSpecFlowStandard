using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public sealed class EducationSteps
    {
        //Add Education
        [Given(@"User try to add new Education on profile page")]
        public void GivenUserTryToAddNewEducationOnProfilePage()
        {
            //Add Education
            Education eduobj = new Education();
            eduobj.EnterEducation();
           
        }
        [When(@"User click on Add Education button")]
        public void WhenUserClickOnAddEducationButton()
        {
            //Add Education
            Education eduobj = new Education();
            eduobj.AddEducation();
            
        }
        [Then(@"User should able to add new education successfully")]
        public void ThenUserShouldAbleToAddNewEducationSuccessfully()
        {
            //Add Education
            Education eduobj = new Education();
            eduobj.VerifyEducation();
        }

        //Edit Education
        [Given(@"User try to edit the Education record")]
        public void GivenUserTryToEditTheEducationRecord()
        {
            //Edit Education
            Education eduobj = new Education();
            eduobj.EditEducation();
           
        }
        [When(@"User click on update Education button")]
        public void WhenUserClickOnUpdateEducationButton()
        {
            //Edit Education
            Education eduobj = new Education();
            eduobj.UpdateEducation();
            
        }
        [Then(@"User should able to edit education successfully")]
        public void ThenUserShouldAbleToEditEducationSuccessfully()
        {
            //Edit Education
            Education eduobj = new Education();
            eduobj.VerifyEditedEducation();
        }

        //Delete Education
        [Given(@"User should able to Delete Education sucessfully")]
        public void GivenUserShouldAbleToDeleteEducationSucessfully()
        {
            //Delete Education details
            Education eduobj = new Education();
            eduobj.DeleteEducation();
        }

    }
}
