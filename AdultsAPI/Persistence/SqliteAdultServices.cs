using AdultsApi.Models;
using AdultsAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdultsAPI.Persistence
{
    public class SqliteAdultServices : IAdultsService
    {
        private FamilyDbContext context;

        public SqliteAdultServices(FamilyDbContext fdc)
        {
            context = fdc;
            if(context.Adults == null)
            {
                DbInitializer initializer = new DbInitializer();
                initializer.Initialize(context);
            }
        }
        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            EntityEntry<Adult> adultAdd = await context.Adults.AddAsync(adult);
            await context.SaveChangesAsync();
            return adultAdd.Entity;
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            return await context.Adults.ToListAsync();
        }

        public async Task RemoveAdultAsync(int adultId)
        {
            Adult ar = await context.Adults.FirstAsync(a => a.Id == adultId);
            if (ar != null)
            {
                context.Adults.Remove(ar);
                await context.SaveChangesAsync();
            }
        }

        public async Task<Adult> UpdateAsync(Adult adult)
        {
            try
            {
                Adult adultUpdate = await context.Adults.FirstOrDefaultAsync(a => a.Id == adult.Id);
                context.Adults.Update(adultUpdate);
                context.Update(adultUpdate);
                await context.SaveChangesAsync();
                return adultUpdate;
            }catch (Exception e)
            {
                throw new Exception($"Did not find adult with id {adult.Id}");
            }
        }
    }
}
