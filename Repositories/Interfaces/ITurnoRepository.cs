using TurnosLibrary.Entities;

namespace TurnosLibrary.Repositories.Interfaces
  {
  public interface ITurnoRepository
    {
    List<TTurno> GetAll(); //Devuelve una lista con todos los turnos actuales no cancelados

    List<TTurno> GetByDate(string fecha); //Devuelve todos los turnos en la fecha especificada

    List<TTurno> GetByClient(string cliente); //Devuelve una lista de los turnos de ese cliente

    List<TTurno> GetCanceled(int days); //devuelve los turnos cancelados desde el dia pasado como parametro(days) hasta el dia actual.

    bool Save(TTurno turno); //Crea un turno si no existe en la base de datos. Si ya existe se actualiza.

    bool Delete(int id, string motivo); //Asigna una fecha y un motivo de cancelación al turno con ese id(Borrado Lógico)
    }
  }
