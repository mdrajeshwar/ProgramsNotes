using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework.Utils
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            return new ChromeDriver(options);
        }
    }
}