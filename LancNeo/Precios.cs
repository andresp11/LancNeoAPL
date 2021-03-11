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
	/// Descripción breve de Precios.
	/// </summary>
	public class Precios  : CatalogoGenerico
	{
        private string IdUsuario;

        private System.Windows.Forms.Panel panel2;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPrecio;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsPrecio dsPrecio1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcepto;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlDataAdapter sqlDAInforme;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private LancNeo.dsConcepto dsConcepto1;
		private LancNeo.dsInformeCons dsInformeCons1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.ComboBox cmbIdConcepto;
		private System.Windows.Forms.ComboBox cmbIdInforme;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPrecioDet;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private DataGridView dgPrecio;
        private DataGridViewTextBoxColumn idPrecioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaIniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private BindingSource precioBindingSource;
        private TextBox textBox4;
        private Label label6;
        private CheckBox chkImprime;
        protected tbBtn tbBtn1;
        private TextBox txtFIMin;
        private TextBox txtFIMax;
        private DateTimePicker dtpPFf;
        private Label label7;
        private DateTimePicker dtpPFi;
        private Label label8;
        private CheckBox chkSemestre;
        private SqlCommand sqlComAgregaP;
        private TextBox textBox5;
        private Label label9;
        private TextBox txtUsrMov;
        private Label label59;
        private IContainer components;

		public Precios()
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Precios));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsPrecio1 = new LancNeo.dsPrecio();
            this.tbBtn1 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkSemestre = new System.Windows.Forms.CheckBox();
            this.txtFIMin = new System.Windows.Forms.TextBox();
            this.txtFIMax = new System.Windows.Forms.TextBox();
            this.dtpPFf = new System.Windows.Forms.DateTimePicker();
            this.chkImprime = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dtpPFi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbIdInforme = new System.Windows.Forms.ComboBox();
            this.dsInformeCons1 = new LancNeo.dsInformeCons();
            this.cmbIdConcepto = new System.Windows.Forms.ComboBox();
            this.dsConcepto1 = new LancNeo.dsConcepto();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlDAPrecio = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAConcepto = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAInforme = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAPrecioDet = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dgPrecio = new System.Windows.Forms.DataGridView();
            this.idPrecioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlComAgregaP = new System.Data.SqlClient.SqlCommand();
            this.txtUsrMov = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrecio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInformeCons1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcepto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 483);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1014, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(1014, 64);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tbBtn1);
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.txtUsrMov);
            this.panel2.Controls.Add(this.label59);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.chkSemestre);
            this.panel2.Controls.Add(this.txtFIMin);
            this.panel2.Controls.Add(this.txtFIMax);
            this.panel2.Controls.Add(this.dtpPFf);
            this.panel2.Controls.Add(this.chkImprime);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.dtpPFi);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cmbIdInforme);
            this.panel2.Controls.Add(this.cmbIdConcepto);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 403);
            this.panel2.TabIndex = 4;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsPrecio1.Precio;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(136, -2);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 6;
            // 
            // dsPrecio1
            // 
            this.dsPrecio1.DataSetName = "dsPrecio";
            this.dsPrecio1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsPrecio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbBtn1
            // 
            this.tbBtn1.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn1.Icon")));
            this.tbBtn1.Location = new System.Drawing.Point(8, 117);
            this.tbBtn1.Name = "tbBtn1";
            this.tbBtn1.Size = new System.Drawing.Size(64, 64);
            this.tbBtn1.TabIndex = 56;
            this.tbBtn1.Visible = false;
            this.tbBtn1.Click += new System.EventHandler(this.tbBtn1_Click);
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPrecio1, "Precio.DescPres", true));
            this.textBox5.Location = new System.Drawing.Point(274, 248);
            this.textBox5.MaxLength = 200;
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox5.Size = new System.Drawing.Size(330, 109);
            this.textBox5.TabIndex = 61;
            this.textBox5.Text = "textBox5";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Descripción presupuesto:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkSemestre
            // 
            this.chkSemestre.AutoSize = true;
            this.chkSemestre.Checked = true;
            this.chkSemestre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSemestre.Location = new System.Drawing.Point(250, 117);
            this.chkSemestre.Name = "chkSemestre";
            this.chkSemestre.Size = new System.Drawing.Size(115, 17);
            this.chkSemestre.TabIndex = 59;
            this.chkSemestre.Text = "Semestre siguiente";
            this.chkSemestre.UseVisualStyleBackColor = true;
            this.chkSemestre.Visible = false;
            this.chkSemestre.CheckedChanged += new System.EventHandler(this.chkSemestre_CheckedChanged);
            this.chkSemestre.CheckStateChanged += new System.EventHandler(this.chkSemestre_CheckStateChanged);
            // 
            // txtFIMin
            // 
            this.txtFIMin.Enabled = false;
            this.txtFIMin.Location = new System.Drawing.Point(250, 164);
            this.txtFIMin.Name = "txtFIMin";
            this.txtFIMin.Size = new System.Drawing.Size(84, 20);
            this.txtFIMin.TabIndex = 58;
            this.txtFIMin.Visible = false;
            // 
            // txtFIMax
            // 
            this.txtFIMax.Enabled = false;
            this.txtFIMax.Location = new System.Drawing.Point(148, 164);
            this.txtFIMax.Name = "txtFIMax";
            this.txtFIMax.Size = new System.Drawing.Size(84, 20);
            this.txtFIMax.TabIndex = 57;
            this.txtFIMax.Visible = false;
            // 
            // dtpPFf
            // 
            this.dtpPFf.Enabled = false;
            this.dtpPFf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPFf.Location = new System.Drawing.Point(250, 140);
            this.dtpPFf.Name = "dtpPFf";
            this.dtpPFf.Size = new System.Drawing.Size(84, 20);
            this.dtpPFf.TabIndex = 55;
            this.dtpPFf.Visible = false;
            // 
            // chkImprime
            // 
            this.chkImprime.AutoSize = true;
            this.chkImprime.Checked = true;
            this.chkImprime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkImprime.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsPrecio1, "Precio.Imprime", true));
            this.chkImprime.Location = new System.Drawing.Point(35, 75);
            this.chkImprime.Name = "chkImprime";
            this.chkImprime.Size = new System.Drawing.Size(77, 17);
            this.chkImprime.TabIndex = 23;
            this.chkImprime.Text = "Se imprime";
            this.chkImprime.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-10, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Fechas de NUEVOS PRECIOS:";
            this.label7.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPrecio1, "Precio.Metodo", true));
            this.textBox4.Location = new System.Drawing.Point(274, 121);
            this.textBox4.MaxLength = 250;
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox4.Size = new System.Drawing.Size(335, 60);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "textBox4";
            // 
            // dtpPFi
            // 
            this.dtpPFi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPFi.Location = new System.Drawing.Point(147, 140);
            this.dtpPFi.Name = "dtpPFi";
            this.dtpPFi.Size = new System.Drawing.Size(84, 20);
            this.dtpPFi.TabIndex = 52;
            this.dtpPFi.Visible = false;
            this.dtpPFi.ValueChanged += new System.EventHandler(this.dtpPFi_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Método:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Inicial:";
            this.label8.Visible = false;
            // 
            // cmbIdInforme
            // 
            this.cmbIdInforme.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsPrecio1, "Precio.IdInforme", true));
            this.cmbIdInforme.DataSource = this.dsInformeCons1.Informes;
            this.cmbIdInforme.DisplayMember = "Informe";
            this.cmbIdInforme.Location = new System.Drawing.Point(274, 208);
            this.cmbIdInforme.Name = "cmbIdInforme";
            this.cmbIdInforme.Size = new System.Drawing.Size(335, 21);
            this.cmbIdInforme.TabIndex = 5;
            this.cmbIdInforme.ValueMember = "IdInforme";
            // 
            // dsInformeCons1
            // 
            this.dsInformeCons1.DataSetName = "dsInformeCons";
            this.dsInformeCons1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsInformeCons1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbIdConcepto
            // 
            this.cmbIdConcepto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsPrecio1, "Precio.IdConcepto", true));
            this.cmbIdConcepto.DataSource = this.dsConcepto1.Concepto;
            this.cmbIdConcepto.DisplayMember = "Concepto";
            this.cmbIdConcepto.Location = new System.Drawing.Point(274, 185);
            this.cmbIdConcepto.Name = "cmbIdConcepto";
            this.cmbIdConcepto.Size = new System.Drawing.Size(335, 21);
            this.cmbIdConcepto.TabIndex = 4;
            this.cmbIdConcepto.ValueMember = "IdConcepto";
            // 
            // dsConcepto1
            // 
            this.dsConcepto1.DataSetName = "dsConcepto";
            this.dsConcepto1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcepto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPrecio1, "Precio.Unidad", true));
            this.textBox3.Location = new System.Drawing.Point(56, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "textBox3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Unidad:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Informe:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Concepto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPrecio1, "Precio.Descripcion", true));
            this.textBox2.Location = new System.Drawing.Point(274, 6);
            this.textBox2.MaxLength = 200;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(330, 109);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "textBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPrecio1, "Precio.IdPrecio", true));
            this.textBox1.Location = new System.Drawing.Point(56, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "textBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdPrecio:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sqlDAPrecio
            // 
            this.sqlDAPrecio.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAPrecio.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAPrecio.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAPrecio.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Precio", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdPrecio", "IdPrecio"),
                        new System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("IdConcepto", "IdConcepto"),
                        new System.Data.Common.DataColumnMapping("IdInforme", "IdInforme"),
                        new System.Data.Common.DataColumnMapping("Metodo", "Metodo"),
                        new System.Data.Common.DataColumnMapping("Imprime", "Imprime"),
                        new System.Data.Common.DataColumnMapping("DescPres", "DescPres"),
                        new System.Data.Common.DataColumnMapping("IdUsuario", "IdUsuario")})});
            this.sqlDAPrecio.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdPrecio", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPrecio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Descripcion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Descripcion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Descripcion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Unidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Unidad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Unidad", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Unidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdConcepto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdConcepto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdConcepto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdConcepto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdInforme", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdInforme", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdInforme", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdInforme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Metodo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Metodo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Metodo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Metodo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Imprime", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Imprime", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Imprime", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Imprime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DescPres", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DescPres", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DescPres", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DescPres", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@IdPrecio", System.Data.SqlDbType.Char, 0, "IdPrecio"),
            new System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 0, "Descripcion"),
            new System.Data.SqlClient.SqlParameter("@Unidad", System.Data.SqlDbType.VarChar, 0, "Unidad"),
            new System.Data.SqlClient.SqlParameter("@IdConcepto", System.Data.SqlDbType.SmallInt, 0, "IdConcepto"),
            new System.Data.SqlClient.SqlParameter("@IdInforme", System.Data.SqlDbType.Char, 0, "IdInforme"),
            new System.Data.SqlClient.SqlParameter("@Metodo", System.Data.SqlDbType.VarChar, 0, "Metodo"),
            new System.Data.SqlClient.SqlParameter("@Imprime", System.Data.SqlDbType.Bit, 0, "Imprime"),
            new System.Data.SqlClient.SqlParameter("@DescPres", System.Data.SqlDbType.VarChar, 0, "DescPres"),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        IdPrecio, Descripcion, Unidad, IdConcepto, IdInforme, Metodo, Impri" +
    "me, DescPres, IdUsuario\r\nFROM            Precio\r\nORDER BY IdPrecio";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdPrecio", System.Data.SqlDbType.Char, 0, "IdPrecio"),
            new System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 0, "Descripcion"),
            new System.Data.SqlClient.SqlParameter("@Unidad", System.Data.SqlDbType.VarChar, 0, "Unidad"),
            new System.Data.SqlClient.SqlParameter("@IdConcepto", System.Data.SqlDbType.SmallInt, 0, "IdConcepto"),
            new System.Data.SqlClient.SqlParameter("@IdInforme", System.Data.SqlDbType.Char, 0, "IdInforme"),
            new System.Data.SqlClient.SqlParameter("@Metodo", System.Data.SqlDbType.VarChar, 0, "Metodo"),
            new System.Data.SqlClient.SqlParameter("@Imprime", System.Data.SqlDbType.Bit, 0, "Imprime"),
            new System.Data.SqlClient.SqlParameter("@DescPres", System.Data.SqlDbType.VarChar, 0, "DescPres"),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario"),
            new System.Data.SqlClient.SqlParameter("@Original_IdPrecio", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPrecio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Descripcion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Descripcion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Descripcion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Unidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Unidad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Unidad", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Unidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdConcepto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdConcepto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdConcepto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdConcepto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdInforme", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdInforme", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdInforme", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdInforme", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Metodo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Metodo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Metodo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Metodo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Imprime", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Imprime", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Imprime", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Imprime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DescPres", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DescPres", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DescPres", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DescPres", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDAConcepto
            // 
            this.sqlDAConcepto.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAConcepto.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Concepto", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcepto", "IdConcepto"),
                        new System.Data.Common.DataColumnMapping("Concepto", "Concepto")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT IdConcepto, Concepto FROM Concepto ORDER BY Concepto";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            // 
            // sqlDAInforme
            // 
            this.sqlDAInforme.SelectCommand = this.sqlSelectCommand3;
            this.sqlDAInforme.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Informes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdInforme", "IdInforme"),
                        new System.Data.Common.DataColumnMapping("Informe", "Informe")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT IdInforme, Informe FROM Informes ORDER BY Informe";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            // 
            // sqlDAPrecioDet
            // 
            this.sqlDAPrecioDet.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDAPrecioDet.InsertCommand = this.sqlInsertCommand2;
            this.sqlDAPrecioDet.SelectCommand = this.sqlSelectCommand4;
            this.sqlDAPrecioDet.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PrecioDet", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdPrecio", "IdPrecio"),
                        new System.Data.Common.DataColumnMapping("FechaIni", "FechaIni"),
                        new System.Data.Common.DataColumnMapping("FechaFin", "FechaFin"),
                        new System.Data.Common.DataColumnMapping("Precio", "Precio")})});
            this.sqlDAPrecioDet.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConn;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FechaIni", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FechaIni", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdPrecio", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPrecio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FechaFin", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FechaFin", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Precio", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(2)), "Precio", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConn;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdPrecio", System.Data.SqlDbType.VarChar, 15, "IdPrecio"),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 4, "FechaIni"),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 4, "FechaFin"),
            new System.Data.SqlClient.SqlParameter("@Precio", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(2)), "Precio", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "SELECT     IdPrecio, FechaIni, FechaFin, Precio\r\nFROM         PrecioDet\r\nORDER BY" +
    " IdPrecio, FechaFin DESC, FechaIni";
            this.sqlSelectCommand4.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConn;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdPrecio", System.Data.SqlDbType.VarChar, 15, "IdPrecio"),
            new System.Data.SqlClient.SqlParameter("@FechaIni", System.Data.SqlDbType.DateTime, 4, "FechaIni"),
            new System.Data.SqlClient.SqlParameter("@FechaFin", System.Data.SqlDbType.DateTime, 4, "FechaFin"),
            new System.Data.SqlClient.SqlParameter("@Precio", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(2)), "Precio", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_FechaIni", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FechaIni", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdPrecio", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPrecio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FechaFin", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FechaFin", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Precio", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(10)), ((byte)(2)), "Precio", System.Data.DataRowVersion.Original, null)});
            // 
            // dgPrecio
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgPrecio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgPrecio.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPrecio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrecio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPrecioDataGridViewTextBoxColumn,
            this.fechaIniDataGridViewTextBoxColumn,
            this.fechaFinDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dgPrecio.DataMember = "Precio.PrecioRel";
            this.dgPrecio.DataSource = this.dsPrecio1;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPrecio.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgPrecio.Location = new System.Drawing.Point(631, 74);
            this.dgPrecio.Name = "dgPrecio";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPrecio.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgPrecio.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgPrecio.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgPrecio.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgPrecio.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgPrecio.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgPrecio.Size = new System.Drawing.Size(371, 383);
            this.dgPrecio.TabIndex = 6;
            // 
            // idPrecioDataGridViewTextBoxColumn
            // 
            this.idPrecioDataGridViewTextBoxColumn.DataPropertyName = "IdPrecio";
            this.idPrecioDataGridViewTextBoxColumn.HeaderText = "IdPrecio";
            this.idPrecioDataGridViewTextBoxColumn.Name = "idPrecioDataGridViewTextBoxColumn";
            this.idPrecioDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaIniDataGridViewTextBoxColumn
            // 
            this.fechaIniDataGridViewTextBoxColumn.DataPropertyName = "FechaIni";
            this.fechaIniDataGridViewTextBoxColumn.HeaderText = "FechaIni";
            this.fechaIniDataGridViewTextBoxColumn.Name = "fechaIniDataGridViewTextBoxColumn";
            // 
            // fechaFinDataGridViewTextBoxColumn
            // 
            this.fechaFinDataGridViewTextBoxColumn.DataPropertyName = "FechaFin";
            this.fechaFinDataGridViewTextBoxColumn.HeaderText = "FechaFin";
            this.fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // precioBindingSource
            // 
            this.precioBindingSource.DataMember = "Precio";
            this.precioBindingSource.DataSource = this.dsPrecio1;
            // 
            // sqlComAgregaP
            // 
            this.sqlComAgregaP.CommandText = "[actualizaprecios]";
            this.sqlComAgregaP.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComAgregaP.Connection = this.sqlConn;
            this.sqlComAgregaP.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@FfMax", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@FfMin", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@FiMax", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@FiMin", System.Data.SqlDbType.SmallDateTime, 4)});
            // 
            // txtUsrMov
            // 
            this.txtUsrMov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPrecio1, "Precio.IdUsuario", true));
            this.txtUsrMov.Location = new System.Drawing.Point(97, 98);
            this.txtUsrMov.Name = "txtUsrMov";
            this.txtUsrMov.ReadOnly = true;
            this.txtUsrMov.Size = new System.Drawing.Size(68, 20);
            this.txtUsrMov.TabIndex = 72;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.Red;
            this.label59.Location = new System.Drawing.Point(36, 102);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(54, 13);
            this.label59.TabIndex = 71;
            this.label59.Text = "Usuario:";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Precios
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1014, 505);
            this.Controls.Add(this.dgPrecio);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAPrecio;
            this.dsGeneral = this.dsPrecio1;
            this.Name = "Precios";
            this.NombreTabla = "Precio";
            this.Text = "Precios de los servicios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Precios_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.dgPrecio, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrecio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInformeCons1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcepto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioBindingSource)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Precios_Load(object sender, System.EventArgs e)
		{
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    IdUsuario = MyControl.Text;
            }
            buscaBtn1.Catalogo = this;
			sqlDAConcepto.Fill(dsConcepto1,"Concepto");
			sqlDAInforme.Fill(dsInformeCons1,"Informes");
		}
		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			base.btnNuevo_Click(sender, e);
            chkImprime.Checked = false;
			cmbIdConcepto.SelectedIndex = -1;
			cmbIdInforme.SelectedIndex = -1;
            chkImprime.Checked = true;
		}
		protected override void btnGuardar_Click(object sender, System.EventArgs e)
		{
			try 
			{
                txtUsrMov.Text = IdUsuario;
                // Intente actualizar el origen de datos.
                base.BindingContext[dsPrecio1,"Precio"].Position = this.BindingContext[dsPrecio1,"Precio"].Position;
				this.UpdateDataSet1();
				base.dsGeneral_PositionChanged();
			}
			catch (System.Exception eUpdate) 
			{
				statusBar1.Panels[2].Text = eUpdate.Message;	
				statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
				statusBar1.Panels[2].ToolTipText = eUpdate.Message;
			}
			sqlDAPrecioDet.Fill(dsPrecio1,"PrecioDet");
		}

		public override void LoadDataSet()
		{

			base.LoadDataSet();
			//dgPrecio.SetDataBinding(dsPrecio1, "Precio.PrecioRel");
			//string apl = dgPrecio.TableStyles.ToString();
			sqlDAPrecioDet.Fill(dsPrecio1,"PrecioDet");
		}

		private void UpdateDataSet1()
		{
			// Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
			// original			DataSet objDataSetChanges = new DataSet();
			LancNeo.dsPrecio objDataSetChanges = new LancNeo.dsPrecio();
			// Detener las ediciones actuales.
			// original			this.BindingContext[dsgeneral].EndCurrentEdit();
			this.BindingContext[dsPrecio1,"Precio"].EndCurrentEdit();
			this.BindingContext[dsPrecio1,"PrecioDet"].EndCurrentEdit();

			// Obtener los cambios realizados en el conjunto de datos principal.
			// original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));

			objDataSetChanges = ((LancNeo.dsPrecio)(dsPrecio1.GetChanges()));

			// Comprobar si se han realizado cambios.
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
					// llamando al método de actualización y pasando el conjunto de datos y los parámetros.
					this.UpdateDataSource1(objDataSetChanges);
					dsPrecio1.Merge(objDataSetChanges);
					dsPrecio1.AcceptChanges();
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
		private void UpdateDataSource1(LancNeo.dsPrecio ChangedRows)
		{
			try 
			{
				// Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
				if ((ChangedRows != null)) 
				{
					// Abra la conexión.
					this.sqlConn.Open();
					// Intente actualizar el origen de datos.
					sqlDAPrecio.Update(ChangedRows);
					sqlDAPrecioDet.Update(ChangedRows);
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

        private void dtpPFi_ValueChanged(object sender, EventArgs e)
        {
            int sumaresta = (chkSemestre.Checked ? 6 : -6);
            int diasuma = (chkSemestre.Checked ? -1 : -1);
            DateTime ff;
            dtpPFf.Value = dtpPFi.Value.AddMonths(6);
            dtpPFf.Value = dtpPFf.Value.AddDays(diasuma);
            txtFIMax.Text = dtpPFi.Value.AddMonths(sumaresta).ToString().Substring(0, 10);
            ff = dtpPFi.Value.AddMonths(sumaresta + 6);
            ff = ff.AddDays(-1);
            txtFIMin.Text = ff.ToString().Substring(0, 10);
        }

        private void tbBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.Open();
                sqlComAgregaP.Parameters["@Ffmax"].Value = dtpPFf.Value.ToString().Substring(0, 10);
                sqlComAgregaP.Parameters["@Ffmin"].Value = dtpPFi.Value.ToString().Substring(0, 10);
                sqlComAgregaP.Parameters["@Fimax"].Value = txtFIMin.Text;
                sqlComAgregaP.Parameters["@Fimin"].Value = txtFIMax.Text;
                int error = sqlComAgregaP.ExecuteNonQuery();
                MessageBox.Show("Proceso terminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();

        }

        private void chkSemestre_CheckedChanged(object sender, EventArgs e)
        {
            dtpPFi_ValueChanged(sender, null);
        }

        private void chkSemestre_CheckStateChanged(object sender, EventArgs e)
        {
            dtpPFi_ValueChanged(sender, null);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

	}
}
