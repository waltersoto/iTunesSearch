
using System.Collections.Generic; 
using System.Runtime.Serialization; 

namespace iTunesSearch
{
    [DataContract]
    public class SearchResult
    {
        public SearchResult()
        {
            Results = new List<Item>();
        }
        [DataMember(Name = "resultCoun", IsRequired = false)]
        public int ResultCount { set; get; }
        [DataMember(Name = "results", IsRequired = false)]
        public List<Item> Results { set; get; }
    }
}
