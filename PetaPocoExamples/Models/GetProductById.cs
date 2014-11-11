namespace PetaPocoExamples.Models
{
    public class GetProductById
    {
        public Product Execute(int id)
        {
            var db = new PetaPoco.Database("example");
            var product = db.SingleOrDefault<Product>("WHERE ProductId = @0", id);

            ////Use the SELECT statement
            // var product2 = db.SingleOrDefault<Product>("select * from Production.Product WHERE ProductId = @0", id);

            ////Use the SQL Builder - good for building condidtional sql
            //var sql = PetaPoco.Sql.Builder.Append("SELECT * FROM Production.Product")
            //    .Append("WHERE ProuctId = @0", id);
            //var p = db.SingleOrDefault<Product>(sql);
            return product;
        }
    }
}