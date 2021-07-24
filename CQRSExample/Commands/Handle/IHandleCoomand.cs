using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSExample.Commands.Handle
{
    public interface IHandleCoomand
    {
        void Handle(EmployeeCommands command);
    }
}
