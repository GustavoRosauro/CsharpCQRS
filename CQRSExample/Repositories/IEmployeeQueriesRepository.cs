using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSExample.Repositories
{
    public interface IEmployeeQueriesRepository
    {
        Employee GetById(int employeeId);
    }
}
