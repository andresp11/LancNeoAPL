namespace LancNeo
{
    partial class InfEnsPro
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
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfEnsPro));
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.GBTipo = new System.Windows.Forms.GroupBox();
            this.rBMortero = new System.Windows.Forms.RadioButton();
            this.rBConcreto = new System.Windows.Forms.RadioButton();
            this.rBAmbos = new System.Windows.Forms.RadioButton();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLaboratorio = new System.Windows.Forms.ComboBox();
            this.dsLaboratorio1 = new LancNeo.dsLaboratorio();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.crvRepMuestreador = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDALaboratorio = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAMuestra = new System.Data.SqlClient.SqlDataAdapter();
            this.cryRepEnsayeProbeta1 = new LancNeo.CryRepEnsayeProbeta();
            this.cryProEns1 = new LancNeo.CryProEns();
            this.dsEspProInf1 = new LancNeo.dsEspProInf();
            this.panel1.SuspendLayout();
            this.GBTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEspProInf1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.GBTipo);
            this.panel1.Controls.Add(this.txtDia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbLaboratorio);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 63);
            this.panel1.TabIndex = 9;
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
            // GBTipo
            // 
            this.GBTipo.Controls.Add(this.rBMortero);
            this.GBTipo.Controls.Add(this.rBConcreto);
            this.GBTipo.Controls.Add(this.rBAmbos);
            this.GBTipo.Location = new System.Drawing.Point(430, 26);
            this.GBTipo.Name = "GBTipo";
            this.GBTipo.Size = new System.Drawing.Size(275, 37);
            this.GBTipo.TabIndex = 47;
            this.GBTipo.TabStop = false;
            this.GBTipo.Text = "Tipo de reporte";
            // 
            // rBMortero
            // 
            this.rBMortero.AutoSize = true;
            this.rBMortero.ForeColor = System.Drawing.Color.White;
            this.rBMortero.Location = new System.Drawing.Point(176, 14);
            this.rBMortero.Name = "rBMortero";
            this.rBMortero.Size = new System.Drawing.Size(61, 17);
            this.rBMortero.TabIndex = 2;
            this.rBMortero.Text = "Mortero";
            this.rBMortero.UseVisualStyleBackColor = true;
            // 
            // rBConcreto
            // 
            this.rBConcreto.AutoSize = true;
            this.rBConcreto.Checked = true;
            this.rBConcreto.ForeColor = System.Drawing.Color.White;
            this.rBConcreto.Location = new System.Drawing.Point(92, 14);
            this.rBConcreto.Name = "rBConcreto";
            this.rBConcreto.Size = new System.Drawing.Size(68, 17);
            this.rBConcreto.TabIndex = 1;
            this.rBConcreto.TabStop = true;
            this.rBConcreto.Text = "Concreto";
            this.rBConcreto.UseVisualStyleBackColor = true;
            // 
            // rBAmbos
            // 
            this.rBAmbos.AutoSize = true;
            this.rBAmbos.ForeColor = System.Drawing.Color.White;
            this.rBAmbos.Location = new System.Drawing.Point(16, 15);
            this.rBAmbos.Name = "rBAmbos";
            this.rBAmbos.Size = new System.Drawing.Size(57, 17);
            this.rBAmbos.TabIndex = 0;
            this.rBAmbos.Text = "Ambos";
            this.rBAmbos.UseVisualStyleBackColor = true;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(746, 3);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(31, 20);
            this.txtDia.TabIndex = 45;
            this.txtDia.Text = "28";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(709, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Días:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.DataSource = this.dsLaboratorio1;
            this.cmbLaboratorio.DisplayMember = "Laboratorio.IdLaboratorio";
            this.cmbLaboratorio.Location = new System.Drawing.Point(633, 3);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.Size = new System.Drawing.Size(72, 21);
            this.cmbLaboratorio.TabIndex = 42;
            this.cmbLaboratorio.ValueMember = "IdLaboratorio";
            // 
            // dsLaboratorio1
            // 
            this.dsLaboratorio1.DataSetName = "dsLaboratorio";
            this.dsLaboratorio1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(560, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "Laboratorio:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(471, 3);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(81, 20);
            this.dtpFecha.TabIndex = 7;
            this.dtpFecha.Value = new System.DateTime(2014, 8, 22, 21, 20, 54, 0);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte de ensaye de probetas de concreto";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.ForeColor = System.Drawing.Color.White;
            this.Fecha.Location = new System.Drawing.Point(425, 7);
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
            this.crvRepMuestreador.Location = new System.Drawing.Point(0, 63);
            this.crvRepMuestreador.Name = "crvRepMuestreador";
            this.crvRepMuestreador.ShowCloseButton = false;
            this.crvRepMuestreador.ShowGroupTreeButton = false;
            this.crvRepMuestreador.ShowLogo = false;
            this.crvRepMuestreador.Size = new System.Drawing.Size(856, 461);
            this.crvRepMuestreador.TabIndex = 11;
            this.crvRepMuestreador.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
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
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "[EnsPro]";
            this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Fensaye", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 10),
            new System.Data.SqlClient.SqlParameter("@Dia", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@TR", System.Data.SqlDbType.Int, 4)});
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
            // dsEspProInf1
            // 
            this.dsEspProInf1.DataSetName = "dsEspProInf";
            this.dsEspProInf1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InfEnsPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 524);
            this.Controls.Add(this.crvRepMuestreador);
            this.Controls.Add(this.panel1);
            this.Name = "InfEnsPro";
            this.Text = "InfEnsPro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfEnsPro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GBTipo.ResumeLayout(false);
            this.GBTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEspProInf1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConn;
        private System.Windows.Forms.Panel panel1;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Fecha;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepMuestreador;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbLaboratorio;
        private System.Windows.Forms.Label label19;
        private dsLaboratorio dsLaboratorio1;
        private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorio;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDAMuestra;
        private CryRepEnsayeProbeta cryRepEnsayeProbeta1;
        private CryProEns cryProEns1;
        private dsEspProInf dsEspProInf1;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GBTipo;
        private System.Windows.Forms.RadioButton rBMortero;
        private System.Windows.Forms.RadioButton rBConcreto;
        private System.Windows.Forms.RadioButton rBAmbos;
    }
}