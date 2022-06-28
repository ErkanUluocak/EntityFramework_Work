using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ADO.NET
            //Entity Framework -- Bir ORM - Object Relational Mapping
            //NHibernate
            //Dapper

            //GetAll();

            GetProductByCategory(1);

        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();

            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetProductByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();

            var result = northwindContext.Products.Where(p => p.CategoryId == categoryId).ToList();

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

    }
}
