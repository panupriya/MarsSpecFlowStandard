using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public sealed class ManageListingSteps
    {
        //View listing
        [Given(@"I open Manage Listing page")]
        public void GivenIOpenManageListingPage()
        {
            //View Manage Listing
            ManageListing manageobj = new ManageListing();
            manageobj.Listings();

        }
        [When(@"I click on View button")]
        public void WhenIClickOnViewButton()
        {
            //View Manage Listing
            ManageListing manageobj = new ManageListing();
            manageobj.ListingsView();

        }
        [Then(@"I am able to see the listed skill")]
        public void ThenIAmAbleToSeeTheListedSkill()
        {
            //View Manage Listing
            ManageListing manageobj = new ManageListing();
            manageobj.ListingsVerify();
        }

        //Edit Listing
        [Given(@"I open the Manage Listing page")]
        public void GivenIOpenTheManageListingPage()
        {
            //Edit Manage Listing
            ManageListing manageobj = new ManageListing();
            manageobj.OpenListings();
            
        }

        [Given(@"I click on Edit button")]
        public void GivenIClickOnEditButton()
        {
            //Edit Manage Listing
            ManageListing manageobj = new ManageListing();
            manageobj.EditListings();
           
        }
        [When(@"I update my skill")]
        public void WhenIUpdateMySkill()
        { 
            //Edit Manage Listing
            ManageListing manageobj = new ManageListing();
            manageobj.EditDetails();

        }
        [Then(@"I should able to verify skill is updated successfully")]
        public void ThenIShouldAbleToVerifySkillIsUpdatedSuccessfully()
        {
            //Edit Manage Listing
            ManageListing manageobj = new ManageListing();
            manageobj.ValidateEditedDetails();
        }




        //Delete Listing
        [Given(@"I go to Manage Listing page")]
        public void GivenIGoToManageListingPage()
        {
            //Delete Manage Listing
            ManageListing manageobj = new ManageListing();
            manageobj.NavListings();
            
        }

        [When(@"I click on Delete button")]
        public void WhenIClickOnDeleteButton()
        {
            //Delete Manage Listing
            ManageListing manageobj = new ManageListing();
            manageobj.DeleteListings();
            
        }

        [Then(@"I Should able to verify listing is deleted successfully")]
        public void ThenIShouldAbleToVerifyListingIsDeletedSuccessfully()
        {
            //Delete Manage Listing
            ManageListing manageobj = new ManageListing();
            manageobj.ValidateDeletedDetails();
        }

    }
}
