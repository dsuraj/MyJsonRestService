using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyJsonRestService.Entity
{
    [DataContract]
    public class Payload
    {
        [DataMember]
        public string country { get; set; }

        [DataMember]
        public string description { get; set; }

        [DataMember]
        public bool drm { get; set; }

        [DataMember]
        public int episodeCount { get; set; }

        [DataMember]
        public string genre { get; set; }

        [DataMember]
        public Image image { get; set; }

        [DataMember]
        public string language { get; set; }

        [DataMember]
        public NextEpisode nextEpisode { get; set; }

        [DataMember]
        public string primaryColour { get; set; }

        [DataMember]
        public List<Season> seasons { get; set; }

        [DataMember]
        public string slug { get; set; }

        [DataMember]
        public string title { get; set; }

        [DataMember]
        public string tvChannel { get; set; }
    }
}