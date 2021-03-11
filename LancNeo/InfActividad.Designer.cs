namespace LancNeo
{
    partial class InfActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfActividad));
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDAActividad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.label4 = new System.Windows.Forms.Label();
            this.crvInfPrecios = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.cryInfActividad1 = new LancNeo.CryInfActividad();
            this.sqlDAIntensidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.dsInfActividad1 = new LancNeo.dsInfActividad();
            this.sqlDADuracion = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDADuraPres = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfActividad1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDAActividad
            // 
            this.sqlDAActividad.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAActividad.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Actividad", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("IdFormato", "IdFormato"),
                        new System.Data.Common.DataColumnMapping("IdIntensidad", "IdIntensidad"),
                        new System.Data.Common.DataColumnMapping("SPorVisita", "SPorVisita"),
                        new System.Data.Common.DataColumnMapping("SPorLab", "SPorLab"),
                        new System.Data.Common.DataColumnMapping("HastaVis", "HastaVis"),
                        new System.Data.Common.DataColumnMapping("HastaVis1", "HastaVis1"),
                        new System.Data.Common.DataColumnMapping("HastaLab1", "HastaLab1"),
                        new System.Data.Common.DataColumnMapping("HastaLab2", "HastaLab2"),
                        new System.Data.Common.DataColumnMapping("Concreto", "Concreto"),
                        new System.Data.Common.DataColumnMapping("Acero", "Acero"),
                        new System.Data.Common.DataColumnMapping("Tabique", "Tabique"),
                        new System.Data.Common.DataColumnMapping("Mortero", "Mortero"),
                        new System.Data.Common.DataColumnMapping("ProSolda", "ProSolda"),
                        new System.Data.Common.DataColumnMapping("AceroEs", "AceroEs"),
                        new System.Data.Common.DataColumnMapping("Cemento", "Cemento"),
                        new System.Data.Common.DataColumnMapping("HastaCem", "HastaCem"),
                        new System.Data.Common.DataColumnMapping("Tubo", "Tubo"),
                        new System.Data.Common.DataColumnMapping("Petreo", "Petreo"),
                        new System.Data.Common.DataColumnMapping("Corazon", "Corazon"),
                        new System.Data.Common.DataColumnMapping("Base", "Base"),
                        new System.Data.Common.DataColumnMapping("Asfalto", "Asfalto"),
                        new System.Data.Common.DataColumnMapping("Elastico", "Elastico"),
                        new System.Data.Common.DataColumnMapping("Carga", "Carga"),
                        new System.Data.Common.DataColumnMapping("HastaBase", "HastaBase"),
                        new System.Data.Common.DataColumnMapping("HastaCarga", "HastaCarga"),
                        new System.Data.Common.DataColumnMapping("VConcreto", "VConcreto"),
                        new System.Data.Common.DataColumnMapping("HastaVCon", "HastaVCon"),
                        new System.Data.Common.DataColumnMapping("VAgregado", "VAgregado"),
                        new System.Data.Common.DataColumnMapping("HastaVAgr", "HastaVAgr"),
                        new System.Data.Common.DataColumnMapping("ConPla", "ConPla"),
                        new System.Data.Common.DataColumnMapping("VTerra", "VTerra"),
                        new System.Data.Common.DataColumnMapping("VTasfalto", "VTasfalto"),
                        new System.Data.Common.DataColumnMapping("VRasfalto", "VRasfalto"),
                        new System.Data.Common.DataColumnMapping("VPavimento", "VPavimento"),
                        new System.Data.Common.DataColumnMapping("VSolVar", "VSolVar"),
                        new System.Data.Common.DataColumnMapping("VSolEst", "VSolEst"),
                        new System.Data.Common.DataColumnMapping("RVisual", "RVisual"),
                        new System.Data.Common.DataColumnMapping("HastaRVis", "HastaRVis"),
                        new System.Data.Common.DataColumnMapping("HastaRVisS", "HastaRVisS"),
                        new System.Data.Common.DataColumnMapping("RSolda", "RSolda"),
                        new System.Data.Common.DataColumnMapping("HastaRSol", "HastaRSol"),
                        new System.Data.Common.DataColumnMapping("HastaRSolS", "HastaRSolS"),
                        new System.Data.Common.DataColumnMapping("RRadio", "RRadio"),
                        new System.Data.Common.DataColumnMapping("HastaRRad", "HastaRRad"),
                        new System.Data.Common.DataColumnMapping("HastaRRadS", "HastaRRadS"),
                        new System.Data.Common.DataColumnMapping("RUltra", "RUltra"),
                        new System.Data.Common.DataColumnMapping("HastaRUlt", "HastaRUlt"),
                        new System.Data.Common.DataColumnMapping("HastaRUltS", "HastaRUltS"),
                        new System.Data.Common.DataColumnMapping("RLiq", "RLiq"),
                        new System.Data.Common.DataColumnMapping("HastaRLiq", "HastaRLiq"),
                        new System.Data.Common.DataColumnMapping("HastaRLiqS", "HastaRLiqS"),
                        new System.Data.Common.DataColumnMapping("RPar", "RPar"),
                        new System.Data.Common.DataColumnMapping("HastaRPar", "HastaRPar"),
                        new System.Data.Common.DataColumnMapping("HastaRParS", "HastaRParS"),
                        new System.Data.Common.DataColumnMapping("RProbeta", "RProbeta"),
                        new System.Data.Common.DataColumnMapping("HastaRProbeta", "HastaRProbeta"),
                        new System.Data.Common.DataColumnMapping("RTorque", "RTorque"),
                        new System.Data.Common.DataColumnMapping("HastaRTorque", "HastaRTorque"),
                        new System.Data.Common.DataColumnMapping("HastaRTorqueS", "HastaRTorqueS"),
                        new System.Data.Common.DataColumnMapping("Colados", "Colados"),
                        new System.Data.Common.DataColumnMapping("Excedente", "Excedente"),
                        new System.Data.Common.DataColumnMapping("MCilCol", "MCilCol"),
                        new System.Data.Common.DataColumnMapping("MCilExc", "MCilExc"),
                        new System.Data.Common.DataColumnMapping("MCilTipo", "MCilTipo"),
                        new System.Data.Common.DataColumnMapping("MCilObra", "MCilObra"),
                        new System.Data.Common.DataColumnMapping("MCilObrP", "MCilObrP"),
                        new System.Data.Common.DataColumnMapping("MCilObrT", "MCilObrT"),
                        new System.Data.Common.DataColumnMapping("Aton", "Aton"),
                        new System.Data.Common.DataColumnMapping("AtonM", "AtonM"),
                        new System.Data.Common.DataColumnMapping("AMen", "AMen"),
                        new System.Data.Common.DataColumnMapping("AmenM", "AmenM"),
                        new System.Data.Common.DataColumnMapping("AEton", "AEton"),
                        new System.Data.Common.DataColumnMapping("AEtonM", "AEtonM"),
                        new System.Data.Common.DataColumnMapping("HastaAcero", "HastaAcero"),
                        new System.Data.Common.DataColumnMapping("HastaAceroE", "HastaAceroE"),
                        new System.Data.Common.DataColumnMapping("TipoMor", "TipoMor"),
                        new System.Data.Common.DataColumnMapping("MorMin", "MorMin"),
                        new System.Data.Common.DataColumnMapping("MorMuMi", "MorMuMi"),
                        new System.Data.Common.DataColumnMapping("MorMueM2", "MorMueM2"),
                        new System.Data.Common.DataColumnMapping("MorMueCub", "MorMueCub"),
                        new System.Data.Common.DataColumnMapping("HastaMor", "HastaMor"),
                        new System.Data.Common.DataColumnMapping("TabCad", "TabCad"),
                        new System.Data.Common.DataColumnMapping("TabTip", "TabTip"),
                        new System.Data.Common.DataColumnMapping("TabPza", "TabPza"),
                        new System.Data.Common.DataColumnMapping("HastaTab", "HastaTab"),
                        new System.Data.Common.DataColumnMapping("TerIni", "TerIni"),
                        new System.Data.Common.DataColumnMapping("TerCad", "TerCad"),
                        new System.Data.Common.DataColumnMapping("TerMe3", "TerMe3"),
                        new System.Data.Common.DataColumnMapping("HastaTer", "HastaTer"),
                        new System.Data.Common.DataColumnMapping("CalCad", "CalCad"),
                        new System.Data.Common.DataColumnMapping("BasCad", "BasCad"),
                        new System.Data.Common.DataColumnMapping("AsfCad", "AsfCad"),
                        new System.Data.Common.DataColumnMapping("HastaAsf", "HastaAsf"),
                        new System.Data.Common.DataColumnMapping("NucCad", "NucCad"),
                        new System.Data.Common.DataColumnMapping("HastaNuc", "HastaNuc"),
                        new System.Data.Common.DataColumnMapping("EmuIni", "EmuIni"),
                        new System.Data.Common.DataColumnMapping("EmuCad", "EmuCad"),
                        new System.Data.Common.DataColumnMapping("EmuMe3", "EmuMe3"),
                        new System.Data.Common.DataColumnMapping("HastaEmu", "HastaEmu"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnVistaPrevia);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbIdObra);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 71);
            this.panel2.TabIndex = 15;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Obra:";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(446, 15);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 60;
            this.cmbIdObra.ValueMember = "IdObra";
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 41);
            this.label4.TabIndex = 54;
            this.label4.Text = "Tarjetón de obra";
            // 
            // crvInfPrecios
            // 
            this.crvInfPrecios.ActiveViewIndex = -1;
            this.crvInfPrecios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInfPrecios.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInfPrecios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInfPrecios.EnableRefresh = false;
            this.crvInfPrecios.Location = new System.Drawing.Point(0, 71);
            this.crvInfPrecios.Name = "crvInfPrecios";
            this.crvInfPrecios.ShowCloseButton = false;
            this.crvInfPrecios.ShowGroupTreeButton = false;
            this.crvInfPrecios.ShowLogo = false;
            this.crvInfPrecios.Size = new System.Drawing.Size(734, 287);
            this.crvInfPrecios.TabIndex = 16;
            this.crvInfPrecios.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvInfPrecios.ToolPanelWidth = 167;
            this.crvInfPrecios.Visible = false;
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
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConn;
            // 
            // sqlDAObra
            // 
            this.sqlDAObra.SelectCommand = this.sqlCommand2;
            this.sqlDAObra.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("Fechai", "Fechai"),
                        new System.Data.Common.DataColumnMapping("IdZona", "IdZona"),
                        new System.Data.Common.DataColumnMapping("Jfrente", "Jfrente"),
                        new System.Data.Common.DataColumnMapping("Zona", "Zona")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = resources.GetString("sqlCommand2.CommandText");
            this.sqlCommand2.Connection = this.sqlConn;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "Idobra")});
            // 
            // sqlDAIntensidad
            // 
            this.sqlDAIntensidad.SelectCommand = this.sqlCommand3;
            this.sqlDAIntensidad.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Intensidad", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdIntensidad", "IdIntensidad"),
                        new System.Data.Common.DataColumnMapping("Inferiores", "Inferiores"),
                        new System.Data.Common.DataColumnMapping("Adicionales", "Adicionales"),
                        new System.Data.Common.DataColumnMapping("Acero", "Acero"),
                        new System.Data.Common.DataColumnMapping("AceroRem", "AceroRem"),
                        new System.Data.Common.DataColumnMapping("Prefabircados", "Prefabircados"),
                        new System.Data.Common.DataColumnMapping("revenimiento", "revenimiento"),
                        new System.Data.Common.DataColumnMapping("Croquis", "Croquis"),
                        new System.Data.Common.DataColumnMapping("Laboratorio", "Laboratorio"),
                        new System.Data.Common.DataColumnMapping("Calas", "Calas"),
                        new System.Data.Common.DataColumnMapping("Mortero", "Mortero")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = resources.GetString("sqlCommand3.CommandText");
            this.sqlCommand3.Connection = this.sqlConn;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdIntensidad", System.Data.SqlDbType.NVarChar, 10, "IdIntensidad")});
            // 
            // dsInfActividad1
            // 
            this.dsInfActividad1.DataSetName = "dsInfActividad";
            this.dsInfActividad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDADuracion
            // 
            this.sqlDADuracion.SelectCommand = this.sqlCommand4;
            this.sqlDADuracion.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "SELECT     MIN(Fecha) AS Fini, MAX(Fecha) AS Ffin\r\nFROM         Concentra\r\nWHERE " +
    "    (IdObra = @IdObra)";
            this.sqlCommand4.Connection = this.sqlConn;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NChar, 6, "IdObra")});
            // 
            // sqlDADuraPres
            // 
            this.sqlDADuraPres.SelectCommand = this.sqlSelectCommand4;
            this.sqlDADuraPres.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SolicitudCar", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Presupuesto", "Presupuesto"),
                        new System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("Renglon", "Renglon"),
                        new System.Data.Common.DataColumnMapping("CanPQT", "CanPQT"),
                        new System.Data.Common.DataColumnMapping("PrePQT", "PrePQT"),
                        new System.Data.Common.DataColumnMapping("Cmetros", "Cmetros")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = resources.GetString("sqlSelectCommand4.CommandText");
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // InfActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 358);
            this.Controls.Add(this.crvInfPrecios);
            this.Controls.Add(this.panel2);
            this.Name = "InfActividad";
            this.Text = "InfActividad";
            this.Load += new System.EventHandler(this.InfActividad_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfActividad1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConn;
        private System.Data.SqlClient.SqlDataAdapter sqlDAActividad;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Windows.Forms.Panel panel2;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private System.Windows.Forms.Label label4;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInfPrecios;
        private dsBusObra dsBusObra1;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIdObra;
        public System.Data.SqlClient.SqlDataAdapter sqlDAObra;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private CryInfActividad cryInfActividad1;
        public System.Data.SqlClient.SqlDataAdapter sqlDAIntensidad;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private dsInfActividad dsInfActividad1;
        public System.Data.SqlClient.SqlDataAdapter sqlDADuracion;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        public System.Data.SqlClient.SqlDataAdapter sqlDADuraPres;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
    }
}