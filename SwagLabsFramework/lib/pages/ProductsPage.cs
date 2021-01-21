using System;
using OpenQA.Selenium;

namespace SwagLabsFramework
{
    public class ProductsPage
    {
        private IWebDriver _seleniumDriver;

        private string ProductsPageUrl = AppConfigReader.ProductsPageUrl;
        private IWebElement _cart => _seleniumDriver.FindElement(By.CssSelector("path"));

        public ProductsPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitProductPage()
        {
            _seleniumDriver.Navigate().GoToUrl(ProductsPageUrl);
        }
        public void AddToCart(string item_no)
        {
            _seleniumDriver.FindElement(By.CssSelector($".inventory_item:nth-child({item_no}) .btn_primary")).Click();
        }
        public void RemoveFromCart(string item_no)
        {
            _seleniumDriver.FindElement(By.CssSelector($".inventory_item:nth-child({item_no}) .btn_secondary")).Click();
        }

        public void ClickOnCart()
        {
            _cart.Click();
        }
    }
}
