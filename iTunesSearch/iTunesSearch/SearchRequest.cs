using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace iTunesSearch
{
  

    public enum Media
    {
        movie, podcast, music, musicVideo, audiobook, shortFilm, tvShow, software, ebook, all
    }

 

    public class SearchRequest
    {
        //ex.   itunes.apple.com/search?term=anime&entity=podcast or media=podcast;
        private string _api =  "https://itunes.apple.com/search";
   
        private Media _searchEntity = Media.all;
         

        public SearchRequest(Media m = Media.all)
        {
            _searchEntity = m; 
        }

        public SearchResult Search(string term)
        {
            return Search(term, _searchEntity);
        }

        public SearchResult Search(string term, Media m)
        {
            string json = RequestRaw(_api+"?media="+m.ToString()+"&term="+term);
            
            JavaScriptSerializer s = new JavaScriptSerializer();
            var result = s.Deserialize<SearchResult>(json);

            return result;
        }

        private string RequestRaw(string url)
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
