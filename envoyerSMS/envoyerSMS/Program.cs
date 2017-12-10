using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Web;
using System.Security.Cryptography;

namespace envoyerSMS
{
    
    class Program
    {       
        
        static void Main(string[] args)
        { 

            

        //{// define the URL to send an SMS
        //const string ACCESS_KEY = "ADqezQmETQf9tjoikYYcsUnY";
        ////const string MESSAGE = "HelloWorld";
        ////const string TO_PHONE_NUMBER = "33612345678";
        //Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        // TSTAMP = unixTimestamp.ToString;
        //string URL =
        //    "https://api.boxis.net/?" +
        //    "returntype=xml&" +
        //    "sender_name=boxis.net&" +
        //    "recipients[1]=41765464985&" +
        //    "content=HelloWordl&" +
        //    "encoding=UTF-8&" +
        //    "version=1.0&" +
        //    "username=cardozoruben@gmail.com&" +
        //    "timestamp="+unixTimestamp.ToString()+"&" +
        //    "authcode=" + unixTimestamp.ToString() + ACCESS_KEY+"&" +
        //    "section=sms&"+
        //    "action=sendSMS";
        
            
        //    // XmlDocument allowed to query a xml document with xpath expression
        //    XmlDocument xmldoc = new XmlDocument();
        //    xmldoc.Load(URL);
        //    Console.WriteLine("Status Message=" + xmldoc.SelectSingleNode("/response/status/status_msg").InnerText);
        

            //  parametres iniciaux
            //+ apiAccessKey +
            //"&to=" + phoneNumber + "&content=" + textContent;

            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            String apiAccessKey = "hNpArSGaXwhQ9KZTeha96fOK";
            var auth = Encoding.UTF8.GetBytes (unixTimestamp + apiAccessKey);
            //byte[] key = Encoding.ASCII.GetBytes(unixTimestamp + apiAccessKey);
            
            var md5 = new HMACMD5(auth);

            //MD5 md5 = MD5.Create();

            //byte[] inputBytes = Encoding.UTF8.GetBytes(auth);

            //var hash = md5.GetHashCode(auth);

            // step 2, convert byte array to hex string

            //StringBuilder sb = new StringBuilder();

            //for (int i = 0; i < hash.Length; i++)
            //{

            //    sb.Append(hash[i].ToString("X2"));

            //}

            //var h = hash;
            
            String url = "https://api.boxis.net/?" +                  
                "returntype=xml&" +
                "sender_name=boxis.net&" +
                "recipients[1]=41765464985&" +
                "content=HelloWordl&" +
                "encoding=UTF-8&" +
                "version=1.0&" +
                "username=cardozoruben@gmail.com&" +
                "timestamp=" + unixTimestamp + 
                "&authcode=" + md5.ToString() +
                "&section=sms&" +
                "action=sendSMS";

            // Envoie requêt
            WebClient client = new WebClient();
            String result = client.DownloadString(url);
            Console.WriteLine("Result : " + result);

            // Parse return XML
            XmlDocument document = new XmlDocument();
            document.LoadXml(result);
            Console.WriteLine("Status code : "
                + document.GetElementsByTagName("status_code").ToString());
            Console.WriteLine("Status message : "
                + document.GetElementsByTagName("status_msg").ToString());
            Console.Read();
        }

        
        
    }
}


