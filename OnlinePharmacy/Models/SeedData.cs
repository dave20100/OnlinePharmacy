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
            foreach(var p in context.Products)
            {
                context.Products.Remove(p);
            }
            //if (!context.Products.Any())
            //{
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Ibuprom",
                        Description = "Good",
                        Category = "Meds",
                        Price = 100
                    },
                    new Product
                    {
                        Name = "Gripex",
                        Category = "Meds",
                        Price = 200
                    });
                context.SaveChanges();
            //}
        }
    }
}
