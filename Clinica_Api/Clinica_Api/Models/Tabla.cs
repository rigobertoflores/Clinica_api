using System;
using System.Collections.Generic;

namespace Clinica_Api.Models;

public partial class Tabla
{
    public string Nombre { get; set; } = null!;

    public byte[]? Tabla1 { get; set; }
}
