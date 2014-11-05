using System.Net;
using System.Net.Http;
using System.Web.Http;
using PetaPocoExamples.Models;

namespace PetaPocoExamples.Controllers
{
    public class ProductController : ApiController
    {
        public HttpResponseMessage Get(int id)
        {
            ////Get single record
            var product = new GetProductById().Execute(id);
            return Request.CreateResponse(HttpStatusCode.OK, product);
        }

        public HttpResponseMessage Get(string  productName)
        {
            var product = new GetProductsByName().Execute(productName);
            return Request.CreateResponse(HttpStatusCode.OK, product);
        }

        public HttpResponseMessage Get(string productName, int pageNumber, int recordCount)
        {
            var product = new GetProductByNameWithPaging().Execute(productName, pageNumber, recordCount);
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