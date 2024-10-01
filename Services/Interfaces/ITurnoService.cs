using TurnosLibrary.Entities;

namespace TurnosLibrary.Services.Interfaces
  {
  public interface ITurnoService
    {
    Task<List<TTurno>> GetAll();

    Task<List<TTurno>> GetByDate(string fecha);

    Task<List<TTurno>> GetByClient(string cliente);

    Task<List<TTurno>> GetCanceled(int days);

    Task<bool> Save(TTurno turno);

    Task<bool> Delete(int id, string motivo);
    }
  }
