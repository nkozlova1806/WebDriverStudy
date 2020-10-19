using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace WebDriver123
{
    [TestClass]
    public class TestSuit
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [TestMethod]
        public void TestMethod1()
        {
            string currentWindowHandle = driver.CurrentWindowHandle;
            var WindowHandles = driver.WindowHandles;

            driver.FindElement(By.CssSelector("someSelector")); // = драйвер, найди элемент по цсс селектору
                                                                // если элемент не найден, вернет эксепшен, поэтому нужно обернуть в try catch
            driver.FindElements(By.CssSelector("someSelector")); // коллекция  элементов; если ни один элемент не будет найден,
                                                                 // вернется пустая коллекция          
            driver.Navigate().GoToUrl("www.test.com");

            //driver.Manage().Cookies.DeleteCookie();

            driver.Manage().Window.FullScreen();
            //driver.Manage().Window.Size();
            driver.SwitchTo().Alert();
            //driver.SwitchTo().Frame(); // преключиться в айфрейм
            driver.SwitchTo().DefaultContent(); // переключиться из айфрейма назад в предыдущее окно
            driver.SwitchTo().Window(currentWindowHandle);

            Console.WriteLine(currentWindowHandle);
        }
    }
}
