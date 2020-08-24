@CurrencyTemplate
Feature: forex contracts

Scenario: New forex contract for valid currency
  Given a forex contract for currency "{Test_Currency}"
  When the contract is received
  Then the contract status should be "Open"