using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public sealed class ManageRequestSteps
    {

        //Received request
        [Given(@"I go to Manage Request tab")]
        public void GivenIGoToManageRequestTab()
        {
            ManageRequest manageRequest = new ManageRequest();
            manageRequest.ManageRequests();
        }
        [When(@"I click on Received Request")]
        public void WhenIClickOnReceivedRequest()
        {
            ManageRequest manageRequest = new ManageRequest();
            manageRequest.ReceviedRequests();
        }
        [Then(@"I am able to accept or decline request")]
        public void ThenIAmAbleToAcceptOrDeclineRequest()
        {
            ManageRequest manageRequest = new ManageRequest();
            manageRequest.ResponseRequests();
        }

        //Sent Request
        [Given(@"I navigate to Manage Request tab")]
        public void GivenINavigateToManageRequestTab()
        {
            ManageRequest manageRequest = new ManageRequest();
            manageRequest.MangRequests();
        }
        [When(@"I click on Sent Request")]
        public void WhenIClickOnSentRequest()
        {
            ManageRequest manageRequest = new ManageRequest();
            manageRequest.SentRequests();
        }
        [Then(@"I am able to sent request")]
        public void ThenIAmAbleToSentRequest()
        {
            ManageRequest manageRequest = new ManageRequest();
            manageRequest.SentARequest();
        }
                                                                                                                                                                                                                                    
    }
}
