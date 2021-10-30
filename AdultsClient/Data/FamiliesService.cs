using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace AdultsClient.Data
{
    /*
    public class FamiliesService : IFamiliesService
    {
        public IList<Family> Families { get; private set; }
        public IList<Adult> adults { get; private set; }

        private readonly string familiesFile = "families.json";
        private readonly string adultsFile = "adults.json";

        public FamiliesService()
        {
            Families = File.Exists(familiesFile) ? ReadData<Family>(familiesFile) : new List<Family>();
            adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
        }

        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(s))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        public void SaveChanges()
        {
            // storing families
            /*string jsonFamilies = JsonSerializer.Serialize(Families, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(familiesFile, false))
            {
                outputFile.Write(jsonFamilies);
            }#1#

            // storing persons
            string jsonAdults = JsonSerializer.Serialize(adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(adultsFile, false))
            {
                outputFile.Write(jsonAdults);
            }
        }


        public Task<Adult> GetAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Adult> GetAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            List<Adult> tmp = new List<Adult>(adults);
            // Task<IList<Adult>> tmpTask = new Task<IList<Adult>>();
            return tmp;
        }

        public Task AddAdultAsync(Adult adult)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveAdultAsync(int adultId)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Adult adult)
        {
            throw new System.NotImplementedException();
        }

        public void AddAdult(Adult adult)
        {
            var adults = GetAdultsAsync();
            adult.Id = adults.Result.Last().Id + 1;
            this.adults.Add(adult);
            SaveChanges();
        }

        public void RemoveAdult(int todoId)
        {
            Adult toRemove = adults.First(t => t.Id == todoId);
            adults.Remove(toRemove);
            SaveChanges();
        }

        public void Update(Adult adult)
        {
            Adult toUpdate = adults.First(t => t.Id == adult.Id);
            toUpdate.FirstName = adult.FirstName;
            toUpdate.LastName = adult.LastName;
            SaveChanges();
        }

        public Adult Get(int id)
        {
            return adults.FirstOrDefault(a => a.Id == id);
        }
    }*/
}