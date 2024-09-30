using TurnosLibrary.Entities;
using TurnosLibrary.Repositories.Interfaces;
using TurnosLibrary.Services.Interfaces;

namespace TurnosLibrary.Services.Implementations
  {
  public class TurnoService : ITurnoService
    {
    private readonly ITurnoRepository _turnoRepository;

    public TurnoService(ITurnoRepository turnoRepository)
      {
      _turnoRepository = turnoRepository;
      }

    public bool Delete(int id, string motivo)
      {
      return _turnoRepository.Delete(id, motivo);
      }

    public List<TTurno> GetAll()
      {
      return _turnoRepository.GetAll();
      }

    public List<TTurno> GetByClient(string cliente)
      {
      return _turnoRepository.GetByClient(cliente);
      }

    public List<TTurno> GetByDate(string fecha)
      {
      return _turnoRepository.GetByDate(fecha);
      }

    public List<TTurno> GetCanceled(int days)
      {
      return _turnoRepository.GetCanceled(days);
      }

    public bool Save(TTurno turno)
      {
      return _turnoRepository.Save(turno);
      }
    }
  }
