using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ChromeTest()
        {

            // Specify the path to the ChromeDriver executable
            var chromeDriverPath = " C:\\Users\\JamesBass\\Downloads\chromedriver.exe";

            // Create a new instance of the Chrome driver
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized"); // Maximize the browser window
            var driver = new ChromeDriver(chromeDriverPath, options);

            // Navigate to a webpage
            driver.Navigate().GoToUrl("https://example.com");

            // Find an element by its ID and interact with it
            var element = driver.FindElement(By.Id("someElementId"));
            element.Click();

            // Find an element by its CSS selector and interact with it
            var anotherElement = driver.FindElement(By.CssSelector(".someClass"));
            anotherElement.SendKeys("Hello, world!");

            // Close the browser
            driver.Quit();

            /*
             This only works with Google Chrome, Firefox or other Browsers need different packages imported
             */

        }

    }
}
}