using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiProject.Models.Requests
{
    /* Step: This object is used to read data from the api call*/
    public class LOCRequest
    {
        public string fo { get; set; }
        public string at { get; set; }
        public string query { get; set; }
    }
}