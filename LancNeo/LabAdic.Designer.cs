namespace LancNeo
{
    partial class LabAdic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabAdic));
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDALabAdic = new System.Data.SqlClient.SqlDataAdapter();
            this.dsLabAdic1 = new LancNeo.dsLabAdic();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDALaboratorista = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.dsLaboratorista1 = new LancNeo.dsLaboratorista();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.txtObserva = new System.Windows.Forms.TextBox();
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.cmbNoeco = new System.Windows.Forms.ComboBox();
            this.dtpFensaye = new System.Windows.Forms.DateTimePicker();
            this.dtpFmuestreo = new System.Windows.Forms.DateTimePicker();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLabAdic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 392);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(598, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(598, 64);
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     IdObra, NoEco, FInicial, FFinal, Semana, Observación\r\nFROM         Lab" +
                "Adic\r\nORDER BY IdObra, NoEco, FInicial, FFinal";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@FInicial", System.Data.SqlDbType.SmallDateTime, 0, "FInicial"),
            new System.Data.SqlClient.SqlParameter("@FFinal", System.Data.SqlDbType.SmallDateTime, 0, "FFinal"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.Int, 0, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Observación", System.Data.SqlDbType.VarChar, 0, "Observación")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@FInicial", System.Data.SqlDbType.SmallDateTime, 0, "FInicial"),
            new System.Data.SqlClient.SqlParameter("@FFinal", System.Data.SqlDbType.SmallDateTime, 0, "FFinal"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.Int, 0, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Observación", System.Data.SqlDbType.VarChar, 0, "Observación"),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FInicial", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FInicial", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FFinal", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FFinal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Semana", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Observación", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Observación", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Observación", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observación", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FInicial", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FInicial", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FFinal", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FFinal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Semana", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Observación", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Observación", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Observación", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observación", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDALabAdic
            // 
            this.sqlDALabAdic.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDALabAdic.InsertCommand = this.sqlInsertCommand1;
            this.sqlDALabAdic.SelectCommand = this.sqlSelectCommand1;
            this.sqlDALabAdic.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "LabAdic", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("FInicial", "FInicial"),
                        new System.Data.Common.DataColumnMapping("FFinal", "FFinal"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Observación", "Observación")})});
            this.sqlDALabAdic.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dsLabAdic1
            // 
            this.dsLabAdic1.DataSetName = "dsLabAdic";
            this.dsLabAdic1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.sqlCommand1.CommandText = "SELECT Obra.Idobra, Obra.Ubicacion, Obra.RFC, Razonsocial.Facturar FROM Obra LEFT" +
                " OUTER JOIN Razonsocial ON Obra.IdCliente = Razonsocial.IdCliente AND Obra.RFC =" +
                " Razonsocial.RFC ORDER BY Obra.Idobra";
            this.sqlCommand1.Connection = this.sqlConn;
            // 
            // sqlDALaboratorista
            // 
            this.sqlDALaboratorista.SelectCommand = this.sqlSelectCommand5;
            this.sqlDALaboratorista.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Laboratorista", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("Laboratorista", "Laboratorista"),
                        new System.Data.Common.DataColumnMapping("IdZona", "IdZona"),
                        new System.Data.Common.DataColumnMapping("IdNivel", "IdNivel"),
                        new System.Data.Common.DataColumnMapping("Fechai", "Fechai")})});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "SELECT NoEco, LTRIM(STR(NoEco)) + \' \' + Laboratorista AS Laboratorista, IdZona, I" +
                "dNivel, Fechai FROM Laboratorista ORDER BY NoEco";
            this.sqlSelectCommand5.Connection = this.sqlConn;
            // 
            // dsLaboratorista1
            // 
            this.dsLaboratorista1.DataSetName = "dsLaboratorista";
            this.dsLaboratorista1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsLaboratorista1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.txtObserva);
            this.panel2.Controls.Add(this.txtSemana);
            this.panel2.Controls.Add(this.cmbNoeco);
            this.panel2.Controls.Add(this.dtpFensaye);
            this.panel2.Controls.Add(this.dtpFmuestreo);
            this.panel2.Controls.Add(this.cmbIdObra);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(23, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 320);
            this.panel2.TabIndex = 5;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 675;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsLabAdic1.LabAdic;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(202, 2);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 20;
            // 
            // txtObserva
            // 
            this.txtObserva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLabAdic1, "LabAdic.Observación", true));
            this.txtObserva.Location = new System.Drawing.Point(126, 168);
            this.txtObserva.MaxLength = 50;
            this.txtObserva.Name = "txtObserva";
            this.txtObserva.Size = new System.Drawing.Size(394, 20);
            this.txtObserva.TabIndex = 19;
            this.txtObserva.Text = "textBox5";
            // 
            // txtSemana
            // 
            this.txtSemana.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLabAdic1, "LabAdic.Semana", true));
            this.txtSemana.Location = new System.Drawing.Point(126, 142);
            this.txtSemana.MaxLength = 2;
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(66, 20);
            this.txtSemana.TabIndex = 17;
            this.txtSemana.Text = "textBox3";
            // 
            // cmbNoeco
            // 
            this.cmbNoeco.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsLabAdic1, "LabAdic.NoEco", true));
            this.cmbNoeco.DataSource = this.dsLaboratorista1.Laboratorista;
            this.cmbNoeco.DisplayMember = "Laboratorista";
            this.cmbNoeco.Location = new System.Drawing.Point(126, 71);
            this.cmbNoeco.Name = "cmbNoeco";
            this.cmbNoeco.Size = new System.Drawing.Size(392, 21);
            this.cmbNoeco.TabIndex = 16;
            this.cmbNoeco.ValueMember = "NoEco";
            // 
            // dtpFensaye
            // 
            this.dtpFensaye.CustomFormat = "dd/MM/yyyy";
            this.dtpFensaye.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLabAdic1, "LabAdic.FFinal", true));
            this.dtpFensaye.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFensaye.Location = new System.Drawing.Point(126, 118);
            this.dtpFensaye.Name = "dtpFensaye";
            this.dtpFensaye.Size = new System.Drawing.Size(84, 20);
            this.dtpFensaye.TabIndex = 14;
            // 
            // dtpFmuestreo
            // 
            this.dtpFmuestreo.CustomFormat = "dd/MM/yyyy";
            this.dtpFmuestreo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsLabAdic1, "LabAdic.FInicial", true));
            this.dtpFmuestreo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFmuestreo.Location = new System.Drawing.Point(126, 94);
            this.dtpFmuestreo.Name = "dtpFmuestreo";
            this.dtpFmuestreo.Size = new System.Drawing.Size(84, 20);
            this.dtpFmuestreo.TabIndex = 13;
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsLabAdic1, "LabAdic.IdObra", true));
            this.cmbIdObra.DataSource = this.dsBusObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(126, 29);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(66, 21);
            this.cmbIdObra.TabIndex = 11;
            this.cmbIdObra.ValueMember = "Obra.Idobra";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Observaciones:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Semana:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ensayado por:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha final:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha inicial";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.label4, ":");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Obra:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabAdic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 414);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDALabAdic;
            this.dsGeneral = this.dsLabAdic1;
            this.Name = "LabAdic";
            this.NombreTabla = "LabAdic";
            this.Text = "LabAdic";
            this.Load += new System.EventHandler(this.LabAdic_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsLabAdic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorista1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Data.SqlClient.SqlConnection sqlConn;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDALabAdic;
        private dsLabAdic dsLabAdic1;
        private dsBusObra dsBusObra1;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDALaboratorista;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private dsLaboratorista dsLaboratorista1;
        private System.Windows.Forms.Panel panel2;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
        private System.Windows.Forms.TextBox txtObserva;
        private System.Windows.Forms.TextBox txtSemana;
        private System.Windows.Forms.ComboBox cmbNoeco;
        private System.Windows.Forms.DateTimePicker dtpFensaye;
        private System.Windows.Forms.DateTimePicker dtpFmuestreo;
        private System.Windows.Forms.ComboBox cmbIdObra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}