Feature: MPGfeature
	Simple calculator for adding two numbers

@mytag
Scenario: mpg - easy
	Given Miles driven is 80
	And Gallons used is 10
	When calc_mpg is called
	Then the fuel efficiency should be 8

Scenario: MPG-easy
	Given Miles driven is 85
	And Gallons used is 10
	When calc_mpg is called
	Then the fuel efficiency should be 8.5

Scenario: GasHog
	Given gallons used is greater than 17
	And miles is less than 15
	When it is gasHog() true
	Then gasHog() should return true

Scenario: calculating gas
	Given Miles driven is 100
	And your MPG is 10
	When calcgallons is called
	Then the gas used should be 10

Scenario: Miles calcualted
	Given Gallons used is 5
	And your MPG is 10
	When calcMiles is called
	Then the amount of miles traveled is 50

Scenario: payment validation
	Given price per gallon is 2
	And your card amount is 20
	When calc_pay is called
	Then the payment should be 10

Scenario: Fuel up
	Given Gallons used is 100
	And the tank is 5
	When calc_fuelUse
	Then the times stoped should be 20