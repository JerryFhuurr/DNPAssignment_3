using AdultsApi.Models;
using System.Linq;

namespace AdultsAPI.Persistence
{
    public class DbInitializer
    {
        public void Initialize(FamilyDbContext context)
        {
            context.Database.EnsureCreated();

            //look for any adults
            if (context.Adults.Any())
            {
                return;  // db has been seeded
            }

            var jobs = new Job[]
            {
                new Job{JobTitle = "WORK1", Salary = 3000},
                new Job{JobTitle = "WORK2", Salary = 4000},
                new Job{JobTitle = "WORK3", Salary = 5000},
                new Job{JobTitle = "WORK4", Salary = 6000}
            };


            var adults = new Adult[]
            {
                new Adult{Id = 0, FirstName = "AB", LastName = "CD", HairColor = "Blue", EyeColor = "Black", Age = 30, Weight = 50, Height = 165, Sex = "F", Job = jobs[0]},
                new Adult{Id = 1, FirstName = "DD", LastName = "DSCD", HairColor = "Blue", EyeColor = "Black", Age = 22, Weight = 50, Height = 175, Sex = "M", Job = jobs[1]},
                new Adult{Id = 2, FirstName = "ACCB", LastName = "CSDD", HairColor = "Blue", EyeColor = "Black", Age = 45, Weight = 50, Height = 165, Sex = "F", Job = jobs[2]},
                new Adult{Id = 3, FirstName = "EE", LastName = "CDW", HairColor = "Blue", EyeColor = "Black", Age = 66, Weight = 50, Height = 190, Sex = "M", Job = jobs[3]}
            };
            foreach (var a in adults)
            {
                context.Adults.AddAsync(a);
                context.SaveChanges();
            }

        }



    }
}
