Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: I am sending message without all required informations
	Given I am on codecouple page
	When  I go to contact page
	And   I create uncomplete message
    Then  It should be an error 


Scenario: I want to search java
	Given I am on codecouple page
	When  I search java
    Then  I should be on search page