Feature: API Testing demo

@mytag
Scenario: BCM Service testing
	Given I want to create a new document I make a POST request
	And To check that the docJson name is "Test DocJson Name" I make a GET request
	And To modify the docJson name I make a PUT request
	And To check that the docJson name has been modified into "test123" I make a GET request
	When I want to delete the document I make a DELETE request
#	Then To check that the document was deleted I make a GET request
	Then To check that the document was deleted I make a PUT request

	
