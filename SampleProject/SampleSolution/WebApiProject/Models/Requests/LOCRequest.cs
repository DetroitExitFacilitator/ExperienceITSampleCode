using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiProject.Models.Requests
{
    /* Step: This object is used to read data from the api call*/
    // Step 6.521: Create a public class called LOCRequest.
    // Step 6.522: add public properties of type string called fo, at, query
    public class LOCRequest
    {
        public string fo { get; set; }
        public string at { get; set; }
        public string query { get; set; }
    }
}