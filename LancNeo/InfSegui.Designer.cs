namespace LancNeo
{
    partial class InfSegui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfSegui));
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.crvInfPrecios = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.sqlDASolicitud = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDASolicitudPre = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand10 = new System.Data.SqlClient.SqlCommand();
            this.sqlDASolicitudCar = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlDASolicitudPre1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDASolicitudPre2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dsInfSegui1 = new LancNeo.dsInfSegui();
            this.sqlDASolPre = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.cryInfSegui1 = new LancNeo.CryInfSegui();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfSegui1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
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
            this.crvInfPrecios.TabIndex = 15;
            this.crvInfPrecios.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvInfPrecios.ToolPanelWidth = 167;
            this.crvInfPrecios.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnVistaPrevia);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 71);
            this.panel2.TabIndex = 14;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(406, 36);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(80, 20);
            this.dateTimePicker2.TabIndex = 61;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(406, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(80, 20);
            this.dateTimePicker1.TabIndex = 60;
            this.dateTimePicker1.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_Validating);
            this.dateTimePicker1.Validated += new System.EventHandler(this.dateTimePicker1_Validated);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 41);
            this.label4.TabIndex = 54;
            this.label4.Text = "Seguimiento presupuestos";
            // 
            // sqlDASolicitud
            // 
            this.sqlDASolicitud.SelectCommand = this.sqlSelectCommand1;
            this.sqlDASolicitud.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Solicitud", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdSolicitud", "IdSolicitud"),
                        new System.Data.Common.DataColumnMapping("Año", "Año"),
                        new System.Data.Common.DataColumnMapping("LocFor", "LocFor"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("Constructora", "Constructora"),
                        new System.Data.Common.DataColumnMapping("Atención", "Atención"),
                        new System.Data.Common.DataColumnMapping("email", "email"),
                        new System.Data.Common.DataColumnMapping("Encargado", "Encargado"),
                        new System.Data.Common.DataColumnMapping("Oficina", "Oficina"),
                        new System.Data.Common.DataColumnMapping("Telefono", "Telefono"),
                        new System.Data.Common.DataColumnMapping("Celular", "Celular"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("TipoObra", "TipoObra"),
                        new System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("Presupuesto", "Presupuesto"),
                        new System.Data.Common.DataColumnMapping("IvaPrecios", "IvaPrecios"),
                        new System.Data.Common.DataColumnMapping("IvaPaquete", "IvaPaquete"),
                        new System.Data.Common.DataColumnMapping("ConceptoPQT", "ConceptoPQT"),
                        new System.Data.Common.DataColumnMapping("AnexoNorma", "AnexoNorma"),
                        new System.Data.Common.DataColumnMapping("AnexoIntensidad", "AnexoIntensidad"),
                        new System.Data.Common.DataColumnMapping("FecAprobado", "FecAprobado"),
                        new System.Data.Common.DataColumnMapping("Instalaciones", "Instalaciones"),
                        new System.Data.Common.DataColumnMapping("FormaPago", "FormaPago")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Fechai", System.Data.SqlDbType.SmallDateTime, 4, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@Fechaf", System.Data.SqlDbType.SmallDateTime, 4, "Fecha")});
            // 
            // sqlDASolicitudPre
            // 
            this.sqlDASolicitudPre.SelectCommand = this.sqlCommand10;
            this.sqlDASolicitudPre.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SolicitudPre", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdSolicitud", "IdSolicitud"),
                        new System.Data.Common.DataColumnMapping("Año", "Año"),
                        new System.Data.Common.DataColumnMapping("Renglon", "Renglon"),
                        new System.Data.Common.DataColumnMapping("Version", "Version"),
                        new System.Data.Common.DataColumnMapping("IdPrecio", "IdPrecio"),
                        new System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"),
                        new System.Data.Common.DataColumnMapping("Precio", "Precio"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("Concepto", "Concepto")})});
            // 
            // sqlCommand10
            // 
            this.sqlCommand10.CommandText = resources.GetString("sqlCommand10.CommandText");
            this.sqlCommand10.Connection = this.sqlConn;
            this.sqlCommand10.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Fechai", System.Data.SqlDbType.SmallDateTime, 4, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@Fechaf", System.Data.SqlDbType.SmallDateTime, 4, "Fecha")});
            // 
            // sqlDASolicitudCar
            // 
            this.sqlDASolicitudCar.SelectCommand = this.sqlCommand6;
            this.sqlDASolicitudCar.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SolicitudCar", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdSolicitud", "IdSolicitud"),
                        new System.Data.Common.DataColumnMapping("Año", "Año"),
                        new System.Data.Common.DataColumnMapping("Renglon", "Renglon"),
                        new System.Data.Common.DataColumnMapping("Caracteristica", "Caracteristica"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"),
                        new System.Data.Common.DataColumnMapping("Ajustada", "Ajustada")})});
            // 
            // sqlCommand6
            // 
            this.sqlCommand6.CommandText = resources.GetString("sqlCommand6.CommandText");
            this.sqlCommand6.Connection = this.sqlConn;
            this.sqlCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Fechai", System.Data.SqlDbType.SmallDateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Current, "31/12/2019"),
            new System.Data.SqlClient.SqlParameter("@Fechaf", System.Data.SqlDbType.SmallDateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Current, "19/01/2020")});
            // 
            // sqlDASolicitudPre1
            // 
            this.sqlDASolicitudPre1.SelectCommand = this.sqlCommand1;
            this.sqlDASolicitudPre1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SolicitudPre", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdSolicitud", "IdSolicitud"),
                        new System.Data.Common.DataColumnMapping("Año", "Año"),
                        new System.Data.Common.DataColumnMapping("Renglon", "Renglon"),
                        new System.Data.Common.DataColumnMapping("Version", "Version"),
                        new System.Data.Common.DataColumnMapping("IdPrecio", "IdPrecio"),
                        new System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"),
                        new System.Data.Common.DataColumnMapping("Precio", "Precio"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("Concepto", "Concepto")})});
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConn;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Fechai", System.Data.SqlDbType.SmallDateTime, 4, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@Fechaf", System.Data.SqlDbType.SmallDateTime, 4, "Fecha")});
            // 
            // sqlDASolicitudPre2
            // 
            this.sqlDASolicitudPre2.SelectCommand = this.sqlCommand2;
            this.sqlDASolicitudPre2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SolicitudPre", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdSolicitud", "IdSolicitud"),
                        new System.Data.Common.DataColumnMapping("Año", "Año"),
                        new System.Data.Common.DataColumnMapping("Renglon", "Renglon"),
                        new System.Data.Common.DataColumnMapping("Version", "Version"),
                        new System.Data.Common.DataColumnMapping("IdPrecio", "IdPrecio"),
                        new System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"),
                        new System.Data.Common.DataColumnMapping("Precio", "Precio"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("Concepto", "Concepto")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = resources.GetString("sqlCommand2.CommandText");
            this.sqlCommand2.Connection = this.sqlConn;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Fechai", System.Data.SqlDbType.SmallDateTime, 4, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@Fechaf", System.Data.SqlDbType.SmallDateTime, 4, "Fecha")});
            // 
            // dsInfSegui1
            // 
            this.dsInfSegui1.DataSetName = "dsInfSegui";
            this.dsInfSegui1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDASolPre
            // 
            this.sqlDASolPre.SelectCommand = this.sqlCommand3;
            this.sqlDASolPre.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SolicitudPre", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdSolicitud", "IdSolicitud"),
                        new System.Data.Common.DataColumnMapping("Año", "Año"),
                        new System.Data.Common.DataColumnMapping("Renglon", "Renglon"),
                        new System.Data.Common.DataColumnMapping("Version", "Version"),
                        new System.Data.Common.DataColumnMapping("IdPrecio", "IdPrecio"),
                        new System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"),
                        new System.Data.Common.DataColumnMapping("Precio", "Precio"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("Concepto", "Concepto")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = resources.GetString("sqlCommand3.CommandText");
            this.sqlCommand3.Connection = this.sqlConn;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdSolicitud", System.Data.SqlDbType.SmallInt, 2, "IdSolicitud"),
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 2, "Año")});
            // 
            // InfSegui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 358);
            this.Controls.Add(this.crvInfPrecios);
            this.Controls.Add(this.panel2);
            this.Name = "InfSegui";
            this.Text = "InfSegui";
            this.Load += new System.EventHandler(this.InfSegui_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsInfSegui1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConn;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInfPrecios;
        private System.Windows.Forms.Panel panel2;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Data.SqlClient.SqlDataAdapter sqlDASolicitud;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDASolicitudPre;
        private System.Data.SqlClient.SqlCommand sqlCommand10;
        private System.Data.SqlClient.SqlDataAdapter sqlDASolicitudCar;
        private System.Data.SqlClient.SqlCommand sqlCommand6;
        private System.Data.SqlClient.SqlDataAdapter sqlDASolicitudPre1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private dsInfSegui dsInfSegui1;
        private CryInfSegui cryInfSegui1;
        private System.Data.SqlClient.SqlDataAdapter sqlDASolicitudPre2;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDASolPre;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
    }
}