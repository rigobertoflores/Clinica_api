using System;
using System.Collections.Generic;

namespace Clinica_Api.Models;

public partial class Cuenta
{
    public int Consecutivo { get; set; }

    public int? Clave { get; set; }

    public DateTime? Fecha { get; set; }

    public short? Procedimiento { get; set; }

    public short? Unidad { get; set; }

    public short? AUnidad { get; set; }

    public string? Superficie { get; set; }

    public decimal? Cargo { get; set; }

    public short? Doctor { get; set; }

    public short? FormaPago { get; set; }

    public double? Banco { get; set; }

    public string? NumeroDoc { get; set; }

    public string? NumeroCuenta { get; set; }

    public DateTime? FechaVence { get; set; }

    public string? Recibo { get; set; }

    public string? NombreRecibo { get; set; }

    public short? Captura { get; set; }

    public string? Comentarios { get; set; }

    public short? Número { get; set; }

    public short? Modo { get; set; }

    public int? Nombre { get; set; }
}
