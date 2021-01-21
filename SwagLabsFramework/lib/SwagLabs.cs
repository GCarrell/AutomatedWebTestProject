using System;
using OpenQA.Selenium;

namespace SwagLabsFramework
{
    public class SwagLabs
    {
        public IWebDriver SeleniumDriver { get; set; }
        public SigninPage SigninPage { get; set; }
        public ProductsPage ProductsPage { get; set; }
        public CartPage CartPage { get; set; }
        public CheckoutPage CheckoutPage { get; set; }

        public SwagLabs(int pageLoadWaitInSecs = 10, int implicitWaitInSecs = 10)
        {
            SeleniumDriver = new SeleniumDriverConfig(pageLoadWaitInSecs, implicitWaitInSecs).Driver;
            SigninPage = new SigninPage(SeleniumDriver);
            ProductsPage = new ProductsPage(SeleniumDriver);
            CartPage = new CartPage(SeleniumDriver);
            CheckoutPage = new CheckoutPage(SeleniumDriver);
        }
    }
}
