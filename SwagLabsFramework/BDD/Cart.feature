Feature: Cart
	As a customer, I want to be able to add items to my shopping cart so that I can continue shopping after adding an item.

@2.1
Scenario: Cart item count increase
	Given I am on the products page
	When I click the add to cart button
	Then the cart item count should increase by 1

@2.2
Scenario: Item added to cart successfully
	Given I am on the products page
	When I click the add to cart button
	And I click the cart icon
	Then the cart item should match the item I decided to buy

@2.3
Scenario: Clicking the cart icon takes you to the cart page
	Given I am on the products page
	When I click the cart icon
	Then I should land on the cart page

@2.4
Scenario: Clicking the continue shopping button takes you to the product page
	Given I am on the cart page
	When I click the continue shopping button
	Then I should land on the product page