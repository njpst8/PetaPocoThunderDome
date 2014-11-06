using PetaPoco;

namespace PetaPocoExamples.Models
{
    public class GetProductByIdV2
    {
        private readonly Database _database;

        public GetProductByIdV2(Database database)
        {
            _database = database;
        }

        public Product Execute(int id)
        {
            var product = _database.SingleOrDefault<Product>("WHERE ProductId = @0", id);

            //// var product = _database.SingleOrDefault<Product>("select * from WHERE ProductId = @0", id);
            return product;
        }
    }
}