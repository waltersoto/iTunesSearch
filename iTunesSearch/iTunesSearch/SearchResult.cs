using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesSearch
{
    public class SearchResult
    {
        public SearchResult()
        {
            results = new List<Item>();
        }

        public int resultCount { set; get; }
        public List<Item> results { set; get; }
    }
}
