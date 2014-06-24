using System.Runtime.Serialization;

namespace MyJsonRestService.Entity
{
    [DataContract]
    public class Season
    {
        [DataMember]
        public string slug { get; set; }
    }
}