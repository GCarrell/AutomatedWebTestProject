using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SwagLabsFramework
{
    [Binding]
    public class SigninSteps
    {
        private SwagLabs _swagLabs = new SwagLabs();

        [Given(@"I am on the signin page")]
        public void GivenIAmOnTheSigninPage()
        {
            _swagLabs.SigninPage.VisitSigninPage();
        }

        [Given(@"I have entered the username ""(.*)""")]
        public void GivenIHaveEnteredTheUsername(string username)
        {
            _swagLabs.SigninPage.InputUsername(username);
        }

        [Given(@"I have entered the password ""(.*)""")]
        public void GivenIHaveEnteredThePassword(string password)
        {
            _swagLabs.SigninPage.InputPassword(password);
        }

        [Given(@"I have entered (.*) and (.*)")]
        public void GivenIHaveEnteredAnd(string username, string password)
        {
            _swagLabs.SigninPage.InputUsername(username);
            _swagLabs.SigninPage.InputPassword(password);
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _swagLabs.SigninPage.ClickLogin();
        }

        [Then(@"I should land on the Products page")]
        public void ThenIShouldLandOnTheProductsPage()
        {
            Assert.That(_swagLabs.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }

        [Then(@"I should see an alert saying ""(.*)""")]
        public void ThenIShouldSeeAnAlertSaying(string expected)
        {
            Assert.That(_swagLabs.SigninPage.GetErrorMessage(), Does.Contain(expected));
        }

        [Then(@"I should see an error saying (.*)")]
        public void ThenIShouldSeeAnErrorSaying(string expected)
        {
            Assert.That(_swagLabs.SigninPage.GetErrorMessage(), Does.Contain(expected));
        }

        [Given(@"I am on products page")]
        public void GivenIAmOnProductsPage()
        {
            _swagLabs.ProductsPage.VisitProductPage();
        }

        [When(@"I click the logout button")]
        public void WhenIClickTheLogoutButton()
        {
            _swagLabs.ProductsPage.OpenSidebar();
            _swagLabs.ProductsPage.ClickLogout();
        }

        [Then(@"I should land on the signin page")]
        public void ThenIShouldLandOnTheSigninPage()
        {
            Assert.That(_swagLabs.SeleniumDriver.Url, Is.EqualTo("https://www.saucedemo.com/index.html"));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            _swagLabs.SeleniumDriver.Quit();
            _swagLabs.SeleniumDriver.Dispose();
        }
    }
}