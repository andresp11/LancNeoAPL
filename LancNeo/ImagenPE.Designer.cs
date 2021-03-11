namespace LancNeo
{
    partial class ImagenPE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImagenPE));
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlComGraba = new System.Data.SqlClient.SqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPROCESO = new Soluciones2000.Tools.WinLib.tbBtn();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsImagenPE1 = new LancNeo.dsImagenPE();
            this.txtUsrMov = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.dsNorma1 = new LancNeo.dsNorma();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dsConcepto1 = new LancNeo.dsConcepto();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFmuestreo = new System.Windows.Forms.DateTimePicker();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlDAConcepto = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAImagenPE = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsImagenPE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNorma1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcepto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 296);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(584, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(584, 64);
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnPROCESO);
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.txtUsrMov);
            this.panel2.Controls.Add(this.label59);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpFmuestreo);
            this.panel2.Controls.Add(this.txtConsecutivo);
            this.panel2.Controls.Add(this.cmbIdObra);
            this.panel2.Controls.Add(this.txtFolio);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(24, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 220);
            this.panel2.TabIndex = 8;
            // 
            // btnPROCESO
            // 
            this.btnPROCESO.BackColor = System.Drawing.Color.Transparent;
            this.btnPROCESO.Icon = ((System.Drawing.Icon)(resources.GetObject("btnPROCESO.Icon")));
            this.btnPROCESO.Location = new System.Drawing.Point(131, 145);
            this.btnPROCESO.Name = "btnPROCESO";
            this.btnPROCESO.Size = new System.Drawing.Size(64, 64);
            this.btnPROCESO.TabIndex = 26;
            this.btnPROCESO.Load += new System.EventHandler(this.btnPROCESO_Load);
            this.btnPROCESO.Click += new System.EventHandler(this.btnPROCESO_Click);
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsImagenPE1.ImagenPE;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(198, 6);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 27;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // dsImagenPE1
            // 
            this.dsImagenPE1.DataSetName = "dsImagenPE";
            this.dsImagenPE1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtUsrMov
            // 
            this.txtUsrMov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsImagenPE1, "ImagenPE.IdUsusario", true));
            this.txtUsrMov.Location = new System.Drawing.Point(414, 168);
            this.txtUsrMov.Name = "txtUsrMov";
            this.txtUsrMov.ReadOnly = true;
            this.txtUsrMov.Size = new System.Drawing.Size(68, 20);
            this.txtUsrMov.TabIndex = 70;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.Red;
            this.label59.Location = new System.Drawing.Point(353, 172);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(54, 13);
            this.label59.TabIndex = 69;
            this.label59.Text = "Usuario:";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dsNorma1
            // 
            this.dsNorma1.DataSetName = "dsNorma";
            this.dsNorma1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsNorma1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "No. de muestras:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Prueba especial:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsImagenPE1, "ImagenPE.IdConcepto", true));
            this.comboBox1.DataSource = this.dsConcepto1;
            this.comboBox1.DisplayMember = "Concepto.Concepto";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.ValueMember = "Concepto.IdConcepto";
            // 
            // dsConcepto1
            // 
            this.dsConcepto1.DataSetName = "dsConcepto";
            this.dsConcepto1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcepto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Imagen:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFmuestreo
            // 
            this.dtpFmuestreo.CustomFormat = "dd/MM/yyyy";
            this.dtpFmuestreo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsImagenPE1, "ImagenPE.Fmuestreo", true));
            this.dtpFmuestreo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFmuestreo.Location = new System.Drawing.Point(414, 30);
            this.dtpFmuestreo.Name = "dtpFmuestreo";
            this.dtpFmuestreo.Size = new System.Drawing.Size(84, 20);
            this.dtpFmuestreo.TabIndex = 13;
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsImagenPE1, "ImagenPE.ConsObra", true));
            this.txtConsecutivo.Location = new System.Drawing.Point(414, 6);
            this.txtConsecutivo.MaxLength = 4;
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(66, 20);
            this.txtConsecutivo.TabIndex = 12;
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsImagenPE1, "ImagenPE.IdObra", true));
            this.cmbIdObra.DataSource = this.dsBusObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(126, 35);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(66, 21);
            this.cmbIdObra.TabIndex = 11;
            this.cmbIdObra.ValueMember = "Obra.Idobra";
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtFolio
            // 
            this.txtFolio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsImagenPE1, "ImagenPE.Folio", true));
            this.txtFolio.Location = new System.Drawing.Point(126, 11);
            this.txtFolio.MaxLength = 10;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(64, 20);
            this.txtFolio.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de muestreo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Consecutivo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Obra:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOLIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sqlDAConcepto
            // 
            this.sqlDAConcepto.SelectCommand = this.sqlCommand2;
            this.sqlDAConcepto.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "SELECT     IdConcepto, Concepto\r\nFROM         Concepto\r\nWHERE     (Especial = 1)\r" +
    "\nORDER BY Concepto";
            this.sqlCommand2.Connection = this.sqlConn;
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
            this.sqlCommand1.CommandText = "SELECT Obra.Idobra, Obra.Ubicacion, Obra.RFC, Razonsocial.Facturar FROM Obra LEFT" +
    " OUTER JOIN Razonsocial ON Obra.IdCliente = Razonsocial.IdCliente AND Obra.RFC =" +
    " Razonsocial.RFC ORDER BY Obra.Idobra";
            this.sqlCommand1.Connection = this.sqlConn;
            // 
            // sqlDAImagenPE
            // 
            this.sqlDAImagenPE.DeleteCommand = this.sqlDeleteCommand;
            this.sqlDAImagenPE.InsertCommand = this.sqlInsertCommand;
            this.sqlDAImagenPE.SelectCommand = this.sqlCommand3;
            this.sqlDAImagenPE.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ImagenPE", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("IdConcepto", "IdConcepto"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("Fmuestreo", "Fmuestreo"),
                        new System.Data.Common.DataColumnMapping("Imagen", "Imagen"),
                        new System.Data.Common.DataColumnMapping("Periodo", "Periodo"),
                        new System.Data.Common.DataColumnMapping("IdUsuario", "IdUsuario")})});
            this.sqlDAImagenPE.UpdateCommand = this.sqlUpdateCommand;
            // 
            // sqlDeleteCommand
            // 
            this.sqlDeleteCommand.CommandText = resources.GetString("sqlDeleteCommand.CommandText");
            this.sqlDeleteCommand.Connection = this.sqlConn;
            this.sqlDeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Folio", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Folio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdConcepto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdConcepto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ConsObra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ConsObra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fmuestreo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fmuestreo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fmuestreo", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fmuestreo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Periodo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Periodo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Periodo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand
            // 
            this.sqlInsertCommand.CommandText = resources.GetString("sqlInsertCommand.CommandText");
            this.sqlInsertCommand.Connection = this.sqlConn;
            this.sqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.Char, 0, "Folio"),
            new System.Data.SqlClient.SqlParameter("@IdConcepto", System.Data.SqlDbType.SmallInt, 0, "IdConcepto"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@ConsObra", System.Data.SqlDbType.SmallInt, 0, "ConsObra"),
            new System.Data.SqlClient.SqlParameter("@Fmuestreo", System.Data.SqlDbType.SmallDateTime, 0, "Fmuestreo"),
            new System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.SmallInt, 0, "Periodo"),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario")});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "SELECT        Folio, IdConcepto, IdObra, ConsObra, Fmuestreo, \' \' AS Imagen, Peri" +
    "odo, IdUsuario\r\nFROM            ImagenPE\r\nORDER BY IdObra, Folio, IdConcepto";
            this.sqlCommand3.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand
            // 
            this.sqlUpdateCommand.CommandText = resources.GetString("sqlUpdateCommand.CommandText");
            this.sqlUpdateCommand.Connection = this.sqlConn;
            this.sqlUpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Folio", System.Data.SqlDbType.Char, 0, "Folio"),
            new System.Data.SqlClient.SqlParameter("@IdConcepto", System.Data.SqlDbType.SmallInt, 0, "IdConcepto"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@ConsObra", System.Data.SqlDbType.SmallInt, 0, "ConsObra"),
            new System.Data.SqlClient.SqlParameter("@Fmuestreo", System.Data.SqlDbType.SmallDateTime, 0, "Fmuestreo"),
            new System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.SmallInt, 0, "Periodo"),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario"),
            new System.Data.SqlClient.SqlParameter("@Original_Folio", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Folio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdConcepto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdConcepto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ConsObra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ConsObra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fmuestreo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fmuestreo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fmuestreo", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fmuestreo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Periodo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Periodo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Periodo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsImagenPE1, "ImagenPE.Periodo", true));
            this.textBox1.Location = new System.Drawing.Point(414, 81);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(3, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(531, 37);
            this.label8.TabIndex = 72;
            this.label8.Text = resources.GetString("label8.Text");
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImagenPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 318);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAImagenPE;
            this.dsGeneral = this.dsImagenPE1;
            this.Name = "ImagenPE";
            this.NombreTabla = "ImagenPE";
            this.Text = "Pruebas especiales";
            this.Load += new System.EventHandler(this.ImagenPE_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsImagenPE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNorma1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcepto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConn;
        private System.Data.SqlClient.SqlCommand sqlComGraba;
        private System.Windows.Forms.Panel panel2;
        protected Soluciones2000.Tools.WinLib.tbBtn btnPROCESO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFmuestreo;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.ComboBox cmbIdObra;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Data.SqlClient.SqlDataAdapter sqlDAConcepto;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private dsConcepto dsConcepto1;
        private dsBusObra dsBusObra1;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        public System.Data.SqlClient.SqlDataAdapter sqlDAImagenPE;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand;
        private dsImagenPE dsImagenPE1;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
        private System.Windows.Forms.Label label7;
        private dsNorma dsNorma1;
        private System.Windows.Forms.TextBox txtUsrMov;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
    }
}