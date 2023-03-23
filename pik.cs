using Docker.DotNet.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V108.BackgroundService;
using OpenQA.Selenium.DevTools.V108.DOM;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace BenjaminTest
{
    public class pik
    {
        public static IWebDriver driver;

        public static object ExpectedConditions { get; private set; }

        public static string Apartmant(string word)
        {


            string message = "",
            apartmantMessage = "";
            string minprice = "50000";
            string maxprice = "200000";
            string minQuadrature = "30";
            string maxQuadrature = "70";
            string minbalcony = "1";
            string maxbalcony = "3";


            int retries = 0;
            bool isAdClosed = false;
            
            
            string url = "https://olx.ba/pretraga?category_id=23";
            




                try
                {
                    var googleSearchField = Driver.Instance.FindElement(By.Name("q"));
                    googleSearchField.SendKeys(word);
                    googleSearchField.SendKeys(Keys.Enter);

                    var olx = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) .yuRUbf a cite"));
                    olx.Click();
                    Thread.Sleep(1000);

                    var categories = Driver.Instance.FindElement(By.CssSelector("#__layout  div:nth-child(2) .pb-lg  div:nth-child(1) a.text-center.font-medium.items-center.menu-icon"));
                    categories.Click();
                    Thread.Sleep(1000);


                   //  driver.SwitchTo().iFrame(Driver.FindElement(By.CssSelector("//*[@id=\"ad_iframe\"]")));
                   
                    
                    
                    Driver.Instance.Navigate().GoToUrl(url);

                    
                    
                    
                    var Location = Driver.Instance.FindElement(By.CssSelector("#__layout .pretraga-page .mobile-search .sortGroupFilter select"));
                    Location.Click();

                    var LocationKantonSarajevo = Driver.Instance.FindElement(By.CssSelector("#__layout .pretraga-page .relative.cities select option:nth-child(11)"));
                    LocationKantonSarajevo.Click();
                    Thread.Sleep(5000);

                    var LocationSarajevoCentar = Driver.Instance.FindElement(By.CssSelector("#__layout .mobile-search .filter-box.desktop .relative.cities li:nth-child(5)"));
                    LocationSarajevoCentar.Click();
                    Thread.Sleep(5000);

                    var Pricemin = Driver.Instance.FindElement(By.CssSelector("#__layout div:nth-child(5) .sortGroupFilter input.mr-sm"));
                    Pricemin.Click();
                    Thread.Sleep(1000);
                    Pricemin.SendKeys(minprice);
                    Thread.Sleep(2000);

                    var maxPrice = Driver.Instance.FindElement(By.CssSelector("#__layout div:nth-child(5) .sortGroupFilter input.ml-sm"));
                    maxPrice.Click();
                    maxPrice.SendKeys(maxprice);
                    Thread.Sleep(1000);

                    var CheckBox = Driver.Instance.FindElement(By.CssSelector("#available"));
                    CheckBox.Click();
                    Thread.Sleep(1000);

                    var ApartmantSale = Driver.Instance.FindElement(By.CssSelector("#__layout div:nth-child(7) .sortGroupFilter button:nth-child(2)"));
                    ApartmantSale.Click();
                    Thread.Sleep(1000);

                    var ButtonNew = Driver.Instance.FindElement(By.CssSelector("#buttonNovo"));
                    ButtonNew.Click();
                    Thread.Sleep(1000);

                    var NumberofRooms = Driver.Instance.FindElement(By.XPath("//*[@id=\"__layout\"]/div/div[1]//div//div[9]/div[1]/h2"));
                    NumberofRooms.Click();
                    Thread.Sleep(1000);

                    var tworoomapartment = Driver.Instance.FindElement(By.XPath("//*[@id=\"__layout\"]/div/div[1]//div//div[9]/div[2]/button[4]"));
                    tworoomapartment.Click();
                    Thread.Sleep(1000);

                    var quadrature = Driver.Instance.FindElement(By.CssSelector("#__layout div.filter-box.desktop div:nth-child(10) "));
                    quadrature.Click();
                    Thread.Sleep(1000);

                    var minquadrature = Driver.Instance.FindElement(By.CssSelector("#__layout div:nth-child(10) .sortGroupFilter input.mr-sm"));
                    minquadrature.Click();
                    minquadrature.SendKeys(minQuadrature);
                    Thread.Sleep(1000);

                    var maxquadrature = Driver.Instance.FindElement(By.CssSelector("#__layout div:nth-child(10) .sortGroupFilter input.ml-sm "));
                    maxquadrature.Click();
                    maxquadrature.SendKeys(maxQuadrature);
                    Thread.Sleep(1000);

                    var FurnishedApartment = Driver.Instance.FindElement(By.CssSelector("#__layout .mobile-search .filter-box.desktop div:nth-child(11) svg"));
                    FurnishedApartment.Click();
                    FurnishedApartment = Driver.Instance.FindElement(By.CssSelector("#__layout div:nth-child(11) .sortGroupFilter button:nth-child(1)"));
                    FurnishedApartment.Click();
                    Thread.Sleep(1000);

                    var Floor = Driver.Instance.FindElement(By.CssSelector("#__layout .pretraga-page .mobile-search .filter-box.desktop div:nth-child(12) "));
                    Floor.Click();
                    Floor = Driver.Instance.FindElement(By.CssSelector("#__layout .filter-box.desktop div:nth-child(12) button:nth-child(9)"));
                    Floor.Click();
                    Thread.Sleep(1000);

                var HomePage = Driver.Instance.FindElement(By.CssSelector("#__layout .flex.flex-row.items-center.justify-between.mb-md.sm\\:mb-0 div:nth-child(1) > a"));
                    HomePage.Click();



                }

                catch (Exception e)
                {
                    message += "ERROR!!!" + e.Message;
                }

                message += apartmantMessage;

                return message;
            




        }

        public static string Cars()
        {

            string message = "",
                carsMessage = "";
            string minCarPrice = "10000";
            string maxCarPrice = "200000";



            try
            {
                var CarCategoria = Driver.Instance.FindElement(By.CssSelector("#__layout .text-center.font-medium.items-center.menu-icon"));
                CarCategoria.Click();

                var cars = Driver.Instance.FindElement(By.CssSelector("#__layout div:nth-child(2) > div:nth-child(1) > a:nth-child(1)"));
                cars.Click();

                var manufacturer = Driver.Instance.FindElement(By.CssSelector("#__layout .relative.cars-filter.mb-md .sortGroupFilter select"));
                manufacturer.Click();
                var BMW = Driver.Instance.FindElement(By.CssSelector("#__layout .relative.cars-filter.mb-md .sortGroupFilter option:nth-child(4)"));
                BMW.Click();

                var Model = Driver.Instance.FindElement(By.CssSelector("#__layout .pretraga-page .mobile-search .flex.flex-row.items-center.selected-brands.relative "));
                Model = Driver.Instance.FindElement(By.CssSelector("#__layout .relative.cars-filter.mb-md .custom-models.relative  li:nth-child(14) li:nth-child(6)"));
                Model.Click();

                var CCButton = Driver.Instance.FindElement(By.XPath("//*[@id=\"__layout\"]//div[1]//div//div[2]//ul/li[17]/div"));
                CCButton.Click();

                var Location = Driver.Instance.FindElement(By.XPath("//*[@id=\"__layout\"]/div/div[1]//div//div[3]//div/select"));
                Location.Click();
                Location = Driver.Instance.FindElement(By.CssSelector("#__layout .relative.cities .sortGroupFilter select option:nth-child(6)"));
                Location.Click();

                var Town = Driver.Instance.FindElement(By.CssSelector("#__layout .filter-box.desktop .relative.cities ul li:nth-child(4)"));
                Town.Click();

                var minPrice = Driver.Instance.FindElement(By.CssSelector("#__layout .filter-box.desktop div:nth-child(5) .sortGroupFilter input.mr-sm"));
                minPrice.Click();
                minPrice.SendKeys(minCarPrice);

                var maxPrice = Driver.Instance.FindElement(By.CssSelector("#__layout .filter-box.desktop div:nth-child(5) .sortGroupFilter input.ml-sm"));
                maxPrice.Click();
                maxPrice.SendKeys(maxCarPrice);

                var CarYear = Driver.Instance.FindElement(By.CssSelector("#__layout .mobile-search .filter-box.desktop > div:nth-child(9) "));
                CarYear.Click();

                var minYear = Driver.Instance.FindElement(By.CssSelector("#__layout .filter-box.desktop div:nth-child(9) .sortGroupFilter select.mr-sm"));
                minYear.Click();
                minYear = Driver.Instance.FindElement(By.CssSelector("#__layout div:nth-child(9) .sortGroupFilter select.mr-sm option:nth-child(13)"));
                minYear.Click();

                var maxYear = Driver.Instance.FindElement(By.CssSelector("#__layout .filter-box.desktop div:nth-child(9) .sortGroupFilter select.ml-sm"));
                maxYear.Click();
                maxYear = Driver.Instance.FindElement(By.CssSelector("#__layout  div:nth-child(9) .sortGroupFilter select.ml-sm option:nth-child(2)"));
                maxYear.Click();

                var homepage = Driver.Instance.FindElement(By.CssSelector("#__layout .flex.flex-row.items-center.justify-between.mb-md.sm\\:mb-0 div:nth-child(1) > a"));
                homepage.Click();

            }

            
            
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }
           
            message += carsMessage;
            return message;
        }

         
        
        
        public static string TouristOffers()
        {
            string message = "";
            string TourisOffersMessage = "";


            try
            {
                var OfferCategoria = Driver.Instance.FindElement(By.CssSelector("#__layout .text-center.font-medium.items-center.menu-icon"));
                OfferCategoria.Click();
                var tourisOffer = Driver.Instance.FindElement(By.CssSelector("#__layout div:nth-child(2) div:nth-child(3) a:nth-child(13)"));
                tourisOffer.Click();
                var tourisLocation = Driver.Instance.FindElement(By.CssSelector("#__layout .relative.cities .sortGroupFilter select"));
                tourisLocation.Click();
                var HNKanton = Driver.Instance.FindElement(By.CssSelector("#__layout .relative.cities .sortGroupFilter option:nth-child(9)"));
                HNKanton.Click();

                var AdAvailable = Driver.Instance.FindElement(By.CssSelector("#available"));
                AdAvailable.Click();

                var AdsType = Driver.Instance.FindElement(By.CssSelector("#__layout div:nth-child(7) svg"));
                AdsType.Click();

                var AdStatus = Driver.Instance.FindElement(By.CssSelector("#__layout .condition-listing.my-md .new-wrap"));
                var ButtonNovo = Driver.Instance.FindElement(By.CssSelector("#buttonNovo"));
                ButtonNovo.Click();

                var OtherOptions = Driver.Instance.FindElement(By.CssSelector("#__layout div:nth-child(10) svg"));
                OtherOptions.Click();

                var PriceOptions = Driver.Instance.FindElement(By.CssSelector("#\\30 "));
                PriceOptions.Click();

             

            }


            catch(Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }
            
            message += TourisOffersMessage;
            return message;
       
        
        
        }
    }
}


