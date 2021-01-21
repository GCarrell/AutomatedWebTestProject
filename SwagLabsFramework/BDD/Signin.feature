Feature: Signin
	As a user of the sauce demo website
	I want to be able to log in and out of my account
	So I can access the product store

@signin
Scenario: Valid Username/Password
	Given I am on the signin page
	And I have entered the username "standard_user"
	And I have entered the password "secret_sauce"
	When I click the login button
	Then I should land on the Products page

@signin
Scenario: Valid Username/Invalid Password
	Given I am on the signin page
	And I have entered the username "standard_user"
	And I have entered the password "secretsauce"
	When I click the login button
	Then I should see an alert saying "Username and password do not match"

@signin
Scenario: Invalid Username/Valid Password
	Given I am on the signin page
	And I have entered the username "user"
	And I have entered the password "secret_sauce"
	When I click the login button
	Then I should see an alert saying "Username and password do not match"

@signin
Scenario: Missing Credentials
	Given I am on the signin page
	And I have entered <username> and <password>
	When I click the login button
	Then I should see an error saying <error>
	Examples: 
	| username | password     | error                |
	| user     |              | Password is required |
	|          | secret_sauce | Username is required |

@signout
Scenario: Logout
	Given I am on products page
	When I click the logout button
	Then I should land on the signin page