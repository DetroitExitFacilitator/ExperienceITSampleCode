using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProject.Models;
using WebApiProject.Models.Requests;
using System.Web.Http.Cors;
using WebApplication1.DBContext;
using System.Web;

namespace WebApiProject.Controllers
{
    /* Step: This class is used to define what happens when the '/AWEntity' endpoint is called.  
     * In this case, it queries the "AdventureWorks" database, and gets all the results from a table. 
     * */
    public class AWEntityController : ApiController
    {
        [HttpGet]
        public LOCData GetFromQueryString([FromUri] LOCRequest location)
        {
            return Get(location.query);
        }

        // Step 9.50: Get the entity
        // protected readonly AdventureWorksEntities AdventureWorksDB = new AdventureWorksEntities();


        // Step 9.60: Returns the LOCData, based on iterating the results from the Products object */
        private LOCData Get(string search)
        {
            //Student: Replace this Code to Query AdventureWorksDB and return LOCData
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
