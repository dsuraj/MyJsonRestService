using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MyJsonRestService.Entity
{
    [DataContract]
    public class Show
    {
        [DataMember]
        public string showImage { get; set; }

        [DataMember]
        public string slug { get; set; }

        [DataMember]
        public string title { get; set; }
    }
}
