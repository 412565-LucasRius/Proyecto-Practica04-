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

    public async Task<bool> Delete(int id, string motivo)
      {
      return await _turnoRepository.Delete(id, motivo);
      }

    public async Task<List<TTurno>> GetAll()
      {
      return await _turnoRepository.GetAll();
      }

    public async Task<List<TTurno>> GetByClient(string cliente)
      {
      return await _turnoRepository.GetByClient(cliente);
      }

    public async Task<List<TTurno>> GetByDate(string fecha)
      {
      return await _turnoRepository.GetByDate(fecha);
      }

    public async Task<List<TTurno>> GetCanceled(int days)
      {
      return await _turnoRepository.GetCanceled(days);
      }

    public async Task<bool> Save(TTurno turno)
      {
      return await _turnoRepository.Save(turno);
      }
    }
  }
