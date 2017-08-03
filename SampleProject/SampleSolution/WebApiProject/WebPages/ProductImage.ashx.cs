using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DBContext;

namespace AdventureWorks
{
    /// <summary>
    /// Summary description for ProductImage
    /// </summary>
    public class ProductImage : IHttpHandler
    {
        protected readonly AdventureWorksEntities AdventureWorksDB = new AdventureWorksEntities();

        public void ProcessRequest(HttpContext context)
        {
            int prodId;
            int.TryParse(context.Request.QueryString["ProductID"], out prodId);
            byte[] img;
            if (prodId > 0)
            {
                var photos = AdventureWorksDB.ProductPhotoes.Where(x => x.ProductPhotoID == prodId);

                if (photos != null)
                {
                    var photo = photos.FirstOrDefault();
                    if (photo == null) return;
                    if (context.Request.QueryString["size"] != null && context.Request.QueryString["size"] == "large")
                    {
                        img = photo.LargePhoto;
                    }
                    else
                    {
                        img = photo.ThumbNailPhoto;
                    }
                    context.Response.Cache.SetExpires(DateTime.Today.AddMonths(3));
                    context.Response.Cache.SetCacheability(HttpCacheability.Public);
                    context.Response.Cache.SetValidUntilExpires(true);
                    //context.Response.AddHeader("Access-Control-Allow-Headers", "*");
                    //context.Response.AddHeader("Access-Control-Allow-Credentials", "true");
                    //context.Response.AddHeader("Access-Control-Allow-Methods", "GET,PUT,POST,DELETE");
                    context.Response.ContentType = "image/jpeg";
                    context.Response.BinaryWrite(img);
                    context.Response.Flush();
                    context.Response.End();
                }
                else
                {
                    context.Response.Write("No Image Availabe");
                    context.Response.End();
                }
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}