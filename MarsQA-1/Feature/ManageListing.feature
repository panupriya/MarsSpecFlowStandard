Feature: ManageListing
	In order for buyers to to view and updated information of my listings
	As a Skill Trader
	I want to be able to update and delete skills that I have shared

	
	
	@ManageListing
Scenario: View listed skill information
	Given I open Manage Listing page
	When I click on View button 
	Then I am able to see the listed skill
	
Scenario: Update listed skill information
	Given I open the Manage Listing page
	And I click on Edit button
	When I update my skill
	Then I should able to verify skill is updated successfully
	
Scenario: Remove a skill from the listing
	Given I go to Manage Listing page
	When I click on Delete button
	Then I Should able to verify listing is deleted successfully

