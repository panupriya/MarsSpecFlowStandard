Feature: Certification
		 As a user 
	 I would like to Add, Edit and Delete Certification

@Certification
Scenario: Add Certification
	Given User try to add new Certification on profile page
	When  User click on Add Certification button
	Then User should able to add new Certification successfully


Scenario: Update Certification
	Given User try to edit the Certification record
	When  User click on update Certification button
	Then User should able to edit Certification successfully



Scenario: Delete Certification
	 Given  User should able to Delete Certification sucessfully
     