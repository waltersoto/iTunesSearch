using System;
using System.Text;
using System.Collections.Generic;
using System.Net; 
using System.Web.Script.Serialization;

namespace iTunesSearch
{
   
    public class SearchRequest
    {
        //ex.   itunes.apple.com/search?term=anime&media=podcast;
        private string _api =  "https://itunes.apple.com/search";
   
        private Media _searchEntity = Media.all;
        

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
            string json = RequestRaw(_api+"?media="+m.ToString()+"&term="+term+LoadParameters());
            
            JavaScriptSerializer s = new JavaScriptSerializer();
            var result = s.Deserialize<SearchResult>(json);

            return result;
        }
 
        public static string RequestRaw(string url)
        {
            string htmlCode = "";

            using (WebClient client = new WebClient())
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
