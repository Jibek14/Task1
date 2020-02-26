# Task1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace bitcoin
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://api.binance.com/api/v3/order?symbol=LTCBTC&appid=9Voq4OIaeWBhtKJafczUPfTaNlH9n6Ozu1ZwfxYLBmqZVI6xIDrlQuUxw0kt0je6";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
        }
    }
}
