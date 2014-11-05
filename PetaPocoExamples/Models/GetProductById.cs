namespace PetaPocoExamples.Models
{
    public class GetProductById
    {
        public Product Execute(int id)
        {
            var db = new PetaPoco.Database("example");
            var product = db.SingleOrDefault<Product>("WHERE ProductId = @0", id);

            //// var product = db.SingleOrDefault<Product>("select * from WHERE ProductId = @0", id);
            return product;
        }
    }
}