using PetaPoco;

namespace PetaPocoExamples.DI
{
    public interface IDatabaseFactory
    {
        Database Create(string connectionString);
    }

    public class DatabaseFactory : IDatabaseFactory
    {
        public Database Create(string connectionString)
        {
            return new Database(connectionString, "System.Data.SqlClient");
        }
    }
}