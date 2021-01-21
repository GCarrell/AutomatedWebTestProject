using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SwagLabsFramework
{
    public class SeleniumDriverConfig
    {
		public IWebDriver Driver { get; set; }

		public SeleniumDriverConfig(int pageLaodsInSecs, int implicitWaitInSecs)
		{
			DriverSetUp(pageLaodsInSecs, implicitWaitInSecs);
		}

		public void DriverSetUp(int pageLaodsInSecs, int implicitWaitInSecs)
		{
			SetChromeDriver();
			SetDriverConfiguration(pageLaodsInSecs, implicitWaitInSecs);
		}

		public void SetChromeDriver()
		{
			Driver = new ChromeDriver();
		}

		public void SetDriverConfiguration(int pageLoadsInSecs, int implicitWaitInSecs)
		{
			Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadsInSecs);
			Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);
		}
	}
}
