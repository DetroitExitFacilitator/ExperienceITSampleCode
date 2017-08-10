using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiProject.Models
{
    /* Step: This object is used to define a LOCData object*/
    // Step 6.561: Create a public class called LOCData.
    // Step 6.562: add public properties called results, that returns an IEnumerable of type Result
    public class LOCData
    {
        public IEnumerable<Result> results { get; set; }
    }
}