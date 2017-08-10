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
    /* This class is used to define what happens when the '/AWEntity' endpoint is called.  
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
        //Student: Update your code here
        protected readonly AdventureWorksEntities AdventureWorksDB = null;


        // Step 9.60: Returns the LOCData, based on iterating the results from the Products object */
        private LOCData Get(string search)
        {
            // This will allow to get the base url.
            var request = HttpContext.Current.Request;
            var urlBase = "http://" + request.Url.Authority + "/WebPages";
            // Step 9.61: Create a products variable that gets data from the Products entity.  Convert it to a List
            //Student: Update your code here
            //var products = null;
            // Step 9.62: Create a filtered variable, using LINQ that filters if either search == null or the name contains search.
            //Student: Update your code here
            //var filtered = products.Where(x => true);
            // Step 9.63: Create a filteredFilled that filters out data with no images.  This can be determined by: 
            // making sure the ProductProductPhotoes.ElementAt(0).ProductPhotoID value is not 1
            //Student: Update your code here
            //var filteredFilled = filtered.Where(x => true);

            var data = new LOCData();
            var results = new List<Result>();
            // Step 9.64: Interate through all the filteredFilled items using the dbItems name.
            // foreach ...
            {
                // Step 9.65: For each item, create a Result object, call it item.
                //Student: Update your code here
                //var item = null;
                // Step 9.66: Populate the title with the dbItems' Name
                //Student: Update your code here
                //item.title = null;
                // Step 9.67: Populate the createdOn with the dbItems' ModifiedDate (need to convert it to a string)
                //Student: Update your code here
                //item.createdOn = null;
                // Step 9.68: The photo object can be gotten using dbItem.ProductProductPhotoes.First(), which grabs the first photo.
                //var productPhoto = null;
                // Step 9.69: Uncomment below.  This will initialise the image, and links object with image urls.
                // item.image = new Image()
                // {
                //     full = urlBase + "/ProductImage.ashx?ProductID=" + productPhoto.ProductPhotoID + "&size=large",
                //     square = urlBase + "/ProductImage.ashx?ProductID=" + productPhoto.ProductPhotoID + "&size=small"
                // };
                // item.links = new Links()
                // {
                //     item = urlBase + "/ProductImage.ashx?ProductID=" + productPhoto.ProductPhotoID + "&size=small",
                //     resource = urlBase + "/ProductImage.ashx?ProductID=" + productPhoto.ProductPhotoID + "&size=large"
                // };
                //results.Add(item);
            }
            // data.results = results;
            return data;
        }
    }
}
