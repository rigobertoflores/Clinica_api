using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinica_Api.Models;

public partial class Paciente
{
    [Key]
    public int Clave { get; set; }

    public string? Nombre { get; set; }

    public bool? Sexo { get; set; }

    public DateTime? FechaDeNacimiento { get; set; }

    public string? LugarDir { get; set; }

    public string? Responsable { get; set; }

    public string? Puesto { get; set; }

    public string? Empresa { get; set; }

    public string? Religión { get; set; }

    public string? Referencia { get; set; }

    public string? Rfc { get; set; }

    public string? DocPref { get; set; }

    public bool? Recall { get; set; }

    public string? FrecRecall { get; set; }

    public string? ReciboNom { get; set; }

    public string? ReciboDir { get; set; }

    public DateTime? UltCita { get; set; }

    public DateTime? UltProf { get; set; }

    public short? Ttrata { get; set; }

    public short? Tprof { get; set; }

    public string? Puntual { get; set; }

    public string? Paga { get; set; }

    public bool? Banco { get; set; }

    public int? CualBanco { get; set; }

    public string? Comentarios { get; set; }

    public bool? Incluye { get; set; }

    public string? Nºcuenta { get; set; }

    public string? Beneficiario { get; set; }

    public DateTime? MemoInicio { get; set; }

    public DateTime? MemoFin { get; set; }

    public string? Ingresos { get; set; }

    public string? Clasificación { get; set; }

    public string? Email { get; set; }

    public string? EName { get; set; }

    public string? Motivo { get; set; }

    public string Tema { get; set; } = null!;

    public string? TipoEvento { get; set; }

    public DateTime? Start { get; set; }

    public DateTime? Finish { get; set; }

    public int? Izq { get; set; }

    public int? Arriba { get; set; }

    public int? Ancho { get; set; }

    public int? Alto { get; set; }

    public int? Prop { get; set; }

    public string? Local { get; set; }

    public string? Privado { get; set; }

    public string? Expediente { get; set; }

    public string? Depto { get; set; }
}
