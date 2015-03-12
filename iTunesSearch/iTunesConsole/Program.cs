using System;
using System.Linq;
using iTunesSearch;

namespace iTunesConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            SearchRequest s = new SearchRequest(Media.podcast) {
                Parameters = { {"country","us"} }
            };

            var result = s.Search(".NET Rocks");

            foreach (var item in result.Results.Take(5))
            {
                Console.WriteLine(item.TrackName);
                Console.WriteLine("by {0}", item.ArtistName);
                Console.WriteLine(item.FeedUrl); 
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }
 
    }
}
