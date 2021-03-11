using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;
////using DataGridExtensions;
using System.Data;
using System.Data.SqlClient;


namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Volumetrica.
	/// </summary>
	public class Volumetrica : CatalogoGenerico
	{
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsBusObra dsBusObra1;
        private LancNeo.dsLaboratorista dsLaboratorista1;
		private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorista;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtObserva;
		private System.Windows.Forms.TextBox txtSemana;
		private System.Windows.Forms.ComboBox cmbNoeco;
		private System.Windows.Forms.DateTimePicker dtpFinforme;
		private System.Windows.Forms.TextBox txtConsecutivo;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAVolumetrico;
        private LancNeo.dsVolumetrico dsVolumetrico1;
        private LancNeo.dsLaboratorio dsLaboratorio1;
		private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorio;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private System.Windows.Forms.DataGridTableStyle dgtsapl;
		private System.Windows.Forms.DataGridTextBoxColumn FOLIO;
		private System.Windows.Forms.DataGridTextBoxColumn FECHA;
		private System.Windows.Forms.DataGridTextBoxColumn IdLaboratorio;
		private System.Windows.Forms.DataGridTextBoxColumn Material;
		private System.Windows.Forms.DataGridTextBoxColumn Tipoprueba;
		private System.Windows.Forms.DataGridTextBoxColumn Masa;
		private System.Windows.Forms.DataGridTextBoxColumn Optimo;
		private System.Windows.Forms.DataGridTableStyle dgtsapl1;
		public System.Data.SqlClient.SqlDataAdapter sqlDAVolRes;
		private System.Windows.Forms.DataGrid dgVolum;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		private System.Windows.Forms.DataGridTextBoxColumn Prueba;
		private System.Windows.Forms.Label label4;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Windows.Forms.DateTimePicker dtpFEnsaye;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Volumetrica()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			sqlDALaboratorio.Fill(dsLaboratorio1, "Laboratorio");

			DataGridComboBoxColumnStyle col1 = new DataGridComboBoxColumnStyle();
			col1.MappingName = "IdLaboratorio";				//Name of column in Rows DataTable
			col1.HeaderText = "IdLaboratorio";      
			col1.DataSource = dsLaboratorio1.Laboratorio; //DataSource for lookup table 
			col1.DisplayMember = "IdLaboratorio";			//Display value in lookup table
			col1.ValueMember = "IdLaboratorio";				//Value in lookup table - maps to MappingName in Rows
			col1.NullText = "<none>";
			col1.ReadOnly = false;
			col1.Width = 75;
			ArrayList Tipo =new ArrayList();
			Tipo.Add(new matComboSS("Porter","Porter"));
			Tipo.Add(new matComboSS("Proctor","Proctor"));
			DataGridComboBoxColumnStyle col2 = new DataGridComboBoxColumnStyle();
			col2.MappingName = "Tipoprueba";  //Name of column in Rows DataTable
			col2.HeaderText = "Tipo prueba";      
			col2.DataSource = Tipo; //DataSource for lookup table 
			col2.DisplayMember = "getName"; //Display value in lookup table
			col2.ValueMember = "getId";  //Value in lookup table - maps to MappingName in Rows
			col2.NullText = "<none>";
			col2.ReadOnly = false;
			col2.Width = 62;

			dgtsapl1.GridColumnStyles.Clear();
			foreach(DataGridColumnStyle myColStyle in dgtsapl.GridColumnStyles)
			{
				switch(myColStyle.MappingName.ToString())       
				{         
					case "IdLaboratorio":
						dgtsapl1.GridColumnStyles.Add(col1);
						break;                  
					case "Tipoprueba":
						dgtsapl1.GridColumnStyles.Add(col2);
						break;                  
					default:
						try
						{
							dgtsapl1.GridColumnStyles.Add(myColStyle);
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.Message );
						}
						break;
				}
			}

			dgtsapl.GridColumnStyles.Clear();
			foreach(DataGridColumnStyle myColStyle in dgtsapl1.GridColumnStyles)
				dgtsapl.GridColumnStyles.Add(myColStyle);
			dgtsapl.AlternatingBackColor = System.Drawing.Color.LightGray;
			dgtsapl.BackColor = System.Drawing.Color.Gainsboro;
			dgtsapl.ForeColor = System.Drawing.Color.Black;
			dgtsapl.GridLineColor = System.Drawing.Color.DimGray;
			dgtsapl.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			dgtsapl.HeaderFont = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			dgtsapl.HeaderForeColor = System.Drawing.Color.White;
			dgtsapl.LinkColor = System.Drawing.Color.MidnightBlue;
			dgtsapl.SelectionBackColor = System.Drawing.Color.CadetBlue;
			dgtsapl.SelectionForeColor = System.Drawing.Color.White;

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		protected struct matComboSS
		{
			private string Descripcion;
			private string Identificador;
			public matComboSS(string Nombre , string id)
			{
				Descripcion=Nombre;
				Identificador = id;
			}
			public string getName
			{
				get
				{
					return Descripcion;
				}
			}

			public string getId
			{
				get
				{
					return Identificador;
				}
			}
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Volumetrica));
			this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.dsLaboratorista1 = new LancNeo.dsLaboratorista();
			this.sqlDALaboratorista = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
			this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsVolumetrico1 = new LancNeo.dsVolumetrico();
			this.dtpFEnsaye = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.txtObserva = new System.Windows.Forms.TextBox();
			this.txtSemana = new System.Windows.Forms.TextBox();
			this.cmbNoeco = new System.Windows.Forms.ComboBox();
			this.dtpFinforme = new System.Windows.Forms.DateTimePicker();
			this.txtConsecutivo = new System.Windows.Forms.TextBox();
			this.cmbIdObra = new System.Windows.Forms.ComboBox();
			this.txtFolio = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.sqlDAVolumetrico = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.dgVolum = new System.Windows.Forms.DataGrid();
			this.dgtsapl = new System.Windows.Forms.DataGridTableStyle();
			this.FOLIO = new System.Windows.Forms.DataGridTextBoxColumn();
			this.FECHA = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Prueba = new System.Windows.Forms.DataGridTextBoxColumn();
			this.IdLaboratorio = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Material = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Tipoprueba = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Masa = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Optimo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dgtsapl1 = new System.Windows.Forms.DataGridTableStyle();
            this.dsLaboratorio1 = new LancNeo.dsLaboratorio();
			this.sqlDALaboratorio = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
			this.sqlDAVolRes = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.panelToolBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsVolumetrico1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgVolum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio1)).BeginInit();
			this.SuspendLayout();
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 455);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(800, 22);
			// 
			// panelToolBar
			// 
			this.panelToolBar.Name = "panelToolBar";
			this.panelToolBar.Size = new System.Drawing.Size(800, 64);
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.Name = "btnSiguiente";
			// 
			// btnUltimo
			// 
			this.btnUltimo.Name = "btnUltimo";
			// 
			// btnAnterior
			// 
			this.btnAnterior.Name = "btnAnterior";
			// 
			// btnPrimero
			// 
			this.btnPrimero.Name = "btnPrimero";
			// 
			// btnDeshacer
			// 
			this.btnDeshacer.Name = "btnDeshacer";
			// 
			// btnNuevo
			// 
			this.btnNuevo.Name = "btnNuevo";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Name = "btnEliminar";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Name = "btnGuardar";
			// 
			// btnVistaPrevia
			// 
			this.btnVistaPrevia.Name = "btnVistaPrevia";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Name = "btnCancelar";
			// 
			// sqlConn
			// 
			this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
			// 
			// dsBusObra1
			// 
			this.dsBusObra1.DataSetName = "dsBusObra";
			this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
			// 
			// dsLaboratorista1
			// 
			this.dsLaboratorista1.DataSetName = "dsLaboratorista";
			this.dsLaboratorista1.Locale = new System.Globalization.CultureInfo("es-MX");
			// 
			// sqlDALaboratorista
			// 
			this.sqlDALaboratorista.SelectCommand = this.sqlSelectCommand5;
			this.sqlDALaboratorista.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										 new System.Data.Common.DataTableMapping("Table", "Laboratorista", new System.Data.Common.DataColumnMapping[] {
																																																						  new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
																																																						  new System.Data.Common.DataColumnMapping("Laboratorista", "Laboratorista"),
																																																						  new System.Data.Common.DataColumnMapping("IdZona", "IdZona"),
																																																						  new System.Data.Common.DataColumnMapping("IdNivel", "IdNivel"),
																																																						  new System.Data.Common.DataColumnMapping("Fechai", "Fechai")})});
			// 
			// sqlSelectCommand5
			// 
			this.sqlSelectCommand5.CommandText = "SELECT NoEco, LTRIM(STR(NoEco)) + \' \' + Laboratorista AS Laboratorista, IdZona, I" +
				"dNivel, Fechai FROM Laboratorista ORDER BY NoEco";
			this.sqlSelectCommand5.Connection = this.sqlConn;
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
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.buscaBtn1);
			this.panel2.Controls.Add(this.dtpFEnsaye);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txtObserva);
			this.panel2.Controls.Add(this.txtSemana);
			this.panel2.Controls.Add(this.cmbNoeco);
			this.panel2.Controls.Add(this.dtpFinforme);
			this.panel2.Controls.Add(this.txtConsecutivo);
			this.panel2.Controls.Add(this.cmbIdObra);
			this.panel2.Controls.Add(this.txtFolio);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(8, 96);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(784, 136);
			this.panel2.TabIndex = 4;
			// 
			// buscaBtn1
			// 
			this.buscaBtn1.AnchoColTit = true;
			this.buscaBtn1.AnchoDlgBusq = 675;
			this.buscaBtn1.BackColor = System.Drawing.SystemColors.Control;
			this.buscaBtn1.Datos = this.dsVolumetrico1.Volumetrico;
			this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
			this.buscaBtn1.Location = new System.Drawing.Point(208, 16);
			this.buscaBtn1.Name = "buscaBtn1";
			this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
			this.buscaBtn1.TabIndex = 34;
			// 
			// dsVolumetrico1
			// 
			this.dsVolumetrico1.DataSetName = "dsVolumetrico";
			this.dsVolumetrico1.Locale = new System.Globalization.CultureInfo("es-MX");
			// 
			// dtpFEnsaye
			// 
			this.dtpFEnsaye.CustomFormat = "dd/MM/yyyy";
			this.dtpFEnsaye.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsVolumetrico1, "Volumetrico.FEnsaye"));
			this.dtpFEnsaye.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFEnsaye.Location = new System.Drawing.Point(560, 8);
			this.dtpFEnsaye.Name = "dtpFEnsaye";
			this.dtpFEnsaye.Size = new System.Drawing.Size(84, 20);
			this.dtpFEnsaye.TabIndex = 35;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label4.Location = new System.Drawing.Point(472, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 16);
			this.label4.TabIndex = 36;
			this.label4.Text = "Fecha muestreo:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtObserva
			// 
			this.txtObserva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsVolumetrico1, "Volumetrico.Observaciones"));
			this.txtObserva.Location = new System.Drawing.Point(376, 56);
			this.txtObserva.MaxLength = 512;
			this.txtObserva.Multiline = true;
			this.txtObserva.Name = "txtObserva";
			this.txtObserva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtObserva.Size = new System.Drawing.Size(394, 68);
			this.txtObserva.TabIndex = 10;
			this.txtObserva.Text = "textBox5";
			// 
			// txtSemana
			// 
			this.txtSemana.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsVolumetrico1, "Volumetrico.Semana"));
			this.txtSemana.Location = new System.Drawing.Point(117, 80);
			this.txtSemana.MaxLength = 2;
			this.txtSemana.Name = "txtSemana";
			this.txtSemana.Size = new System.Drawing.Size(66, 20);
			this.txtSemana.TabIndex = 4;
			this.txtSemana.Text = "textBox3";
			// 
			// cmbNoeco
			// 
			this.cmbNoeco.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsVolumetrico1, "Volumetrico.NoEco"));
			this.cmbNoeco.DataSource = this.dsLaboratorista1.Laboratorista;
			this.cmbNoeco.DisplayMember = "Laboratorista";
			this.cmbNoeco.ItemHeight = 13;
			this.cmbNoeco.Location = new System.Drawing.Point(376, 32);
			this.cmbNoeco.Name = "cmbNoeco";
			this.cmbNoeco.Size = new System.Drawing.Size(392, 21);
			this.cmbNoeco.TabIndex = 7;
			this.cmbNoeco.ValueMember = "NoEco";
			// 
			// dtpFinforme
			// 
			this.dtpFinforme.CustomFormat = "dd/MM/yyyy";
			this.dtpFinforme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsVolumetrico1, "Volumetrico.Finforme"));
			this.dtpFinforme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFinforme.Location = new System.Drawing.Point(376, 8);
			this.dtpFinforme.Name = "dtpFinforme";
			this.dtpFinforme.Size = new System.Drawing.Size(84, 20);
			this.dtpFinforme.TabIndex = 5;
			// 
			// txtConsecutivo
			// 
			this.txtConsecutivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsVolumetrico1, "Volumetrico.ConsObra"));
			this.txtConsecutivo.Location = new System.Drawing.Point(117, 56);
			this.txtConsecutivo.MaxLength = 4;
			this.txtConsecutivo.Name = "txtConsecutivo";
			this.txtConsecutivo.Size = new System.Drawing.Size(66, 20);
			this.txtConsecutivo.TabIndex = 3;
			this.txtConsecutivo.Text = "textBox2";
			// 
			// cmbIdObra
			// 
			this.cmbIdObra.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsVolumetrico1, "Volumetrico.IdObra"));
			this.cmbIdObra.DataSource = this.dsBusObra1;
			this.cmbIdObra.DisplayMember = "Obra.Idobra";
			this.cmbIdObra.ItemHeight = 13;
			this.cmbIdObra.Location = new System.Drawing.Point(117, 32);
			this.cmbIdObra.Name = "cmbIdObra";
			this.cmbIdObra.Size = new System.Drawing.Size(66, 21);
			this.cmbIdObra.TabIndex = 2;
			this.cmbIdObra.ValueMember = "Obra.Idobra";
			// 
			// txtFolio
			// 
			this.txtFolio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsVolumetrico1, "Volumetrico.FOLIO"));
			this.txtFolio.Location = new System.Drawing.Point(117, 8);
			this.txtFolio.MaxLength = 10;
			this.txtFolio.Name = "txtFolio";
			this.txtFolio.Size = new System.Drawing.Size(64, 20);
			this.txtFolio.TabIndex = 1;
			this.txtFolio.Text = "textBox1";
			this.txtFolio.TextChanged += new System.EventHandler(this.txtFolio_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label10.Location = new System.Drawing.Point(285, 56);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(83, 16);
			this.label10.TabIndex = 26;
			this.label10.Text = "Observaciones:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label8.Location = new System.Drawing.Point(54, 82);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 16);
			this.label8.TabIndex = 25;
			this.label8.Text = "Semana:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label7.Location = new System.Drawing.Point(291, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 16);
			this.label7.TabIndex = 24;
			this.label7.Text = "Ensayado por:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label6.Location = new System.Drawing.Point(288, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 16);
			this.label6.TabIndex = 23;
			this.label6.Text = "Fecha informe:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label3.Location = new System.Drawing.Point(34, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 16);
			this.label3.TabIndex = 22;
			this.label3.Text = "Consecutivo:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new System.Drawing.Point(72, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 16);
			this.label2.TabIndex = 21;
			this.label2.Text = "Obra:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(63, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 16);
			this.label1.TabIndex = 20;
			this.label1.Text = "FOLIO:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// sqlDAVolumetrico
			// 
			this.sqlDAVolumetrico.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDAVolumetrico.InsertCommand = this.sqlInsertCommand1;
			this.sqlDAVolumetrico.SelectCommand = this.sqlSelectCommand1;
			this.sqlDAVolumetrico.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									   new System.Data.Common.DataTableMapping("Table", "Volumetrico", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
																																																					  new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
																																																					  new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
																																																					  new System.Data.Common.DataColumnMapping("Finforme", "Finforme"),
																																																					  new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
																																																					  new System.Data.Common.DataColumnMapping("Semana", "Semana"),
																																																					  new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"),
																																																					  new System.Data.Common.DataColumnMapping("FEnsaye", "FEnsaye")})});
			this.sqlDAVolumetrico.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM Volumetrico WHERE (FOLIO = @Original_FOLIO) AND (ConsObra = @Original_ConsObra OR @Original_ConsObra IS NULL AND ConsObra IS NULL) AND (FEnsaye = @Original_FEnsaye OR @Original_FEnsaye IS NULL AND FEnsaye IS NULL) AND (Finforme = @Original_Finforme OR @Original_Finforme IS NULL AND Finforme IS NULL) AND (IdObra = @Original_IdObra OR @Original_IdObra IS NULL AND IdObra IS NULL) AND (NoEco = @Original_NoEco OR @Original_NoEco IS NULL AND NoEco IS NULL) AND (Observaciones = @Original_Observaciones OR @Original_Observaciones IS NULL AND Observaciones IS NULL) AND (Semana = @Original_Semana OR @Original_Semana IS NULL AND Semana IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ConsObra", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FEnsaye", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FEnsaye", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Finforme", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Finforme", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 512, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Semana", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO Volumetrico(FOLIO, IdObra, ConsObra, Finforme, NoEco, Semana, Observa" +
				"ciones, FEnsaye) VALUES (@FOLIO, @IdObra, @ConsObra, @Finforme, @NoEco, @Semana," +
				" @Observaciones, @FEnsaye)";
			this.sqlInsertCommand1.Connection = this.sqlConn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ConsObra", System.Data.SqlDbType.SmallInt, 2, "ConsObra"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Finforme", System.Data.SqlDbType.DateTime, 4, "Finforme"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 2, "NoEco"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 2, "Semana"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 512, "Observaciones"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FEnsaye", System.Data.SqlDbType.DateTime, 4, "FEnsaye"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT Volumetrico.FOLIO, Volumetrico.IdObra, Volumetrico.ConsObra, Volumetrico.F" +
				"informe, Volumetrico.NoEco, Volumetrico.Semana, Volumetrico.Observaciones, Volum" +
				"etrico.FEnsaye FROM Volumetrico INNER JOIN Obra ON Volumetrico.IdObra = Obra.Ido" +
				"bra";
			this.sqlSelectCommand1.Connection = this.sqlConn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE Volumetrico SET FOLIO = @FOLIO, IdObra = @IdObra, ConsObra = @ConsObra, Finforme = @Finforme, NoEco = @NoEco, Semana = @Semana, Observaciones = @Observaciones, FEnsaye = @FEnsaye WHERE (FOLIO = @Original_FOLIO) AND (ConsObra = @Original_ConsObra OR @Original_ConsObra IS NULL AND ConsObra IS NULL) AND (FEnsaye = @Original_FEnsaye OR @Original_FEnsaye IS NULL AND FEnsaye IS NULL) AND (Finforme = @Original_Finforme OR @Original_Finforme IS NULL AND Finforme IS NULL) AND (IdObra = @Original_IdObra OR @Original_IdObra IS NULL AND IdObra IS NULL) AND (NoEco = @Original_NoEco OR @Original_NoEco IS NULL AND NoEco IS NULL) AND (Observaciones = @Original_Observaciones OR @Original_Observaciones IS NULL AND Observaciones IS NULL) AND (Semana = @Original_Semana OR @Original_Semana IS NULL AND Semana IS NULL)";
			this.sqlUpdateCommand1.Connection = this.sqlConn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ConsObra", System.Data.SqlDbType.SmallInt, 2, "ConsObra"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Finforme", System.Data.SqlDbType.DateTime, 4, "Finforme"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 2, "NoEco"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 2, "Semana"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 512, "Observaciones"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FEnsaye", System.Data.SqlDbType.DateTime, 4, "FEnsaye"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ConsObra", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FEnsaye", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FEnsaye", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Finforme", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Finforme", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 512, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Semana", System.Data.DataRowVersion.Original, null));
			// 
			// dgVolum
			// 
			this.dgVolum.AlternatingBackColor = System.Drawing.Color.LightGray;
			this.dgVolum.BackColor = System.Drawing.Color.Gainsboro;
			this.dgVolum.BackgroundColor = System.Drawing.Color.Silver;
			this.dgVolum.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
			this.dgVolum.DataMember = "Volumetrico.VolumetricoVolumetricoRes";
			this.dgVolum.DataSource = this.dsVolumetrico1;
			this.dgVolum.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgVolum.Location = new System.Drawing.Point(-16, 248);
			this.dgVolum.Name = "dgVolum";
			this.dgVolum.Size = new System.Drawing.Size(808, 200);
			this.dgVolum.TabIndex = 5;
			this.dgVolum.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								this.dgtsapl,
																								this.dgtsapl1});
			// 
			// dgtsapl
			// 
			this.dgtsapl.DataGrid = this.dgVolum;
			this.dgtsapl.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																									  this.FOLIO,
																									  this.FECHA,
																									  this.Prueba,
																									  this.IdLaboratorio,
																									  this.Material,
																									  this.Tipoprueba,
																									  this.Masa,
																									  this.Optimo});
			this.dgtsapl.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgtsapl.MappingName = "VolumetricoRes";
			// 
			// FOLIO
			// 
			this.FOLIO.Format = "";
			this.FOLIO.FormatInfo = null;
			this.FOLIO.HeaderText = "FOLIO";
			this.FOLIO.MappingName = "FOLIO";
			this.FOLIO.ReadOnly = true;
			this.FOLIO.Width = 0;
			// 
			// FECHA
			// 
			this.FECHA.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.FECHA.Format = "dd/MM/yyyy";
			this.FECHA.FormatInfo = null;
			this.FECHA.HeaderText = "Fecha ensaye";
			this.FECHA.MappingName = "FECHA";
			this.FECHA.Width = 75;
			// 
			// Prueba
			// 
			this.Prueba.Format = "";
			this.Prueba.FormatInfo = null;
			this.Prueba.HeaderText = "No. de prueba";
			this.Prueba.MappingName = "Prueba";
			this.Prueba.Width = 80;
			// 
			// IdLaboratorio
			// 
			this.IdLaboratorio.Format = "";
			this.IdLaboratorio.FormatInfo = null;
			this.IdLaboratorio.HeaderText = "IdLaboratorio";
			this.IdLaboratorio.MappingName = "IdLaboratorio";
			this.IdLaboratorio.Width = 72;
			// 
			// Material
			// 
			this.Material.Format = "";
			this.Material.FormatInfo = null;
			this.Material.HeaderText = "Identificación del material";
			this.Material.MappingName = "Material";
			this.Material.Width = 280;
			// 
			// Tipoprueba
			// 
			this.Tipoprueba.Format = "";
			this.Tipoprueba.FormatInfo = null;
			this.Tipoprueba.HeaderText = "Tipo de prueba";
			this.Tipoprueba.MappingName = "Tipoprueba";
			this.Tipoprueba.Width = 80;
			// 
			// Masa
			// 
			this.Masa.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
			this.Masa.Format = "";
			this.Masa.FormatInfo = null;
			this.Masa.HeaderText = "Masa.";
			this.Masa.MappingName = "Masa";
			this.Masa.Width = 55;
			// 
			// Optimo
			// 
			this.Optimo.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
			this.Optimo.Format = "";
			this.Optimo.FormatInfo = null;
			this.Optimo.HeaderText = "Contenido optimo.";
			this.Optimo.MappingName = "Optimo";
			this.Optimo.Width = 120;
			// 
			// dgtsapl1
			// 
			this.dgtsapl1.DataGrid = this.dgVolum;
			this.dgtsapl1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgtsapl1.MappingName = "";
			// 
			// dsLaboratorio1
			// 
			this.dsLaboratorio1.DataSetName = "dsLaboratorio";
			this.dsLaboratorio1.Locale = new System.Globalization.CultureInfo("es-MX");
			// 
			// sqlDALaboratorio
			// 
			this.sqlDALaboratorio.SelectCommand = this.sqlSelectCommand4;
			this.sqlDALaboratorio.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									   new System.Data.Common.DataTableMapping("Table", "Laboratorio", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
																																																					  new System.Data.Common.DataColumnMapping("Laboratorio", "Laboratorio"),
																																																					  new System.Data.Common.DataColumnMapping("IdZona", "IdZona")})});
			// 
			// sqlSelectCommand4
			// 
			this.sqlSelectCommand4.CommandText = "SELECT IdLaboratorio, Laboratorio, IdZona FROM Laboratorio ORDER BY IdLaboratorio" +
				", Laboratorio";
			this.sqlSelectCommand4.Connection = this.sqlConn;
			// 
			// sqlDAVolRes
			// 
			this.sqlDAVolRes.DeleteCommand = this.sqlDeleteCommand2;
			this.sqlDAVolRes.InsertCommand = this.sqlInsertCommand2;
			this.sqlDAVolRes.SelectCommand = this.sqlSelectCommand2;
			this.sqlDAVolRes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								  new System.Data.Common.DataTableMapping("Table", "VolumetricoRes", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
																																																					new System.Data.Common.DataColumnMapping("Prueba", "Prueba"),
																																																					new System.Data.Common.DataColumnMapping("FECHA", "FECHA"),
																																																					new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
																																																					new System.Data.Common.DataColumnMapping("Material", "Material"),
																																																					new System.Data.Common.DataColumnMapping("Tipoprueba", "Tipoprueba"),
																																																					new System.Data.Common.DataColumnMapping("Masa", "Masa"),
																																																					new System.Data.Common.DataColumnMapping("Optimo", "Optimo")})});
			this.sqlDAVolRes.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = @"DELETE FROM VolumetricoRes WHERE (FOLIO = @Original_FOLIO) AND (Prueba = @Original_Prueba) AND (FECHA = @Original_FECHA OR @Original_FECHA IS NULL AND FECHA IS NULL) AND (IdLaboratorio = @Original_IdLaboratorio OR @Original_IdLaboratorio IS NULL AND IdLaboratorio IS NULL) AND (Masa = @Original_Masa OR @Original_Masa IS NULL AND Masa IS NULL) AND (Material = @Original_Material OR @Original_Material IS NULL AND Material IS NULL) AND (Optimo = @Original_Optimo OR @Original_Optimo IS NULL AND Optimo IS NULL) AND (Tipoprueba = @Original_Tipoprueba OR @Original_Tipoprueba IS NULL AND Tipoprueba IS NULL)";
			this.sqlDeleteCommand2.Connection = this.sqlConn;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Prueba", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prueba", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FECHA", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FECHA", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_IdLaboratorio", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(3)), "Masa", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Material", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Material", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Optimo", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(6)), ((System.Byte)(1)), "Optimo", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Tipoprueba", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Tipoprueba", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = @"INSERT INTO VolumetricoRes(FOLIO, Prueba, FECHA, IdLaboratorio, Material, Tipoprueba, Masa, Optimo) VALUES (@FOLIO, @Prueba, @FECHA, @IdLaboratorio, @Material, @Tipoprueba, @Masa, @Optimo); SELECT FOLIO, Prueba, FECHA, IdLaboratorio, Material, Tipoprueba, Masa, Optimo FROM VolumetricoRes WHERE (FOLIO = @FOLIO) AND (Prueba = @Prueba) ORDER BY FOLIO";
			this.sqlInsertCommand2.Connection = this.sqlConn;
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Prueba", System.Data.SqlDbType.VarChar, 10, "Prueba"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FECHA", System.Data.SqlDbType.DateTime, 4, "FECHA"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 10, "IdLaboratorio"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Material", System.Data.SqlDbType.VarChar, 50, "Material"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tipoprueba", System.Data.SqlDbType.VarChar, 10, "Tipoprueba"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(3)), "Masa", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Optimo", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(6)), ((System.Byte)(1)), "Optimo", System.Data.DataRowVersion.Current, null));
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT FOLIO, Prueba, FECHA, IdLaboratorio, Material, Tipoprueba, Masa, Optimo FR" +
				"OM VolumetricoRes WHERE (FOLIO = @Folio) ORDER BY FOLIO";
			this.sqlSelectCommand2.Connection = this.sqlConn;
			this.sqlSelectCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.VarChar, 10, "FOLIO"));
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = @"UPDATE VolumetricoRes SET FOLIO = @FOLIO, Prueba = @Prueba, FECHA = @FECHA, IdLaboratorio = @IdLaboratorio, Material = @Material, Tipoprueba = @Tipoprueba, Masa = @Masa, Optimo = @Optimo WHERE (FOLIO = @Original_FOLIO) AND (Prueba = @Original_Prueba) AND (FECHA = @Original_FECHA OR @Original_FECHA IS NULL AND FECHA IS NULL) AND (IdLaboratorio = @Original_IdLaboratorio OR @Original_IdLaboratorio IS NULL AND IdLaboratorio IS NULL) AND (Masa = @Original_Masa OR @Original_Masa IS NULL AND Masa IS NULL) AND (Material = @Original_Material OR @Original_Material IS NULL AND Material IS NULL) AND (Optimo = @Original_Optimo OR @Original_Optimo IS NULL AND Optimo IS NULL) AND (Tipoprueba = @Original_Tipoprueba OR @Original_Tipoprueba IS NULL AND Tipoprueba IS NULL); SELECT FOLIO, Prueba, FECHA, IdLaboratorio, Material, Tipoprueba, Masa, Optimo FROM VolumetricoRes WHERE (FOLIO = @FOLIO) AND (Prueba = @Prueba) ORDER BY FOLIO";
			this.sqlUpdateCommand2.Connection = this.sqlConn;
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Prueba", System.Data.SqlDbType.VarChar, 10, "Prueba"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FECHA", System.Data.SqlDbType.DateTime, 4, "FECHA"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 10, "IdLaboratorio"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Material", System.Data.SqlDbType.VarChar, 50, "Material"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Tipoprueba", System.Data.SqlDbType.VarChar, 10, "Tipoprueba"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(3)), "Masa", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Optimo", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(6)), ((System.Byte)(1)), "Optimo", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Prueba", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prueba", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FECHA", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FECHA", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_IdLaboratorio", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(3)), "Masa", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Material", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Material", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Optimo", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(6)), ((System.Byte)(1)), "Optimo", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Tipoprueba", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Tipoprueba", System.Data.DataRowVersion.Original, null));
			// 
			// Volumetrica
			// 
			this.AccessibleDescription = ((string)(configurationAppSettings.GetValue("Volumetrica.AccessibleDescription", typeof(string))));
			this.AccessibleName = ((string)(configurationAppSettings.GetValue("Volumetrica.AccessibleName", typeof(string))));
			this.AllowDrop = ((bool)(configurationAppSettings.GetValue("Volumetrica.AllowDrop", typeof(bool))));
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(800, 477);
			this.Controls.Add(this.dgVolum);
			this.Controls.Add(this.panel2);
			this.DAGeneral = this.sqlDAVolumetrico;
			this.dsGeneral = this.dsVolumetrico1;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.KeyPreview = ((bool)(configurationAppSettings.GetValue("Volumetrica.KeyPreview", typeof(bool))));
			this.Name = "Volumetrica";
			this.NombreTabla = "Volumetrico";
			this.Text = ((string)(configurationAppSettings.GetValue("Volumetrica.Text", typeof(string))));
			this.Load += new System.EventHandler(this.Volumetrica_Load_1);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.dgVolum, 0);
			this.Controls.SetChildIndex(this.statusBar1, 0);
			this.Controls.SetChildIndex(this.panelToolBar, 0);
			this.panelToolBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsVolumetrico1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgVolum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			base.btnNuevo_Click(sender, e);
			cmbIdObra.SelectedIndex = -1;
			cmbNoeco.SelectedIndex = -1;
			dtpFinforme.Value = DateTime.Now.AddDays(1);
			dtpFinforme.Value = DateTime.Today; 
			dtpFEnsaye.Value = DateTime.Now.AddDays(1);
			dtpFEnsaye.Value = DateTime.Today; 
		}

		private void Volumetrica_Load_1(object sender, System.EventArgs e)
		{
			buscaBtn1.Catalogo = this;
			sqlDABusObra.Fill(dsBusObra1,"Obra");
			sqlDALaboratorista.Fill(dsLaboratorista1,"Laboratorista");

		}
		protected override void btnGuardar_Click(object sender, System.EventArgs e)
		{
			try 
			{
				// Intente actualizar el origen de datos.
				base.BindingContext[dsVolumetrico1,"Volumetrico"].Position = this.BindingContext[dsVolumetrico1,"Volumetrico"].Position;
				this.UpdateDataSet1();
				base.dsGeneral_PositionChanged();
			}
			catch (System.Exception eUpdate) 
			{
				statusBar1.Panels[2].Text = eUpdate.Message;	
				statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
				statusBar1.Panels[2].ToolTipText = eUpdate.Message;
			}
			dsVolumetrico1.Tables["VolumetricoRes"].Clear();
			sqlDAVolRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDAVolRes.Fill(dsVolumetrico1,"VolumetricoRes");
		}
		public override void LoadDataSet()
		{
			base.LoadDataSet();
			dgVolum.SetDataBinding(dsVolumetrico1, "Volumetrico.VolumetricoVolumetricoRes");
			string apl = dgVolum.TableStyles.ToString();
			dsVolumetrico1.Tables["VolumetricoRes"].Clear();
			sqlDAVolRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDAVolRes.Fill(dsVolumetrico1,"VolumetricoRes");
		}

		private void UpdateDataSet1()
		{
			// Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
            LancNeo.dsVolumetrico objDataSetChanges = new LancNeo.dsVolumetrico();
			// Detener las ediciones actuales.
			this.BindingContext[dsVolumetrico1,"Volumetrico"].EndCurrentEdit();
			this.BindingContext[dsVolumetrico1,"VolumetricoRes"].EndCurrentEdit();

			// Obtener los cambios realizados en el conjunto de datos principal.
            objDataSetChanges = ((LancNeo.dsVolumetrico)(dsVolumetrico1.GetChanges()));

			// Comprobar si se han realizado cambios.
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
					// llamando al método de actualización y pasando el conjunto de datos y los parámetros.
					this.UpdateDataSource1(objDataSetChanges);
					dsVolumetrico1.Merge(objDataSetChanges);
					dsVolumetrico1.AcceptChanges();
				}
				catch (System.Exception eUpdate) 
				{
					// Agregar aquí el código de control de errores.
					throw eUpdate;
				}
				// Agregar código para comprobar en el conjunto de datos devuelto los errores que se puedan haber
				// introducido en el error del objeto de fila.
			}

		}
        private void UpdateDataSource1(LancNeo.dsVolumetrico ChangedRows)
		{
			try 
			{
				// Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
				if ((ChangedRows != null)) 
				{
					// Abra la conexión.
					this.sqlConn.Open();
					// Intente actualizar el origen de datos.
					sqlDAVolumetrico.Update(ChangedRows);
					sqlDAVolRes.Update(ChangedRows);
				}
			}
			catch (System.Exception updateException) 
			{
				// Agregar aquí el código de control de errores.
				throw updateException;
			}
			finally 
			{
				// Cerrar la conexión independientemente de si se inició una excepción o no.
				this.sqlConn.Close();
			}
		}

		private void txtFolio_TextChanged(object sender, System.EventArgs e)
		{
			dsVolumetrico1.Tables["VolumetricoRes"].Clear();
			sqlDAVolRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDAVolRes.Fill(dsVolumetrico1,"VolumetricoRes");
		}
	}
}
