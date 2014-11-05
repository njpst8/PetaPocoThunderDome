using System.Collections.Generic;
using System.Linq;
using PetaPocoExamples.Models;

namespace PetaPocoExamples.Controllers
{
    public class GetProductsByName
    {
        public List<Product> Execute(string productName)
        {
            var db = new PetaPoco.Database("example");

            var product = db.Fetch<Product>("WHERE name like @0", "%" + productName + "%");
            return product;
        }

        /*
         * db.Query vs db.Fetch 
         */
    }
}