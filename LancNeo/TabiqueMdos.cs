using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de TabiqueMdos.
	/// </summary>
	public class TabiqueMdos  : CatalogoGenerico
	{
		private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorista;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsLaboratorista dsLaboratorista1;
		private LancNeo.dsBusObra dsBusObra1;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Windows.Forms.Panel panel2;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.TextBox txtGrado;
		private System.Windows.Forms.TextBox txtSubtipo;
		private System.Windows.Forms.TextBox txtTipo;
		private System.Windows.Forms.CheckBox cbEmpleado;
		private System.Windows.Forms.DateTimePicker dtpFmuestreo;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtObscomo;
		private System.Windows.Forms.TextBox txtComo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox cbNorma;
		private System.Windows.Forms.CheckBox cbCumple;
		private System.Windows.Forms.CheckBox cbUnidad;
		private System.Windows.Forms.CheckBox cbMreducida;
		private System.Windows.Forms.TextBox txtObserva;
		private System.Windows.Forms.TextBox txtSemana;
		private System.Windows.Forms.ComboBox cmbNoeco;
		private System.Windows.Forms.TextBox txtConsecutivo;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtpFensaye;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpFinforme;
		private LancNeo.dsTabiqueMdor dsTabiqueMdor1;
        private LancNeo.dsAcero dsAcero1;
		private System.Data.SqlClient.SqlDataAdapter sqlDATabiqueRes;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlDataAdapter sqlDATabiqueMdor;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtLargo;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtAncho;
		private System.Windows.Forms.TextBox txtPeralte;
        private DataGridView dgTabique;
        private DataGridViewTextBoxColumn fOLIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mUESTRADataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn tMuestraDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn largoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anchoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn peralteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn masaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rcAIndDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rcAProDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn espIndDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn espProDataGridViewTextBoxColumn;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TabiqueMdos()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabiqueMdos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sqlDALaboratorista = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsLaboratorista1 = new LancNeo.dsLaboratorista();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsTabiqueMdor1 = new LancNeo.dsTabiqueMdor();
            this.txtPeralte = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.txtSubtipo = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.cbEmpleado = new System.Windows.Forms.CheckBox();
            this.dtpFmuestreo = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtObscomo = new System.Windows.Forms.TextBox();
            this.txtComo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbNorma = new System.Windows.Forms.CheckBox();
            this.cbCumple = new System.Windows.Forms.CheckBox();
            this.cbUnidad = new System.Windows.Forms.CheckBox();
            this.cbMreducida = new System.Windows.Forms.CheckBox();
            this.txtObserva = new System.Windows.Forms.TextBox();
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.cmbNoeco = new System.Windows.Forms.ComboBox();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFensaye = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFinforme = new System.Windows.Forms.DateTimePicker();
            this.dsAcero1 = new LancNeo.dsAcero();
            this.sqlDATabiqueRes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDATabiqueMdor = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dgTabique = new System.Windows.Forms.DataGridView();
            this.fOLIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUESTRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMuestraDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.largoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anchoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peralteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcAIndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcAProDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espIndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espProDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTabiqueMdor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabique)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 645);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1022, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(1022, 64);
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
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsLaboratorista1
            // 
            this.dsLaboratorista1.DataSetName = "dsLaboratorista";
            this.dsLaboratorista1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorista1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel2.Controls.Add(this.txtPeralte);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtAncho);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtLargo);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtGrado);
            this.panel2.Controls.Add(this.txtSubtipo);
            this.panel2.Controls.Add(this.txtTipo);
            this.panel2.Controls.Add(this.cbEmpleado);
            this.panel2.Controls.Add(this.dtpFmuestreo);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtObscomo);
            this.panel2.Controls.Add(this.txtComo);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbNorma);
            this.panel2.Controls.Add(this.cbCumple);
            this.panel2.Controls.Add(this.cbUnidad);
            this.panel2.Controls.Add(this.cbMreducida);
            this.panel2.Controls.Add(this.txtObserva);
            this.panel2.Controls.Add(this.txtSemana);
            this.panel2.Controls.Add(this.cmbNoeco);
            this.panel2.Controls.Add(this.txtConsecutivo);
            this.panel2.Controls.Add(this.cmbIdObra);
            this.panel2.Controls.Add(this.txtFolio);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtpFensaye);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpFinforme);
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 174);
            this.panel2.TabIndex = 6;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsTabiqueMdor1.TabiqueMdor;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(112, 6);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 15;
            // 
            // dsTabiqueMdor1
            // 
            this.dsTabiqueMdor1.DataSetName = "dsTabiqueMdor";
            this.dsTabiqueMdor1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTabiqueMdor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPeralte
            // 
            this.txtPeralte.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabiqueMdor1, "TabiqueMdor.Peralte", true));
            this.txtPeralte.Location = new System.Drawing.Point(514, 86);
            this.txtPeralte.Name = "txtPeralte";
            this.txtPeralte.Size = new System.Drawing.Size(44, 20);
            this.txtPeralte.TabIndex = 21;
            this.txtPeralte.Text = "textBox3";
            this.txtPeralte.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(471, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 54;
            this.label16.Text = "Peralte:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAncho
            // 
            this.txtAncho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabiqueMdor1, "TabiqueMdor.Ancho", true));
            this.txtAncho.Location = new System.Drawing.Point(396, 86);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(44, 20);
            this.txtAncho.TabIndex = 20;
            this.txtAncho.Text = "textBox2";
            this.txtAncho.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(324, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Ancho:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLargo
            // 
            this.txtLargo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabiqueMdor1, "TabiqueMdor.Largo", true));
            this.txtLargo.Location = new System.Drawing.Point(254, 86);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(44, 20);
            this.txtLargo.TabIndex = 19;
            this.txtLargo.Text = "textBox1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(219, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "Largo:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGrado
            // 
            this.txtGrado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabiqueMdor1, "TabiqueMdor.Grado", true));
            this.txtGrado.Location = new System.Drawing.Point(930, 58);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(78, 20);
            this.txtGrado.TabIndex = 17;
            this.txtGrado.Text = "textBox5";
            // 
            // txtSubtipo
            // 
            this.txtSubtipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabiqueMdor1, "TabiqueMdor.Subtipo", true));
            this.txtSubtipo.Location = new System.Drawing.Point(866, 32);
            this.txtSubtipo.Name = "txtSubtipo";
            this.txtSubtipo.Size = new System.Drawing.Size(142, 20);
            this.txtSubtipo.TabIndex = 16;
            this.txtSubtipo.Text = "textBox4";
            // 
            // txtTipo
            // 
            this.txtTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabiqueMdor1, "TabiqueMdor.Tipo", true));
            this.txtTipo.Location = new System.Drawing.Point(930, 6);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(78, 20);
            this.txtTipo.TabIndex = 15;
            this.txtTipo.Text = "textBox3";
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbEmpleado.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsTabiqueMdor1, "TabiqueMdor.Empleado", true));
            this.cbEmpleado.Location = new System.Drawing.Point(868, 82);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(140, 24);
            this.cbEmpleado.TabIndex = 18;
            this.cbEmpleado.Text = "Si puede ser empleado";
            this.cbEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFmuestreo
            // 
            this.dtpFmuestreo.CustomFormat = "dd/MM/yyyy";
            this.dtpFmuestreo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabiqueMdor1, "TabiqueMdor.FMuestreo", true));
            this.dtpFmuestreo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFmuestreo.Location = new System.Drawing.Point(780, 32);
            this.dtpFmuestreo.Name = "dtpFmuestreo";
            this.dtpFmuestreo.Size = new System.Drawing.Size(84, 20);
            this.dtpFmuestreo.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(888, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Grado:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(898, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Tipo:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObscomo
            // 
            this.txtObscomo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabiqueMdor1, "TabiqueMdor.ObsComo", true));
            this.txtObscomo.Location = new System.Drawing.Point(782, 6);
            this.txtObscomo.Name = "txtObscomo";
            this.txtObscomo.Size = new System.Drawing.Size(80, 20);
            this.txtObscomo.TabIndex = 11;
            this.txtObscomo.Text = "textBox2";
            // 
            // txtComo
            // 
            this.txtComo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabiqueMdor1, "TabiqueMdor.Como", true));
            this.txtComo.Location = new System.Drawing.Point(730, 6);
            this.txtComo.Name = "txtComo";
            this.txtComo.Size = new System.Drawing.Size(50, 20);
            this.txtComo.TabIndex = 10;
            this.txtComo.Text = "textBox1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(692, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Como:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbNorma
            // 
            this.cbNorma.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbNorma.Checked = true;
            this.cbNorma.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNorma.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsTabiqueMdor1, "TabiqueMdor.Norma", true));
            this.cbNorma.Location = new System.Drawing.Point(586, 56);
            this.cbNorma.Name = "cbNorma";
            this.cbNorma.Size = new System.Drawing.Size(104, 24);
            this.cbNorma.TabIndex = 8;
            this.cbNorma.Text = "NMX-C-404";
            this.cbNorma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbCumple
            // 
            this.cbCumple.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbCumple.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsTabiqueMdor1, "TabiqueMdor.Cumple", true));
            this.cbCumple.Location = new System.Drawing.Point(570, 82);
            this.cbCumple.Name = "cbCumple";
            this.cbCumple.Size = new System.Drawing.Size(120, 24);
            this.cbCumple.TabIndex = 9;
            this.cbCumple.Text = "Si cumple la norma";
            this.cbCumple.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbUnidad
            // 
            this.cbUnidad.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbUnidad.Checked = true;
            this.cbUnidad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUnidad.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsTabiqueMdor1, "TabiqueMdor.Unidad", true));
            this.cbUnidad.Location = new System.Drawing.Point(562, 30);
            this.cbUnidad.Name = "cbUnidad";
            this.cbUnidad.Size = new System.Drawing.Size(128, 24);
            this.cbUnidad.TabIndex = 7;
            this.cbUnidad.Text = "Absorción en dm³/m³";
            this.cbUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbMreducida
            // 
            this.cbMreducida.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbMreducida.Checked = true;
            this.cbMreducida.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMreducida.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsTabiqueMdor1, "TabiqueMdor.MReducida", true));
            this.cbMreducida.Location = new System.Drawing.Point(578, 4);
            this.cbMreducida.Name = "cbMreducida";
            this.cbMreducida.Size = new System.Drawing.Size(112, 24);
            this.cbMreducida.TabIndex = 6;
            this.cbMreducida.Text = "Muestra reducida";
            this.cbMreducida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtObserva
            // 
            this.txtObserva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabiqueMdor1, "TabiqueMdor.Observaciones", true));
            this.txtObserva.Location = new System.Drawing.Point(256, 114);
            this.txtObserva.MaxLength = 512;
            this.txtObserva.Multiline = true;
            this.txtObserva.Name = "txtObserva";
            this.txtObserva.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObserva.Size = new System.Drawing.Size(684, 48);
            this.txtObserva.TabIndex = 5;
            this.txtObserva.Text = "textBox5";
            this.txtObserva.TextChanged += new System.EventHandler(this.txtObserva_TextChanged);
            // 
            // txtSemana
            // 
            this.txtSemana.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabiqueMdor1, "TabiqueMdor.Semana", true));
            this.txtSemana.Location = new System.Drawing.Point(514, 10);
            this.txtSemana.MaxLength = 2;
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(46, 20);
            this.txtSemana.TabIndex = 3;
            this.txtSemana.Text = "textBox3";
            // 
            // cmbNoeco
            // 
            this.cmbNoeco.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsTabiqueMdor1, "TabiqueMdor.NoEco", true));
            this.cmbNoeco.DataSource = this.dsLaboratorista1.Laboratorista;
            this.cmbNoeco.DisplayMember = "Laboratorista";
            this.cmbNoeco.Location = new System.Drawing.Point(254, 34);
            this.cmbNoeco.Name = "cmbNoeco";
            this.cmbNoeco.Size = new System.Drawing.Size(306, 21);
            this.cmbNoeco.TabIndex = 4;
            this.cmbNoeco.ValueMember = "NoEco";
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabiqueMdor1, "TabiqueMdor.ConsObra", true));
            this.txtConsecutivo.Location = new System.Drawing.Point(396, 10);
            this.txtConsecutivo.MaxLength = 4;
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(66, 20);
            this.txtConsecutivo.TabIndex = 2;
            this.txtConsecutivo.Text = "textBox2";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsTabiqueMdor1, "TabiqueMdor.IdObra", true));
            this.cmbIdObra.DataSource = this.dsBusObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(254, 10);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(66, 21);
            this.cmbIdObra.TabIndex = 1;
            this.cmbIdObra.ValueMember = "Obra.Idobra";
            // 
            // txtFolio
            // 
            this.txtFolio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabiqueMdor1, "TabiqueMdor.FOLIO", true));
            this.txtFolio.Location = new System.Drawing.Point(46, 22);
            this.txtFolio.MaxLength = 10;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(64, 20);
            this.txtFolio.TabIndex = 0;
            this.txtFolio.Text = "textBox1";
            this.txtFolio.TextChanged += new System.EventHandler(this.txtFolio_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Observaciones:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Semana:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ensayado por:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Consecutivo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Obra:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "FOLIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Fecha muestreo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(700, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fecha informe:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFensaye
            // 
            this.dtpFensaye.CustomFormat = "dd/MM/yyyy";
            this.dtpFensaye.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabiqueMdor1, "TabiqueMdor.FEnsaye", true));
            this.dtpFensaye.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFensaye.Location = new System.Drawing.Point(780, 58);
            this.dtpFensaye.Name = "dtpFensaye";
            this.dtpFensaye.Size = new System.Drawing.Size(84, 20);
            this.dtpFensaye.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(702, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Fecha ensaye:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFinforme
            // 
            this.dtpFinforme.CustomFormat = "dd/MM/yyyy";
            this.dtpFinforme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTabiqueMdor1, "TabiqueMdor.FInforme", true));
            this.dtpFinforme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinforme.Location = new System.Drawing.Point(780, 84);
            this.dtpFinforme.Name = "dtpFinforme";
            this.dtpFinforme.Size = new System.Drawing.Size(84, 20);
            this.dtpFinforme.TabIndex = 14;
            // 
            // dsAcero1
            // 
            this.dsAcero1.DataSetName = "dsAcero";
            this.dsAcero1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsAcero1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDATabiqueRes
            // 
            this.sqlDATabiqueRes.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDATabiqueRes.InsertCommand = this.sqlInsertCommand2;
            this.sqlDATabiqueRes.SelectCommand = this.sqlSelectCommand2;
            this.sqlDATabiqueRes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "TabiqueRes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("MUESTRA", "MUESTRA"),
                        new System.Data.Common.DataColumnMapping("TMuestra", "TMuestra"),
                        new System.Data.Common.DataColumnMapping("Largo", "Largo"),
                        new System.Data.Common.DataColumnMapping("Ancho", "Ancho"),
                        new System.Data.Common.DataColumnMapping("Peralte", "Peralte"),
                        new System.Data.Common.DataColumnMapping("Masa", "Masa"),
                        new System.Data.Common.DataColumnMapping("Area", "Area"),
                        new System.Data.Common.DataColumnMapping("RcAInd", "RcAInd"),
                        new System.Data.Common.DataColumnMapping("RcAPro", "RcAPro"),
                        new System.Data.Common.DataColumnMapping("EspInd", "EspInd"),
                        new System.Data.Common.DataColumnMapping("EspPro", "EspPro")})});
            this.sqlDATabiqueRes.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConn;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_MUESTRA", System.Data.SqlDbType.SmallInt, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MUESTRA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ancho", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(8)), ((byte)(3)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EspInd", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "EspInd", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EspPro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "EspPro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Largo", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Largo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Peralte", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Peralte", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RcAInd", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "RcAInd", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RcAPro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "RcAPro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_TMuestra", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TMuestra", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConn;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@MUESTRA", System.Data.SqlDbType.SmallInt, 4, "MUESTRA"),
            new System.Data.SqlClient.SqlParameter("@TMuestra", System.Data.SqlDbType.Bit, 1, "TMuestra"),
            new System.Data.SqlClient.SqlParameter("@Largo", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Largo", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Ancho", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Peralte", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Peralte", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(8)), ((byte)(3)), "Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@RcAInd", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "RcAInd", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@RcAPro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "RcAPro", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EspInd", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "EspInd", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EspPro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "EspPro", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT FOLIO, MUESTRA, TMuestra, Largo, Ancho, Peralte, Masa, Area, RcAInd, RcAPr" +
                "o, EspInd, EspPro FROM TabiqueRes WHERE (FOLIO = @Folio)";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.VarChar, 10, "FOLIO")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConn;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@MUESTRA", System.Data.SqlDbType.SmallInt, 4, "MUESTRA"),
            new System.Data.SqlClient.SqlParameter("@TMuestra", System.Data.SqlDbType.Bit, 1, "TMuestra"),
            new System.Data.SqlClient.SqlParameter("@Largo", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Largo", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Ancho", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Peralte", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Peralte", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(8)), ((byte)(3)), "Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@RcAInd", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "RcAInd", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@RcAPro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "RcAPro", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EspInd", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "EspInd", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EspPro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "EspPro", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_MUESTRA", System.Data.SqlDbType.SmallInt, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MUESTRA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ancho", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(8)), ((byte)(3)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EspInd", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "EspInd", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EspPro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "EspPro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Largo", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Largo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Peralte", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Peralte", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RcAInd", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "RcAInd", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RcAPro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(1)), "RcAPro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_TMuestra", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TMuestra", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDATabiqueMdor
            // 
            this.sqlDATabiqueMdor.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDATabiqueMdor.InsertCommand = this.sqlInsertCommand1;
            this.sqlDATabiqueMdor.SelectCommand = this.sqlSelectCommand1;
            this.sqlDATabiqueMdor.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "TabiqueMdor", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("FMuestreo", "FMuestreo"),
                        new System.Data.Common.DataColumnMapping("FEnsaye", "FEnsaye"),
                        new System.Data.Common.DataColumnMapping("FInforme", "FInforme"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("MReducida", "MReducida"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("Cumple", "Cumple"),
                        new System.Data.Common.DataColumnMapping("Norma", "Norma"),
                        new System.Data.Common.DataColumnMapping("Como", "Como"),
                        new System.Data.Common.DataColumnMapping("ObsComo", "ObsComo"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Subtipo", "Subtipo"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("Empleado", "Empleado"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"),
                        new System.Data.Common.DataColumnMapping("Largo", "Largo"),
                        new System.Data.Common.DataColumnMapping("Ancho", "Ancho"),
                        new System.Data.Common.DataColumnMapping("Peralte", "Peralte")})});
            this.sqlDATabiqueMdor.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ancho", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Como", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Como", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ConsObra", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Cumple", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cumple", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Empleado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Empleado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FEnsaye", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FEnsaye", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FInforme", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FInforme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FMuestreo", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FMuestreo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Largo", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Largo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_MReducida", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MReducida", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Norma", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Norma", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ObsComo", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ObsComo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 512, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Peralte", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Peralte", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Subtipo", System.Data.SqlDbType.NVarChar, 128, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Subtipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Unidad", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Unidad", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@ConsObra", System.Data.SqlDbType.SmallInt, 2, "ConsObra"),
            new System.Data.SqlClient.SqlParameter("@FMuestreo", System.Data.SqlDbType.DateTime, 4, "FMuestreo"),
            new System.Data.SqlClient.SqlParameter("@FEnsaye", System.Data.SqlDbType.DateTime, 4, "FEnsaye"),
            new System.Data.SqlClient.SqlParameter("@FInforme", System.Data.SqlDbType.DateTime, 4, "FInforme"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 2, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 2, "Semana"),
            new System.Data.SqlClient.SqlParameter("@MReducida", System.Data.SqlDbType.Bit, 1, "MReducida"),
            new System.Data.SqlClient.SqlParameter("@Unidad", System.Data.SqlDbType.Bit, 1, "Unidad"),
            new System.Data.SqlClient.SqlParameter("@Cumple", System.Data.SqlDbType.Bit, 1, "Cumple"),
            new System.Data.SqlClient.SqlParameter("@Norma", System.Data.SqlDbType.Bit, 1, "Norma"),
            new System.Data.SqlClient.SqlParameter("@Como", System.Data.SqlDbType.NVarChar, 15, "Como"),
            new System.Data.SqlClient.SqlParameter("@ObsComo", System.Data.SqlDbType.NVarChar, 50, "ObsComo"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.NVarChar, 15, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@Subtipo", System.Data.SqlDbType.NVarChar, 128, "Subtipo"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 15, "Grado"),
            new System.Data.SqlClient.SqlParameter("@Empleado", System.Data.SqlDbType.Bit, 1, "Empleado"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 512, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@Largo", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Largo", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Ancho", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Peralte", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Peralte", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@ConsObra", System.Data.SqlDbType.SmallInt, 2, "ConsObra"),
            new System.Data.SqlClient.SqlParameter("@FMuestreo", System.Data.SqlDbType.DateTime, 4, "FMuestreo"),
            new System.Data.SqlClient.SqlParameter("@FEnsaye", System.Data.SqlDbType.DateTime, 4, "FEnsaye"),
            new System.Data.SqlClient.SqlParameter("@FInforme", System.Data.SqlDbType.DateTime, 4, "FInforme"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 2, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 2, "Semana"),
            new System.Data.SqlClient.SqlParameter("@MReducida", System.Data.SqlDbType.Bit, 1, "MReducida"),
            new System.Data.SqlClient.SqlParameter("@Unidad", System.Data.SqlDbType.Bit, 1, "Unidad"),
            new System.Data.SqlClient.SqlParameter("@Cumple", System.Data.SqlDbType.Bit, 1, "Cumple"),
            new System.Data.SqlClient.SqlParameter("@Norma", System.Data.SqlDbType.Bit, 1, "Norma"),
            new System.Data.SqlClient.SqlParameter("@Como", System.Data.SqlDbType.NVarChar, 15, "Como"),
            new System.Data.SqlClient.SqlParameter("@ObsComo", System.Data.SqlDbType.NVarChar, 50, "ObsComo"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.NVarChar, 15, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@Subtipo", System.Data.SqlDbType.NVarChar, 128, "Subtipo"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 15, "Grado"),
            new System.Data.SqlClient.SqlParameter("@Empleado", System.Data.SqlDbType.Bit, 1, "Empleado"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 512, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@Largo", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Largo", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Ancho", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Peralte", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Peralte", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ancho", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Como", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Como", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ConsObra", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Cumple", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cumple", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Empleado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Empleado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FEnsaye", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FEnsaye", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FInforme", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FInforme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FMuestreo", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FMuestreo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Largo", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Largo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_MReducida", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MReducida", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Norma", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Norma", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ObsComo", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ObsComo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 512, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Peralte", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Peralte", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Subtipo", System.Data.SqlDbType.NVarChar, 128, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Subtipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Unidad", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Unidad", System.Data.DataRowVersion.Original, null)});
            // 
            // dgTabique
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgTabique.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTabique.AutoGenerateColumns = false;
            this.dgTabique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabique.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fOLIODataGridViewTextBoxColumn,
            this.mUESTRADataGridViewTextBoxColumn,
            this.tMuestraDataGridViewCheckBoxColumn,
            this.largoDataGridViewTextBoxColumn,
            this.anchoDataGridViewTextBoxColumn,
            this.peralteDataGridViewTextBoxColumn,
            this.masaDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.rcAIndDataGridViewTextBoxColumn,
            this.rcAProDataGridViewTextBoxColumn,
            this.espIndDataGridViewTextBoxColumn,
            this.espProDataGridViewTextBoxColumn});
            this.dgTabique.DataMember = "TabiqueMdor.Tabique";
            this.dgTabique.DataSource = this.dsTabiqueMdor1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTabique.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgTabique.Location = new System.Drawing.Point(72, 260);
            this.dgTabique.Name = "dgTabique";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgTabique.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgTabique.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgTabique.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgTabique.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgTabique.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgTabique.Size = new System.Drawing.Size(892, 376);
            this.dgTabique.TabIndex = 7;
            // 
            // fOLIODataGridViewTextBoxColumn
            // 
            this.fOLIODataGridViewTextBoxColumn.DataPropertyName = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.HeaderText = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.Name = "fOLIODataGridViewTextBoxColumn";
            this.fOLIODataGridViewTextBoxColumn.Visible = false;
            this.fOLIODataGridViewTextBoxColumn.Width = 5;
            // 
            // mUESTRADataGridViewTextBoxColumn
            // 
            this.mUESTRADataGridViewTextBoxColumn.DataPropertyName = "MUESTRA";
            this.mUESTRADataGridViewTextBoxColumn.HeaderText = "MUESTRA";
            this.mUESTRADataGridViewTextBoxColumn.Name = "mUESTRADataGridViewTextBoxColumn";
            this.mUESTRADataGridViewTextBoxColumn.Width = 75;
            // 
            // tMuestraDataGridViewCheckBoxColumn
            // 
            this.tMuestraDataGridViewCheckBoxColumn.DataPropertyName = "TMuestra";
            this.tMuestraDataGridViewCheckBoxColumn.HeaderText = "¿Compresión?";
            this.tMuestraDataGridViewCheckBoxColumn.Name = "tMuestraDataGridViewCheckBoxColumn";
            this.tMuestraDataGridViewCheckBoxColumn.Width = 80;
            // 
            // largoDataGridViewTextBoxColumn
            // 
            this.largoDataGridViewTextBoxColumn.DataPropertyName = "Largo";
            this.largoDataGridViewTextBoxColumn.HeaderText = "Largo";
            this.largoDataGridViewTextBoxColumn.Name = "largoDataGridViewTextBoxColumn";
            this.largoDataGridViewTextBoxColumn.Width = 75;
            // 
            // anchoDataGridViewTextBoxColumn
            // 
            this.anchoDataGridViewTextBoxColumn.DataPropertyName = "Ancho";
            this.anchoDataGridViewTextBoxColumn.HeaderText = "Ancho";
            this.anchoDataGridViewTextBoxColumn.Name = "anchoDataGridViewTextBoxColumn";
            this.anchoDataGridViewTextBoxColumn.Width = 75;
            // 
            // peralteDataGridViewTextBoxColumn
            // 
            this.peralteDataGridViewTextBoxColumn.DataPropertyName = "Peralte";
            this.peralteDataGridViewTextBoxColumn.HeaderText = "Peralte";
            this.peralteDataGridViewTextBoxColumn.Name = "peralteDataGridViewTextBoxColumn";
            this.peralteDataGridViewTextBoxColumn.Width = 75;
            // 
            // masaDataGridViewTextBoxColumn
            // 
            this.masaDataGridViewTextBoxColumn.DataPropertyName = "Masa";
            this.masaDataGridViewTextBoxColumn.HeaderText = "Masa";
            this.masaDataGridViewTextBoxColumn.Name = "masaDataGridViewTextBoxColumn";
            this.masaDataGridViewTextBoxColumn.Width = 75;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.Width = 75;
            // 
            // rcAIndDataGridViewTextBoxColumn
            // 
            this.rcAIndDataGridViewTextBoxColumn.DataPropertyName = "RcAInd";
            this.rcAIndDataGridViewTextBoxColumn.HeaderText = "Individual";
            this.rcAIndDataGridViewTextBoxColumn.Name = "rcAIndDataGridViewTextBoxColumn";
            this.rcAIndDataGridViewTextBoxColumn.Width = 75;
            // 
            // rcAProDataGridViewTextBoxColumn
            // 
            this.rcAProDataGridViewTextBoxColumn.DataPropertyName = "RcAPro";
            this.rcAProDataGridViewTextBoxColumn.HeaderText = "Promedio";
            this.rcAProDataGridViewTextBoxColumn.Name = "rcAProDataGridViewTextBoxColumn";
            this.rcAProDataGridViewTextBoxColumn.Width = 75;
            // 
            // espIndDataGridViewTextBoxColumn
            // 
            this.espIndDataGridViewTextBoxColumn.DataPropertyName = "EspInd";
            this.espIndDataGridViewTextBoxColumn.HeaderText = "E. Individual";
            this.espIndDataGridViewTextBoxColumn.Name = "espIndDataGridViewTextBoxColumn";
            this.espIndDataGridViewTextBoxColumn.Width = 75;
            // 
            // espProDataGridViewTextBoxColumn
            // 
            this.espProDataGridViewTextBoxColumn.DataPropertyName = "EspPro";
            this.espProDataGridViewTextBoxColumn.HeaderText = "E. Promedios";
            this.espProDataGridViewTextBoxColumn.Name = "espProDataGridViewTextBoxColumn";
            this.espProDataGridViewTextBoxColumn.Width = 75;
            // 
            // TabiqueMdos
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1022, 667);
            this.Controls.Add(this.dgTabique);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDATabiqueMdor;
            this.dsGeneral = this.dsTabiqueMdor1;
            this.Name = "TabiqueMdos";
            this.NombreTabla = "TabiqueMdor";
            this.Text = "TabiqueMdos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TabiqueMdos_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgTabique, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTabiqueMdor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabique)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void TabiqueMdos_Load(object sender, System.EventArgs e)
		{
			buscaBtn1.Catalogo = this;
			sqlDABusObra.Fill(dsBusObra1,"Obra");
			sqlDALaboratorista.Fill(dsLaboratorista1,"Laboratorista");
		}
		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			dsTabiqueMdor1.TabiqueMdor.MReducidaColumn.DefaultValue = 1;
			dsTabiqueMdor1.TabiqueMdor.UnidadColumn.DefaultValue = 1;
			dsTabiqueMdor1.TabiqueMdor.CumpleColumn.DefaultValue = 0;
			dsTabiqueMdor1.TabiqueMdor.NormaColumn.DefaultValue = 1;
			dsTabiqueMdor1.TabiqueMdor.EmpleadoColumn.DefaultValue = 0;
			base.btnNuevo_Click(sender, e);
			cmbIdObra.SelectedIndex = -1;
			cmbNoeco.SelectedIndex = -1;
			dtpFmuestreo.Value = DateTime.Now.AddDays(1);
			dtpFmuestreo.Value = DateTime.Today; 
			dtpFensaye.Value = DateTime.Now.AddDays(1);
			dtpFensaye.Value = DateTime.Today; 
			dtpFinforme.Value = DateTime.Now.AddDays(1);
			dtpFinforme.Value = DateTime.Today;
		}
		protected override void btnGuardar_Click(object sender, System.EventArgs e)
		{
			try 
			{
				// Intente actualizar el origen de datos.
				base.BindingContext[dsTabiqueMdor1,"TabiqueMdor"].Position = this.BindingContext[dsTabiqueMdor1,"TabiqueMdor"].Position;
				this.UpdateDataSet1();
				base.dsGeneral_PositionChanged();
			}
			catch (System.Exception eUpdate) 
			{
				statusBar1.Panels[2].Text = eUpdate.Message;	
				statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
				statusBar1.Panels[2].ToolTipText = eUpdate.Message;
			}
			dsTabiqueMdor1.Tables["TabiqueRes"].Clear();
			sqlDATabiqueRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDATabiqueRes.Fill(dsTabiqueMdor1,"TabiqueRes");
		}

		public override void LoadDataSet()
		{

//			sqlDATabiqueRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			base.LoadDataSet();
//			dgTabique.SetDataBinding(dsTabiqueMdor1, "TabiqueMdor.Tabique");
//			string apl = dgTabique.TableStyles.ToString();
			dsTabiqueMdor1.Tables["TabiqueRes"].Clear();
			sqlDATabiqueRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDATabiqueRes.Fill(dsTabiqueMdor1,"TabiqueRes");
		}

		private void UpdateDataSet1()
		{
			// Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
			// original			DataSet objDataSetChanges = new DataSet();
			LancNeo.dsTabiqueMdor objDataSetChanges = new LancNeo.dsTabiqueMdor();
			// Detener las ediciones actuales.
			// original			this.BindingContext[dsgeneral].EndCurrentEdit();
			this.BindingContext[dsTabiqueMdor1,"TabiqueMdor"].EndCurrentEdit();
			this.BindingContext[dsTabiqueMdor1,"TabiqueRes"].EndCurrentEdit();

			// Obtener los cambios realizados en el conjunto de datos principal.
			// original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));

			objDataSetChanges = ((LancNeo.dsTabiqueMdor)(dsTabiqueMdor1.GetChanges()));

			// Comprobar si se han realizado cambios.
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
					// llamando al método de actualización y pasando el conjunto de datos y los parámetros.
					this.UpdateDataSource1(objDataSetChanges);
					dsTabiqueMdor1.Merge(objDataSetChanges);
					dsTabiqueMdor1.AcceptChanges();
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
		private void UpdateDataSource1(LancNeo.dsTabiqueMdor ChangedRows)
		{
			try 
			{
				// Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
				if ((ChangedRows != null)) 
				{
					// Abra la conexión.
					this.sqlConn.Open();
					// Intente actualizar el origen de datos.
					sqlDATabiqueMdor.Update(ChangedRows);
					sqlDATabiqueRes.Update(ChangedRows);
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

		private void textBox2_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void textBox3_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void label10_Click(object sender, System.EventArgs e)
		{
		
		}

		private void txtObserva_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void txtFolio_TextChanged(object sender, System.EventArgs e)
		{
			dsTabiqueMdor1.Tables["TabiqueRes"].Clear();
			sqlDATabiqueRes.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDATabiqueRes.Fill(dsTabiqueMdor1,"TabiqueRes");
		}
	}
}
