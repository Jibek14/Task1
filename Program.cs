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
            string url = "http://api.binance.com/api/v3/ticker/price?symbol=LTCBTC";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            Console.WriteLine(response);
            Console.ReadLine();
        }
    }
}
