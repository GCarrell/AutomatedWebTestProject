using OpenQA.Selenium;
using System;

namespace Framework
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
