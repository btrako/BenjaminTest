using NUnit.Framework.Internal.Execution;
using OpenQA.Selenium;
using System.ComponentModel;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.DevTools.V108.CSS;

namespace BenjaminTest
 {

    public class academy387
    {
           public static string SearchParameter()
           {
            string message = "";
            string SearchMessage = "";

            try
            {

                var google = Driver.Instance.FindElement(By.Name("q"));
                google.Click();
                google.SendKeys("academy 387");
                google.SendKeys(Keys.Enter);

                var academy = Driver.Instance.FindElement(By.XPath("//*[@id=\"rso\"]/div[1]//div//div//div//a/h3"));
                academy.Click();
                academy = Driver.Instance.FindElement(By.Id("main-search-input"));
                academy.Click();
                academy.SendKeys("qa");
                academy = Driver.Instance.FindElement(By.ClassName("input-group-btn"));
                academy.Click();

                var dropdown = Driver.Instance.FindElement(By.CssSelector("#category_id"));
                dropdown.Click();
                dropdown = Driver.Instance.FindElement(By.CssSelector("#category_id option:nth-child(2)"));
                dropdown.Click();
                dropdown = Driver.Instance.FindElement(By.CssSelector("#lecturer_id"));
                dropdown.Click();
                dropdown = Driver.Instance.FindElement(By.CssSelector("#lecturer_id  option:nth-child(227)"));
                dropdown.Click();

                var minprice = Driver.Instance.FindElement(By.CssSelector("#price_min"));
                minprice.Click();
                minprice.SendKeys("50");

                var maxprice = Driver.Instance.FindElement(By.CssSelector("#price_max"));
                maxprice.Click();
                maxprice.SendKeys("500");

                var button = Driver.Instance.FindElement(By.CssSelector("body .page-content .col-xs-12.col-md-3.seach-filters-col  form  input.btn.btn-green.btn-block"));
                button.Click();

                var QACours = Driver.Instance.FindElement(By.ClassName("program-card__footer"));
                QACours.Click();
            }

            catch (Exception e)
            {

                message += "ERORR !!!" + e.Message;
            }

            message = SearchMessage;
            return message;
           
        }


     public static string Contact() {

            string message = "";
            string ContactMessage = "";

            try
            {
                var Contact = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1  li:nth-child(6)"));
                Contact.Click();
            }
            
            catch(Exception e)
            {
                message += "ERORR!!!" + e.Message;
            }

            message = ContactMessage;
            return message;
        }

        
        
        
        public static string Clients()
        {
            string message = "";
            string ClientsMessage = "";

            try
            {
                var clients = Driver.Instance.FindElement(By.XPath("//*[@id=\"bs-example-navbar-collapse-1\"]//li[5]"));
                clients.Click();

            }

            catch (Exception e)
            {
                message += "ERORR!!!" + e.Message;
            }

            message = ClientsMessage;
            return message;
        }



        public static string Blogs()
        {

            string message = "";
            string BlogsMessage = "";

            try
            {
                var Blogs = Driver.Instance.FindElement(By.XPath("//*[@id=\"bs-example-navbar-collapse-1\"]//li[4]"));
                Blogs.Click();
            }

            catch (Exception e)
            {
                message += "ERORR!!!" + e.Message;
            }

            message = BlogsMessage;
            return message;
        }

 
        public static string Events()
          {

            string message = "";
            string EventsMessage = "";

            try
            {
                var Events = Driver.Instance.FindElement(By.XPath("//*[@id=\"bs-example-navbar-collapse-1\"]//li[3]"));
                Events.Click();
            }

            catch (Exception e)
            {
                message += "ERORR!!!" + e.Message;
            }

            message = EventsMessage;
            return message;
        }



           public static string Lecturers()
            
        {
            string message = "";
            string LecturersMessage = "";

            try
            {
                var Lecturers = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1  ul.nav.navbar-nav.navbar-right li:nth-child(2)"));
                Lecturers.Click();
                Lecturers = Driver.Instance.FindElement(By.XPath("/html/body//div//div//div[2]/div/ul/li[14]/a"));
                Lecturers.Click();
                Lecturers = Driver.Instance.FindElement(By.CssSelector("#lecturers-container div:nth-child(11) a"));
                Lecturers.Click();
            }

            catch (Exception e)
            {
                message += "ERORR!!!" + e.Message;
            }

            message = LecturersMessage;
            return message;





        }
        
    }
    
}



    
    
        
          






   











































