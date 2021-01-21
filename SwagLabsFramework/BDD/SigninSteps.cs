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

        [AfterScenario]
        public void DisposeWebDriver()
        {
            _swagLabs.SeleniumDriver.Quit();
            _swagLabs.SeleniumDriver.Dispose();
        }
    }
}
