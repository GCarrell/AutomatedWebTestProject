using OpenQA.Selenium;
using System;

namespace Framework
{
    public class SigninPage
    {
        private IWebDriver _seleniumDriver;

        public SigninPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }
    }
}
