Feature: Notification
	
	As a user
	I want to be view mark and delete notifications

@Notification
Scenario: Notification 
	Given I go to notification tab
	And I click on see all button
	And I click on select all button
	And I click on unselect all button
	And I select one notification 
	When I mark one selection as read
	Then I should be able to delete notification successfully