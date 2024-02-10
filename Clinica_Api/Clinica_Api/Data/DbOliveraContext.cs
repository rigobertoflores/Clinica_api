using System;
using System.Collections.Generic;
using Clinica_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinica_Api.Data;

public partial class DbOliveraContext : DbContext
{
    
    public DbOliveraContext(DbContextOptions<DbOliveraContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AgendaHoy> AgendaHoys { get; set; }

    public virtual DbSet<Agendum> Agenda { get; set; }

    public virtual DbSet<Commaux> Commauxes { get; set; }

    public virtual DbSet<Cuenta> Cuentas { get; set; }

    public virtual DbSet<Dia> Dias { get; set; }

    public virtual DbSet<Direccione> Direcciones { get; set; }

    public virtual DbSet<Dx> Dxes { get; set; }

    public virtual DbSet<ExpedienteX> ExpedienteXes { get; set; }

    public virtual DbSet<Historia> Historias { get; set; }

    public virtual DbSet<LasFoto> LasFotos { get; set; }

    public virtual DbSet<LasImagene> LasImagenes { get; set; }

    public virtual DbSet<LasReceta> LasRecetas { get; set; }

    public virtual DbSet<LosDato> LosDatos { get; set; }

    public virtual DbSet<Observacione> Observaciones { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<RecetasX> RecetasXes { get; set; }

    public virtual DbSet<Recibo> Recibos { get; set; }

    public virtual DbSet<Socio> Socios { get; set; }

    public virtual DbSet<Tabla> Tablas { get; set; }

    public virtual DbSet<Tratamiento> Tratamientos { get; set; }

    public virtual DbSet<Visita> Visitas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-UB7952GK\\MSSQLSERVER01;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Database=db_olivera;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AgendaHoy>(entity =>
        {
            entity.HasKey(e => new { e.Dia, e.Hora });

            entity.ToTable("AgendaHoy");

            entity.Property(e => e.Dia).HasColumnType("datetime");
            entity.Property(e => e.Hora)
                .HasMaxLength(12)
                .IsFixedLength();
            entity.Property(e => e.Nombre).HasMaxLength(40);
            entity.Property(e => e.Procedimiento)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<Agendum>(entity =>
        {
            entity.HasKey(e => new { e.Dia, e.Hora }).HasName("PK_Agenda_Agenda_Agenda");

            entity.Property(e => e.Dia).HasColumnType("datetime");
            entity.Property(e => e.Hora)
                .HasMaxLength(12)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsFixedLength();
            entity.Property(e => e.Procedimiento)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<Commaux>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("COMMAUX");

            entity.Property(e => e.Cabeza).HasColumnName("cabeza");
            entity.Property(e => e.ColorExp).HasMaxLength(40);
            entity.Property(e => e.ColorNota).HasMaxLength(40);
            entity.Property(e => e.ColorReceta).HasMaxLength(40);
            entity.Property(e => e.Data).HasMaxLength(50);
            entity.Property(e => e.Eam)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Epm)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Fecha).HasMaxLength(50);
            entity.Property(e => e.Md).HasColumnName("MD");
            entity.Property(e => e.Mi).HasColumnName("MI");
            entity.Property(e => e.Minf).HasColumnName("MInf");
            entity.Property(e => e.Ms).HasColumnName("MS");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.Nombre).HasMaxLength(40);
            entity.Property(e => e.Pie).HasColumnName("pie");
            entity.Property(e => e.Serie)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.Tam)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.TipoExp).HasMaxLength(80);
            entity.Property(e => e.TipoNota).HasMaxLength(80);
            entity.Property(e => e.TipoReceta).HasMaxLength(80);
            entity.Property(e => e.Tpm)
                .HasMaxLength(11)
                .IsFixedLength();
            entity.Property(e => e.Ultima).HasMaxLength(50);
        });

        modelBuilder.Entity<Cuenta>(entity =>
        {
            entity.HasKey(e => e.Consecutivo).HasName("PK_CUENTAS_CUENTAS_CUENTAS_CUENTAS");

            entity.ToTable("CUENTAS");

            entity.Property(e => e.Consecutivo).ValueGeneratedNever();
            entity.Property(e => e.AUnidad).HasColumnName("A Unidad");
            entity.Property(e => e.Cargo).HasColumnType("money");
            entity.Property(e => e.Comentarios).HasMaxLength(50);
            entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaVence).HasColumnType("smalldatetime");
            entity.Property(e => e.NombreRecibo).HasMaxLength(40);
            entity.Property(e => e.NumeroCuenta).HasMaxLength(12);
            entity.Property(e => e.NumeroDoc).HasMaxLength(12);
            entity.Property(e => e.Recibo).HasMaxLength(12);
            entity.Property(e => e.Superficie).HasMaxLength(10);
        });

        modelBuilder.Entity<Dia>(entity =>
        {
            entity.HasKey(e => e.Dia1);

            entity.Property(e => e.Dia1)
                .HasColumnType("datetime")
                .HasColumnName("Dia");
            entity.Property(e => e.Fondo).HasMaxLength(20);
            entity.Property(e => e.Texto).HasMaxLength(25);
        });

        modelBuilder.Entity<Direccione>(entity =>
        {
            entity.HasKey(e => new { e.Clave, e.Dir }).HasName("PK_DIRECCIONES_DIRECCIONES_DIRECCIONES");

            entity.ToTable("DIRECCIONES");

            entity.Property(e => e.Dir).HasMaxLength(15);
            entity.Property(e => e.Celular).HasMaxLength(40);
            entity.Property(e => e.Ciudad).HasMaxLength(40);
            entity.Property(e => e.Colonia).HasMaxLength(40);
            entity.Property(e => e.Cp)
                .HasMaxLength(5)
                .HasColumnName("CP");
            entity.Property(e => e.Direccion).HasMaxLength(40);
            entity.Property(e => e.Estado).HasMaxLength(15);
            entity.Property(e => e.Ext1).HasMaxLength(8);
            entity.Property(e => e.Ext2).HasMaxLength(8);
            entity.Property(e => e.Ext3).HasMaxLength(8);
            entity.Property(e => e.Fax).HasMaxLength(12);
            entity.Property(e => e.Lada).HasMaxLength(5);
            entity.Property(e => e.Tel2).HasMaxLength(12);
            entity.Property(e => e.Tel3).HasMaxLength(12);
            entity.Property(e => e.Telefonos).HasMaxLength(40);
        });

        modelBuilder.Entity<Dx>(entity =>
        {
            entity.HasKey(e => new { e.Clave, e.Dx1 }).HasName("PK_Dx_1_Dx_Dx");

            entity.ToTable("Dx");

            entity.Property(e => e.Dx1)
                .HasMaxLength(20)
                .HasColumnName("Dx");
        });

        modelBuilder.Entity<ExpedienteX>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PK_ExpedienteX_ExpedienteX_ExpedienteX");

            entity.ToTable("ExpedienteX");

            entity.Property(e => e.Clave).ValueGeneratedNever();
            entity.Property(e => e.Expediente).HasColumnType("image");
        });

        modelBuilder.Entity<Historia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Historias_Historias");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Hc).HasColumnName("HC");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<LasFoto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LasFotos_LasFotos");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<LasImagene>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Letra, e.Ext }).HasName("PK_LasImagenes_LasImagenes");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Letra).HasMaxLength(40);
            entity.Property(e => e.Ext).HasMaxLength(10);
        });

        modelBuilder.Entity<LasReceta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LasRecetas_LasRecetas");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<LosDato>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Letra, e.Ext }).HasName("PK_LosDatos_LosDatos");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Letra).HasMaxLength(40);
            entity.Property(e => e.Ext).HasMaxLength(10);
        });

        modelBuilder.Entity<Observacione>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PK_OBSERVACIONES_OBSERVACIONES_OBSERVACIONES_OBSERVACIONES");

            entity.ToTable("OBSERVACIONES");

            entity.Property(e => e.Clave).ValueGeneratedNever();
            entity.Property(e => e.O1).HasMaxLength(21);
            entity.Property(e => e.O2).HasMaxLength(21);
            entity.Property(e => e.O3).HasMaxLength(21);
            entity.Property(e => e.O4).HasMaxLength(21);
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PK_pacientes_pacientes_pacientes");

            entity.ToTable("pacientes");

            entity.Property(e => e.Clave).ValueGeneratedNever();
            entity.Property(e => e.Beneficiario).HasMaxLength(40);
            entity.Property(e => e.Clasificación).HasMaxLength(15);
            entity.Property(e => e.Comentarios).HasMaxLength(255);
            entity.Property(e => e.CualBanco).HasColumnName("Cual Banco");
            entity.Property(e => e.Depto)
                .HasMaxLength(70)
                .HasColumnName("DEPTO");
            entity.Property(e => e.DocPref)
                .HasMaxLength(40)
                .HasColumnName("Doc Pref");
            entity.Property(e => e.EName)
                .HasMaxLength(40)
                .HasColumnName("E-Name");
            entity.Property(e => e.Email).HasMaxLength(40);
            entity.Property(e => e.Empresa).HasMaxLength(40);
            entity.Property(e => e.FechaDeNacimiento)
                .HasColumnType("smalldatetime")
                .HasColumnName("Fecha de Nacimiento");
            entity.Property(e => e.Finish).HasColumnType("smalldatetime");
            entity.Property(e => e.FrecRecall)
                .HasMaxLength(2)
                .HasColumnName("Frec Recall");
            entity.Property(e => e.Ingresos).HasMaxLength(1);
            entity.Property(e => e.Local)
                .HasMaxLength(8)
                .HasColumnName("local");
            entity.Property(e => e.LugarDir).HasMaxLength(8);
            entity.Property(e => e.MemoFin).HasColumnType("smalldatetime");
            entity.Property(e => e.MemoInicio).HasColumnType("smalldatetime");
            entity.Property(e => e.Motivo).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(40);
            entity.Property(e => e.Nºcuenta)
                .HasMaxLength(12)
                .HasColumnName("NºCuenta");
            entity.Property(e => e.Paga).HasMaxLength(1);
            entity.Property(e => e.Privado)
                .HasMaxLength(70)
                .HasColumnName("privado");
            entity.Property(e => e.Puesto).HasMaxLength(30);
            entity.Property(e => e.Puntual).HasMaxLength(1);
            entity.Property(e => e.ReciboDir).HasMaxLength(8);
            entity.Property(e => e.ReciboNom).HasMaxLength(40);
            entity.Property(e => e.Referencia).HasMaxLength(40);
            entity.Property(e => e.Religión).HasMaxLength(12);
            entity.Property(e => e.Responsable).HasMaxLength(40);
            entity.Property(e => e.Rfc)
                .HasMaxLength(15)
                .HasColumnName("RFC");
            entity.Property(e => e.Start).HasColumnType("smalldatetime");
            entity.Property(e => e.Tema)
                .HasMaxLength(9)
                .HasDefaultValueSql("('Pacientes')");
            entity.Property(e => e.TipoEvento).HasMaxLength(15);
            entity.Property(e => e.Tprof).HasColumnName("TProf");
            entity.Property(e => e.Ttrata).HasColumnName("TTrata");
            entity.Property(e => e.UltCita)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ult Cita");
            entity.Property(e => e.UltProf)
                .HasColumnType("smalldatetime")
                .HasColumnName("Ult Prof");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Abono).HasColumnType("money");
            entity.Property(e => e.Cargo).HasColumnType("money");
            entity.Property(e => e.Datos).HasMaxLength(80);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.PrecioU).HasColumnType("money");
            entity.Property(e => e.ReciboTxt).HasMaxLength(80);
            entity.Property(e => e.Tratamiento).HasMaxLength(50);
        });

        modelBuilder.Entity<RecetasX>(entity =>
        {
            entity.HasKey(e => e.Clave).HasName("PK_RecetasX_RecetasX_RecetasX");

            entity.ToTable("RecetasX");

            entity.Property(e => e.Clave).ValueGeneratedNever();
            entity.Property(e => e.Expediente).HasColumnType("image");
        });

        modelBuilder.Entity<Recibo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Recibo");
        });

        modelBuilder.Entity<Socio>(entity =>
        {
            entity.HasKey(e => new { e.Clave, e.Asoc }).HasName("PK_Socios_Socios_Socios");
        });

        modelBuilder.Entity<Tabla>(entity =>
        {
            entity.HasKey(e => e.Nombre).HasName("PK_Tablas_1_Tablas_Tablas");

            entity.Property(e => e.Nombre).HasMaxLength(20);
            entity.Property(e => e.Tabla1)
                .HasColumnType("image")
                .HasColumnName("Tabla");
        });

        modelBuilder.Entity<Tratamiento>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Descripción).HasMaxLength(50);
            entity.Property(e => e.Precio).HasColumnType("money");
            entity.Property(e => e.PrecioMax).HasColumnType("money");
            entity.Property(e => e.PrecioMin).HasColumnType("money");
        });

        modelBuilder.Entity<Visita>(entity =>
        {
            entity.HasKey(e => new { e.Dia, e.Hora }).HasName("PK_Visitas_Visitas_Visitas");

            entity.Property(e => e.Dia).HasColumnType("datetime");
            entity.Property(e => e.Hora)
                .HasMaxLength(12)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsFixedLength();
            entity.Property(e => e.Procedimiento)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
