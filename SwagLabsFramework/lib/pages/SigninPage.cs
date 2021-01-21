using System;
using OpenQA.Selenium;

namespace SwagLabsFramework
{
    public class SigninPage
    {
        private IWebDriver _seleniumDriver;
        private string _signinPageUrl = AppConfigReader.SigninPageUrl;
        private IWebElement _username => _seleniumDriver.FindElement(By.Id("user-name"));
        private IWebElement _password => _seleniumDriver.FindElement(By.Id("password"));
        private IWebElement _loginButton => _seleniumDriver.FindElement(By.Id("login-button"));
        private IWebElement _errorMessage => _seleniumDriver.FindElement(By.CssSelector("#login_button_container > div > form > h3"));

        public SigninPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitSigninPage()
        {
            _seleniumDriver.Navigate().GoToUrl(_signinPageUrl);
        }

        public void InputUsername(string username)
        {
            _username.SendKeys(username);
        }

        public void InputPassword(string password)
        {
            _password.SendKeys(password);
        }

        public void ClickLogin()
        {
            _loginButton.Click();
        }

        public string GetErrorMessage()
        {
            return _errorMessage.Text;
        }
    }
}
