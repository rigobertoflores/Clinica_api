using System;
using System.Collections.Generic;

namespace Clinica_Api.Modelss;

public partial class Expediente
{
    public int Clave { get; set; }

    public string? Nombre { get; set; }

    public bool? Sexo { get; set; }

    public DateTime? FechaDeNacimiento { get; set; }

    public string Tema { get; set; } = null!;

    public string? Expediente1 { get; set; }

    public string? Depto { get; set; }
}
