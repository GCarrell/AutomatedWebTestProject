Feature: CheckoutPage
	As a customer
	I want to be able to check out the items in my shopping cart
	so that I can purchase them

@mytag
Scenario: Checkout form filled
	Given I am on the checkout form
	And I enter user credentials
	When I click the continue button
	Then I should land on the "Checkout: overview page"
	Examples:
	| first name | last name | postcode |
	| Maydup     | Naym      | GU167HF  |

Scenario: Missing Credentials
	Given I am on the checkout form
	And I enter user credentials
	When I click the continue button
	Then I should receive the error <expected error>
	Examples: 
	| first name | last name | postcode | expected error          |
	|            | Naym      | GU167HF  | First Name is required  |
	| Maydup     |           | GU167HF  | Last Name is required   |
	| Maydup     | Naym      |          | Postal Code is required |