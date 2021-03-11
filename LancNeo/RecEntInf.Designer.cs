namespace LancNeo
{
    partial class RecEntInf
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecEntInf));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUbicacion = new System.Windows.Forms.ComboBox();
            this.zonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUbicacion = new LancNeo.dsUbicacion();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.crvRepMuestreador = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDAMuestra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dsRecEntInf1 = new LancNeo.dsRecEntInf();
            this.cryRecEntInf1 = new LancNeo.CryRecEntInf();
            this.zonaTableAdapter = new LancNeo.dsUbicacionTableAdapters.ZonaTableAdapter();
            this.lancDataSet = new LancNeo.lancDataSet();
            this.zonaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zonaTableAdapter1 = new LancNeo.lancDataSetTableAdapters.ZonaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUbicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecEntInf1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbUbicacion);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 56);
            this.panel1.TabIndex = 10;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(783, 0);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 6;
            this.btnVistaPrevia.Load += new System.EventHandler(this.btnVistaPrevia_Load);
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Localización:";
            // 
            // cmbUbicacion
            // 
            this.cmbUbicacion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.zonaBindingSource, "Ubicación", true));
            this.cmbUbicacion.FormattingEnabled = true;
            this.cmbUbicacion.Items.AddRange(new object[] {
            "Todos",
            "Local",
            "Foranea"});
            this.cmbUbicacion.Location = new System.Drawing.Point(667, 10);
            this.cmbUbicacion.Name = "cmbUbicacion";
            this.cmbUbicacion.Size = new System.Drawing.Size(121, 21);
            this.cmbUbicacion.TabIndex = 8;
            // 
            // zonaBindingSource
            // 
            this.zonaBindingSource.DataMember = "Zona";
            this.zonaBindingSource.DataSource = this.dsUbicacion;
            // 
            // dsUbicacion
            // 
            this.dsUbicacion.DataSetName = "dsUbicacion";
            this.dsUbicacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(471, 11);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(81, 20);
            this.dtpFecha.TabIndex = 7;
            this.dtpFecha.Value = new System.DateTime(2014, 8, 22, 21, 20, 54, 0);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte de recepción y entrega de informes";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(425, 17);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(46, 13);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fecha:";
            // 
            // crvRepMuestreador
            // 
            this.crvRepMuestreador.ActiveViewIndex = -1;
            this.crvRepMuestreador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRepMuestreador.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRepMuestreador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRepMuestreador.EnableRefresh = false;
            this.crvRepMuestreador.Location = new System.Drawing.Point(0, 56);
            this.crvRepMuestreador.Name = "crvRepMuestreador";
            this.crvRepMuestreador.ShowCloseButton = false;
            this.crvRepMuestreador.ShowGroupTreeButton = false;
            this.crvRepMuestreador.ShowLogo = false;
            this.crvRepMuestreador.Size = new System.Drawing.Size(856, 468);
            this.crvRepMuestreador.TabIndex = 12;
            this.crvRepMuestreador.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDAMuestra
            // 
            this.sqlDAMuestra.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAMuestra.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Especimen", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Consecutivo", "Consecutivo"),
                        new System.Data.Common.DataColumnMapping("IdConcretera", "IdConcretera"),
                        new System.Data.Common.DataColumnMapping("IdPlanta", "IdPlanta"),
                        new System.Data.Common.DataColumnMapping("ResistenciaKG", "ResistenciaKG"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Agregado", "Agregado"),
                        new System.Data.Common.DataColumnMapping("Revenimento", "Revenimento"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("IdAgregado", "IdAgregado"),
                        new System.Data.Common.DataColumnMapping("IdRemision", "IdRemision"),
                        new System.Data.Common.DataColumnMapping("IdOlla", "IdOlla"),
                        new System.Data.Common.DataColumnMapping("Volumen", "Volumen"),
                        new System.Data.Common.DataColumnMapping("Hora", "Hora"),
                        new System.Data.Common.DataColumnMapping("RevObt", "RevObt"),
                        new System.Data.Common.DataColumnMapping("Elemento", "Elemento"),
                        new System.Data.Common.DataColumnMapping("Ejes", "Ejes"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel"),
                        new System.Data.Common.DataColumnMapping("Edif", "Edif"),
                        new System.Data.Common.DataColumnMapping("Observa", "Observa"),
                        new System.Data.Common.DataColumnMapping("IdDescarga", "IdDescarga"),
                        new System.Data.Common.DataColumnMapping("Origen", "Origen"),
                        new System.Data.Common.DataColumnMapping("ResBajo", "ResBajo"),
                        new System.Data.Common.DataColumnMapping("Hsalida", "Hsalida"),
                        new System.Data.Common.DataColumnMapping("Hllegada", "Hllegada"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("MUCF", "MUCF"),
                        new System.Data.Common.DataColumnMapping("NEsp", "NEsp"),
                        new System.Data.Common.DataColumnMapping("IdEnsaye", "IdEnsaye")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "[RecEntInf]";
            this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Fensaye", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@Ubicacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "")});
            // 
            // dsRecEntInf1
            // 
            this.dsRecEntInf1.DataSetName = "dsRecEntInf";
            this.dsRecEntInf1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zonaTableAdapter
            // 
            this.zonaTableAdapter.ClearBeforeFill = true;
            // 
            // lancDataSet
            // 
            this.lancDataSet.DataSetName = "lancDataSet";
            this.lancDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zonaBindingSource1
            // 
            this.zonaBindingSource1.DataMember = "Zona";
            this.zonaBindingSource1.DataSource = this.lancDataSet;
            // 
            // zonaTableAdapter1
            // 
            this.zonaTableAdapter1.ClearBeforeFill = true;
            // 
            // RecEntInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 524);
            this.Controls.Add(this.crvRepMuestreador);
            this.Controls.Add(this.panel1);
            this.Name = "RecEntInf";
            this.Text = "RecEntInf";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RecEntInf_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUbicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecEntInf1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Fecha;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepMuestreador;
        private System.Data.SqlClient.SqlConnection sqlConn;
        private System.Data.SqlClient.SqlDataAdapter sqlDAMuestra;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private dsRecEntInf dsRecEntInf1;
        private CryRecEntInf cryRecEntInf1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUbicacion;
        private dsUbicacion dsUbicacion;
        private System.Windows.Forms.BindingSource zonaBindingSource;
        private dsUbicacionTableAdapters.ZonaTableAdapter zonaTableAdapter;
        private lancDataSet lancDataSet;
        private System.Windows.Forms.BindingSource zonaBindingSource1;
        private lancDataSetTableAdapters.ZonaTableAdapter zonaTableAdapter1;
    }
}