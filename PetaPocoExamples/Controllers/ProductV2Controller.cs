using System.Net;
using System.Net.Http;
using System.Web.Http;
using PetaPocoExamples.Models;

namespace PetaPocoExamples.Controllers
{
    public class ProductV2Controller : ApiController
    {
        private readonly GetProductByIdV2 _getProductByIdV2;

        public ProductV2Controller(GetProductByIdV2 getProductByIdV2)
        {
            _getProductByIdV2 = getProductByIdV2;
        }

        public HttpResponseMessage Get(int id)
        {
            ////Get single record
            var product = _getProductByIdV2.Execute(id);
            return Request.CreateResponse(HttpStatusCode.OK, product);
        }
    }
}
