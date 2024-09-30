using System;
using System.Collections.Generic;

namespace TurnosLibrary.Entities;

public partial class TTurno
{
    public int Id { get; set; }

    public string? Fecha { get; set; }

    public string? Hora { get; set; }

    public string? Cliente { get; set; }

    public DateTime? FechaCancelacion { get; set; }

    public string? MotivoCancelacion { get; set; }
}
