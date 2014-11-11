namespace PetaPocoExamples.Models
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

            //// Alternatively we could have decorated the POCO with the following attribute to eleminate some code
            //// [PetaPoco.PrimaryKey("article_id")]
            //if (db.IsNew(product))
            //{
            //    db.Insert(product);
            //}
            //else
            //{
            //    db.Update(product);
            //}

            ////We can condense that with db.save
            //db.Save(product);
            ////or
            //db.Save("Production.Product", "ProductId", product);

            ////Or we can just roll with db.Execute
            //db.Execute("INSERT INTO Production.Product (ProductId....) VALUES (@ProductId...)", product);
            
        }

    }
}