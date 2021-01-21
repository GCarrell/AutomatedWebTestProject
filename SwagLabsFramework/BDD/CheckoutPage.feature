Feature: CheckoutPage
	As a customer
	I want to be able to check out the items in my shopping cart
	so that I can purchase them
@checkout
Scenario: Checkout form filled
	Given I am on the checkout form
	And I enter user credentials <first name>, <last name> and <postcode>
	When I click the continue button
	Then I should land on the "Checkout: Overview" page
	Examples:
	| first name | last name | postcode |
	| Maydup     | Naym      | GU167HF  |

@checkout
Scenario: Missing Credentials
	Given I am on the checkout form
	And I enter user credentials <first name>, <last name> and <postcode>
	When I click the continue button
	Then I should receive the error <expected error>
	Examples: 
	| first name | last name | postcode | expected error          |
	|            | Naym      | GU167HF  | First Name is required  |
	| Maydup     |           | GU167HF  | Last Name is required   |
	| Maydup     | Naym      |          | Postal Code is required |

@checkout
Scenario: Checkout Successful
	Given I am on the product page
	And I add two items to my basket
	When I go to my cart page
	And click the checkout button
	And I enter user credentials <first name>, <last name> and <postcode>
	And I click the continue button
	And I click the finish button
	Then I should land on the thank you for your order page
	Examples:
	| first name | last name | postcode |
	| Maydup     | Naym      | GU167HF  |