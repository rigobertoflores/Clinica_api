using System;
using System.Collections.Generic;

namespace Clinica_Api.Models;

public partial class Tratamiento
{
    public int Id { get; set; }

    public string Descripción { get; set; } = null!;

    public decimal Precio { get; set; }

    public decimal? PrecioMax { get; set; }

    public decimal? PrecioMin { get; set; }
}
