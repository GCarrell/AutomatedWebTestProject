using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Framework.BDD
{
    [Binding]
    public class CheckoutPageSteps
    {
        public SauceDemo SauceDemo { get; }  = new SauceDemo();

        [Given(@"I am on the checkout form")]
        public void GivenIAmOnTheCheckoutForm()
        {
            SauceDemo.CheckoutPage.VisitCheckoutPage();
        }
        
        [Given(@"I enter user credentials")]
        public void GivenIEnterUserCredentials(Table table)
        {
            var credentials = table.CreateInstance<CheckoutFormCredentials>();
            SauceDemo.CheckoutPage.FillCheckoutFields(credentials);
        }
        
        
        [When(@"I click the continue button")]
        public void WhenIClickTheContinueButton()
        {
            SauceDemo.CheckoutPage.ClickContinue();
        }
        

        [Then(@"I should land on the ""(.*)""")]
        public void ThenIShouldLandOnThe(string p0)
        {
            Assert.That(SauceDemo.CheckoutPage.GetPageTitle(), Is.EqualTo(p0));
        }

        [Then(@"I should receive the error (.*)")]
        public void ThenIShouldReceiveTheError(string p0)
        {
            Assert.That(SauceDemo.CheckoutPage.GetErrorMessage(), Is.EqualTo(p0));
        }

        [AfterScenario]
        public void Dispose()
        {
            SauceDemo.SeleniumDriver.Close();
            SauceDemo.SeleniumDriver.Dispose();
        }
    }
}
