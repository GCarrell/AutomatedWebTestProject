using System;
using OpenQA.Selenium;

namespace SwagLabsFramework
{
    public class CheckoutPage
    {
        private IWebDriver _seleniumDriver;

        public CheckoutPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }
    }
}
