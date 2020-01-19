using dataSample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using Xunit;

namespace sample.test
{
    public class MyEntityLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new MyLogger();
        }

        public void Dispose()
        {

        }
    }

    class MyLogger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            var oFormat = formatter(state, exception);
            //File.AppendAllText(@"C:\sw-dev\Logs", oFormat);
            Debug.WriteLine($"EXECUTED QUERY:\n{oFormat}");
        }
    }

    public class UnitTest1
    {

        public UnitTest1()
        {
            using (var context = new SampleContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                dataSample.Sql.Insert.Split("GO").ToList().ForEach(x =>
                {
                    context.Database.ExecuteSqlRaw(x);
                });
            }
        }

        [Fact]
        public void Update()
        {
            Expression<Func<Customer,bool>> expr = (Customer c) => c.Id < 5;

            using (var context = new SampleContext())
            {
                context.GetService<ILoggerFactory>().AddProvider(new MyEntityLoggerProvider());
                var customers = context.Customer.ToList();

                context.Update(new { FirstName = "Prueba" }, expr);


                customers.Where(expr.Compile()).ToList().ForEach(x =>
                {
                    Assert.True(x.FirstName != "Prueba");
                });

                context.SaveChanges();
            }

            using (var context = new SampleContext())
            {
                context.GetService<ILoggerFactory>().AddProvider(new MyEntityLoggerProvider());
                var customers = context.Customer.ToList();

                customers.Where(expr.Compile()).ToList().ForEach(x =>
                {
                    Assert.True(x.FirstName == "Prueba");
                });
            }
        }

        [Fact]
        public void Delete()
        {
            Expression<Func<Product, bool>> expr = (Product c) => c.Id > 5 && c.Id<20;

            using (var context = new SampleContext())
            {
                context.GetService<ILoggerFactory>().AddProvider(new MyEntityLoggerProvider());
                var products = context.Product.ToList();

                context.Remove(expr);

                context.SaveChanges();
            }

            using (var context = new SampleContext())
            {
                context.GetService<ILoggerFactory>().AddProvider(new MyEntityLoggerProvider());
                var products = context.Product.Where(expr.Compile()).ToList();

                Assert.True(!products.Any());
            }
        }

        [Fact]
        public void NoExpression()
        {
            ///UPDATE
            using (var context = new SampleContext())
            {
                context.GetService<ILoggerFactory>().AddProvider(new MyEntityLoggerProvider());

                context.Update(new { OrderNumber = "Prueba" }, (Order o) => 1 == 1);

                context.SaveChanges();
            }

            using (var context = new SampleContext())
            {
                context.GetService<ILoggerFactory>().AddProvider(new MyEntityLoggerProvider());

                context.Order.ToList().ForEach(x =>
                {
                    Assert.True(x.OrderNumber == "Prueba");
                });
            }

            //DELETE
            using (var context = new SampleContext())
            {
                context.GetService<ILoggerFactory>().AddProvider(new MyEntityLoggerProvider());
                
                context.Remove<Order>();

                context.SaveChanges();
            }

            using (var context = new SampleContext())
            {
                context.GetService<ILoggerFactory>().AddProvider(new MyEntityLoggerProvider());

                Assert.True(!context.Order.Any());
            }
        }
    }
}
