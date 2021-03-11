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
	/// Descripción breve de AsfalticoMal.
	/// </summary>
	public class AsfalticoMal : CatalogoGenerico
	{
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Label label1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAAsfalticoMal;
        private LancNeo.dsAsfalticoMal dsAsfalticoMal1;
		protected Soluciones2000.Tools.WinLib.tbBtn tbBtn1;
		protected Soluciones2000.Tools.WinLib.tbBtn tbBtn2;
		private System.Windows.Forms.Label label2;
		private System.Data.SqlClient.SqlDataAdapter sqlDAMedida;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private LancNeo.dsMedida dsMedida1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAMalla;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Windows.Forms.ComboBox cmbMedida;
		private LancNeo.dsMalla dsMalla1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private DataGridView dgMateriales;
        private BindingSource asfalticoMalBindingSource;
        private SqlConnection sqlConn;
        protected tbBtn tbBtn3;
        private DataGridViewTextBoxColumn folioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn renglonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mallaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn linea1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn linea2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quepasaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn proyectoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Designacion;
        private IContainer components;

		public AsfalticoMal()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsfalticoMal));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlDAAsfalticoMal = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsAsfalticoMal1 = new LancNeo.dsAsfalticoMal();
            this.tbBtn1 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.tbBtn2 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.cmbMedida = new System.Windows.Forms.ComboBox();
            this.dsMedida1 = new LancNeo.dsMedida();
            this.label2 = new System.Windows.Forms.Label();
            this.sqlDAMedida = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAMalla = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.dsMalla1 = new LancNeo.dsMalla();
            this.dgMateriales = new System.Windows.Forms.DataGridView();
            this.asfalticoMalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbBtn3 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.folioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renglonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mallaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linea1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linea2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quepasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAsfalticoMal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedida1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMalla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asfalticoMalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 505);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(778, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(778, 64);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Visible = false;
            // 
            // btnUltimo
            // 
            this.btnUltimo.Visible = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Visible = false;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Visible = false;
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Visible = false;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Visible = false;
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(56, 73);
            this.txtFolio.MaxLength = 10;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(64, 20);
            this.txtFolio.TabIndex = 54;
            this.txtFolio.TextChanged += new System.EventHandler(this.txtFolio_TextChanged);
            this.txtFolio.Validated += new System.EventHandler(this.txtFolio_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "FOLIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sqlDAAsfalticoMal
            // 
            this.sqlDAAsfalticoMal.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAAsfalticoMal.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAAsfalticoMal.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAAsfalticoMal.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "AsfalticoMal", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("Renglon", "Renglon"),
                        new System.Data.Common.DataColumnMapping("Malla", "Malla"),
                        new System.Data.Common.DataColumnMapping("Linea1", "Linea1"),
                        new System.Data.Common.DataColumnMapping("Linea2", "Linea2"),
                        new System.Data.Common.DataColumnMapping("Quepasa", "Quepasa"),
                        new System.Data.Common.DataColumnMapping("Proyecto", "Proyecto"),
                        new System.Data.Common.DataColumnMapping("Designacion", "Designacion")})});
            this.sqlDAAsfalticoMal.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Folio", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Folio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Renglon", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Renglon", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Malla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Malla", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Malla", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "Malla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Linea1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Linea1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Linea1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Linea2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Linea2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Linea2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Quepasa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Quepasa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Quepasa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Quepasa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Proyecto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Proyecto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Proyecto", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Proyecto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Designacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Designacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Designacion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designacion", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.Char, 0, "Folio"),
            new System.Data.SqlClient.SqlParameter("@Renglon", System.Data.SqlDbType.SmallInt, 0, "Renglon"),
            new System.Data.SqlClient.SqlParameter("@Malla", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "Malla", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Linea1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Linea2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea2", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Quepasa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Quepasa", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Proyecto", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Proyecto", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Designacion", System.Data.SqlDbType.NVarChar, 0, "Designacion")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        Folio, Renglon, Malla, Linea1, Linea2, Quepasa, Proyecto, Designaci" +
    "on\r\nFROM            AsfalticoMal\r\nWHERE        (Folio = @Folio)\r\nORDER BY Folio";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.Char, 10, "Folio")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.Char, 0, "Folio"),
            new System.Data.SqlClient.SqlParameter("@Renglon", System.Data.SqlDbType.SmallInt, 0, "Renglon"),
            new System.Data.SqlClient.SqlParameter("@Malla", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "Malla", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Linea1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Linea2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea2", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Quepasa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Quepasa", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Proyecto", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Proyecto", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Designacion", System.Data.SqlDbType.NVarChar, 0, "Designacion"),
            new System.Data.SqlClient.SqlParameter("@Original_Folio", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Folio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Renglon", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Renglon", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Malla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Malla", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Malla", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "Malla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Linea1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Linea1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Linea1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Linea2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Linea2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Linea2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Linea2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Quepasa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Quepasa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Quepasa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Quepasa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Proyecto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Proyecto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Proyecto", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Proyecto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Designacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Designacion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Designacion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Designacion", System.Data.DataRowVersion.Original, null)});
            // 
            // dsAsfalticoMal1
            // 
            this.dsAsfalticoMal1.DataSetName = "dsAsfalticoMal";
            this.dsAsfalticoMal1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsAsfalticoMal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbBtn1
            // 
            this.tbBtn1.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn1.Icon")));
            this.tbBtn1.Location = new System.Drawing.Point(450, 73);
            this.tbBtn1.Name = "tbBtn1";
            this.tbBtn1.Size = new System.Drawing.Size(64, 64);
            this.tbBtn1.TabIndex = 58;
            this.tbBtn1.Visible = false;
            this.tbBtn1.Load += new System.EventHandler(this.tbBtn1_Load);
            this.tbBtn1.Click += new System.EventHandler(this.tbBtn1_Click);
            // 
            // tbBtn2
            // 
            this.tbBtn2.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn2.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn2.Icon")));
            this.tbBtn2.Location = new System.Drawing.Point(132, 73);
            this.tbBtn2.Name = "tbBtn2";
            this.tbBtn2.Size = new System.Drawing.Size(64, 64);
            this.tbBtn2.TabIndex = 59;
            this.tbBtn2.Load += new System.EventHandler(this.tbBtn2_Load);
            this.tbBtn2.Click += new System.EventHandler(this.tbBtn2_Click);
            // 
            // cmbMedida
            // 
            this.cmbMedida.DataSource = this.dsMedida1.AsfalticoReq;
            this.cmbMedida.DisplayMember = "IdTamaño";
            this.cmbMedida.Location = new System.Drawing.Point(322, 73);
            this.cmbMedida.Name = "cmbMedida";
            this.cmbMedida.Size = new System.Drawing.Size(121, 21);
            this.cmbMedida.TabIndex = 60;
            this.cmbMedida.ValueMember = "IdTamaño";
            this.cmbMedida.Visible = false;
            this.cmbMedida.SelectedIndexChanged += new System.EventHandler(this.cmbMedida_SelectedIndexChanged);
            // 
            // dsMedida1
            // 
            this.dsMedida1.DataSetName = "dsMedida";
            this.dsMedida1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsMedida1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Medida malla:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sqlDAMedida
            // 
            this.sqlDAMedida.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAMedida.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "AsfalticoReq", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdTamaño", "IdTamaño")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT DISTINCT IdTamaño FROM AsfalticoReq";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            // 
            // sqlDAMalla
            // 
            this.sqlDAMalla.SelectCommand = this.sqlSelectCommand3;
            this.sqlDAMalla.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "AsfalticoReq", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Renglon", "Renglon"),
                        new System.Data.Common.DataColumnMapping("IdMalla", "IdMalla"),
                        new System.Data.Common.DataColumnMapping("Linea1", "Linea1"),
                        new System.Data.Common.DataColumnMapping("Linea2", "Linea2")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT        Renglon, IdMalla, Linea1, Linea2, quepasa, proyecto, Designacion\r\nF" +
    "ROM            AsfalticoReq\r\nWHERE        (IdTamaño = @Tamaño)\r\nORDER BY Renglon" +
    "";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Tamaño", System.Data.SqlDbType.NVarChar, 6, "IdTamaño")});
            // 
            // dsMalla1
            // 
            this.dsMalla1.DataSetName = "dsMalla";
            this.dsMalla1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsMalla1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgMateriales
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgMateriales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgMateriales.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMateriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folioDataGridViewTextBoxColumn,
            this.renglonDataGridViewTextBoxColumn,
            this.mallaDataGridViewTextBoxColumn,
            this.linea1DataGridViewTextBoxColumn,
            this.linea2DataGridViewTextBoxColumn,
            this.quepasaDataGridViewTextBoxColumn,
            this.proyectoDataGridViewTextBoxColumn,
            this.Designacion});
            this.dgMateriales.DataSource = this.asfalticoMalBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMateriales.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgMateriales.Location = new System.Drawing.Point(11, 143);
            this.dgMateriales.Name = "dgMateriales";
            this.dgMateriales.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgMateriales.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgMateriales.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgMateriales.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgMateriales.Size = new System.Drawing.Size(755, 356);
            this.dgMateriales.TabIndex = 62;
            // 
            // asfalticoMalBindingSource
            // 
            this.asfalticoMalBindingSource.DataMember = "AsfalticoMal";
            this.asfalticoMalBindingSource.DataSource = this.dsAsfalticoMal1;
            // 
            // tbBtn3
            // 
            this.tbBtn3.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn3.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn3.Icon")));
            this.tbBtn3.Location = new System.Drawing.Point(528, 73);
            this.tbBtn3.Name = "tbBtn3";
            this.tbBtn3.Size = new System.Drawing.Size(64, 64);
            this.tbBtn3.TabIndex = 63;
            this.tbBtn3.Visible = false;
            this.tbBtn3.Click += new System.EventHandler(this.tbBtn3_Click);
            // 
            // folioDataGridViewTextBoxColumn
            // 
            this.folioDataGridViewTextBoxColumn.DataPropertyName = "Folio";
            this.folioDataGridViewTextBoxColumn.HeaderText = "Folio";
            this.folioDataGridViewTextBoxColumn.Name = "folioDataGridViewTextBoxColumn";
            this.folioDataGridViewTextBoxColumn.Visible = false;
            // 
            // renglonDataGridViewTextBoxColumn
            // 
            this.renglonDataGridViewTextBoxColumn.DataPropertyName = "Renglon";
            this.renglonDataGridViewTextBoxColumn.HeaderText = "Renglon";
            this.renglonDataGridViewTextBoxColumn.Name = "renglonDataGridViewTextBoxColumn";
            // 
            // mallaDataGridViewTextBoxColumn
            // 
            this.mallaDataGridViewTextBoxColumn.DataPropertyName = "Malla";
            this.mallaDataGridViewTextBoxColumn.HeaderText = "Malla";
            this.mallaDataGridViewTextBoxColumn.Name = "mallaDataGridViewTextBoxColumn";
            // 
            // linea1DataGridViewTextBoxColumn
            // 
            this.linea1DataGridViewTextBoxColumn.DataPropertyName = "Linea1";
            this.linea1DataGridViewTextBoxColumn.HeaderText = "Linea1";
            this.linea1DataGridViewTextBoxColumn.Name = "linea1DataGridViewTextBoxColumn";
            // 
            // linea2DataGridViewTextBoxColumn
            // 
            this.linea2DataGridViewTextBoxColumn.DataPropertyName = "Linea2";
            this.linea2DataGridViewTextBoxColumn.HeaderText = "Linea2";
            this.linea2DataGridViewTextBoxColumn.Name = "linea2DataGridViewTextBoxColumn";
            // 
            // quepasaDataGridViewTextBoxColumn
            // 
            this.quepasaDataGridViewTextBoxColumn.DataPropertyName = "Quepasa";
            this.quepasaDataGridViewTextBoxColumn.HeaderText = "Quepasa";
            this.quepasaDataGridViewTextBoxColumn.Name = "quepasaDataGridViewTextBoxColumn";
            // 
            // proyectoDataGridViewTextBoxColumn
            // 
            this.proyectoDataGridViewTextBoxColumn.DataPropertyName = "Proyecto";
            this.proyectoDataGridViewTextBoxColumn.HeaderText = "Proyecto";
            this.proyectoDataGridViewTextBoxColumn.Name = "proyectoDataGridViewTextBoxColumn";
            // 
            // Designacion
            // 
            this.Designacion.DataPropertyName = "Designacion";
            this.Designacion.HeaderText = "Designacion";
            this.Designacion.Name = "Designacion";
            this.Designacion.ReadOnly = true;
            // 
            // AsfalticoMal
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(778, 527);
            this.Controls.Add(this.tbBtn1);
            this.Controls.Add(this.tbBtn2);
            this.Controls.Add(this.tbBtn3);
            this.Controls.Add(this.dgMateriales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMedida);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.label1);
            this.DAGeneral = this.sqlDAAsfalticoMal;
            this.dsGeneral = this.dsAsfalticoMal1;
            this.Name = "AsfalticoMal";
            this.NombreTabla = "AsfalticoMal";
            this.Text = "AsfalticoMal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AsfalticoMal_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtFolio, 0);
            this.Controls.SetChildIndex(this.cmbMedida, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dgMateriales, 0);
            this.Controls.SetChildIndex(this.tbBtn3, 0);
            this.Controls.SetChildIndex(this.tbBtn2, 0);
            this.Controls.SetChildIndex(this.tbBtn1, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsAsfalticoMal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMedida1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMalla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asfalticoMalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void AsfalticoMal_Load(object sender, System.EventArgs e)
		{
			sqlDAMedida.Fill(dsMedida1,"AsfalticoReq");
			cmbMedida.SelectedIndex = 0;	
		}

		private void txtFolio_TextChanged(object sender, System.EventArgs e)
		{
		}

		private void txtFolio_Validated(object sender, System.EventArgs e)
		{
		}

		private void tbBtn1_Click(object sender, System.EventArgs e)
		{
			int renglones = int.Parse(dgMateriales.RowCount.ToString());
			if (renglones <= 1)
			{
				renglones = dsMalla1.AsfalticoReq.Rows.Count;
				DataColumn[] Llave = new DataColumn[2]; 

				try 
				{
					for (int i = 0; i < renglones; i++)
					{
						Object[] Matriz = new Object[8]; 
						Llave[0] = dsAsfalticoMal1.Tables["AsfalticoMal"].Columns["Folio"];
						Llave[1] = dsAsfalticoMal1.Tables["AsfalticoMal"].Columns["Renglon"];
						Matriz[0] = txtFolio.Text;
						Matriz[1] = dsMalla1.Tables[0].Rows[i][0].ToString();
						Matriz[2] = dsMalla1.Tables[0].Rows[i][1].ToString();
						Matriz[3] = dsMalla1.Tables[0].Rows[i][2].ToString();
						if(dsMalla1.Tables[0].Rows[i][3].ToString() != "0")
						Matriz[4] = dsMalla1.Tables[0].Rows[i][3].ToString();
                        //						Matriz[5] = dsMalla1.Tables[0].Rows[i][4].ToString();
                        //						Matriz[6] = dsMalla1.Tables[0].Rows[i][5].ToString();
                        Matriz[7] = dsMalla1.Tables[0].Rows[i][6].ToString();
                        dsAsfalticoMal1.Tables["AsfalticoMal"].BeginLoadData();
						dsAsfalticoMal1.Tables["AsfalticoMal"].LoadDataRow(Matriz,	false); 
						dsAsfalticoMal1.Tables["AsfalticoMal"].EndLoadData();
					}
				}
				catch(Exception e1) 
				{
					MessageBox.Show(e1.ToString());
				}
				finally 
				{
				}
				dgMateriales.Show();
				dgMateriales.Refresh();
			}
		
		}

		private void tbBtn2_Click(object sender, System.EventArgs e)
		{
			dsAsfalticoMal1.Clear();
			sqlDAAsfalticoMal.SelectCommand.Parameters["@Folio"].Value = txtFolio.Text;
			sqlDAAsfalticoMal.Fill(dsAsfalticoMal1,"AsfalticoMal");	
			cmbMedida.Visible = true;
			tbBtn1.Visible = true;
            tbBtn3.Visible = true;
        }


		private void cmbMedida_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsMalla1.Clear();
			sqlDAMalla.SelectCommand.Parameters["@Tamaño"].Value = cmbMedida.SelectedValue;
			sqlDAMalla.Fill(dsMalla1,"AsfalticoReq");				
		
		}

		private void tbBtn2_Load(object sender, System.EventArgs e)
		{
		
		}

        private void tbBtn3_Click(object sender, EventArgs e)
        {
            btnGuardar_Click(sender, null);
        }

        private void tbBtn1_Load(object sender, EventArgs e)
        {

        }
    }
}
