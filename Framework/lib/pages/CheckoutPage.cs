using OpenQA.Selenium;
using System;

namespace Framework
{
    public class CheckoutPage
    {
        private IWebDriver _seleniumDriver;
        private string CheckoutPageUrl = AppConfigReader.CheckoutPageUrl;
        private IWebElement _submitCheckoutDetailsButton => _seleniumDriver.FindElement(By.CssSelector("[type=\"submit\"]"));
        public CheckoutPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitCheckoutPage()
        {
            _seleniumDriver.Navigate().GoToUrl(@"https://www.saucedemo.com/checkout-step-one.html");
        }

        public string GetPageTitle()
        {
            return _seleniumDriver.Url;
        }

        public void FillCheckoutFields(CheckoutFormCredentials credentials)
        {
            _seleniumDriver.FindElement(By.Id("first-name")).SendKeys(credentials.FirstName);
            _seleniumDriver.FindElement(By.Id("last-name")).SendKeys(credentials.LastName);
            _seleniumDriver.FindElement(By.Id("postal-code")).SendKeys(credentials.PostCode);
        }

        public void ClickContinue()
        {
            _submitCheckoutDetailsButton.Click();
        }

        public string GetErrorMessage()
        {
            return _seleniumDriver.FindElement(By.CssSelector("[data-test=\"error\"]:nth-child(3)")).Text;
        }
    }
}
