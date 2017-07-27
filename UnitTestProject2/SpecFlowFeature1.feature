Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Searching stuff
	Given I am at code couple 
	And I go to Krzysztof page
	When I search java
	Then the result be on screen


Scenario: Sending messages without all data
	 Given I am at code couple
	 And I go to contact page
	 When I create and send incomplete message
	 Then it should be error on contact page