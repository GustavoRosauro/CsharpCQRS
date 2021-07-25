using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSExample.Infrastructure
{
    public class SqlDatabase:ISqlDatabase
    {
        const string ConnectionString = "Data Source=localhost;Initial Catalog=FACTORY;Integrated Security=True;";
        private readonly SqlConnection _connection;
        private readonly SqlTransaction _trans;
        public SqlDatabase()
        {
            if (_connection == null)
                _connection = new SqlConnection(ConnectionString);
            if (_trans == null)
            {
                _connection.Open();
                _trans = _connection.BeginTransaction();
            }
        }

        public void Commands(string sqlCommand,object model)
        {
            _connection.Execute(sqlCommand,model,_trans);
        }

        public void Commit()
        {
            _trans.Commit();
        }

        public IEnumerable<dynamic> Querys(string sqlQuery, object model)
        {
            return _connection.Query(sqlQuery,model,_trans);
        }

        public void RollBack()
        {
            _trans.Rollback();
        }
    }
}
