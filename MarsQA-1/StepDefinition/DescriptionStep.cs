using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public sealed class DescriptionStep
    {
        //Add description
        [Given(@"User try to add Description")]
        public void GivenUserTryToAddDescription()
        {
            //Add description
            Description descriobj = new Description();
            descriobj.EnterDescription();
           
        }
        [Then(@"User should able to add Description successfully")]
        public void ThenUserShouldAbleToAddDescriptionSuccessfully()
        {
            //verify description
            Description descriobj = new Description();
            descriobj.VerifyDescription();
        }


        //Edit description
        [Given(@"User try to edit Description")]
        public void GivenUserTryToEditDescription()
        {
            //Edit description
            Description descriobj = new Description();
            descriobj.EditDescription();
           
        }
        [Then(@"User should able to edit Description successfully")]
        public void ThenUserShouldAbleToEditDescriptionSuccessfully()
        {
            //Verify edited description
            Description descriobj = new Description();
            descriobj.VerifyEditedDescription();
        }

    }
}
