﻿using Microsoft.EntityFrameworkCore;
using RunGroop.Data;
using RunGroop.Interfaces;
using RunGroop.Models;
using RunGroop.ViewModels;

namespace RunGroop.Repository
{
    public class ClubRepository: IClubRepository
    {
        private readonly DataContext _context;

        public ClubRepository(DataContext context)
        {
            _context = context;
        }
        public bool Add(Club club)
        {
            _context.Add(club);
            return Save();
        }

        

        public bool Delete(Club club)
        {
            _context.Remove(club);
            return Save();
        }

        public async Task<IEnumerable<Club>> GetAll()
        {
            return await _context.Clubs.ToListAsync();
        }

        public async Task<Club> GetByIdAsync(int id)
        {
            return await _context.Clubs.Include(a => a.Address).FirstOrDefaultAsync( c => c.ClubId == id);
        }

        public async Task<Club> GetByIdAsyncNoTracking(int id)
        {
            return await _context.Clubs.Include(a => a.Address).AsNoTracking().FirstOrDefaultAsync(c => c.ClubId == id);
        }

        public async Task<IEnumerable<Club>> GetClubByCity(string city)
        {
            return await _context.Clubs.Where(c => c.Address.City.Contains(city)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true: false;
        }

        public bool Update(Club club)
        {
            _context.Update(club);
            return Save();
        }
    }
}
