namespace LancNeo
{
    partial class InfGenera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfGenera));
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.nUDAño = new System.Windows.Forms.NumericUpDown();
            this.nUDSemana = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nUDRenglon = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBPre = new System.Windows.Forms.RadioButton();
            this.rdBAsf = new System.Windows.Forms.RadioButton();
            this.rdBSol = new System.Windows.Forms.RadioButton();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.crvRepTarjeta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDAInfGenera = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dsInfGenera1 = new LancNeo.dsInfGenera();
            this.sqlDAObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAPresupuesto = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.cryInfGenera1 = new LancNeo.CryInfGenera();
            this.SqlDaInfGenPresC = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAFactura = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAFacCob = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlDASolicitudCar = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand8 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAAgente = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand9 = new System.Data.SqlClient.SqlCommand();
            this.dsAgenteC1 = new LancNeo.dsAgenteC();
            this.dsInfGenera2 = new LancNeo.dsInfGenera();
            this.sqlDASolicitudPre = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand10 = new System.Data.SqlClient.SqlCommand();
            this.sqlDASolicitudPre1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand11 = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSemana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRenglon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfGenera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgenteC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfGenera2)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnVistaPrevia);
            this.panel2.Controls.Add(this.nUDAño);
            this.panel2.Controls.Add(this.nUDSemana);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nUDRenglon);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.cmbIdObra);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 95);
            this.panel2.TabIndex = 11;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(823, 1);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 63);
            this.btnVistaPrevia.TabIndex = 59;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // nUDAño
            // 
            this.nUDAño.Location = new System.Drawing.Point(714, 67);
            this.nUDAño.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.nUDAño.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nUDAño.Name = "nUDAño";
            this.nUDAño.Size = new System.Drawing.Size(44, 20);
            this.nUDAño.TabIndex = 66;
            this.nUDAño.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // nUDSemana
            // 
            this.nUDSemana.Location = new System.Drawing.Point(714, 42);
            this.nUDSemana.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.nUDSemana.Name = "nUDSemana";
            this.nUDSemana.Size = new System.Drawing.Size(44, 20);
            this.nUDSemana.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(679, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(659, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Semana:";
            // 
            // nUDRenglon
            // 
            this.nUDRenglon.Location = new System.Drawing.Point(715, 8);
            this.nUDRenglon.Name = "nUDRenglon";
            this.nUDRenglon.Size = new System.Drawing.Size(44, 20);
            this.nUDRenglon.TabIndex = 62;
            this.nUDRenglon.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(591, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Renglones adicionales:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBPre);
            this.groupBox1.Controls.Add(this.rdBAsf);
            this.groupBox1.Controls.Add(this.rdBSol);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(310, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 43);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formato reporte";
            // 
            // rdBPre
            // 
            this.rdBPre.AutoSize = true;
            this.rdBPre.Checked = true;
            this.rdBPre.Location = new System.Drawing.Point(152, 21);
            this.rdBPre.Name = "rdBPre";
            this.rdBPre.Size = new System.Drawing.Size(99, 17);
            this.rdBPre.TabIndex = 2;
            this.rdBPre.TabStop = true;
            this.rdBPre.Text = "Predeterminado";
            this.rdBPre.UseVisualStyleBackColor = true;
            // 
            // rdBAsf
            // 
            this.rdBAsf.AutoSize = true;
            this.rdBAsf.Location = new System.Drawing.Point(85, 21);
            this.rdBAsf.Name = "rdBAsf";
            this.rdBAsf.Size = new System.Drawing.Size(65, 17);
            this.rdBAsf.TabIndex = 1;
            this.rdBAsf.Text = "Asfáltico";
            this.rdBAsf.UseVisualStyleBackColor = true;
            // 
            // rdBSol
            // 
            this.rdBSol.AutoSize = true;
            this.rdBSol.Location = new System.Drawing.Point(6, 20);
            this.rdBSol.Name = "rdBSol";
            this.rdBSol.Size = new System.Drawing.Size(73, 17);
            this.rdBSol.TabIndex = 0;
            this.rdBSol.Text = "Soldadura";
            this.rdBSol.UseVisualStyleBackColor = true;
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(483, 8);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 57;
            this.cmbIdObra.ValueMember = "IdObra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(443, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Obra:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 56);
            this.label4.TabIndex = 54;
            this.label4.Text = "Informe de generación de facturas";
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
            this.crvRepTarjeta.Size = new System.Drawing.Size(920, 283);
            this.crvRepTarjeta.TabIndex = 13;
            this.crvRepTarjeta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvRepTarjeta.Visible = false;
            // 
            // sqlDAInfGenera
            // 
            this.sqlDAInfGenera.SelectCommand = this.sqlCommand2;
            this.sqlDAInfGenera.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "InfGenera";
            this.sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand2.Connection = this.sqlConn;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6)});
            // 
            // dsInfGenera1
            // 
            this.dsInfGenera1.DataSetName = "dsInfGenera";
            this.dsInfGenera1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAObra
            // 
            this.sqlDAObra.SelectCommand = this.sqlCommand3;
            this.sqlDAObra.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("Codigop", "Codigop"),
                        new System.Data.Common.DataColumnMapping("Solicitud", "Solicitud"),
                        new System.Data.Common.DataColumnMapping("Fechai", "Fechai"),
                        new System.Data.Common.DataColumnMapping("Fechaf", "Fechaf"),
                        new System.Data.Common.DataColumnMapping("PresupuestoZ", "PresupuestoZ"),
                        new System.Data.Common.DataColumnMapping("Informes", "Informes"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Domicilio", "Domicilio"),
                        new System.Data.Common.DataColumnMapping("Expr1", "Expr1"),
                        new System.Data.Common.DataColumnMapping("Codpos", "Codpos"),
                        new System.Data.Common.DataColumnMapping("Encargada", "Encargada"),
                        new System.Data.Common.DataColumnMapping("email", "email"),
                        new System.Data.Common.DataColumnMapping("Revision", "Revision"),
                        new System.Data.Common.DataColumnMapping("Pagos", "Pagos"),
                        new System.Data.Common.DataColumnMapping("diar", "diar"),
                        new System.Data.Common.DataColumnMapping("diap", "diap"),
                        new System.Data.Common.DataColumnMapping("Telefonot", "Telefonot")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = resources.GetString("sqlCommand3.CommandText");
            this.sqlCommand3.Connection = this.sqlConn;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "Idobra")});
            // 
            // sqlDAPresupuesto
            // 
            this.sqlDAPresupuesto.SelectCommand = this.sqlCommand4;
            this.sqlDAPresupuesto.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("Colonia", "Colonia"),
                        new System.Data.Common.DataColumnMapping("Codigop", "Codigop"),
                        new System.Data.Common.DataColumnMapping("Solicitud", "Solicitud"),
                        new System.Data.Common.DataColumnMapping("Fechai", "Fechai"),
                        new System.Data.Common.DataColumnMapping("Fechaf", "Fechaf"),
                        new System.Data.Common.DataColumnMapping("PresupuestoZ", "PresupuestoZ"),
                        new System.Data.Common.DataColumnMapping("Informes", "Informes"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Domicilio", "Domicilio"),
                        new System.Data.Common.DataColumnMapping("Expr1", "Expr1"),
                        new System.Data.Common.DataColumnMapping("Codpos", "Codpos"),
                        new System.Data.Common.DataColumnMapping("Encargada", "Encargada"),
                        new System.Data.Common.DataColumnMapping("email", "email"),
                        new System.Data.Common.DataColumnMapping("Revision", "Revision"),
                        new System.Data.Common.DataColumnMapping("Pagos", "Pagos"),
                        new System.Data.Common.DataColumnMapping("diar", "diar"),
                        new System.Data.Common.DataColumnMapping("diap", "diap"),
                        new System.Data.Common.DataColumnMapping("Telefonot", "Telefonot")})});
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "InfGenPres";
            this.sqlCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand4.Connection = this.sqlConn;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6)});
            // 
            // SqlDaInfGenPresC
            // 
            this.SqlDaInfGenPresC.SelectCommand = this.sqlCommand5;
            this.SqlDaInfGenPresC.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "InfGenPresC";
            this.sqlCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand5.Connection = this.sqlConn;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6)});
            // 
            // sqlDAFactura
            // 
            this.sqlDAFactura.SelectCommand = this.sqlCommand6;
            this.sqlDAFactura.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlCommand6
            // 
            this.sqlCommand6.CommandText = resources.GetString("sqlCommand6.CommandText");
            this.sqlCommand6.Connection = this.sqlConn;
            this.sqlCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "Obra")});
            // 
            // sqlDAFacCob
            // 
            this.sqlDAFacCob.SelectCommand = this.sqlCommand7;
            this.sqlDAFacCob.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlCommand7
            // 
            this.sqlCommand7.CommandText = resources.GetString("sqlCommand7.CommandText");
            this.sqlCommand7.Connection = this.sqlConn;
            this.sqlCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "Obra")});
            // 
            // sqlDASolicitudCar
            // 
            this.sqlDASolicitudCar.SelectCommand = this.sqlCommand8;
            this.sqlDASolicitudCar.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SolicitudCar", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdSolicitud", "IdSolicitud"),
                        new System.Data.Common.DataColumnMapping("Año", "Año"),
                        new System.Data.Common.DataColumnMapping("Renglon", "Renglon"),
                        new System.Data.Common.DataColumnMapping("Caracteristica", "Caracteristica"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"),
                        new System.Data.Common.DataColumnMapping("Ajustada", "Ajustada"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra")})});
            // 
            // sqlCommand8
            // 
            this.sqlCommand8.CommandText = resources.GetString("sqlCommand8.CommandText");
            this.sqlCommand8.Connection = this.sqlConn;
            this.sqlCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // sqlDAAgente
            // 
            this.sqlDAAgente.SelectCommand = this.sqlCommand9;
            this.sqlDAAgente.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SolicitudCar", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdSolicitud", "IdSolicitud"),
                        new System.Data.Common.DataColumnMapping("Año", "Año"),
                        new System.Data.Common.DataColumnMapping("Renglon", "Renglon"),
                        new System.Data.Common.DataColumnMapping("Caracteristica", "Caracteristica"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"),
                        new System.Data.Common.DataColumnMapping("Ajustada", "Ajustada"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra")})});
            // 
            // sqlCommand9
            // 
            this.sqlCommand9.CommandText = "SELECT     IdAgente, IdObra, Agente\r\nFROM         Agente\r\nWHERE     (IdObra = @Id" +
    "Obra)";
            this.sqlCommand9.Connection = this.sqlConn;
            this.sqlCommand9.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // dsAgenteC1
            // 
            this.dsAgenteC1.DataSetName = "dsAgenteC";
            this.dsAgenteC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsInfGenera2
            // 
            this.dsInfGenera2.DataSetName = "dsInfGenera";
            this.dsInfGenera2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            new System.Data.SqlClient.SqlParameter("@Version", System.Data.SqlDbType.SmallInt, 2, "Version"),
            new System.Data.SqlClient.SqlParameter("@IdSolicitud", System.Data.SqlDbType.SmallInt, 2, "IdSolicitud"),
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 2, "Año")});
            // 
            // sqlDASolicitudPre1
            // 
            this.sqlDASolicitudPre1.SelectCommand = this.sqlCommand11;
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
            // sqlCommand11
            // 
            this.sqlCommand11.CommandText = resources.GetString("sqlCommand11.CommandText");
            this.sqlCommand11.Connection = this.sqlConn;
            this.sqlCommand11.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Version", System.Data.SqlDbType.SmallInt, 2, "Version"),
            new System.Data.SqlClient.SqlParameter("@IdSolicitud", System.Data.SqlDbType.SmallInt, 2, "IdSolicitud"),
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 2, "Año")});
            // 
            // InfGenera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 378);
            this.Controls.Add(this.crvRepTarjeta);
            this.Controls.Add(this.panel2);
            this.Name = "InfGenera";
            this.Text = "InfGenera";
            this.Load += new System.EventHandler(this.InfGenera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSemana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRenglon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfGenera1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgenteC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfGenera2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConn;
        private dsBusObra dsBusObra1;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Panel panel2;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private System.Windows.Forms.ComboBox cmbIdObra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepTarjeta;
        public System.Data.SqlClient.SqlDataAdapter sqlDAInfGenera;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private dsInfGenera dsInfGenera1;
        public System.Data.SqlClient.SqlDataAdapter sqlDAObra;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        public System.Data.SqlClient.SqlDataAdapter sqlDAPresupuesto;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private CryInfGenera cryInfGenera1;
        public System.Data.SqlClient.SqlDataAdapter SqlDaInfGenPresC;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
        public System.Data.SqlClient.SqlDataAdapter sqlDAFactura;
        private System.Data.SqlClient.SqlCommand sqlCommand6;
        public System.Data.SqlClient.SqlDataAdapter sqlDAFacCob;
        private System.Data.SqlClient.SqlCommand sqlCommand7;
        private System.Data.SqlClient.SqlDataAdapter sqlDASolicitudCar;
        private System.Data.SqlClient.SqlCommand sqlCommand8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBPre;
        private System.Windows.Forms.RadioButton rdBAsf;
        private System.Windows.Forms.RadioButton rdBSol;
        private System.Data.SqlClient.SqlDataAdapter sqlDAAgente;
        private System.Data.SqlClient.SqlCommand sqlCommand9;
        private dsAgenteC dsAgenteC1;
        private System.Windows.Forms.NumericUpDown nUDRenglon;
        private System.Windows.Forms.Label label1;
        private dsInfGenera dsInfGenera2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUDAño;
        private System.Windows.Forms.NumericUpDown nUDSemana;
        private System.Data.SqlClient.SqlDataAdapter sqlDASolicitudPre;
        private System.Data.SqlClient.SqlCommand sqlCommand10;
        private System.Data.SqlClient.SqlDataAdapter sqlDASolicitudPre1;
        private System.Data.SqlClient.SqlCommand sqlCommand11;
    }
}