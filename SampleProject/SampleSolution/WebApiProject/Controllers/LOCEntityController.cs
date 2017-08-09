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
    /* Step: This class is used to define what happens when the '/locEntity' endpoint is called.  
     * In this case, it queries the "ExperienceIT" database, and gets all the results from a table. 
     * It uses Entity to get the data from the database to the internal objects. */
    public class LOCEntityController : ApiController
    {
        [HttpGet]
        public LOCData GetFromQueryString([FromUri] LOCRequest location)
        {
            //return GetV1(location.query);
            return Get(location.query);
        }
        // Step 8.50: Get the entity
        protected readonly ExperienceITDatabaseEntities ExperienceITDB = new ExperienceITDatabaseEntities();

        // Step NA: Returns the LOCData, based on iterating the results from the ResultsTables
        private LOCData GetV1(string search)
        {
            // Step: Return data form using the ResultsTables property
            var resultsTable = ExperienceITDB.ResultsTables.AsEnumerable();
            // Step: Filter based on the title containing the search value
            var dbresults = resultsTable.Where(x => x.Title.Contains(search));
            var data = new LOCData();
            var results = new List<Result>();
            foreach (var dbItem in dbresults)
            {
                var item = new Result();
                item.title = dbItem.Title;
                item.createdOn = dbItem.CreateDate;
                item.image = new Image()
                {
                    full = "https://dummyimage.com/275x275/aaaaaa/000000.jpg&text=" + item.title,
                    square = "https://dummyimage.com/75x75/cccccc/000000.jpg&text=" + item.title
                };
                item.links = new Links()
                {
                    item = "https://dummyimage.com/75x75/aaaaaa/000000.jpg&text=link:" + item.title,
                    resource = "https://dummyimage.com/275x275/aaaaaa/000000.jpg&text=link:" + item.title
                };
                results.Add(item);
            }
            data.results = results;
            return data;
        }
        // Step 8.60: Returns the LOCData, based on using LINQ
        private LOCData Get(string search)
        {
            //QLNOTE:TODO More details needed here.  Also, cover in prior HW?
            // Step: This will create a variable db that contains the entity information.
            using (var db = new ExperienceITDatabaseEntities())
            {
                // Step 8.61: Iterate the ResultsTables.  
                var resultList = db.ResultsTables
                       // Step 8.62: Filter based on the title containing the search value  
                       .Where(x => x.Title.Contains(search))
                        // Step 8.63: transform the data from ResultsTable  to Result
                        .Select<ResultsTable, Result>
                        (t => new Result
                        {
                            title = t.Title,
                            createdOn = t.CreateDate,
                            image = new Image()
                            {
                                full = "https://dummyimage.com/275x275/aaaaaa/000000.jpg&text=" + t.Title,
                                square = "https://dummyimage.com/75x75/cccccc/000000.jpg&text=" + t.Title
                            },
                            links = new Links()
                            {
                                item = "https://dummyimage.com/75x75/aaaaaa/000000.jpg&text=link:" + t.Title,
                                resource = "https://dummyimage.com/275x275/aaaaaa/000000.jpg&text=link:" + t.Title
                            }
                        })
                        .ToList(); // Converts to a list

                // Step: This will return the resultList, and place it in an LOCData object.
                var data = new LOCData() { results = resultList };
                return data;
            }
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
