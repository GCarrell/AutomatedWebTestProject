using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SwagLabsFramework
{
    [Binding]
    public class CheckoutPageSteps
    {
        public SwagLabs SwagLabs { get; }  = new SwagLabs();

        [Given(@"I am on the checkout form")]
        public void GivenIAmOnTheCheckoutForm()
        {
            SwagLabs.CheckoutPage.VisitCheckoutPage();
        }        

        [Given(@"I enter user credentials (.*), (.*) and (.*)")]
        public void GivenIEnterUserCredentialsAnd(string firstName, string lastName, string postcode)
        {
            SwagLabs.CheckoutPage.FillCheckoutFields(firstName, lastName, postcode);
        }

        [When(@"I click the continue button")]
        public void WhenIClickTheContinueButton()
        {
            SwagLabs.CheckoutPage.ClickContinue();
        }
        [Given(@"I am on the product page")]
        public void GivenIAmOnTheProductPage()
        {
            SwagLabs.ProductsPage.VisitProductPage();
        }

        [Given(@"I add two items to my basket")]
        public void GivenIAddTwoItemsToMyBasket()
        {
            SwagLabs.ProductsPage.AddToCart("1");
            SwagLabs.ProductsPage.AddToCart("2");
        }

        [When(@"I go to my cart page")]
        public void WhenIGoToMyCartPage()
        {
            SwagLabs.ProductsPage.ClickOnCart();
        }

        [When(@"click the checkout button")]
        public void WhenClickTheCheckoutButton()
        {
            SwagLabs.CheckoutPage.ClickCheckoutButton();
        }

        [When(@"I enter user credentials (.*), (.*) and (.*)")]
        public void WhenIEnterUserCredentialsAnd(string firstName, string lastName, string postcode)
        {
            SwagLabs.CheckoutPage.FillCheckoutFields(firstName, lastName, postcode);
        }

        [When(@"I click the finish button")]
        public void WhenIClickTheFinishButton()
        {
            SwagLabs.CheckoutPage.ClickFinishButton();
        }

        [Then(@"I should land on the thank you for your order page")]
        public void ThenIShouldLandOnTheThankYouForYourOrderPage()
        {
            Assert.That(SwagLabs.CheckoutPage.GetPageTitle(), Is.EqualTo("Finish"));
        }

        [Then(@"I should land on the ""(.*)"" page")]
        public void ThenIShouldLandOnThePage(string p0)
        {
            Assert.That(SwagLabs.CheckoutPage.GetPageTitle(), Is.EqualTo(p0));
        }

        [Then(@"I should receive the error (.*)")]
        public void ThenIShouldReceiveTheError(string p0)
        {
            Assert.That(SwagLabs.CheckoutPage.GetErrorMessage(), Does.Contain(p0));
        }

        [AfterScenario]
        public void Dispose()
        {
            SwagLabs.SeleniumDriver.Close();
            SwagLabs.SeleniumDriver.Dispose();
        }
    }
}
