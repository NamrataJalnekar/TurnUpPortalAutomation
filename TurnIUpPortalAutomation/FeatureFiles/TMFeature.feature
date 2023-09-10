Feature: TMFeature

As a TurnUp Portal admin
i would like to create, edit end Delete time and material records

@tag1
Scenario: Create time and Material record with valid details 
	Given I logged in to TurnUp portal sucessfully 
	And i navigate to TIme and Material Page
	When i create new record
	Then record should be create sucessfully
