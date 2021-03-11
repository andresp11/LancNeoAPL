using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;
using System.Data;
using System.Data.SqlClient;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de PlacAceEsp.
	/// </summary>
	public class PlacAceEsp : CatalogoGenerico
	{
        private string IdUsuario;

        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtAltura;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtSepara;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtAlarga;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtEsMax;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtEsLE;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtmasa;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbNumero;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEspec;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox textBox1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPlacAceEsp;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Data.SqlClient.SqlDataAdapter sqlDAAcero;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private LancNeo.dsAcero dsAcero1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPlacAceRes;
		private LancNeo.dsPlacAceEsp dsPlacAceEsp1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private DataGridView dgPlacAceEns;
        private DataGridViewTextBoxColumn fOLIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn especificaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn muestraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn espesorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anchoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargaLEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargaMaxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn esfuerzoLEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn esfuerzoMaxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alargamiento20DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alargamiento5DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coladaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remesaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private TextBox txtUsrMov;
        private Label label28;

        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public PlacAceEsp()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlacAceEsp));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsPlacAceEsp1 = new LancNeo.dsPlacAceEsp();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSepara = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAlarga = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEsMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEsLE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmasa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNumero = new System.Windows.Forms.ComboBox();
            this.dsAcero1 = new LancNeo.dsAcero();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEspec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlDAPlacAceEsp = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAAcero = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAPlacAceRes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dgPlacAceEns = new System.Windows.Forms.DataGridView();
            this.fOLIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especificaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muestraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espesorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anchoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esfuerzoLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esfuerzoMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alargamiento20DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alargamiento5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coladaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUsrMov = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlacAceEsp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlacAceEns)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 511);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1016, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(1016, 64);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.txtUsrMov);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.txtAltura);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtSepara);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtAlarga);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtEsMax);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtEsLE);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtmasa);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbNumero);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtEspec);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtFolio);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-4, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 96);
            this.panel2.TabIndex = 6;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 675;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsPlacAceEsp1.PlacAceEsp;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(98, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 41;
            // 
            // dsPlacAceEsp1
            // 
            this.dsPlacAceEsp1.DataSetName = "dsPlacAceEsp";
            this.dsPlacAceEsp1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsPlacAceEsp1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPlacAceEsp1, "PlacAceEsp.Alargamiento20", true));
            this.textBox1.Location = new System.Drawing.Point(932, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "textBox1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(856, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 13);
            this.label24.TabIndex = 38;
            this.label24.Text = "Alargamiento20:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Gold;
            this.label22.Location = new System.Drawing.Point(194, -4);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(144, 20);
            this.label22.TabIndex = 35;
            this.label22.Text = "Especificación";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAltura
            // 
            this.txtAltura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPlacAceEsp1, "PlacAceEsp.Producto", true));
            this.txtAltura.Location = new System.Drawing.Point(180, 70);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(42, 20);
            this.txtAltura.TabIndex = 24;
            this.txtAltura.Text = "textBox9";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(130, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Producto:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(798, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Max (Kg/Cm²)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(690, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = " Max (Kg/cm²)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(590, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Flu (Kg/cm²)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSepara
            // 
            this.txtSepara.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPlacAceEsp1, "PlacAceEsp.Alargamiento5", true));
            this.txtSepara.Location = new System.Drawing.Point(84, 70);
            this.txtSepara.Name = "txtSepara";
            this.txtSepara.Size = new System.Drawing.Size(44, 20);
            this.txtSepara.TabIndex = 17;
            this.txtSepara.Text = "textBox8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Alargamiento5o:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAlarga
            // 
            this.txtAlarga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPlacAceEsp1, "PlacAceEsp.EsfuerzoMax2", true));
            this.txtAlarga.Location = new System.Drawing.Point(798, 16);
            this.txtAlarga.Name = "txtAlarga";
            this.txtAlarga.Size = new System.Drawing.Size(52, 20);
            this.txtAlarga.TabIndex = 15;
            this.txtAlarga.Text = "textBox7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(752, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Esfuerzo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEsMax
            // 
            this.txtEsMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPlacAceEsp1, "PlacAceEsp.EsfuerzoMax1", true));
            this.txtEsMax.Location = new System.Drawing.Point(694, 16);
            this.txtEsMax.Name = "txtEsMax";
            this.txtEsMax.Size = new System.Drawing.Size(56, 20);
            this.txtEsMax.TabIndex = 13;
            this.txtEsMax.Text = "textBox6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(650, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Esfuerzo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEsLE
            // 
            this.txtEsLE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPlacAceEsp1, "PlacAceEsp.EsfuerzoLE", true));
            this.txtEsLE.Location = new System.Drawing.Point(590, 16);
            this.txtEsLE.Name = "txtEsLE";
            this.txtEsLE.Size = new System.Drawing.Size(56, 20);
            this.txtEsLE.TabIndex = 11;
            this.txtEsLE.Text = "textBox5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(544, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Esfuerzo:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtmasa
            // 
            this.txtmasa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPlacAceEsp1, "PlacAceEsp.TAcero", true));
            this.txtmasa.Location = new System.Drawing.Point(492, 16);
            this.txtmasa.Name = "txtmasa";
            this.txtmasa.Size = new System.Drawing.Size(48, 20);
            this.txtmasa.TabIndex = 9;
            this.txtmasa.Text = "textBox4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de acero:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbNumero
            // 
            this.cmbNumero.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsPlacAceEsp1, "PlacAceRes.Muestra", true));
            this.cmbNumero.DataSource = this.dsAcero1.Acero;
            this.cmbNumero.DisplayMember = "Numero";
            this.cmbNumero.Location = new System.Drawing.Point(346, 16);
            this.cmbNumero.Name = "cmbNumero";
            this.cmbNumero.Size = new System.Drawing.Size(80, 21);
            this.cmbNumero.TabIndex = 5;
            this.cmbNumero.ValueMember = "Numero";
            // 
            // dsAcero1
            // 
            this.dsAcero1.DataSetName = "dsAcero";
            this.dsAcero1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsAcero1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Diámetro:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEspec
            // 
            this.txtEspec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPlacAceEsp1, "PlacAceEsp.Especifica", true));
            this.txtEspec.Location = new System.Drawing.Point(264, 16);
            this.txtEspec.Name = "txtEspec";
            this.txtEspec.Size = new System.Drawing.Size(24, 20);
            this.txtEspec.TabIndex = 3;
            this.txtEspec.Text = "textBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N° Especificación:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFolio
            // 
            this.txtFolio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPlacAceEsp1, "PlacAceEsp.FOLIO", true));
            this.txtFolio.Location = new System.Drawing.Point(48, 16);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(48, 20);
            this.txtFolio.TabIndex = 1;
            this.txtFolio.Text = "textBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOLIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sqlDAPlacAceEsp
            // 
            this.sqlDAPlacAceEsp.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAPlacAceEsp.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAPlacAceEsp.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAPlacAceEsp.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PlacAceEsp", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("Especifica", "Especifica"),
                        new System.Data.Common.DataColumnMapping("Nominal", "Nominal"),
                        new System.Data.Common.DataColumnMapping("TAcero", "TAcero"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoLE", "EsfuerzoLE"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoMax1", "EsfuerzoMax1"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoMax2", "EsfuerzoMax2"),
                        new System.Data.Common.DataColumnMapping("Alargamiento20", "Alargamiento20"),
                        new System.Data.Common.DataColumnMapping("Alargamiento5", "Alargamiento5"),
                        new System.Data.Common.DataColumnMapping("Producto", "Producto"),
                        new System.Data.Common.DataColumnMapping("IdUsuario", "IdUsuario")})});
            this.sqlDAPlacAceEsp.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Nominal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nominal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Nominal", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nominal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TAcero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TAcero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TAcero", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TAcero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoLE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoLE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoLE", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EsfuerzoLE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoMax1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoMax1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMax1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EsfuerzoMax1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoMax2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoMax2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMax2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EsfuerzoMax2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Alargamiento20", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Alargamiento20", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento20", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento20", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Alargamiento5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Alargamiento5", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento5", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento5", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Producto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Producto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Producto", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Producto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.Char, 0, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Especifica", System.Data.SqlDbType.SmallInt, 0, "Especifica"),
            new System.Data.SqlClient.SqlParameter("@Nominal", System.Data.SqlDbType.NVarChar, 0, "Nominal"),
            new System.Data.SqlClient.SqlParameter("@TAcero", System.Data.SqlDbType.NVarChar, 0, "TAcero"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoLE", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EsfuerzoLE", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMax1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EsfuerzoMax1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMax2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EsfuerzoMax2", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento20", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento20", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento5", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento5", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Producto", System.Data.SqlDbType.NVarChar, 0, "Producto"),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        FOLIO, Especifica, Nominal, TAcero, EsfuerzoLE, EsfuerzoMax1, Esfue" +
    "rzoMax2, Alargamiento20, Alargamiento5, Producto, IdUsuario\r\nFROM            Pla" +
    "cAceEsp\r\nORDER BY Especifica, FOLIO";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.Char, 0, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Especifica", System.Data.SqlDbType.SmallInt, 0, "Especifica"),
            new System.Data.SqlClient.SqlParameter("@Nominal", System.Data.SqlDbType.NVarChar, 0, "Nominal"),
            new System.Data.SqlClient.SqlParameter("@TAcero", System.Data.SqlDbType.NVarChar, 0, "TAcero"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoLE", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EsfuerzoLE", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMax1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EsfuerzoMax1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMax2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EsfuerzoMax2", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento20", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento20", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento5", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento5", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Producto", System.Data.SqlDbType.NVarChar, 0, "Producto"),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario"),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Nominal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nominal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Nominal", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nominal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TAcero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TAcero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TAcero", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TAcero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoLE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoLE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoLE", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EsfuerzoLE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoMax1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoMax1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMax1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EsfuerzoMax1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoMax2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoMax2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMax2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "EsfuerzoMax2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Alargamiento20", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Alargamiento20", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento20", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento20", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Alargamiento5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Alargamiento5", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento5", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento5", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Producto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Producto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Producto", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Producto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDAAcero
            // 
            this.sqlDAAcero.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAAcero.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Acero", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Numero", "Numero"),
                        new System.Data.Common.DataColumnMapping("Nominal", "Nominal"),
                        new System.Data.Common.DataColumnMapping("Milimetros", "Milimetros"),
                        new System.Data.Common.DataColumnMapping("Clasificacion", "Clasificacion")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT Numero, Nominal, Milimetros, Clasificacion FROM Acero ORDER BY Numero";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            // 
            // sqlDAPlacAceRes
            // 
            this.sqlDAPlacAceRes.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDAPlacAceRes.InsertCommand = this.sqlInsertCommand2;
            this.sqlDAPlacAceRes.SelectCommand = this.sqlSelectCommand3;
            this.sqlDAPlacAceRes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PlacAceRes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("Especifica", "Especifica"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Espesor", "Espesor"),
                        new System.Data.Common.DataColumnMapping("Ancho", "Ancho"),
                        new System.Data.Common.DataColumnMapping("Area", "Area"),
                        new System.Data.Common.DataColumnMapping("CargaLE", "CargaLE"),
                        new System.Data.Common.DataColumnMapping("CargaMax", "CargaMax"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoLE", "EsfuerzoLE"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoMax", "EsfuerzoMax"),
                        new System.Data.Common.DataColumnMapping("Alargamiento20", "Alargamiento20"),
                        new System.Data.Common.DataColumnMapping("Alargamiento5", "Alargamiento5"),
                        new System.Data.Common.DataColumnMapping("Colada", "Colada"),
                        new System.Data.Common.DataColumnMapping("Remesa", "Remesa"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})});
            this.sqlDAPlacAceRes.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConn;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento20", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento20", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento5", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento5", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ancho", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaLE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaLE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Colada", System.Data.SqlDbType.NVarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Colada", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoLE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoLE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Espesor", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Espesor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Remesa", System.Data.SqlDbType.NVarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Remesa", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConn;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Especifica", System.Data.SqlDbType.SmallInt, 2, "Especifica"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.SmallInt, 2, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@Espesor", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Espesor", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Ancho", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaLE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaLE", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoLE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoLE", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento20", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento20", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento5", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento5", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Colada", System.Data.SqlDbType.NVarChar, 12, "Colada"),
            new System.Data.SqlClient.SqlParameter("@Remesa", System.Data.SqlDbType.NVarChar, 12, "Remesa"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 50, "Observaciones")});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = resources.GetString("sqlSelectCommand3.CommandText");
            this.sqlSelectCommand3.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConn;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Especifica", System.Data.SqlDbType.SmallInt, 2, "Especifica"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.SmallInt, 2, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@Espesor", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Espesor", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Ancho", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaLE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaLE", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoLE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoLE", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento20", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento20", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento5", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento5", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Colada", System.Data.SqlDbType.NVarChar, 12, "Colada"),
            new System.Data.SqlClient.SqlParameter("@Remesa", System.Data.SqlDbType.NVarChar, 12, "Remesa"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 50, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento20", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento20", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento5", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento5", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ancho", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Ancho", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaLE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaLE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Colada", System.Data.SqlDbType.NVarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Colada", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoLE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoLE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "EsfuerzoMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Espesor", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(5)), ((byte)(2)), "Espesor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Remesa", System.Data.SqlDbType.NVarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Remesa", System.Data.DataRowVersion.Original, null)});
            // 
            // dgPlacAceEns
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgPlacAceEns.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgPlacAceEns.AutoGenerateColumns = false;
            this.dgPlacAceEns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlacAceEns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fOLIODataGridViewTextBoxColumn,
            this.especificaDataGridViewTextBoxColumn,
            this.muestraDataGridViewTextBoxColumn,
            this.espesorDataGridViewTextBoxColumn,
            this.anchoDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.cargaLEDataGridViewTextBoxColumn,
            this.cargaMaxDataGridViewTextBoxColumn,
            this.esfuerzoLEDataGridViewTextBoxColumn,
            this.esfuerzoMaxDataGridViewTextBoxColumn,
            this.alargamiento20DataGridViewTextBoxColumn,
            this.alargamiento5DataGridViewTextBoxColumn,
            this.coladaDataGridViewTextBoxColumn,
            this.remesaDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dgPlacAceEns.DataMember = "PlacAceEsp.PlacAce";
            this.dgPlacAceEns.DataSource = this.dsPlacAceEsp1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPlacAceEns.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgPlacAceEns.Location = new System.Drawing.Point(0, 168);
            this.dgPlacAceEns.Name = "dgPlacAceEns";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgPlacAceEns.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgPlacAceEns.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgPlacAceEns.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgPlacAceEns.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgPlacAceEns.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgPlacAceEns.Size = new System.Drawing.Size(1016, 336);
            this.dgPlacAceEns.TabIndex = 7;
            // 
            // fOLIODataGridViewTextBoxColumn
            // 
            this.fOLIODataGridViewTextBoxColumn.DataPropertyName = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.HeaderText = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.Name = "fOLIODataGridViewTextBoxColumn";
            this.fOLIODataGridViewTextBoxColumn.Visible = false;
            // 
            // especificaDataGridViewTextBoxColumn
            // 
            this.especificaDataGridViewTextBoxColumn.DataPropertyName = "Especifica";
            this.especificaDataGridViewTextBoxColumn.HeaderText = "Especifica";
            this.especificaDataGridViewTextBoxColumn.Name = "especificaDataGridViewTextBoxColumn";
            this.especificaDataGridViewTextBoxColumn.Visible = false;
            // 
            // muestraDataGridViewTextBoxColumn
            // 
            this.muestraDataGridViewTextBoxColumn.DataPropertyName = "Muestra";
            this.muestraDataGridViewTextBoxColumn.HeaderText = "Muestra";
            this.muestraDataGridViewTextBoxColumn.Name = "muestraDataGridViewTextBoxColumn";
            // 
            // espesorDataGridViewTextBoxColumn
            // 
            this.espesorDataGridViewTextBoxColumn.DataPropertyName = "Espesor";
            this.espesorDataGridViewTextBoxColumn.HeaderText = "Espesor";
            this.espesorDataGridViewTextBoxColumn.Name = "espesorDataGridViewTextBoxColumn";
            // 
            // anchoDataGridViewTextBoxColumn
            // 
            this.anchoDataGridViewTextBoxColumn.DataPropertyName = "Ancho";
            this.anchoDataGridViewTextBoxColumn.HeaderText = "Ancho";
            this.anchoDataGridViewTextBoxColumn.Name = "anchoDataGridViewTextBoxColumn";
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            // 
            // cargaLEDataGridViewTextBoxColumn
            // 
            this.cargaLEDataGridViewTextBoxColumn.DataPropertyName = "CargaLE";
            this.cargaLEDataGridViewTextBoxColumn.HeaderText = "CargaLE";
            this.cargaLEDataGridViewTextBoxColumn.Name = "cargaLEDataGridViewTextBoxColumn";
            // 
            // cargaMaxDataGridViewTextBoxColumn
            // 
            this.cargaMaxDataGridViewTextBoxColumn.DataPropertyName = "CargaMax";
            this.cargaMaxDataGridViewTextBoxColumn.HeaderText = "CargaMax";
            this.cargaMaxDataGridViewTextBoxColumn.Name = "cargaMaxDataGridViewTextBoxColumn";
            // 
            // esfuerzoLEDataGridViewTextBoxColumn
            // 
            this.esfuerzoLEDataGridViewTextBoxColumn.DataPropertyName = "EsfuerzoLE";
            this.esfuerzoLEDataGridViewTextBoxColumn.HeaderText = "EsfuerzoLE";
            this.esfuerzoLEDataGridViewTextBoxColumn.Name = "esfuerzoLEDataGridViewTextBoxColumn";
            // 
            // esfuerzoMaxDataGridViewTextBoxColumn
            // 
            this.esfuerzoMaxDataGridViewTextBoxColumn.DataPropertyName = "EsfuerzoMax";
            this.esfuerzoMaxDataGridViewTextBoxColumn.HeaderText = "EsfuerzoMax";
            this.esfuerzoMaxDataGridViewTextBoxColumn.Name = "esfuerzoMaxDataGridViewTextBoxColumn";
            // 
            // alargamiento20DataGridViewTextBoxColumn
            // 
            this.alargamiento20DataGridViewTextBoxColumn.DataPropertyName = "Alargamiento20";
            this.alargamiento20DataGridViewTextBoxColumn.HeaderText = "Alargamiento20";
            this.alargamiento20DataGridViewTextBoxColumn.Name = "alargamiento20DataGridViewTextBoxColumn";
            // 
            // alargamiento5DataGridViewTextBoxColumn
            // 
            this.alargamiento5DataGridViewTextBoxColumn.DataPropertyName = "Alargamiento5";
            this.alargamiento5DataGridViewTextBoxColumn.HeaderText = "Alargamiento5";
            this.alargamiento5DataGridViewTextBoxColumn.Name = "alargamiento5DataGridViewTextBoxColumn";
            // 
            // coladaDataGridViewTextBoxColumn
            // 
            this.coladaDataGridViewTextBoxColumn.DataPropertyName = "Colada";
            this.coladaDataGridViewTextBoxColumn.HeaderText = "Colada";
            this.coladaDataGridViewTextBoxColumn.Name = "coladaDataGridViewTextBoxColumn";
            // 
            // remesaDataGridViewTextBoxColumn
            // 
            this.remesaDataGridViewTextBoxColumn.DataPropertyName = "Remesa";
            this.remesaDataGridViewTextBoxColumn.HeaderText = "Remesa";
            this.remesaDataGridViewTextBoxColumn.Name = "remesaDataGridViewTextBoxColumn";
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            // 
            // txtUsrMov
            // 
            this.txtUsrMov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPlacAceEsp1, "PlacAceEsp.IdUsuario", true));
            this.txtUsrMov.Location = new System.Drawing.Point(346, 69);
            this.txtUsrMov.Name = "txtUsrMov";
            this.txtUsrMov.ReadOnly = true;
            this.txtUsrMov.Size = new System.Drawing.Size(68, 20);
            this.txtUsrMov.TabIndex = 52;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(285, 73);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(54, 13);
            this.label28.TabIndex = 51;
            this.label28.Text = "Usuario:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlacAceEsp
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1016, 533);
            this.Controls.Add(this.dgPlacAceEns);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAPlacAceEsp;
            this.dsGeneral = this.dsPlacAceEsp1;
            this.Name = "PlacAceEsp";
            this.NombreTabla = "PlacAceEsp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "PlacAceEsp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PlacAceEsp_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgPlacAceEns, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlacAceEsp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlacAceEns)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void PlacAceEsp_Load(object sender, System.EventArgs e)
		{
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    IdUsuario = MyControl.Text;
            }
            buscaBtn1.Catalogo = this;
			sqlDAAcero.Fill(dsAcero1,"Acero");
		}
		
		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			base.btnNuevo_Click(sender, e);
			cmbNumero.SelectedIndex = -1;
		}
		
		protected override void btnGuardar_Click(object sender, System.EventArgs e)
		{
			try 
			{
                txtUsrMov.Text = IdUsuario;
                // Intente actualizar el origen de datos.
                base.BindingContext[dsPlacAceEsp1,"PlacAceEsp"].Position = this.BindingContext[dsPlacAceEsp1,"PlacAceEsp"].Position;
				this.UpdateDataSet1();
				base.dsGeneral_PositionChanged();
			}
			catch (System.Exception eUpdate) 
			{
				statusBar1.Panels[2].Text = eUpdate.Message;	
				statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
				statusBar1.Panels[2].ToolTipText = eUpdate.Message;
			}
			dsPlacAceEsp1.Tables["PlacAceRes"].Clear();
			sqlDAPlacAceRes.Fill(dsPlacAceEsp1,"PlacAceRes");
		}

		public override void LoadDataSet()
		{

			//			sqlDAMuestreador.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
			base.LoadDataSet();
			//dgPlacAceEns.SetDataBinding(dsPlacAceEsp1, "PlacAceEsp.PlacAce");
			//string apl = dgPlacAceEns.TableStyles.ToString();
			dsPlacAceEsp1.Tables["PlacAceRes"].Clear();
			sqlDAPlacAceRes.Fill(dsPlacAceEsp1,"PlacAceRes");
		}

		private void UpdateDataSet1()
		{
			// Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
			// original			DataSet objDataSetChanges = new DataSet();
			LancNeo.dsPlacAceEsp objDataSetChanges = new LancNeo.dsPlacAceEsp();
			// Detener las ediciones actuales.
			// original			this.BindingContext[dsgeneral].EndCurrentEdit();
			this.BindingContext[dsPlacAceEsp1,"PlacAceEsp"].EndCurrentEdit();
			this.BindingContext[dsPlacAceEsp1,"PlacAceRes"].EndCurrentEdit();

			// Obtener los cambios realizados en el conjunto de datos principal.
			// original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));

			objDataSetChanges = ((LancNeo.dsPlacAceEsp)(dsPlacAceEsp1.GetChanges()));

			// Comprobar si se han realizado cambios.
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
					// llamando al método de actualización y pasando el conjunto de datos y los parámetros.
					this.UpdateDataSource1(objDataSetChanges);
					dsPlacAceEsp1.Merge(objDataSetChanges);
					dsPlacAceEsp1.AcceptChanges();
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
		private void UpdateDataSource1(LancNeo.dsPlacAceEsp ChangedRows)
		{
			try 
			{
				// Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
				if ((ChangedRows != null)) 
				{
					// Abra la conexión.
					this.sqlConn.Open();
					// Intente actualizar el origen de datos.
					sqlDAPlacAceEsp.Update(ChangedRows);
					sqlDAPlacAceRes.Update(ChangedRows);
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
	}
}
