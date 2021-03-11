using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Experiencia.
	/// </summary>
	public class Experiencia : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblIdObra;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcretera;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlConnection sqlConn;
        private LancNeo.dsConcretera dsConcretera1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAdExperiencia;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private LancNeo.dsExperiencia dsExperiencia1;
		private System.Windows.Forms.ComboBox cmbIdConcretera;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.ToolTip toolTip1;
		protected Soluciones2000.Tools.WinLib.tbBtn btnEliminar;
		public System.Data.SqlClient.SqlCommand sqlCMBorra;
        private DataGridView dgExperiencia;
        private DataGridViewTextBoxColumn premezDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ptaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tmaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn revDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn grDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn muestrasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn a7DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aEEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aEEDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fIniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fFinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn d3A7DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn d3AEEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn d7AEEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pruebaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn identificadorDataGridViewTextBoxColumn;
        private BindingSource experienciaBindingSource;
        protected Soluciones2000.Tools.WinLib.tbBtn btnCalculaTodas;
        public System.Data.SqlClient.SqlCommand sqlCCalcula;
		private System.ComponentModel.IContainer components;

		public Experiencia()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Experiencia));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsExperiencia1 = new LancNeo.dsExperiencia();
            this.btnEliminar = new Soluciones2000.Tools.WinLib.tbBtn();
            this.btnCalculaTodas = new Soluciones2000.Tools.WinLib.tbBtn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIdConcretera = new System.Windows.Forms.ComboBox();
            this.dsConcretera1 = new LancNeo.dsConcretera();
            this.lblIdObra = new System.Windows.Forms.Label();
            this.sqlDAConcretera = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDAdExperiencia = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sqlCMBorra = new System.Data.SqlClient.SqlCommand();
            this.dgExperiencia = new System.Windows.Forms.DataGridView();
            this.premezDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muestrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aEEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d3A7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d3AEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d7AEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pruebaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlCCalcula = new System.Data.SqlClient.SqlCommand();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsExperiencia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExperiencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.btnCalculaTodas);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbIdConcretera);
            this.panel2.Controls.Add(this.lblIdObra);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 74);
            this.panel2.TabIndex = 6;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 800;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsExperiencia1.Experiencia;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(536, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 41;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar experiencia para eliminar");
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsExperiencia1
            // 
            this.dsExperiencia1.DataSetName = "dsExperiencia";
            this.dsExperiencia1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsExperiencia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Icon = ((System.Drawing.Icon)(resources.GetObject("btnEliminar.Icon")));
            this.btnEliminar.Location = new System.Drawing.Point(608, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 64);
            this.btnEliminar.TabIndex = 42;
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.Visible = false;
            this.btnEliminar.Load += new System.EventHandler(this.btnEliminar_Load);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCalculaTodas
            // 
            this.btnCalculaTodas.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculaTodas.Icon = ((System.Drawing.Icon)(resources.GetObject("btnCalculaTodas.Icon")));
            this.btnCalculaTodas.Location = new System.Drawing.Point(709, 0);
            this.btnCalculaTodas.Name = "btnCalculaTodas";
            this.btnCalculaTodas.Size = new System.Drawing.Size(64, 64);
            this.btnCalculaTodas.TabIndex = 65;
            this.toolTip1.SetToolTip(this.btnCalculaTodas, "Calcula todas las experiencias");
            this.btnCalculaTodas.Click += new System.EventHandler(this.btnCalculaTodas_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Consulta de experiencia";
            // 
            // cmbIdConcretera
            // 
            this.cmbIdConcretera.DataSource = this.dsConcretera1.Concretera;
            this.cmbIdConcretera.DisplayMember = "Concretera";
            this.cmbIdConcretera.Location = new System.Drawing.Point(320, 16);
            this.cmbIdConcretera.Name = "cmbIdConcretera";
            this.cmbIdConcretera.Size = new System.Drawing.Size(208, 21);
            this.cmbIdConcretera.TabIndex = 39;
            this.cmbIdConcretera.Tag = "ACE";
            this.cmbIdConcretera.ValueMember = "IdConcretera";
            this.cmbIdConcretera.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // dsConcretera1
            // 
            this.dsConcretera1.DataSetName = "dsConcretera";
            this.dsConcretera1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcretera1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblIdObra
            // 
            this.lblIdObra.AutoSize = true;
            this.lblIdObra.Location = new System.Drawing.Point(256, 18);
            this.lblIdObra.Name = "lblIdObra";
            this.lblIdObra.Size = new System.Drawing.Size(62, 13);
            this.lblIdObra.TabIndex = 1;
            this.lblIdObra.Text = "Concretera:";
            this.lblIdObra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sqlDAConcretera
            // 
            this.sqlDAConcretera.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAConcretera.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Concretera", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("Concretera", "Concretera"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdConcretera, Concretera, Direccion FROM Concretera ORDER BY Concretera";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDAdExperiencia
            // 
            this.sqlDAdExperiencia.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAdExperiencia.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Experiencia", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Revenimento", "Revenimento"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado"),
                        new System.Data.Common.DataColumnMapping("Fechaini", "Fechaini"),
                        new System.Data.Common.DataColumnMapping("Fechafin", "Fechafin"),
                        new System.Data.Common.DataColumnMapping("Planta", "Planta"),
                        new System.Data.Common.DataColumnMapping("Muestras", "Muestras"),
                        new System.Data.Common.DataColumnMapping("d3a7", "d3a7"),
                        new System.Data.Common.DataColumnMapping("d3aEE", "d3aEE"),
                        new System.Data.Common.DataColumnMapping("d7aEE", "d7aEE"),
                        new System.Data.Common.DataColumnMapping("s3a7", "s3a7"),
                        new System.Data.Common.DataColumnMapping("s3EE", "s3EE"),
                        new System.Data.Common.DataColumnMapping("s7EE", "s7EE"),
                        new System.Data.Common.DataColumnMapping("IdPrueba", "IdPrueba"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("Diametro", "Diametro")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdConcretera", System.Data.SqlDbType.NVarChar, 10, "Premez")});
            // 
            // sqlCMBorra
            // 
            this.sqlCMBorra.CommandText = "DELETE FROM Experiencia WHERE (Identificador = @Identificador)";
            this.sqlCMBorra.Connection = this.sqlConn;
            this.sqlCMBorra.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Identificador", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Identificador", System.Data.DataRowVersion.Original, null)});
            // 
            // dgExperiencia
            // 
            this.dgExperiencia.AutoGenerateColumns = false;
            this.dgExperiencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExperiencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.premezDataGridViewTextBoxColumn,
            this.ptaDataGridViewTextBoxColumn,
            this.fcDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.tmaDataGridViewTextBoxColumn,
            this.revDataGridViewTextBoxColumn,
            this.grDataGridViewTextBoxColumn,
            this.tADataGridViewTextBoxColumn,
            this.muestrasDataGridViewTextBoxColumn,
            this.a7DataGridViewTextBoxColumn,
            this.aEEDataGridViewTextBoxColumn,
            this.aEEDataGridViewTextBoxColumn1,
            this.fIniDataGridViewTextBoxColumn,
            this.fFinDataGridViewTextBoxColumn,
            this.d3A7DataGridViewTextBoxColumn,
            this.d3AEEDataGridViewTextBoxColumn,
            this.d7AEEDataGridViewTextBoxColumn,
            this.unidadDataGridViewTextBoxColumn,
            this.pruebaDataGridViewTextBoxColumn,
            this.identificadorDataGridViewTextBoxColumn});
            this.dgExperiencia.DataSource = this.experienciaBindingSource;
            this.dgExperiencia.Location = new System.Drawing.Point(0, 80);
            this.dgExperiencia.Name = "dgExperiencia";
            this.dgExperiencia.Size = new System.Drawing.Size(957, 529);
            this.dgExperiencia.TabIndex = 8;
            // 
            // premezDataGridViewTextBoxColumn
            // 
            this.premezDataGridViewTextBoxColumn.DataPropertyName = "Premez";
            this.premezDataGridViewTextBoxColumn.HeaderText = "Premez";
            this.premezDataGridViewTextBoxColumn.Name = "premezDataGridViewTextBoxColumn";
            // 
            // ptaDataGridViewTextBoxColumn
            // 
            this.ptaDataGridViewTextBoxColumn.DataPropertyName = "Pta";
            this.ptaDataGridViewTextBoxColumn.HeaderText = "Pta";
            this.ptaDataGridViewTextBoxColumn.Name = "ptaDataGridViewTextBoxColumn";
            // 
            // fcDataGridViewTextBoxColumn
            // 
            this.fcDataGridViewTextBoxColumn.DataPropertyName = "f´c ";
            this.fcDataGridViewTextBoxColumn.HeaderText = "f´c ";
            this.fcDataGridViewTextBoxColumn.Name = "fcDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo  ";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo  ";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // tmaDataGridViewTextBoxColumn
            // 
            this.tmaDataGridViewTextBoxColumn.DataPropertyName = "Tma ";
            this.tmaDataGridViewTextBoxColumn.HeaderText = "Tma ";
            this.tmaDataGridViewTextBoxColumn.Name = "tmaDataGridViewTextBoxColumn";
            // 
            // revDataGridViewTextBoxColumn
            // 
            this.revDataGridViewTextBoxColumn.DataPropertyName = "Rev ";
            this.revDataGridViewTextBoxColumn.HeaderText = "Rev ";
            this.revDataGridViewTextBoxColumn.Name = "revDataGridViewTextBoxColumn";
            // 
            // grDataGridViewTextBoxColumn
            // 
            this.grDataGridViewTextBoxColumn.DataPropertyName = "Gr";
            this.grDataGridViewTextBoxColumn.HeaderText = "Gr";
            this.grDataGridViewTextBoxColumn.Name = "grDataGridViewTextBoxColumn";
            // 
            // tADataGridViewTextBoxColumn
            // 
            this.tADataGridViewTextBoxColumn.DataPropertyName = "  T A  ";
            this.tADataGridViewTextBoxColumn.HeaderText = "  T A  ";
            this.tADataGridViewTextBoxColumn.Name = "tADataGridViewTextBoxColumn";
            // 
            // muestrasDataGridViewTextBoxColumn
            // 
            this.muestrasDataGridViewTextBoxColumn.DataPropertyName = "Muestras";
            this.muestrasDataGridViewTextBoxColumn.HeaderText = "Muestras";
            this.muestrasDataGridViewTextBoxColumn.Name = "muestrasDataGridViewTextBoxColumn";
            // 
            // a7DataGridViewTextBoxColumn
            // 
            this.a7DataGridViewTextBoxColumn.DataPropertyName = "3 a 7";
            this.a7DataGridViewTextBoxColumn.HeaderText = "3 a 7";
            this.a7DataGridViewTextBoxColumn.Name = "a7DataGridViewTextBoxColumn";
            this.a7DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aEEDataGridViewTextBoxColumn
            // 
            this.aEEDataGridViewTextBoxColumn.DataPropertyName = "3 a EE";
            this.aEEDataGridViewTextBoxColumn.HeaderText = "3 a EE";
            this.aEEDataGridViewTextBoxColumn.Name = "aEEDataGridViewTextBoxColumn";
            this.aEEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aEEDataGridViewTextBoxColumn1
            // 
            this.aEEDataGridViewTextBoxColumn1.DataPropertyName = "7 a EE";
            this.aEEDataGridViewTextBoxColumn1.HeaderText = "7 a EE";
            this.aEEDataGridViewTextBoxColumn1.Name = "aEEDataGridViewTextBoxColumn1";
            this.aEEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fIniDataGridViewTextBoxColumn
            // 
            this.fIniDataGridViewTextBoxColumn.DataPropertyName = "F.  Ini";
            this.fIniDataGridViewTextBoxColumn.HeaderText = "F.  Ini";
            this.fIniDataGridViewTextBoxColumn.Name = "fIniDataGridViewTextBoxColumn";
            // 
            // fFinDataGridViewTextBoxColumn
            // 
            this.fFinDataGridViewTextBoxColumn.DataPropertyName = "F.  Fin";
            this.fFinDataGridViewTextBoxColumn.HeaderText = "F.  Fin";
            this.fFinDataGridViewTextBoxColumn.Name = "fFinDataGridViewTextBoxColumn";
            // 
            // d3A7DataGridViewTextBoxColumn
            // 
            this.d3A7DataGridViewTextBoxColumn.DataPropertyName = "d3 a 7";
            this.d3A7DataGridViewTextBoxColumn.HeaderText = "d3 a 7";
            this.d3A7DataGridViewTextBoxColumn.Name = "d3A7DataGridViewTextBoxColumn";
            this.d3A7DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // d3AEEDataGridViewTextBoxColumn
            // 
            this.d3AEEDataGridViewTextBoxColumn.DataPropertyName = "d3 a EE";
            this.d3AEEDataGridViewTextBoxColumn.HeaderText = "d3 a EE";
            this.d3AEEDataGridViewTextBoxColumn.Name = "d3AEEDataGridViewTextBoxColumn";
            this.d3AEEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // d7AEEDataGridViewTextBoxColumn
            // 
            this.d7AEEDataGridViewTextBoxColumn.DataPropertyName = "d7 a EE";
            this.d7AEEDataGridViewTextBoxColumn.HeaderText = "d7 a EE";
            this.d7AEEDataGridViewTextBoxColumn.Name = "d7AEEDataGridViewTextBoxColumn";
            this.d7AEEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadDataGridViewTextBoxColumn
            // 
            this.unidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad";
            this.unidadDataGridViewTextBoxColumn.HeaderText = "Unidad";
            this.unidadDataGridViewTextBoxColumn.Name = "unidadDataGridViewTextBoxColumn";
            // 
            // pruebaDataGridViewTextBoxColumn
            // 
            this.pruebaDataGridViewTextBoxColumn.DataPropertyName = "Prueba";
            this.pruebaDataGridViewTextBoxColumn.HeaderText = "Prueba";
            this.pruebaDataGridViewTextBoxColumn.Name = "pruebaDataGridViewTextBoxColumn";
            // 
            // identificadorDataGridViewTextBoxColumn
            // 
            this.identificadorDataGridViewTextBoxColumn.DataPropertyName = "Identificador";
            this.identificadorDataGridViewTextBoxColumn.HeaderText = "Identificador";
            this.identificadorDataGridViewTextBoxColumn.Name = "identificadorDataGridViewTextBoxColumn";
            this.identificadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // experienciaBindingSource
            // 
            this.experienciaBindingSource.DataMember = "Experiencia";
            this.experienciaBindingSource.DataSource = this.dsExperiencia1;
            // 
            // sqlCCalcula
            // 
            this.sqlCCalcula.CommandText = "ExpTotal";
            this.sqlCCalcula.CommandTimeout = 600;
            this.sqlCCalcula.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCCalcula.Connection = this.sqlConn;
            this.sqlCCalcula.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // Experiencia
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(960, 613);
            this.Controls.Add(this.dgExperiencia);
            this.Controls.Add(this.panel2);
            this.Name = "Experiencia";
            this.Text = "Experiencia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Experiencia_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsExperiencia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcretera1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExperiencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienciaBindingSource)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			dsExperiencia1.Clear();
			sqlDAdExperiencia.SelectCommand.Parameters["@IdConcretera"].Value = cmbIdConcretera.SelectedValue;
			sqlDAdExperiencia.Fill(dsExperiencia1,"Experiencia");
		}

		private void Experiencia_Load(object sender, System.EventArgs e)
		{
			sqlDAConcretera.Fill(dsConcretera1, "Concretera");

			int intTotCols = dsExperiencia1.Experiencia.Columns.Count;
			//			dgcMuestras.PreferredColumnWidth = (this.panel2.Bounds.Width - intTotCols - 53 ) / intTotCols;
			int i = 0;
			DataGridTableStyle miest = new DataGridTableStyle();
			miest.MappingName = dsExperiencia1.Experiencia.TableName;
			foreach(DataColumn dc in dsExperiencia1.Experiencia.Columns)
			{
				DataGridTextBoxColumn col1 = new DataGridTextBoxColumn();
				col1.Width = System.Convert.ToInt32(dsExperiencia1.Experiencia.Columns[i].ColumnName.Length * 7.15);
				col1.HeaderText =  dsExperiencia1.Experiencia.Columns[i].ColumnName;
				col1.MappingName = dsExperiencia1.Experiencia.Columns[i].ColumnName;
					
				if(dsExperiencia1.Experiencia.Columns[i].ColumnName == "Hora")
					col1.Format = "HH.mm";
				if(dsExperiencia1.Experiencia.Columns[i].ColumnName.Substring(0,2) == "F.")
					col1.Format = "yy-MM-dd";

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
			//dgExperiencia.TableStyles.Add(miest);

		}

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			if (buscaBtn1.RegistroSeleccionado >= 0)
				btnEliminar.Visible = true;
			else
				btnEliminar.Visible = false;
		}

		private void btnEliminar_Click(object sender, System.EventArgs e)
		{
			sqlConn.Open();
			sqlCMBorra.Parameters["@Identificador"].Value = dsExperiencia1.Tables["Experiencia"].Rows[buscaBtn1.RegistroSeleccionado][19].ToString();
			sqlCMBorra.ExecuteNonQuery();
			sqlConn.Close();
			dgExperiencia.Refresh();
            cmbIdObra_SelectedIndexChanged(sender, null);
		}

        private void btnEliminar_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculaTodas_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            //sqlCMBorra.Parameters["@Identificador"].Value = dsExperiencia1.Tables["Experiencia"].Rows[buscaBtn1.RegistroSeleccionado][19].ToString();
            sqlCCalcula.ExecuteNonQuery();
            sqlConn.Close();
            dgExperiencia.Refresh();
            cmbIdObra_SelectedIndexChanged(sender, null);
            MessageBox.Show("Proceso terminado");
        }
	}
}
