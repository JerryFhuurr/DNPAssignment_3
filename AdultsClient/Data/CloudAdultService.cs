using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AdultsClient.Models;

namespace AdultsClient.Data
{
    public class CloudAdultService : IFamiliesService
    {
        private string uri = "https://localhost:5003";
        
        // private string uri = "http://jsonplaceholder.typicode.com";
        private readonly HttpClient client;

        private IList<Adult> adults;
        
        public CloudAdultService()
        {
            client = new HttpClient();
        }

        public async Task<Adult> GetAsync(int id)
        {
            var adultsAsync = await GetAdultsAsync();
            var adultById = adultsAsync.First(t => t.Id == id);
            return adultById;
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            HttpResponseMessage response = await client.GetAsync(uri + "/adults");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }

            string message = await response.Content.ReadAsStringAsync();
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }

        public async Task AddAdultAsync(Adult adult)
        {
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage response = await client.PostAsync(uri + "/adults", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task RemoveAdultAsync(int adultId)
        {
            HttpResponseMessage response = await client.DeleteAsync($"{uri}/adults/{adultId}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task UpdateAsync(Adult adult)
        {
            string adultAsJson = JsonSerializer.Serialize(adult);
            HttpContent content = new StringContent(adultAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage response = await client.PatchAsync($"{uri}/adults/{adult.Id}", content);
            
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
            else
            {
                Adult toUpdate = adults.FirstOrDefault(t => t.Id == adult.Id);
                if (toUpdate == null) throw new Exception($"Did not find adult with id: {adult.Id}");
            
                toUpdate.FirstName = adult.FirstName;
                toUpdate.LastName = adult.LastName;
                toUpdate.JobTitle.JobTitle = adult.JobTitle.JobTitle;
                toUpdate.JobTitle.Salary = adult.JobTitle.Salary;
                toUpdate.HairColor = adult.HairColor;
                toUpdate.EyeColor = adult.EyeColor;
                toUpdate.Age = adult.Age;
                toUpdate.Weight = adult.Weight;
                toUpdate.Height = adult.Height;
                toUpdate.Sex = adult.Sex;
                
                Console.WriteLine("Update success");
            }
        }
    }
}