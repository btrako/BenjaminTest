using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
           
            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(url);





            academy387.SearchParameter();

            academy387.Contact();

            academy387.Clients();

            academy387.Blogs();

            academy387.Events();

            academy387.Lecturers(); 






         } 

           [TestCleanup]
        public void Cleanup()
        {
            Driver.Close(); 

        }

    }
}
