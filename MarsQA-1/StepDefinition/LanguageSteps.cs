using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public sealed class LanguageSteps
    {
        //Add language
        [Given(@"User try to add new Language on profile page")]
        public void GivenUserTryToAddNewLanguageOnProfilePage()
        {
          
            //Add profile
            Language Langobj = new Language();
            Langobj.EnterLanguage();
            
        }
        [When(@"User click on Add button")]
        public void WhenUserClickOnAddButton()
        {
            //Add profile
            Language Langobj = new Language();
            Langobj.AddLanguage();
        }
       
       [Then(@"User should able to add new language successfully")]
        public void ThenUserShouldAbleToAddNewLanguageSuccessfully()
        {
            //Add profile
            Language Langobj = new Language();
            Langobj.VerifyLanguage();
        }


        //Edit Language
        [Given(@"User try toedit the Language record")]
        public void GivenUserTryToeditTheLanguageRecord()
        {
            //Edit Language
            Language Langobj = new Language();
            Langobj.EditLanguage();
            
        }
        [When(@"User click on update button")]
        public void WhenUserClickOnUpdateButton()
        {
            //Edit Language
            Language Langobj = new Language();
            Langobj.UpdateLanguage();
            
        }
        [Then(@"User should able to edit language successfully")]
        public void ThenUserShouldAbleToEditLanguageSuccessfully()
        {
            //Verify edited Language
            Language Langobj = new Language();
            Langobj.VerifyEditedLanguage();
        }


        //Delete Language
       
        [Given(@"User should able to Delete Language sucessfully")]
        public void GivenUserShouldAbleToDeleteLanguageSucessfully()
        {
            //Delete profile
            Language Langobj = new Language();
            Langobj.DeleteLanguage();
        }

    }
}
