﻿using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db.Repositories
{
    public class CompanionRepository : ICrudRepository<Companion>, ICompanionRepository
    {
        public async Task<List<Companion>> GetAllCompanionsAsync()
        {
            return await context.companions.ToListAsync();
        }

        public async Task<Companion>? GetCompanionById(int id)
        {
            return await context.companions.FindAsync(id);
        }
    }
}