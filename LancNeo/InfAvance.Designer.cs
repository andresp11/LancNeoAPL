namespace LancNeo
{
    partial class InfAvance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfAvance));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDAAvance = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.crvInfAvance = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDAObras = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsAvance1 = new LancNeo.dsAvance();
            this.cryInfAvance1 = new LancNeo.CryInfAvance();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAvance1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnVistaPrevia);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 71);
            this.panel2.TabIndex = 16;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(640, 1);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 63);
            this.btnVistaPrevia.TabIndex = 59;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(461, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Fecha informe:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(548, 22);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(86, 20);
            this.dtpFecha.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 54);
            this.label4.TabIndex = 54;
            this.label4.Text = "Muestreo de acero, prefabricados, mortero y asfalto";
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDAAvance
            // 
            this.sqlDAAvance.SelectCommand = this.sqlCommand3;
            this.sqlDAAvance.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Avance", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Presupuesto", "Presupuesto"),
                        new System.Data.Common.DataColumnMapping("InicioO", "InicioO"),
                        new System.Data.Common.DataColumnMapping("Duracion", "Duracion"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Ciente", "Ciente"),
                        new System.Data.Common.DataColumnMapping("PAcero", "PAcero"),
                        new System.Data.Common.DataColumnMapping("AAcero", "AAcero"),
                        new System.Data.Common.DataColumnMapping("IncioPr", "IncioPr"),
                        new System.Data.Common.DataColumnMapping("PPrefa", "PPrefa"),
                        new System.Data.Common.DataColumnMapping("APrefa", "APrefa"),
                        new System.Data.Common.DataColumnMapping("PMortero", "PMortero"),
                        new System.Data.Common.DataColumnMapping("AMortero", "AMortero"),
                        new System.Data.Common.DataColumnMapping("PAzfalto", "PAzfalto"),
                        new System.Data.Common.DataColumnMapping("AAzfalto", "AAzfalto"),
                        new System.Data.Common.DataColumnMapping("PAgrega", "PAgrega"),
                        new System.Data.Common.DataColumnMapping("AAgrega", "AAgrega"),
                        new System.Data.Common.DataColumnMapping("PTerra", "PTerra"),
                        new System.Data.Common.DataColumnMapping("ATerra", "ATerra"),
                        new System.Data.Common.DataColumnMapping("PNucleo", "PNucleo"),
                        new System.Data.Common.DataColumnMapping("ANucleo", "ANucleo"),
                        new System.Data.Common.DataColumnMapping("Operador", "Operador"),
                        new System.Data.Common.DataColumnMapping("IdObraM", "IdObraM"),
                        new System.Data.Common.DataColumnMapping("PConector", "PConector"),
                        new System.Data.Common.DataColumnMapping("AConector", "AConector"),
                        new System.Data.Common.DataColumnMapping("PCalas", "PCalas"),
                        new System.Data.Common.DataColumnMapping("Acalas", "Acalas"),
                        new System.Data.Common.DataColumnMapping("PModulo", "PModulo"),
                        new System.Data.Common.DataColumnMapping("AModulo", "AModulo"),
                        new System.Data.Common.DataColumnMapping("UAcero", "UAcero"),
                        new System.Data.Common.DataColumnMapping("PAB", "PAB"),
                        new System.Data.Common.DataColumnMapping("AAB", "AAB"),
                        new System.Data.Common.DataColumnMapping("PAC", "PAC"),
                        new System.Data.Common.DataColumnMapping("AAC", "AAC"),
                        new System.Data.Common.DataColumnMapping("PAD", "PAD"),
                        new System.Data.Common.DataColumnMapping("AAD", "AAD"),
                        new System.Data.Common.DataColumnMapping("PAF", "PAF"),
                        new System.Data.Common.DataColumnMapping("AAF", "AAF"),
                        new System.Data.Common.DataColumnMapping("UConector", "UConector"),
                        new System.Data.Common.DataColumnMapping("UMortero", "UMortero"),
                        new System.Data.Common.DataColumnMapping("UPrefa", "UPrefa"),
                        new System.Data.Common.DataColumnMapping("UModulos", "UModulos"),
                        new System.Data.Common.DataColumnMapping("Ucalidades", "Ucalidades"),
                        new System.Data.Common.DataColumnMapping("UCalas", "UCalas"),
                        new System.Data.Common.DataColumnMapping("UAB", "UAB")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = resources.GetString("sqlCommand3.CommandText");
            this.sqlCommand3.Connection = this.sqlConn;
            // 
            // crvInfAvance
            // 
            this.crvInfAvance.ActiveViewIndex = -1;
            this.crvInfAvance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInfAvance.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInfAvance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInfAvance.EnableRefresh = false;
            this.crvInfAvance.Location = new System.Drawing.Point(0, 71);
            this.crvInfAvance.Name = "crvInfAvance";
            this.crvInfAvance.ShowCloseButton = false;
            this.crvInfAvance.ShowGroupTreeButton = false;
            this.crvInfAvance.ShowLogo = false;
            this.crvInfAvance.Size = new System.Drawing.Size(734, 287);
            this.crvInfAvance.TabIndex = 17;
            this.crvInfAvance.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvInfAvance.ToolPanelWidth = 167;
            this.crvInfAvance.Visible = false;
            // 
            // sqlDAObras
            // 
            this.sqlDAObras.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAObras.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdCliente", "IdCliente"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("Codigop", "Codigop"),
                        new System.Data.Common.DataColumnMapping("Sintendente", "Sintendente"),
                        new System.Data.Common.DataColumnMapping("Jfrente", "Jfrente"),
                        new System.Data.Common.DataColumnMapping("Telefono", "Telefono"),
                        new System.Data.Common.DataColumnMapping("Solicitud", "Solicitud"),
                        new System.Data.Common.DataColumnMapping("Presupuesto", "Presupuesto"),
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Fechai", "Fechai"),
                        new System.Data.Common.DataColumnMapping("Fechaf", "Fechaf"),
                        new System.Data.Common.DataColumnMapping("Carpeta", "Carpeta"),
                        new System.Data.Common.DataColumnMapping("Diaj", "Diaj"),
                        new System.Data.Common.DataColumnMapping("Horaj", "Horaj"),
                        new System.Data.Common.DataColumnMapping("Soldadura", "Soldadura"),
                        new System.Data.Common.DataColumnMapping("IdZona", "IdZona"),
                        new System.Data.Common.DataColumnMapping("Origen", "Origen"),
                        new System.Data.Common.DataColumnMapping("Coeficiente", "Coeficiente"),
                        new System.Data.Common.DataColumnMapping("PresupuestoZ", "PresupuestoZ"),
                        new System.Data.Common.DataColumnMapping("Duracion", "Duracion"),
                        new System.Data.Common.DataColumnMapping("Paradox", "Paradox"),
                        new System.Data.Common.DataColumnMapping("Informes", "Informes"),
                        new System.Data.Common.DataColumnMapping("Contrato", "Contrato"),
                        new System.Data.Common.DataColumnMapping("Tipolab", "Tipolab"),
                        new System.Data.Common.DataColumnMapping("Certificado", "Certificado"),
                        new System.Data.Common.DataColumnMapping("SerConcreto", "SerConcreto"),
                        new System.Data.Common.DataColumnMapping("SerSoldadura", "SerSoldadura"),
                        new System.Data.Common.DataColumnMapping("PlaCim", "PlaCim"),
                        new System.Data.Common.DataColumnMapping("PlaPT", "PlaPT"),
                        new System.Data.Common.DataColumnMapping("PlaCorte", "PlaCorte"),
                        new System.Data.Common.DataColumnMapping("SerAcero", "SerAcero"),
                        new System.Data.Common.DataColumnMapping("SerTerra", "SerTerra"),
                        new System.Data.Common.DataColumnMapping("SerPrefa", "SerPrefa"),
                        new System.Data.Common.DataColumnMapping("SerMor", "SerMor"),
                        new System.Data.Common.DataColumnMapping("AccesoWEB", "AccesoWEB"),
                        new System.Data.Common.DataColumnMapping("InfResbajas", "InfResbajas"),
                        new System.Data.Common.DataColumnMapping("Infemail", "Infemail"),
                        new System.Data.Common.DataColumnMapping("InfTelefono", "InfTelefono"),
                        new System.Data.Common.DataColumnMapping("InfOriginal", "InfOriginal"),
                        new System.Data.Common.DataColumnMapping("InfCopia", "InfCopia"),
                        new System.Data.Common.DataColumnMapping("TelResidente", "TelResidente"),
                        new System.Data.Common.DataColumnMapping("Correo1", "Correo1"),
                        new System.Data.Common.DataColumnMapping("Correo2", "Correo2"),
                        new System.Data.Common.DataColumnMapping("Correo3", "Correo3"),
                        new System.Data.Common.DataColumnMapping("Correo4", "Correo4"),
                        new System.Data.Common.DataColumnMapping("Correo5", "Correo5"),
                        new System.Data.Common.DataColumnMapping("SeEspe", "SeEspe"),
                        new System.Data.Common.DataColumnMapping("CualEsp", "CualEsp")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // dsAvance1
            // 
            this.dsAvance1.DataSetName = "dsAvance";
            this.dsAvance1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InfAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 358);
            this.Controls.Add(this.crvInfAvance);
            this.Controls.Add(this.panel2);
            this.Name = "InfAvance";
            this.Text = "InfAvance";
            this.Load += new System.EventHandler(this.InfAvance_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAvance1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private System.Windows.Forms.Label label4;
        private System.Data.SqlClient.SqlConnection sqlConn;
        private System.Data.SqlClient.SqlDataAdapter sqlDAAvance;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private dsAvance dsAvance1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInfAvance;
        private System.Data.SqlClient.SqlDataAdapter sqlDAObras;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private CryInfAvance cryInfAvance1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}