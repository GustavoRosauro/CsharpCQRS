using CQRSExample.DTOs;
using CQRSExample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSExample.Querys.Handle
{
    public interface IHandleQuery
    {
        EmployeeDTO Handle(EmployeeQueries employee);
    }
}
