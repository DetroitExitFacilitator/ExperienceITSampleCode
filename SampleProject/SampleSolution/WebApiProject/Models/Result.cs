using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WebApiProject.Models
{
    /* Step: This object is used to define a Result object*/
    // Step 6.551: Create a public class called Links.
    // Step 6.552: Add an attribute called DataContract to the class.
    //    This is used so we can rename properties.
    // Step 6.553: add public properties called:
    //    named id, title, createdOn, image, links, ignore.
    //    for image, define it as an Image object
    //    for links, define it as an Links object.
    // Step 6.554: Using attributes, give the property createdOn and external name of created_published_date
    //QLNOTE:  This should be covered in a prior HW?

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