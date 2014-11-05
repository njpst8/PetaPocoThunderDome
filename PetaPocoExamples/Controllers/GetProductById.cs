using PetaPocoExamples.Models;

namespace PetaPocoExamples.Controllers
{
    public class GetProductById
    {
        public Product Execute(int id)
        {
            var db = new PetaPoco.Database("example");
            var product = db.SingleOrDefault<Product>("WHERE ProductId = @0", id);
            return product;
        }
    }
}