using OpenQA.Selenium;
using System;
using System.Threading;

namespace SwagLabsFramework
{
    public class CheckoutPage
    {
        private IWebDriver _seleniumDriver;
        private string CheckoutPageUrl = SwagLabsFramework.AppConfigReader.CheckoutPageUrl;
        private IWebElement _submitCheckoutDetailsButton => _seleniumDriver.FindElement(By.CssSelector("[type=\"submit\"]"));
        private IWebElement _checkoutPageSubheader => _seleniumDriver.FindElement(By.CssSelector(".subheader"));
        private IWebElement _finishCheckoutButton => _seleniumDriver.FindElement(By.CssSelector(".btn_action.cart_button"));
        private IWebElement _startCheckoutButton => _seleniumDriver.FindElement(By.CssSelector(".btn_action.checkout_button"));

        public CheckoutPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitCheckoutPage()
        {
            _seleniumDriver.Navigate().GoToUrl(CheckoutPageUrl);
        }

        public string GetPageTitle()
        {
            return _checkoutPageSubheader.Text;
        }



        public void FillCheckoutFields(string firstName, string lastName, string postcode)
        {
            _seleniumDriver.FindElement(By.Id("first-name")).SendKeys(firstName);
            _seleniumDriver.FindElement(By.Id("last-name")).SendKeys(lastName);
            _seleniumDriver.FindElement(By.Id("postal-code")).SendKeys(postcode);
        }

        public void ClickContinue()
        {
            _submitCheckoutDetailsButton.Click();
        }

        public string GetErrorMessage()
        {
            Thread.Sleep(50);
            return _seleniumDriver.FindElement(By.CssSelector("[data-test=\"error\"]")).Text;
        }

        internal void ClickCheckoutButton()
        {
            _startCheckoutButton.Click();
        }

        internal void ClickFinishButton()
        {
            _finishCheckoutButton.Click();
        }
    }
}
