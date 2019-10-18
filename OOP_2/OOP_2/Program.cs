using System;
using Autofac;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfigure.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
                Console.ReadKey();
        }
    }
}
