using BenjaminTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Gmail.v1.Data;
using System;
using System.IO;
using System.Threading;

namespace BenjaminTest

{
    [TestClass]
    public class BenjaminTest2
    {
        
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

            OpenUrl.GoTo(URL);
            
            
            string apartmantMessage = pik.Apartmant("pik.olx");
            string carsMessage = pik.Cars();
            string touristoffersMessage = pik.TouristOffers();






            if (!apartmantMessage.Contains("ERROR") && (!carsMessage.Contains("ERROR") && (!touristoffersMessage.Contains("ERROR")))) 
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + apartmantMessage;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = apartmantMessage;
            }

            Functions.SendEmailAttachment(subject, body);

            
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