using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjectionLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddSingleton<ISingletonClass, SomeClass>();
            services.AddTransient<ITransientClass, SomeClass>();
            services.AddScoped<IScopedClass, SomeClass>();
            ServiceProvider _serviceProvider = services.BuildServiceProvider(true);


            using (var scope = _serviceProvider.CreateScope())
            {
                Console.WriteLine("Scope 1");
                Console.WriteLine("First Request");
                var singleton = scope.ServiceProvider.GetRequiredService<ISingletonClass>().Something;
                var scoped = scope.ServiceProvider.GetRequiredService<IScopedClass>().Something;
                var transient = scope.ServiceProvider.GetRequiredService<ITransientClass>().Something;

                Console.WriteLine("Singleton: " + singleton);
                Console.WriteLine("Scoped: " + scoped);
                Console.WriteLine("Transient: " + transient);

                Console.WriteLine("Second Request");
                var singleton2 = scope.ServiceProvider.GetRequiredService<ISingletonClass>().Something;
                var scoped2 = scope.ServiceProvider.GetRequiredService<IScopedClass>().Something;
                var transient2 = scope.ServiceProvider.GetRequiredService<ITransientClass>().Something;
                var transient3 = scope.ServiceProvider.GetRequiredService<ITransientClass>().Something;

                Console.WriteLine("Singleton: " + singleton2);
                Console.WriteLine("Scoped: " + scoped2);
                Console.WriteLine("Transient: " + transient2);
            }

            using (var scope = _serviceProvider.CreateScope())
            {
                Console.WriteLine("Scope 2");
                Console.WriteLine("First Request");
                var singleton = scope.ServiceProvider.GetRequiredService<ISingletonClass>().Something;
                var scoped = scope.ServiceProvider.GetRequiredService<IScopedClass>().Something;
                var transient = scope.ServiceProvider.GetRequiredService<ITransientClass>().Something;

                Console.WriteLine("Singleton: " + singleton);
                Console.WriteLine("Scoped: " + scoped);
                Console.WriteLine("Transient: " + transient);
            }


        }
    }
}
