using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WebApiProject.Models
{
    [DataContract]
    public class Result
    {
        [DataMember]
        public int id { get; set; }
        [DataMember(Name = "title")]
        public string title { get; set; }
        [DataMember(Name = "created_published_date")]
        public string createdOn { get; set; }
        [DataMember]
        public Image image { get; set; }
        [DataMember]
        public Links links { get; set; }
        [IgnoreDataMember]  //Don't serialize this one
        public Links ignore { get; set; }
    }

}