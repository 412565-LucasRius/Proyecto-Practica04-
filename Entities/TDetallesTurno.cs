using System;
using System.Collections.Generic;

namespace TurnosLibrary.Entities;

public partial class TDetallesTurno
{
    public int IdTurno { get; set; }

    public int IdServicio { get; set; }

    public string? Observaciones { get; set; }
}
