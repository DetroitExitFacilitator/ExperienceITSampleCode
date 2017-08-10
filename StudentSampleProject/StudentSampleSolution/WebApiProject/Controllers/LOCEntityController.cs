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

namespace WebApiProject.Controllers
{
    /* This class is used to define what happens when the '/locEntity' endpoint is called.  
     * In this case, it queries the "ExperienceIT" database, and gets all the results from a table. 
     * It uses Entity to get the data from the database to the internal objects. */
    public class LOCEntityController : ApiController
    {
        [HttpGet]
        public LOCData GetFromQueryString([FromUri] LOCRequest location)
        {
            return Get(location.query);
        }

        // Step 8.50: Get the entity
        //Student: Insert Code Here.
        protected readonly ExperienceITDatabaseEntities ExperienceITDB = null;

        // Step 8.60 Returns the LOCData, based on using LINQ
        private LOCData Get(string search)
        {
            // This will create a variable db that contains the entity information.
            using (var db = new ExperienceITDatabaseEntities())
            {
                // Step 8.61: Iterate the ResultsTables.  
                var resultList = db.ResultsTables
                  // Step 8.62: Filter based on the title containing the search value  
                  //Student: Update Code Here.
                  .Where(x => true)
                    // Step 8.63: transform the data from ResultsTable  to Result
                    .Select<ResultsTable, Result>
                    (t => new Result
                    {
                        //Student: Insert Code Here.

                    })
                    .ToList(); // Converts to a list

                // This will return the resultList, and place it in an LOCData object.
                var data = new LOCData() { results = resultList };
                throw new NotImplementedException();
                return null;
            }
        }
    }
}
