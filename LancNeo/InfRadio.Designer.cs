namespace LancNeo
{
    partial class InfRadio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfRadio));
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsInfRadio1 = new LancNeo.dsInfRadio();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsRadio1 = new LancNeo.dsRadio();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.crvInfAcero = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cryRepRadio1 = new LancNeo.CryRepRadio();
            this.sqlDAFirmas = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.dsFirmas1 = new LancNeo.dsFirmas();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDARadioMdor = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDARadioRes = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDARazon = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDARadio = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfRadio1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsInfRadio1
            // 
            this.dsInfRadio1.DataSetName = "dsInfRadio";
            this.dsInfRadio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.txtFolio);
            this.panel1.Controls.Add(this.cmbIdObra);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 80);
            this.panel1.TabIndex = 50;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 400;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsRadio1.RadioMdor;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(432, 3);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 63);
            this.buscaBtn1.TabIndex = 51;
            this.buscaBtn1.Visible = false;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsRadio1
            // 
            this.dsRadio1.DataSetName = "dsRadio";
            this.dsRadio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(609, 3);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 63);
            this.btnVistaPrevia.TabIndex = 52;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(543, 7);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(56, 20);
            this.txtFolio.TabIndex = 53;
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(345, 9);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 50;
            this.cmbIdObra.ValueMember = "IdObra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Obra:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 56);
            this.label4.TabIndex = 0;
            this.label4.Text = "Informe de Radiografía";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Folio:";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(432, 32);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // crvInfAcero
            // 
            this.crvInfAcero.ActiveViewIndex = -1;
            this.crvInfAcero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInfAcero.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInfAcero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInfAcero.EnableRefresh = false;
            this.crvInfAcero.Location = new System.Drawing.Point(0, 80);
            this.crvInfAcero.Name = "crvInfAcero";
            this.crvInfAcero.ShowCloseButton = false;
            this.crvInfAcero.ShowCopyButton = false;
            this.crvInfAcero.ShowGroupTreeButton = false;
            this.crvInfAcero.ShowLogo = false;
            this.crvInfAcero.Size = new System.Drawing.Size(849, 449);
            this.crvInfAcero.TabIndex = 51;
            this.crvInfAcero.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // sqlDAFirmas
            // 
            this.sqlDAFirmas.SelectCommand = this.sqlSelectCommand7;
            this.sqlDAFirmas.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Firmas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdFirma", "IdFirma"),
                        new System.Data.Common.DataColumnMapping("Nombre", "Nombre"),
                        new System.Data.Common.DataColumnMapping("Cargo", "Cargo"),
                        new System.Data.Common.DataColumnMapping("Imprime", "Imprime")})});
            // 
            // sqlSelectCommand7
            // 
            this.sqlSelectCommand7.CommandText = "SELECT     IdFirma, Nombre, Cargo, Imprime\r\nFROM         Firmas\r\nWHERE     (Impri" +
    "me = 1) AND (IdFirma = 1)\r\nORDER BY IdFirma";
            this.sqlSelectCommand7.Connection = this.sqlConn;
            // 
            // dsFirmas1
            // 
            this.dsFirmas1.DataSetName = "dsFirmas";
            this.dsFirmas1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsFirmas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@IdFolio", System.Data.SqlDbType.Char, 10, "FOLIO")});
            // 
            // sqlDARadioMdor
            // 
            this.sqlDARadioMdor.SelectCommand = this.sqlSelectCommand1;
            this.sqlDARadioMdor.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "RadioMdor", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("Fmuestreo", "Fmuestreo"),
                        new System.Data.Common.DataColumnMapping("Fuente", "Fuente"),
                        new System.Data.Common.DataColumnMapping("Actividad", "Actividad"),
                        new System.Data.Common.DataColumnMapping("PFocal", "PFocal"),
                        new System.Data.Common.DataColumnMapping("DFP", "DFP"),
                        new System.Data.Common.DataColumnMapping("TipoP", "TipoP"),
                        new System.Data.Common.DataColumnMapping("Pantalla", "Pantalla"),
                        new System.Data.Common.DataColumnMapping("TecnicaP", "TecnicaP"),
                        new System.Data.Common.DataColumnMapping("Tecnicae", "Tecnicae"),
                        new System.Data.Common.DataColumnMapping("Proc", "Proc"),
                        new System.Data.Common.DataColumnMapping("Norma", "Norma"),
                        new System.Data.Common.DataColumnMapping("Material", "Material"),
                        new System.Data.Common.DataColumnMapping("IQIU", "IQIU"),
                        new System.Data.Common.DataColumnMapping("Diseño", "Diseño"),
                        new System.Data.Common.DataColumnMapping("NoPeliculas", "NoPeliculas")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT     FOLIO, Renglon, IdRadio, NoPelicula, Defectos, Evaluacion, Observacion" +
    "es\r\nFROM         RadioRes\r\nWHERE     (FOLIO = @IdFolio)\r\nORDER BY Renglon";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdFolio", System.Data.SqlDbType.Char, 10, "FOLIO")});
            // 
            // sqlDARadioRes
            // 
            this.sqlDARadioRes.SelectCommand = this.sqlSelectCommand2;
            this.sqlDARadioRes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "RadioRes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("Renglon", "Renglon"),
                        new System.Data.Common.DataColumnMapping("IdRadio", "IdRadio"),
                        new System.Data.Common.DataColumnMapping("NoPelicula", "NoPelicula"),
                        new System.Data.Common.DataColumnMapping("Defectos", "Defectos"),
                        new System.Data.Common.DataColumnMapping("Evaluacion", "Evaluacion"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT     IdCliente, RFC, Facturar, Domicilio, Colonia, Codpos, Lugar, Entrega, " +
    "Direcciont, Coloniat, Telefonot\r\nFROM         Razonsocial\r\nWHERE     (RFC = @Rfc" +
    ")";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Rfc", System.Data.SqlDbType.NVarChar, 13, "RFC")});
            // 
            // sqlDARazon
            // 
            this.sqlDARazon.SelectCommand = this.sqlSelectCommand3;
            this.sqlDARazon.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Razonsocial", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdCliente", "IdCliente"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar"),
                        new System.Data.Common.DataColumnMapping("Domicilio", "Domicilio"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("Codpos", "Codpos"),
                        new System.Data.Common.DataColumnMapping("Lugar", "Lugar"),
                        new System.Data.Common.DataColumnMapping("Entrega", "Entrega"),
                        new System.Data.Common.DataColumnMapping("Direcciont", "Direcciont"),
                        new System.Data.Common.DataColumnMapping("Coloniat", "Coloniat"),
                        new System.Data.Common.DataColumnMapping("Telefonot", "Telefonot")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = resources.GetString("sqlSelectCommand4.CommandText");
            this.sqlSelectCommand4.Connection = this.sqlConn;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "Idobra")});
            // 
            // sqlDAObra
            // 
            this.sqlDAObra.SelectCommand = this.sqlSelectCommand4;
            this.sqlDAObra.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "cliente", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdCliente", "IdCliente"),
                        new System.Data.Common.DataColumnMapping("Cliente", "Cliente"),
                        new System.Data.Common.DataColumnMapping("GerenteCons", "GerenteCons"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("CodPos", "CodPos"),
                        new System.Data.Common.DataColumnMapping("TelefonoOfna", "TelefonoOfna"),
                        new System.Data.Common.DataColumnMapping("Fax", "Fax"),
                        new System.Data.Common.DataColumnMapping("Encargado", "Encargado"),
                        new System.Data.Common.DataColumnMapping("Revision", "Revision"),
                        new System.Data.Common.DataColumnMapping("diasr", "diasr"),
                        new System.Data.Common.DataColumnMapping("horari", "horari"),
                        new System.Data.Common.DataColumnMapping("horarf", "horarf"),
                        new System.Data.Common.DataColumnMapping("Pago", "Pago"),
                        new System.Data.Common.DataColumnMapping("diap", "diap"),
                        new System.Data.Common.DataColumnMapping("horapi", "horapi"),
                        new System.Data.Common.DataColumnMapping("horapf", "horapf"),
                        new System.Data.Common.DataColumnMapping("Esposa", "Esposa"),
                        new System.Data.Common.DataColumnMapping("Direccionp", "Direccionp"),
                        new System.Data.Common.DataColumnMapping("Coloniap", "Coloniap")})});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "SELECT     IdObra, FOLIO, ConsObra, CAST(Fmuestreo AS char(11)) AS Fecha, Fuente," +
    " TipoP\r\nFROM         RadioMdor\r\nWHERE     (IdObra = @IdObra)\r\nORDER BY FOLIO";
            this.sqlSelectCommand5.Connection = this.sqlConn;
            this.sqlSelectCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // sqlDARadio
            // 
            this.sqlDARadio.SelectCommand = this.sqlSelectCommand5;
            this.sqlDARadio.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "RadioMdor", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Fuente", "Fuente"),
                        new System.Data.Common.DataColumnMapping("TipoP", "TipoP")})});
            // 
            // InfRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 529);
            this.Controls.Add(this.crvInfAcero);
            this.Controls.Add(this.panel1);
            this.Name = "InfRadio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfRadio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfRadio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsInfRadio1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFirmas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConn;
        private dsInfRadio dsInfRadio1;
        private System.Windows.Forms.Panel panel1;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.ComboBox cmbIdObra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdobra;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInfAcero;
        private CryRepRadio cryRepRadio1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAFirmas;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
        private dsFirmas dsFirmas1;
        private dsBusObra dsBusObra1;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDARadioMdor;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDARadioRes;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlDataAdapter sqlDARazon;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlDataAdapter sqlDAObra;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private System.Data.SqlClient.SqlDataAdapter sqlDARadio;
        private dsRadio dsRadio1;
    }
}