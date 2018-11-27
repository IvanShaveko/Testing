using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AirlinesTestingApp.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        private const string url = "https://www.klm.com/home/by/ru";
        By addInput = By.ClassName("g-search-form--input g-pax-selector g-forms-text");
        By addPassenger = By.ClassName("g-number-stepper__increment");
        By plusBaby = By.ClassName("g-number-stepper__increment");
        By errorsMessages = By.ClassName("error");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.FindElement(addInput).Click();
        }

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(Url);
        }

        public void AddPassengers(){
            driver.FindElements(addPassenger)[0].Click();
        }

        public void PlusBaby(int count = 1)
        {
            for (int i = 0; i < count; i++)
            {
                driver.FindElements(plusBaby)[1].Click();
            }
        }

        public IWebElement GetErrorsMessages()
        {
            return driver.FindElement(errorsMessages);
        }
    }
}
