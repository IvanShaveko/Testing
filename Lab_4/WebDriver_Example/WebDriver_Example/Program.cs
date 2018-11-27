using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.klm.com/home/by/ru";

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts();

            
            driver.FindElement(By.ClassName("g-locationpicker--origin")).SendKeys("Minsk - Minsk National Airport (MSQ), Беларусь");
            driver.FindElement(By.ClassName("g-locationpicker--destination")).SendKeys("Пулман - Moscow Regional (PUW), Washington - США");

            driver.FindElement(By.ClassName("g-forms-datepicker")).Click();
            driver.FindElement(By.XPath("//*[@ui-state-default ui-state-active='28']")).Click();
            driver.FindElement(By.ClassName("g-btn g-btn-primary g-search-form--footer-continue-button")).Click();

        }
    }
}
