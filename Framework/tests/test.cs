//using System;
//using NUnit.Framework;

//namespace Framework
//{
//    public class test
//    {
//        private SauceDemo _sauceDemo;

//        [SetUp]
//        public void SetUp()
//        {
//            _sauceDemo = new SauceDemo();
//        }

//        [Test]
//        public void JustTest()
//        {
//            _sauceDemo.SigninPage.VisitSigninPage();

//            Assert.That(_sauceDemo.SeleniumDriver.Title, Is.EqualTo("Swag Labs"));
//        }
//    }
//}
