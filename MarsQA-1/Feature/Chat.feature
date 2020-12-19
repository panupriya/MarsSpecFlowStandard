Feature: Chat
	
	As a user
	I want to be able to chat with other users

@mytag
Scenario: Chat
	Given I go to chat tab
	And I select the person to chat
	When I enter and the details and click on sent
	Then sent message should be successfull