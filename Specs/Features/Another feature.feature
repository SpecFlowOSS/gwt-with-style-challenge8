Feature: Another feature

Scenario: Another scenario
  Given a forex contract for currency "SEK"
  When the contract is received
  Then the contract status should be "Open"