namespace LancNeo
{
    partial class IncFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncFactura));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbBtn4 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.tbBtn1 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.tbBtn5 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.btSelAge = new System.Windows.Forms.Button();
            this.txtArcAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btSelObs = new System.Windows.Forms.Button();
            this.txtArcObs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btSelExc = new System.Windows.Forms.Button();
            this.txtFicheroPDFOrigen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dlAbrir = new System.Windows.Forms.OpenFileDialog();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlComInserta = new System.Data.SqlClient.SqlCommand();
            this.sqlComInsertaCob = new System.Data.SqlClient.SqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbBtn2 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.tbBtn3 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.cmbObras = new System.Windows.Forms.ComboBox();
            this.dsObraFac1 = new LancNeo.dsObraFac();
            this.cmbAgente = new System.Windows.Forms.ComboBox();
            this.dsAgente1 = new LancNeo.dsAgente();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSin = new System.Windows.Forms.RadioButton();
            this.rbtAlineada = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.sqlComValida = new System.Data.SqlClient.SqlCommand();
            this.sqlDAFactura = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dwvFactura = new System.Windows.Forms.DataGridView();
            this.numDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recepcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsObra1 = new LancNeo.dsObra();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsIncFac1 = new LancNeo.dsIncFac();
            this.sqlDAObras = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAAgente = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dlAbrirO = new System.Windows.Forms.OpenFileDialog();
            this.sqlComInsObj = new System.Data.SqlClient.SqlCommand();
            this.sqlComInsAge = new System.Data.SqlClient.SqlCommand();
            this.dlAbrirA = new System.Windows.Forms.OpenFileDialog();
            this.tbBtn6 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.sqlComLimpia = new System.Data.SqlClient.SqlCommand();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsObraFac1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgente1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dwvFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIncFac1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.tbBtn5);
            this.panel1.Controls.Add(this.tbBtn1);
            this.panel1.Controls.Add(this.tbBtn4);
            this.panel1.Controls.Add(this.btSelAge);
            this.panel1.Controls.Add(this.txtArcAge);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btSelObs);
            this.panel1.Controls.Add(this.txtArcObs);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btSelExc);
            this.panel1.Controls.Add(this.txtFicheroPDFOrigen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 176);
            this.panel1.TabIndex = 4;
            // 
            // tbBtn4
            // 
            this.tbBtn4.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn4.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn4.Icon")));
            this.tbBtn4.Location = new System.Drawing.Point(801, 53);
            this.tbBtn4.Name = "tbBtn4";
            this.tbBtn4.Size = new System.Drawing.Size(64, 64);
            this.tbBtn4.TabIndex = 65;
            this.tbBtn4.Click += new System.EventHandler(this.tbBtn4_Click);
            // 
            // tbBtn1
            // 
            this.tbBtn1.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn1.Icon")));
            this.tbBtn1.Location = new System.Drawing.Point(802, 3);
            this.tbBtn1.Name = "tbBtn1";
            this.tbBtn1.Size = new System.Drawing.Size(64, 64);
            this.tbBtn1.TabIndex = 58;
            this.tbBtn1.Load += new System.EventHandler(this.tbBtn1_Load);
            this.tbBtn1.Click += new System.EventHandler(this.tbBtn1_Click);
            // 
            // tbBtn5
            // 
            this.tbBtn5.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn5.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn5.Icon")));
            this.tbBtn5.Location = new System.Drawing.Point(801, 108);
            this.tbBtn5.Name = "tbBtn5";
            this.tbBtn5.Size = new System.Drawing.Size(64, 64);
            this.tbBtn5.TabIndex = 69;
            this.tbBtn5.Click += new System.EventHandler(this.tbBtn5_Click);
            // 
            // btSelAge
            // 
            this.btSelAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelAge.BackColor = System.Drawing.Color.SteelBlue;
            this.btSelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelAge.ForeColor = System.Drawing.Color.BlueViolet;
            this.btSelAge.Location = new System.Drawing.Point(801, 129);
            this.btSelAge.Name = "btSelAge";
            this.btSelAge.Size = new System.Drawing.Size(30, 24);
            this.btSelAge.TabIndex = 72;
            this.btSelAge.Text = "...";
            this.btSelAge.UseVisualStyleBackColor = false;
            this.btSelAge.Click += new System.EventHandler(this.btSelAge_Click);
            // 
            // txtArcAge
            // 
            this.txtArcAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArcAge.Location = new System.Drawing.Point(141, 131);
            this.txtArcAge.Name = "txtArcAge";
            this.txtArcAge.Size = new System.Drawing.Size(605, 20);
            this.txtArcAge.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(86, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Agentes:";
            // 
            // btSelObs
            // 
            this.btSelObs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelObs.BackColor = System.Drawing.Color.SteelBlue;
            this.btSelObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelObs.ForeColor = System.Drawing.Color.BlueViolet;
            this.btSelObs.Location = new System.Drawing.Point(801, 74);
            this.btSelObs.Name = "btSelObs";
            this.btSelObs.Size = new System.Drawing.Size(30, 24);
            this.btSelObs.TabIndex = 68;
            this.btSelObs.Text = "...";
            this.btSelObs.UseVisualStyleBackColor = false;
            this.btSelObs.Click += new System.EventHandler(this.btSelObs_Click);
            // 
            // txtArcObs
            // 
            this.txtArcObs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArcObs.Location = new System.Drawing.Point(141, 76);
            this.txtArcObs.Name = "txtArcObs";
            this.txtArcObs.Size = new System.Drawing.Size(605, 20);
            this.txtArcObs.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-2, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Observaciones de facturas:";
            // 
            // btSelExc
            // 
            this.btSelExc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSelExc.BackColor = System.Drawing.Color.SteelBlue;
            this.btSelExc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelExc.ForeColor = System.Drawing.Color.BlueViolet;
            this.btSelExc.Location = new System.Drawing.Point(802, 24);
            this.btSelExc.Name = "btSelExc";
            this.btSelExc.Size = new System.Drawing.Size(30, 24);
            this.btSelExc.TabIndex = 63;
            this.btSelExc.Text = "...";
            this.btSelExc.UseVisualStyleBackColor = false;
            this.btSelExc.Click += new System.EventHandler(this.btSelExc_Click);
            // 
            // txtFicheroPDFOrigen
            // 
            this.txtFicheroPDFOrigen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFicheroPDFOrigen.Location = new System.Drawing.Point(142, 26);
            this.txtFicheroPDFOrigen.Name = "txtFicheroPDFOrigen";
            this.txtFicheroPDFOrigen.Size = new System.Drawing.Size(605, 20);
            this.txtFicheroPDFOrigen.TabIndex = 62;
            this.txtFicheroPDFOrigen.TextChanged += new System.EventHandler(this.txtFicheroPDFOrigen_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Archivo de excel:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 57);
            this.label1.TabIndex = 7;
            this.label1.Text = "Incorpora facturas cobranza";
            // 
            // dlAbrir
            // 
            this.dlAbrir.FileName = "openFileDialog1";
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlComInserta
            // 
            this.sqlComInserta.CommandText = "insertFactura";
            this.sqlComInserta.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComInserta.Connection = this.sqlConn;
            this.sqlComInserta.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.NVarChar, 8),
            new System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.NVarChar, 4),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@Recepcion", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@IdCliente", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@Cliente", System.Data.SqlDbType.NChar, 100),
            new System.Data.SqlClient.SqlParameter("@S", System.Data.SqlDbType.NVarChar, 1),
            new System.Data.SqlClient.SqlParameter("@N", System.Data.SqlDbType.NVarChar, 2),
            new System.Data.SqlClient.SqlParameter("@Agente", System.Data.SqlDbType.NVarChar, 3),
            new System.Data.SqlClient.SqlParameter("@Importe", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlComInsertaCob
            // 
            this.sqlComInsertaCob.CommandText = "insertFacCob";
            this.sqlComInsertaCob.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComInsertaCob.Connection = this.sqlConn;
            this.sqlComInsertaCob.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.NVarChar, 8),
            new System.Data.SqlClient.SqlParameter("@NCobro", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@Concepto", System.Data.SqlDbType.NVarChar, 50),
            new System.Data.SqlClient.SqlParameter("@ICobrado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.tbBtn6);
            this.panel2.Controls.Add(this.tbBtn3);
            this.panel2.Controls.Add(this.btnVistaPrevia);
            this.panel2.Controls.Add(this.tbBtn2);
            this.panel2.Controls.Add(this.cmbObras);
            this.panel2.Controls.Add(this.cmbAgente);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 70);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tbBtn2
            // 
            this.tbBtn2.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn2.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn2.Icon")));
            this.tbBtn2.Location = new System.Drawing.Point(164, 3);
            this.tbBtn2.Name = "tbBtn2";
            this.tbBtn2.Size = new System.Drawing.Size(64, 64);
            this.tbBtn2.TabIndex = 64;
            this.tbBtn2.Click += new System.EventHandler(this.tbBtn2_Click);
            // 
            // tbBtn3
            // 
            this.tbBtn3.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn3.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn3.Icon")));
            this.tbBtn3.Location = new System.Drawing.Point(764, 3);
            this.tbBtn3.Name = "tbBtn3";
            this.tbBtn3.Size = new System.Drawing.Size(64, 64);
            this.tbBtn3.TabIndex = 64;
            this.tbBtn3.Click += new System.EventHandler(this.tbBtn3_Click);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(680, 3);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 68;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // cmbObras
            // 
            this.cmbObras.DataSource = this.dsObraFac1;
            this.cmbObras.DisplayMember = "Factura.Obra";
            this.cmbObras.FormattingEnabled = true;
            this.cmbObras.Location = new System.Drawing.Point(578, 21);
            this.cmbObras.Name = "cmbObras";
            this.cmbObras.Size = new System.Drawing.Size(84, 21);
            this.cmbObras.TabIndex = 67;
            this.cmbObras.ValueMember = "Factura.Obra";
            this.cmbObras.Visible = false;
            // 
            // dsObraFac1
            // 
            this.dsObraFac1.DataSetName = "dsObraFac";
            this.dsObraFac1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbAgente
            // 
            this.cmbAgente.DataSource = this.dsAgente1;
            this.cmbAgente.DisplayMember = "Factura.Agente1";
            this.cmbAgente.FormattingEnabled = true;
            this.cmbAgente.Location = new System.Drawing.Point(457, 21);
            this.cmbAgente.Name = "cmbAgente";
            this.cmbAgente.Size = new System.Drawing.Size(84, 21);
            this.cmbAgente.TabIndex = 66;
            this.cmbAgente.ValueMember = "Factura.Agente";
            // 
            // dsAgente1
            // 
            this.dsAgente1.DataSetName = "dsAgente";
            this.dsAgente1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSin);
            this.groupBox1.Controls.Add(this.rbtAlineada);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(272, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 47);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // rdbSin
            // 
            this.rdbSin.AutoSize = true;
            this.rdbSin.Location = new System.Drawing.Point(94, 20);
            this.rdbSin.Name = "rdbSin";
            this.rdbSin.Size = new System.Drawing.Size(72, 17);
            this.rdbSin.TabIndex = 1;
            this.rdbSin.Text = "por obra";
            this.rdbSin.UseVisualStyleBackColor = true;
            this.rdbSin.CheckedChanged += new System.EventHandler(this.rdbSin_CheckedChanged);
            // 
            // rbtAlineada
            // 
            this.rbtAlineada.AutoSize = true;
            this.rbtAlineada.Checked = true;
            this.rbtAlineada.Location = new System.Drawing.Point(7, 20);
            this.rbtAlineada.Name = "rbtAlineada";
            this.rbtAlineada.Size = new System.Drawing.Size(86, 17);
            this.rbtAlineada.TabIndex = 0;
            this.rbtAlineada.TabStop = true;
            this.rbtAlineada.Text = "por agente";
            this.rbtAlineada.UseVisualStyleBackColor = true;
            this.rbtAlineada.CheckedChanged += new System.EventHandler(this.rbtAlineada_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Validar clientes";
            // 
            // sqlComValida
            // 
            this.sqlComValida.CommandText = "ValidaCliente";
            this.sqlComValida.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComValida.Connection = this.sqlConn;
            // 
            // sqlDAFactura
            // 
            this.sqlDAFactura.DeleteCommand = this.sqlCommand1;
            this.sqlDAFactura.InsertCommand = this.sqlInsertCommand;
            this.sqlDAFactura.SelectCommand = this.sqlCommand3;
            this.sqlDAFactura.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Factura", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("NumDoc", "NumDoc"),
                        new System.Data.Common.DataColumnMapping("TipoDoc", "TipoDoc"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Recepcion", "Recepcion"),
                        new System.Data.Common.DataColumnMapping("Vencimiento", "Vencimiento"),
                        new System.Data.Common.DataColumnMapping("IdCliente", "IdCliente"),
                        new System.Data.Common.DataColumnMapping("Cliente", "Cliente"),
                        new System.Data.Common.DataColumnMapping("S", "S"),
                        new System.Data.Common.DataColumnMapping("N", "N"),
                        new System.Data.Common.DataColumnMapping("Agente", "Agente"),
                        new System.Data.Common.DataColumnMapping("Anos", "Anos"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Importe", "Importe"),
                        new System.Data.Common.DataColumnMapping("Saldo", "Saldo"),
                        new System.Data.Common.DataColumnMapping("Obra", "Obra"),
                        new System.Data.Common.DataColumnMapping("Obs", "Obs")})});
            this.sqlDAFactura.UpdateCommand = this.sqlUpdateCommand;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConn;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NumDoc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TipoDoc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TipoDoc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TipoDoc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fecha", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Recepcion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Recepcion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Recepcion", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Recepcion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Vencimiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Vencimiento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Vencimiento", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vencimiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdCliente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdCliente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdCliente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdCliente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cliente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cliente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cliente", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cliente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_S", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "S", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_S", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "S", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_N", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "N", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_N", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Agente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Agente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Agente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Agente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Anos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Anos", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Anos", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Anos", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Semana", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Importe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Importe", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Importe", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Importe", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Saldo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Saldo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Saldo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Saldo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Obra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Obra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Obra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Obra", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand
            // 
            this.sqlInsertCommand.CommandText = resources.GetString("sqlInsertCommand.CommandText");
            this.sqlInsertCommand.Connection = this.sqlConn;
            this.sqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.NVarChar, 0, "NumDoc"),
            new System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.NVarChar, 0, "TipoDoc"),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.SmallDateTime, 0, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@Recepcion", System.Data.SqlDbType.SmallDateTime, 0, "Recepcion"),
            new System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.SmallDateTime, 0, "Vencimiento"),
            new System.Data.SqlClient.SqlParameter("@IdCliente", System.Data.SqlDbType.NVarChar, 0, "IdCliente"),
            new System.Data.SqlClient.SqlParameter("@Cliente", System.Data.SqlDbType.NChar, 0, "Cliente"),
            new System.Data.SqlClient.SqlParameter("@S", System.Data.SqlDbType.NVarChar, 0, "S"),
            new System.Data.SqlClient.SqlParameter("@N", System.Data.SqlDbType.NVarChar, 0, "N"),
            new System.Data.SqlClient.SqlParameter("@Agente", System.Data.SqlDbType.NVarChar, 0, "Agente"),
            new System.Data.SqlClient.SqlParameter("@Anos", System.Data.SqlDbType.SmallInt, 0, "Anos"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 0, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Importe", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Importe", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Saldo", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Obra", System.Data.SqlDbType.NVarChar, 0, "Obra"),
            new System.Data.SqlClient.SqlParameter("@Obs", System.Data.SqlDbType.NVarChar, 0, "Obs")});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "FacturasDes";
            this.sqlCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand3.Connection = this.sqlConn;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Bit, 1),
            new System.Data.SqlClient.SqlParameter("@Agente", System.Data.SqlDbType.NVarChar, 3),
            new System.Data.SqlClient.SqlParameter("@Obra", System.Data.SqlDbType.NVarChar, 6)});
            // 
            // sqlUpdateCommand
            // 
            this.sqlUpdateCommand.CommandText = resources.GetString("sqlUpdateCommand.CommandText");
            this.sqlUpdateCommand.Connection = this.sqlConn;
            this.sqlUpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.NVarChar, 0, "NumDoc"),
            new System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.NVarChar, 0, "TipoDoc"),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.SmallDateTime, 0, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@Recepcion", System.Data.SqlDbType.SmallDateTime, 0, "Recepcion"),
            new System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.SmallDateTime, 0, "Vencimiento"),
            new System.Data.SqlClient.SqlParameter("@IdCliente", System.Data.SqlDbType.NVarChar, 0, "IdCliente"),
            new System.Data.SqlClient.SqlParameter("@Cliente", System.Data.SqlDbType.NChar, 0, "Cliente"),
            new System.Data.SqlClient.SqlParameter("@S", System.Data.SqlDbType.NVarChar, 0, "S"),
            new System.Data.SqlClient.SqlParameter("@N", System.Data.SqlDbType.NVarChar, 0, "N"),
            new System.Data.SqlClient.SqlParameter("@Agente", System.Data.SqlDbType.NVarChar, 0, "Agente"),
            new System.Data.SqlClient.SqlParameter("@Anos", System.Data.SqlDbType.SmallInt, 0, "Anos"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 0, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Importe", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Importe", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Saldo", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Obra", System.Data.SqlDbType.NVarChar, 0, "Obra"),
            new System.Data.SqlClient.SqlParameter("@Obs", System.Data.SqlDbType.NVarChar, 0, "Obs"),
            new System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NumDoc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TipoDoc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TipoDoc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TipoDoc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fecha", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Recepcion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Recepcion", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Recepcion", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Recepcion", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Vencimiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Vencimiento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Vencimiento", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vencimiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdCliente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdCliente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdCliente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdCliente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cliente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cliente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cliente", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cliente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_S", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "S", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_S", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "S", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_N", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "N", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_N", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "N", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Agente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Agente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Agente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Agente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Anos", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Anos", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Anos", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Anos", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Semana", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Importe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Importe", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Importe", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Importe", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Saldo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Saldo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Saldo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "Saldo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Obra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Obra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Obra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Obra", System.Data.DataRowVersion.Original, null)});
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.dwvFactura);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 207);
            this.panel3.TabIndex = 6;
            // 
            // dwvFactura
            // 
            this.dwvFactura.AllowUserToAddRows = false;
            this.dwvFactura.AllowUserToDeleteRows = false;
            this.dwvFactura.AutoGenerateColumns = false;
            this.dwvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDocDataGridViewTextBoxColumn,
            this.tipoDocDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.recepcionDataGridViewTextBoxColumn,
            this.vencimientoDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.agenteDataGridViewTextBoxColumn,
            this.obraDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn,
            this.Obs});
            this.dwvFactura.DataMember = "Factura";
            this.dwvFactura.DataSource = this.dsIncFac1;
            this.dwvFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dwvFactura.Location = new System.Drawing.Point(0, 0);
            this.dwvFactura.Name = "dwvFactura";
            this.dwvFactura.Size = new System.Drawing.Size(944, 207);
            this.dwvFactura.TabIndex = 0;
            this.dwvFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dwvFactura_CellContentClick);
            // 
            // numDocDataGridViewTextBoxColumn
            // 
            this.numDocDataGridViewTextBoxColumn.DataPropertyName = "NumDoc";
            this.numDocDataGridViewTextBoxColumn.HeaderText = "NumDoc";
            this.numDocDataGridViewTextBoxColumn.Name = "numDocDataGridViewTextBoxColumn";
            this.numDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.numDocDataGridViewTextBoxColumn.Width = 60;
            // 
            // tipoDocDataGridViewTextBoxColumn
            // 
            this.tipoDocDataGridViewTextBoxColumn.DataPropertyName = "TipoDoc";
            this.tipoDocDataGridViewTextBoxColumn.HeaderText = "TipoDoc";
            this.tipoDocDataGridViewTextBoxColumn.Name = "tipoDocDataGridViewTextBoxColumn";
            this.tipoDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDocDataGridViewTextBoxColumn.Width = 50;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 70;
            // 
            // recepcionDataGridViewTextBoxColumn
            // 
            this.recepcionDataGridViewTextBoxColumn.DataPropertyName = "Recepcion";
            this.recepcionDataGridViewTextBoxColumn.HeaderText = "Recepcion";
            this.recepcionDataGridViewTextBoxColumn.Name = "recepcionDataGridViewTextBoxColumn";
            this.recepcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.recepcionDataGridViewTextBoxColumn.Width = 70;
            // 
            // vencimientoDataGridViewTextBoxColumn
            // 
            this.vencimientoDataGridViewTextBoxColumn.DataPropertyName = "Vencimiento";
            this.vencimientoDataGridViewTextBoxColumn.HeaderText = "Vencimiento";
            this.vencimientoDataGridViewTextBoxColumn.Name = "vencimientoDataGridViewTextBoxColumn";
            this.vencimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.vencimientoDataGridViewTextBoxColumn.Width = 70;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Width = 50;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteDataGridViewTextBoxColumn.Width = 550;
            // 
            // agenteDataGridViewTextBoxColumn
            // 
            this.agenteDataGridViewTextBoxColumn.DataPropertyName = "Agente";
            this.agenteDataGridViewTextBoxColumn.HeaderText = "Agente";
            this.agenteDataGridViewTextBoxColumn.Name = "agenteDataGridViewTextBoxColumn";
            this.agenteDataGridViewTextBoxColumn.ReadOnly = true;
            this.agenteDataGridViewTextBoxColumn.Width = 50;
            // 
            // obraDataGridViewTextBoxColumn
            // 
            this.obraDataGridViewTextBoxColumn.DataPropertyName = "Obra";
            this.obraDataGridViewTextBoxColumn.DataSource = this.dsObra1;
            this.obraDataGridViewTextBoxColumn.DisplayMember = "Obra.Idobra";
            this.obraDataGridViewTextBoxColumn.HeaderText = "Obra";
            this.obraDataGridViewTextBoxColumn.Name = "obraDataGridViewTextBoxColumn";
            this.obraDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.obraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.obraDataGridViewTextBoxColumn.ValueMember = "Obra.Idobra";
            // 
            // dsObra1
            // 
            this.dsObra1.DataSetName = "dsObra";
            this.dsObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "Importe";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.importeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.importeDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            this.importeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.saldoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.saldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            this.saldoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Obs
            // 
            this.Obs.DataPropertyName = "Obs";
            this.Obs.HeaderText = "Obs";
            this.Obs.Name = "Obs";
            // 
            // dsIncFac1
            // 
            this.dsIncFac1.DataSetName = "dsIncFac";
            this.dsIncFac1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sqlDAAgente
            // 
            this.sqlDAAgente.SelectCommand = this.sqlCommand5;
            this.sqlDAAgente.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Factura", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Agente", "Agente"),
                        new System.Data.Common.DataColumnMapping("Agente1", "Agente1")})});
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SELECT DISTINCT Agente, Agente AS Agente1\r\nFROM         Factura\r\nORDER BY Agente";
            this.sqlCommand5.Connection = this.sqlConn;
            // 
            // sqlDAObra
            // 
            this.sqlDAObra.SelectCommand = this.sqlCommand2;
            this.sqlDAObra.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Factura", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Agente", "Agente"),
                        new System.Data.Common.DataColumnMapping("Agente1", "Agente1")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "SELECT DISTINCT Obra, Obra AS Obra1\r\nFROM         Factura\r\nORDER BY Obra";
            this.sqlCommand2.Connection = this.sqlConn;
            // 
            // dlAbrirO
            // 
            this.dlAbrirO.FileName = "openFileDialog1";
            // 
            // sqlComInsObj
            // 
            this.sqlComInsObj.CommandText = "insertFacObs";
            this.sqlComInsObj.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComInsObj.Connection = this.sqlConn;
            this.sqlComInsObj.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.NVarChar, 8),
            new System.Data.SqlClient.SqlParameter("@Obser", System.Data.SqlDbType.NVarChar, 2147483647)});
            // 
            // sqlComInsAge
            // 
            this.sqlComInsAge.CommandText = "insertAgente";
            this.sqlComInsAge.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComInsAge.Connection = this.sqlConn;
            this.sqlComInsAge.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdAgente", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@Agente", System.Data.SqlDbType.NVarChar, 50)});
            // 
            // dlAbrirA
            // 
            this.dlAbrirA.FileName = "openFileDialog1";
            // 
            // tbBtn6
            // 
            this.tbBtn6.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn6.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn6.Icon")));
            this.tbBtn6.Location = new System.Drawing.Point(855, 3);
            this.tbBtn6.Name = "tbBtn6";
            this.tbBtn6.Size = new System.Drawing.Size(64, 64);
            this.tbBtn6.TabIndex = 69;
            this.tbBtn6.Click += new System.EventHandler(this.tbBtn6_Click);
            // 
            // sqlComLimpia
            // 
            this.sqlComLimpia.CommandText = "LimpiaObs";
            this.sqlComLimpia.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComLimpia.Connection = this.sqlConn;
            // 
            // IncFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 453);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IncFactura";
            this.Text = "IncFactura";
            this.Load += new System.EventHandler(this.IncFactura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsObraFac1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAgente1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dwvFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIncFac1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected Soluciones2000.Tools.WinLib.tbBtn tbBtn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog dlAbrir;
        private System.Data.SqlClient.SqlConnection sqlConn;
        private dsIncFac dsIncFac1;
        private System.Data.SqlClient.SqlCommand sqlComInserta;
        private System.Data.SqlClient.SqlCommand sqlComInsertaCob;
        private System.Windows.Forms.Panel panel2;
        protected Soluciones2000.Tools.WinLib.tbBtn tbBtn2;
        private System.Windows.Forms.Label label3;
        private System.Data.SqlClient.SqlCommand sqlComValida;
        private System.Data.SqlClient.SqlDataAdapter sqlDAFactura;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand;
        private System.Windows.Forms.DataGridView dwvFactura;
        private System.Windows.Forms.Panel panel3;
        private System.Data.SqlClient.SqlDataAdapter sqlDAObras;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private dsObra dsObra1;
        protected Soluciones2000.Tools.WinLib.tbBtn tbBtn3;
        private System.Windows.Forms.ComboBox cmbAgente;
        private dsAgente dsAgente1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSin;
        private System.Windows.Forms.RadioButton rbtAlineada;
        private System.Data.SqlClient.SqlDataAdapter sqlDAAgente;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
        private System.Windows.Forms.TextBox txtFicheroPDFOrigen;
        private System.Windows.Forms.ComboBox cmbObras;
        private dsObraFac dsObraFac1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAObra;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        protected System.Windows.Forms.Button btSelExc;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recepcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn obraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obs;
        protected Soluciones2000.Tools.WinLib.tbBtn tbBtn4;
        protected System.Windows.Forms.Button btSelObs;
        private System.Windows.Forms.TextBox txtArcObs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog dlAbrirO;
        private System.Data.SqlClient.SqlCommand sqlComInsObj;
        protected Soluciones2000.Tools.WinLib.tbBtn tbBtn5;
        protected System.Windows.Forms.Button btSelAge;
        private System.Windows.Forms.TextBox txtArcAge;
        private System.Windows.Forms.Label label5;
        private System.Data.SqlClient.SqlCommand sqlComInsAge;
        private System.Windows.Forms.OpenFileDialog dlAbrirA;
        protected Soluciones2000.Tools.WinLib.tbBtn tbBtn6;
        private System.Data.SqlClient.SqlCommand sqlComLimpia;
    }
}