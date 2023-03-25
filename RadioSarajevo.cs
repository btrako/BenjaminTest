using Docker.DotNet.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
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
            string bih = "https://radiosarajevo.ba/vijesti/bosna-i-hercegovina";



            try
            {


                var googleSearchField = Driver.Instance.FindElement(By.Name("q"));
                googleSearchField.SendKeys(word);
                googleSearchField.SendKeys(Keys.Enter);

                var RadioSarajevo = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) .yuRUbf a h3"));
                RadioSarajevo.Click();

                IWebDriver driver = new EdgeDriver();
                driver.Navigate().GoToUrl(url);


                // Kreiranje objekta Actions klase
                Actions actions = new Actions(driver);

                // Pronalazak elementa koji će aktivirati drop-down izbornik
                IWebElement dropDown = driver.FindElement(By.XPath("//*[@id=\"header\"]//nav/div[3]/div/div[1]"));

                // Pokretanje akcije hovera na elementu
                actions.MoveToElement(dropDown).Perform();

                // Sačekaj da se pojavi drop-down izbornik
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                System.Threading.Thread.Sleep(5000);

                // Pronalazak opcije na koju želimo kliknuti
                IWebElement BiH = driver.FindElement(By.XPath("//*[@id=\"header\"]//div[3]/div/div[1]//ul/li[1]"));

                // Klikni na opciju
                BiH.Click();

                driver.Navigate().GoToUrl(bih);
                
                
                // Religija
                IWebElement dropDown1 = driver.FindElement(By.XPath("//*[@id=\"header\"]/div//div[3]/div/div[1]/a"));
                actions.MoveToElement(dropDown1).Perform();
                WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                System.Threading.Thread.Sleep(5000);
                IWebElement world = driver.FindElement(By.XPath("//*[@id=\"header\"]/div//div[3]//div[1]/div/ul/li[3]/a"));
                world.Click();

                // Crna Hronika 
                IWebElement dropDown2 = driver.FindElement(By.XPath("//*[@id=\"header\"]/div//div[3]/div/div[1]/a"));
                actions.MoveToElement(dropDown1).Perform();
                WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                System.Threading.Thread.Sleep(5000);
                IWebElement blackChronicle = driver.FindElement(By.XPath("//*[@id=\"header\"]//div[3]/div/div[1]//ul/li[4]/a"));
                blackChronicle.Click();

                // Lokalne teme
                IWebElement dropDown3 = driver.FindElement(By.XPath("//*[@id=\"header\"]/div//div[3]/div/div[1]/a"));
                actions.MoveToElement(dropDown1).Perform();
                WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                System.Threading.Thread.Sleep(5000);
                IWebElement LocalTopics = driver.FindElement(By.XPath("//*[@id=\"header\"]//div[3]/div/div[1]//ul/li[5]/a"));
                LocalTopics.Click();

                }


            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            message += NewsMessage;
            return message;

        }

        public static string BussinesMessage()
            
        {
            string message = "";
            string BussinesMessage = "";
       
        try
            {
                var Bussines = driver.FindElement(By.XPath("//*[@id=\"header\"]//div[3]//div[2]"));
                Bussines.Click();

                Actions actions = new Actions(driver);
                
                // Ekonomija
                IWebElement dropdownbussines = driver.FindElement(By.XPath("//*[@id=\"header\"]//div[3]//div[2]"));
                actions.MoveToElement(dropdownbussines).Perform();
                WebDriverWait Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                System.Threading.Thread.Sleep(5000);
                IWebElement Economy = driver.FindElement(By.XPath("//*[@id=\"header\"]//div[3]//div[2]//li[1]"));
                Economy.Click();
           
            
        
            }
        
        catch(Exception e)
            {
                message += "ERORR !!!" + e.Message;
            }

            message += BussinesMessage;
            return message;



        }
    }
}

    