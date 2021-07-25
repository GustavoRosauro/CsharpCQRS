using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSExample.Infrastructure
{
    public interface ISqlDatabase
    {
        void Commit();
        void RollBack();
        void Commands(string sqlCommand,object model);
        IEnumerable<dynamic> Querys(string sqlQuery, object model);
    }
}
