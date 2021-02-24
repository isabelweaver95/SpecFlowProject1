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
Given gallons used is greater than 10
And miles is less than 100
When it is gasHog() true
Then they are gas hogs