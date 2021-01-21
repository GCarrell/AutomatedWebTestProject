using System;
using OpenQA.Selenium;

namespace SwagLabsFramework
{
    public class CartPage
    {
        private IWebDriver _seleniumDriver;

        public CartPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }
    }
}
