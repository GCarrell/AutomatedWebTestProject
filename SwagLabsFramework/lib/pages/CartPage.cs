using System;
using OpenQA.Selenium;

namespace SwagLabsFramework
{
    public class CartPage
    {
        private IWebDriver _seleniumDriver;

        private string CartPageUrl = AppConfigReader.CartPageUrl;

        private IWebElement _continueShoppingButton => _seleniumDriver.FindElement(By.CssSelector(".btn_secondary"));

        private IWebElement _inventoryItem => _seleniumDriver.FindElement(By.CssSelector("#item_4_title_link > .inventory_item_name"));

        public CartPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitCartPage()
        {
            _seleniumDriver.Navigate().GoToUrl(CartPageUrl);
        }

        public string Url()
		{
            return CartPageUrl;
		}

        public string InventoryItemName()
		{
            return _inventoryItem.Text;
		}

        public void ClickContinueShopping()
		{
            _continueShoppingButton.Click();
		}
    }
}
