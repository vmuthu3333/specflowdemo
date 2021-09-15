Feature: quotation
	As a user, I want my quotation should be successful to check my eligibility of loan

@smoke
Scenario: End to End journey of quotation
	Given User launch the application url "https://likelyloans.com/"
	And click on Getmyquote link
	When User submits their details with 
	| borroamt | period | purpose | firstname | lastname |
	| 2100     | 12     | Other   | TESTFIRST | TESTLAST |
	| 500      | 24     | Holiday | TESTFIRSTONE| TESTLASTONE|
	Then quotation should be submitted successfully

 