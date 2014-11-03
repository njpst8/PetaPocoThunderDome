using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PetaPocoExamples.Models;

namespace PetaPocoExamples.Controllers
{
    public class ProductController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public HttpResponseMessage Get(int id)
        {
            var db = new PetaPoco.Database("example");
            var product = db.SingleOrDefault<Product>("WHERE ProductId = @0", id);
            return Request.CreateResponse(HttpStatusCode.OK, product);
        }

        // GET api/<controller>/5
        public HttpResponseMessage Get(string  productName)
        {
            var db = new PetaPoco.Database("example");
            var product = db.Query<Product>("WHERE name like @0", "%"+productName+"%").ToList();
            return Request.CreateResponse(HttpStatusCode.OK, product);
        }


        public HttpResponseMessage Get(string productName, int pageNumber, int recordCount)
        {
            var db = new PetaPoco.Database("example");
            var product = db.Page<Product>(pageNumber, recordCount, "WHERE name like @0 order by name",
                "%" + productName + "%");
            return Request.CreateResponse(HttpStatusCode.OK, product.Items);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}