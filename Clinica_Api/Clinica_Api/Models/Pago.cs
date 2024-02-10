using System;
using System.Collections.Generic;

namespace Clinica_Api.Models;

public partial class Pago
{
    public int Id { get; set; }

    public int? Clave { get; set; }

    public DateTime Fecha { get; set; }

    public string Tratamiento { get; set; } = null!;

    public decimal? Cargo { get; set; }

    public decimal? Abono { get; set; }

    public int? Recibo { get; set; }

    public string? ReciboTxt { get; set; }

    public string? Datos { get; set; }

    public decimal? PrecioU { get; set; }

    public int? Piezas { get; set; }
}
