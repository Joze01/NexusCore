using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DiagnostikaNexusCore.Models.Openf
{
    public partial class OpenfContext : DbContext
    {
        public OpenfContext()
        {
        }

        public OpenfContext(DbContextOptions<OpenfContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActiveX> ActiveX { get; set; }
        public virtual DbSet<Cola> Cola { get; set; }
        public virtual DbSet<Contador> Contador { get; set; }
        public virtual DbSet<DefDocs> DefDocs { get; set; }
        public virtual DbSet<Docs> Docs { get; set; }
        public virtual DbSet<His2lis> His2lis { get; set; }
        public virtual DbSet<Incidencias> Incidencias { get; set; }
        public virtual DbSet<Oauto> Oauto { get; set; }
        public virtual DbSet<OauxDiag> OauxDiag { get; set; }
        public virtual DbSet<OauxDoctor> OauxDoctor { get; set; }
        public virtual DbSet<OauxExterno> OauxExterno { get; set; }
        public virtual DbSet<OauxOrigen> OauxOrigen { get; set; }
        public virtual DbSet<OauxServicio> OauxServicio { get; set; }
        public virtual DbSet<OauxWg> OauxWg { get; set; }
        public virtual DbSet<Oauxiliar> Oauxiliar { get; set; }
        public virtual DbSet<OcenterHist> OcenterHist { get; set; }
        public virtual DbSet<Ocompuesto> Ocompuesto { get; set; }
        public virtual DbSet<Oexcluye> Oexcluye { get; set; }
        public virtual DbSet<Ofechas> Ofechas { get; set; }
        public virtual DbSet<Oficha> Oficha { get; set; }
        public virtual DbSet<Ofiles> Ofiles { get; set; }
        public virtual DbSet<Oformu> Oformu { get; set; }
        public virtual DbSet<OformuData> OformuData { get; set; }
        public virtual DbSet<Ogol> Ogol { get; set; }
        public virtual DbSet<Ogrupos> Ogrupos { get; set; }
        public virtual DbSet<Ohistidx> Ohistidx { get; set; }
        public virtual DbSet<Ohistlog> Ohistlog { get; set; }
        public virtual DbSet<Ohost> Ohost { get; set; }
        public virtual DbSet<Olcopa> Olcopa { get; set; }
        public virtual DbSet<Olcopap> Olcopap { get; set; }
        public virtual DbSet<Olgrupos> Olgrupos { get; set; }
        public virtual DbSet<Olnum> Olnum { get; set; }
        public virtual DbSet<Ologin> Ologin { get; set; }
        public virtual DbSet<Oltest> Oltest { get; set; }
        public virtual DbSet<Onaccesion> Onaccesion { get; set; }
        public virtual DbSet<Operfil> Operfil { get; set; }
        public virtual DbSet<OperfilAux> OperfilAux { get; set; }
        public virtual DbSet<OperfilAuxData> OperfilAuxData { get; set; }
        public virtual DbSet<OperfilData> OperfilData { get; set; }
        public virtual DbSet<Oprecio> Oprecio { get; set; }
        public virtual DbSet<Oproceso> Oproceso { get; set; }
        public virtual DbSet<OprocesoOt> OprocesoOt { get; set; }
        public virtual DbSet<Oproyecto> Oproyecto { get; set; }
        public virtual DbSet<Orango> Orango { get; set; }
        public virtual DbSet<Ospecimen> Ospecimen { get; set; }
        public virtual DbSet<Ostock> Ostock { get; set; }
        public virtual DbSet<Ot> Ot { get; set; }
        public virtual DbSet<OtHisto> OtHisto { get; set; }
        public virtual DbSet<OtP> OtP { get; set; }
        public virtual DbSet<OtPerfil> OtPerfil { get; set; }
        public virtual DbSet<Otest> Otest { get; set; }
        public virtual DbSet<Owg> Owg { get; set; }
        public virtual DbSet<PreData> PreData { get; set; }
        public virtual DbSet<PreListas> PreListas { get; set; }
        public virtual DbSet<Prodef> Prodef { get; set; }
        public virtual DbSet<Prueba> Prueba { get; set; }
        public virtual DbSet<Qt> Qt { get; set; }
        public virtual DbSet<SiapsEdad> SiapsEdad { get; set; }
        public virtual DbSet<SiapsSexo> SiapsSexo { get; set; }
        public virtual DbSet<SiapsSubelemento> SiapsSubelemento { get; set; }

        // Unable to generate entity type for table 'dbo.webusers'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TestCodes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Plantilla_A'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.log_paciente'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Plantilla_B_Ele'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Plantilla_B_SEle'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Plantilla_E_Ele'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Conf'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=openf3;user id=developer;password=270494");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<ActiveX>(entity =>
            {
                entity.HasKey(e => e.ActiveXparam)
                    .HasName("PK__ActiveX__627A95E8");

                entity.HasIndex(e => e.ActiveXparam)
                    .HasName("kActiveXKey")
                    .IsUnique();

                entity.Property(e => e.ActiveXparam)
                    .HasColumnName("ActiveXParam")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveXid)
                    .IsRequired()
                    .HasColumnName("ActiveXID")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cola>(entity =>
            {
                entity.HasKey(e => new { e.ColaToOnline, e.ColaTipo, e.ColaNum })
                    .HasName("PK__cola__2B2A60FE");

                entity.ToTable("cola");

                entity.Property(e => e.ColaToOnline).HasColumnName("cola_to_online");

                entity.Property(e => e.ColaTipo).HasColumnName("cola_tipo");

                entity.Property(e => e.ColaNum).HasColumnName("cola_num");

                entity.Property(e => e.ColaCount)
                    .HasColumnName("cola_count")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ColaDate)
                    .HasColumnName("cola_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ColaDescrip1)
                    .HasColumnName("cola_descrip1")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ColaDescrip2)
                    .HasColumnName("cola_descrip2")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ColaDescrip3)
                    .HasColumnName("cola_descrip3")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ColaDescrip4)
                    .HasColumnName("cola_descrip4")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ColaFlag)
                    .HasColumnName("cola_flag")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ColaFromOnline).HasColumnName("cola_from_online");

                entity.Property(e => e.ColaTime)
                    .HasColumnName("cola_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Contador>(entity =>
            {
                entity.HasKey(e => e.ContClave)
                    .HasName("PK__contador__108B795B");

                entity.ToTable("contador");

                entity.Property(e => e.ContClave)
                    .HasColumnName("cont_clave")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContNum)
                    .HasColumnName("cont_num")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<DefDocs>(entity =>
            {
                entity.HasKey(e => e.DefDocUid)
                    .HasName("PK__Def_Docs__5DB5E0CB");

                entity.ToTable("Def_Docs");

                entity.HasIndex(e => e.DefDocServicio)
                    .HasName("kDefDocServicio");

                entity.HasIndex(e => e.DefDocTestUid)
                    .HasName("kDefDocTestUID");

                entity.Property(e => e.DefDocUid)
                    .HasColumnName("DefDocUID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ComparDefDoc).HasColumnName("Compar_DefDoc");

                entity.Property(e => e.ConfiDefDoc).HasColumnName("Confi_DefDoc");

                entity.Property(e => e.DefDocDescrip)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DefDocGrafico)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DefDocPfile)
                    .HasColumnName("DefDocPFile")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DefDocPrpt).HasColumnName("DefDocPRPT");

                entity.Property(e => e.DefDocPvts).HasColumnName("DefDocPVTS");

                entity.Property(e => e.DefDocPvw).HasColumnName("DefDocPVW");

                entity.Property(e => e.DefDocServicio).HasDefaultValueSql("(0)");

                entity.Property(e => e.DefDocTestUid)
                    .HasColumnName("DefDocTestUID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DefDocTipo).HasDefaultValueSql("(0)");

                entity.Property(e => e.DefDocVts)
                    .HasColumnName("DefDocVTS")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DefDocWrite)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DefDocWriteRtf).HasColumnName("DefDocWriteRTF");

                entity.Property(e => e.PublicDefDoc).HasColumnName("Public_DefDoc");
            });

            modelBuilder.Entity<Docs>(entity =>
            {
                entity.HasKey(e => new { e.DocInciUid, e.DocNum })
                    .HasName("PK__Docs__55209ACA");

                entity.HasIndex(e => new { e.DocInciUid, e.DocNum })
                    .HasName("kDocsKey")
                    .IsUnique();

                entity.Property(e => e.DocInciUid).HasColumnName("DocInciUID");

                entity.Property(e => e.ComparDoc).HasColumnName("Compar_Doc");

                entity.Property(e => e.ConfiDoc).HasColumnName("Confi_Doc");

                entity.Property(e => e.DocDefDoc).HasDefaultValueSql("(0)");

                entity.Property(e => e.DocDiagUid)
                    .HasColumnName("DocDiagUID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DocGrafico)
                    .HasColumnName("Doc_Grafico")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DocPvts).HasColumnName("DocPVTS");

                entity.Property(e => e.DocPvw).HasColumnName("DocPVW");

                entity.Property(e => e.DocRiesgoUid)
                    .HasColumnName("DocRiesgoUID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DocServiDoc).HasDefaultValueSql("(0)");

                entity.Property(e => e.DocTtoUid)
                    .HasColumnName("DocTtoUID")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DocUser)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDoc)
                    .HasColumnName("Fecha_Doc")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImgDoc)
                    .HasColumnName("IMG_Doc")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OleDoc)
                    .HasColumnName("OLE_Doc")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OleExt)
                    .HasColumnName("OLE_Ext")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PrivateDoc).HasColumnName("Private_Doc");

                entity.Property(e => e.PublicDoc).HasColumnName("Public_Doc");

                entity.Property(e => e.TextoDoc)
                    .HasColumnName("TEXTO_Doc")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDoc)
                    .HasColumnName("Tipo_Doc")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TitleDoc)
                    .HasColumnName("Title_Doc")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.VtsDoc)
                    .HasColumnName("VTS_Doc")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<His2lis>(entity =>
            {
                entity.HasKey(e => e.Indice);

                entity.ToTable("HIS2LIS");

                entity.Property(e => e.Indice)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Apell1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Apell2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Diu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Doctor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Embarazo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Fnac)
                    .HasColumnName("FNac")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fsolicitud)
                    .HasColumnName("FSolicitud")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Hab)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Libre)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orden)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Origen)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Perfil)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Peso)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Servicio)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Incidencias>(entity =>
            {
                entity.HasKey(e => e.IncidenciaUid)
                    .HasName("PK__Incidencias__4F67C174");

                entity.HasIndex(e => e.InciUnicoId)
                    .HasName("kInciUnicoId");

                entity.HasIndex(e => new { e.InciDate, e.InciOrder, e.InciParam })
                    .HasName("kIncidencias");

                entity.Property(e => e.IncidenciaUid)
                    .HasColumnName("IncidenciaUID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InciDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.InciOrder).HasDefaultValueSql("(null)");

                entity.Property(e => e.InciParam).HasDefaultValueSql("(null)");

                entity.Property(e => e.InciUnicoId).HasDefaultValueSql("(null)");
            });

            modelBuilder.Entity<Oauto>(entity =>
            {
                entity.HasKey(e => new { e.AutoDate, e.AutoOrder, e.AutoNum })
                    .HasName("PK__oauto__6D0D32F4");

                entity.ToTable("oauto");

                entity.Property(e => e.AutoDate)
                    .HasColumnName("auto_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AutoOrder).HasColumnName("auto_order");

                entity.Property(e => e.AutoNum).HasColumnName("auto_num");

                entity.Property(e => e.AutoCopa)
                    .HasColumnName("auto_copa")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AutoDateProg)
                    .HasColumnName("auto_date_prog")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("auto_id")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.AutoOrigen)
                    .HasColumnName("auto_origen")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.AutoSampletype)
                    .HasColumnName("auto_sampletype")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SE')");

                entity.Property(e => e.AutoSector)
                    .HasColumnName("auto_sector")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AutoTesttype)
                    .HasColumnName("auto_testtype")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('RO')");

                entity.Property(e => e.AutoTime)
                    .HasColumnName("auto_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OauxDiag>(entity =>
            {
                entity.HasKey(e => e.ClaseName)
                    .HasName("PK__oaux_diag__73852659");

                entity.ToTable("oaux_diag");

                entity.Property(e => e.ClaseName)
                    .HasColumnName("clase_name")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaseDescripcion)
                    .HasColumnName("clase_descripcion")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");
            });

            modelBuilder.Entity<OauxDoctor>(entity =>
            {
                entity.HasKey(e => e.ClaseName)
                    .HasName("PK__oaux_doctor__6DCC4D03");

                entity.ToTable("oaux_doctor");

                entity.Property(e => e.ClaseName)
                    .HasColumnName("clase_name")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.ClaseDescripcion)
                    .HasColumnName("clase_descripcion")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.ClaseOrigen)
                    .HasColumnName("clase_origen")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ClaseServicio)
                    .HasColumnName("clase_servicio")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Urgencia)
                    .HasColumnName("urgencia")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')");
            });

            modelBuilder.Entity<OauxExterno>(entity =>
            {
                entity.HasKey(e => e.ClaseName)
                    .HasName("PK__oaux_externo__793DFFAF");

                entity.ToTable("oaux_externo");

                entity.Property(e => e.ClaseName)
                    .HasColumnName("clase_name")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaseDescripcion)
                    .HasColumnName("clase_descripcion")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");
            });

            modelBuilder.Entity<OauxOrigen>(entity =>
            {
                entity.HasKey(e => e.ClaseName)
                    .HasName("PK__oaux_origen__65370702");

                entity.ToTable("oaux_origen");

                entity.Property(e => e.ClaseName)
                    .HasColumnName("clase_name")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaseDescripcion)
                    .HasColumnName("clase_descripcion")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.ClaseHis)
                    .HasColumnName("clase_his")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Laboratorio)
                    .HasColumnName("laboratorio")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')");
            });

            modelBuilder.Entity<OauxServicio>(entity =>
            {
                entity.HasKey(e => new { e.ClaseName, e.ClaseOrigen })
                    .HasName("PK__oaux_servicio__690797E6");

                entity.ToTable("oaux_servicio");

                entity.Property(e => e.ClaseName)
                    .HasColumnName("clase_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ClaseOrigen)
                    .HasColumnName("clase_origen")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('VOID')");

                entity.Property(e => e.ClaseDescripcion)
                    .HasColumnName("clase_descripcion")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.ClaseHis)
                    .HasColumnName("clase_his")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Laboratorio)
                    .HasColumnName("laboratorio")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')");
            });

            modelBuilder.Entity<OauxWg>(entity =>
            {
                entity.HasKey(e => e.ClaseName)
                    .HasName("PK__oaux_wg__76619304");

                entity.ToTable("oaux_wg");

                entity.Property(e => e.ClaseName)
                    .HasColumnName("clase_name")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaseDescripcion)
                    .HasColumnName("clase_descripcion")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");
            });

            modelBuilder.Entity<Oauxiliar>(entity =>
            {
                entity.HasKey(e => new { e.Clase, e.ClaseName })
                    .HasName("PK__oauxiliar__5CA1C101");

                entity.ToTable("oauxiliar");

                entity.Property(e => e.Clase).HasColumnName("clase");

                entity.Property(e => e.ClaseName)
                    .HasColumnName("clase_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ClaseDescripcion)
                    .HasColumnName("clase_descripcion")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ClaseExtra1)
                    .HasColumnName("clase_extra1")
                    .HasMaxLength(127)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ClaseExtra2)
                    .HasColumnName("clase_extra2")
                    .HasMaxLength(127)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ClaseValor)
                    .HasColumnName("clase_valor")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<OcenterHist>(entity =>
            {
                entity.HasKey(e => new { e.CodCentro, e.HistoriaC })
                    .HasName("PK__ocenter_hist__625A9A57");

                entity.ToTable("ocenter_hist");

                entity.HasIndex(e => e.UnicoId)
                    .HasName("kidx_uid_oc");

                entity.Property(e => e.CodCentro)
                    .HasColumnName("cod_centro")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HistoriaC)
                    .HasColumnName("historia_c")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Historia)
                    .IsRequired()
                    .HasColumnName("historia")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UnicoId)
                    .HasColumnName("unico_id")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Ocompuesto>(entity =>
            {
                entity.HasKey(e => new { e.CompuestoFecha, e.CompuestoOrden, e.CompuestoParam, e.CompuestoOrden1, e.CompuestoOrden2 })
                    .HasName("PK__ocompuesto__40257DE4");

                entity.ToTable("ocompuesto");

                entity.HasIndex(e => e.CompuestoTexto48)
                    .HasName("kcompuesto_48");

                entity.Property(e => e.CompuestoFecha)
                    .HasColumnName("compuesto_fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompuestoOrden).HasColumnName("compuesto_orden");

                entity.Property(e => e.CompuestoParam).HasColumnName("compuesto_param");

                entity.Property(e => e.CompuestoOrden1).HasColumnName("compuesto_orden1");

                entity.Property(e => e.CompuestoOrden2).HasColumnName("compuesto_orden2");

                entity.Property(e => e.CompuestoNum1)
                    .HasColumnName("compuesto_num_1")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.CompuestoNum2)
                    .HasColumnName("compuesto_num_2")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.CompuestoNum3)
                    .HasColumnName("compuesto_num_3")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.CompuestoNum4)
                    .HasColumnName("compuesto_num_4")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.CompuestoTexto16)
                    .HasColumnName("compuesto_texto_16")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.CompuestoTexto48)
                    .HasColumnName("compuesto_texto_48")
                    .HasMaxLength(47)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.CompuestoTexto64)
                    .HasColumnName("compuesto_texto_64")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");
            });

            modelBuilder.Entity<Oexcluye>(entity =>
            {
                entity.HasKey(e => e.Edia)
                    .HasName("PK__oexcluye__1CDC41A7");

                entity.ToTable("oexcluye");

                entity.Property(e => e.Edia)
                    .HasColumnName("edia")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cexfutur)
                    .HasColumnName("cexfutur")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Eflag)
                    .HasColumnName("eflag")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Iexfutur1)
                    .HasColumnName("iexfutur1")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Iexfutur2)
                    .HasColumnName("iexfutur2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MaxPacientes)
                    .HasColumnName("max_pacientes")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Ofechas>(entity =>
            {
                entity.HasKey(e => new { e.FDia, e.FClase })
                    .HasName("PK__ofechas__286302EC");

                entity.ToTable("ofechas");

                entity.Property(e => e.FDia)
                    .HasColumnName("f_dia")
                    .HasColumnType("datetime");

                entity.Property(e => e.FClase).HasColumnName("f_clase");

                entity.Property(e => e.FCount)
                    .HasColumnName("f_count")
                    .HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<Oficha>(entity =>
            {
                entity.HasKey(e => new { e.FichaDate, e.FichaOrder })
                    .HasName("PK__oficha__2B3F6F97");

                entity.ToTable("oficha");

                entity.HasIndex(e => e.Icu)
                    .HasName("kicu");

                entity.HasIndex(e => e.UnicoId)
                    .HasName("kunico_id");

                entity.HasIndex(e => new { e.Terminado, e.Custom })
                    .HasName("kficha_terminado");

                entity.Property(e => e.FichaDate)
                    .HasColumnName("ficha_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FichaOrder)
                    .HasColumnName("ficha_order")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Bextra1)
                    .HasColumnName("bextra1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Bextra2)
                    .HasColumnName("bextra2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cama)
                    .HasColumnName("cama")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cextra1)
                    .HasColumnName("cextra1")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Cia)
                    .HasColumnName("cia")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Custom)
                    .HasColumnName("custom")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DescripDiag)
                    .HasColumnName("descrip_diag")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.DescripMedico)
                    .HasColumnName("descrip_medico")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Diagnostico)
                    .HasColumnName("diagnostico")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Diuresis)
                    .HasColumnName("diuresis")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Embarazo)
                    .HasColumnName("embarazo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExistePrevio)
                    .HasColumnName("existe_previo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Export)
                    .HasColumnName("export")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExternalCodigo)
                    .HasColumnName("external_codigo")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Factura)
                    .HasColumnName("factura")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fdfromhost)
                    .HasColumnName("fdfromhost")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('.')");

                entity.Property(e => e.Fdhistorico)
                    .HasColumnName("fdhistorico")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('.')");

                entity.Property(e => e.Fdimpreso)
                    .HasColumnName("fdimpreso")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('.')");

                entity.Property(e => e.Fdprecitado)
                    .HasColumnName("fdprecitado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('.')");

                entity.Property(e => e.Fdterminado)
                    .HasColumnName("fdterminado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('.')");

                entity.Property(e => e.Fdtransmitido)
                    .HasColumnName("fdtransmitido")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('.')");

                entity.Property(e => e.Fdurgencia)
                    .HasColumnName("fdurgencia")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('.')");

                entity.Property(e => e.FechaImpresion)
                    .HasColumnName("fecha_impresion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaLimpresion)
                    .HasColumnName("fecha_limpresion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRecogida)
                    .HasColumnName("fecha_recogida")
                    .HasColumnType("datetime");

                entity.Property(e => e.FichaDateCrea)
                    .HasColumnName("ficha_date_crea")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FichaEdad)
                    .HasColumnName("ficha_edad")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FichaTipoEdad)
                    .HasColumnName("ficha_tipo_edad")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fichacomentario)
                    .HasColumnName("fichacomentario")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.Fichaflag1)
                    .HasColumnName("fichaflag1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fichaflag2)
                    .HasColumnName("fichaflag2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fichalinea2)
                    .HasColumnName("fichalinea2")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.Fichalinea3)
                    .HasColumnName("fichalinea3")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.FreeField)
                    .HasColumnName("free_field")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Freserved).HasColumnName("freserved");

                entity.Property(e => e.Icu)
                    .HasColumnName("icu")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Impreso).HasColumnName("impreso");

                entity.Property(e => e.InHisto)
                    .HasColumnName("in_histo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Interno)
                    .HasColumnName("interno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Medico)
                    .HasColumnName("medico")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Nino)
                    .HasColumnName("nino")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Operador)
                    .HasColumnName("operador")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OrigenPet)
                    .HasColumnName("origen_pet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pendiente)
                    .HasColumnName("pendiente")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Peso)
                    .HasColumnName("peso")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Precitado)
                    .HasColumnName("precitado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ResultTest)
                    .HasColumnName("result_test")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Servicio)
                    .HasColumnName("servicio")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Sextra1)
                    .HasColumnName("sextra1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sextra2)
                    .HasColumnName("sextra2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sextra3)
                    .HasColumnName("sextra3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Terminado)
                    .HasColumnName("terminado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeImpresion)
                    .HasColumnName("time_impresion")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeLimpresion)
                    .HasColumnName("time_limpresion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Timepet)
                    .HasColumnName("timepet")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TotalTest)
                    .HasColumnName("total_test")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Transmit)
                    .HasColumnName("transmit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnicoId).HasColumnName("unico_id");

                entity.Property(e => e.Urgencia)
                    .HasColumnName("urgencia")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Validado)
                    .HasColumnName("validado")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Ofiles>(entity =>
            {
                entity.HasKey(e => new { e.OfilesClase, e.OfilesFname })
                    .HasName("PK__ofiles__4E53A1AA");

                entity.ToTable("ofiles");

                entity.Property(e => e.OfilesClase).HasColumnName("ofiles_clase");

                entity.Property(e => e.OfilesFname)
                    .HasColumnName("ofiles_fname")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OfilesDate)
                    .HasColumnName("ofiles_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OfilesDescrip)
                    .HasColumnName("ofiles_descrip")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OfilesFcode)
                    .HasColumnName("ofiles_fcode")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OfilesTime)
                    .HasColumnName("ofiles_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OfilesUser)
                    .IsRequired()
                    .HasColumnName("ofiles_user")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Oformu>(entity =>
            {
                entity.HasKey(e => e.Clase)
                    .HasName("PK__oformu__1D114BD1");

                entity.ToTable("oformu");

                entity.HasIndex(e => e.ClaseName)
                    .HasName("kformu_name")
                    .IsUnique();

                entity.Property(e => e.Clase)
                    .HasColumnName("clase")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaseDescrip)
                    .HasColumnName("clase_descrip")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ClaseName)
                    .HasColumnName("clase_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ClaseValor)
                    .HasColumnName("clase_valor")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<OformuData>(entity =>
            {
                entity.HasKey(e => new { e.VoidCodigo, e.ParCodigo })
                    .HasName("PK__oformu_data__20E1DCB5");

                entity.ToTable("oformu_data");

                entity.HasIndex(e => e.ParCodigo)
                    .HasName("kfd_param");

                entity.Property(e => e.VoidCodigo).HasColumnName("void_codigo");

                entity.Property(e => e.ParCodigo).HasColumnName("par_codigo");

                entity.Property(e => e.Abreviado)
                    .IsRequired()
                    .HasColumnName("abreviado")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Absurdembarazo)
                    .HasColumnName("absurdembarazo")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Absurdhembra)
                    .HasColumnName("absurdhembra")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Absurdmax)
                    .HasColumnName("absurdmax")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Absurdmin)
                    .HasColumnName("absurdmin")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Absurdnino)
                    .HasColumnName("absurdnino")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Absurdvaron)
                    .HasColumnName("absurdvaron")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Ajuste)
                    .HasColumnName("ajuste")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Alternate1)
                    .HasColumnName("alternate1")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.AnormalCheck1)
                    .HasColumnName("anormal_check1")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AnormalCheck2)
                    .HasColumnName("anormal_check2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AnormalCheck3)
                    .HasColumnName("anormal_check3")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AnormalCheck4)
                    .HasColumnName("anormal_check4")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AnormalInclude1)
                    .HasColumnName("anormal_include1")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AnormalInclude2)
                    .HasColumnName("anormal_include2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AnormalInclude3)
                    .HasColumnName("anormal_include3")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AnormalInclude4)
                    .HasColumnName("anormal_include4")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Asocglos)
                    .HasColumnName("asocglos")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Asocgraf)
                    .HasColumnName("asocgraf")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Automat)
                    .HasColumnName("automat")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Checkformula)
                    .HasColumnName("checkformula")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodigoGeneral)
                    .HasColumnName("codigo_general")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.CodigoManual)
                    .HasColumnName("codigo_manual")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.CodigosAut1)
                    .HasColumnName("codigos_aut1")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.CodigosAut2)
                    .HasColumnName("codigos_aut2")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.CodigosAut3)
                    .HasColumnName("codigos_aut3")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Delta)
                    .HasColumnName("delta")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Deltafactor)
                    .HasColumnName("deltafactor")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DescripAut1)
                    .HasColumnName("descrip_aut1")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.DescripAut2)
                    .HasColumnName("descrip_aut2")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.DescripAut3)
                    .HasColumnName("descrip_aut3")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Especial)
                    .HasColumnName("especial")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Etiqueta)
                    .HasColumnName("etiqueta")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FacAut1)
                    .HasColumnName("fac_aut1")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.FacAut2)
                    .HasColumnName("fac_aut2")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.FacAut3)
                    .HasColumnName("fac_aut3")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Facunidad2)
                    .HasColumnName("facunidad2")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.FamDescrip)
                    .HasColumnName("fam_descrip")
                    .HasMaxLength(47)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Familia)
                    .HasColumnName("familia")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000')");

                entity.Property(e => e.Formula)
                    .HasColumnName("formula")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.GrupoTrabajo)
                    .HasColumnName("grupo_trabajo")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IncludeValorMayor)
                    .HasColumnName("include_valor_mayor")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IncludeValorMenor)
                    .HasColumnName("include_valor_menor")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IncludeValorNegativo)
                    .HasColumnName("include_valor_negativo")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IncludeValorPositivo)
                    .HasColumnName("include_valor_positivo")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Inter1)
                    .HasColumnName("inter1")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Inter2)
                    .HasColumnName("inter2")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Inter3)
                    .HasColumnName("inter3")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Inter4)
                    .HasColumnName("inter4")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Inter5)
                    .HasColumnName("inter5")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.MaxInter1)
                    .HasColumnName("max_inter1")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MaxInter2)
                    .HasColumnName("max_inter2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MaxInter3)
                    .HasColumnName("max_inter3")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MaxInter4)
                    .HasColumnName("max_inter4")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MaxInter5)
                    .HasColumnName("max_inter5")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Maxescala)
                    .HasColumnName("maxescala")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Maxrl)
                    .HasColumnName("maxrl")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MinInter1)
                    .HasColumnName("min_inter1")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MinInter2)
                    .HasColumnName("min_inter2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MinInter3)
                    .HasColumnName("min_inter3")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MinInter4)
                    .HasColumnName("min_inter4")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MinInter5)
                    .HasColumnName("min_inter5")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Minescala)
                    .HasColumnName("minescala")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Minrl)
                    .HasColumnName("minrl")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MuestraAut1)
                    .HasColumnName("muestra_aut1")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.MuestraAut2)
                    .HasColumnName("muestra_aut2")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.MuestraAut3)
                    .HasColumnName("muestra_aut3")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.NoStad)
                    .HasColumnName("no_stad")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NormalCheck1)
                    .HasColumnName("normal_check1")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NormalCheck2)
                    .HasColumnName("normal_check2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NormalCheck3)
                    .HasColumnName("normal_check3")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NormalCheck4)
                    .HasColumnName("normal_check4")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NumAutomat).HasColumnName("num_automat");

                entity.Property(e => e.NumEspecial)
                    .HasColumnName("num_especial")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Orden)
                    .HasColumnName("orden")
                    .HasDefaultValueSql("(999)");

                entity.Property(e => e.Panicmax)
                    .HasColumnName("panicmax")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Panicmin)
                    .HasColumnName("panicmin")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ParGrupo).HasColumnName("par_grupo");

                entity.Property(e => e.ParMuestra)
                    .IsRequired()
                    .HasColumnName("par_muestra")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ParNombre)
                    .IsRequired()
                    .HasColumnName("par_nombre")
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.Porcentaje1)
                    .HasColumnName("porcentaje1")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Porcentaje2)
                    .HasColumnName("porcentaje2")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Porcentaje3)
                    .HasColumnName("porcentaje3")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Porcentaje4)
                    .HasColumnName("porcentaje4")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Porcentaje5)
                    .HasColumnName("porcentaje5")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.PreResult)
                    .HasColumnName("pre_result")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PreResultFlag)
                    .HasColumnName("pre_result_flag")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PrecioBase)
                    .HasColumnName("precio_base")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ReservedSmallint)
                    .HasColumnName("reserved_smallint")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.T1)
                    .HasColumnName("t1")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.T2)
                    .HasColumnName("t2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.T3)
                    .HasColumnName("t3")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Tarifa1)
                    .HasColumnName("tarifa1")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Tarifa2)
                    .HasColumnName("tarifa2")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Tarifa3)
                    .HasColumnName("tarifa3")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Tarifa4)
                    .HasColumnName("tarifa4")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Tarifa5)
                    .HasColumnName("tarifa5")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Tecnica)
                    .HasColumnName("tecnica")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.TestExterno)
                    .HasColumnName("test_externo")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TestImprocedente)
                    .HasColumnName("test_improcedente")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TestInterpretado)
                    .HasColumnName("test_interpretado")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TestProyecto)
                    .HasColumnName("test_proyecto")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TestTimprocedente)
                    .HasColumnName("test_timprocedente")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoResult)
                    .HasColumnName("tipo_result")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Unidad2)
                    .HasColumnName("unidad2")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Unidades)
                    .IsRequired()
                    .HasColumnName("unidades")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ValorInferior1)
                    .HasColumnName("valor_inferior1")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorInferior2)
                    .HasColumnName("valor_inferior2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorInferior3)
                    .HasColumnName("valor_inferior3")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorInferior4)
                    .HasColumnName("valor_inferior4")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorSuperior1)
                    .HasColumnName("valor_superior1")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorSuperior2)
                    .HasColumnName("valor_superior2")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorSuperior3)
                    .HasColumnName("valor_superior3")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ValorSuperior4)
                    .HasColumnName("valor_superior4")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Variacion)
                    .HasColumnName("variacion")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.VoidReserved)
                    .HasColumnName("void_reserved")
                    .HasDefaultValueSql("(0)");

                entity.HasOne(d => d.NumAutomatNavigation)
                    .WithMany(p => p.OformuData)
                    .HasForeignKey(d => d.NumAutomat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__oformu_da__num_a__24B26D99");

                entity.HasOne(d => d.ParGrupoNavigation)
                    .WithMany(p => p.OformuData)
                    .HasForeignKey(d => d.ParGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__oformu_da__par_g__22CA2527");
            });

            modelBuilder.Entity<Ogol>(entity =>
            {
                entity.HasKey(e => new { e.OgolNum, e.OgolDate, e.OgolOrder })
                    .HasName("PK__ogol__76969D2E");

                entity.ToTable("ogol");

                entity.Property(e => e.OgolNum).HasColumnName("ogol_num");

                entity.Property(e => e.OgolDate)
                    .HasColumnName("ogol_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OgolOrder).HasColumnName("ogol_order");

                entity.Property(e => e.OgolFlag)
                    .HasColumnName("ogol_flag")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OgolTime)
                    .HasColumnName("ogol_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Ogrupos>(entity =>
            {
                entity.HasKey(e => e.Clase)
                    .HasName("PK__ogrupos__01D345B0");

                entity.ToTable("ogrupos");

                entity.HasIndex(e => e.ClaseName)
                    .HasName("kgrupo_name")
                    .IsUnique();

                entity.Property(e => e.Clase)
                    .HasColumnName("clase")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaseDescripcion)
                    .HasColumnName("clase_descripcion")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.ClaseName)
                    .HasColumnName("clase_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ClaseValor)
                    .HasColumnName("clase_valor")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Ohistidx>(entity =>
            {
                entity.HasKey(e => e.IdxUnicoId)
                    .HasName("PK__ohistidx__1367E606");

                entity.ToTable("ohistidx");

                entity.HasIndex(e => e.IdxDni)
                    .HasName("kidx_dni");

                entity.HasIndex(e => e.IdxHistoria)
                    .HasName("kidx_historia");

                entity.HasIndex(e => new { e.IdxApell1, e.IdxApell2, e.IdxName })
                    .HasName("knombre");

                entity.Property(e => e.IdxUnicoId)
                    .HasColumnName("idx_unico_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.IdxApell1)
                    .HasColumnName("idx_apell1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdxApell2)
                    .HasColumnName("idx_apell2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdxChar1)
                    .HasColumnName("idx_char1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IdxCount)
                    .HasColumnName("idx_count")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdxDni)
                    .HasColumnName("idx_dni")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdxFechaNacimiento)
                    .HasColumnName("idx_fecha_nacimiento")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdxFichaDate)
                    .HasColumnName("idx_ficha_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdxHistoCount)
                    .HasColumnName("idx_histo_count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdxHistoria)
                    .HasColumnName("idx_historia")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IdxInt1)
                    .HasColumnName("idx_int1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdxInt2)
                    .HasColumnName("idx_int2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdxLong1)
                    .HasColumnName("idx_long1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdxName)
                    .HasColumnName("idx_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdxSexo)
                    .HasColumnName("idx_sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.Orden)
                    .HasColumnName("orden")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("poblacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Tfono)
                    .HasColumnName("tfono")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ohistlog>(entity =>
            {
                entity.HasKey(e => new { e.LogUnicoId, e.LogOrderCopy })
                    .HasName("PK__ohistlog__239E4DCF");

                entity.ToTable("ohistlog");

                entity.HasIndex(e => new { e.LogDate, e.LogOrder })
                    .HasName("k_codigo");

                entity.Property(e => e.LogUnicoId).HasColumnName("log_unico_id");

                entity.Property(e => e.LogOrderCopy).HasColumnName("log_order_copy");

                entity.Property(e => e.LogDate)
                    .HasColumnName("log_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LogDateCopy)
                    .HasColumnName("log_date_copy")
                    .HasColumnType("datetime");

                entity.Property(e => e.LogOrder).HasColumnName("log_order");

                entity.Property(e => e.LogVolumen)
                    .HasColumnName("log_volumen")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.LogVolumenDescrip)
                    .HasColumnName("log_volumen_descrip")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ohost>(entity =>
            {
                entity.HasKey(e => new { e.HostDate, e.HostOrder })
                    .HasName("PK__ohost__6477ECF3");

                entity.ToTable("ohost");

                entity.HasIndex(e => e.Accesion)
                    .HasName("kaccesion");

                entity.Property(e => e.HostDate)
                    .HasColumnName("host_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.HostOrder).HasColumnName("host_order");

                entity.Property(e => e.Accesion)
                    .HasColumnName("accesion")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.HostCopa).HasColumnName("host_copa");

                entity.Property(e => e.HostFlag)
                    .HasColumnName("host_flag")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.HostSector)
                    .HasColumnName("host_sector")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.HostTesttype)
                    .HasColumnName("host_testtype")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Hostprinttype)
                    .HasColumnName("hostprinttype")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.Hostsampletype)
                    .HasColumnName("hostsampletype")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PatientId)
                    .HasColumnName("patient_id")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");
            });

            modelBuilder.Entity<Olcopa>(entity =>
            {
                entity.HasKey(e => new { e.OlcopaNum, e.OlcopaSector, e.OlcopaCopa })
                    .HasName("PK__olcopa__075714DC");

                entity.ToTable("olcopa");

                entity.HasIndex(e => new { e.OlcopaDate, e.OlcopaOrder })
                    .HasName("kolcopa_ficha");

                entity.HasIndex(e => new { e.OlcopaNum, e.OlcopaStatus })
                    .HasName("kolcopa_prog");

                entity.Property(e => e.OlcopaNum).HasColumnName("olcopa_num");

                entity.Property(e => e.OlcopaSector).HasColumnName("olcopa_sector");

                entity.Property(e => e.OlcopaCopa).HasColumnName("olcopa_copa");

                entity.Property(e => e.OlcopaCustom).HasColumnName("olcopa_custom");

                entity.Property(e => e.OlcopaDate)
                    .HasColumnName("olcopa_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OlcopaDescrip)
                    .HasColumnName("olcopa_descrip")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OlcopaError)
                    .HasColumnName("olcopa_error")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OlcopaMuestra)
                    .IsRequired()
                    .HasColumnName("olcopa_muestra")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OlcopaNmuestra)
                    .HasColumnName("olcopa_nmuestra")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.OlcopaOrder).HasColumnName("olcopa_order");

                entity.Property(e => e.OlcopaOrigen)
                    .HasColumnName("olcopa_origen")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OlcopaStatus)
                    .HasColumnName("olcopa_status")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OlcopaTipo)
                    .HasColumnName("olcopa_tipo")
                    .HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<Olcopap>(entity =>
            {
                entity.HasKey(e => new { e.OlcopapNum, e.OlcopapSector, e.OlcopapCopa, e.OlcopapParam })
                    .HasName("PK__olcopap__0EF836A4");

                entity.ToTable("olcopap");

                entity.Property(e => e.OlcopapNum).HasColumnName("olcopap_num");

                entity.Property(e => e.OlcopapSector).HasColumnName("olcopap_sector");

                entity.Property(e => e.OlcopapCopa).HasColumnName("olcopap_copa");

                entity.Property(e => e.OlcopapParam).HasColumnName("olcopap_param");

                entity.Property(e => e.OlcopapMuestra)
                    .HasColumnName("olcopap_muestra")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OlcopapName)
                    .HasColumnName("olcopap_name")
                    .HasMaxLength(47)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");
            });

            modelBuilder.Entity<Olgrupos>(entity =>
            {
                entity.HasKey(e => e.OlgruposNum)
                    .HasName("PK__olgrupos__04AFB25B");

                entity.ToTable("olgrupos");

                entity.Property(e => e.OlgruposNum)
                    .HasColumnName("olgrupos_num")
                    .ValueGeneratedNever();

                entity.Property(e => e.OlgruposDescrip)
                    .HasColumnName("olgrupos_descrip")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");
            });

            modelBuilder.Entity<Olnum>(entity =>
            {
                entity.HasKey(e => e.OlnumNum)
                    .HasName("PK__olnum__078C1F06");

                entity.ToTable("olnum");

                entity.Property(e => e.OlnumNum)
                    .HasColumnName("olnum_num")
                    .ValueGeneratedNever();

                entity.Property(e => e.OlnumBarcode)
                    .HasColumnName("olnum_barcode")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OlnumBarcodePrefix)
                    .HasColumnName("olnum_barcode_prefix")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OlnumBidireccional)
                    .HasColumnName("olnum_bidireccional")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.OlnumCopas)
                    .HasColumnName("olnum_copas")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.OlnumDescrip)
                    .HasColumnName("olnum_descrip")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OlnumGrupo).HasColumnName("olnum_grupo");

                entity.Property(e => e.OlnumRealtime)
                    .HasColumnName("olnum_realtime")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OlnumSectores)
                    .HasColumnName("olnum_sectores")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.OlnumTrans)
                    .HasColumnName("olnum_trans")
                    .HasDefaultValueSql("(0)");

                entity.HasOne(d => d.OlnumGrupoNavigation)
                    .WithMany(p => p.Olnum)
                    .HasForeignKey(d => d.OlnumGrupo)
                    .HasConstraintName("FK__olnum__olnum_gru__0880433F");
            });

            modelBuilder.Entity<Ologin>(entity =>
            {
                entity.HasKey(e => e.LoginName)
                    .HasName("PK__ologin__07F6335A");

                entity.ToTable("ologin");

                entity.Property(e => e.LoginName)
                    .HasColumnName("login_name")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.LoginChange)
                    .HasColumnName("login_change")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LoginCreate)
                    .HasColumnName("login_create")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LoginDef)
                    .HasColumnName("login_def")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LoginDelete)
                    .HasColumnName("login_delete")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LoginDescripcion)
                    .HasColumnName("login_descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginGrupoTrabajo)
                    .HasColumnName("login_grupo_trabajo")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LoginPrint)
                    .HasColumnName("login_print")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LoginValidate)
                    .HasColumnName("login_validate")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UsrPasConsulta)
                    .HasColumnName("usr_pas_consulta")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Oltest>(entity =>
            {
                entity.HasKey(e => new { e.OltestNum, e.OltestParam })
                    .HasName("PK__oltest__7EC1CEDB");

                entity.ToTable("oltest");

                entity.Property(e => e.OltestNum).HasColumnName("oltest_num");

                entity.Property(e => e.OltestParam).HasColumnName("oltest_param");

                entity.Property(e => e.OltestFactor)
                    .HasColumnName("oltest_factor")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OltestFromOl)
                    .HasColumnName("oltest_from_ol")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OltestMuestra)
                    .IsRequired()
                    .HasColumnName("oltest_muestra")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OltestToOl)
                    .HasColumnName("oltest_to_ol")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OltestUnidades)
                    .IsRequired()
                    .HasColumnName("oltest_unidades")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OltestValueMayor)
                    .HasColumnName("oltest_value_mayor")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OltestValueMenor)
                    .HasColumnName("oltest_value_menor")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.HasOne(d => d.OltestNumNavigation)
                    .WithMany(p => p.Oltest)
                    .HasForeignKey(d => d.OltestNum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__oltest__oltest_n__7FB5F314");

                entity.HasOne(d => d.OltestParamNavigation)
                    .WithMany(p => p.Oltest)
                    .HasForeignKey(d => d.OltestParam)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__oltest__oltest_p__00AA174D");
            });

            modelBuilder.Entity<Onaccesion>(entity =>
            {
                entity.HasKey(e => e.AccesionNumber)
                    .HasName("PK__onaccesion__267ABA7A");

                entity.ToTable("onaccesion");

                entity.Property(e => e.AccesionNumber)
                    .HasColumnName("accesion_number")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Operfil>(entity =>
            {
                entity.HasKey(e => e.Clase)
                    .HasName("PK__operfil__2C88998B");

                entity.ToTable("operfil");

                entity.HasIndex(e => e.ClaseName)
                    .HasName("kperfil_name")
                    .IsUnique();

                entity.Property(e => e.Clase)
                    .HasColumnName("clase")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaseDescrip)
                    .HasColumnName("clase_descrip")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ClaseName)
                    .HasColumnName("clase_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ClaseValor)
                    .HasColumnName("clase_valor")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<OperfilAux>(entity =>
            {
                entity.HasKey(e => new { e.PerfilAuxTipo, e.PerfilAuxNum })
                    .HasName("PK__operfil_aux__7C1A6C5A");

                entity.ToTable("operfil_aux");

                entity.HasIndex(e => e.PerfilAuxName)
                    .HasName("kperfil_aux_name")
                    .IsUnique();

                entity.Property(e => e.PerfilAuxTipo)
                    .HasColumnName("perfil_aux_tipo")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PerfilAuxNum).HasColumnName("perfil_aux_num");

                entity.Property(e => e.PerfilAuxDescripcion)
                    .HasColumnName("perfil_aux_descripcion")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PerfilAuxName)
                    .IsRequired()
                    .HasColumnName("perfil_aux_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperfilAuxData>(entity =>
            {
                entity.HasKey(e => new { e.PerfilAuxDataTipo, e.PerfilAuxDataNum, e.PerfilAuxDataClase, e.PerfilAuxDataName })
                    .HasName("PK__operfil_aux_data__7EF6D905");

                entity.ToTable("operfil_aux_data");

                entity.Property(e => e.PerfilAuxDataTipo)
                    .HasColumnName("perfil_aux_data_tipo")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PerfilAuxDataNum).HasColumnName("perfil_aux_data_num");

                entity.Property(e => e.PerfilAuxDataClase).HasColumnName("perfil_aux_data_clase");

                entity.Property(e => e.PerfilAuxDataName)
                    .HasColumnName("perfil_aux_data_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PerfilAuxDataDescripcion)
                    .HasColumnName("perfil_aux_data_descripcion")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");
            });

            modelBuilder.Entity<OperfilData>(entity =>
            {
                entity.HasKey(e => new { e.VoidCodigo, e.ParCodigo })
                    .HasName("PK__operfil_data__30592A6F");

                entity.ToTable("operfil_data");

                entity.HasIndex(e => e.ParCodigo)
                    .HasName("kpd_param");

                entity.Property(e => e.VoidCodigo).HasColumnName("void_codigo");

                entity.Property(e => e.ParCodigo).HasColumnName("par_codigo");

                entity.Property(e => e.Abreviado)
                    .IsRequired()
                    .HasColumnName("abreviado")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Absurdembarazo)
                    .HasColumnName("absurdembarazo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Absurdhembra)
                    .HasColumnName("absurdhembra")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Absurdmax)
                    .HasColumnName("absurdmax")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Absurdmin)
                    .HasColumnName("absurdmin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Absurdnino)
                    .HasColumnName("absurdnino")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Absurdvaron)
                    .HasColumnName("absurdvaron")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ajuste)
                    .HasColumnName("ajuste")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Alternate1)
                    .HasColumnName("alternate1")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AnormalCheck1)
                    .HasColumnName("anormal_check1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnormalCheck2)
                    .HasColumnName("anormal_check2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnormalCheck3)
                    .HasColumnName("anormal_check3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnormalCheck4)
                    .HasColumnName("anormal_check4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnormalInclude1)
                    .HasColumnName("anormal_include1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnormalInclude2)
                    .HasColumnName("anormal_include2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnormalInclude3)
                    .HasColumnName("anormal_include3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnormalInclude4)
                    .HasColumnName("anormal_include4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Asocglos)
                    .HasColumnName("asocglos")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Asocgraf)
                    .HasColumnName("asocgraf")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Automat)
                    .HasColumnName("automat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Checkformula)
                    .HasColumnName("checkformula")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodPerfil)
                    .HasColumnName("cod_perfil")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoGeneral)
                    .HasColumnName("codigo_general")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoManual)
                    .HasColumnName("codigo_manual")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CodigosAut1)
                    .HasColumnName("codigos_aut1")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CodigosAut2)
                    .HasColumnName("codigos_aut2")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CodigosAut3)
                    .HasColumnName("codigos_aut3")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Delta)
                    .HasColumnName("delta")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Deltafactor)
                    .HasColumnName("deltafactor")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DescripAut1)
                    .HasColumnName("descrip_aut1")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DescripAut2)
                    .HasColumnName("descrip_aut2")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DescripAut3)
                    .HasColumnName("descrip_aut3")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Especial)
                    .HasColumnName("especial")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Etiqueta)
                    .HasColumnName("etiqueta")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FacAut1)
                    .HasColumnName("fac_aut1")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FacAut2)
                    .HasColumnName("fac_aut2")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FacAut3)
                    .HasColumnName("fac_aut3")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Facunidad2)
                    .HasColumnName("facunidad2")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FamDescrip)
                    .HasColumnName("fam_descrip")
                    .HasMaxLength(47)
                    .IsUnicode(false);

                entity.Property(e => e.Familia)
                    .HasColumnName("familia")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000')");

                entity.Property(e => e.Formula)
                    .HasColumnName("formula")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoTrabajo)
                    .HasColumnName("grupo_trabajo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IncludeValorMayor)
                    .HasColumnName("include_valor_mayor")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IncludeValorMenor)
                    .HasColumnName("include_valor_menor")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IncludeValorNegativo)
                    .HasColumnName("include_valor_negativo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IncludeValorPositivo)
                    .HasColumnName("include_valor_positivo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Inter1)
                    .HasColumnName("inter1")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Inter2)
                    .HasColumnName("inter2")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Inter3)
                    .HasColumnName("inter3")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Inter4)
                    .HasColumnName("inter4")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Inter5)
                    .HasColumnName("inter5")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MaxInter1)
                    .HasColumnName("max_inter1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxInter2)
                    .HasColumnName("max_inter2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxInter3)
                    .HasColumnName("max_inter3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxInter4)
                    .HasColumnName("max_inter4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxInter5)
                    .HasColumnName("max_inter5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Maxescala)
                    .HasColumnName("maxescala")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Maxrl)
                    .HasColumnName("maxrl")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MinInter1)
                    .HasColumnName("min_inter1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MinInter2)
                    .HasColumnName("min_inter2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MinInter3)
                    .HasColumnName("min_inter3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MinInter4)
                    .HasColumnName("min_inter4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MinInter5)
                    .HasColumnName("min_inter5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Minescala)
                    .HasColumnName("minescala")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Minrl)
                    .HasColumnName("minrl")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MuestraAut1)
                    .HasColumnName("muestra_aut1")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.MuestraAut2)
                    .HasColumnName("muestra_aut2")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.MuestraAut3)
                    .HasColumnName("muestra_aut3")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NoStad)
                    .HasColumnName("no_stad")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NormalCheck1)
                    .HasColumnName("normal_check1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NormalCheck2)
                    .HasColumnName("normal_check2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NormalCheck3)
                    .HasColumnName("normal_check3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NormalCheck4)
                    .HasColumnName("normal_check4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NumAutomat).HasColumnName("num_automat");

                entity.Property(e => e.NumEspecial)
                    .HasColumnName("num_especial")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Orden)
                    .HasColumnName("orden")
                    .HasDefaultValueSql("((999))");

                entity.Property(e => e.Panicmax)
                    .HasColumnName("panicmax")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Panicmin)
                    .HasColumnName("panicmin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PantillaBel)
                    .HasColumnName("Pantilla_BEL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParGrupo).HasColumnName("par_grupo");

                entity.Property(e => e.ParMuestra)
                    .IsRequired()
                    .HasColumnName("par_muestra")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ParNombre)
                    .IsRequired()
                    .HasColumnName("par_nombre")
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.Plantilla)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PlantillaBse)
                    .HasColumnName("Plantilla_BSE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PlantillaEid)
                    .HasColumnName("Plantilla_EId")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Porcentaje1)
                    .HasColumnName("porcentaje1")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Porcentaje2)
                    .HasColumnName("porcentaje2")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Porcentaje3)
                    .HasColumnName("porcentaje3")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Porcentaje4)
                    .HasColumnName("porcentaje4")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Porcentaje5)
                    .HasColumnName("porcentaje5")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PreResult)
                    .HasColumnName("pre_result")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PreResultFlag)
                    .HasColumnName("pre_result_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioBase)
                    .HasColumnName("precio_base")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReservedSmallint)
                    .HasColumnName("reserved_smallint")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.T1)
                    .HasColumnName("t1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.T2)
                    .HasColumnName("t2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.T3)
                    .HasColumnName("t3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tarifa1)
                    .HasColumnName("tarifa1")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tarifa2)
                    .HasColumnName("tarifa2")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tarifa3)
                    .HasColumnName("tarifa3")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tarifa4)
                    .HasColumnName("tarifa4")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tarifa5)
                    .HasColumnName("tarifa5")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tecnica)
                    .HasColumnName("tecnica")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.TestExterno)
                    .HasColumnName("test_externo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TestImprocedente)
                    .HasColumnName("test_improcedente")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TestInterpretado)
                    .HasColumnName("test_interpretado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TestProyecto)
                    .HasColumnName("test_proyecto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TestTimprocedente)
                    .HasColumnName("test_timprocedente")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoResult)
                    .HasColumnName("tipo_result")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Unidad2)
                    .HasColumnName("unidad2")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Unidades)
                    .IsRequired()
                    .HasColumnName("unidades")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ValorInferior1)
                    .HasColumnName("valor_inferior1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorInferior2)
                    .HasColumnName("valor_inferior2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorInferior3)
                    .HasColumnName("valor_inferior3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorInferior4)
                    .HasColumnName("valor_inferior4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorSuperior1)
                    .HasColumnName("valor_superior1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorSuperior2)
                    .HasColumnName("valor_superior2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorSuperior3)
                    .HasColumnName("valor_superior3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorSuperior4)
                    .HasColumnName("valor_superior4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Variacion)
                    .HasColumnName("variacion")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VoidReserved)
                    .HasColumnName("void_reserved")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.NumAutomatNavigation)
                    .WithMany(p => p.OperfilData)
                    .HasForeignKey(d => d.NumAutomat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__operfil_d__num_a__3429BB53");

                entity.HasOne(d => d.ParGrupoNavigation)
                    .WithMany(p => p.OperfilData)
                    .HasForeignKey(d => d.ParGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__operfil_d__par_g__324172E1");
            });

            modelBuilder.Entity<Oprecio>(entity =>
            {
                entity.HasKey(e => new { e.PrecioCodigo, e.CiaClase, e.CiaName })
                    .HasName("PK__oprecio__27C3E46E");

                entity.ToTable("oprecio");

                entity.Property(e => e.PrecioCodigo).HasColumnName("precio_codigo");

                entity.Property(e => e.CiaClase).HasColumnName("cia_clase");

                entity.Property(e => e.CiaName)
                    .HasColumnName("cia_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoCia)
                    .HasColumnName("codigo_cia")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.PrecioValor)
                    .HasColumnName("precio_valor")
                    .HasDefaultValueSql("(0)");

                entity.HasOne(d => d.PrecioCodigoNavigation)
                    .WithMany(p => p.Oprecio)
                    .HasForeignKey(d => d.PrecioCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__oprecio__precio___28B808A7");
            });

            modelBuilder.Entity<Oproceso>(entity =>
            {
                entity.HasKey(e => e.ProcesoCode)
                    .HasName("PK__oproceso__34B3CB38");

                entity.ToTable("oproceso");

                entity.Property(e => e.ProcesoCode)
                    .HasColumnName("proceso_code")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProcesoDescripcion)
                    .HasColumnName("proceso_descripcion")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.ProcesoDuracion)
                    .HasColumnName("proceso_duracion")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ProcesoIcono)
                    .HasColumnName("proceso_icono")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ProcesoNombre)
                    .IsRequired()
                    .HasColumnName("proceso_nombre")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ProcesoPrefijo)
                    .HasColumnName("proceso_prefijo")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OprocesoOt>(entity =>
            {
                entity.HasKey(e => new { e.ProcesoOtFecha, e.ProcesoOtOrden, e.ProcesoOtParam, e.ProcesoOtRow, e.ProcesoOtCol })
                    .HasName("PK__oproceso_ot__379037E3");

                entity.ToTable("oproceso_ot");

                entity.HasIndex(e => e.ProcesoOtFlag)
                    .HasName("kproceso_flag");

                entity.HasIndex(e => e.ProcesoOtId)
                    .HasName("kproceso_id");

                entity.HasIndex(e => new { e.ProcesoOtFechaI, e.ProcesoOtHoraI })
                    .HasName("kproceso_time");

                entity.Property(e => e.ProcesoOtFecha)
                    .HasColumnName("proceso_ot_fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcesoOtOrden).HasColumnName("proceso_ot_orden");

                entity.Property(e => e.ProcesoOtParam).HasColumnName("proceso_ot_param");

                entity.Property(e => e.ProcesoOtRow).HasColumnName("proceso_ot_row");

                entity.Property(e => e.ProcesoOtCol).HasColumnName("proceso_ot_col");

                entity.Property(e => e.ProcesoOtCodigo).HasColumnName("proceso_ot_codigo");

                entity.Property(e => e.ProcesoOtComentario)
                    .HasColumnName("proceso_ot_comentario")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.ProcesoOtFechaF)
                    .HasColumnName("proceso_ot_fecha_f")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProcesoOtFechaI)
                    .HasColumnName("proceso_ot_fecha_i")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProcesoOtFlag)
                    .HasColumnName("proceso_ot_flag")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ProcesoOtHoraF)
                    .HasColumnName("proceso_ot_hora_f")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProcesoOtHoraI)
                    .HasColumnName("proceso_ot_hora_i")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProcesoOtId)
                    .IsRequired()
                    .HasColumnName("proceso_ot_id")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ProcesoOtNew)
                    .HasColumnName("proceso_ot_new")
                    .HasDefaultValueSql("(0)");

                entity.HasOne(d => d.ProcesoOtCodigoNavigation)
                    .WithMany(p => p.OprocesoOt)
                    .HasForeignKey(d => d.ProcesoOtCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__oproceso___proce__38845C1C");
            });

            modelBuilder.Entity<Oproyecto>(entity =>
            {
                entity.HasKey(e => new { e.ParamOwner, e.ParamMember })
                    .HasName("PK__oproyecto__0D99FE17");

                entity.ToTable("oproyecto");

                entity.Property(e => e.ParamOwner).HasColumnName("param_owner");

                entity.Property(e => e.ParamMember).HasColumnName("param_member");

                entity.HasOne(d => d.ParamMemberNavigation)
                    .WithMany(p => p.OproyectoParamMemberNavigation)
                    .HasForeignKey(d => d.ParamMember)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__oproyecto__param__0F824689");

                entity.HasOne(d => d.ParamOwnerNavigation)
                    .WithMany(p => p.OproyectoParamOwnerNavigation)
                    .HasForeignKey(d => d.ParamOwner)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__oproyecto__param__0E8E2250");
            });

            modelBuilder.Entity<Orango>(entity =>
            {
                entity.HasKey(e => new { e.RangoCodigo, e.RangoTipo })
                    .HasName("PK__orango__1E3A7A34");

                entity.ToTable("orango");

                entity.Property(e => e.RangoCodigo).HasColumnName("rango_codigo");

                entity.Property(e => e.RangoTipo).HasColumnName("rango_tipo");

                entity.Property(e => e.RangoEdadInf)
                    .HasColumnName("rango_edad_inf")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RangoEdadSup)
                    .HasColumnName("rango_edad_sup")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RangoInf)
                    .HasColumnName("rango_inf")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RangoSexo)
                    .HasColumnName("rango_sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.RangoSup)
                    .HasColumnName("rango_sup")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TipoEdad)
                    .HasColumnName("tipo_edad")
                    .HasDefaultValueSql("(1)");

                entity.HasOne(d => d.RangoCodigoNavigation)
                    .WithMany(p => p.Orango)
                    .HasForeignKey(d => d.RangoCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__orango__rango_co__1F2E9E6D");
            });

            modelBuilder.Entity<Ospecimen>(entity =>
            {
                entity.HasKey(e => e.SpecimenNum)
                    .HasName("PK__ospecimen__48BAC3E5");

                entity.ToTable("ospecimen");

                entity.HasIndex(e => e.SpecimenUnicoId)
                    .HasName("kspecimen_unico_id");

                entity.Property(e => e.SpecimenNum)
                    .HasColumnName("specimen_num")
                    .ValueGeneratedNever();

                entity.Property(e => e.SpecimenDevice)
                    .HasColumnName("specimen_device")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.SpecimenFecha)
                    .HasColumnName("specimen_fecha")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SpecimenLabel)
                    .HasColumnName("specimen_label")
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.SpecimenMuestra)
                    .HasColumnName("specimen_muestra")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.SpecimenUnicoId).HasColumnName("specimen_unico_id");

                entity.Property(e => e.SpecimenXy)
                    .HasColumnName("specimen_xy")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");
            });

            modelBuilder.Entity<Ostock>(entity =>
            {
                entity.HasKey(e => e.StockCodigo)
                    .HasName("PK__ostock__12C8C788");

                entity.ToTable("ostock");

                entity.Property(e => e.StockCodigo)
                    .HasColumnName("stock_codigo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cmp)
                    .HasColumnName("cmp")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Cpp)
                    .HasColumnName("cpp")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Fuc)
                    .HasColumnName("fuc")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Minalerta)
                    .HasColumnName("minalerta")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Npr)
                    .HasColumnName("npr")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Nuc)
                    .HasColumnName("nuc")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Puc)
                    .HasColumnName("puc")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.StockFecha)
                    .HasColumnName("stock_fecha")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Stockactual)
                    .HasColumnName("stockactual")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<Ot>(entity =>
            {
                entity.HasKey(e => new { e.TDate, e.TOrder, e.TParam })
                    .HasName("PK__ot__02084FDA");

                entity.ToTable("ot");

                entity.HasIndex(e => e.TCerrado)
                    .HasName("kt_cerrado");

                entity.HasIndex(e => e.TDate)
                    .HasName("IX_ot");

                entity.HasIndex(e => e.TFromHis)
                    .HasName("IX_t_from_his");

                entity.HasIndex(e => new { e.TDateVal, e.Tdtransmitido })
                    .HasName("kt_fecha_val");

                entity.HasIndex(e => new { e.TUnicoId, e.TParam, e.TDateCrea })
                    .HasName("kt_unico_id");

                entity.Property(e => e.TDate)
                    .HasColumnName("t_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TOrder)
                    .HasColumnName("t_order")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TParam).HasColumnName("t_param");

                entity.Property(e => e.Anormal)
                    .HasColumnName("anormal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Calculo)
                    .HasColumnName("calculo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hilow)
                    .HasColumnName("hilow")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Incongruente)
                    .HasColumnName("incongruente")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Inonline)
                    .HasColumnName("inonline")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Interpretado)
                    .HasColumnName("interpretado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Numdilucion)
                    .HasColumnName("numdilucion")
                    .HasDefaultValueSql("((1.0))");

                entity.Property(e => e.Numflag3)
                    .HasColumnName("numflag3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Numflag4)
                    .HasColumnName("numflag4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Onlineflag)
                    .HasColumnName("onlineflag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Orderprint)
                    .HasColumnName("orderprint")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RInf).HasColumnName("r_inf");

                entity.Property(e => e.RSup).HasColumnName("r_sup");

                entity.Property(e => e.Resultado).HasColumnName("resultado");

                entity.Property(e => e.Rlinea)
                    .HasColumnName("rlinea")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TCerrado)
                    .HasColumnName("t_cerrado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TCodigoManual)
                    .HasColumnName("t_codigo_manual")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TComFlag)
                    .HasColumnName("t_com_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TComentado)
                    .HasColumnName("t_comentado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TComentario)
                    .HasColumnName("t_comentario")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.TCount)
                    .HasColumnName("t_count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TCustom)
                    .HasColumnName("t_custom")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TDateCrea)
                    .HasColumnName("t_date_crea")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TDateMod)
                    .HasColumnName("t_date_mod")
                    .HasColumnType("datetime");

                entity.Property(e => e.TDateVal)
                    .HasColumnName("t_date_val")
                    .HasColumnType("datetime");

                entity.Property(e => e.TDescripMemo)
                    .HasColumnName("t_descrip_memo")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TEdad)
                    .HasColumnName("t_edad")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TEstad)
                    .HasColumnName("t_estad")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TEtiqueta)
                    .HasColumnName("t_etiqueta")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TExterno)
                    .HasColumnName("t_externo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TExtra).HasColumnName("t_extra");

                entity.Property(e => e.TFamilia)
                    .HasColumnName("t_familia")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TFromHis)
                    .HasColumnName("t_from_his")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TGrupo).HasColumnName("t_grupo");

                entity.Property(e => e.TGrupoTrabajo)
                    .HasColumnName("t_grupo_trabajo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TListas)
                    .HasColumnName("t_listas")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TLong)
                    .HasColumnName("t_long")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TModificadoPor)
                    .HasColumnName("t_modificado_por")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TMuestra)
                    .IsRequired()
                    .HasColumnName("t_muestra")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TNombre)
                    .IsRequired()
                    .HasColumnName("t_nombre")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.TNoprint)
                    .HasColumnName("t_noprint")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TPendMod)
                    .HasColumnName("t_pend_mod")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TPerfil)
                    .HasColumnName("t_perfil")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TPerfilCodigo)
                    .HasColumnName("t_perfil_codigo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TPlantilla)
                    .HasColumnName("t_plantilla")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TPlantillaBel).HasColumnName("t_plantilla_BEL");

                entity.Property(e => e.TPlantillaBse).HasColumnName("t_plantilla_BSE");

                entity.Property(e => e.TPlantillaEid).HasColumnName("t_plantilla_EId");

                entity.Property(e => e.TProyecto)
                    .HasColumnName("t_proyecto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TSexo)
                    .HasColumnName("t_sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.TTimeCrea)
                    .HasColumnName("t_time_crea")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TTimeMod)
                    .HasColumnName("t_time_mod")
                    .HasColumnType("datetime");

                entity.Property(e => e.TTimeVal)
                    .HasColumnName("t_time_val")
                    .HasColumnType("datetime");

                entity.Property(e => e.TTipoEdad)
                    .HasColumnName("t_tipo_edad")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TTipoResult)
                    .HasColumnName("t_tipo_result")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TUnicoId).HasColumnName("t_unico_id");

                entity.Property(e => e.TUnidades)
                    .IsRequired()
                    .HasColumnName("t_unidades")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TValidado)
                    .HasColumnName("t_validado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TValidadoPor)
                    .HasColumnName("t_validado_por")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TValoracion)
                    .HasColumnName("t_valoracion")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tdanormal)
                    .HasColumnName("tdanormal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Tdcalculado)
                    .HasColumnName("tdcalculado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('.')");

                entity.Property(e => e.Tdfromhost)
                    .HasColumnName("tdfromhost")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('.')");

                entity.Property(e => e.Tdimpreso)
                    .HasColumnName("tdimpreso")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('.')");

                entity.Property(e => e.Tdincongruente)
                    .HasColumnName("tdincongruente")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('.')");

                entity.Property(e => e.Tdpendiente)
                    .HasColumnName("tdpendiente")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('.')");

                entity.Property(e => e.Tdterminado)
                    .HasColumnName("tdterminado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('.')");

                entity.Property(e => e.Tdtransmitido)
                    .HasColumnName("tdtransmitido")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('.')");

                entity.Property(e => e.Tdvalidado)
                    .HasColumnName("tdvalidado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('.')");

                entity.Property(e => e.Terminated)
                    .HasColumnName("terminated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VInf).HasColumnName("v_inf");

                entity.Property(e => e.VSup).HasColumnName("v_sup");
            });

            modelBuilder.Entity<OtHisto>(entity =>
            {
                entity.HasKey(e => new { e.THistoDate, e.THistoOrder, e.THistoParam, e.THistoCount })
                    .HasName("PK__ot_histo__3E1D39E1");

                entity.ToTable("ot_histo");

                entity.Property(e => e.THistoDate)
                    .HasColumnName("t_histo_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.THistoOrder).HasColumnName("t_histo_order");

                entity.Property(e => e.THistoParam).HasColumnName("t_histo_param");

                entity.Property(e => e.THistoCount).HasColumnName("t_histo_count");

                entity.Property(e => e.THistoFechaMod)
                    .HasColumnName("t_histo_fecha_mod")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.THistoFechaVal)
                    .HasColumnName("t_histo_fecha_val")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.THistoModificadoPor)
                    .HasColumnName("t_histo_modificado_por")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.THistoRlinea)
                    .HasColumnName("t_histo_rlinea")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.THistoTimeMod)
                    .HasColumnName("t_histo_time_mod")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.THistoTimeVal)
                    .HasColumnName("t_histo_time_val")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.THistoValidado)
                    .HasColumnName("t_histo_validado")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.THistoValidadoPor)
                    .HasColumnName("t_histo_validado_por")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");
            });

            modelBuilder.Entity<OtP>(entity =>
            {
                entity.HasKey(e => new { e.TPDate, e.TPOrder, e.TPParam, e.TPCount })
                    .HasName("PK__ot_p__47A6A41B");

                entity.ToTable("ot_p");

                entity.HasIndex(e => e.TPCerrado)
                    .HasName("kt_p_cerrado");

                entity.Property(e => e.TPDate)
                    .HasColumnName("t_p_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TPOrder).HasColumnName("t_p_order");

                entity.Property(e => e.TPParam).HasColumnName("t_p_param");

                entity.Property(e => e.TPCount).HasColumnName("t_p_count");

                entity.Property(e => e.TPCerrado)
                    .HasColumnName("t_p_cerrado")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TPFecha)
                    .HasColumnName("t_p_fecha")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TPFlag1)
                    .HasColumnName("t_p_flag1")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TPHora)
                    .HasColumnName("t_p_hora")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TPResultado)
                    .HasColumnName("t_p_resultado")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");
            });

            modelBuilder.Entity<OtPerfil>(entity =>
            {
                entity.HasKey(e => new { e.OtPerfilDate, e.OtPerfilOrder, e.OtPerfilClase })
                    .HasName("PK__ot_perfil__7F2BE32F");

                entity.ToTable("ot_perfil");

                entity.Property(e => e.OtPerfilDate)
                    .HasColumnName("ot_perfil_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OtPerfilOrder)
                    .HasColumnName("ot_perfil_order")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OtPerfilClase).HasColumnName("ot_perfil_clase");

                entity.Property(e => e.OtPerfilClaseDescrip)
                    .HasColumnName("ot_perfil_clase_descrip")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.OtPerfilClaseName)
                    .HasColumnName("ot_perfil_clase_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OtPerfilValor)
                    .HasColumnName("ot_perfil_valor")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Otest>(entity =>
            {
                entity.HasKey(e => e.ParCodigo)
                    .HasName("PK__otest__1209AD79");

                entity.ToTable("otest");

                entity.HasIndex(e => e.CodigoManual)
                    .HasName("kcodigo_manual")
                    .IsUnique();

                entity.HasIndex(e => e.GrupoTrabajo)
                    .HasName("kgrupo_trabajo");

                entity.HasIndex(e => e.VoidCodigo)
                    .HasName("kpar_grupo");

                entity.Property(e => e.ParCodigo)
                    .HasColumnName("par_codigo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Abreviado)
                    .IsRequired()
                    .HasColumnName("abreviado")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Absurdembarazo)
                    .HasColumnName("absurdembarazo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Absurdhembra)
                    .HasColumnName("absurdhembra")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Absurdmax)
                    .HasColumnName("absurdmax")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Absurdmin)
                    .HasColumnName("absurdmin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Absurdnino)
                    .HasColumnName("absurdnino")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Absurdvaron)
                    .HasColumnName("absurdvaron")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ajuste)
                    .HasColumnName("ajuste")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Alternate1)
                    .HasColumnName("alternate1")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AnormalCheck1)
                    .HasColumnName("anormal_check1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnormalCheck2)
                    .HasColumnName("anormal_check2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnormalCheck3)
                    .HasColumnName("anormal_check3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnormalCheck4)
                    .HasColumnName("anormal_check4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnormalInclude1)
                    .HasColumnName("anormal_include1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnormalInclude2)
                    .HasColumnName("anormal_include2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnormalInclude3)
                    .HasColumnName("anormal_include3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnormalInclude4)
                    .HasColumnName("anormal_include4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Asocglos)
                    .HasColumnName("asocglos")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Asocgraf)
                    .HasColumnName("asocgraf")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Automat)
                    .HasColumnName("automat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Checkformula)
                    .HasColumnName("checkformula")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodigoGeneral)
                    .HasColumnName("codigo_general")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoManual)
                    .HasColumnName("codigo_manual")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CodigosAut1)
                    .HasColumnName("codigos_aut1")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CodigosAut2)
                    .HasColumnName("codigos_aut2")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CodigosAut3)
                    .HasColumnName("codigos_aut3")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Confidencial)
                    .HasColumnName("confidencial")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Delta)
                    .HasColumnName("delta")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Deltafactor)
                    .HasColumnName("deltafactor")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DescripAut1)
                    .HasColumnName("descrip_aut1")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DescripAut2)
                    .HasColumnName("descrip_aut2")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DescripAut3)
                    .HasColumnName("descrip_aut3")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Especial)
                    .HasColumnName("especial")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Etiqueta)
                    .HasColumnName("etiqueta")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FacAut1)
                    .HasColumnName("fac_aut1")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FacAut2)
                    .HasColumnName("fac_aut2")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FacAut3)
                    .HasColumnName("fac_aut3")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Facunidad2)
                    .HasColumnName("facunidad2")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FamDescrip)
                    .HasColumnName("fam_descrip")
                    .HasMaxLength(47)
                    .IsUnicode(false);

                entity.Property(e => e.Familia)
                    .HasColumnName("familia")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000')");

                entity.Property(e => e.Formula)
                    .HasColumnName("formula")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoTrabajo)
                    .HasColumnName("grupo_trabajo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IncludeValorMayor)
                    .HasColumnName("include_valor_mayor")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IncludeValorMenor)
                    .HasColumnName("include_valor_menor")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IncludeValorNegativo)
                    .HasColumnName("include_valor_negativo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IncludeValorPositivo)
                    .HasColumnName("include_valor_positivo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Inter1)
                    .HasColumnName("inter1")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Inter2)
                    .HasColumnName("inter2")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Inter3)
                    .HasColumnName("inter3")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Inter4)
                    .HasColumnName("inter4")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Inter5)
                    .HasColumnName("inter5")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MaxInter1)
                    .HasColumnName("max_inter1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxInter2)
                    .HasColumnName("max_inter2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxInter3)
                    .HasColumnName("max_inter3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxInter4)
                    .HasColumnName("max_inter4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxInter5)
                    .HasColumnName("max_inter5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Maxescala)
                    .HasColumnName("maxescala")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Maxrl)
                    .HasColumnName("maxrl")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MinInter1)
                    .HasColumnName("min_inter1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MinInter2)
                    .HasColumnName("min_inter2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MinInter3)
                    .HasColumnName("min_inter3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MinInter4)
                    .HasColumnName("min_inter4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MinInter5)
                    .HasColumnName("min_inter5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Minescala)
                    .HasColumnName("minescala")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Minrl)
                    .HasColumnName("minrl")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MuestraAut1)
                    .HasColumnName("muestra_aut1")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.MuestraAut2)
                    .HasColumnName("muestra_aut2")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.MuestraAut3)
                    .HasColumnName("muestra_aut3")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NoStad)
                    .HasColumnName("no_stad")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NormalCheck1)
                    .HasColumnName("normal_check1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NormalCheck2)
                    .HasColumnName("normal_check2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NormalCheck3)
                    .HasColumnName("normal_check3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NormalCheck4)
                    .HasColumnName("normal_check4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NumAutomat).HasColumnName("num_automat");

                entity.Property(e => e.NumEspecial)
                    .HasColumnName("num_especial")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Orden)
                    .HasColumnName("orden")
                    .HasDefaultValueSql("((999))");

                entity.Property(e => e.Panicmax)
                    .HasColumnName("panicmax")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Panicmin)
                    .HasColumnName("panicmin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParGrupo).HasColumnName("par_grupo");

                entity.Property(e => e.ParMuestra)
                    .IsRequired()
                    .HasColumnName("par_muestra")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ParNombre)
                    .IsRequired()
                    .HasColumnName("par_nombre")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PlantillaACod)
                    .HasColumnName("PlantillaA_Cod")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PlantillaBCod)
                    .HasColumnName("PlantillaB_Cod")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PlantillaBElid).HasColumnName("PlantillaB_ELId");

                entity.Property(e => e.PlantillaBSelid).HasColumnName("PlantillaB_SELId");

                entity.Property(e => e.PlantillaECod)
                    .HasColumnName("PlantillaE_Cod")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PlantillaEId).HasColumnName("PlantillaE_Id");

                entity.Property(e => e.Porcentaje1)
                    .HasColumnName("porcentaje1")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Porcentaje2)
                    .HasColumnName("porcentaje2")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Porcentaje3)
                    .HasColumnName("porcentaje3")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Porcentaje4)
                    .HasColumnName("porcentaje4")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Porcentaje5)
                    .HasColumnName("porcentaje5")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PreResult)
                    .HasColumnName("pre_result")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.PreResultFlag)
                    .HasColumnName("pre_result_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioBase)
                    .HasColumnName("precio_base")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReservedSmallint)
                    .HasColumnName("reserved_smallint")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.T1)
                    .HasColumnName("t1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.T2)
                    .HasColumnName("t2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.T3)
                    .HasColumnName("t3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tarifa1)
                    .HasColumnName("tarifa1")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tarifa2)
                    .HasColumnName("tarifa2")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tarifa3)
                    .HasColumnName("tarifa3")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tarifa4)
                    .HasColumnName("tarifa4")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tarifa5)
                    .HasColumnName("tarifa5")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tecnica)
                    .HasColumnName("tecnica")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.TestExterno)
                    .HasColumnName("test_externo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TestImprocedente)
                    .HasColumnName("test_improcedente")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TestInterpretado)
                    .HasColumnName("test_interpretado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TestProyecto)
                    .HasColumnName("test_proyecto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TestTimprocedente)
                    .HasColumnName("test_timprocedente")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoResult)
                    .HasColumnName("tipo_result")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Unidad2)
                    .HasColumnName("unidad2")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Unidades)
                    .IsRequired()
                    .HasColumnName("unidades")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ValorInferior1)
                    .HasColumnName("valor_inferior1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorInferior2)
                    .HasColumnName("valor_inferior2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorInferior3)
                    .HasColumnName("valor_inferior3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorInferior4)
                    .HasColumnName("valor_inferior4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorSuperior1)
                    .HasColumnName("valor_superior1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorSuperior2)
                    .HasColumnName("valor_superior2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorSuperior3)
                    .HasColumnName("valor_superior3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValorSuperior4)
                    .HasColumnName("valor_superior4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Variacion)
                    .HasColumnName("variacion")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VoidCodigo).HasColumnName("void_codigo");

                entity.Property(e => e.VoidReserved)
                    .HasColumnName("void_reserved")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.NumAutomatNavigation)
                    .WithMany(p => p.Otest)
                    .HasForeignKey(d => d.NumAutomat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__otest__num_autom__15DA3E5D");

                entity.HasOne(d => d.ParGrupoNavigation)
                    .WithMany(p => p.Otest)
                    .HasForeignKey(d => d.ParGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__otest__par_grupo__13F1F5EB");
            });

            modelBuilder.Entity<Owg>(entity =>
            {
                entity.HasKey(e => new { e.OwgNum, e.OwgDate, e.OwgOrder })
                    .HasName("PK__owg__7A672E12");

                entity.ToTable("owg");

                entity.Property(e => e.OwgNum).HasColumnName("owg_num");

                entity.Property(e => e.OwgDate)
                    .HasColumnName("owg_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OwgOrder).HasColumnName("owg_order");

                entity.Property(e => e.OwgComentario)
                    .HasColumnName("owg_comentario")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.OwgFlag)
                    .HasColumnName("owg_flag")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OwgTime)
                    .HasColumnName("owg_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PreData>(entity =>
            {
                entity.HasKey(e => new { e.PreDataCode, e.PreDataMask })
                    .HasName("PK__pre_data__56E8E7AB");

                entity.ToTable("pre_data");

                entity.Property(e => e.PreDataCode)
                    .HasColumnName("pre_data_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PreDataMask)
                    .HasColumnName("pre_data_mask")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PreDataFreport)
                    .HasColumnName("pre_data_freport")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PreDataFsave)
                    .HasColumnName("pre_data_fsave")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.PreDataReport)
                    .HasColumnName("pre_data_report")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.HasOne(d => d.PreDataCodeNavigation)
                    .WithMany(p => p.PreData)
                    .HasForeignKey(d => d.PreDataCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__pre_data__pre_da__57DD0BE4");
            });

            modelBuilder.Entity<PreListas>(entity =>
            {
                entity.HasKey(e => e.PreCode)
                    .HasName("PK__pre_listas__540C7B00");

                entity.ToTable("pre_listas");

                entity.Property(e => e.PreCode)
                    .HasColumnName("pre_code")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.PreDescrip)
                    .HasColumnName("pre_descrip")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");
            });

            modelBuilder.Entity<Prodef>(entity =>
            {
                entity.HasKey(e => e.ProdefNum)
                    .HasName("PK__prodef__116A8EFB");

                entity.ToTable("prodef");

                entity.Property(e => e.ProdefNum)
                    .HasColumnName("prodef_num")
                    .ValueGeneratedNever();

                entity.Property(e => e.Prodef3d)
                    .HasColumnName("prodef_3d")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ProdefDescrip)
                    .HasColumnName("prodef_descrip")
                    .HasMaxLength(63)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ProdefFile)
                    .IsRequired()
                    .HasColumnName("prodef_file")
                    .HasMaxLength(63)
                    .IsUnicode(false);

                entity.Property(e => e.ProdefGrafHeigh)
                    .HasColumnName("prodef_graf_heigh")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ProdefGrafLeft)
                    .HasColumnName("prodef_graf_left")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ProdefGrafTop)
                    .HasColumnName("prodef_graf_top")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ProdefGrafWidth)
                    .HasColumnName("prodef_graf_width")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ProdefGrafico)
                    .HasColumnName("prodef_grafico")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ProdefLinkrange)
                    .HasColumnName("prodef_linkrange")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ProdefPages)
                    .HasColumnName("prodef_pages")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ProdefTipo)
                    .HasColumnName("prodef_tipo")
                    .HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<Prueba>(entity =>
            {
                entity.HasKey(e => e.Indice);

                entity.ToTable("PRUEBA");

                entity.Property(e => e.Indice)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Apell1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Apell2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Diagnostico)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Diu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Doctor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Embarazo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Fnac)
                    .HasColumnName("FNac")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fsolicitud)
                    .HasColumnName("FSolicitud")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Hab)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Libre)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Orden)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Origen)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Perfil)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Peso)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Servicio)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Qt>(entity =>
            {
                entity.HasKey(e => e.QtOrden)
                    .HasName("PK__qt__23893F36");

                entity.ToTable("qt");

                entity.HasIndex(e => e.QtFlag)
                    .HasName("kqt_fl");

                entity.HasIndex(e => e.QtStatus)
                    .HasName("kqt_st");

                entity.HasIndex(e => new { e.QtOlnum, e.QtParam })
                    .HasName("kqt_ol");

                entity.HasIndex(e => new { e.QtDate, e.QtTime, e.QtParam, e.QtControl })
                    .HasName("kqt");

                entity.Property(e => e.QtOrden)
                    .HasColumnName("qt_orden")
                    .ValueGeneratedNever();

                entity.Property(e => e.QtControl)
                    .IsRequired()
                    .HasColumnName("qt_control")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.QtDate)
                    .HasColumnName("qt_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.QtFlag)
                    .HasColumnName("qt_flag")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.QtOlnum).HasColumnName("qt_olnum");

                entity.Property(e => e.QtParam).HasColumnName("qt_param");

                entity.Property(e => e.QtResultado).HasColumnName("qt_resultado");

                entity.Property(e => e.QtStatus)
                    .HasColumnName("qt_status")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.QtTime)
                    .HasColumnName("qt_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.QtOlnumNavigation)
                    .WithMany(p => p.Qt)
                    .HasForeignKey(d => d.QtOlnum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__qt__qt_olnum__2665ABE1");

                entity.HasOne(d => d.QtParamNavigation)
                    .WithMany(p => p.Qt)
                    .HasForeignKey(d => d.QtParam)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__qt__qt_param__2759D01A");
            });

            modelBuilder.Entity<SiapsEdad>(entity =>
            {
                entity.HasKey(e => e.Indice);

                entity.ToTable("siaps_edad");

                entity.Property(e => e.Indice)
                    .HasColumnName("indice")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DiasMax)
                    .HasColumnName("diasMax")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DiasMin)
                    .HasColumnName("diasMin")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NombreEdad)
                    .HasColumnName("nombreEdad")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SiapsSexo>(entity =>
            {
                entity.HasKey(e => e.SiapsSexoindice);

                entity.ToTable("siaps_sexo");

                entity.Property(e => e.SiapsSexoindice)
                    .HasColumnName("siaps_sexoindice")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SiapsSexoid)
                    .IsRequired()
                    .HasColumnName("siaps_sexoid")
                    .HasMaxLength(10);

                entity.Property(e => e.SiaspsSexonombre)
                    .HasColumnName("siasps_sexonombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SiapsSubelemento>(entity =>
            {
                entity.HasKey(e => e.Indice);

                entity.ToTable("siaps_subelemento");

                entity.Property(e => e.Indice)
                    .HasColumnName("indice")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EdadId)
                    .HasColumnName("edad_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GeneroId)
                    .HasColumnName("genero_id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IdElemento)
                    .HasColumnName("id_elemento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdSubelemento)
                    .HasColumnName("id_subelemento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParCodigo)
                    .HasColumnName("par_codigo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubelementoNombre)
                    .HasColumnName("subelemento_nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Edad)
                    .WithMany(p => p.SiapsSubelemento)
                    .HasForeignKey(d => d.EdadId)
                    .HasConstraintName("FK_siaps_subelemento_siaps_edad");
            });
        }
    }
}
