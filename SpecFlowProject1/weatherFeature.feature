Feature: SpecFlowFeature1
	Simple calculator for adding two numbers

@mytag
Scenario: Varify report sent
	Given that the report is "sent"
	And the weather stations "resieved"
	When checkingVarification is called
	Then the result should be true