using PetaPoco;
using PetaPocoExamples.Models;

namespace PetaPocoExamples.Controllers
{
    public class GetProductByNameWithPaging
    {
        public Page<Product> Execute(string productName, int pageNumber, int recordCount)
        {
            var db = new PetaPoco.Database("example");
            var product = db.Page<Product>(pageNumber, recordCount, "WHERE name like @0 order by name",
                "%" + productName + "%");
            return product;
        }
    }
}