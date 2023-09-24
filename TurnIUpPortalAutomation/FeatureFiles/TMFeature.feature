Feature: TMFeature

As a TurnUp Portal admin
i would like to create, edit end Delete time and material records

@regression
Scenario: Create time and Material record with valid details 
	Given I logged in to TurnUp portal sucessfully 
	And i navigate to TIme and Material Page
	When i create new record
	Then record should be create sucessfully

Scenario Outline: Edit time and material record with valid details
	Given I logged in to TurnUp portal sucessfully
	And i navigate to TIme and Material Page
	When i update '<Code1>' on an existing time record 
	Then record should have an updated '<Code1>'

	Examples:
	| Code1		  |
	| Pen         |
	| Keyboard    |
	| Mouse       |
