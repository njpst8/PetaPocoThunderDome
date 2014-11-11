using Microsoft.Ajax.Utilities;
using PetaPoco;

namespace PetaPocoExamples.Controllers
{
    public class GetProductByIdV3
    {
        private readonly Database _database;

        public GetProductByIdV3(Database database)
        {
            _database = database;
        }

        public dynamic Execute(int id)
        {
            return _database.FirstOrDefault<dynamic>("SELECT * FROM Production.Product WHERE ProductId = @0", id);
        }
    }
}