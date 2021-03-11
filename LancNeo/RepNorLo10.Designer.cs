namespace LancNeo
{
    partial class RepNorLo10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepNorLo10));
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsTipoPrueba1 = new LancNeo.dsTipoPrueba();
            this.dsBusEspMues1 = new LancNeo.dsBusEspMues();
            this.dsUnidad1 = new LancNeo.dsUnidad();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.dsConcretera1 = new LancNeo.dsConcretera();
            this.dsPlanta1 = new LancNeo.dsPlanta();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAUnidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAPrueba = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAConcretera = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAPLanta = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusEspecimen = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDARepSemNormal = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAFirmas = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.dsFirmas1 = new LancNeo.dsFirmas();
            this.dsLaboratorio1 = new LancNeo.dsLaboratorio();
            this.sqlDANorma = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand9 = new System.Data.SqlClient.SqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.Pdf = new Soluciones2000.Tools.WinLib.tbBtn();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.chbRespaldo = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsrMov = new System.Windows.Forms.TextBox();
            this.chkMUCF = new System.Windows.Forms.CheckBox();
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.chbLeyenda = new System.Windows.Forms.CheckBox();
            this.chbFormato = new System.Windows.Forms.CheckBox();
            this.chbElemento = new System.Windows.Forms.CheckBox();
            this.chbLogo = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPrueba = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMezcla = new System.Windows.Forms.ComboBox();
            this.chbImprime = new System.Windows.Forms.CheckBox();
            this.chbRevisa = new System.Windows.Forms.CheckBox();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.cmbConcretera = new System.Windows.Forms.ComboBox();
            this.cmbPlanta = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chbDuplicado = new System.Windows.Forms.CheckBox();
            this.crvRepSemNormal = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cryRepNo10Neo1 = new LancNeo.CryRepNo10Neo();
            this.cryRepNo10NeoE1 = new LancNeo.CryRepNo10NeoE();
            this.sqlDASemNormalE = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDACorreos = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.dsCorreos1 = new LancNeo.dsCorreos();
            this.sqlDADiametro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dsRepNo10Neo1 = new LancNeo.dsRepNo10Neo();
            this.dsRepNo10Neo2 = new LancNeo.dsRepNo10Neo();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusEspMues1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCorreos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepNo10Neo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepNo10Neo2)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsTipoPrueba1
            // 
            this.dsTipoPrueba1.DataSetName = "dsTipoPrueba";
            this.dsTipoPrueba1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTipoPrueba1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsBusEspMues1
            // 
            this.dsBusEspMues1.DataSetName = "dsBusEspMues";
            this.dsBusEspMues1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusEspMues1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsUnidad1
            // 
            this.dsUnidad1.DataSetName = "dsUnidad";
            this.dsUnidad1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsUnidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsConcretera1
            // 
            this.dsConcretera1.DataSetName = "dsConcretera";
            this.dsConcretera1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcretera1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsPlanta1
            // 
            this.dsPlanta1.DataSetName = "dsPlanta";
            this.dsPlanta1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsPlanta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDABusObra
            // 
            this.sqlDABusObra.SelectCommand = this.sqlCommand1;
            this.sqlDABusObra.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT Obra.Idobra, Obra.Ubicacion, Obra.RFC, Razonsocial.Facturar FROM Obra LEFT" +
    " OUTER JOIN Razonsocial ON Obra.IdCliente = Razonsocial.IdCliente AND Obra.RFC =" +
    " Razonsocial.RFC ORDER BY Obra.Idobra";
            this.sqlCommand1.Connection = this.sqlConn;
            // 
            // sqlDAUnidad
            // 
            this.sqlDAUnidad.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAUnidad.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Unidad", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdUnidad", "IdUnidad"),
                        new System.Data.Common.DataColumnMapping("Factor", "Factor"),
                        new System.Data.Common.DataColumnMapping("Undescr", "Undescr"),
                        new System.Data.Common.DataColumnMapping("MaxagrUn", "MaxagrUn"),
                        new System.Data.Common.DataColumnMapping("RevenUn", "RevenUn")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdUnidad, Factor, Undescr, MaxagrUn, RevenUn FROM Unidad";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlDAPrueba
            // 
            this.sqlDAPrueba.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAPrueba.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Tipoprueba", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdPrueba", "IdPrueba"),
                        new System.Data.Common.DataColumnMapping("Prueba", "Prueba")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT IdPrueba, Prueba FROM Tipoprueba";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            // 
            // sqlDAConcretera
            // 
            this.sqlDAConcretera.SelectCommand = this.sqlSelectCommand5;
            this.sqlDAConcretera.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Concretera", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("Concretera", "Concretera"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion")})});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "SELECT IdConcretera, Concretera, Direccion FROM Concretera";
            this.sqlSelectCommand5.Connection = this.sqlConn;
            // 
            // sqlDAPLanta
            // 
            this.sqlDAPLanta.SelectCommand = this.sqlSelectCommand6;
            this.sqlDAPLanta.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Planta", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("Planta", "Planta")})});
            // 
            // sqlSelectCommand6
            // 
            this.sqlSelectCommand6.CommandText = "SELECT IdConcretera, IdPlanta, Planta FROM Planta WHERE (IdConcretera LIKE @IdCon" +
    "cretera)";
            this.sqlSelectCommand6.Connection = this.sqlConn;
            this.sqlSelectCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, "IdConcretera")});
            // 
            // sqlDABusEspecimen
            // 
            this.sqlDABusEspecimen.SelectCommand = this.sqlSelectCommand3;
            this.sqlDABusEspecimen.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Especimen", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Prueba", "Prueba"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("tipo", "tipo")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = resources.GetString("sqlSelectCommand3.CommandText");
            this.sqlSelectCommand3.Connection = this.sqlConn;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // sqlDARepSemNormal
            // 
            this.sqlDARepSemNormal.SelectCommand = this.sqlSelectCommand4;
            this.sqlDARepSemNormal.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "RepSemLo10", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Anos", "Anos"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Hoja", "Hoja"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("PREMEZ.", "PREMEZ."),
                        new System.Data.Common.DataColumnMapping("PTA", "PTA"),
                        new System.Data.Common.DataColumnMapping("Res.", "Res."),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Tma", "Tma"),
                        new System.Data.Common.DataColumnMapping("Rev.", "Rev."),
                        new System.Data.Common.DataColumnMapping("G", "G"),
                        new System.Data.Common.DataColumnMapping("T.A.", "T.A."),
                        new System.Data.Common.DataColumnMapping("m3", "m3"),
                        new System.Data.Common.DataColumnMapping("Olla", "Olla"),
                        new System.Data.Common.DataColumnMapping("Rem", "Rem"),
                        new System.Data.Common.DataColumnMapping("Hora", "Hora"),
                        new System.Data.Common.DataColumnMapping("Obt", "Obt"),
                        new System.Data.Common.DataColumnMapping("ELEMENTO", "ELEMENTO"),
                        new System.Data.Common.DataColumnMapping("EJES", "EJES"),
                        new System.Data.Common.DataColumnMapping("Niv.", "Niv."),
                        new System.Data.Common.DataColumnMapping("Edif", "Edif"),
                        new System.Data.Common.DataColumnMapping("Observa", "Observa"),
                        new System.Data.Common.DataColumnMapping("Observa1", "Observa1"),
                        new System.Data.Common.DataColumnMapping("Nota", "Nota"),
                        new System.Data.Common.DataColumnMapping("Nota1", "Nota1"),
                        new System.Data.Common.DataColumnMapping("Origen", "Origen"),
                        new System.Data.Common.DataColumnMapping("Resbajo", "Resbajo"),
                        new System.Data.Common.DataColumnMapping("d1", "d1"),
                        new System.Data.Common.DataColumnMapping("v1", "v1"),
                        new System.Data.Common.DataColumnMapping("N1", "N1"),
                        new System.Data.Common.DataColumnMapping("Dia1", "Dia1"),
                        new System.Data.Common.DataColumnMapping("d11", "d11"),
                        new System.Data.Common.DataColumnMapping("v11", "v11"),
                        new System.Data.Common.DataColumnMapping("N11", "N11"),
                        new System.Data.Common.DataColumnMapping("Dia11", "Dia11"),
                        new System.Data.Common.DataColumnMapping("d2", "d2"),
                        new System.Data.Common.DataColumnMapping("v2", "v2"),
                        new System.Data.Common.DataColumnMapping("N2", "N2"),
                        new System.Data.Common.DataColumnMapping("Dia31", "Dia31"),
                        new System.Data.Common.DataColumnMapping("d3", "d3"),
                        new System.Data.Common.DataColumnMapping("v3", "v3"),
                        new System.Data.Common.DataColumnMapping("N3", "N3"),
                        new System.Data.Common.DataColumnMapping("Dia32", "Dia32"),
                        new System.Data.Common.DataColumnMapping("d4", "d4"),
                        new System.Data.Common.DataColumnMapping("v4", "v4"),
                        new System.Data.Common.DataColumnMapping("N4", "N4"),
                        new System.Data.Common.DataColumnMapping("Dia71", "Dia71"),
                        new System.Data.Common.DataColumnMapping("d5", "d5"),
                        new System.Data.Common.DataColumnMapping("v5", "v5"),
                        new System.Data.Common.DataColumnMapping("N5", "N5"),
                        new System.Data.Common.DataColumnMapping("Dia72", "Dia72"),
                        new System.Data.Common.DataColumnMapping("d6", "d6"),
                        new System.Data.Common.DataColumnMapping("v6", "v6"),
                        new System.Data.Common.DataColumnMapping("N6", "N6"),
                        new System.Data.Common.DataColumnMapping("Dia141", "Dia141"),
                        new System.Data.Common.DataColumnMapping("d7", "d7"),
                        new System.Data.Common.DataColumnMapping("v7", "v7"),
                        new System.Data.Common.DataColumnMapping("N7", "N7"),
                        new System.Data.Common.DataColumnMapping("Dia142", "Dia142"),
                        new System.Data.Common.DataColumnMapping("d8", "d8"),
                        new System.Data.Common.DataColumnMapping("v8", "v8"),
                        new System.Data.Common.DataColumnMapping("N8", "N8"),
                        new System.Data.Common.DataColumnMapping("Dia281", "Dia281"),
                        new System.Data.Common.DataColumnMapping("d9", "d9"),
                        new System.Data.Common.DataColumnMapping("v9", "v9"),
                        new System.Data.Common.DataColumnMapping("N9", "N9"),
                        new System.Data.Common.DataColumnMapping("Dia282", "Dia282"),
                        new System.Data.Common.DataColumnMapping("d10", "d10"),
                        new System.Data.Common.DataColumnMapping("v10", "v10"),
                        new System.Data.Common.DataColumnMapping("N10", "N10"),
                        new System.Data.Common.DataColumnMapping("Dia631", "Dia631"),
                        new System.Data.Common.DataColumnMapping("Lab", "Lab"),
                        new System.Data.Common.DataColumnMapping("Razonsocial", "Razonsocial"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("Laboratorio", "Laboratorio"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("UMaxagr", "UMaxagr"),
                        new System.Data.Common.DataColumnMapping("UReven", "UReven"),
                        new System.Data.Common.DataColumnMapping("Cuantos", "Cuantos"),
                        new System.Data.Common.DataColumnMapping("MUCF", "MUCF"),
                        new System.Data.Common.DataColumnMapping("EJES1", "EJES1"),
                        new System.Data.Common.DataColumnMapping("Edif1", "Edif1"),
                        new System.Data.Common.DataColumnMapping("Nivel1", "Nivel1"),
                        new System.Data.Common.DataColumnMapping("ELEMENTO1", "ELEMENTO1")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "dbo.RepSemLo10";
            this.sqlSelectCommand4.CommandTimeout = 120;
            this.sqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@IdPlanta", System.Data.SqlDbType.NVarChar, 4),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@IdReporte", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Mezcla", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Nulos", System.Data.SqlDbType.Bit, 1),
            new System.Data.SqlClient.SqlParameter("@Secuencia", System.Data.SqlDbType.Bit, 1),
            new System.Data.SqlClient.SqlParameter("@FEspecimen", System.Data.SqlDbType.Bit, 1)});
            // 
            // sqlDAFirmas
            // 
            this.sqlDAFirmas.SelectCommand = this.sqlSelectCommand7;
            this.sqlDAFirmas.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Firmas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdFirma", "IdFirma"),
                        new System.Data.Common.DataColumnMapping("Nombre", "Nombre"),
                        new System.Data.Common.DataColumnMapping("Cargo", "Cargo"),
                        new System.Data.Common.DataColumnMapping("Imprime", "Imprime")})});
            // 
            // sqlSelectCommand7
            // 
            this.sqlSelectCommand7.CommandText = "SELECT     IdFirma, Nombre, Cargo, Imprime\r\nFROM         Firmas\r\nWHERE     (Impri" +
    "me = 1) AND (Concreto < 6)\r\nORDER BY Concreto";
            this.sqlSelectCommand7.Connection = this.sqlConn;
            // 
            // dsFirmas1
            // 
            this.dsFirmas1.DataSetName = "dsFirmas";
            this.dsFirmas1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsFirmas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsLaboratorio1
            // 
            this.dsLaboratorio1.DataSetName = "dsLaboratorio";
            this.dsLaboratorio1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDANorma
            // 
            this.sqlDANorma.SelectCommand = this.sqlSelectCommand9;
            this.sqlDANorma.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Normas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdNorma", "IdNorma"),
                        new System.Data.Common.DataColumnMapping("Informe", "Informe"),
                        new System.Data.Common.DataColumnMapping("Normas", "Normas"),
                        new System.Data.Common.DataColumnMapping("Titulo", "Titulo"),
                        new System.Data.Common.DataColumnMapping("IdInforme", "IdInforme"),
                        new System.Data.Common.DataColumnMapping("Norma1", "Norma1"),
                        new System.Data.Common.DataColumnMapping("Norma2", "Norma2"),
                        new System.Data.Common.DataColumnMapping("Norma3", "Norma3"),
                        new System.Data.Common.DataColumnMapping("Norma4", "Norma4"),
                        new System.Data.Common.DataColumnMapping("Norma5", "Norma5")})});
            // 
            // sqlSelectCommand9
            // 
            this.sqlSelectCommand9.CommandText = "SELECT IdNorma, Informe, Normas, Titulo, IdInforme, Norma1, Norma2, Norma3, Norma" +
    "4, Norma5 FROM Normas WHERE (IdNorma = @IdNorma)";
            this.sqlSelectCommand9.Connection = this.sqlConn;
            this.sqlSelectCommand9.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdNorma", System.Data.SqlDbType.SmallInt, 2, "IdNorma")});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.Pdf);
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.chbRespaldo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtUsrMov);
            this.panel1.Controls.Add(this.chkMUCF);
            this.panel1.Controls.Add(this.chbLab);
            this.panel1.Controls.Add(this.chbLeyenda);
            this.panel1.Controls.Add(this.chbFormato);
            this.panel1.Controls.Add(this.chbElemento);
            this.panel1.Controls.Add(this.chbLogo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbPrueba);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbMezcla);
            this.panel1.Controls.Add(this.chbImprime);
            this.panel1.Controls.Add(this.chbRevisa);
            this.panel1.Controls.Add(this.cmbUnidad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpIni);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbIdObra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.cmbConcretera);
            this.panel1.Controls.Add(this.cmbPlanta);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.chbDuplicado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 107);
            this.panel1.TabIndex = 10;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsBusEspMues1.Especimen;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(200, 35);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.buscaBtn1.Visible = false;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // Pdf
            // 
            this.Pdf.BackColor = System.Drawing.Color.Transparent;
            this.Pdf.Icon = ((System.Drawing.Icon)(resources.GetObject("Pdf.Icon")));
            this.Pdf.Location = new System.Drawing.Point(843, 7);
            this.Pdf.Name = "Pdf";
            this.Pdf.Size = new System.Drawing.Size(64, 65);
            this.Pdf.TabIndex = 46;
            this.Pdf.Visible = false;
            this.Pdf.Click += new System.EventHandler(this.Pdf_Click);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(773, 3);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 65);
            this.btnVistaPrevia.TabIndex = 11;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // chbRespaldo
            // 
            this.chbRespaldo.ForeColor = System.Drawing.Color.White;
            this.chbRespaldo.Location = new System.Drawing.Point(678, 80);
            this.chbRespaldo.Name = "chbRespaldo";
            this.chbRespaldo.Size = new System.Drawing.Size(90, 24);
            this.chbRespaldo.TabIndex = 103;
            this.chbRespaldo.Text = "Respaldo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Highlight;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(498, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 102;
            this.label10.Text = "Usuario:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsrMov
            // 
            this.txtUsrMov.Location = new System.Drawing.Point(550, 78);
            this.txtUsrMov.Name = "txtUsrMov";
            this.txtUsrMov.Size = new System.Drawing.Size(56, 20);
            this.txtUsrMov.TabIndex = 101;
            // 
            // chkMUCF
            // 
            this.chkMUCF.Location = new System.Drawing.Point(389, 75);
            this.chkMUCF.Name = "chkMUCF";
            this.chkMUCF.Size = new System.Drawing.Size(116, 24);
            this.chkMUCF.TabIndex = 45;
            this.chkMUCF.Text = "MUCF";
            // 
            // chbLab
            // 
            this.chbLab.Checked = true;
            this.chbLab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab.Location = new System.Drawing.Point(267, 76);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(115, 25);
            this.chbLab.TabIndex = 44;
            this.chbLab.Text = "Incluye laboratorio";
            this.chbLab.Visible = false;
            // 
            // chbLeyenda
            // 
            this.chbLeyenda.Location = new System.Drawing.Point(390, 52);
            this.chbLeyenda.Name = "chbLeyenda";
            this.chbLeyenda.Size = new System.Drawing.Size(116, 24);
            this.chbLeyenda.TabIndex = 39;
            this.chbLeyenda.Text = "Formato leyenda";
            // 
            // chbFormato
            // 
            this.chbFormato.Checked = true;
            this.chbFormato.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFormato.Location = new System.Drawing.Point(267, 52);
            this.chbFormato.Name = "chbFormato";
            this.chbFormato.Size = new System.Drawing.Size(115, 24);
            this.chbFormato.TabIndex = 38;
            this.chbFormato.Text = "Formato con logo";
            this.chbFormato.Visible = false;
            // 
            // chbElemento
            // 
            this.chbElemento.Location = new System.Drawing.Point(267, 28);
            this.chbElemento.Name = "chbElemento";
            this.chbElemento.Size = new System.Drawing.Size(104, 24);
            this.chbElemento.TabIndex = 37;
            this.chbElemento.Text = "Por elemento";
            // 
            // chbLogo
            // 
            this.chbLogo.Location = new System.Drawing.Point(8, 28);
            this.chbLogo.Name = "chbLogo";
            this.chbLogo.Size = new System.Drawing.Size(184, 24);
            this.chbLogo.TabIndex = 25;
            this.chbLogo.Text = "Incluye imagen de acreditación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(653, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Planta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(633, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Concretera:";
            // 
            // cmbPrueba
            // 
            this.cmbPrueba.DataSource = this.dsTipoPrueba1.Tipoprueba;
            this.cmbPrueba.DisplayMember = "Prueba";
            this.cmbPrueba.Location = new System.Drawing.Point(437, 24);
            this.cmbPrueba.Name = "cmbPrueba";
            this.cmbPrueba.Size = new System.Drawing.Size(68, 21);
            this.cmbPrueba.TabIndex = 11;
            this.cmbPrueba.ValueMember = "IdPrueba";
            this.cmbPrueba.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Prueba:";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mezcla:";
            // 
            // cmbMezcla
            // 
            this.cmbMezcla.Location = new System.Drawing.Point(700, 52);
            this.cmbMezcla.Name = "cmbMezcla";
            this.cmbMezcla.Size = new System.Drawing.Size(68, 21);
            this.cmbMezcla.TabIndex = 9;
            this.cmbMezcla.Text = "cmbMezcla";
            // 
            // chbImprime
            // 
            this.chbImprime.Checked = true;
            this.chbImprime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbImprime.Location = new System.Drawing.Point(8, 52);
            this.chbImprime.Name = "chbImprime";
            this.chbImprime.Size = new System.Drawing.Size(180, 24);
            this.chbImprime.TabIndex = 8;
            this.chbImprime.Text = "No imprime muestras sin datos";
            // 
            // chbRevisa
            // 
            this.chbRevisa.Checked = true;
            this.chbRevisa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbRevisa.Location = new System.Drawing.Point(267, 3);
            this.chbRevisa.Name = "chbRevisa";
            this.chbRevisa.Size = new System.Drawing.Size(111, 24);
            this.chbRevisa.TabIndex = 7;
            this.chbRevisa.Text = "Revisa secuencia";
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DataSource = this.dsUnidad1.Unidad;
            this.cmbUnidad.DisplayMember = "Undescr";
            this.cmbUnidad.Location = new System.Drawing.Point(550, 52);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(84, 21);
            this.cmbUnidad.TabIndex = 10;
            this.cmbUnidad.ValueMember = "IdUnidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unidad:";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(550, 28);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(84, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Final:";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(550, 3);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(84, 20);
            this.dtpIni.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1.Obra;
            this.cmbIdObra.DisplayMember = "IdObra";
            this.cmbIdObra.Location = new System.Drawing.Point(137, 80);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(56, 21);
            this.cmbIdObra.TabIndex = 1;
            this.cmbIdObra.ValueMember = "IdObra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte semanal con todos";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(213, 56);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(390, 3);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(95, 13);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fechas de periodo";
            // 
            // cmbConcretera
            // 
            this.cmbConcretera.DataSource = this.dsConcretera1.Concretera;
            this.cmbConcretera.DisplayMember = "IdConcretera";
            this.cmbConcretera.Location = new System.Drawing.Point(700, 3);
            this.cmbConcretera.Name = "cmbConcretera";
            this.cmbConcretera.Size = new System.Drawing.Size(68, 21);
            this.cmbConcretera.TabIndex = 5;
            this.cmbConcretera.ValueMember = "IdConcretera";
            this.cmbConcretera.SelectedIndexChanged += new System.EventHandler(this.cmbConcretera_SelectedIndexChanged);
            // 
            // cmbPlanta
            // 
            this.cmbPlanta.DataSource = this.dsPlanta1.Planta;
            this.cmbPlanta.DisplayMember = "Planta";
            this.cmbPlanta.Enabled = false;
            this.cmbPlanta.Location = new System.Drawing.Point(700, 28);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(68, 21);
            this.cmbPlanta.TabIndex = 6;
            this.cmbPlanta.ValueMember = "IdPlanta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(592, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // chbDuplicado
            // 
            this.chbDuplicado.Location = new System.Drawing.Point(3, 80);
            this.chbDuplicado.Name = "chbDuplicado";
            this.chbDuplicado.Size = new System.Drawing.Size(89, 24);
            this.chbDuplicado.TabIndex = 30;
            this.chbDuplicado.Text = "¿Duplicado?";
            // 
            // crvRepSemNormal
            // 
            this.crvRepSemNormal.ActiveViewIndex = -1;
            this.crvRepSemNormal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRepSemNormal.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRepSemNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRepSemNormal.EnableRefresh = false;
            this.crvRepSemNormal.Location = new System.Drawing.Point(0, 107);
            this.crvRepSemNormal.Name = "crvRepSemNormal";
            this.crvRepSemNormal.ShowCloseButton = false;
            this.crvRepSemNormal.ShowGroupTreeButton = false;
            this.crvRepSemNormal.ShowLogo = false;
            this.crvRepSemNormal.ShowRefreshButton = false;
            this.crvRepSemNormal.Size = new System.Drawing.Size(1028, 641);
            this.crvRepSemNormal.TabIndex = 11;
            this.crvRepSemNormal.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvRepSemNormal.ToolPanelWidth = 167;
            // 
            // cryRepNo10NeoE1
            // 
            this.cryRepNo10NeoE1.InitReport += new System.EventHandler(this.cryRepNo10NeoE1_InitReport);
            // 
            // sqlDASemNormalE
            // 
            this.sqlDASemNormalE.SelectCommand = this.sqlCommand2;
            this.sqlDASemNormalE.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "RepSemNormalV", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Anos", "Anos"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Hoja", "Hoja"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("PREMEZ.", "PREMEZ."),
                        new System.Data.Common.DataColumnMapping("PTA", "PTA"),
                        new System.Data.Common.DataColumnMapping("Res.", "Res."),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Tma", "Tma"),
                        new System.Data.Common.DataColumnMapping("Rev.", "Rev."),
                        new System.Data.Common.DataColumnMapping("G", "G"),
                        new System.Data.Common.DataColumnMapping("T.A.", "T.A."),
                        new System.Data.Common.DataColumnMapping("m3", "m3"),
                        new System.Data.Common.DataColumnMapping("Olla", "Olla"),
                        new System.Data.Common.DataColumnMapping("Rem", "Rem"),
                        new System.Data.Common.DataColumnMapping("Hora", "Hora"),
                        new System.Data.Common.DataColumnMapping("Obt", "Obt"),
                        new System.Data.Common.DataColumnMapping("ELEMENTO", "ELEMENTO"),
                        new System.Data.Common.DataColumnMapping("EJES", "EJES"),
                        new System.Data.Common.DataColumnMapping("Niv.", "Niv."),
                        new System.Data.Common.DataColumnMapping("Edif", "Edif"),
                        new System.Data.Common.DataColumnMapping("Observa", "Observa"),
                        new System.Data.Common.DataColumnMapping("Observa1", "Observa1"),
                        new System.Data.Common.DataColumnMapping("Nota", "Nota"),
                        new System.Data.Common.DataColumnMapping("Nota1", "Nota1"),
                        new System.Data.Common.DataColumnMapping("Origen", "Origen"),
                        new System.Data.Common.DataColumnMapping("Resbajo", "Resbajo"),
                        new System.Data.Common.DataColumnMapping("d1", "d1"),
                        new System.Data.Common.DataColumnMapping("v1", "v1"),
                        new System.Data.Common.DataColumnMapping("N1", "N1"),
                        new System.Data.Common.DataColumnMapping("3 días", "3 días"),
                        new System.Data.Common.DataColumnMapping("d2", "d2"),
                        new System.Data.Common.DataColumnMapping("v2", "v2"),
                        new System.Data.Common.DataColumnMapping("N2", "N2"),
                        new System.Data.Common.DataColumnMapping("7 días", "7 días"),
                        new System.Data.Common.DataColumnMapping("d3", "d3"),
                        new System.Data.Common.DataColumnMapping("v3", "v3"),
                        new System.Data.Common.DataColumnMapping("N3", "N3"),
                        new System.Data.Common.DataColumnMapping("ee1", "ee1"),
                        new System.Data.Common.DataColumnMapping("d4", "d4"),
                        new System.Data.Common.DataColumnMapping("v4", "v4"),
                        new System.Data.Common.DataColumnMapping("N4", "N4"),
                        new System.Data.Common.DataColumnMapping("ee2", "ee2"),
                        new System.Data.Common.DataColumnMapping("d5", "d5"),
                        new System.Data.Common.DataColumnMapping("v5", "v5"),
                        new System.Data.Common.DataColumnMapping("N5", "N5"),
                        new System.Data.Common.DataColumnMapping("eV1", "eV1"),
                        new System.Data.Common.DataColumnMapping("d6", "d6"),
                        new System.Data.Common.DataColumnMapping("v6", "v6"),
                        new System.Data.Common.DataColumnMapping("N6", "N6"),
                        new System.Data.Common.DataColumnMapping("eV2", "eV2"),
                        new System.Data.Common.DataColumnMapping("Lab", "Lab"),
                        new System.Data.Common.DataColumnMapping("Razonsocial", "Razonsocial"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("Laboratorio", "Laboratorio"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("UMaxagr", "UMaxagr"),
                        new System.Data.Common.DataColumnMapping("UReven", "UReven"),
                        new System.Data.Common.DataColumnMapping("Cuantos", "Cuantos")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "[RepSemLo10E]";
            this.sqlCommand2.CommandTimeout = 180;
            this.sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand2.Connection = this.sqlConn;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@IdPlanta", System.Data.SqlDbType.NVarChar, 4),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@IdReporte", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Mezcla", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Nulos", System.Data.SqlDbType.Bit, 1),
            new System.Data.SqlClient.SqlParameter("@Secuencia", System.Data.SqlDbType.Bit, 1)});
            // 
            // sqlDACorreos
            // 
            this.sqlDACorreos.SelectCommand = this.sqlCommand3;
            this.sqlDACorreos.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Correo1", "Correo1"),
                        new System.Data.Common.DataColumnMapping("Correo2", "Correo2"),
                        new System.Data.Common.DataColumnMapping("Correo3", "Correo3"),
                        new System.Data.Common.DataColumnMapping("Correo4", "Correo4"),
                        new System.Data.Common.DataColumnMapping("Correo5", "Correo5")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "SELECT     Idobra, Correo1, Correo2, Correo3, Correo4, Correo5\r\nFROM         Obra" +
    "\r\nWHERE     (Idobra = @IdObra)\r\nORDER BY Idobra";
            this.sqlCommand3.Connection = this.sqlConn;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "Idobra")});
            // 
            // dsCorreos1
            // 
            this.dsCorreos1.DataSetName = "dsCorreos";
            this.dsCorreos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDADiametro
            // 
            this.sqlDADiametro.SelectCommand = this.sqlCommand4;
            this.sqlDADiametro.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Unidad", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdUnidad", "IdUnidad"),
                        new System.Data.Common.DataColumnMapping("Factor", "Factor"),
                        new System.Data.Common.DataColumnMapping("Undescr", "Undescr"),
                        new System.Data.Common.DataColumnMapping("MaxagrUn", "MaxagrUn"),
                        new System.Data.Common.DataColumnMapping("RevenUn", "RevenUn")})});
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "SELECT     IdDiam, Diametro, Figura\r\nFROM         Diametro\r\nWHERE     (IdDiam <> " +
    "1)";
            this.sqlCommand4.Connection = this.sqlConn;
            // 
            // dsRepNo10Neo1
            // 
            this.dsRepNo10Neo1.DataSetName = "dsRepNo10Neo";
            this.dsRepNo10Neo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsRepNo10Neo2
            // 
            this.dsRepNo10Neo2.DataSetName = "dsRepNo10Neo";
            this.dsRepNo10Neo2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RepNorLo10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 748);
            this.Controls.Add(this.crvRepSemNormal);
            this.Controls.Add(this.panel1);
            this.Name = "RepNorLo10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RepNorLo10";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RepNorLo10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusEspMues1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCorreos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepNo10Neo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepNo10Neo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConn;
        private dsTipoPrueba dsTipoPrueba1;
        private dsBusEspMues dsBusEspMues1;
        private dsUnidad dsUnidad1;
        private dsBusObra dsBusObra1;
        private dsConcretera dsConcretera1;
        private dsPlanta dsPlanta1;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAUnidad;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAPrueba;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDAConcretera;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private System.Data.SqlClient.SqlDataAdapter sqlDAPLanta;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand6;
        private System.Data.SqlClient.SqlDataAdapter sqlDABusEspecimen;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlDataAdapter sqlDARepSemNormal;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlDataAdapter sqlDAFirmas;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
        private dsFirmas dsFirmas1;
        private dsLaboratorio dsLaboratorio1;
        public System.Data.SqlClient.SqlDataAdapter sqlDANorma;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand9;
        private System.Windows.Forms.Panel panel1;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
        private System.Windows.Forms.CheckBox chbLab;
        private System.Windows.Forms.CheckBox chbLeyenda;
        private System.Windows.Forms.CheckBox chbFormato;
        private System.Windows.Forms.CheckBox chbElemento;
        private System.Windows.Forms.CheckBox chbLogo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPrueba;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMezcla;
        private System.Windows.Forms.CheckBox chbImprime;
        private System.Windows.Forms.CheckBox chbRevisa;
        private System.Windows.Forms.ComboBox cmbUnidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIdObra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdobra;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.ComboBox cmbConcretera;
        private System.Windows.Forms.ComboBox cmbPlanta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chbDuplicado;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepSemNormal;
        private CryRepNo10Neo cryRepNo10Neo1;
        private CryRepNo10NeoE cryRepNo10NeoE1;
        private System.Data.SqlClient.SqlDataAdapter sqlDASemNormalE;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.CheckBox chkMUCF;
        protected Soluciones2000.Tools.WinLib.tbBtn Pdf;
        private System.Windows.Forms.TextBox txtUsrMov;
        private System.Windows.Forms.Label label10;
        public System.Data.SqlClient.SqlDataAdapter sqlDACorreos;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private dsCorreos dsCorreos1;
        private System.Data.SqlClient.SqlDataAdapter sqlDADiametro;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Windows.Forms.CheckBox chbRespaldo;
        private dsRepNo10Neo dsRepNo10Neo1;
        private dsRepNo10Neo dsRepNo10Neo2;
    }
}