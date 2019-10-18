using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace OOP_2
{
    public static class ContainerConfigure
    {
        public static IContainer Configure ()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<TennisTable>().As<ITennisTable>();
            builder.RegisterType<TennisRules>().As<ITennisRules>();

            return builder.Build();
        }
    }
}
