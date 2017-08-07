using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProject.Models;
using WebApiProject.Models.Requests;
using System.Web.Http.Cors;

namespace WebApiProject.Controllers
{
    /*This class is used to define what happens when the '/loc' endpoint is called*/
    public class LOCController : ApiController
    {
        /* Step 6.50: Need to create  object LOCRequest, as well as:
         LOCData, Result, Image, and Links*/

        [HttpGet]
        public LOCData GetFromQueryString([FromUri] LOCRequest location)
        {
            var search = location.query;
            // Step 6.60: Return the LOCData object, with sample data 
            var data = new LOCData();
            data.results = new List<Result>
            {
          // Step 6.70: Return the Result object, with sample data 
               new Result()
                {
          //Student: Insert your code here

          // Step 6.80: Return the Image object, with sample data 
                   image = new Image()
                    {
                       //Student: Insert your code here
                    },
          // Step 6.90: Return the Links object, with sample data 
                   links = new Links()
                    {
                       //Student: Insert your code here
                    }
                },
           // Step 6.100: Create a second Result object.  
              new Result()
                {
                  //Student: Insert your code here
                }
            };
            //Student: return Data 
            throw new NotImplementedException();
        }

        //// GET api/loc/5
        //[Route("api/locaaa/{search}")]
        //[HttpGet]
        //public LOCData Getaaa(string search)
        //{
        //    return Get(search);
        //}

        //// GET api/loc/5
        //[Route("api/loc/{fo}/{at}/{query}")]
        //[HttpGet]
        //public LOCData Getbbb(string fo, string at, string query)
        //{
        //    return Get(query);
        //}


        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
