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

    public bool Delete(int id, string motivo)
      {
      var turno = _context.TTurnos.Find(id);

      if (turno != null)
        {
        turno.MotivoCancelacion = motivo;
        turno.FechaCancelacion = DateTime.Now;
        _context.TTurnos.Update(turno);

        return _context.SaveChanges() > 0;
        }
      return false;
      }

    public List<TTurno> GetAll()
      {
      return _context.TTurnos.Where(t => t.FechaCancelacion.HasValue == false).ToList();
      }

    public List<TTurno> GetCanceled(int days)
      {
      DateTime from = DateTime.Now.AddDays(-days);
      return _context.TTurnos.Where(t => t.FechaCancelacion >= from).ToList();
      }

    public List<TTurno> GetByClient(string cliente)
      {
      return _context.TTurnos.Where(t => t.Cliente == cliente && string.IsNullOrEmpty(t.MotivoCancelacion)).ToList();
      }

    public List<TTurno> GetByDate(string fecha)
      {
      return _context.TTurnos.Where(t => t.Fecha == fecha).ToList();
      }

    public bool Save(TTurno turno)
      {
      if (turno.Id == 0)
        {
        _context.TTurnos.Add(turno);
        return _context.SaveChanges() > 0;
        }
      else
        {
        _context.TTurnos.Update(turno);
        return _context.SaveChanges() > 0;
        }
      }


    }
  }
