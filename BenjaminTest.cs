using BenjaminTest;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace BenjaminTest
{
    [TestClass]
    public class BenjaminTest

    {
        public string url;

        [TestInitialize]
        public void Init()
        {
            TestArguments parameters = new TestArguments();
            int a = int.Parse(parameters.browser);
            Driver.Initialize(a);

            

        }

        [TestMethod]

        public void TestMethod1()
        {
            string subject = "";
            string body = "";


            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(url);


            string SearchMessage = academy387.SearchParameter();

            string ContactMessage = academy387.Contact();

            string ClientsMessage = academy387.Clients();

            string BlogsMessage = academy387.Blogs();

            string EventsMessage = academy387.Events();

            string LecturersMessage = academy387.Lecturers();




            if (!SearchMessage.Contains("ERROR") && (!ContactMessage.Contains("ERROR") && (!ClientsMessage.Contains("ERORR") && (!BlogsMessage.Contains("ERORR") && (!EventsMessage.Contains("ERORR") && (!LecturersMessage.Contains("ERORR")))))))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + SearchMessage + ContactMessage + ClientsMessage + BlogsMessage + EventsMessage + LecturersMessage;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = SearchMessage + ContactMessage + ClientsMessage + BlogsMessage + EventsMessage + LecturersMessage;
            }


            Assert.IsTrue(subject.Contains("Passed"));
            Assert.IsFalse(subject.Contains("Failed"));

        }




[TestCleanup]
        public void Cleanup()
        {
            Driver.Close(); 

        }

    }
}
