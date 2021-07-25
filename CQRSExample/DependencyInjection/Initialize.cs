using CQRSExample.Commands;
using CQRSExample.Commands.Handle;
using CQRSExample.Infrastructure;
using CQRSExample.Querys.Handle;
using CQRSExample.Repositories;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSExample.DependencyInjection
{
    public class Initialize
    {
        public static IHandleCoomand Injection()
        {
            var container = new Container();
            Register(container);
            return container.GetInstance<IHandleCoomand>();
        }
        public static IHandleQuery InjectionQuerys()
        {
            var container = new Container();
            Register(container);
            return container.GetInstance<IHandleQuery>();
        }        
        private static void Register(Container container)
        {
            container.Register<IEmployeeCommandsRepository, EmployeeCommandsRepository>();
            container.Register<IEmployeeQueriesRepository, EmployeeQueriesRepository>();
            container.Register<ISqlDatabase, SqlDatabase>();
            container.Register<IHandleCoomand, HandleCommand>();
            container.Register<IHandleQuery, HandleQuery>();
        }
    }
}
