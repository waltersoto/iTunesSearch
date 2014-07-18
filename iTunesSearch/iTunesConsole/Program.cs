using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using iTunesSearch;

namespace iTunesConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            SearchRequest s = new SearchRequest(Media.podcast);

            var result = s.Search("Nintendo");

            foreach (var item in result.results.Take(10).ToList())
            {
                Console.WriteLine(item.trackName);
                Console.WriteLine(item.trackViewUrl);
                Console.WriteLine();
            }

            Console.ReadLine();
            Console.WriteLine("Press any key...");
        }

        public static string RequestRaw(string url)
        {
            string output = "";

            string userAgent = "iTunes/9.1.1";

            string req = url;
            HttpWebRequest oReq = (HttpWebRequest)WebRequest.Create(req);
            oReq.UserAgent = userAgent;
            HttpWebResponse resp = (HttpWebResponse)oReq.GetResponse();
            Stream resultStream = resp.GetResponseStream();

            StreamReader reader = new StreamReader(resultStream);
            output = reader.ReadToEnd();


            return output;
        }

    }
}
