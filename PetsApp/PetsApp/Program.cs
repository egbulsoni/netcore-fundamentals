using PetsApp.Data;
using PetsApp.Models;
using System;
using System.Linq;

namespace PetsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using ContosoPetsContext context = new ContosoPetsContext();
            Product squeakyBone = new Product();
            //{
            //    Name = "Squeaky Dog Bone",
            //    Price = 4.99M
            //};
            //context.Products.Add(squeakyBone);
            //Product tennisBalls = new Product()
            //{
            //    Name = "Tennis Ball 3-pack",
            //    Price = 9.99M
            //};
            //context.Add(tennisBalls);
            //context.SaveChanges();

            var products = context.Products
                .Where(p => p.Price >= 5.00m)
                .OrderBy(p => p.Name);


            //var squeakyBone = context.Products
            //    .Where(p => p.Name == "Squeaky Dog Bone")
            //    .FirstOrDefault();

            if (squeakyBone is Product)
            {
                //squeakyBone.Price = 7.99m;
                context.Remove(squeakyBone);
            }
            context.SaveChanges();

            foreach (Product p in products)
            {
                Console.WriteLine($"Id:     {p.Id}");
                Console.WriteLine($"Id:     {p.Name}");
                Console.WriteLine($"Id:     {p.Price}");
                Console.WriteLine(new string('-', 20));
            }
        }
    }
}
