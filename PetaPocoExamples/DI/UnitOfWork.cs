using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using PetaPoco;

namespace PetaPocoExamples.DI
{
    public interface IUnitOfWork
    {
        Database GetCurrentSession();
    }

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public Guid Id { get; private set; }
        private Database _database;

        public UnitOfWork(IDatabaseFactory databaseFactory)
            : this(databaseFactory,  WebConfigurationManager.ConnectionStrings["example"].ConnectionString)
        {
        }

        public UnitOfWork(IDatabaseFactory databaseFactory, string connectionString)
        {
            _database = databaseFactory.Create(connectionString);
            _database.BeginTransaction();
        }

        public void Dispose()
        {
            CommitOrRollbackChanges();
        }

        private void CommitOrRollbackChanges()
        {
            try
            {
                if (IsInError())
                {
                    _database.AbortTransaction();
                }
                else
                {
                    _database.CompleteTransaction();
                }
            }
            finally
            {
                _database.Dispose();
            }
        }

        private bool IsInError()
        {
            return HttpContext.Current != null && HttpContext.Current.Response.StatusCode >= 400;
        }

        public Database GetCurrentSession()
        {
            return _database;
        }
    }
}