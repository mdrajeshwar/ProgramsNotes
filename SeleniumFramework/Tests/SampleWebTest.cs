using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumFramework.Utils;
using SeleniumFramework.Pages;

namespace SeleniumFramework.Tests
{
    public class SampleWebTest
    {
        private IWebDriver? _driver;
        private LoginPage _loginPage;

        [SetUp]
        public void Setup()
        {
            _driver = WebDriverFactory.CreateDriver();
            _loginPage = new LoginPage(_driver);
        }

        [Test]
        public void LoginTest()
        {
            _driver!.Navigate().GoToUrl(Config.BaseUrl);
            _loginPage.Login("testuser", "password");
            Assert.That(_driver!.Url.Contains("dashboard"), Is.True);
        }

        [TearDown]
        public void TearDown()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
                _driver = null;
            }
        }
    }
}