using Microsoft.EntityFrameworkCore;
using TurnosLibrary.Entities;
using TurnosLibrary.Repositories.Interfaces;

namespace TurnosLibrary.Repositories.Implementations
  {
  public class TurnoRepository : ITurnoRepository
    {

    private readonly TurnosDb2Context _context;

    public TurnoRepository(TurnosDb2Context context)
      {
      _context = context;
      }

    public async Task<bool> Delete(int id, string motivo)
      {
      var turno = await _context.TTurnos.FindAsync(id);

      if (turno != null)
        {
        turno.MotivoCancelacion = motivo;
        turno.FechaCancelacion = DateTime.Now;
        _context.TTurnos.Update(turno);

        return await _context.SaveChangesAsync() > 0;
        }
      return false;
      }

    public async Task<List<TTurno>> GetAll()
      {
      return await _context.TTurnos.Where(t => t.FechaCancelacion.HasValue == false).ToListAsync();
      }

    public async Task<List<TTurno>> GetCanceled(int days)
      {
      DateTime from = DateTime.Now.AddDays(-days);
      return await _context.TTurnos.Where(t => t.FechaCancelacion >= from).ToListAsync();
      }

    public async Task<List<TTurno>> GetByClient(string cliente)
      {
      return await _context.TTurnos.Where(t => t.Cliente == cliente && string.IsNullOrEmpty(t.MotivoCancelacion)).ToListAsync();
      }

    public async Task<List<TTurno>> GetByDate(string fecha)
      {
      return await _context.TTurnos.Where(t => t.Fecha == fecha).ToListAsync();
      }

    public async Task<bool> Save(TTurno turno)
      {
      if (turno.Id == 0)
        {
        _context.TTurnos.Add(turno);
        return await _context.SaveChangesAsync() > 0;
        }
      else
        {
        _context.TTurnos.Update(turno);
        return await _context.SaveChangesAsync() > 0;
        }
      }


    }
  }
