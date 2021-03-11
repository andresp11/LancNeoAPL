namespace LancNeo
{
    partial class InfPresup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfPresup));
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDABusSol = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsBusSol1 = new LancNeo.dsBusSol();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.chkFirma = new System.Windows.Forms.CheckBox();
            this.chkNotas = new System.Windows.Forms.CheckBox();
            this.chkAtencion = new System.Windows.Forms.CheckBox();
            this.chkCarac = new System.Windows.Forms.CheckBox();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.chkFormaPago = new System.Windows.Forms.CheckBox();
            this.chkLetras = new System.Windows.Forms.CheckBox();
            this.chkSalIns = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudRenglon = new System.Windows.Forms.NumericUpDown();
            this.chkSaltoNota = new System.Windows.Forms.CheckBox();
            this.chkInstalaCala = new System.Windows.Forms.CheckBox();
            this.chkSoldadura = new System.Windows.Forms.CheckBox();
            this.chkTotales = new System.Windows.Forms.CheckBox();
            this.chkSaltoi = new System.Windows.Forms.CheckBox();
            this.chkSalto = new System.Windows.Forms.CheckBox();
            this.grBFirmas = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.chkIntensidas = new System.Windows.Forms.CheckBox();
            this.chkInstalacion = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpAprobado = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIdObra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.lblIdBascula = new System.Windows.Forms.Label();
            this.txtSolicitud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbVersion = new System.Windows.Forms.ComboBox();
            this.dsSolicitudVer1 = new LancNeo.dsSolicitudVer();
            this.txtUsrMov = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.crvPresupuesto = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.sqlDASolicitud = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDASolicitudSer = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDASolicitudCar = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlDASolicitudPre = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand10 = new System.Data.SqlClient.SqlCommand();
            this.dsInfPresup1 = new LancNeo.dsInfPresup();
            this.sqlDAVersion = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand14 = new System.Data.SqlClient.SqlCommand();
            this.sqlDASolicitudPre1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAIntensidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlComAgrega = new System.Data.SqlClient.SqlCommand();
            this.cryInfPresup1 = new LancNeo.CryInfPresup();
            this.sqlDASolicitudPre2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusSol1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenglon)).BeginInit();
            this.grBFirmas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSolicitudVer1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfPresup1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDABusSol
            // 
            this.sqlDABusSol.SelectCommand = this.sqlSelectCommand2;
            this.sqlDABusSol.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
            this.sqlSelectCommand2.CommandText = "SELECT     IdSolicitud, Año, LocFor, Fecha, Direccion, IdObra, TipoObra, Presupue" +
    "sto, FecAprobado\r\nFROM         Solicitud\r\nORDER BY Año DESC, IdSolicitud DESC";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.buscaBtn1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbFormato);
            this.panel1.Controls.Add(this.chkFirma);
            this.panel1.Controls.Add(this.chkNotas);
            this.panel1.Controls.Add(this.chkAtencion);
            this.panel1.Controls.Add(this.chkCarac);
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.chkFormaPago);
            this.panel1.Controls.Add(this.chkLetras);
            this.panel1.Controls.Add(this.chkSalIns);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.nudRenglon);
            this.panel1.Controls.Add(this.chkSaltoNota);
            this.panel1.Controls.Add(this.chkInstalaCala);
            this.panel1.Controls.Add(this.chkSoldadura);
            this.panel1.Controls.Add(this.chkTotales);
            this.panel1.Controls.Add(this.chkSaltoi);
            this.panel1.Controls.Add(this.chkSalto);
            this.panel1.Controls.Add(this.grBFirmas);
            this.panel1.Controls.Add(this.chkIntensidas);
            this.panel1.Controls.Add(this.chkInstalacion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpAprobado);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtPresupuesto);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtIdObra);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtUbicacion);
            this.panel1.Controls.Add(this.cmbZona);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAño);
            this.panel1.Controls.Add(this.lblIdBascula);
            this.panel1.Controls.Add(this.txtSolicitud);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.cmbVersion);
            this.panel1.Controls.Add(this.txtUsrMov);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 93);
            this.panel1.TabIndex = 10;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 750;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsBusSol1.Solicitud;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(116, 26);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 94;
            this.buscaBtn1.Click += new System.EventHandler(this.buscaBtn1_Click);
            // 
            // dsBusSol1
            // 
            this.dsBusSol1.DataSetName = "dsBusSol";
            this.dsBusSol1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(438, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 123;
            this.label8.Text = "Formato:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbFormato
            // 
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Items.AddRange(new object[] {
            "A",
            "C",
            "D"});
            this.cmbFormato.Location = new System.Drawing.Point(499, 64);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(81, 21);
            this.cmbFormato.TabIndex = 122;
            // 
            // chkFirma
            // 
            this.chkFirma.AutoSize = true;
            this.chkFirma.ForeColor = System.Drawing.Color.White;
            this.chkFirma.Location = new System.Drawing.Point(991, 26);
            this.chkFirma.Name = "chkFirma";
            this.chkFirma.Size = new System.Drawing.Size(85, 17);
            this.chkFirma.TabIndex = 101;
            this.chkFirma.Text = "Incluye firma";
            this.chkFirma.UseVisualStyleBackColor = true;
            this.chkFirma.CheckedChanged += new System.EventHandler(this.chkFirma_CheckedChanged);
            // 
            // chkNotas
            // 
            this.chkNotas.AutoSize = true;
            this.chkNotas.Checked = true;
            this.chkNotas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotas.ForeColor = System.Drawing.Color.White;
            this.chkNotas.Location = new System.Drawing.Point(851, 49);
            this.chkNotas.Name = "chkNotas";
            this.chkNotas.Size = new System.Drawing.Size(89, 17);
            this.chkNotas.TabIndex = 103;
            this.chkNotas.Text = "Incluye notas";
            this.chkNotas.UseVisualStyleBackColor = true;
            // 
            // chkAtencion
            // 
            this.chkAtencion.AutoSize = true;
            this.chkAtencion.Checked = true;
            this.chkAtencion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtencion.ForeColor = System.Drawing.Color.White;
            this.chkAtencion.Location = new System.Drawing.Point(605, 7);
            this.chkAtencion.Name = "chkAtencion";
            this.chkAtencion.Size = new System.Drawing.Size(104, 17);
            this.chkAtencion.TabIndex = 121;
            this.chkAtencion.Text = "Incluye atención";
            this.chkAtencion.UseVisualStyleBackColor = true;
            // 
            // chkCarac
            // 
            this.chkCarac.AutoSize = true;
            this.chkCarac.ForeColor = System.Drawing.Color.White;
            this.chkCarac.Location = new System.Drawing.Point(715, 7);
            this.chkCarac.Name = "chkCarac";
            this.chkCarac.Size = new System.Drawing.Size(123, 17);
            this.chkCarac.TabIndex = 112;
            this.chkCarac.Text = "Salto características";
            this.chkCarac.UseVisualStyleBackColor = true;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(1191, 3);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 6;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // chkFormaPago
            // 
            this.chkFormaPago.AutoSize = true;
            this.chkFormaPago.Checked = true;
            this.chkFormaPago.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFormaPago.ForeColor = System.Drawing.Color.White;
            this.chkFormaPago.Location = new System.Drawing.Point(427, 40);
            this.chkFormaPago.Name = "chkFormaPago";
            this.chkFormaPago.Size = new System.Drawing.Size(149, 17);
            this.chkFormaPago.TabIndex = 120;
            this.chkFormaPago.Text = "Salto después forma pago";
            this.chkFormaPago.UseVisualStyleBackColor = true;
            // 
            // chkLetras
            // 
            this.chkLetras.AutoSize = true;
            this.chkLetras.Checked = true;
            this.chkLetras.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLetras.ForeColor = System.Drawing.Color.White;
            this.chkLetras.Location = new System.Drawing.Point(1171, 72);
            this.chkLetras.Name = "chkLetras";
            this.chkLetras.Size = new System.Drawing.Size(82, 17);
            this.chkLetras.TabIndex = 119;
            this.chkLetras.Text = "Letras pago";
            this.chkLetras.UseVisualStyleBackColor = true;
            // 
            // chkSalIns
            // 
            this.chkSalIns.AutoSize = true;
            this.chkSalIns.ForeColor = System.Drawing.Color.White;
            this.chkSalIns.Location = new System.Drawing.Point(992, 2);
            this.chkSalIns.Name = "chkSalIns";
            this.chkSalIns.Size = new System.Drawing.Size(178, 17);
            this.chkSalIns.TabIndex = 118;
            this.chkSalIns.Text = "Incluye salto antes instalaciones";
            this.chkSalIns.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(987, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 115;
            this.label7.Text = "Espacio antes de notas:";
            // 
            // nudRenglon
            // 
            this.nudRenglon.Location = new System.Drawing.Point(1124, 48);
            this.nudRenglon.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRenglon.Name = "nudRenglon";
            this.nudRenglon.Size = new System.Drawing.Size(31, 20);
            this.nudRenglon.TabIndex = 114;
            // 
            // chkSaltoNota
            // 
            this.chkSaltoNota.AutoSize = true;
            this.chkSaltoNota.ForeColor = System.Drawing.Color.White;
            this.chkSaltoNota.Location = new System.Drawing.Point(851, 70);
            this.chkSaltoNota.Name = "chkSaltoNota";
            this.chkSaltoNota.Size = new System.Drawing.Size(102, 17);
            this.chkSaltoNota.TabIndex = 113;
            this.chkSaltoNota.Text = "Salto hoja notas";
            this.chkSaltoNota.UseVisualStyleBackColor = true;
            // 
            // chkInstalaCala
            // 
            this.chkInstalaCala.AutoSize = true;
            this.chkInstalaCala.ForeColor = System.Drawing.Color.White;
            this.chkInstalaCala.Location = new System.Drawing.Point(851, 26);
            this.chkInstalaCala.Name = "chkInstalaCala";
            this.chkInstalaCala.Size = new System.Drawing.Size(141, 17);
            this.chkInstalaCala.TabIndex = 111;
            this.chkInstalaCala.Text = "Incluye instalación calas";
            this.chkInstalaCala.UseVisualStyleBackColor = true;
            this.chkInstalaCala.CheckedChanged += new System.EventHandler(this.chkInstalaCala_CheckedChanged);
            // 
            // chkSoldadura
            // 
            this.chkSoldadura.AutoSize = true;
            this.chkSoldadura.ForeColor = System.Drawing.Color.White;
            this.chkSoldadura.Location = new System.Drawing.Point(992, 70);
            this.chkSoldadura.Name = "chkSoldadura";
            this.chkSoldadura.Size = new System.Drawing.Size(147, 17);
            this.chkSoldadura.TabIndex = 110;
            this.chkSoldadura.Text = "Incluye sistema soldadura";
            this.chkSoldadura.UseVisualStyleBackColor = true;
            // 
            // chkTotales
            // 
            this.chkTotales.AutoSize = true;
            this.chkTotales.Checked = true;
            this.chkTotales.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTotales.ForeColor = System.Drawing.Color.White;
            this.chkTotales.Location = new System.Drawing.Point(715, 70);
            this.chkTotales.Name = "chkTotales";
            this.chkTotales.Size = new System.Drawing.Size(96, 17);
            this.chkTotales.TabIndex = 109;
            this.chkTotales.Text = "Imprime totales";
            this.chkTotales.UseVisualStyleBackColor = true;
            // 
            // chkSaltoi
            // 
            this.chkSaltoi.AutoSize = true;
            this.chkSaltoi.ForeColor = System.Drawing.Color.White;
            this.chkSaltoi.Location = new System.Drawing.Point(715, 49);
            this.chkSaltoi.Name = "chkSaltoi";
            this.chkSaltoi.Size = new System.Drawing.Size(136, 17);
            this.chkSaltoi.TabIndex = 108;
            this.chkSaltoi.Text = "Incluye salto intensidad";
            this.chkSaltoi.UseVisualStyleBackColor = true;
            // 
            // chkSalto
            // 
            this.chkSalto.AutoSize = true;
            this.chkSalto.ForeColor = System.Drawing.Color.White;
            this.chkSalto.Location = new System.Drawing.Point(605, 26);
            this.chkSalto.Name = "chkSalto";
            this.chkSalto.Size = new System.Drawing.Size(85, 17);
            this.chkSalto.TabIndex = 107;
            this.chkSalto.Text = "Incluye salto";
            this.chkSalto.UseVisualStyleBackColor = true;
            // 
            // grBFirmas
            // 
            this.grBFirmas.Controls.Add(this.radioButton2);
            this.grBFirmas.Controls.Add(this.radioButton1);
            this.grBFirmas.Location = new System.Drawing.Point(1078, 19);
            this.grBFirmas.Name = "grBFirmas";
            this.grBFirmas.Size = new System.Drawing.Size(95, 24);
            this.grBFirmas.TabIndex = 106;
            this.grBFirmas.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(48, 7);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "AW";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(3, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "MF";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // chkIntensidas
            // 
            this.chkIntensidas.AutoSize = true;
            this.chkIntensidas.ForeColor = System.Drawing.Color.White;
            this.chkIntensidas.Location = new System.Drawing.Point(715, 26);
            this.chkIntensidas.Name = "chkIntensidas";
            this.chkIntensidas.Size = new System.Drawing.Size(111, 17);
            this.chkIntensidas.TabIndex = 104;
            this.chkIntensidas.Text = "Incluye intensidad";
            this.chkIntensidas.UseVisualStyleBackColor = true;
            // 
            // chkInstalacion
            // 
            this.chkInstalacion.AutoSize = true;
            this.chkInstalacion.Checked = true;
            this.chkInstalacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInstalacion.ForeColor = System.Drawing.Color.White;
            this.chkInstalacion.Location = new System.Drawing.Point(851, 2);
            this.chkInstalacion.Name = "chkInstalacion";
            this.chkInstalacion.Size = new System.Drawing.Size(124, 17);
            this.chkInstalacion.TabIndex = 102;
            this.chkInstalacion.Text = "Incluye instalaciones";
            this.chkInstalacion.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(453, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 99;
            this.label6.Text = "Usuario:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Visible = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(342, 10);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(81, 20);
            this.dtpFecha.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(303, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Fecha:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpAprobado
            // 
            this.dtpAprobado.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpAprobado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAprobado.Location = new System.Drawing.Point(499, 10);
            this.dtpAprobado.Name = "dtpAprobado";
            this.dtpAprobado.Size = new System.Drawing.Size(81, 20);
            this.dtpAprobado.TabIndex = 93;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(424, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 13);
            this.label24.TabIndex = 92;
            this.label24.Text = "F. aprobación:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(172, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 90;
            this.label16.Text = "Presupuesto:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.Location = new System.Drawing.Point(240, 10);
            this.txtPresupuesto.MaxLength = 8;
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(56, 20);
            this.txtPresupuesto.TabIndex = 91;
            this.txtPresupuesto.Text = "textBox16";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(199, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 88;
            this.label15.Text = "IdObra:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIdObra
            // 
            this.txtIdObra.Location = new System.Drawing.Point(240, 38);
            this.txtIdObra.MaxLength = 6;
            this.txtIdObra.Name = "txtIdObra";
            this.txtIdObra.Size = new System.Drawing.Size(56, 20);
            this.txtIdObra.TabIndex = 89;
            this.txtIdObra.Text = "textBox15";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(185, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Dirección:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(240, 64);
            this.txtUbicacion.MaxLength = 50;
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(180, 20);
            this.txtUbicacion.TabIndex = 86;
            this.txtUbicacion.Text = "textBox2";
            // 
            // cmbZona
            // 
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Items.AddRange(new object[] {
            "Local",
            "Foranea"});
            this.cmbZona.Location = new System.Drawing.Point(342, 38);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(78, 21);
            this.cmbZona.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(308, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Zona:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Año:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(50, 65);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(56, 20);
            this.txtAño.TabIndex = 83;
            this.txtAño.Text = "textBox2";
            // 
            // lblIdBascula
            // 
            this.lblIdBascula.AutoSize = true;
            this.lblIdBascula.ForeColor = System.Drawing.Color.White;
            this.lblIdBascula.Location = new System.Drawing.Point(1, 42);
            this.lblIdBascula.Name = "lblIdBascula";
            this.lblIdBascula.Size = new System.Drawing.Size(50, 13);
            this.lblIdBascula.TabIndex = 80;
            this.lblIdBascula.Text = "Solicitud:";
            this.lblIdBascula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSolicitud
            // 
            this.txtSolicitud.Location = new System.Drawing.Point(50, 38);
            this.txtSolicitud.Name = "txtSolicitud";
            this.txtSolicitud.Size = new System.Drawing.Size(56, 20);
            this.txtSolicitud.TabIndex = 81;
            this.txtSolicitud.Text = "textBox1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presupuestos";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Highlight;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(326, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 98;
            this.label17.Text = "Versión:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbVersion
            // 
            this.cmbVersion.DataSource = this.dsSolicitudVer1;
            this.cmbVersion.DisplayMember = "CatServicios.Version";
            this.cmbVersion.FormattingEnabled = true;
            this.cmbVersion.Location = new System.Drawing.Point(373, 64);
            this.cmbVersion.Name = "cmbVersion";
            this.cmbVersion.Size = new System.Drawing.Size(41, 21);
            this.cmbVersion.TabIndex = 97;
            this.cmbVersion.ValueMember = "CatServicios.Version";
            // 
            // dsSolicitudVer1
            // 
            this.dsSolicitudVer1.DataSetName = "dsSolicitudVer";
            this.dsSolicitudVer1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtUsrMov
            // 
            this.txtUsrMov.Location = new System.Drawing.Point(499, 10);
            this.txtUsrMov.Name = "txtUsrMov";
            this.txtUsrMov.Size = new System.Drawing.Size(56, 20);
            this.txtUsrMov.TabIndex = 100;
            this.txtUsrMov.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.crvPresupuesto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1262, 572);
            this.panel3.TabIndex = 12;
            // 
            // crvPresupuesto
            // 
            this.crvPresupuesto.ActiveViewIndex = -1;
            this.crvPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPresupuesto.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPresupuesto.EnableRefresh = false;
            this.crvPresupuesto.Location = new System.Drawing.Point(0, 0);
            this.crvPresupuesto.Name = "crvPresupuesto";
            this.crvPresupuesto.ShowCloseButton = false;
            this.crvPresupuesto.ShowGroupTreeButton = false;
            this.crvPresupuesto.ShowLogo = false;
            this.crvPresupuesto.Size = new System.Drawing.Size(1262, 572);
            this.crvPresupuesto.TabIndex = 13;
            this.crvPresupuesto.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvPresupuesto.ToolPanelWidth = 167;
            this.crvPresupuesto.Load += new System.EventHandler(this.crvPresupuesto_Load);
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
            new System.Data.SqlClient.SqlParameter("@IdSolicitud", System.Data.SqlDbType.SmallInt, 2, "IdSolicitud"),
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 2, "Año")});
            // 
            // sqlDASolicitudSer
            // 
            this.sqlDASolicitudSer.SelectCommand = this.sqlCommand4;
            this.sqlDASolicitudSer.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SolicitudSer", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdSolicitud", "IdSolicitud"),
                        new System.Data.Common.DataColumnMapping("Año", "Año"),
                        new System.Data.Common.DataColumnMapping("Renglon", "Renglon"),
                        new System.Data.Common.DataColumnMapping("IdServicio", "IdServicio")})});
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = resources.GetString("sqlCommand4.CommandText");
            this.sqlCommand4.Connection = this.sqlConn;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdSolicitud", System.Data.SqlDbType.SmallInt, 2, "IdSolicitud"),
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 2, "Año")});
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
            this.sqlCommand6.CommandText = "SELECT     IdSolicitud, Año, Renglon, Caracteristica, Unidad, Cantidad, Ajustada\r" +
    "\nFROM         SolicitudCar\r\nWHERE     (IdSolicitud = @IdSolicitud) AND (Año = @A" +
    "ño)\r\nORDER BY Año, IdSolicitud";
            this.sqlCommand6.Connection = this.sqlConn;
            this.sqlCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdSolicitud", System.Data.SqlDbType.SmallInt, 2, "IdSolicitud"),
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 2, "Año")});
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
            // dsInfPresup1
            // 
            this.dsInfPresup1.DataSetName = "dsInfPresup";
            this.dsInfPresup1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAVersion
            // 
            this.sqlDAVersion.SelectCommand = this.sqlCommand14;
            this.sqlDAVersion.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CatServicios", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdServicio", "IdServicio"),
                        new System.Data.Common.DataColumnMapping("Descripción", "Descripción")})});
            // 
            // sqlCommand14
            // 
            this.sqlCommand14.CommandText = "SELECT DISTINCT IdSolicitud, Año, Version\r\nFROM         SolicitudPre\r\nWHERE     (" +
    "IdSolicitud = @IdSolicitud) AND (Año = @Año)\r\nORDER BY Version DESC";
            this.sqlCommand14.Connection = this.sqlConn;
            this.sqlCommand14.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdSolicitud", System.Data.SqlDbType.SmallInt, 2, "IdSolicitud"),
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 2, "Año")});
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
            new System.Data.SqlClient.SqlParameter("@Version", System.Data.SqlDbType.SmallInt, 2, "Version"),
            new System.Data.SqlClient.SqlParameter("@IdSolicitud", System.Data.SqlDbType.SmallInt, 2, "IdSolicitud"),
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 2, "Año")});
            // 
            // sqlDAIntensidad
            // 
            this.sqlDAIntensidad.SelectCommand = this.sqlCommand2;
            this.sqlDAIntensidad.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
            this.sqlCommand2.CommandText = "SELECT     IdIntensidad, Inferiores, Adicionales, Acero, AceroRem, Prefabircados," +
    " revenimiento, Croquis, Laboratorio, Calas, Mortero\r\nFROM         Intensidad\r\nWH" +
    "ERE     (IdIntensidad = @Intensidad)";
            this.sqlCommand2.Connection = this.sqlConn;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Intensidad", System.Data.SqlDbType.NVarChar, 10, "IdIntensidad")});
            // 
            // sqlComAgrega
            // 
            this.sqlComAgrega.CommandText = "AgregaSolicitudBit";
            this.sqlComAgrega.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComAgrega.Connection = this.sqlConn;
            this.sqlComAgrega.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 10),
            new System.Data.SqlClient.SqlParameter("@IdSolicitud", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Version", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlDASolicitudPre2
            // 
            this.sqlDASolicitudPre2.SelectCommand = this.sqlCommand3;
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
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = resources.GetString("sqlCommand3.CommandText");
            this.sqlCommand3.Connection = this.sqlConn;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Version", System.Data.SqlDbType.SmallInt, 2, "Version"),
            new System.Data.SqlClient.SqlParameter("@IdSolicitud", System.Data.SqlDbType.SmallInt, 2, "IdSolicitud"),
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 2, "Año")});
            // 
            // InfPresup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 665);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "InfPresup";
            this.Text = "InfPresupuesto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfPresupuesto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusSol1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenglon)).EndInit();
            this.grBFirmas.ResumeLayout(false);
            this.grBFirmas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSolicitudVer1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsInfPresup1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConn;
        private System.Data.SqlClient.SqlDataAdapter sqlDABusSol;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private dsBusSol dsBusSol1;
        private System.Windows.Forms.Panel panel1;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAprobado;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPresupuesto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIdObra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label lblIdBascula;
        private System.Windows.Forms.TextBox txtSolicitud;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPresupuesto;
        private System.Data.SqlClient.SqlDataAdapter sqlDASolicitud;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDASolicitudSer;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Data.SqlClient.SqlDataAdapter sqlDASolicitudCar;
        private System.Data.SqlClient.SqlCommand sqlCommand6;
        private System.Data.SqlClient.SqlDataAdapter sqlDASolicitudPre;
        private System.Data.SqlClient.SqlCommand sqlCommand10;
        private dsInfPresup dsInfPresup1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAVersion;
        private System.Data.SqlClient.SqlCommand sqlCommand14;
        private dsSolicitudVer dsSolicitudVer1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbVersion;
        private CryInfPresup cryInfPresup1;
        private System.Data.SqlClient.SqlDataAdapter sqlDASolicitudPre1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAIntensidad;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.TextBox txtUsrMov;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkFirma;
        private System.Data.SqlClient.SqlCommand sqlComAgrega;
        private System.Windows.Forms.CheckBox chkNotas;
        private System.Windows.Forms.CheckBox chkInstalacion;
        private System.Windows.Forms.CheckBox chkIntensidas;
        private System.Windows.Forms.GroupBox grBFirmas;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox chkSalto;
        private System.Windows.Forms.CheckBox chkTotales;
        private System.Windows.Forms.CheckBox chkSaltoi;
        private System.Windows.Forms.CheckBox chkSoldadura;
        private System.Windows.Forms.CheckBox chkInstalaCala;
        private System.Data.SqlClient.SqlDataAdapter sqlDASolicitudPre2;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Windows.Forms.CheckBox chkCarac;
        private System.Windows.Forms.CheckBox chkSaltoNota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudRenglon;
        private System.Windows.Forms.CheckBox chkSalIns;
        private System.Windows.Forms.CheckBox chkLetras;
        private System.Windows.Forms.CheckBox chkFormaPago;
        private System.Windows.Forms.CheckBox chkAtencion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbFormato;
    }
}