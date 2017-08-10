using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WebApiProject.Models
{
    /* Step: This object is used to define a Result object*/
    // Step 6.551: Create a public class called Result.
    // Student: Update Code Here.
    // Step 6.552: Add an attribute called DataContract to the class.
    //    This is used so we can rename properties.
    public class Result
    {


        // Step 6.553: add public properties called:
        //    named id, title, createdOn, image, links, ignore.

        public Image image { get; set; }

        public Links links { get; set; }

        // Step 6.554: Using attributes, give the property createdOn and external name of created_published_date
        // Student: Insert Code Here.
    }
}