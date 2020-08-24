using System;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Specs.Steps
{
    [Binding]
    public sealed class ForexContractStepDefinitions
    {
        private string _currency;
        private string _contractStatus;

        [Given(@"a forex contract for currency ""(.*)""")]
        public void GivenAForexContractForCurrency(string currency)
        {
            _currency = currency;
        }

        [When(@"the contract is received")]
        public void WhenTheContractIsReceived()
        {
            Console.WriteLine($"Contract received with currency {_currency}");

            //TODO: call contract handler
            _contractStatus = "Open";
        }

        [Then(@"the contract status should be ""(.*)""")]
        public void ThenTheContractStatusShouldBe(string expectedStatus)
        {
            _contractStatus.Should().Be(expectedStatus);
        }
    }
}
