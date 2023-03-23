using BenjaminTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace BenjaminTest
{
    public class OpenUrl
    {
        public static void GoTo(string url)
        {
            Driver.Instance.Navigate().GoToUrl(url);
            Thread.Sleep(1000);

        }
        public static void GoTo()
        {
            string url = "https://olx.ba/pretraga?category_id=23";
            Driver.Instance.Navigate().GoToUrl(url);
        }
    }
}
