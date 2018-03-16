using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class UntitledTestCase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("http://localhost:50019/");

            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Clear();
            driver.FindElement(By.Id("age")).SendKeys("12");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).Clear();
            driver.FindElement(By.Id("gender")).SendKeys("female");
            driver.FindElement(By.Id("submit")).Click();
            driver.FindElement(By.LinkText("Get Another Premium")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Clear();
            driver.FindElement(By.Id("age")).SendKeys("18");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).Clear();
            driver.FindElement(By.Id("gender")).SendKeys("female");
            driver.FindElement(By.Id("submit")).Click();
            driver.FindElement(By.LinkText("Get Another Premium")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Clear();
            driver.FindElement(By.Id("age")).SendKeys("30");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).Clear();
            driver.FindElement(By.Id("gender")).SendKeys("female");
            driver.FindElement(By.Id("submit")).Click();
            driver.FindElement(By.LinkText("Get Another Premium")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Clear();
            driver.FindElement(By.Id("age")).SendKeys("51");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).Clear();
            driver.FindElement(By.Id("gender")).SendKeys("female");
            driver.FindElement(By.Id("submit")).Click();
            driver.FindElement(By.LinkText("Get Another Premium")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Clear();
            driver.FindElement(By.Id("age")).SendKeys("18");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).Clear();
            driver.FindElement(By.Id("gender")).SendKeys("male");
            driver.FindElement(By.Id("submit")).Click();
            driver.FindElement(By.LinkText("Get Another Premium")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Clear();
            driver.FindElement(By.Id("age")).SendKeys("37");
            driver.FindElement(By.XPath("//form[@action='/Home/InputForm']")).Click();
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).Clear();
            driver.FindElement(By.Id("gender")).SendKeys("male");
            driver.FindElement(By.Id("submit")).Click();
            driver.FindElement(By.LinkText("Get Another Premium")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Clear();
            driver.FindElement(By.Id("age")).SendKeys("51");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).Clear();
            driver.FindElement(By.Id("gender")).SendKeys("male");
            driver.FindElement(By.Id("submit")).Click();
            driver.FindElement(By.LinkText("Get Another Premium")).Click();
            driver.FindElement(By.Id("age")).Click();
            driver.FindElement(By.Id("age")).Clear();
            driver.FindElement(By.Id("age")).SendKeys("17");
            driver.FindElement(By.Id("gender")).Click();
            driver.FindElement(By.Id("gender")).Clear();
            driver.FindElement(By.Id("gender")).SendKeys("male");
            driver.FindElement(By.Id("submit")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
