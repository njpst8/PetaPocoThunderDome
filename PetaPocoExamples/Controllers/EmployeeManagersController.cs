using System.Net;
using System.Net.Http;
using System.Web.Http;
using PetaPocoExamples.Models;

namespace PetaPocoExamples.Controllers
{
    public class EmployeeManagersController : ApiController
    {
        public HttpResponseMessage Get(int businessEntityId)
        {
            var db = new PetaPoco.Database("example");
            var product = db.Query<EmployeeManager>(string.Format("; exec uspGetEmployeeManagers {0}", businessEntityId));
            return Request.CreateResponse(HttpStatusCode.OK, product);
        }

    }
}
