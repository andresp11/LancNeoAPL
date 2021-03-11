using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;
using System.Data.SqlClient;
using System.Data;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Laboratorio.
	/// </summary>
	public class Laboratorio : CatalogoGenerico
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblIdLaboratorio;
		private System.Windows.Forms.Label lblLaboratorio;
		private System.Windows.Forms.Label lblZona;
		private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorio;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsLaboratorio dsLaboratorio1;
		private System.Windows.Forms.TextBox txtIdLaboratorio;
		private System.Windows.Forms.TextBox txtLaboratorio;
		private System.Windows.Forms.ComboBox cmbZona;
		private LancNeo.dsZona dsZona1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAZona;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
		private System.Data.SqlClient.SqlCommand sqlCommand3;
		private System.Data.SqlClient.SqlCommand sqlCommand4;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn2;
		private System.Windows.Forms.TextBox txtRuta;
		private System.Windows.Forms.Label label1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private DataGridView dataGridView1;
        private SqlDataAdapter sqlDAGruLab;
        private SqlCommand sqlCommand5;
        private SqlCommand sqlCommand6;
        private SqlCommand sqlCommand7;
        private SqlCommand sqlCommand8;
        private DataGridViewTextBoxColumn cInicialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cFinalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idLaboratorioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fInicialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Ubucacion;
        private DataGridViewTextBoxColumn IdObra;
        private DataGridViewTextBoxColumn Prensa;
        private DataGridViewTextBoxColumn Responsable;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn fFinalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Observaciones;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Laboratorio()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laboratorio));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsLaboratorio1 = new LancNeo.dsLaboratorio();
            this.buscaBtn2 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsZona1 = new LancNeo.dsZona();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.txtIdLaboratorio = new System.Windows.Forms.TextBox();
            this.lblIdLaboratorio = new System.Windows.Forms.Label();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.lblZona = new System.Windows.Forms.Label();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.sqlDALaboratorio = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAZona = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sqlDAGruLab = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand8 = new System.Data.SqlClient.SqlCommand();
            this.idLaboratorioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubucacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdObra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prensa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelToolBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZona1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 515);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1019, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(1019, 64);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.buscaBtn2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtRuta);
            this.panel1.Controls.Add(this.cmbZona);
            this.panel1.Controls.Add(this.txtIdLaboratorio);
            this.panel1.Controls.Add(this.lblIdLaboratorio);
            this.panel1.Controls.Add(this.lblLaboratorio);
            this.panel1.Controls.Add(this.lblZona);
            this.panel1.Controls.Add(this.txtLaboratorio);
            this.panel1.Location = new System.Drawing.Point(5, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 174);
            this.panel1.TabIndex = 3;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsLaboratorio1.Laboratorio;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(256, 2);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // dsLaboratorio1
            // 
            this.dsLaboratorio1.DataSetName = "dsLaboratorio";
            this.dsLaboratorio1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscaBtn2
            // 
            this.buscaBtn2.AnchoDlgBusq = 450;
            this.buscaBtn2.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn2.Datos = this.dsZona1.Zona;
            this.buscaBtn2.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn2.Icon")));
            this.buscaBtn2.Location = new System.Drawing.Point(368, 75);
            this.buscaBtn2.Name = "buscaBtn2";
            this.buscaBtn2.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn2.TabIndex = 4;
            this.buscaBtn2.Click += new System.EventHandler(this.buscaBtn2_Click);
            // 
            // dsZona1
            // 
            this.dsZona1.DataSetName = "dsZona";
            this.dsZona1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsZona1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(32, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ruta Imagen:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRuta
            // 
            this.txtRuta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLaboratorio1, "Laboratorio.Rutaimagen", true));
            this.txtRuta.Location = new System.Drawing.Point(152, 139);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(280, 20);
            this.txtRuta.TabIndex = 5;
            this.txtRuta.Text = "textBox1";
            // 
            // cmbZona
            // 
            this.cmbZona.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsLaboratorio1, "Laboratorio.IdZona", true));
            this.cmbZona.DataSource = this.dsZona1.Zona;
            this.cmbZona.DisplayMember = "Zona";
            this.cmbZona.Location = new System.Drawing.Point(152, 97);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(208, 21);
            this.cmbZona.TabIndex = 2;
            this.cmbZona.ValueMember = "IdZona";
            // 
            // txtIdLaboratorio
            // 
            this.txtIdLaboratorio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLaboratorio1, "Laboratorio.IdLaboratorio", true));
            this.txtIdLaboratorio.Location = new System.Drawing.Point(152, 24);
            this.txtIdLaboratorio.Name = "txtIdLaboratorio";
            this.txtIdLaboratorio.Size = new System.Drawing.Size(100, 20);
            this.txtIdLaboratorio.TabIndex = 1;
            this.txtIdLaboratorio.Text = "textBox1";
            this.txtIdLaboratorio.TextChanged += new System.EventHandler(this.txtIdLaboratorio_TextChanged);
            // 
            // lblIdLaboratorio
            // 
            this.lblIdLaboratorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIdLaboratorio.Location = new System.Drawing.Point(32, 23);
            this.lblIdLaboratorio.Name = "lblIdLaboratorio";
            this.lblIdLaboratorio.Size = new System.Drawing.Size(100, 23);
            this.lblIdLaboratorio.TabIndex = 0;
            this.lblIdLaboratorio.Text = "Id Laboratorio:";
            this.lblIdLaboratorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLaboratorio.Location = new System.Drawing.Point(32, 69);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(100, 23);
            this.lblLaboratorio.TabIndex = 0;
            this.lblLaboratorio.Text = "Laboratorio:";
            this.lblLaboratorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblZona
            // 
            this.lblZona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblZona.Location = new System.Drawing.Point(32, 96);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(100, 23);
            this.lblZona.TabIndex = 0;
            this.lblZona.Text = "Zona:";
            this.lblZona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLaboratorio
            // 
            this.txtLaboratorio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLaboratorio1, "Laboratorio.Laboratorio", true));
            this.txtLaboratorio.Location = new System.Drawing.Point(152, 69);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(208, 20);
            this.txtLaboratorio.TabIndex = 1;
            this.txtLaboratorio.Text = "textBox1";
            // 
            // sqlDALaboratorio
            // 
            this.sqlDALaboratorio.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDALaboratorio.InsertCommand = this.sqlInsertCommand1;
            this.sqlDALaboratorio.SelectCommand = this.sqlSelectCommand1;
            this.sqlDALaboratorio.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Laboratorio", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("Laboratorio", "Laboratorio"),
                        new System.Data.Common.DataColumnMapping("IdZona", "IdZona"),
                        new System.Data.Common.DataColumnMapping("Rutaimagen", "Rutaimagen")})});
            this.sqlDALaboratorio.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdLaboratorio", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdZona", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdZona", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Laboratorio", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Laboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Rutaimagen", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Rutaimagen", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 10, "IdLaboratorio"),
            new System.Data.SqlClient.SqlParameter("@Laboratorio", System.Data.SqlDbType.NVarChar, 50, "Laboratorio"),
            new System.Data.SqlClient.SqlParameter("@IdZona", System.Data.SqlDbType.NVarChar, 1, "IdZona"),
            new System.Data.SqlClient.SqlParameter("@Rutaimagen", System.Data.SqlDbType.NVarChar, 50, "Rutaimagen")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     IdLaboratorio, Laboratorio, IdZona, Rutaimagen\r\nFROM         Laborator" +
    "io\r\nORDER BY IdLaboratorio";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 10, "IdLaboratorio"),
            new System.Data.SqlClient.SqlParameter("@Laboratorio", System.Data.SqlDbType.NVarChar, 50, "Laboratorio"),
            new System.Data.SqlClient.SqlParameter("@IdZona", System.Data.SqlDbType.NVarChar, 1, "IdZona"),
            new System.Data.SqlClient.SqlParameter("@Rutaimagen", System.Data.SqlDbType.NVarChar, 50, "Rutaimagen"),
            new System.Data.SqlClient.SqlParameter("@Original_IdLaboratorio", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdZona", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdZona", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Laboratorio", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Laboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Rutaimagen", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Rutaimagen", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDAZona
            // 
            this.sqlDAZona.DeleteCommand = this.sqlCommand1;
            this.sqlDAZona.InsertCommand = this.sqlCommand2;
            this.sqlDAZona.SelectCommand = this.sqlCommand3;
            this.sqlDAZona.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Zona", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdZona", "IdZona"),
                        new System.Data.Common.DataColumnMapping("Zona", "Zona"),
                        new System.Data.Common.DataColumnMapping("Ubicación", "Ubicación")})});
            this.sqlDAZona.UpdateCommand = this.sqlCommand4;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConn;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdZona", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdZona", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ubicación", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ubicación", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Zona", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Zona", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "INSERT INTO Zona(IdZona, Zona, Ubicación) VALUES (@IdZona, @Zona, @Ubicación); SE" +
    "LECT IdZona, Zona, Ubicación FROM Zona WHERE (IdZona = @IdZona)";
            this.sqlCommand2.Connection = this.sqlConn;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdZona", System.Data.SqlDbType.NVarChar, 1, "IdZona"),
            new System.Data.SqlClient.SqlParameter("@Zona", System.Data.SqlDbType.NVarChar, 50, "Zona"),
            new System.Data.SqlClient.SqlParameter("@Ubicación", System.Data.SqlDbType.Int, 4, "Ubicación")});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "SELECT IdZona, Zona, Ubicación FROM Zona";
            this.sqlCommand3.Connection = this.sqlConn;
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = resources.GetString("sqlCommand4.CommandText");
            this.sqlCommand4.Connection = this.sqlConn;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdZona", System.Data.SqlDbType.NVarChar, 1, "IdZona"),
            new System.Data.SqlClient.SqlParameter("@Zona", System.Data.SqlDbType.NVarChar, 50, "Zona"),
            new System.Data.SqlClient.SqlParameter("@Ubicación", System.Data.SqlDbType.Int, 4, "Ubicación"),
            new System.Data.SqlClient.SqlParameter("@Original_IdZona", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdZona", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ubicación", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ubicación", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Zona", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Zona", System.Data.DataRowVersion.Original, null)});
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLaboratorioDataGridViewTextBoxColumn,
            this.fInicialDataGridViewTextBoxColumn,
            this.Ubucacion,
            this.IdObra,
            this.Prensa,
            this.Responsable,
            this.Cliente,
            this.fFinalDataGridViewTextBoxColumn,
            this.Observaciones});
            this.dataGridView1.DataMember = "Laboratorio.FK_Laboratorio_GruLab";
            this.dataGridView1.DataSource = this.dsLaboratorio1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(5, 247);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 238);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sqlDAGruLab
            // 
            this.sqlDAGruLab.DeleteCommand = this.sqlCommand5;
            this.sqlDAGruLab.InsertCommand = this.sqlCommand6;
            this.sqlDAGruLab.SelectCommand = this.sqlCommand7;
            this.sqlDAGruLab.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "GruLab", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("FInicial", "FInicial"),
                        new System.Data.Common.DataColumnMapping("FFinal", "FFinal"),
                        new System.Data.Common.DataColumnMapping("Ubucacion", "Ubucacion"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Prensa", "Prensa"),
                        new System.Data.Common.DataColumnMapping("Responsable", "Responsable"),
                        new System.Data.Common.DataColumnMapping("Cliente", "Cliente"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})});
            this.sqlDAGruLab.UpdateCommand = this.sqlCommand8;
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = resources.GetString("sqlCommand5.CommandText");
            this.sqlCommand5.Connection = this.sqlConn;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FInicial", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FInicial", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FFinal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FFinal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FFinal", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FFinal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ubucacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ubucacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ubucacion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ubucacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdObra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Prensa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Prensa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Prensa", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prensa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Responsable", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Responsable", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Responsable", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Responsable", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cliente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cliente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cliente", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cliente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Observaciones", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand6
            // 
            this.sqlCommand6.CommandText = resources.GetString("sqlCommand6.CommandText");
            this.sqlCommand6.Connection = this.sqlConn;
            this.sqlCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, "IdLaboratorio"),
            new System.Data.SqlClient.SqlParameter("@FInicial", System.Data.SqlDbType.SmallDateTime, 0, "FInicial"),
            new System.Data.SqlClient.SqlParameter("@FFinal", System.Data.SqlDbType.SmallDateTime, 0, "FFinal"),
            new System.Data.SqlClient.SqlParameter("@Ubucacion", System.Data.SqlDbType.NVarChar, 0, "Ubucacion"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Prensa", System.Data.SqlDbType.VarChar, 0, "Prensa"),
            new System.Data.SqlClient.SqlParameter("@Responsable", System.Data.SqlDbType.VarChar, 0, "Responsable"),
            new System.Data.SqlClient.SqlParameter("@Cliente", System.Data.SqlDbType.VarChar, 0, "Cliente"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 0, "Observaciones")});
            // 
            // sqlCommand7
            // 
            this.sqlCommand7.CommandText = resources.GetString("sqlCommand7.CommandText");
            this.sqlCommand7.Connection = this.sqlConn;
            this.sqlCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 10, "IdLaboratorio")});
            // 
            // sqlCommand8
            // 
            this.sqlCommand8.CommandText = resources.GetString("sqlCommand8.CommandText");
            this.sqlCommand8.Connection = this.sqlConn;
            this.sqlCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, "IdLaboratorio"),
            new System.Data.SqlClient.SqlParameter("@FInicial", System.Data.SqlDbType.SmallDateTime, 0, "FInicial"),
            new System.Data.SqlClient.SqlParameter("@FFinal", System.Data.SqlDbType.SmallDateTime, 0, "FFinal"),
            new System.Data.SqlClient.SqlParameter("@Ubucacion", System.Data.SqlDbType.NVarChar, 0, "Ubucacion"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Prensa", System.Data.SqlDbType.VarChar, 0, "Prensa"),
            new System.Data.SqlClient.SqlParameter("@Responsable", System.Data.SqlDbType.VarChar, 0, "Responsable"),
            new System.Data.SqlClient.SqlParameter("@Cliente", System.Data.SqlDbType.VarChar, 0, "Cliente"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 0, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@Original_IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FInicial", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FInicial", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FFinal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FFinal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FFinal", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FFinal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Ubucacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ubucacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Ubucacion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ubucacion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdObra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Prensa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Prensa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Prensa", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prensa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Responsable", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Responsable", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Responsable", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Responsable", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cliente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cliente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cliente", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cliente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Observaciones", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null)});
            // 
            // idLaboratorioDataGridViewTextBoxColumn
            // 
            this.idLaboratorioDataGridViewTextBoxColumn.DataPropertyName = "IdLaboratorio";
            this.idLaboratorioDataGridViewTextBoxColumn.HeaderText = "IdLaboratorio";
            this.idLaboratorioDataGridViewTextBoxColumn.Name = "idLaboratorioDataGridViewTextBoxColumn";
            this.idLaboratorioDataGridViewTextBoxColumn.Visible = false;
            this.idLaboratorioDataGridViewTextBoxColumn.Width = 5;
            // 
            // fInicialDataGridViewTextBoxColumn
            // 
            this.fInicialDataGridViewTextBoxColumn.DataPropertyName = "FInicial";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.fInicialDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.fInicialDataGridViewTextBoxColumn.HeaderText = "Fecha inicial";
            this.fInicialDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.fInicialDataGridViewTextBoxColumn.Name = "fInicialDataGridViewTextBoxColumn";
            this.fInicialDataGridViewTextBoxColumn.Width = 70;
            // 
            // Ubucacion
            // 
            this.Ubucacion.DataPropertyName = "Ubucacion";
            this.Ubucacion.HeaderText = "Ubicación";
            this.Ubucacion.MaxInputLength = 80;
            this.Ubucacion.Name = "Ubucacion";
            this.Ubucacion.Width = 250;
            // 
            // IdObra
            // 
            this.IdObra.DataPropertyName = "IdObra";
            this.IdObra.HeaderText = "IdObra";
            this.IdObra.MaxInputLength = 6;
            this.IdObra.Name = "IdObra";
            this.IdObra.Width = 50;
            // 
            // Prensa
            // 
            this.Prensa.DataPropertyName = "Prensa";
            this.Prensa.HeaderText = "Prensa";
            this.Prensa.MaxInputLength = 20;
            this.Prensa.Name = "Prensa";
            this.Prensa.Width = 70;
            // 
            // Responsable
            // 
            this.Responsable.DataPropertyName = "Responsable";
            this.Responsable.HeaderText = "Responsable";
            this.Responsable.MaxInputLength = 50;
            this.Responsable.Name = "Responsable";
            this.Responsable.Width = 150;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MaxInputLength = 20;
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 70;
            // 
            // fFinalDataGridViewTextBoxColumn
            // 
            this.fFinalDataGridViewTextBoxColumn.DataPropertyName = "FFinal";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.fFinalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.fFinalDataGridViewTextBoxColumn.HeaderText = "Fecha final";
            this.fFinalDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.fFinalDataGridViewTextBoxColumn.Name = "fFinalDataGridViewTextBoxColumn";
            this.fFinalDataGridViewTextBoxColumn.Width = 70;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.MaxInputLength = 50;
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Width = 200;
            // 
            // Laboratorio
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1019, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.DAGeneral = this.sqlDALaboratorio;
            this.dsGeneral = this.dsLaboratorio1;
            this.Name = "Laboratorio";
            this.NombreTabla = "Laboratorio";
            this.Text = "Laboratorio";
            this.Load += new System.EventHandler(this.Laboratorio_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZona1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Laboratorio_Load(object sender, System.EventArgs e)
		{
			LlenaZona();
			LlenaVistaPrevia();
			this.buscaBtn1.Catalogo = this;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
		}
		private void LlenaZona()
		{
			sqlDAZona.Fill(dsZona1,"Zona");
		}
		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			base.btnNuevo_Click(sender, e);
			cmbZona.SelectedIndex = -1;
            dataGridView1.Visible = false;
		}
		private void LlenaVistaPrevia()
		{
			DataSet dsVista = new DataSet();
			String strSql = " SELECT IdLaboratorio As Id, Laboratorio, Zona FROM Laboratorio L";
			strSql += " Join Zona Z on Z.IdZona = L.IdZona ";
			SqlDataAdapter sqlDAVP = new SqlDataAdapter(strSql, sqlConn);
			sqlDAVP.Fill(dsVista,"Laboratorio");
			this.dsVistaPrevia = dsVista;

		}

		private void buscaBtn2_Click(object sender, System.EventArgs e)
		{
			cmbZona.SelectedIndex = buscaBtn2.RegistroSeleccionado;
		}

        protected override void btnGuardar_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Intente actualizar el origen de datos.
                base.BindingContext[dsLaboratorio1, "Laboratorio"].Position = this.BindingContext[dsLaboratorio1, "Laboratorio"].Position;
                this.UpdateDataSet1();
                base.dsGeneral_PositionChanged();
            }
            catch (System.Exception eUpdate)
            {
                statusBar1.Panels[2].Text = eUpdate.Message;
                statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
                statusBar1.Panels[2].ToolTipText = eUpdate.Message;
            }
            dataGridView1.Visible = true;
        }

        public override void LoadDataSet()
        {

            base.LoadDataSet();
            //dgPrecio.SetDataBinding(dsPrecio1, "Precio.PrecioRel");
            //string apl = dgPrecio.TableStyles.ToString();
            dsLaboratorio1.GruLab.Clear();
            sqlDAGruLab.SelectCommand.Parameters["@IdLaboratorio"].Value = txtIdLaboratorio.Text;
            sqlDAGruLab.Fill(dsLaboratorio1, "GruLab");
        }

        private void UpdateDataSet1()
        {
            // Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
            // original			DataSet objDataSetChanges = new DataSet();
            LancNeo.dsLaboratorio objDataSetChanges = new LancNeo.dsLaboratorio();
            // Detener las ediciones actuales.
            // original			this.BindingContext[dsgeneral].EndCurrentEdit();
            this.BindingContext[dsLaboratorio1, "Laboratorio"].EndCurrentEdit();
            this.BindingContext[dsLaboratorio1, "GruLab"].EndCurrentEdit();

            // Obtener los cambios realizados en el conjunto de datos principal.
            // original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));

            objDataSetChanges = ((LancNeo.dsLaboratorio)(dsLaboratorio1.GetChanges()));

            // Comprobar si se han realizado cambios.
            if ((objDataSetChanges != null))
            {
                try
                {
                    // Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
                    // llamando al método de actualización y pasando el conjunto de datos y los parámetros.
                    this.UpdateDataSource1(objDataSetChanges);
                    dsLaboratorio1.Merge(objDataSetChanges);
                    dsLaboratorio1.AcceptChanges();
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
        private void UpdateDataSource1(LancNeo.dsLaboratorio ChangedRows)
        {
            try
            {
                // Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
                if ((ChangedRows != null))
                {
                    // Abra la conexión.
                    this.sqlConn.Open();
                    // Intente actualizar el origen de datos.
                    sqlDALaboratorio.Update(ChangedRows);
                    sqlDAGruLab.Update(ChangedRows);
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

        private void txtIdLaboratorio_TextChanged(object sender, EventArgs e)
        {
            if (txtIdLaboratorio.Text != "")
            {
                dsLaboratorio1.GruLab.Clear();
                sqlDAGruLab.SelectCommand.Parameters["@IdLaboratorio"].Value = txtIdLaboratorio.Text;
                sqlDAGruLab.Fill(dsLaboratorio1, "GruLab");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


	}
}
