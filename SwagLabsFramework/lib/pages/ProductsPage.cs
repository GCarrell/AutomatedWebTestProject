using System;
using OpenQA.Selenium;
using System.Threading;

namespace SwagLabsFramework
{
    public class ProductsPage
    {
        private IWebDriver _seleniumDriver;

        private string ProductsPageUrl = AppConfigReader.ProductsPageUrl;
        private IWebElement _cart => _seleniumDriver.FindElement(By.CssSelector("path"));

        private IWebElement _cartCount => _seleniumDriver.FindElement(By.CssSelector(".fa-layers-counter"));

        private IWebElement _sidebarButton => _seleniumDriver.FindElement(By.ClassName("bm-burger-button"));

        private IWebElement _logoutButton => _seleniumDriver.FindElement(By.Id("logout_sidebar_link"));

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


        public string CartCount()
		{
            return _cartCount.Text;
		}

        public string Url()
		{
            return ProductsPageUrl;
		}

        public void OpenSidebar()
        {
            _sidebarButton.Click();
        }

        public void ClickLogout()
        {
            _logoutButton.Click();
        }
    }
}