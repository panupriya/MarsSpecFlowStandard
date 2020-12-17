Feature: ManageRequest
	
	As a user
	I want to be able to sent and receive request

	
	
	@ManageListing
Scenario: Received Request
	Given I go to Manage Request tab
	When I click on Received Request
	Then I am able to accept or decline request

Scenario: Sent Request
	Given I navigate to Manage Request tab
	When I click on Sent Request
	Then I am able to sent request

