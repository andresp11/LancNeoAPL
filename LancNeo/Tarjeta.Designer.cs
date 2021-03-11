namespace LancNeo
{
    partial class Tarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarjeta));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.crvRepTarjeta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAEmpresa = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDACliente = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dsTarjeta1 = new LancNeo.dsTarjeta();
            this.cryTarjeta1 = new LancNeo.CryTarjeta();
            this.sqlComAgrega = new System.Data.SqlClient.SqlCommand();
            this.sqlDAServicios = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.dsServicios1 = new LancNeo.dsServicios();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTarjeta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServicios1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnVistaPrevia);
            this.panel2.Controls.Add(this.cmbIdObra);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 95);
            this.panel2.TabIndex = 10;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(527, 8);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 63);
            this.btnVistaPrevia.TabIndex = 59;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(386, 8);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 57;
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
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(326, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Obra inicial:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 56);
            this.label4.TabIndex = 54;
            this.label4.Text = "Informe de tarjetas";
            // 
            // crvRepTarjeta
            // 
            this.crvRepTarjeta.ActiveViewIndex = -1;
            this.crvRepTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRepTarjeta.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRepTarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRepTarjeta.EnableRefresh = false;
            this.crvRepTarjeta.Location = new System.Drawing.Point(0, 95);
            this.crvRepTarjeta.Name = "crvRepTarjeta";
            this.crvRepTarjeta.ShowCloseButton = false;
            this.crvRepTarjeta.ShowGroupTreeButton = false;
            this.crvRepTarjeta.ShowLogo = false;
            this.crvRepTarjeta.Size = new System.Drawing.Size(620, 167);
            this.crvRepTarjeta.TabIndex = 12;
            this.crvRepTarjeta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvRepTarjeta.Visible = false;
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
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
            this.sqlCommand1.CommandText = "SELECT DISTINCT Idobra, Ubicacion, RFC, Informes AS Facturar\r\nFROM            Obr" +
    "a\r\nORDER BY Idobra";
            this.sqlCommand1.Connection = this.sqlConn;
            // 
            // sqlDAObra
            // 
            this.sqlDAObra.SelectCommand = this.sqlCommand2;
            this.sqlDAObra.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("IdCliente", "IdCliente"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"),
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
                        new System.Data.Common.DataColumnMapping("SeEspe", "SeEspe"),
                        new System.Data.Common.DataColumnMapping("CualEsp", "CualEsp"),
                        new System.Data.Common.DataColumnMapping("DelOMun", "DelOMun"),
                        new System.Data.Common.DataColumnMapping("Correo5", "Correo5")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = resources.GetString("sqlCommand2.CommandText");
            this.sqlCommand2.Connection = this.sqlConn;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "Idobra")});
            // 
            // sqlDAEmpresa
            // 
            this.sqlDAEmpresa.SelectCommand = this.sqlCommand3;
            this.sqlDAEmpresa.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = resources.GetString("sqlCommand3.CommandText");
            this.sqlCommand3.Connection = this.sqlConn;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "Idobra")});
            // 
            // sqlDACliente
            // 
            this.sqlDACliente.SelectCommand = this.sqlCommand4;
            this.sqlDACliente.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = resources.GetString("sqlCommand4.CommandText");
            this.sqlCommand4.Connection = this.sqlConn;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "Idobra")});
            // 
            // dsTarjeta1
            // 
            this.dsTarjeta1.DataSetName = "dsTarjeta";
            this.dsTarjeta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlComAgrega
            // 
            this.sqlComAgrega.CommandText = "[agregaconcentra]";
            this.sqlComAgrega.CommandTimeout = 1200;
            this.sqlComAgrega.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComAgrega.Connection = this.sqlConn;
            this.sqlComAgrega.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FIni", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@FFin", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@Mortero", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdObram", System.Data.SqlDbType.NVarChar, 6)});
            // 
            // sqlDAServicios
            // 
            this.sqlDAServicios.SelectCommand = this.sqlCommand5;
            this.sqlDAServicios.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("IdCliente", "IdCliente"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"),
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
                        new System.Data.Common.DataColumnMapping("SeEspe", "SeEspe"),
                        new System.Data.Common.DataColumnMapping("CualEsp", "CualEsp"),
                        new System.Data.Common.DataColumnMapping("DelOMun", "DelOMun"),
                        new System.Data.Common.DataColumnMapping("Correo5", "Correo5")})});
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SELECT        IdObra, Fecha, Consecutivo, Identificador, IdConcepto, Cantidad, Op" +
    "erador, IdInforme\r\nFROM            Servicios\r\nWHERE        (IdObra = @IdObra)\r\nO" +
    "RDER BY Fecha";
            this.sqlCommand5.Connection = this.sqlConn;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NChar, 6, "IdObra")});
            // 
            // dsServicios1
            // 
            this.dsServicios1.DataSetName = "dsServicios";
            this.dsServicios1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsServicios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 262);
            this.Controls.Add(this.crvRepTarjeta);
            this.Controls.Add(this.panel2);
            this.Name = "Tarjeta";
            this.Text = "Tarjeta";
            this.Load += new System.EventHandler(this.Tarjeta_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTarjeta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServicios1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private System.Windows.Forms.ComboBox cmbIdObra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepTarjeta;
        private System.Data.SqlClient.SqlConnection sqlConn;
        private dsBusObra dsBusObra1;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        public System.Data.SqlClient.SqlDataAdapter sqlDAObra;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        public System.Data.SqlClient.SqlDataAdapter sqlDAEmpresa;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        public System.Data.SqlClient.SqlDataAdapter sqlDACliente;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private dsTarjeta dsTarjeta1;
        private CryTarjeta cryTarjeta1;
        private System.Data.SqlClient.SqlCommand sqlComAgrega;
        public System.Data.SqlClient.SqlDataAdapter sqlDAServicios;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
        private dsServicios dsServicios1;
    }
}