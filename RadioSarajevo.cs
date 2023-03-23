using Docker.DotNet.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.ComponentModel;






namespace BenjaminTest
{
    public class RadioSarajevo
    {
        public static IWebDriver driver;

        public static string News(string word)
        {
            string message = "";
            string NewsMessage = "";
            string url = "https://radiosarajevo.ba/vijesti";

           
            try
            {
                 var googleSearchField = Driver.Instance.FindElement(By.Name("q"));
                googleSearchField.SendKeys(word);
                googleSearchField.SendKeys(Keys.Enter);

                var RadioSarajevo = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) .yuRUbf a h3"));
                RadioSarajevo.Click();
                
                // var News = Driver.Instance.FindElement(By.XPath("//*[@id=\"header\"]//nav/div[3]/div/div[1]"));
               //  News.Click(); 

               

                IWebDriver driver = new EdgeDriver();
                driver.Navigate().GoToUrl(url);
              
                // Hover preko dropdown menija Vijesti
                
                IWebElement vijestiDropdown = Driver.Instance.FindElement(By.XPath("//*[@id=\"header\"]//nav/div[3]/div/div[1]"));
                Actions action = new Actions(driver);
                Thread.Sleep(3000);
                action.MoveToElement(vijestiDropdown);
                var dropdownBiH = Driver.Instance.FindElement(By.XPath("//*[@id=\"header\"]//div[3]/div/div[1]//ul/li[1]"));
                dropdownBiH.Click();

                
                
                 
                
             



                







            }


            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            message += NewsMessage;
            return message;

        }
    }
}