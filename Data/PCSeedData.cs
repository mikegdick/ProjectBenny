using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectBenny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBenny.Data
{
    public class PCSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PlantContext(
                serviceProvider.GetRequiredService<DbContextOptions<PlantContext>>()))
            {
                if (!context.Plants.Any())
                {
                    Plant a = new Plant()
                    {
                        Name = "Wild Rose",
                        PlantedDate = DateTime.Now,
                        Species = "Rose",
                        Location = "East Wing"
                    };
                    context.Plants.Add(a);

                    Plant b = new Plant()
                    {
                        Name = "Tulip",
                        PlantedDate = DateTime.Now,
                        Species = "Perenial",
                        Location = "West Wing"
                    };
                    context.Plants.Add(b);
                }

                context.SaveChanges();
            }
        }
    }
}
