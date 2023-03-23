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
    public class BenjaminTest3
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


            string NewsMessage = RadioSarajevo.News("Radio Sarajevo");
          






            if (!NewsMessage.Contains("ERROR")) 
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + NewsMessage ;
            }
            else
            { 
                subject = "Failed!!! " + subject;
                body = NewsMessage;
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