using System;
using OpenQA.Selenium;

namespace Framework
{
    public class SauceDemo
    {
        public IWebDriver SeleniumDriver { get; set; }
        public SigninPage SigninPage { get; set; }
        public ProductsPage ProductsPage { get; set; }
        public CartPage CartPage { get; set; }
        public CheckoutPage CheckoutPage { get; set; }

        public SauceDemo(int pageLoadWaitInSecs = 10, int implicitWaitInSecs = 10)
        {
            SeleniumDriver = new SeleniumDriverConfig(pageLoadWaitInSecs, implicitWaitInSecs).Driver;
            SigninPage = new SigninPage(SeleniumDriver);
            ProductsPage = new ProductsPage(SeleniumDriver);
            CartPage = new CartPage(SeleniumDriver);
            CheckoutPage = new CheckoutPage(SeleniumDriver);
        }
    }
}
