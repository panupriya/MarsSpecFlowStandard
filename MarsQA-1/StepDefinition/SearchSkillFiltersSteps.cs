using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public sealed class SearchSkillFiltersSteps
    {
        [Given(@"I go to search skill")]
        public void GivenIGoToSearchSkill()
        {
            SearchByFilters searchSkill = new SearchByFilters();
            searchSkill.SearchSkills();
        }
        [Given(@"I click on search button")]
        public void GivenIClickOnSearchButton()
        {
            SearchByFilters searchSkill = new SearchByFilters();
            searchSkill.Search();
        }
        [Given(@"I click on search using filter Online")]
        public void GivenIClickOnSearchUsingFilterOnline()
        {
            SearchByFilters searchSkill = new SearchByFilters();
            searchSkill.FilterOnline();
        }
        [Given(@"I click on search using filter Onsite")]
        public void GivenIClickOnSearchUsingFilterOnsite()
        {
            SearchByFilters searchSkill = new SearchByFilters();
            searchSkill.FilterOnSite();
        }
        [Given(@"I click on search using filter ShowAll")]
        public void GivenIClickOnSearchUsingFilterShowAll()
        {
            SearchByFilters searchSkill = new SearchByFilters();
            searchSkill.FilterShowAll();
        }

    }
}
