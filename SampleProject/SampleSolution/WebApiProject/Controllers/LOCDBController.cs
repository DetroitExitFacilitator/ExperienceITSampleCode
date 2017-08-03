using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data;
using System.Data.SqlClient;
using System.Web.Http;
using WebApiProject.Models;
using WebApiProject.Models.Requests;
using System.Web.Http.Cors;
using System.Configuration;

namespace WebApiProject.Controllers
{
    public class LOCDBController : ApiController
    {
        [HttpGet]
        public LOCData GetFromQueryString([FromUri] LOCRequest location)
        {
            return Get(location.query);
        }

        private static List<Result> Reader(string search)
        {
            string _connectionString = ConfigurationManager.ConnectionStrings["ExperienceITDatabaseConnectionString"].ConnectionString;
            var results = new List<Result>();

            string commandText = "SELECT * FROM ResultsTable";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = (int)reader["id"];

                            var title = (string)reader["title"];
                            if (!title.Contains(search)) continue;
                            string createdOn = (string)reader["createDate"];
                            var result = new Result()
                            {
                                id = id,
                                title = title,
                                createdOn = createdOn,
                                image = new Image()
                                {
                                    full = "//www.loc.gov/pictures/cdn/service/pnp/cph/3c20000/3c23000/3c23000/3c23096_150px.jpg",
                                    square = "https://dummyimage.com/75x75/cccccc/000000.jpg&text=" + title
                                },
                                links = new Links()
                                {
                                    item = "//www.loc.gov/pictures/item/99403554/",
                                    resource = "//www.loc.gov/pictures/item/99403554/resource/"
                                }
                            };
                            results.Add(result);
                        }
                    }
                }
            }
            return results;
        }

        // GET api/loc
        private LOCData Get(string search)
        {
            var data = new LOCData();
            var results = Reader(search);
            foreach (var item in results)
            {
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
            }
            data.results = results;
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
