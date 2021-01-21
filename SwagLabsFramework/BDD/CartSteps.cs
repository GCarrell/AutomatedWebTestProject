using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SwagLabsFramework
{
	[Binding]
	public class CartSteps
	{
		public SwagLabs SwagLabs { get; } = new SwagLabs();

		[Given(@"I am on the products page")]
		public void GivenIAmOnTheProductsPage()
		{
			SwagLabs.ProductsPage.VisitProductPage();
		}

		[When(@"I click the add to cart button")]
		public void WhenIClickTheAddToCartButton()
		{
			SwagLabs.ProductsPage.AddToCart("1");
		}

		[Then(@"the cart item count should increase by (.*)")]
		public void ThenTheCartItemCountShouldIncreaseBy(int num)
		{
			Assert.That(SwagLabs.ProductsPage.CartCount(), Is.EqualTo(num.ToString()));
		}

		[When(@"I click the cart icon")]
		public void WhenIClickTheCartIcon()
		{
			SwagLabs.ProductsPage.ClickOnCart();
		}

		[Then(@"I should land on the cart page")]
		public void ThenIShouldLandOnTheCartPage()
		{
			Assert.That(SwagLabs.SeleniumDriver.Url, Is.EqualTo(SwagLabs.CartPage.Url()));
		}

		[Given(@"I am on the cart page")]
		public void GivenIAmOnTheCartPage()
		{
			SwagLabs.CartPage.VisitCartPage();
		}

		[When(@"I click the continue shopping button")]
		public void WhenIClickTheContinueShoppingButton()
		{
			SwagLabs.CartPage.ClickContinueShopping();
		}

		[Then(@"I should land on the product page")]
		public void ThenIShouldLandOnTheProductPage()
		{
			Assert.That(SwagLabs.SeleniumDriver.Url, Is.EqualTo(SwagLabs.ProductsPage.Url()));
		}

		[Then(@"the cart item should match the item I decided to buy")]
		public void ThenTheCartItemShouldMatchTheItemIDecidedToBuy()
		{
			Assert.That(SwagLabs.CartPage.InventoryItemName(), Is.EqualTo("Sauce Labs Backpack"));
		}

		[AfterScenario]
		public void DiposeWebDriver()
		{
			SwagLabs.SeleniumDriver.Quit();
			SwagLabs.SeleniumDriver.Dispose();
		}
	}
}
