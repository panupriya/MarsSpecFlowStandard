Feature: SearchSkillFilters
		As a user
	I want to be able to search skill using filters

@SearchByFilters
Scenario: Search By Filters 
	Given I go to search skill
	And I click on search button
	And I click on search using filter Online
	And I click on search using filter Onsite
	And I click on search using filter ShowAll 
	