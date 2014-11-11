using PetaPoco;

namespace PetaPocoExamples.Models
{
    public class OutputFromStoredProcedure
    {
        // This is not wired up to anything it's just used to explain how to get output params from a stored procedure

        public void Execute(Database db)
        {
            var sql = new Sql().Append("declare @@returnParamter int;")
                .Append(string.Format("exec @@returnParameter = dbo.[procName] '{0}', '{1}';", "param1", "param2"))
                .Append("select @@returnParamter");

            var returnValue = db.ExecuteScalar<int>(sql);
        }
    }
}