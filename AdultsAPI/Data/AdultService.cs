using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AdultsApi.Models;

namespace AdultsAPI.Data
{
    public class AdultService : IAdultsService
    {
        private string adultFile = "adults.json";
        private IList<Adult> adults;

        public AdultService()
        {
            if (!File.Exists(adultFile))
            {
                throw new FileLoadException($"Couldn't find the file - {adultFile}");
            }
            else
            {
                string content = File.ReadAllText(adultFile);
                adults = JsonSerializer.Deserialize<List<Adult>>(content);
            }
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            List<Adult> tmp = new List<Adult>(adults);
            return tmp;
        }

        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            int max = adults.Max(adult => adult.Id);
            adult.Id = (++max);
            adults.Add(adult);
            WriteAdultsToFile();
            return adult;
        }

        public async Task RemoveAdultAsync(int id)
        {
            Adult toRemove = adults.First(t => t.Id == id);
            adults.Remove(toRemove);
            WriteAdultsToFile();
        }

        public async Task<Adult> UpdateAsync(Adult adult)
        {
            foreach (var ad in adults)
            {
                if (ad.Id == adult.Id)
                {
                    Console.WriteLine(ad.FirstName);
                }
            }
            
            Adult toUpdate = adults.FirstOrDefault(t => t.Id == adult.Id);
            if (toUpdate == null) throw new Exception($"Did not find adult with id: {adult.Id}");
            
            toUpdate.FirstName = adult.FirstName;
            toUpdate.LastName = adult.LastName;
            toUpdate.Job.JobTitle = adult.Job.JobTitle;
            toUpdate.Job.Salary = adult.Job.Salary;
            toUpdate.HairColor = adult.HairColor;
            toUpdate.EyeColor = adult.EyeColor;
            toUpdate.Age = adult.Age;
            toUpdate.Weight = adult.Weight;
            toUpdate.Height = adult.Height;
            toUpdate.Sex = adult.Sex;
            
            foreach (var ad in adults)
            {
                if (ad.Id == adult.Id)
                {
                    Console.WriteLine(ad.FirstName);
                    ad.FirstName = adult.FirstName;
                }
            }
            
            WriteAdultsToFile();
            return toUpdate;
        }

        private void WriteAdultsToFile()
        {
            string productsAsJson = JsonSerializer.Serialize(adults);

            File.WriteAllText(adultFile, productsAsJson);
        }

        public Task<Job> GetJob(int id)
        {
            throw new NotImplementedException();
        }
    }
}