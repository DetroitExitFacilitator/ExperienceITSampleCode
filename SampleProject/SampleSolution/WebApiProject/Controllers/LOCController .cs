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
    /* Step: This class is used to define what happens when the '/loc' endpoint is called*/
    public class LOCController : ApiController
    {
        /* Step: Need to create  object LOCRequest, as well as:
         LOCData, Result, Image, and Links*/
        [HttpGet]
        public LOCData GetFromQueryString([FromUri] LOCRequest location)
        {
            var search = location.query;
            // Step: Return the LOCData object, with sample data 
            var data = new LOCData();
            data.results = new List<Result>
            {
          // Step: Return the Result object, with sample data 
               new Result()
                {
                    title = "SAMPLE: Michigan, Detroit, Campus Martius",
                    createdOn = "[between 1920 and 1940]",
         // Step: Return the Image object, with sample data 
                   image = new Image()
                    {
                        full ="//www.loc.gov/pictures/cdn/service/pnp/cph/3c20000/3c23000/3c23000/3c23096_150px.jpg",
                        square ="https://dummyimage.com/75x75/cccccc/000000.jpg&text=gsdfgdfsdf+dsaf+"
                    },
          // Step: Return the Links object, with sample data 
                   links = new Links()
                    {
                        item ="//www.loc.gov/pictures/item/99403554/",
                        resource ="//www.loc.gov/pictures/item/99403554/resource/"
                    }
                },
           // Step: Create a second Result object.  
              new Result()
                {
                    title = "SAMPLE: [Shubert's Detroit Opera House, Campus Martins, Detroit, Michigan]",
                    createdOn =  "1929.",
                    image = new Image()
                    {
                        full ="//www.loc.gov/pictures/cdn/service/pnp/cph/3c30000/3c34000/3c34900/3c34960_150px.jpg",
                        square = "//cdn.loc.gov/service/pnp/cph/3c30000/3c34000/3c34900/3c34960_75x75px.jpg",
                    },
                    links = new Links()
                    {
                        item = "//www.loc.gov/pictures/item/2004675446/",
                        resource ="//www.loc.gov/pictures/item/2004675446/resource/"
                    }
                }
            };
            return data;
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
