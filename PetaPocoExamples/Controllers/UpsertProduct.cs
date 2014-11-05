using PetaPocoExamples.Models;

namespace PetaPocoExamples.Controllers
{
    public class UpsertProduct
    {
        public void Execute(Product product)
        {
            var db = new PetaPoco.Database("example");

            if (db.IsNew("ProductId", product))
            {
                db.Insert("Production.Product", "ProductId", product);
                ////db.Execute("INSERT INTO Production.Product (ProductId....) VALUES (@ProductId...)", product);
            }
            else
            {
                db.Update("Production.Product", "ProductId", product);
            }

            //// [PetaPoco.PrimaryKey("article_id")]
        }

    }
}