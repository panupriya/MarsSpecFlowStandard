Feature: ChangePassword
	 As a user
	I would like to change my password

@ChangePassword
Scenario: Change Password
	Given User should able to reset password
	Then User should able to reset password successfully

Scenario: Set old Password
	Given User try to set password
	Then User should able to set password successfully