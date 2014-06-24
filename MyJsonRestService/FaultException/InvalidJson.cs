using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace MyJsonRestService.FaultException
{
    [DataContract]
    public class InvalidJson
    {
        [DataMember]
        public string Error { get; set; }
    }
}
