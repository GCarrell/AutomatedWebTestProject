using System;
using OpenQA.Selenium;

namespace Framework
{
    public class ProductsPage
    {
        private IWebDriver _seleniumDriver;

        public ProductsPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }
    }
}
