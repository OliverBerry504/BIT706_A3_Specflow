using BIT706_A3_OliverBerry;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace BIT706_A3.Steps
{
    [Binding]
    public sealed class StepDefinition1
    {
        private static readonly Customer customer = new Customer("Mike", false);

        private Everyday _everyday = new Everyday(customer);
        private Investment _investment = new Investment(customer);
        private Omni _omni = new Omni(customer);
        private AccController _accCtrl = new AccController();
        Exception? _error;

        [Given(@"the Everyday account has a balance of (.*)")]
        public void GivenTheEverydayAccHasABalanceOf(double amount)
        {   
            
            _everyday.Balance = amount;
        }

        [Given(@"the Omni account has a balance of (.*)")]
        public void GivenTheOmniAccountHasABalanceOf(double amount)
        {
            _omni.Balance = amount;
        }

        [Given(@"the Investment account has a balance of (.*)")]
        public void GivenTheInvestmentAccountHasABalanceOf(double amount)
        {
            _investment.Balance = amount;
        }

        [When(@"the amount transfered between everyday and investment is (.*)")]
        public void WhenTheAmountTransferedBetweenEverydayAndInvestmentIs(double amount)
        {
            try
            {
                _accCtrl.Transfer(_investment, _everyday, amount);
            }
            catch (Exception e)
            {
                _error = e;
            }
        }

        [When(@"the amount transfered between everyday and omni is (.*)")]
        public void WhenTheAmountTransferedBetweenEverydayAndOmniIs(double amount)
        {
            try
            {
                _accCtrl.Transfer(_omni, _everyday, amount);
            }
            catch (Exception e)
            {
                _error = e;
            }
        }

        [When(@"the amount transfered between investment and everyday is (.*)")]
        public void WhenTheAmountTransferedBetweenInvestmentAndEverydayIs(double amount)
        {
            try
            {
                _accCtrl.Transfer(_everyday, _investment, amount);
            }
            catch (Exception e)
            {
                _error = e;
            }
        }

        [When(@"the amount transfered between investment and omni is (.*)")]
        public void WhenTheAmountTransferedBetweenInvestmentAndOmniIs(double amount)
        {
            try
            {
                _accCtrl.Transfer(_omni, _investment, amount);
            }
            catch (Exception e)
            {
                _error = e;
            }
        }

        [When(@"the amount transfered between omni and everyday is (.*)")]
        public void WhenTheAmountTransferedBetweenOmniAndEverydayIs(double amount)
        {
            try
            {
                _accCtrl.Transfer(_everyday, _omni, amount);
            }
            catch (Exception e)
            {
                _error = e;
            }
        }

        [When(@"the amount transfered between omni and investment is (.*)")]
        public void WhenTheAmountTransferedBetweenOmniAndinvestmentIs(double amount)
        {
            try
            {
                _accCtrl.Transfer(_investment, _omni, amount);
            }
            catch (Exception e)
            {
                _error = e;
            }
        }

        [Then(@"the Everyday account will have a balance of (.*)")]
        public void ThenTheEverydayAccountWillHaveABalanceOf(double amount)
        {
            Assert.AreEqual(_everyday.Balance, amount);
        }

        [Then(@"the Omni account will have a balance of (.*)")]
        public void ThenTheOmniAccountWillHaveABalanceOf(double amount)
        {
            Assert.AreEqual(_omni.Balance, amount);
        }

        [Then(@"the Investment account will have a balance of (.*)")]
        public void ThenTheInvestmentAccountWillHaveABalanceOf(double amount)
        {
            Assert.AreEqual(_investment.Balance, amount);
        }

        [When(@"the customer (.*) a staff member")]
        public void WhenTheCustomerAStaffMember(bool x)
        {
            customer.IsStaff = x;
        }
    }
}
