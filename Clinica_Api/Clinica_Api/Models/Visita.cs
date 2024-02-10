using System;
using System.Collections.Generic;

namespace Clinica_Api.Models;

public partial class Visita
{
    public DateTime Dia { get; set; }

    public string Hora { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Procedimiento { get; set; }
}
