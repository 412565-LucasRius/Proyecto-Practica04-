using TurnosLibrary.Entities;

namespace TurnosLibrary.Services.Interfaces
  {
  public interface ITurnoService
    {
    List<TTurno> GetAll();

    List<TTurno> GetByDate(string fecha);

    List<TTurno> GetByClient(string cliente);

    List<TTurno> GetCanceled(int days);

    bool Save(TTurno turno);

    bool Delete(int id, string motivo);
    }
  }
