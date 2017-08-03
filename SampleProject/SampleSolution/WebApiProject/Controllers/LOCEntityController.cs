using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProject.Models;
using WebApiProject.Models.Requests;
using System.Web.Http.Cors;

/*
 * Status:  
 * Add an WebAPI with a similiar endpoint.  
 * Update html code to call this endpoint.
 * Need to be able to bring up test page in 'Website' project (CORS issues).
 * 
 * Routing:
 * https://docs.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2
 * 
 * https://docs.microsoft.com/en-us/aspnet/web-api/overview/security/enabling-cross-origin-requests-in-web-api
 //* */
using WebApplication1.DBContext;

namespace WebApiProject.Controllers
{
    public class LOCEntityController : ApiController
    {
        [HttpGet]
        public LOCData GetFromQueryString([FromUri] LOCRequest location)
        {
            return Get(location.query);
        }

        protected readonly ExperienceITDatabaseEntities ExperienceITDB = new ExperienceITDatabaseEntities();
        // GET api/loc
        private LOCData GetV1(string search)
        {
            var resultsTable = ExperienceITDB.ResultsTables.AsEnumerable();
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
        private LOCData Get(string search)
        {
            var resultsTable = ExperienceITDB.ResultsTables.AsEnumerable();
            var dbresults = resultsTable.Where(x => x.Title.Contains(search));

            using (var db = new ExperienceITDatabaseEntities())
            {
                var query = db.ResultsTables
                        .Where(x => x.Title.Contains(search))
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
                        });

                var data = new LOCData() { results = query.ToList<Result>() };
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
