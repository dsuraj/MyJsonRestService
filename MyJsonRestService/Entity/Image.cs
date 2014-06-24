using System.Runtime.Serialization;

namespace MyJsonRestService.Entity
{
    [DataContract]
    public class Image
    {
        [DataMember]
        public string showImage { get; set; }
    }
}