using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdultsApi.Models;
using AdultsAPI.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AdultsAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (FamilyDbContext family = new FamilyDbContext())
            {
                if (!family.Adults.Any())
                {
                    Seed(family);
                }
            }
            CreateHostBuilder(args).Build().Run();
        }
        private static void Seed(FamilyDbContext context)
        {
            var jobs = new Job[]
                {
                new Job{JobTitle = "WORK1", Salary = 3000},
                new Job{JobTitle = "WORK2", Salary = 4000},
                new Job{JobTitle = "WORK3", Salary = 5000},
                new Job{JobTitle = "WORK4", Salary = 6000}
                };


            var adults = new Adult[]
            {
                new Adult{Id = 1, FirstName = "AB", LastName = "CD", HairColor = "Blue", EyeColor = "Black", Age = 30, Weight = 50, Height = 165, Sex = "F", Job = jobs[0]},
                new Adult{Id = 2, FirstName = "DD", LastName = "DSCD", HairColor = "Blue", EyeColor = "Black", Age = 22, Weight = 50, Height = 175, Sex = "M", Job = jobs[1]},
                new Adult{Id = 3, FirstName = "ACCB", LastName = "CSDD", HairColor = "Blue", EyeColor = "Black", Age = 45, Weight = 50, Height = 165, Sex = "F", Job = jobs[2]},
                new Adult{Id = 4, FirstName = "EE", LastName = "CDW", HairColor = "Blue", EyeColor = "Black", Age = 66, Weight = 50, Height = 190, Sex = "M", Job = jobs[3]}
            };

            foreach (var a in adults)
            {
                context.Adults.AddAsync(a);
                context.SaveChanges();
            }

        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }


}