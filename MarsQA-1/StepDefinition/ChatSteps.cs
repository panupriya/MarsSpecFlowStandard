using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public sealed class ChatSteps
    {
        [Given(@"I go to chat tab")]
        public void GivenIGoToChatTab()
        {
            Chat ChatObj = new Chat();
            ChatObj.Chats();
        }
        [Given(@"I select the person to chat")]
        public void GivenISelectThePersonToChat()
        {
            Chat ChatObj = new Chat();
            ChatObj.ChatsUser();
        }
        [When(@"I enter and the details and click on sent")]
        public void WhenIEnterAndTheDetailsAndClickOnSent()
        {
            Chat ChatObj = new Chat();
            ChatObj.ChatsSent();
        }
        [Then(@"sent message should be successfull")]
        public void ThenSentMessageShouldBeSuccessfull()
        {
            Chat ChatObj = new Chat();
            ChatObj.SuccesfullChats();
        }

    }
}
