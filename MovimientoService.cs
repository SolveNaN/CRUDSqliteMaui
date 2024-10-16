using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudFinanzasMaui
{
    public class MovimientoService
    {
        private readonly AppDbContext _context;

        public MovimientoService()
        {
            _context = new AppDbContext();
            _context.Database.EnsureCreated();
        }

        public async Task AddMovimientoAsync(Movimiento Movimiento)
        {
            _context.Movimientos.Add(Movimiento);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Movimiento>> GetMovimientosAsync()
        {
            return await _context.Movimientos.ToListAsync();
        }

        public async Task<Movimiento> GetMovimientoByIdAsync(int id)
        {
            return await _context.Movimientos.FindAsync(id);
        }

        public async Task UpdateMovimientoAsync(Movimiento Movimiento)
        {
            _context.Movimientos.Update(Movimiento);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMovimientoAsync(int id)
        {
            var Movimiento = await _context.Movimientos.FindAsync(id);
            if (Movimiento != null)
            {
                _context.Movimientos.Remove(Movimiento);
                await _context.SaveChangesAsync();
            }
        }
    }

}
