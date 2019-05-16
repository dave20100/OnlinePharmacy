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
                    Description = "Pain reliever",
                    Category = "Pain Relievers",
                    Price = 9.99M
                },
                new Product
                {
                    Name = "Gripex",
                    Description = "Pain reliever",
                    Category = "Pain Relievers",
                    Price = 200,
                    IsPrescripted = true
                },
                new Product
                {
                    Name = "2KC",
                    Category = "Hangover"
                },
                new Product
                {
                    Name = "Acatar",
                    Category = "Runny nose"
                },
                new Product
                {
                    Name = "Neo-Angin",
                    Category = "Resistance"
                },
                new Product
                {
                    Name = "Rutinacea",
                    Category = "Resistance"
                },
                new Product
                {
                    Name = "Witamina K",
                    Category = "Vitamins"
                }
                );

                context.SaveChanges();
            }
        }
    }
}
