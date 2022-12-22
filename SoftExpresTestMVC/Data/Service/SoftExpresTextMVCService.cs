using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SoftExpresTestMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftExpresTestMVC.Data.Service
{
    public class SoftExpresTextMVCService
    {
        public readonly AppDbContext _context;
        public SoftExpresTextMVCService(AppDbContext contect)
        {
            _context = contect;
        }


        public async Task<IEnumerable<Fature>> GetAllFatura(string text)
        {
            var allFature = await _context.Fatures.Where(x => x.Emertimi.StartsWith(text) || text == null).ToListAsync();
            return allFature;
        }

        public Fature GetFature(int id)
        {
            var oneFature = _context.Fatures.FirstOrDefault(x => x.Id == id);
            return oneFature;
        } 


        public async Task  AddFature(Fature fature)
        {
             await _context.Fatures.AddAsync(fature);
             await _context.SaveChangesAsync();
        }
       
        public async Task UpdateAsync(int id, Fature fature)
        {
            EntityEntry entityEntry = _context.Entry(fature);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }
    }
}
