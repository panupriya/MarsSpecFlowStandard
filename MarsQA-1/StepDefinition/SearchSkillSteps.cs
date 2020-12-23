using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public sealed class SearchSkillSteps
    {

        //search using category
        [Given(@"I navigate to search skill")]
        public void GivenINavigateToSearchSkill()
        {
            SearchSkill searchSkill = new SearchSkill();
            searchSkill.Search_skill();
        }
        [When(@"I try to search skill using category")]
        public void WhenITryToSearchSkillUsingCategory()
        {
            SearchSkill searchSkill = new SearchSkill();
            searchSkill.SearchCategory();
        }
        [Then(@"I am able to see skills based on category")]
        public void ThenIAmAbleToSeeSkillsBasedOnCategory()
        {
            SearchSkill searchSkill = new SearchSkill();
            searchSkill.SearchSucessfull();
        }

        //search using name
        [Given(@"I navigate to the Search skill")]
        public void GivenINavigateToTheSearchSkill()
        {
            SearchSkill searchSkill = new SearchSkill();
            searchSkill.Search_Skill();
        }

        [When(@"I try to search skill using name")]
        public void WhenITryToSearchSkillUsingName()
        {
            SearchSkill searchSkill = new SearchSkill();
            searchSkill.SearchName();
        }
        [Then(@"I am able to see skill based on given name")]
        public void ThenIAmAbleToSeeSkillBasedOnGivenName()
        {
            SearchSkill searchSkill = new SearchSkill();
            searchSkill.SearchNameSuccesfull();
        }

    }
}
