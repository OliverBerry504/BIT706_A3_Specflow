Feature: Transfers

	In order to transfer money between my bank accounts
	As a customer
	I need the resulting balances to be correctly displayed

@Transfers
Scenario Outline: Transfer from Everyday to Investment
	Given the Everyday account has a balance of 100
	And the Investment account has a balance of 100
	When the customer <boolIsStaff> a staff member
	And the amount transfered between everyday and investment is <numAmount>
	Then the Everyday account will have a balance of <resultFrom>
	Then the Investment account will have a balance of <resultToo>

	Examples:
	| numAmount | resultFrom | resultToo | boolIsStaff |
	| 50        | 50         | 150       | false     |
	| 150       | 100        | 100       | false     |
	| 150       | 100        | 100       | true      |

Scenario: Transfer from Everyday to Omni
	Given the Everyday account has a balance of 100
	And the Omni account has a balance of 100
	When the customer <boolIsStaff> a staff member
	And the amount transfered between everyday and omni is <numAmount>
	Then the Everyday account will have a balance of <resultFrom>
	And the Omni account will have a balance of <resultToo>

	Examples:
	| numAmount | resultFrom | resultToo | boolIsStaff |
	| 50        | 50         | 150       | false     |
	| 150       | 100        | 100       | false     |
	| 150       | 100        | 100       | true      |

Scenario: Transfer from Investment to Everyday
	Given the Investment account has a balance of 100
	And the Everyday account has a balance of 100
	When the customer <boolIsStaff> a staff member
	And the amount transfered between investment and everyday is <numAmount>
	Then the Investment account will have a balance of <resultFrom>
	And the Everyday account will have a balance of <resultToo>

	Examples:
	| numAmount | resultFrom | resultToo | boolIsStaff |
	| 50        | 50         | 150       | false     |
	| 150       | 90         | 100       | false     |
	| 150       | 95         | 100       | true      |

Scenario: Transfer from Investment to Omni
	Given the Investment account has a balance of 100
	And the Omni account has a balance of 100
	When the customer <boolIsStaff> a staff member
	And the amount transfered between investment and omni is <numAmount>
	Then the Investment account will have a balance of <resultFrom>
	And the Omni account will have a balance of <resultToo>

	Examples:
	| numAmount | resultFrom | resultToo | boolIsStaff |
	| 50        | 50         | 150       | false     |
	| 150       | 90         | 100       | false     |
	| 150       | 95         | 100       | true      |

Scenario: Transfer from Omni to Everyday
	Given the Omni account has a balance of 100
	And the Everyday account has a balance of 100
	When the customer <boolIsStaff> a staff member
	And the amount transfered between omni and everyday is <numAmount>
	Then the Omni account will have a balance of <resultFrom>
	And the Everyday account will have a balance of <resultToo>

	Examples:
	|numAmount	|resultFrom	|resultToo	| boolIsStaff |
	|50	        |50	        |150	    | false     |
	|1000	    |-900	    |1100	    | false     |
	|10000	    |90	        |100	    | false     |
	|10000	    |95	        |100	    | true      |

Scenario: Transfer from Omni to Investment
	Given the Omni account has a balance of 100
	And the Investment account has a balance of 100
	When the customer <boolIsStaff> a staff member
	And the amount transfered between omni and investment is <numAmount>
	Then the Omni account will have a balance of <resultFrom>
	And the Investment account will have a balance of <resultToo>

	Examples:
	|numAmount	|resultFrom	|resultToo	| boolIsStaff |
	|50	        |50	        |150	    | false     |
	|1000	    |-900	    |1100	    | false     |
	|10000	    |90	        |100	    | false     |
	|10000	    |95	        |100	    | true      |