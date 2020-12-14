Feature: Language
	 As a user 
	 I would like to Add, Edit and Delete language

@Language
Scenario: Add new Language
	Given User try to add new Language on profile page
	When  User click on Add button
	Then User should able to add new language successfully


Scenario: Update Language
	Given User try toedit the Language record
	When  User click on update button
	Then User should able to edit language successfully



Scenario: Delete Language
	 Given  User should able to Delete Language sucessfully
     

