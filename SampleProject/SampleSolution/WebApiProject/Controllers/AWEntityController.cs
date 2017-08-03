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
    public class AWEntityController : ApiController
    {
        [HttpGet]
        public LOCData GetFromQueryString([FromUri] LOCRequest location)
        {
            return Get(location.query);
        }

        protected readonly AdventureWorksEntities AdventureWorksDB = new AdventureWorksEntities();
        private LOCData Get(string search)
        {
            var request = HttpContext.Current.Request;
            var urlBase = "http://" + request.Url.Authority + "/WebPages";
            var products = AdventureWorksDB.Products.AsEnumerable().ToList();
            var filtered = products.Where(x => (search == null) || x.Name.Contains(search));
            var filteredFilled = filtered.Where(x => x.ProductProductPhotoes.ElementAt(0).ProductPhotoID != 1);

            var data = new LOCData();
            var results = new List<Result>();
            foreach (var dbItem in filteredFilled)
            {
                var item = new Result();
                item.title = dbItem.Name;
                item.createdOn = dbItem.ModifiedDate.ToString();
                var productPhoto = dbItem.ProductProductPhotoes.First();
                item.image = new Image()
                {
                    full = urlBase + "/ProductImage.ashx?ProductID=" + productPhoto.ProductPhotoID + "&size=large",
                    square = urlBase + "/ProductImage.ashx?ProductID=" + productPhoto.ProductPhotoID + "&size=small"
                };
                item.links = new Links()
                {
                    item = urlBase + "/ProductImage.ashx?ProductID=" + productPhoto.ProductPhotoID + "&size=small",
                    resource = urlBase + "/ProductImage.ashx?ProductID=" + productPhoto.ProductPhotoID + "&size=large"
                };
                results.Add(item);
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
