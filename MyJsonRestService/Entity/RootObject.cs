using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyJsonRestService.Entity
{
    [DataContract]
    public class RootObject
    {
        [DataMember]
        public List<Payload> payload { get; set; }

        [DataMember]
        public int skip { get; set; }

        [DataMember]
        public int take { get; set; }

        [DataMember]
        public int totalRecords { get; set; }
    }
}