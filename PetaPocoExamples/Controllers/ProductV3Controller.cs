using System.Web.Http;

namespace PetaPocoExamples.Controllers
{
    public class ProductV3Controller : ApiController
    {
        private readonly GetProductByIdV3 _getProductByIdV3;

        public ProductV3Controller(GetProductByIdV3 getProductByIdV3)
        {
            _getProductByIdV3 = getProductByIdV3;
        }

        public dynamic Get(int id)
        {
            //JSON formatter neeeds to be enabled in order for the dynamic to be returend
            //Configuration.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        
            var product = _getProductByIdV3.Execute(id);
            return product;
        }
    }
}
