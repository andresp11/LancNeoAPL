using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using ZedGraph;
using System.IO;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de InfMateriales.
	/// </summary>
	public class InfMateriales : System.Windows.Forms.Form
	{
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsInfMateriales dsInfMateriales1;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private LancNeo.dsBusObra dsBusObra1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAFirmas;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
		private LancNeo.dsFirmas dsFirmas1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		public System.Data.SqlClient.SqlDataAdapter sqlDAInfMaterialesMal;
		private System.Data.SqlClient.SqlDataAdapter sqlDAMaterialesInf;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private LancNeo.dsMaterialesInf dsMaterialesInf1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtFolioIni;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.TextBox txtFolioFin;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIdobra;
		private System.Windows.Forms.PictureBox pictureBox1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private LancNeo.CryRepMateriales cryRepMateriales1;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInfMateriales;
		public System.Data.SqlClient.SqlDataAdapter sqlDAInfMateriales;
		private System.Data.SqlClient.SqlDataAdapter sqlDAUnidad;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
		private LancNeo.dsUnidad dsUnidad1;
		private System.Windows.Forms.ComboBox cmbUnidad;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chbDuplicado;
		private System.Windows.Forms.CheckBox chbLeyenda;
		private System.Data.SqlClient.SqlDataAdapter sqlDANorma;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private System.Windows.Forms.CheckBox chbLab;
        private CheckBox chbLab1;
        private CheckBox chbTodos;
        private CheckBox chbRespaldo;
		private DBGraphics memGraphics;

		public InfMateriales()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			memGraphics = new  DBGraphics();
			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfMateriales));
            this.sqlDAInfMateriales = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsInfMateriales1 = new LancNeo.dsInfMateriales();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.sqlDAFirmas = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.dsFirmas1 = new LancNeo.dsFirmas();
            this.sqlDAInfMaterialesMal = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAMaterialesInf = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.dsMaterialesInf1 = new LancNeo.dsMaterialesInf();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.chbRespaldo = new System.Windows.Forms.CheckBox();
            this.chbTodos = new System.Windows.Forms.CheckBox();
            this.chbLab1 = new System.Windows.Forms.CheckBox();
            this.chbLab = new System.Windows.Forms.CheckBox();
            this.chbLeyenda = new System.Windows.Forms.CheckBox();
            this.chbDuplicado = new System.Windows.Forms.CheckBox();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.dsUnidad1 = new LancNeo.dsUnidad();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFolioIni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFolioFin = new System.Windows.Forms.TextBox();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cryRepMateriales1 = new LancNeo.CryRepMateriales();
            this.crvInfMateriales = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDAUnidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDANorma = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfMateriales1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterialesInf1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDAInfMateriales
            // 
            this.sqlDAInfMateriales.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAInfMateriales.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "MaterialesRep", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("FMuestreo", "FMuestreo"),
                        new System.Data.Common.DataColumnMapping("FEnsaye", "FEnsaye"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("Material", "Material"),
                        new System.Data.Common.DataColumnMapping("Lab", "Lab"),
                        new System.Data.Common.DataColumnMapping("Anos", "Anos"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Hoja", "Hoja"),
                        new System.Data.Common.DataColumnMapping("Observac", "Observac"),
                        new System.Data.Common.DataColumnMapping("Muestreadas", "Muestreadas"),
                        new System.Data.Common.DataColumnMapping("Procedencia", "Procedencia"),
                        new System.Data.Common.DataColumnMapping("Usarse", "Usarse"),
                        new System.Data.Common.DataColumnMapping("MasaSuelta", "MasaSuelta"),
                        new System.Data.Common.DataColumnMapping("MasaMaxima", "MasaMaxima"),
                        new System.Data.Common.DataColumnMapping("Agua", "Agua"),
                        new System.Data.Common.DataColumnMapping("Expansion", "Expansion"),
                        new System.Data.Common.DataColumnMapping("Soporte", "Soporte"),
                        new System.Data.Common.DataColumnMapping("Liquido", "Liquido"),
                        new System.Data.Common.DataColumnMapping("Plastico", "Plastico"),
                        new System.Data.Common.DataColumnMapping("Indice", "Indice"),
                        new System.Data.Common.DataColumnMapping("Lineal", "Lineal"),
                        new System.Data.Common.DataColumnMapping("Rocas", "Rocas"),
                        new System.Data.Common.DataColumnMapping("Gruesas", "Gruesas"),
                        new System.Data.Common.DataColumnMapping("Mediana", "Mediana"),
                        new System.Data.Common.DataColumnMapping("Fina", "Fina"),
                        new System.Data.Common.DataColumnMapping("Limas", "Limas"),
                        new System.Data.Common.DataColumnMapping("Arcillas", "Arcillas"),
                        new System.Data.Common.DataColumnMapping("Valor", "Valor"),
                        new System.Data.Common.DataColumnMapping("Arena", "Arena"),
                        new System.Data.Common.DataColumnMapping("Sucs", "Sucs"),
                        new System.Data.Common.DataColumnMapping("MasaEspecifica", "MasaEspecifica"),
                        new System.Data.Common.DataColumnMapping("Absorcion", "Absorcion"),
                        new System.Data.Common.DataColumnMapping("Razonsocial", "Razonsocial"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("Zona", "Zona")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "[MaterialesRep]";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FolioIni", System.Data.SqlDbType.VarChar, 10),
            new System.Data.SqlClient.SqlParameter("@FOlioFin", System.Data.SqlDbType.VarChar, 10),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsInfMateriales1
            // 
            this.dsInfMateriales1.DataSetName = "dsInfMateriales";
            this.dsInfMateriales1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsInfMateriales1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConn;
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
    "me = 1) AND (Materiales < 6)\r\nORDER BY Materiales";
            this.sqlSelectCommand7.Connection = this.sqlConn;
            // 
            // dsFirmas1
            // 
            this.dsFirmas1.DataSetName = "dsFirmas";
            this.dsFirmas1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsFirmas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAInfMaterialesMal
            // 
            this.sqlDAInfMaterialesMal.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAInfMaterialesMal.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "MaterialesMal", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("Renglon", "Renglon"),
                        new System.Data.Common.DataColumnMapping("Grava", "Grava"),
                        new System.Data.Common.DataColumnMapping("GravaSI", "GravaSI"),
                        new System.Data.Common.DataColumnMapping("Linea1", "Linea1"),
                        new System.Data.Common.DataColumnMapping("Linea2", "Linea2"),
                        new System.Data.Common.DataColumnMapping("Linea3", "Linea3"),
                        new System.Data.Common.DataColumnMapping("Linea4", "Linea4"),
                        new System.Data.Common.DataColumnMapping("Quepasa", "Quepasa")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdFolioFin", System.Data.SqlDbType.Char, 10, "Folio"),
            new System.Data.SqlClient.SqlParameter("@IdFolioini", System.Data.SqlDbType.Char, 10, "Folio")});
            // 
            // sqlDAMaterialesInf
            // 
            this.sqlDAMaterialesInf.SelectCommand = this.sqlSelectCommand3;
            this.sqlDAMaterialesInf.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Materiales", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Material", "Material"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("Fmuestreo", "Fmuestreo"),
                        new System.Data.Common.DataColumnMapping("Fensaye", "Fensaye"),
                        new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Muestreadas", "Muestreadas"),
                        new System.Data.Common.DataColumnMapping("Procedencia", "Procedencia"),
                        new System.Data.Common.DataColumnMapping("Usarse", "Usarse")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = resources.GetString("sqlSelectCommand3.CommandText");
            this.sqlSelectCommand3.Connection = this.sqlConn;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // dsMaterialesInf1
            // 
            this.dsMaterialesInf1.DataSetName = "dsMaterialesInf";
            this.dsMaterialesInf1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsMaterialesInf1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.chbRespaldo);
            this.panel1.Controls.Add(this.chbTodos);
            this.panel1.Controls.Add(this.chbLab1);
            this.panel1.Controls.Add(this.chbLab);
            this.panel1.Controls.Add(this.chbLeyenda);
            this.panel1.Controls.Add(this.chbDuplicado);
            this.panel1.Controls.Add(this.cmbUnidad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFolioIni);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFolioFin);
            this.panel1.Controls.Add(this.cmbIdObra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 120);
            this.panel1.TabIndex = 13;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 650;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsMaterialesInf1.Materiales;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(547, 2);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 2;
            this.buscaBtn1.Visible = false;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(770, 3);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 65);
            this.btnVistaPrevia.TabIndex = 11;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Load += new System.EventHandler(this.btnVistaPrevia_Load);
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // chbRespaldo
            // 
            this.chbRespaldo.ForeColor = System.Drawing.Color.White;
            this.chbRespaldo.Location = new System.Drawing.Point(430, 91);
            this.chbRespaldo.Name = "chbRespaldo";
            this.chbRespaldo.Size = new System.Drawing.Size(82, 24);
            this.chbRespaldo.TabIndex = 47;
            this.chbRespaldo.Text = "Respaldo";
            // 
            // chbTodos
            // 
            this.chbTodos.ForeColor = System.Drawing.Color.White;
            this.chbTodos.Location = new System.Drawing.Point(532, 91);
            this.chbTodos.Name = "chbTodos";
            this.chbTodos.Size = new System.Drawing.Size(132, 24);
            this.chbTodos.TabIndex = 43;
            this.chbTodos.Text = "Todos los informes";
            // 
            // chbLab1
            // 
            this.chbLab1.Checked = true;
            this.chbLab1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab1.ForeColor = System.Drawing.Color.White;
            this.chbLab1.Location = new System.Drawing.Point(670, 91);
            this.chbLab1.Name = "chbLab1";
            this.chbLab1.Size = new System.Drawing.Size(133, 24);
            this.chbLab1.TabIndex = 42;
            this.chbLab1.Text = "Incluye laboratorista";
            // 
            // chbLab
            // 
            this.chbLab.Checked = true;
            this.chbLab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLab.ForeColor = System.Drawing.Color.White;
            this.chbLab.Location = new System.Drawing.Point(670, 69);
            this.chbLab.Name = "chbLab";
            this.chbLab.Size = new System.Drawing.Size(116, 25);
            this.chbLab.TabIndex = 37;
            this.chbLab.Text = "Incluye laboratorio";
            // 
            // chbLeyenda
            // 
            this.chbLeyenda.ForeColor = System.Drawing.Color.White;
            this.chbLeyenda.Location = new System.Drawing.Point(532, 69);
            this.chbLeyenda.Name = "chbLeyenda";
            this.chbLeyenda.Size = new System.Drawing.Size(132, 24);
            this.chbLeyenda.TabIndex = 32;
            this.chbLeyenda.Text = "Formato Leyenda";
            // 
            // chbDuplicado
            // 
            this.chbDuplicado.ForeColor = System.Drawing.Color.White;
            this.chbDuplicado.Location = new System.Drawing.Point(430, 68);
            this.chbDuplicado.Name = "chbDuplicado";
            this.chbDuplicado.Size = new System.Drawing.Size(114, 23);
            this.chbDuplicado.TabIndex = 31;
            this.chbDuplicado.Text = "¿Duplicado?";
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsUnidad1, "Unidad.Undescr", true));
            this.cmbUnidad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsUnidad1, "Unidad.IdUnidad", true));
            this.cmbUnidad.DataSource = this.dsUnidad1.Unidad;
            this.cmbUnidad.DisplayMember = "Undescr";
            this.cmbUnidad.Location = new System.Drawing.Point(463, 35);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(80, 21);
            this.cmbUnidad.TabIndex = 29;
            this.cmbUnidad.ValueMember = "IdUnidad";
            // 
            // dsUnidad1
            // 
            this.dsUnidad1.DataSetName = "dsUnidad";
            this.dsUnidad1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsUnidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(420, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Unidad:";
            // 
            // txtFolioIni
            // 
            this.txtFolioIni.Location = new System.Drawing.Point(685, 9);
            this.txtFolioIni.Name = "txtFolioIni";
            this.txtFolioIni.Size = new System.Drawing.Size(54, 20);
            this.txtFolioIni.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(246, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Folio final:";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(615, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Folio inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(432, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // txtFolioFin
            // 
            this.txtFolioFin.Location = new System.Drawing.Point(308, 91);
            this.txtFolioFin.Name = "txtFolioFin";
            this.txtFolioFin.Size = new System.Drawing.Size(54, 20);
            this.txtFolioFin.TabIndex = 28;
            this.txtFolioFin.Visible = false;
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(463, 3);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 1;
            this.cmbIdObra.ValueMember = "IdObra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe de calidad de los materiales para: Terracerias, Sub-base, y base de pavim" +
    "entos";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(570, 36);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2111, 1222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // crvInfMateriales
            // 
            this.crvInfMateriales.ActiveViewIndex = -1;
            this.crvInfMateriales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInfMateriales.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInfMateriales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInfMateriales.EnableRefresh = false;
            this.crvInfMateriales.Location = new System.Drawing.Point(0, 120);
            this.crvInfMateriales.Name = "crvInfMateriales";
            this.crvInfMateriales.ShowCloseButton = false;
            this.crvInfMateriales.ShowGroupTreeButton = false;
            this.crvInfMateriales.ShowLogo = false;
            this.crvInfMateriales.ShowParameterPanelButton = false;
            this.crvInfMateriales.ShowRefreshButton = false;
            this.crvInfMateriales.Size = new System.Drawing.Size(856, 528);
            this.crvInfMateriales.TabIndex = 76;
            this.crvInfMateriales.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // sqlDAUnidad
            // 
            this.sqlDAUnidad.SelectCommand = this.sqlCommand2;
            this.sqlDAUnidad.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Unidad", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdUnidad", "IdUnidad"),
                        new System.Data.Common.DataColumnMapping("Factor", "Factor"),
                        new System.Data.Common.DataColumnMapping("Undescr", "Undescr"),
                        new System.Data.Common.DataColumnMapping("MaxagrUn", "MaxagrUn"),
                        new System.Data.Common.DataColumnMapping("RevenUn", "RevenUn")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "SELECT IdUnidad, Factor, Undescr, MaxagrUn, RevenUn FROM Unidad";
            this.sqlCommand2.Connection = this.sqlConn;
            // 
            // sqlDANorma
            // 
            this.sqlDANorma.SelectCommand = this.sqlSelectCommand4;
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
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "SELECT IdNorma, Informe, Normas, Titulo, IdInforme, Norma1, Norma2, Norma3, Norma" +
    "4, Norma5 FROM Normas WHERE (IdNorma = 11) ORDER BY IdNorma";
            this.sqlSelectCommand4.Connection = this.sqlConn;
            // 
            // InfMateriales
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(856, 648);
            this.Controls.Add(this.crvInfMateriales);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InfMateriales";
            this.Text = "InfMateriales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfMateriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsInfMateriales1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterialesInf1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		protected GraphPane myPane;

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			if(dsMaterialesInf1.Tables["Materiales"].Rows.Count > 0)
			{
				txtFolioIni.Text = dsMaterialesInf1.Tables["Materiales"].Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
				txtFolioFin.Text = dsMaterialesInf1.Tables["Materiales"].Rows[buscaBtn1.RegistroSeleccionado][0].ToString();
				btnVistaPrevia.Visible = true;
			}
			else
			{
				btnVistaPrevia.Visible = false;
			}
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
			int j = 0;
			int k = 0;
			double[] x = new double[13];
			double[] y = new double[13];
			double[] x1 = new double[13];
			double[] y1 = new double[13];

			crvInfMateriales.Visible = true;
			dsInfMateriales1.Clear();

            cryRepMateriales1.SetDataSource(dsInfMateriales1);
            cryRepMateriales1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            cryRepMateriales1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;

			sqlDAInfMateriales.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDAInfMateriales.SelectCommand.Parameters["@FolioIni"].Value = (chbTodos.Checked ? "   " : txtFolioIni.Text);
			sqlDAInfMateriales.SelectCommand.Parameters["@FolioFin"].Value = (chbTodos.Checked ? "zzzzzzzzzz" : txtFolioIni.Text);
			sqlDAInfMateriales.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue;
			sqlDAInfMateriales.Fill(dsInfMateriales1, "MaterialesRep");
            sqlDAInfMaterialesMal.SelectCommand.Parameters["@IdFolioIni"].Value = (chbTodos.Checked ? "   " : txtFolioIni.Text);
			sqlDAInfMaterialesMal.SelectCommand.Parameters["@IdFolioFin"].Value = (chbTodos.Checked ? "zzzzzzzzzz" : txtFolioFin.Text);
			sqlDAInfMaterialesMal.Fill(dsInfMateriales1, "MaterialesMal");
			sqlDAFirmas.Fill(dsFirmas1, "Firmas");
			sqlDANorma.Fill(dsInfMateriales1, "Normas");
			cryRepMateriales1.SetParameterValue("@F1", dsFirmas1.Tables[0].Rows[0][1].ToString());
			cryRepMateriales1.SetParameterValue("@F2", dsFirmas1.Tables[0].Rows[1][1].ToString());
			cryRepMateriales1.SetParameterValue("@F3", dsFirmas1.Tables[0].Rows[2][1].ToString());
			cryRepMateriales1.SetParameterValue("@F4", dsFirmas1.Tables[0].Rows[3][1].ToString());
            cryRepMateriales1.SetParameterValue("@F5", dsFirmas1.Tables[0].Rows[4][1].ToString());
            cryRepMateriales1.SetParameterValue("@C1", dsFirmas1.Tables[0].Rows[0][2].ToString());
			cryRepMateriales1.SetParameterValue("@C2", dsFirmas1.Tables[0].Rows[1][2].ToString());
			cryRepMateriales1.SetParameterValue("@C3", dsFirmas1.Tables[0].Rows[2][2].ToString());
			cryRepMateriales1.SetParameterValue("@C4", dsFirmas1.Tables[0].Rows[3][2].ToString());
            cryRepMateriales1.SetParameterValue("@C5", dsFirmas1.Tables[0].Rows[4][2].ToString());
            cryRepMateriales1.SetParameterValue("@Unidad", dsUnidad1.Tables[0].Rows[cmbUnidad.SelectedIndex][1].ToString());
			cryRepMateriales1.SetParameterValue("@Lab", chbLab.Checked);
			string conversion  = (cmbUnidad.SelectedValue.ToString() == "2" ? "* Para convertir a kg/cm² multiplique por 10,19716" : "* Para convertir en Mega Pascales multiplique por 0,0980665" );
			cryRepMateriales1.SetParameterValue("@Conversion", conversion);
			cryRepMateriales1.SetParameterValue("@Duplicado", chbDuplicado.Checked);
			cryRepMateriales1.SetParameterValue("@Leyenda", chbLeyenda.Checked);
            cryRepMateriales1.SetParameterValue("@Ineco", chbLab1.Checked);
            cryRepMateriales1.SetParameterValue("@Respaldo", chbRespaldo.Checked);

			memGraphics.CreateDoubleBuffer(this.CreateGraphics(),
				this.ClientRectangle.Width, this.ClientRectangle.Height);
            int ejex = 2;
            CurveItem curve;
			myPane = new GraphPane( new Rectangle( 10, 10, 10, 10 ), "", "", "");
			SetSize();
            string folio;
            TextItem texe = new TextItem();
            for (int m = 0; m < dsInfMateriales1.Tables["MaterialesREP"].Rows.Count; m++)
            {

                folio = "Folio = '" + dsInfMateriales1.Tables["MaterialesREP"].Rows[m][0].ToString().Trim() + "'";
                DataRow[] filas;
                filas = dsInfMateriales1.Tables["MaterialesMal"].Select(folio);

                //Curva que pasa
                string acotacion = "Pasa";
                for (k = 0; k < 13; k++)
                    x[k] = y[k] = 0;
                k = 0;
                for (j = 12; j > -1; j--)
                {
                    //if (dsInfMateriales1.Tables["MaterialesMal"].Rows[j][ejex].ToString() != "" &&
                    //    dsInfMateriales1.Tables["MaterialesMal"].Rows[j][8].ToString() != "")
                    //{
                    //    x[k] = double.Parse(dsInfMateriales1.Tables["MaterialesMal"].Rows[j][ejex].ToString());
                    //    y[k++] = double.Parse(dsInfMateriales1.Tables["MaterialesMal"].Rows[j][8].ToString());
                    ////}
                    if (filas[j][ejex].ToString() != "" &&
                        filas[j][8].ToString() != "")
                    {
                        x[k] = double.Parse(filas[j][ejex].ToString());
                        y[k++] = double.Parse(filas[j][8].ToString());
                    }
                }
                curve = myPane.AddCurve(acotacion, x, y, Color.Blue, SymbolType.Triangle);
                curve.Line.Width = 2.0F;
                curve.Line.Style = DashStyle.Dash;
                curve.Symbol.PenWidth = 6.0F;
                curve.Symbol.Fill = new Fill(Color.Blue);
                //Limite inferior
                acotacion = "L1";
                for (k = 0; k < 13; k++)
                    x1[k] = y1[k] = 0;
                k = 0;
                for (j = 12; j > -1; j--)
                {
                    if (filas[j][ejex].ToString() != "" &&
                        filas[j][4].ToString() != "")
                    {
                        x1[k] = double.Parse(filas[j][ejex].ToString());
                        y1[k++] = double.Parse(filas[j][4].ToString());
                    }
                }
                curve = myPane.AddCurve(acotacion, x1, y1, Color.Red, SymbolType.Empty);
                curve.Line.Width = 1.0F;
                curve.Symbol.IsVisible = false;
                //Limite superior
                acotacion = "L2";
                for (k = 0; k < 13; k++)
                    x1[k] = y1[k] = 0;
                k = 0;
                for (j = 12; j > -1; j--)
                {
                    if (filas[j][ejex].ToString() != "" &&
                        filas[j][5].ToString() != "")
                    {
                        x1[k] = double.Parse(filas[j][ejex].ToString());
                        y1[k++] = double.Parse(filas[j][5].ToString());
                    }
                }
                curve = myPane.AddCurve(acotacion, x1, y1, Color.DarkGreen, SymbolType.Empty);
                curve.Line.Width = 1.0F;
                curve.Symbol.IsVisible = false;
                //Limite inferior
                acotacion = "L3";
                for (k = 0; k < 13; k++)
                    x1[k] = y1[k] = 0;
                k = 0;
                for (j = 12; j > -1; j--)
                {
                    if (filas[j][ejex].ToString() != "" &&
                        filas[j][6].ToString() != "")
                    {
                        x1[k] = double.Parse(filas[j][ejex].ToString());
                        y1[k++] = double.Parse(filas[j][6].ToString());
                    }
                }
                curve = myPane.AddCurve(acotacion, x1, y1, Color.Brown, SymbolType.Empty);
                curve.Line.Width = 1.0F;
                curve.Symbol.IsVisible = false;
                //Limite superior
                acotacion = "L4";
                for (k = 0; k < 13; k++)
                    x1[k] = y1[k] = 0;
                k = 0;
                for (j = 12; j > -1; j--)
                {
                    if (filas[j][ejex].ToString() != "" &&
                        filas[j][7].ToString() != "")
                    {
                        x1[k] = double.Parse(filas[j][ejex].ToString());
                        y1[k++] = double.Parse(filas[j][7].ToString());
                    }
                }
                curve = myPane.AddCurve(acotacion, x1, y1, Color.Violet, SymbolType.Empty);
                curve.Line.Width = 1.0F;
                curve.Symbol.IsVisible = false;

                int si = -4;
                string acota = "";
                acotacion = "Pasa";
                for (k = 0; k < 13; k++)
                    x[k] = y[k] = 0;
                k = 0;
                for (j = 12; j > -1; j--)
                {
                    if (filas[j][ejex].ToString() != "" )
    //                    if (filas[j][ejex].ToString() != "" &&
    //filas[j][8].ToString() != "")
                    {
                        ArrowItem arrow = new ArrowItem(Color.Gray, 0, float.Parse(dsInfMateriales1.Tables["MaterialesMal"].Rows[j][ejex].ToString()), 0, float.Parse(dsInfMateriales1.Tables["MaterialesMal"].Rows[j][ejex].ToString()), 100);
                        arrow.CoordinateFrame = CoordType.AxisXYScale;
                        arrow.PenWidth = 0.0F;
                        //if (filas[j][ejex].ToString() == "0.425")
                        //    arrow.PenWidth = 3.0F;
                        //if (float.Parse(filas[j][ejex].ToString()) == 4.75)
                        //    arrow.PenWidth = 3.0F;
                        acota = dsInfMateriales1.Tables["MaterialesMal"].Rows[j][ejex].ToString().Trim();
                        int lacota = acota.Length-1;
                        acota = (acota.Substring(lacota,1) == "0" ? acota.Substring(0,lacota - 1) : acota);
                        myPane.ArrowList.Add(arrow);
                        texe = new TextItem( acota, float.Parse(dsInfMateriales1.Tables["MaterialesMal"].Rows[j][ejex].ToString()), si);
//                        si = (si == -2 ? -6 : -2);
                        texe.FontSpec.IsBold = false;
                        texe.FontSpec.FrameColor = Color.White;
                        texe.FontSpec.Size = 9;
                        texe.FontSpec.Family = "Times New Roman";
//                        texe.FontSpec.Angle = 270;
                        myPane.TextList.Add(texe);
                        texe = new TextItem(dsInfMateriales1.Tables["MaterialesMal"].Rows[j][ejex+1].ToString(), float.Parse(dsInfMateriales1.Tables["MaterialesMal"].Rows[j][ejex].ToString()), 103);
                        texe.FontSpec.IsBold = false;
                        texe.FontSpec.FrameColor = Color.White;
                        texe.FontSpec.Size = 9;
                        texe.FontSpec.Family = "Times New Roman"; 
                        myPane.TextList.Add(texe);
                    }
                }
                guardagrafica(dsInfMateriales1.Tables["MaterialesREP"].Rows[m][0].ToString());
                    myPane = new GraphPane(new Rectangle(10, 10, 10, 10),
                        " ", "", "");
                    SetSize();

            }
            //myPane.XAxis.ScaledMinorTic(0);
            //myPane.XAxis.IsMinorInsideTic = false;
            //myPane.XAxis.TicSize = 0;
            //myPane.XAxis.IsShowGrid = false;
            //myPane.XAxis.IsInsideTic = false;
            //myPane.XAxis.ScaleFontSpec.Angle = 0;
            //myPane.XAxis.NumDec = 0;
            //myPane.XAxis.Min = 0.075;
            //myPane.XAxis.Max = MaxX;
            //myPane.XAxis.Type = AxisType.Log;
            //myPane.XAxis.ScaleFormat = "{0:d###.##}";
            //myPane.XAxis.IsShowTitle = false;
            //myPane.XAxis.ScaleFontSpec.FontColor = Color.White;

            //myPane.YAxis.IsShowGrid = true;
            //myPane.YAxis.ScaleFontSpec.Angle = 90;
            //myPane.YAxis.Min = 0;
            //myPane.YAxis.Max = 100;
			
            //myPane.Legend.IsVisible = false;
            //myPane.PaneFill = new Fill( Color.White, Color.White, 0F );
            //myPane.AxisChange( this.CreateGraphics() );

            //pictureBox1.Image = Image.FromHbitmap(myPane.Image.GetHbitmap());
            //MemoryStream ms = new MemoryStream();
            //pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            //byte[] arrImage = ms.GetBuffer();
            //ms.Close();
				
            //myPane.Image.Dispose();
            //pictureBox1.Image.Dispose();
            //dsInfMateriales1.Grafica.AddGraficaRow(txtFolioIni.Text, arrImage);

			crvInfMateriales.ReportSource = cryRepMateriales1;
//			crvInfMateriales.RefreshReport();
		}

		private void InfMateriales_Load(object sender, System.EventArgs e)
		{
			sqlDABusObra.Fill(dsBusObra1, "Obra");
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			buscaBtn1.Visible = true;
			dsMaterialesInf1.Clear();
			sqlDAMaterialesInf.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDAMaterialesInf.Fill(dsMaterialesInf1, "Materiales");
		}
		private void SetSize()
		{
			Rectangle paneRect = pictureBox1.ClientRectangle; //this.ClientRectangle;
			paneRect.Inflate( 0, 0 );
			this.myPane.PaneRect = paneRect;
		}

		private void btnVistaPrevia_Load(object sender, System.EventArgs e)
		{
		
		}

        private void guardagrafica(string folio)
        {

            myPane.XAxis.ScaledMinorTic(0);
            myPane.XAxis.IsMinorInsideTic = false;
            myPane.XAxis.TicSize = 0;
            myPane.XAxis.IsShowGrid = false;
            myPane.XAxis.IsInsideTic = false;
            myPane.XAxis.ScaleFontSpec.Angle = 180;
            myPane.XAxis.NumDec = 0;
            myPane.XAxis.Min = 0.075;
            myPane.XAxis.Max = 75;
            myPane.XAxis.Type = AxisType.Log;
            myPane.XAxis.ScaleFormat = "{0:d###.##}";
            myPane.XAxis.IsShowTitle = false;
            myPane.XAxis.ScaleFontSpec.FontColor = Color.White;

            myPane.YAxis.IsShowGrid = true;
            myPane.YAxis.ScaleFontSpec.Size = 8;
            myPane.YAxis.ScaleFontSpec.Angle = 90;
            myPane.YAxis.Min = 0;
            myPane.YAxis.Max = 100;

            myPane.Legend.IsVisible = false;
            myPane.PaneFill = new Fill(Color.White, Color.White, 0F);
            myPane.AxisChange(this.CreateGraphics());

            pictureBox1.Image = Image.FromHbitmap(myPane.Image.GetHbitmap());
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] arrImage = ms.GetBuffer();
            ms.Close();

            myPane.Image.Dispose();
            pictureBox1.Image.Dispose();
            dsInfMateriales1.Grafica.AddGraficaRow(folio, arrImage);

        }    

	}
}
