using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            //foreach(var p in context.Products)
            //{
            //    context.Products.Remove(p);
            //}
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "Ibuprom",
                    Category = "Pain Relievers",
                    Price = 9.99M,
                    AmountInStock = 2
                },
                new Product
                {
                    Name = "Gripex",
                    Category = "Pain Relievers",
                    Price = 12.99M,
                    IsPrescripted = true,
                    AmountInStock = 9
                },
                new Product
                {
                    Name = "2KC",
                    Category = "Hangover",
                    IsPrescripted = true,
                    Price = 5.99M,
                    AmountInStock = 8
                },
                new Product
                {
                    Name = "Acatar",
                    Category = "Runny nose",
                    Price = 8.49M,
                    AmountInStock = 5
                },
                new Product
                {
                    Name = "Neo-Angin",
                    Category = "Resistance",
                    Price = 3.29M,
                    IsPrescripted = true,
                    AmountInStock = 4
                },
                new Product
                {
                    Name = "Rutinacea",
                    Category = "Resistance",
                    Price = 19.99M,
                    AmountInStock = 0
                },
                new Product
                {
                    Name = "Vitamin K",
                    Category = "Vitamins",
                    Price = 2.0M,
                    AmountInStock = 12
                },
                new Product
                {
                    Name = "Xanax",
                    Category = "Calming",
                    IsPrescripted = true,
                    Price = 29.99M,
                    AmountInStock = 4
                },
                new Product
                {
                    Name = "Regulon",
                    Category = "Contraception",
                    Price = 11.49M,
                    AmountInStock = 21
                },
                new Product
                {
                    Name = "Pritor Plus",
                    Category = "Calming",
                    Price = 16.99M,
                    AmountInStock = 95
                },
                new Product
                {
                    Name = "Voltaren",
                    Category = "Pain Relievers",
                    Price = 15.0M,
                    AmountInStock = 7
                },
                new Product
                {
                    Name = "Apap",
                    Category = "Pain Relievers",
                   Price = 12.99M,
                    AmountInStock = 1
                },
                new Product
                {
                    Name = "Ibum",
                    Category = "Pain Relievers",
                    Price = 13.67M,
                    AmountInStock = 4

                },
                new Product
                {
                    Name = "After",
                    Category = "Hangover",
                    Price = 8.25M,
                    AmountInStock = 6
                },
                new Product
                {
                    Name = "Vitamin C",
                    Category = "Vitamins",
                    Price = 11.19M,
                    AmountInStock = 11
                },
                new Product
                {
                    Name = "Vitamin A",
                    Category = "Vitamins",
                    Price = 6.99M,
                    AmountInStock = 1
                },
                new Product
                {
                    Name = "Vitamin B",
                    Category = "Vitamins",
                    Price = 4.99M,
                    AmountInStock = 2
                }
                
                );

                context.SaveChanges();
            }
        }
    }
}
