using System;
using System.Configuration;

namespace Framework
{
	public static class AppConfigReader
	{
		public static readonly string SigninPageUrl = ConfigurationManager.AppSettings["signinpage_url"];
		public static readonly string ProductsPageUrl = ConfigurationManager.AppSettings["productspage_url"];
		public static readonly string CartPageUrl = ConfigurationManager.AppSettings["cartpage_url"];
		public static readonly string CheckoutPageUrl = ConfigurationManager.AppSettings["checkoutpage_url"];
	}
}
