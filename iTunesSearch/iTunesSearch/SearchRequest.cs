 
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;

namespace iTunesSearch
{
   
    public class SearchRequest
    {
        //ex.   itunes.apple.com/search?term=anime&media=podcast;
        private const string Api = "https://itunes.apple.com/search";

        private Media _searchEntity;
        

        public SearchRequest(Media m = Media.all)
        {
            _searchEntity = m;
            Parameters = new Dictionary<string, string>();
        }

        public SearchResult Search(string term)
        {
            return Search(term, _searchEntity);
        }

        private string LoadParameters()
        {
            StringBuilder pars = new StringBuilder();

            if (Parameters != null && Parameters.Count > 0)
            {
                foreach (var pair in Parameters)
                {
                    pars.Append("&" + pair.Key + "=" + pair.Value);
                }
            }

            return pars.ToString();
        }

        public SearchResult Search(string term, Media m)
        {
            string json = RequestRaw(Api + "?media=" + m.ToString() + "&term=" + term + LoadParameters());

            var d = new DataContractJsonSerializer(typeof(SearchResult));
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var result = (SearchResult)d.ReadObject(stream);
            return result;

        }
 
        public static string RequestRaw(string url)
        {
            string htmlCode = "";

            using (var client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                htmlCode = client.DownloadString(url);
            }

            return htmlCode;
        }

        /// <summary>
        /// Set/Get Parameters
        /// </summary>
        public Dictionary<string, string> Parameters { set; get; }


 
    }
 
}
