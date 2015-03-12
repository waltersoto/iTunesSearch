 
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace iTunesSearch
{

    [DataContract]
    public class Item
    {
        public Item()
        {
            GenreIDs = new List<string>();
            Genres = new List<string>();

        }

        [DataMember(Name = "wrapperType", IsRequired = false)]
        public string WrapperType { set; get; }

        [DataMember(Name = "kind", IsRequired = false)]
        public string Kind { set; get; }

        [DataMember(Name = "artistID", IsRequired = false)]
        public string ArtistID { set; get; }

        [DataMember(Name = "collectionID", IsRequired = false)]
        public string CollectionID { set; get; }

        [DataMember(Name = "trackId", IsRequired = false)]
        public string TrackId { set; get; }

        [DataMember(Name = "artistName", IsRequired = false)]
        public string ArtistName { set; get; }

        [DataMember(Name = "collectionName", IsRequired = false)]
        public string CollectionName { set; get; }

        [DataMember(Name = "trackName", IsRequired = false)]
        public string TrackName { set; get; }

        [DataMember(Name = "collectionCensoredName", IsRequired = false)]
        public string CollectionCensoredName { set; get; }

        [DataMember(Name = "trackCensoredName", IsRequired = false)]
        public string TrackCensoredName { set; get; }

        [DataMember(Name = "artistViewUrl", IsRequired = false)]
        public string ArtistViewUrl { set; get; }

        [DataMember(Name = "feedUrl", IsRequired = false)]
        public string FeedUrl { set; get; }

        [DataMember(Name = "trackViewUrl", IsRequired = false)]
        public string TrackViewUrl { set; get; }

        [DataMember(Name = "previewUrl", IsRequired = false)]
        public string PreviewUrl { set; get; }

        [DataMember(Name = "artworkUrl60", IsRequired = false)]
        public string ArtworkUrl60 { set; get; }

        [DataMember(Name = "artworkUrl100", IsRequired = false)]
        public string ArtworkUrl100 { set; get; }

        [DataMember(Name = "collectionPrice", IsRequired = false)]
        public float CollectionPrice { set; get; }

        [DataMember(Name = "trackPrice", IsRequired = false)]
        public float TrackPrice { set; get; }

        [DataMember(Name = "collectionExplicitness", IsRequired = false)]
        public string CollectionExplicitness { set; get; }

        [DataMember(Name = "trackExplicitness", IsRequired = false)]
        public string TrackExplicitness { set; get; }

        [DataMember(Name = "discCount", IsRequired = false)]
        public string DiscCount { set; get; }

        [DataMember(Name = "discNumber", IsRequired = false)]
        public string DiscNumber { set; get; }

        [DataMember(Name = "trackCount", IsRequired = false)]
        public string TrackCount { set; get; }

        [DataMember(Name = "trackNumber", IsRequired = false)]
        public string TrackNumber { set; get; }

        [DataMember(Name = "trackTimeMillis", IsRequired = false)]
        public string TrackTimeMillis { set; get; }

        [DataMember(Name = "country", IsRequired = false)]
        public string Country { set; get; }

        [DataMember(Name = "currency", IsRequired = false)]
        public string Currency { set; get; }

        [DataMember(Name = "primaryGenreName", IsRequired = false)]
        public string PrimaryGenreName { set; get; }

        [DataMember(Name = "genreIDs", IsRequired = false)]
        public List<string> GenreIDs { set; get; }

        [DataMember(Name = "genres", IsRequired = false)]
        public List<string> Genres { set; get; }
    }

}
