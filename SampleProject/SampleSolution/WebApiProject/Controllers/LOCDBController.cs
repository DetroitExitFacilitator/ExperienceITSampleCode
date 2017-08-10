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
    /* Step: This class is used to define what happens when the '/locdb' endpoint is called.  
     * In this case, it queries the "ExperienceIT" database, and gets all the results from a table. 
     * It uses ADO.Net to get the data from the database to the internal objects. */
    public class LOCDBController : ApiController
    {
        [HttpGet]
        public LOCData GetFromQueryString([FromUri] LOCRequest location)
        {
            var data = new LOCData();
            data.results = Reader(location.query);
            return data;
        }

        // Return a list of Results, from the "ResultsTable" SQL table.
        // Step 7.50: Create a static method, named Reader, that takes a string named search, and returns an List of type Result 
        private static List<Result> Reader(string search)
        {
            // Step 7.51: return the connection string define in the web.config file, under "ExperienceITDatabaseConnectionString"
            string _connectionString = ConfigurationManager.ConnectionStrings["ExperienceITDatabaseConnectionString"].ConnectionString;
            var results = new List<Result>();

            // Step 7.60: Specify the SQL statement to use.  Get all data from the "ResultsTable" 
            string commandText = "SELECT * FROM ResultsTable";

            // Step 7.70: Create a connection object. */
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                // Step 7.80: Create a command object that uses the connection and the commandText 
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    // Step 7.90: Open a connection
                    connection.Open();
                    // Step 7.100: Read the data.
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Step 7.110: Read one row at a time, from the table.
                        while (reader.Read())
                        {
                            // Step 7.111: read the id, title value from the reader, and set an id, and title variable.

                            var id = (int)reader["id"];

                            var title = (string)reader["title"];
                            // Step 7.112:  If the title does not contain the search, continue
                            if (!title.Contains(search)) continue;
                            string createdOn = (string)reader["createDate"];
                            // Step 7.120: Based on the returned data, create a Results object. "TTT" should be replace with the title.
                            var result = new Result()
                            {
                                id = id,
                                title = title,
                                createdOn = createdOn,
                                image = new Image()
                                {
                                    full = "https://dummyimage.com/275x275/aaaaaa/000000.jpg&text=" + title,
                                    square = "https://dummyimage.com/75x75/cccccc/000000.jpg&text=" + title
                                },
                                links = new Links()
                                {
                                    item = "https://dummyimage.com/75x75/aaaaaa/000000.jpg&text=link:" + title,
                                    resource = "https://dummyimage.com/275x275/aaaaaa/000000.jpg&text=link:" + title
                                }
                            };
                            // Step 7.121: Add the result to the results object.
                            results.Add(result);
                        }
                    }
                }
            }
            return results;
        }

    }
}
