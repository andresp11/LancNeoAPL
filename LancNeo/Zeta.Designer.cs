namespace LancNeo
{
    partial class Zeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zeta));
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsDGObra1 = new LancNeo.dsDGObra();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.tbBtn1 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.chkPU = new System.Windows.Forms.CheckBox();
            this.chkSemanas = new System.Windows.Forms.CheckBox();
            this.lblProceso = new System.Windows.Forms.Label();
            this.txtAf = new System.Windows.Forms.TextBox();
            this.txtAi = new System.Windows.Forms.TextBox();
            this.nUDSf = new System.Windows.Forms.NumericUpDown();
            this.nUDSi = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDurSem = new System.Windows.Forms.ComboBox();
            this.txtBimSeg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBimIni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbkTotal = new System.Windows.Forms.CheckBox();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdobra = new System.Windows.Forms.TextBox();
            this.sqlDADuracion = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAZeta = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.dsZeta1 = new LancNeo.dsZeta();
            this.sqlDAPresupuestoz = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAConcepto = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAFechas = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dsPrevioZ1 = new LancNeo.dsPrevioZ();
            this.cryZeta1 = new LancNeo.CryZeta();
            this.sqlComAgrega = new System.Data.SqlClient.SqlCommand();
            this.sqlComPrevioZ = new System.Data.SqlClient.SqlCommand();
            this.sqlDASECIERRA = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.crvResumen = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dGVPresupuesto = new System.Windows.Forms.DataGridView();
            this.idSolicitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presupuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecAprobadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecAdmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procesar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dsZetaSolicitud1 = new LancNeo.dsZetaSolicitud();
            this.dGVObras = new System.Windows.Forms.DataGridView();
            this.idobraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.morteroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.procesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dsZetaObras1 = new LancNeo.dsZetaObras();
            this.sqlDAObras = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlDASolicitud = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand8 = new System.Data.SqlClient.SqlCommand();
            this.sqlCInsZetaTemp = new System.Data.SqlClient.SqlCommand();
            this.sqlCInsZetaSolicitud = new System.Data.SqlClient.SqlCommand();
            this.sqlDAZetaSi = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAZetaSf = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand7 = new System.Data.SqlClient.SqlCommand();
            this.dsZetaSemanas1 = new LancNeo.dsZetaSemanas();
            this.sqlCDelTemp1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCDelTemp2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAVivienda = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand9 = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dsDGObra1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZeta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrevioZ1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZetaSolicitud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVObras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZetaObras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZetaSemanas1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsDGObra1
            // 
            this.dsDGObra1.DataSetName = "dsDGObra";
            this.dsDGObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDGObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbBtn1);
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.chkPU);
            this.panel1.Controls.Add(this.chkSemanas);
            this.panel1.Controls.Add(this.lblProceso);
            this.panel1.Controls.Add(this.txtAf);
            this.panel1.Controls.Add(this.txtAi);
            this.panel1.Controls.Add(this.nUDSf);
            this.panel1.Controls.Add(this.nUDSi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbDurSem);
            this.panel1.Controls.Add(this.txtBimSeg);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtBimIni);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblDuracion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbkTotal);
            this.panel1.Controls.Add(this.cmbIdObra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdobra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 77);
            this.panel1.TabIndex = 13;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(923, 4);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 45;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // tbBtn1
            // 
            this.tbBtn1.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn1.Icon")));
            this.tbBtn1.Location = new System.Drawing.Point(829, 2);
            this.tbBtn1.Name = "tbBtn1";
            this.tbBtn1.Size = new System.Drawing.Size(64, 64);
            this.tbBtn1.TabIndex = 59;
            this.tbBtn1.Click += new System.EventHandler(this.tbBtn1_Click);
            // 
            // chkPU
            // 
            this.chkPU.AutoSize = true;
            this.chkPU.Checked = true;
            this.chkPU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPU.ForeColor = System.Drawing.Color.Lime;
            this.chkPU.Location = new System.Drawing.Point(175, 53);
            this.chkPU.Name = "chkPU";
            this.chkPU.Size = new System.Drawing.Size(103, 17);
            this.chkPU.TabIndex = 75;
            this.chkPU.Text = "Precios unitarios";
            this.chkPU.UseVisualStyleBackColor = true;
            // 
            // chkSemanas
            // 
            this.chkSemanas.AutoSize = true;
            this.chkSemanas.ForeColor = System.Drawing.Color.Lime;
            this.chkSemanas.Location = new System.Drawing.Point(174, 28);
            this.chkSemanas.Name = "chkSemanas";
            this.chkSemanas.Size = new System.Drawing.Size(114, 17);
            this.chkSemanas.TabIndex = 74;
            this.chkSemanas.Text = "Actualiza semanas";
            this.chkSemanas.UseVisualStyleBackColor = true;
            this.chkSemanas.CheckedChanged += new System.EventHandler(this.chkSemanas_CheckedChanged);
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.ForeColor = System.Drawing.Color.Lime;
            this.lblProceso.Location = new System.Drawing.Point(171, 7);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(46, 13);
            this.lblProceso.TabIndex = 73;
            this.lblProceso.Text = "Proceso";
            this.lblProceso.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtAf
            // 
            this.txtAf.Location = new System.Drawing.Point(757, 49);
            this.txtAf.Name = "txtAf";
            this.txtAf.Size = new System.Drawing.Size(45, 20);
            this.txtAf.TabIndex = 72;
            // 
            // txtAi
            // 
            this.txtAi.Location = new System.Drawing.Point(757, 26);
            this.txtAi.Name = "txtAi";
            this.txtAi.Size = new System.Drawing.Size(45, 20);
            this.txtAi.TabIndex = 71;
            // 
            // nUDSf
            // 
            this.nUDSf.Location = new System.Drawing.Point(631, 49);
            this.nUDSf.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.nUDSf.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDSf.Name = "nUDSf";
            this.nUDSf.Size = new System.Drawing.Size(40, 20);
            this.nUDSf.TabIndex = 70;
            this.nUDSf.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUDSi
            // 
            this.nUDSi.Location = new System.Drawing.Point(631, 26);
            this.nUDSi.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.nUDSi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDSi.Name = "nUDSi";
            this.nUDSi.Size = new System.Drawing.Size(40, 20);
            this.nUDSi.TabIndex = 69;
            this.nUDSi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(693, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Año final:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(693, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "Año inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(554, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Semana final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(554, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Semana inicial:";
            // 
            // cmbDurSem
            // 
            this.cmbDurSem.FormattingEnabled = true;
            this.cmbDurSem.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "5",
            "6",
            "8",
            "9",
            "13"});
            this.cmbDurSem.Location = new System.Drawing.Point(492, 4);
            this.cmbDurSem.Name = "cmbDurSem";
            this.cmbDurSem.Size = new System.Drawing.Size(52, 21);
            this.cmbDurSem.TabIndex = 64;
            this.cmbDurSem.Text = "1";
            this.cmbDurSem.SelectedIndexChanged += new System.EventHandler(this.cmbDurSem_SelectedIndexChanged);
            // 
            // txtBimSeg
            // 
            this.txtBimSeg.Location = new System.Drawing.Point(519, 49);
            this.txtBimSeg.MaxLength = 3;
            this.txtBimSeg.Name = "txtBimSeg";
            this.txtBimSeg.Size = new System.Drawing.Size(25, 20);
            this.txtBimSeg.TabIndex = 63;
            this.txtBimSeg.Text = "0";
            this.txtBimSeg.Validating += new System.ComponentModel.CancelEventHandler(this.txtBimSeg_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(294, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "La segunda columna incluye hasta la semana:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(375, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Semanas por columna:";
            // 
            // txtBimIni
            // 
            this.txtBimIni.Location = new System.Drawing.Point(519, 26);
            this.txtBimIni.MaxLength = 3;
            this.txtBimIni.Name = "txtBimIni";
            this.txtBimIni.Size = new System.Drawing.Size(25, 20);
            this.txtBimIni.TabIndex = 57;
            this.txtBimIni.Text = "0";
            this.txtBimIni.Validating += new System.ComponentModel.CancelEventHandler(this.txtBimIni_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(293, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "La primera columna incluye hasta la semana:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDuracion.Location = new System.Drawing.Point(777, 8);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(14, 13);
            this.lblDuracion.TabIndex = 55;
            this.lblDuracion.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(551, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "La duración en semanas de esta obra es de: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Obra:";
            // 
            // cbkTotal
            // 
            this.cbkTotal.Checked = true;
            this.cbkTotal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkTotal.ForeColor = System.Drawing.Color.White;
            this.cbkTotal.Location = new System.Drawing.Point(21, 49);
            this.cbkTotal.Name = "cbkTotal";
            this.cbkTotal.Size = new System.Drawing.Size(148, 24);
            this.cbkTotal.TabIndex = 46;
            this.cbkTotal.Text = "Incluye total de muestas";
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsDGObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(39, 24);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 1;
            this.cmbIdObra.ValueMember = "IdObra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zeta neo II";
            // 
            // txtIdobra
            // 
            this.txtIdobra.Location = new System.Drawing.Point(922, 22);
            this.txtIdobra.Name = "txtIdobra";
            this.txtIdobra.ReadOnly = true;
            this.txtIdobra.Size = new System.Drawing.Size(48, 20);
            this.txtIdobra.TabIndex = 2;
            this.txtIdobra.Visible = false;
            // 
            // sqlDADuracion
            // 
            this.sqlDADuracion.SelectCommand = this.sqlCommand2;
            this.sqlDADuracion.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "SELECT     MIN(Fecha) AS Fini, MAX(Fecha) AS Ffin\r\nFROM         Concentra\r\nWHERE " +
    "    (IdObra = @IdObra)";
            this.sqlCommand2.Connection = this.sqlConn;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NChar, 6, "IdObra")});
            // 
            // sqlDAZeta
            // 
            this.sqlDAZeta.SelectCommand = this.sqlCommand3;
            this.sqlDAZeta.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "SELECT        IdObra, IdConcepto, Fecha, SemCons, Cantidad, PreUni\r\nFROM         " +
    "   PrevioZ\r\nWHERE        (IdObra = @IdObra)\r\nORDER BY IdObra, IdConcepto, SemCon" +
    "s";
            this.sqlCommand3.CommandTimeout = 120;
            this.sqlCommand3.Connection = this.sqlConn;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // dsZeta1
            // 
            this.dsZeta1.DataSetName = "dsZeta";
            this.dsZeta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAPresupuestoz
            // 
            this.sqlDAPresupuestoz.SelectCommand = this.sqlSelectCommand4;
            this.sqlDAPresupuestoz.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
            // sqlDAConcepto
            // 
            this.sqlDAConcepto.SelectCommand = this.sqlSelectCommand3;
            this.sqlDAConcepto.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Concepto", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcepto", "IdConcepto"),
                        new System.Data.Common.DataColumnMapping("Concepto", "Concepto")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT     IdConcepto, Concepto\r\nFROM         Concepto\r\nWHERE     (IdConcepto > 0" +
    ")\r\nORDER BY IdConcepto";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            // 
            // sqlDAFechas
            // 
            this.sqlDAFechas.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAFechas.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Fechas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Fi1", "Fi1"),
                        new System.Data.Common.DataColumnMapping("Ff1", "Ff1"),
                        new System.Data.Common.DataColumnMapping("Fi2", "Fi2"),
                        new System.Data.Common.DataColumnMapping("Ff2", "Ff2"),
                        new System.Data.Common.DataColumnMapping("Fi3", "Fi3"),
                        new System.Data.Common.DataColumnMapping("Ff3", "Ff3"),
                        new System.Data.Common.DataColumnMapping("Fi4", "Fi4"),
                        new System.Data.Common.DataColumnMapping("Ff4", "Ff4")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "[Fechas]";
            this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand2.Connection = this.sqlConn;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FfMax", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@FfMin", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@Mortero", System.Data.SqlDbType.Bit, 1)});
            // 
            // dsPrevioZ1
            // 
            this.dsPrevioZ1.DataSetName = "dsPrevioZ";
            this.dsPrevioZ1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sqlComPrevioZ
            // 
            this.sqlComPrevioZ.CommandText = "insPrevioZ";
            this.sqlComPrevioZ.CommandTimeout = 2400;
            this.sqlComPrevioZ.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComPrevioZ.Connection = this.sqlConn;
            this.sqlComPrevioZ.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@Mortero", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdUser", System.Data.SqlDbType.VarChar, 10),
            new System.Data.SqlClient.SqlParameter("@IdObraM", System.Data.SqlDbType.NVarChar, 6)});
            // 
            // sqlDASECIERRA
            // 
            this.sqlDASECIERRA.SelectCommand = this.sqlCommand4;
            this.sqlDASECIERRA.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("PresupuestoZ", "PresupuestoZ"),
                        new System.Data.Common.DataColumnMapping("Duracion", "Duracion")})});
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = resources.GetString("sqlCommand4.CommandText");
            this.sqlCommand4.Connection = this.sqlConn;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.crvResumen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 485);
            this.panel2.TabIndex = 15;
            // 
            // crvResumen
            // 
            this.crvResumen.ActiveViewIndex = -1;
            this.crvResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvResumen.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvResumen.EnableRefresh = false;
            this.crvResumen.Location = new System.Drawing.Point(0, 0);
            this.crvResumen.Name = "crvResumen";
            this.crvResumen.ShowCloseButton = false;
            this.crvResumen.ShowGroupTreeButton = false;
            this.crvResumen.ShowLogo = false;
            this.crvResumen.Size = new System.Drawing.Size(1062, 485);
            this.crvResumen.TabIndex = 15;
            this.crvResumen.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.dGVPresupuesto);
            this.panel3.Controls.Add(this.dGVObras);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1062, 39);
            this.panel3.TabIndex = 16;
            // 
            // dGVPresupuesto
            // 
            this.dGVPresupuesto.AllowUserToAddRows = false;
            this.dGVPresupuesto.AllowUserToDeleteRows = false;
            this.dGVPresupuesto.AutoGenerateColumns = false;
            this.dGVPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPresupuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSolicitudDataGridViewTextBoxColumn,
            this.añoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.unidadDataGridViewTextBoxColumn,
            this.presupuestoDataGridViewTextBoxColumn,
            this.fecAprobadoDataGridViewTextBoxColumn,
            this.fecAdmDataGridViewTextBoxColumn,
            this.Procesar});
            this.dGVPresupuesto.DataMember = "Solicitud";
            this.dGVPresupuesto.DataSource = this.dsZetaSolicitud1;
            this.dGVPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVPresupuesto.Location = new System.Drawing.Point(215, 0);
            this.dGVPresupuesto.Name = "dGVPresupuesto";
            this.dGVPresupuesto.Size = new System.Drawing.Size(847, 39);
            this.dGVPresupuesto.TabIndex = 1;
            // 
            // idSolicitudDataGridViewTextBoxColumn
            // 
            this.idSolicitudDataGridViewTextBoxColumn.DataPropertyName = "IdSolicitud";
            this.idSolicitudDataGridViewTextBoxColumn.HeaderText = "IdSolicitud";
            this.idSolicitudDataGridViewTextBoxColumn.Name = "idSolicitudDataGridViewTextBoxColumn";
            this.idSolicitudDataGridViewTextBoxColumn.Width = 65;
            // 
            // añoDataGridViewTextBoxColumn
            // 
            this.añoDataGridViewTextBoxColumn.DataPropertyName = "Año";
            this.añoDataGridViewTextBoxColumn.HeaderText = "Año";
            this.añoDataGridViewTextBoxColumn.Name = "añoDataGridViewTextBoxColumn";
            this.añoDataGridViewTextBoxColumn.Width = 45;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 60;
            // 
            // unidadDataGridViewTextBoxColumn
            // 
            this.unidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad";
            this.unidadDataGridViewTextBoxColumn.HeaderText = "Unidad";
            this.unidadDataGridViewTextBoxColumn.Name = "unidadDataGridViewTextBoxColumn";
            this.unidadDataGridViewTextBoxColumn.Width = 60;
            // 
            // presupuestoDataGridViewTextBoxColumn
            // 
            this.presupuestoDataGridViewTextBoxColumn.DataPropertyName = "Presupuesto";
            this.presupuestoDataGridViewTextBoxColumn.HeaderText = "Presupuesto";
            this.presupuestoDataGridViewTextBoxColumn.Name = "presupuestoDataGridViewTextBoxColumn";
            this.presupuestoDataGridViewTextBoxColumn.Width = 75;
            // 
            // fecAprobadoDataGridViewTextBoxColumn
            // 
            this.fecAprobadoDataGridViewTextBoxColumn.DataPropertyName = "FecAprobado";
            this.fecAprobadoDataGridViewTextBoxColumn.HeaderText = "FecAprobado";
            this.fecAprobadoDataGridViewTextBoxColumn.Name = "fecAprobadoDataGridViewTextBoxColumn";
            this.fecAprobadoDataGridViewTextBoxColumn.Width = 75;
            // 
            // fecAdmDataGridViewTextBoxColumn
            // 
            this.fecAdmDataGridViewTextBoxColumn.DataPropertyName = "FecAdm";
            this.fecAdmDataGridViewTextBoxColumn.HeaderText = "FecAdm";
            this.fecAdmDataGridViewTextBoxColumn.Name = "fecAdmDataGridViewTextBoxColumn";
            this.fecAdmDataGridViewTextBoxColumn.Width = 75;
            // 
            // Procesar
            // 
            this.Procesar.HeaderText = "Procesa";
            this.Procesar.Name = "Procesar";
            // 
            // dsZetaSolicitud1
            // 
            this.dsZetaSolicitud1.DataSetName = "dsZetaSolicitud";
            this.dsZetaSolicitud1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dGVObras
            // 
            this.dGVObras.AllowUserToAddRows = false;
            this.dGVObras.AllowUserToDeleteRows = false;
            this.dGVObras.AutoGenerateColumns = false;
            this.dGVObras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVObras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idobraDataGridViewTextBoxColumn,
            this.morteroDataGridViewTextBoxColumn,
            this.procesoDataGridViewTextBoxColumn});
            this.dGVObras.DataMember = "Obra";
            this.dGVObras.DataSource = this.dsZetaObras1;
            this.dGVObras.Dock = System.Windows.Forms.DockStyle.Left;
            this.dGVObras.Location = new System.Drawing.Point(0, 0);
            this.dGVObras.Name = "dGVObras";
            this.dGVObras.Size = new System.Drawing.Size(215, 39);
            this.dGVObras.TabIndex = 0;
            // 
            // idobraDataGridViewTextBoxColumn
            // 
            this.idobraDataGridViewTextBoxColumn.DataPropertyName = "Idobra";
            this.idobraDataGridViewTextBoxColumn.HeaderText = "Idobra";
            this.idobraDataGridViewTextBoxColumn.Name = "idobraDataGridViewTextBoxColumn";
            this.idobraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idobraDataGridViewTextBoxColumn.Width = 55;
            // 
            // morteroDataGridViewTextBoxColumn
            // 
            this.morteroDataGridViewTextBoxColumn.DataPropertyName = "Mortero";
            this.morteroDataGridViewTextBoxColumn.HeaderText = "Mortero";
            this.morteroDataGridViewTextBoxColumn.Name = "morteroDataGridViewTextBoxColumn";
            this.morteroDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.morteroDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.morteroDataGridViewTextBoxColumn.Width = 45;
            // 
            // procesoDataGridViewTextBoxColumn
            // 
            this.procesoDataGridViewTextBoxColumn.DataPropertyName = "Proceso";
            this.procesoDataGridViewTextBoxColumn.HeaderText = "Proceso";
            this.procesoDataGridViewTextBoxColumn.Name = "procesoDataGridViewTextBoxColumn";
            this.procesoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.procesoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.procesoDataGridViewTextBoxColumn.Width = 48;
            // 
            // dsZetaObras1
            // 
            this.dsZetaObras1.DataSetName = "dsZetaObras";
            this.dsZetaObras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAObras
            // 
            this.sqlDAObras.DeleteCommand = this.sqlDeleteCommand;
            this.sqlDAObras.InsertCommand = this.sqlInsertCommand;
            this.sqlDAObras.SelectCommand = this.sqlCommand5;
            this.sqlDAObras.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Mortero", "Mortero"),
                        new System.Data.Common.DataColumnMapping("Proceso", "Proceso")})});
            this.sqlDAObras.UpdateCommand = this.sqlUpdateCommand;
            // 
            // sqlDeleteCommand
            // 
            this.sqlDeleteCommand.CommandText = "DELETE FROM [Obra] WHERE (([Idobra] = @Original_Idobra))";
            this.sqlDeleteCommand.Connection = this.sqlConn;
            this.sqlDeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Idobra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Idobra", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand
            // 
            this.sqlInsertCommand.CommandText = "INSERT INTO [Obra] ([Idobra]) VALUES (@Idobra);\r\nSELECT Idobra, 0 AS Mortero, 0 A" +
    "S Proceso FROM Obra WHERE (Idobra = @Idobra)";
            this.sqlInsertCommand.Connection = this.sqlConn;
            this.sqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Idobra", System.Data.SqlDbType.NVarChar, 0, "Idobra")});
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SELECT        Idobra, 0 AS Mortero, 0 AS Proceso\r\nFROM            Obra\r\nWHERE    " +
    "    (LEFT(Idobra, 3) = @IdObra)";
            this.sqlCommand5.Connection = this.sqlConn;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // sqlUpdateCommand
            // 
            this.sqlUpdateCommand.CommandText = "UPDATE [Obra] SET [Idobra] = @Idobra WHERE (([Idobra] = @Original_Idobra));\r\nSELE" +
    "CT Idobra, 0 AS Mortero, 0 AS Proceso FROM Obra WHERE (Idobra = @Idobra)";
            this.sqlUpdateCommand.Connection = this.sqlConn;
            this.sqlUpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Idobra", System.Data.SqlDbType.NVarChar, 0, "Idobra"),
            new System.Data.SqlClient.SqlParameter("@Original_Idobra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Idobra", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDASolicitud
            // 
            this.sqlDASolicitud.SelectCommand = this.sqlCommand8;
            this.sqlDASolicitud.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Solicitud", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdSolicitud", "IdSolicitud"),
                        new System.Data.Common.DataColumnMapping("Año", "Año"),
                        new System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("Presupuesto", "Presupuesto"),
                        new System.Data.Common.DataColumnMapping("FecAprobado", "FecAprobado"),
                        new System.Data.Common.DataColumnMapping("FecAdm", "FecAdm")})});
            // 
            // sqlCommand8
            // 
            this.sqlCommand8.CommandText = "SELECT        IdSolicitud, Año, Cantidad, Unidad, Presupuesto, FecAprobado, FecAd" +
    "m\r\nFROM            Solicitud\r\nWHERE        (IdObra = @IdObra)";
            this.sqlCommand8.Connection = this.sqlConn;
            this.sqlCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // sqlCInsZetaTemp
            // 
            this.sqlCInsZetaTemp.CommandText = "insZetaTemp";
            this.sqlCInsZetaTemp.CommandTimeout = 120;
            this.sqlCInsZetaTemp.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCInsZetaTemp.Connection = this.sqlConn;
            this.sqlCInsZetaTemp.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdUser", System.Data.SqlDbType.VarChar, 10),
            new System.Data.SqlClient.SqlParameter("@pri", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlCInsZetaSolicitud
            // 
            this.sqlCInsZetaSolicitud.CommandText = "insZetaTempSolicitud";
            this.sqlCInsZetaSolicitud.CommandTimeout = 120;
            this.sqlCInsZetaSolicitud.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCInsZetaSolicitud.Connection = this.sqlConn;
            this.sqlCInsZetaSolicitud.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdSolicitud", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@IdUser", System.Data.SqlDbType.VarChar, 10)});
            // 
            // sqlDAZetaSi
            // 
            this.sqlDAZetaSi.SelectCommand = this.sqlCommand6;
            this.sqlDAZetaSi.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PrevioZ", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("IdConcepto", "IdConcepto"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("SemCons", "SemCons"),
                        new System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"),
                        new System.Data.Common.DataColumnMapping("PreUni", "PreUni"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Ano", "Ano")})});
            // 
            // sqlCommand6
            // 
            this.sqlCommand6.CommandText = "SELECT        TOP (1) IdObra, IdConcepto, Fecha, SemCons, Cantidad, PreUni, Seman" +
    "a, Ano\r\nFROM            PrevioZ\r\nWHERE        (IdObra = @IdObra) AND (Ano <> 0) " +
    "AND (Semana <> 0)\r\nORDER BY Ano, Semana";
            this.sqlCommand6.CommandTimeout = 120;
            this.sqlCommand6.Connection = this.sqlConn;
            this.sqlCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // sqlDAZetaSf
            // 
            this.sqlDAZetaSf.SelectCommand = this.sqlCommand7;
            this.sqlDAZetaSf.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PrevioZ", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("IdConcepto", "IdConcepto"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("SemCons", "SemCons"),
                        new System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"),
                        new System.Data.Common.DataColumnMapping("PreUni", "PreUni"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Ano", "Ano")})});
            // 
            // sqlCommand7
            // 
            this.sqlCommand7.CommandText = resources.GetString("sqlCommand7.CommandText");
            this.sqlCommand7.CommandTimeout = 120;
            this.sqlCommand7.Connection = this.sqlConn;
            this.sqlCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // dsZetaSemanas1
            // 
            this.dsZetaSemanas1.DataSetName = "dsZetaSemanas";
            this.dsZetaSemanas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlCDelTemp1
            // 
            this.sqlCDelTemp1.CommandText = "DELETE FROM ZetaTemp\r\nWHERE        (IdUser = @IdUser);  ";
            this.sqlCDelTemp1.CommandTimeout = 120;
            this.sqlCDelTemp1.Connection = this.sqlConn;
            this.sqlCDelTemp1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdUser", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUser", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCDelTemp2
            // 
            this.sqlCDelTemp2.CommandText = "delete from ZetaTemSolicitud where IdUsuario =  @IdUser";
            this.sqlCDelTemp2.CommandTimeout = 120;
            this.sqlCDelTemp2.Connection = this.sqlConn;
            this.sqlCDelTemp2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdUser", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDAVivienda
            // 
            this.sqlDAVivienda.SelectCommand = this.sqlCommand9;
            this.sqlDAVivienda.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
            // sqlCommand9
            // 
            this.sqlCommand9.CommandText = "SELECT        TOP (1) IdObra, Año, Semana, Vivienda\r\nFROM            Vivienda\r\nWH" +
    "ERE        (IdObra = @IdObra)\r\nORDER BY IdObra, Año DESC, Semana DESC";
            this.sqlCommand9.Connection = this.sqlConn;
            this.sqlCommand9.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Current, "AGL/2")});
            // 
            // Zeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 601);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Zeta";
            this.Text = "Zeta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Zeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDGObra1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZeta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrevioZ1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZetaSolicitud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVObras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZetaObras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZetaSemanas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConn;
        private dsDGObra dsDGObra1;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Panel panel1;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private System.Windows.Forms.CheckBox cbkTotal;
        private System.Windows.Forms.ComboBox cmbIdObra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdobra;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        public System.Data.SqlClient.SqlDataAdapter sqlDADuracion;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.TextBox txtBimIni;
        private System.Windows.Forms.Label label8;
        public System.Data.SqlClient.SqlDataAdapter sqlDAZeta;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private dsZeta dsZeta1;
        public System.Data.SqlClient.SqlDataAdapter sqlDAPresupuestoz;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlDataAdapter sqlDAConcepto;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlDataAdapter sqlDAFechas;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private dsPrevioZ dsPrevioZ1;
        private CryZeta cryZeta1;
        protected Soluciones2000.Tools.WinLib.tbBtn tbBtn1;
        private System.Data.SqlClient.SqlCommand sqlComAgrega;
        private System.Data.SqlClient.SqlCommand sqlComPrevioZ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBimSeg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDurSem;
        public System.Data.SqlClient.SqlDataAdapter sqlDASECIERRA;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Windows.Forms.Panel panel2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvResumen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dGVObras;
        private dsZetaObras dsZetaObras1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAObras;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn idobraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn morteroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn procesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dGVPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSolicitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presupuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecAprobadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecAdmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Procesar;
        private dsZetaSolicitud dsZetaSolicitud1;
        private System.Data.SqlClient.SqlDataAdapter sqlDASolicitud;
        private System.Data.SqlClient.SqlCommand sqlCommand8;
        private System.Windows.Forms.TextBox txtAf;
        private System.Windows.Forms.TextBox txtAi;
        private System.Windows.Forms.NumericUpDown nUDSf;
        private System.Windows.Forms.NumericUpDown nUDSi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Data.SqlClient.SqlCommand sqlCInsZetaTemp;
        private System.Data.SqlClient.SqlCommand sqlCInsZetaSolicitud;
        private System.Windows.Forms.Label lblProceso;
        public System.Data.SqlClient.SqlDataAdapter sqlDAZetaSi;
        private System.Data.SqlClient.SqlCommand sqlCommand6;
        public System.Data.SqlClient.SqlDataAdapter sqlDAZetaSf;
        private System.Data.SqlClient.SqlCommand sqlCommand7;
        private dsZetaSemanas dsZetaSemanas1;
        private System.Windows.Forms.CheckBox chkSemanas;
        private System.Data.SqlClient.SqlCommand sqlCDelTemp1;
        private System.Data.SqlClient.SqlCommand sqlCDelTemp2;
        public System.Data.SqlClient.SqlDataAdapter sqlDAVivienda;
        private System.Data.SqlClient.SqlCommand sqlCommand9;
        private System.Windows.Forms.CheckBox chkPU;
        //        private CryZeta cryZeta1;
    }
}