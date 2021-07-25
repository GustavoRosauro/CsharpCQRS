using CQRSExample.DependencyInjection;
using CQRSExample.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSExample.Repositories
{
    public class EmployeeCommandsRepository : IEmployeeCommandsRepository
    {
        private readonly ISqlDatabase _database;
        public EmployeeCommandsRepository(ISqlDatabase database)
        {
            _database = database;
        }
        public void SaveEmployee(object model)
        {
            var fields = typeof(Employee).GetProperties();
            var queryFields = string.Join(",",fields.Where(x => x.Name.ToLower() != "id").Select(x => x.Name));
            var paramaters = string.Join(",", fields.Where(x => x.Name.ToLower() != "id").Select(x => $"@{x.Name}"));
            string sql = $"INSERT INTO {nameof(Employee)} ({queryFields}) values ({paramaters})";
            _database.Commands(sql,model);
            _database.Commit();
        }
    }
}
