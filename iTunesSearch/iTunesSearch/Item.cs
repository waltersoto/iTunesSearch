using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace iTunesSearch
{

    public class Item
    {
        
        public string wrapperType { set; get; }
        public string kind { set; get; }
        public string artistId { set; get; }
        public string collectionId { set; get; }
        public string trackId { set; get; }
        public string artistName { set; get; }
        public string collectionName { set; get; }
        public string trackName { set; get; }
        public string collectionCensoredName { set; get; }
        public string trackCensoredName { set; get; }
        public string artistViewUrl { set; get; }
        public string trackViewUrl { set; get; }
        public string previewUrl { set; get; }
        public string artworkUrl60 { set; get; }
        public string artworkUrl100 { set; get; }
        public float collectionPrice { set; get; }
        public float trackPrice { set; get; }
        public string collectionExplicitness { set; get; }
        public string trackExplicitness { set; get; }
        public string discCount { set; get; }
        public string discNumber { set; get; }
        public string trackCount { set; get; }
        public string trackNumber { set; get; }
        public string trackTimeMillis { set; get; }
        public string country { set; get; }
        public string currency { set; get; }
        public string primaryGenreName { set; get; }

    }

}
