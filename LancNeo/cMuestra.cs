using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de cMuestra.
	/// </summary>
	public class cMuestra : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Windows.Forms.Label lblIdObra;
		private System.Windows.Forms.Label label1;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
        private LancNeo.dsBusObra dsBusObra1;
        private LancNeo.dsBusMues dsBusMues1;
		private System.Data.SqlClient.SqlDataAdapter sqlDABusq;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		private System.Data.SqlClient.SqlDataAdapter sqlDACmuestra;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private LancNeo.dscMuestras dscMuestras1;
        public Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
		private System.Windows.Forms.CheckBox ckbVapor;
		private System.Windows.Forms.CheckBox ckbNormal;
		private System.Windows.Forms.CheckBox ckbCombinado;
        private LancNeo.CryRepSemcMuestras cryRepSemcMuestras1;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		private System.Windows.Forms.CheckBox cbkPrefijo;
		private System.Windows.Forms.TextBox txtIdobra;
		private System.Windows.Forms.CheckBox ckbCubos;
		private System.Data.SqlClient.SqlDataAdapter sqlDAUnidad;
		private System.Data.SqlClient.SqlCommand sqlCommand2;
        private LancNeo.dsUnidad dsUnidad1;
		private System.Windows.Forms.ComboBox cmbUnidad;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkVolumen;
        private DataGridView dgcMuestras;
        private BindingSource conMuestrasBindingSource;
        private DataGridViewTextBoxColumn idObraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pREMEZDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pTADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn labDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tmaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn revDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn m3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ollaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn obtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eLEMENTODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eJESDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nivDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn edifDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn d1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn d2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn d3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn d4DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn d5DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ee1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn d6DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ee2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn d7DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ee3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn d8DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ee4DataGridViewTextBoxColumn;
        private SqlCommand sqlSelectCommand2;
        private SqlDataAdapter sqlDAConN;
        private CryRepNo10NCo cryRepNo10NCo1;
        private CheckBox cbkAR;
        private Panel panel1;
        private SqlDataAdapter sqlDADiametro;
        private SqlCommand sqlCommand3;
        private dscMuestrasN dscMuestrasN1;
        private dsRepNo10NCo dsRepNo10NCo1;
        private IContainer components;

		public cMuestra()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cMuestra));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.cbkAR = new System.Windows.Forms.CheckBox();
            this.chkVolumen = new System.Windows.Forms.CheckBox();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.dsUnidad1 = new LancNeo.dsUnidad();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbCubos = new System.Windows.Forms.CheckBox();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.cbkPrefijo = new System.Windows.Forms.CheckBox();
            this.ckbCombinado = new System.Windows.Forms.CheckBox();
            this.ckbNormal = new System.Windows.Forms.CheckBox();
            this.ckbVapor = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.lblIdObra = new System.Windows.Forms.Label();
            this.dsBusMues1 = new LancNeo.dsBusMues();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDABusq = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dscMuestras1 = new LancNeo.dscMuestras();
            this.sqlDACmuestra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.cryRepSemcMuestras1 = new LancNeo.CryRepSemcMuestras();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDAUnidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dgcMuestras = new System.Windows.Forms.DataGridView();
            this.idObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREMEZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ollaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eLEMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eJESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ee1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ee2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ee3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ee4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conMuestrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAConN = new System.Data.SqlClient.SqlDataAdapter();
            this.cryRepNo10NCo1 = new LancNeo.CryRepNo10NCo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sqlDADiametro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.dscMuestrasN1 = new LancNeo.dscMuestrasN();
            this.dsRepNo10NCo1 = new LancNeo.dsRepNo10NCo();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusMues1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dscMuestras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcMuestras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conMuestrasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dscMuestrasN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepNo10NCo1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnVistaPrevia);
            this.panel2.Controls.Add(this.cbkAR);
            this.panel2.Controls.Add(this.chkVolumen);
            this.panel2.Controls.Add(this.cmbUnidad);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ckbCubos);
            this.panel2.Controls.Add(this.txtIdobra);
            this.panel2.Controls.Add(this.cbkPrefijo);
            this.panel2.Controls.Add(this.ckbCombinado);
            this.panel2.Controls.Add(this.ckbNormal);
            this.panel2.Controls.Add(this.ckbVapor);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbIdObra);
            this.panel2.Controls.Add(this.lblIdObra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1113, 72);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(456, 0);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 41;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Load += new System.EventHandler(this.btnVistaPrevia_Load);
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // cbkAR
            // 
            this.cbkAR.Location = new System.Drawing.Point(786, 40);
            this.cbkAR.Name = "cbkAR";
            this.cbkAR.Size = new System.Drawing.Size(158, 24);
            this.cbkAR.TabIndex = 79;
            this.cbkAR.Text = "Formato Alta Resistencia";
            // 
            // chkVolumen
            // 
            this.chkVolumen.Checked = true;
            this.chkVolumen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVolumen.Location = new System.Drawing.Point(786, 14);
            this.chkVolumen.Name = "chkVolumen";
            this.chkVolumen.Size = new System.Drawing.Size(118, 24);
            this.chkVolumen.TabIndex = 78;
            this.chkVolumen.Text = "¿Volumen total?";
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsUnidad1, "Unidad.Undescr", true));
            this.cmbUnidad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsUnidad1, "Unidad.IdUnidad", true));
            this.cmbUnidad.DataSource = this.dsUnidad1.Unidad;
            this.cmbUnidad.DisplayMember = "Undescr";
            this.cmbUnidad.Location = new System.Drawing.Point(584, 14);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(80, 21);
            this.cmbUnidad.TabIndex = 76;
            this.cmbUnidad.ValueMember = "IdUnidad";
            this.cmbUnidad.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            this.cmbUnidad.Click += new System.EventHandler(this.cmbUnidad_Click);
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
            this.label5.Location = new System.Drawing.Point(540, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Unidad:";
            // 
            // ckbCubos
            // 
            this.ckbCubos.Location = new System.Drawing.Point(256, 40);
            this.ckbCubos.Name = "ckbCubos";
            this.ckbCubos.Size = new System.Drawing.Size(64, 24);
            this.ckbCubos.TabIndex = 75;
            this.ckbCubos.Text = "Cubos";
            this.ckbCubos.Visible = false;
            this.ckbCubos.Click += new System.EventHandler(this.ckbCubos_Click);
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(674, 14);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.Size = new System.Drawing.Size(76, 20);
            this.txtIdobra.TabIndex = 74;
            this.txtIdobra.Text = "textBox1";
            this.txtIdobra.Visible = false;
            // 
            // cbkPrefijo
            // 
            this.cbkPrefijo.Checked = true;
            this.cbkPrefijo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkPrefijo.Location = new System.Drawing.Point(366, 40);
            this.cbkPrefijo.Name = "cbkPrefijo";
            this.cbkPrefijo.Size = new System.Drawing.Size(74, 24);
            this.cbkPrefijo.TabIndex = 73;
            this.cbkPrefijo.Text = "No prefijo";
            this.cbkPrefijo.CheckedChanged += new System.EventHandler(this.cbkPrefijo_CheckedChanged);
            // 
            // ckbCombinado
            // 
            this.ckbCombinado.Location = new System.Drawing.Point(160, 40);
            this.ckbCombinado.Name = "ckbCombinado";
            this.ckbCombinado.Size = new System.Drawing.Size(88, 24);
            this.ckbCombinado.TabIndex = 44;
            this.ckbCombinado.Text = "Combinado";
            this.ckbCombinado.Visible = false;
            this.ckbCombinado.Click += new System.EventHandler(this.ckbCombinado_Click);
            // 
            // ckbNormal
            // 
            this.ckbNormal.Checked = true;
            this.ckbNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbNormal.Location = new System.Drawing.Point(80, 40);
            this.ckbNormal.Name = "ckbNormal";
            this.ckbNormal.Size = new System.Drawing.Size(72, 24);
            this.ckbNormal.TabIndex = 43;
            this.ckbNormal.Text = "Normal";
            this.ckbNormal.Visible = false;
            this.ckbNormal.Click += new System.EventHandler(this.ckbNormal_Click);
            // 
            // ckbVapor
            // 
            this.ckbVapor.Location = new System.Drawing.Point(16, 40);
            this.ckbVapor.Name = "ckbVapor";
            this.ckbVapor.Size = new System.Drawing.Size(56, 24);
            this.ckbVapor.TabIndex = 42;
            this.ckbVapor.Text = "Vapor";
            this.ckbVapor.Visible = false;
            this.ckbVapor.Click += new System.EventHandler(this.ckbVapor_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Consulta de muestras";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(384, 14);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(56, 21);
            this.cmbIdObra.TabIndex = 39;
            this.cmbIdObra.Tag = "ACE";
            this.cmbIdObra.ValueMember = "Idobra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblIdObra
            // 
            this.lblIdObra.AutoSize = true;
            this.lblIdObra.Location = new System.Drawing.Point(336, 16);
            this.lblIdObra.Name = "lblIdObra";
            this.lblIdObra.Size = new System.Drawing.Size(42, 13);
            this.lblIdObra.TabIndex = 1;
            this.lblIdObra.Text = "IdObra:";
            this.lblIdObra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dsBusMues1
            // 
            this.dsBusMues1.DataSetName = "dsBusMues";
            this.dsBusMues1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusMues1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDABusq
            // 
            this.sqlDABusq.SelectCommand = this.sqlSelectCommand4;
            this.sqlDABusq.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Muestreador", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = resources.GetString("sqlSelectCommand4.CommandText");
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // dscMuestras1
            // 
            this.dscMuestras1.DataSetName = "dscMuestras";
            this.dscMuestras1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dscMuestras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDACmuestra
            // 
            this.sqlDACmuestra.SelectCommand = this.sqlSelectCommand1;
            this.sqlDACmuestra.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ConMuestras", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Anos", "Anos"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
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
                        new System.Data.Common.DataColumnMapping("d1", "d1"),
                        new System.Data.Common.DataColumnMapping("v1", "v1"),
                        new System.Data.Common.DataColumnMapping("N1", "N1"),
                        new System.Data.Common.DataColumnMapping("Vap1", "Vap1"),
                        new System.Data.Common.DataColumnMapping("d2", "d2"),
                        new System.Data.Common.DataColumnMapping("v2", "v2"),
                        new System.Data.Common.DataColumnMapping("N2", "N2"),
                        new System.Data.Common.DataColumnMapping("Vap2", "Vap2"),
                        new System.Data.Common.DataColumnMapping("d3", "d3"),
                        new System.Data.Common.DataColumnMapping("N3", "N3"),
                        new System.Data.Common.DataColumnMapping("3 días", "3 días"),
                        new System.Data.Common.DataColumnMapping("d4", "d4"),
                        new System.Data.Common.DataColumnMapping("N4", "N4"),
                        new System.Data.Common.DataColumnMapping("7 días", "7 días"),
                        new System.Data.Common.DataColumnMapping("d5", "d5"),
                        new System.Data.Common.DataColumnMapping("N5", "N5"),
                        new System.Data.Common.DataColumnMapping("Ee1", "Ee1"),
                        new System.Data.Common.DataColumnMapping("d6", "d6"),
                        new System.Data.Common.DataColumnMapping("N6", "N6"),
                        new System.Data.Common.DataColumnMapping("Ee2", "Ee2"),
                        new System.Data.Common.DataColumnMapping("d7", "d7"),
                        new System.Data.Common.DataColumnMapping("N7", "N7"),
                        new System.Data.Common.DataColumnMapping("Ee3", "Ee3"),
                        new System.Data.Common.DataColumnMapping("d8", "d8"),
                        new System.Data.Common.DataColumnMapping("N8", "N8"),
                        new System.Data.Common.DataColumnMapping("Ee4", "Ee4"),
                        new System.Data.Common.DataColumnMapping("Lab", "Lab")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "[ConMuestras]";
            this.sqlSelectCommand1.CommandTimeout = 600;
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdReporte", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Rep", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@TV", System.Data.SqlDbType.Int, 4)});
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayBackgroundEdge = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1109, 538);
            this.crystalReportViewer1.TabIndex = 7;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Visible = false;
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
            // dgcMuestras
            // 
            this.dgcMuestras.AutoGenerateColumns = false;
            this.dgcMuestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcMuestras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObraDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.mueDataGridViewTextBoxColumn,
            this.pREMEZDataGridViewTextBoxColumn,
            this.pTADataGridViewTextBoxColumn,
            this.labDataGridViewTextBoxColumn,
            this.resDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.tmaDataGridViewTextBoxColumn,
            this.revDataGridViewTextBoxColumn,
            this.tADataGridViewTextBoxColumn,
            this.m3DataGridViewTextBoxColumn,
            this.ollaDataGridViewTextBoxColumn,
            this.remisDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.obtDataGridViewTextBoxColumn,
            this.eLEMENTODataGridViewTextBoxColumn,
            this.eJESDataGridViewTextBoxColumn,
            this.nivDataGridViewTextBoxColumn,
            this.edifDataGridViewTextBoxColumn,
            this.d1DataGridViewTextBoxColumn,
            this.v1DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.d2DataGridViewTextBoxColumn,
            this.v2DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.d3DataGridViewTextBoxColumn,
            this.dDataGridViewTextBoxColumn,
            this.d4DataGridViewTextBoxColumn,
            this.dDataGridViewTextBoxColumn1,
            this.d5DataGridViewTextBoxColumn,
            this.ee1DataGridViewTextBoxColumn,
            this.d6DataGridViewTextBoxColumn,
            this.ee2DataGridViewTextBoxColumn,
            this.d7DataGridViewTextBoxColumn,
            this.ee3DataGridViewTextBoxColumn,
            this.d8DataGridViewTextBoxColumn,
            this.ee4DataGridViewTextBoxColumn});
            this.dgcMuestras.DataSource = this.conMuestrasBindingSource;
            this.dgcMuestras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcMuestras.Location = new System.Drawing.Point(0, 0);
            this.dgcMuestras.Name = "dgcMuestras";
            this.dgcMuestras.Size = new System.Drawing.Size(1109, 538);
            this.dgcMuestras.TabIndex = 8;
            // 
            // idObraDataGridViewTextBoxColumn
            // 
            this.idObraDataGridViewTextBoxColumn.DataPropertyName = "IdObra";
            this.idObraDataGridViewTextBoxColumn.HeaderText = "IdObra";
            this.idObraDataGridViewTextBoxColumn.Name = "idObraDataGridViewTextBoxColumn";
            this.idObraDataGridViewTextBoxColumn.Width = 60;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha ";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha ";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 60;
            // 
            // mueDataGridViewTextBoxColumn
            // 
            this.mueDataGridViewTextBoxColumn.DataPropertyName = "Mue";
            this.mueDataGridViewTextBoxColumn.HeaderText = "Mue";
            this.mueDataGridViewTextBoxColumn.Name = "mueDataGridViewTextBoxColumn";
            this.mueDataGridViewTextBoxColumn.Width = 50;
            // 
            // pREMEZDataGridViewTextBoxColumn
            // 
            this.pREMEZDataGridViewTextBoxColumn.DataPropertyName = "PREMEZ.";
            this.pREMEZDataGridViewTextBoxColumn.HeaderText = "PREMEZ.";
            this.pREMEZDataGridViewTextBoxColumn.Name = "pREMEZDataGridViewTextBoxColumn";
            this.pREMEZDataGridViewTextBoxColumn.Width = 70;
            // 
            // pTADataGridViewTextBoxColumn
            // 
            this.pTADataGridViewTextBoxColumn.DataPropertyName = "PTA";
            this.pTADataGridViewTextBoxColumn.HeaderText = "PTA";
            this.pTADataGridViewTextBoxColumn.Name = "pTADataGridViewTextBoxColumn";
            this.pTADataGridViewTextBoxColumn.Width = 50;
            // 
            // labDataGridViewTextBoxColumn
            // 
            this.labDataGridViewTextBoxColumn.DataPropertyName = "Lab";
            this.labDataGridViewTextBoxColumn.HeaderText = "Lab";
            this.labDataGridViewTextBoxColumn.Name = "labDataGridViewTextBoxColumn";
            this.labDataGridViewTextBoxColumn.Width = 60;
            // 
            // resDataGridViewTextBoxColumn
            // 
            this.resDataGridViewTextBoxColumn.DataPropertyName = "Res";
            this.resDataGridViewTextBoxColumn.HeaderText = "Res";
            this.resDataGridViewTextBoxColumn.Name = "resDataGridViewTextBoxColumn";
            this.resDataGridViewTextBoxColumn.Width = 70;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.Width = 70;
            // 
            // tmaDataGridViewTextBoxColumn
            // 
            this.tmaDataGridViewTextBoxColumn.DataPropertyName = "Tma";
            this.tmaDataGridViewTextBoxColumn.HeaderText = "Tma";
            this.tmaDataGridViewTextBoxColumn.Name = "tmaDataGridViewTextBoxColumn";
            this.tmaDataGridViewTextBoxColumn.Width = 50;
            // 
            // revDataGridViewTextBoxColumn
            // 
            this.revDataGridViewTextBoxColumn.DataPropertyName = "Rev";
            this.revDataGridViewTextBoxColumn.HeaderText = "Rev";
            this.revDataGridViewTextBoxColumn.Name = "revDataGridViewTextBoxColumn";
            this.revDataGridViewTextBoxColumn.Width = 50;
            // 
            // tADataGridViewTextBoxColumn
            // 
            this.tADataGridViewTextBoxColumn.DataPropertyName = "T.A.";
            this.tADataGridViewTextBoxColumn.HeaderText = "T.A.";
            this.tADataGridViewTextBoxColumn.Name = "tADataGridViewTextBoxColumn";
            this.tADataGridViewTextBoxColumn.Width = 70;
            // 
            // m3DataGridViewTextBoxColumn
            // 
            this.m3DataGridViewTextBoxColumn.DataPropertyName = "m3  ";
            this.m3DataGridViewTextBoxColumn.HeaderText = "m3  ";
            this.m3DataGridViewTextBoxColumn.Name = "m3DataGridViewTextBoxColumn";
            this.m3DataGridViewTextBoxColumn.Width = 70;
            // 
            // ollaDataGridViewTextBoxColumn
            // 
            this.ollaDataGridViewTextBoxColumn.DataPropertyName = "Olla";
            this.ollaDataGridViewTextBoxColumn.HeaderText = "Olla";
            this.ollaDataGridViewTextBoxColumn.Name = "ollaDataGridViewTextBoxColumn";
            // 
            // remisDataGridViewTextBoxColumn
            // 
            this.remisDataGridViewTextBoxColumn.DataPropertyName = "Remis";
            this.remisDataGridViewTextBoxColumn.HeaderText = "Remis";
            this.remisDataGridViewTextBoxColumn.Name = "remisDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.Width = 70;
            // 
            // obtDataGridViewTextBoxColumn
            // 
            this.obtDataGridViewTextBoxColumn.DataPropertyName = "Obt";
            this.obtDataGridViewTextBoxColumn.HeaderText = "Obt";
            this.obtDataGridViewTextBoxColumn.Name = "obtDataGridViewTextBoxColumn";
            this.obtDataGridViewTextBoxColumn.Width = 50;
            // 
            // eLEMENTODataGridViewTextBoxColumn
            // 
            this.eLEMENTODataGridViewTextBoxColumn.DataPropertyName = "ELEMENTO";
            this.eLEMENTODataGridViewTextBoxColumn.HeaderText = "ELEMENTO";
            this.eLEMENTODataGridViewTextBoxColumn.Name = "eLEMENTODataGridViewTextBoxColumn";
            // 
            // eJESDataGridViewTextBoxColumn
            // 
            this.eJESDataGridViewTextBoxColumn.DataPropertyName = "EJES";
            this.eJESDataGridViewTextBoxColumn.HeaderText = "EJES";
            this.eJESDataGridViewTextBoxColumn.Name = "eJESDataGridViewTextBoxColumn";
            // 
            // nivDataGridViewTextBoxColumn
            // 
            this.nivDataGridViewTextBoxColumn.DataPropertyName = "Niv.";
            this.nivDataGridViewTextBoxColumn.HeaderText = "Niv.";
            this.nivDataGridViewTextBoxColumn.Name = "nivDataGridViewTextBoxColumn";
            // 
            // edifDataGridViewTextBoxColumn
            // 
            this.edifDataGridViewTextBoxColumn.DataPropertyName = "Edif";
            this.edifDataGridViewTextBoxColumn.HeaderText = "Edif";
            this.edifDataGridViewTextBoxColumn.Name = "edifDataGridViewTextBoxColumn";
            // 
            // d1DataGridViewTextBoxColumn
            // 
            this.d1DataGridViewTextBoxColumn.DataPropertyName = "d1";
            this.d1DataGridViewTextBoxColumn.HeaderText = "d1";
            this.d1DataGridViewTextBoxColumn.Name = "d1DataGridViewTextBoxColumn";
            this.d1DataGridViewTextBoxColumn.Width = 40;
            // 
            // v1DataGridViewTextBoxColumn
            // 
            this.v1DataGridViewTextBoxColumn.DataPropertyName = "V 1";
            this.v1DataGridViewTextBoxColumn.HeaderText = "V 1";
            this.v1DataGridViewTextBoxColumn.Name = "v1DataGridViewTextBoxColumn";
            this.v1DataGridViewTextBoxColumn.Width = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "1 ";
            this.dataGridViewTextBoxColumn1.HeaderText = "1 ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // d2DataGridViewTextBoxColumn
            // 
            this.d2DataGridViewTextBoxColumn.DataPropertyName = "d2";
            this.d2DataGridViewTextBoxColumn.HeaderText = "d2";
            this.d2DataGridViewTextBoxColumn.Name = "d2DataGridViewTextBoxColumn";
            this.d2DataGridViewTextBoxColumn.Width = 40;
            // 
            // v2DataGridViewTextBoxColumn
            // 
            this.v2DataGridViewTextBoxColumn.DataPropertyName = "V 2";
            this.v2DataGridViewTextBoxColumn.HeaderText = "V 2";
            this.v2DataGridViewTextBoxColumn.Name = "v2DataGridViewTextBoxColumn";
            this.v2DataGridViewTextBoxColumn.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "2 ";
            this.dataGridViewTextBoxColumn2.HeaderText = "2 ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // d3DataGridViewTextBoxColumn
            // 
            this.d3DataGridViewTextBoxColumn.DataPropertyName = "d3";
            this.d3DataGridViewTextBoxColumn.HeaderText = "d3";
            this.d3DataGridViewTextBoxColumn.Name = "d3DataGridViewTextBoxColumn";
            this.d3DataGridViewTextBoxColumn.Width = 40;
            // 
            // dDataGridViewTextBoxColumn
            // 
            this.dDataGridViewTextBoxColumn.DataPropertyName = "3 d";
            this.dDataGridViewTextBoxColumn.HeaderText = "3 d";
            this.dDataGridViewTextBoxColumn.Name = "dDataGridViewTextBoxColumn";
            this.dDataGridViewTextBoxColumn.Width = 40;
            // 
            // d4DataGridViewTextBoxColumn
            // 
            this.d4DataGridViewTextBoxColumn.DataPropertyName = "d4";
            this.d4DataGridViewTextBoxColumn.HeaderText = "d4";
            this.d4DataGridViewTextBoxColumn.Name = "d4DataGridViewTextBoxColumn";
            this.d4DataGridViewTextBoxColumn.Width = 50;
            // 
            // dDataGridViewTextBoxColumn1
            // 
            this.dDataGridViewTextBoxColumn1.DataPropertyName = "7 d";
            this.dDataGridViewTextBoxColumn1.HeaderText = "7 d";
            this.dDataGridViewTextBoxColumn1.Name = "dDataGridViewTextBoxColumn1";
            this.dDataGridViewTextBoxColumn1.Width = 40;
            // 
            // d5DataGridViewTextBoxColumn
            // 
            this.d5DataGridViewTextBoxColumn.DataPropertyName = "d5 ";
            this.d5DataGridViewTextBoxColumn.HeaderText = "d5 ";
            this.d5DataGridViewTextBoxColumn.Name = "d5DataGridViewTextBoxColumn";
            this.d5DataGridViewTextBoxColumn.Width = 40;
            // 
            // ee1DataGridViewTextBoxColumn
            // 
            this.ee1DataGridViewTextBoxColumn.DataPropertyName = "Ee1";
            this.ee1DataGridViewTextBoxColumn.HeaderText = "Ee1";
            this.ee1DataGridViewTextBoxColumn.Name = "ee1DataGridViewTextBoxColumn";
            this.ee1DataGridViewTextBoxColumn.Width = 50;
            // 
            // d6DataGridViewTextBoxColumn
            // 
            this.d6DataGridViewTextBoxColumn.DataPropertyName = "d6 ";
            this.d6DataGridViewTextBoxColumn.HeaderText = "d6 ";
            this.d6DataGridViewTextBoxColumn.Name = "d6DataGridViewTextBoxColumn";
            this.d6DataGridViewTextBoxColumn.Width = 40;
            // 
            // ee2DataGridViewTextBoxColumn
            // 
            this.ee2DataGridViewTextBoxColumn.DataPropertyName = "Ee2";
            this.ee2DataGridViewTextBoxColumn.HeaderText = "Ee2";
            this.ee2DataGridViewTextBoxColumn.Name = "ee2DataGridViewTextBoxColumn";
            this.ee2DataGridViewTextBoxColumn.Width = 50;
            // 
            // d7DataGridViewTextBoxColumn
            // 
            this.d7DataGridViewTextBoxColumn.DataPropertyName = "d7 ";
            this.d7DataGridViewTextBoxColumn.HeaderText = "d7 ";
            this.d7DataGridViewTextBoxColumn.Name = "d7DataGridViewTextBoxColumn";
            this.d7DataGridViewTextBoxColumn.Width = 40;
            // 
            // ee3DataGridViewTextBoxColumn
            // 
            this.ee3DataGridViewTextBoxColumn.DataPropertyName = "Ee3";
            this.ee3DataGridViewTextBoxColumn.HeaderText = "Ee3";
            this.ee3DataGridViewTextBoxColumn.Name = "ee3DataGridViewTextBoxColumn";
            this.ee3DataGridViewTextBoxColumn.Width = 50;
            // 
            // d8DataGridViewTextBoxColumn
            // 
            this.d8DataGridViewTextBoxColumn.DataPropertyName = "d8 ";
            this.d8DataGridViewTextBoxColumn.HeaderText = "d8 ";
            this.d8DataGridViewTextBoxColumn.Name = "d8DataGridViewTextBoxColumn";
            this.d8DataGridViewTextBoxColumn.Width = 40;
            // 
            // ee4DataGridViewTextBoxColumn
            // 
            this.ee4DataGridViewTextBoxColumn.DataPropertyName = "Ee4";
            this.ee4DataGridViewTextBoxColumn.HeaderText = "Ee4";
            this.ee4DataGridViewTextBoxColumn.Name = "ee4DataGridViewTextBoxColumn";
            this.ee4DataGridViewTextBoxColumn.Width = 50;
            // 
            // conMuestrasBindingSource
            // 
            this.conMuestrasBindingSource.DataMember = "ConMuestras";
            this.conMuestrasBindingSource.DataSource = this.dscMuestras1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "ConMuestrasNA";
            this.sqlSelectCommand2.CommandTimeout = 600;
            this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdReporte", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdUnidad", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlDAConN
            // 
            this.sqlDAConN.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAConN.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ConMuestrasN", new System.Data.Common.DataColumnMapping[] {
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
                        new System.Data.Common.DataColumnMapping("MUCF", "MUCF")})});
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgcMuestras);
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 542);
            this.panel1.TabIndex = 9;
            // 
            // sqlDADiametro
            // 
            this.sqlDADiametro.SelectCommand = this.sqlCommand3;
            this.sqlDADiametro.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Unidad", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdUnidad", "IdUnidad"),
                        new System.Data.Common.DataColumnMapping("Factor", "Factor"),
                        new System.Data.Common.DataColumnMapping("Undescr", "Undescr"),
                        new System.Data.Common.DataColumnMapping("MaxagrUn", "MaxagrUn"),
                        new System.Data.Common.DataColumnMapping("RevenUn", "RevenUn")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "SELECT     IdDiam, Diametro, Figura\r\nFROM         Diametro\r\nWHERE     (IdDiam <> " +
    "1)";
            this.sqlCommand3.Connection = this.sqlConn;
            // 
            // dscMuestrasN1
            // 
            this.dscMuestrasN1.DataSetName = "dscMuestrasN";
            this.dscMuestrasN1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsRepNo10NCo1
            // 
            this.dsRepNo10NCo1.DataSetName = "dsRepNo10NCo";
            this.dsRepNo10NCo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cMuestra
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1113, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "cMuestra";
            this.Text = "cMuestra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.cMuestra_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusMues1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dscMuestras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcMuestras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conMuestrasBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dscMuestrasN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRepNo10NCo1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void cMuestra_Load(object sender, System.EventArgs e)
		{
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            sqlDABusObra.Fill(dsBusObra1, "Obra");
			sqlDAUnidad.Fill(dsUnidad1, "Unidad");

			int intTotCols = dscMuestras1.ConMuestras.Columns.Count;
//			dgcMuestras.PreferredColumnWidth = (this.panel2.Bounds.Width - intTotCols - 53 ) / intTotCols;
			int i = 0;
			DataGridTableStyle miest = new DataGridTableStyle();
			miest.MappingName = dscMuestras1.ConMuestras.TableName;
			foreach(DataColumn dc in dscMuestras1.ConMuestras.Columns)
			{
				DataGridTextBoxColumn col1 = new DataGridTextBoxColumn();
				col1.Width = System.Convert.ToInt32(dscMuestras1.ConMuestras.Columns[i].ColumnName.Length * 7.15);
				col1.HeaderText =  dscMuestras1.ConMuestras.Columns[i].ColumnName;
				col1.MappingName = dscMuestras1.ConMuestras.Columns[i].ColumnName;
					
				if(dscMuestras1.ConMuestras.Columns[i].ColumnName == "Hora")
					col1.Format = "HH.mm";
				miest.GridColumnStyles.Add(col1);
					
				i++;
			}
			miest.AlternatingBackColor = System.Drawing.Color.LightGray;
			miest.BackColor = System.Drawing.Color.Gainsboro;
			miest.ForeColor = System.Drawing.Color.Black;
			miest.GridLineColor = System.Drawing.Color.DimGray;
			miest.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			miest.HeaderFont = new System.Drawing.Font("Tahoma", 7.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			miest.HeaderForeColor = System.Drawing.Color.White;
			miest.LinkColor = System.Drawing.Color.MidnightBlue;
			miest.ReadOnly = true;
			miest.RowHeaderWidth = 45;
			miest.SelectionBackColor = System.Drawing.Color.CadetBlue;
			miest.SelectionForeColor = System.Drawing.Color.White;
			//dgcMuestras.TableStyles.Add(miest);
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			crystalReportViewer1.Visible = false;
			txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
			dgcMuestras.Visible = true;
			dscMuestras1.Clear();
            if (dgcMuestras.Rows.Count > 1)
                dgcMuestras.Rows.Clear();
			sqlDACmuestra.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text;
			if (ckbVapor.Checked)
				sqlDACmuestra.SelectCommand.Parameters["@Rep"].Value = 1;
			if (ckbNormal.Checked)
				sqlDACmuestra.SelectCommand.Parameters["@Rep"].Value = 2;
			if (ckbCombinado.Checked)
				sqlDACmuestra.SelectCommand.Parameters["@Rep"].Value = 3;
			if (ckbCubos.Checked)
				sqlDACmuestra.SelectCommand.Parameters["@Rep"].Value = 4;
			sqlDACmuestra.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue;;
			sqlDACmuestra.SelectCommand.Parameters["@TV"].Value       = (chkVolumen.Checked ? 1 : 0 );
			sqlDACmuestra.Fill(dscMuestras1,"ConMuestras");
			btnVistaPrevia.Visible = true;
			cbkPrefijo.Checked = true;
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
            dgcMuestras.Visible = false;
			crystalReportViewer1.Visible = true;

            cryRepNo10NCo1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
            cryRepNo10NCo1.SetDataSource(dsRepNo10NCo1);
            dsRepNo10NCo1.Clear();
            sqlDAConN.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text;
            sqlDAConN.SelectCommand.Parameters["@IdReporte"].Value = (cbkAR.Checked ? 1 : 0);
            sqlDAConN.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue; ;
            sqlDAConN.Fill(dsRepNo10NCo1, "RepSemNormal");
            sqlDADiametro.Fill(dsRepNo10NCo1, "Diametro");

            cryRepNo10NCo1.SetParameterValue("IdReporte", cbkAR.Checked);
            crystalReportViewer1.ReportSource = cryRepNo10NCo1;
		
		}

		private void cbkPrefijo_CheckedChanged(object sender, System.EventArgs e)
		{
			if (cbkPrefijo.Checked == false)
				txtIdobra.Text = txtIdobra.Text.Substring(0,3)+"%";
			else
				txtIdobra.Text = cmbIdObra.SelectedValue.ToString();

			crystalReportViewer1.Visible = false;
			dgcMuestras.Visible = true;
			dscMuestras1.Clear();
			sqlDACmuestra.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text;
			if (ckbVapor.Checked)
				sqlDACmuestra.SelectCommand.Parameters["@Rep"].Value = 1;
			if (ckbNormal.Checked)
				sqlDACmuestra.SelectCommand.Parameters["@Rep"].Value = 2;
			if (ckbCombinado.Checked)
				sqlDACmuestra.SelectCommand.Parameters["@Rep"].Value = 3;
			if (ckbCubos.Checked)
				sqlDACmuestra.SelectCommand.Parameters["@Rep"].Value = 4;
			sqlDACmuestra.SelectCommand.Parameters["@TV"].Value       = (chkVolumen.Checked ? 1 : 0 );
			sqlDACmuestra.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue;;
			sqlDACmuestra.Fill(dscMuestras1,"ConMuestras");
		}

		private void ckbVapor_Click(object sender, System.EventArgs e)
		{
			crystalReportViewer1.Visible = false;
			dgcMuestras.Visible = true;
			ckbNormal.Checked = false;
			ckbCombinado.Checked = false;
			ckbCubos.Checked = false;
		}

		private void ckbNormal_Click(object sender, System.EventArgs e)
		{
			crystalReportViewer1.Visible = false;
			dgcMuestras.Visible = true;
			ckbCombinado.Checked = false;
			ckbVapor.Checked = false;
			ckbCubos.Checked = false;
		}

		private void ckbCombinado_Click(object sender, System.EventArgs e)
		{
			crystalReportViewer1.Visible = false;
			dgcMuestras.Visible = true;
			ckbNormal.Checked = false;
			ckbVapor.Checked = false;
			ckbCubos.Checked = false;
		}

		private void ckbCubos_Click(object sender, System.EventArgs e)
		{
			crystalReportViewer1.Visible = false;
			dgcMuestras.Visible = true;
			ckbNormal.Checked = false;
			ckbVapor.Checked = false;
			ckbCombinado.Checked = false;
		}

		private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

        private void btnVistaPrevia_Load(object sender, EventArgs e)
        {

        }

        private void cmbUnidad_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = false;
            txtIdobra.Text = cmbIdObra.SelectedValue.ToString();
            dgcMuestras.Visible = true;
            dscMuestras1.Clear();
            if (dgcMuestras.Rows.Count > 1)
                dgcMuestras.Rows.Clear();
            sqlDACmuestra.SelectCommand.Parameters["@IdObra"].Value = txtIdobra.Text;
            if (ckbVapor.Checked)
                sqlDACmuestra.SelectCommand.Parameters["@Rep"].Value = 1;
            if (ckbNormal.Checked)
                sqlDACmuestra.SelectCommand.Parameters["@Rep"].Value = 2;
            if (ckbCombinado.Checked)
                sqlDACmuestra.SelectCommand.Parameters["@Rep"].Value = 3;
            if (ckbCubos.Checked)
                sqlDACmuestra.SelectCommand.Parameters["@Rep"].Value = 4;
            sqlDACmuestra.SelectCommand.Parameters["@IdUnidad"].Value = cmbUnidad.SelectedValue; ;
            sqlDACmuestra.SelectCommand.Parameters["@TV"].Value = (chkVolumen.Checked ? 1 : 0);
            sqlDACmuestra.Fill(dscMuestras1, "ConMuestras");
            btnVistaPrevia.Visible = true;
            cbkPrefijo.Checked = true;
        }

	}

}
