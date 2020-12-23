Feature: SearchSkills
		As a user
	I want to be able to search skill using category and name

@SearchSkill
Scenario: Search By Category
	Given I navigate to search skill
	When I try to search skill using category
	Then I am able to see skills based on category

Scenario: Search By Name
	Given I navigate to the Search skill
	When I try to search skill using name
	Then I am able to see skill based on given name
	
	