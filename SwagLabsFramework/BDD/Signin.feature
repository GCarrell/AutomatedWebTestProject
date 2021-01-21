Feature: Signin
	As a user of the sauce demo website
	I want to be able to log in and out of my account
	So I can access the product store

@mytag
Scenario: Valid Username/Password
	Given I am on the signin page
	And I have entered the username "standard_user"
	And I have entered the password "secret_sauce"
	When I click the login button
	Then I should land on the Products page

@mytag
Scenario: Valid Username/Invalid Password
	Given I am on the signin page
	And I have entered the username "standard_user"
	And I have entered the password "secretsauce"
	When I click the login button
	Then I should see an alert saying "Username and password do not match"

@mytag
Scenario: Invalid Username/Valid Password
	Given I am on the signin page
	And I have entered the username "user"
	And I have entered the password "secret_sauce"
	When I click the login button
	Then I should see an alert saying "Username and password do not match"