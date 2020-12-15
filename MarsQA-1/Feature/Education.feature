Feature: Education
	 As a user 
	 I would like to Add, Edit and Delete Education

@Education
Scenario: Add Education
	Given User try to add new Education on profile page
	When  User click on Add Education button
	Then User should able to add new education successfully


Scenario: Update Education
	Given User try to edit the Education record
	When  User click on update Education button
	Then User should able to edit education successfully



Scenario: Delete Education
	 Given  User should able to Delete Education sucessfully
     