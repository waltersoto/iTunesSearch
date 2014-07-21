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
            Results = new List<Item>();
        }

        public int ResultCount { set; get; }
        public List<Item> Results { set; get; }
    }
}
