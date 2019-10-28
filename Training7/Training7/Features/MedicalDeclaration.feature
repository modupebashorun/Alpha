Feature: MedicalDeclaration
	In order to get protection
	I need to declare medical condition
	

@mytag
Scenario: Add two numbers
	Given I navigate to the site
	When I Click on Next
	And I Click on Nextb
	And I enter policy reference number
	And I Click on Nextc
	And I Select from a dropdownlist
	And I Select from a dropdownlist2
	And I Select from a dropdownlist3
	Then the result should be 120 on the screen
