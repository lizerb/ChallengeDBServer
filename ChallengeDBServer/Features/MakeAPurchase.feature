Feature: Make a purchase
	As a user who does not have an account,
	I want to buy a product and be able to finish my order with success.

@mytag
Scenario: Make a succesfull purchase
	Given that I am a user who does not have an account
	And I choose a product 
	When insert the product to the shopping cart
	And I go to checkout
	Then the product must be at the shopping cart
	When I create an account
	Then the address must be correct
	When I accept the terms of service
	Then the total price must be correct
	When I select a payment method
	Then I successfully finish my order 