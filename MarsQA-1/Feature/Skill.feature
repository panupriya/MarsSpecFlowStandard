Feature: Skill
	 As a user 
	 I would like to Add, Edit and Delete Skill

@Skill
Scenario: Add Skill
	Given User try to add new Skill on profile page
	When  User click on Add Skill button
	Then User should able to add new skill successfully


Scenario: Update Skill
	Given User try to edit the Skill record
	When  User click on update skill button
	Then User should able to edit skill successfully



Scenario: Delete Skill
	 Given  User should able to Delete Skill sucessfully
     