using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public sealed class NotificationSteps
    {
        [Given(@"I go to notification tab")]
        public void GivenIGoToNotificationTab()
        {
            Notification notifiObj = new Notification();
            notifiObj.Notifications();
        }
        [Given(@"I click on see all button")]
        public void GivenIClickOnSeeAllButton()
        {
            Notification notifiObj = new Notification();
            notifiObj.NotificationSellAll();
        }

        [Given(@"I click on select all button")]
        public void GivenIClickOnSelectAllButton()
        {
            Notification notifiObj = new Notification();
            notifiObj.NotificationSelectAll();
        }
        [Given(@"I click on unselect all button")]
        public void GivenIClickOnUnselectAllButton()
        {
            Notification notifiObj = new Notification();
            notifiObj.NotificationUnSelectAll();
        }
        [Given(@"I select one notification")]
        public void GivenISelectOneNotification()
        {
            Notification notifiObj = new Notification();
            notifiObj.NotificationSelect();
        }

        [When(@"I mark one selection as read")]
        public void WhenIMarkOneSelectionAsRead()
        {
            Notification notifiObj = new Notification();
            notifiObj.NotificationMark();
        }

       
        [Then(@"I should be able to delete notification successfully")]
        public void ThenIShouldBeAbleToDeleteNotificationSuccessfully()
        {
            Notification notifiObj = new Notification();
            notifiObj.NotificationDelete();
        }

    }
}
