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
                    Price = 9.99M
                },
                new Product
                {
                    Name = "Gripex",
                    Category = "Pain Relievers",
                    Price = 12.99M,
                    IsPrescripted = true
                },
                new Product
                {
                    Name = "2KC",
                    Category = "Hangover",
                    IsPrescripted = true,
                    Price = 5.99M
                },
                new Product
                {
                    Name = "Acatar",
                    Category = "Runny nose",
                    Price = 8.49M
                },
                new Product
                {
                    Name = "Neo-Angin",
                    Category = "Resistance",
                    Price = 3.29M,
                    IsPrescripted = true
                },
                new Product
                {
                    Name = "Rutinacea",
                    Category = "Resistance",
                    Price = 19.99M
                },
                new Product
                {
                    Name = "Vitamin K",
                    Category = "Vitamins",
                    Price = 2.0M
                },
                new Product
                {
                    Name = "Xanax",
                    Category = "Calming",
                    IsPrescripted = true,
                    Price = 29.99M
                },
                new Product
                {
                    Name = "Regulon",
                    Category = "Contraception",
                    Price = 11.49M
                },
                new Product
                {
                    Name = "Pritor Plus",
                    Category = "Calming",
                    Price = 16.99M
                },
                new Product
                {
                    Name = "Voltaren",
                    Category = "Pain Relievers",
                    Price = 15.0M
                },
                new Product
                {
                    Name = "Apap",
                    Category = "Pain Relievers",
                   Price = 12.99M
                },
                new Product
                {
                    Name = "Ibum",
                    Category = "Pain Relievers",
                    Price = 13.67M

                },
                new Product
                {
                    Name = "After",
                    Category = "Hangover",
                    Price = 8.25M
                },
                new Product
                {
                    Name = "Vitamin C",
                    Category = "Vitamins",
                    Price = 11.19M
                },
                new Product
                {
                    Name = "Vitamin A",
                    Category = "Vitamins",
                    Price = 6.99M
                },
                new Product
                {
                    Name = "Vitamin B",
                    Category = "Vitamins",
                    Price = 4.99M
                }
                
                );

                context.SaveChanges();
            }
        }
    }
}
