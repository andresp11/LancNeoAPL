namespace LancNeo
{
    partial class InfProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfProd));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbBtn1 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.UnirPdf = new Soluciones2000.Tools.WinLib.tbBtn();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.ckbEliFut = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIdGrupo = new System.Windows.Forms.ComboBox();
            this.dsGrupos1 = new LancNeo.dsGrupos();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDAGrupos = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAGraGrupos = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.crvInfProd = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sqlDAVivienda = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAGrupo = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlComEficiencia = new System.Data.SqlClient.SqlCommand();
            this.sqlDADuracion = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDASolicitud = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlDASFestivo = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsSFestivo1 = new LancNeo.dsSFestivo();
            this.sqlDAVivIni = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand7 = new System.Data.SqlClient.SqlCommand();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dsGraduracion1 = new LancNeo.dsGraduracion();
            this.cryGraGrupos1 = new LancNeo.CryGraGrupos();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSFestivo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGraduracion1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.UnirPdf);
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.tbBtn1);
            this.panel1.Controls.Add(this.ckbEliFut);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpIni);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbIdGrupo);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 72);
            this.panel1.TabIndex = 13;
            // 
            // tbBtn1
            // 
            this.tbBtn1.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn1.Icon")));
            this.tbBtn1.Location = new System.Drawing.Point(650, 4);
            this.tbBtn1.Name = "tbBtn1";
            this.tbBtn1.Size = new System.Drawing.Size(64, 64);
            this.tbBtn1.TabIndex = 56;
            this.tbBtn1.Click += new System.EventHandler(this.tbBtn1_Click);
            // 
            // UnirPdf
            // 
            this.UnirPdf.BackColor = System.Drawing.Color.Transparent;
            this.UnirPdf.Icon = ((System.Drawing.Icon)(resources.GetObject("UnirPdf.Icon")));
            this.UnirPdf.Location = new System.Drawing.Point(929, 0);
            this.UnirPdf.Name = "UnirPdf";
            this.UnirPdf.Size = new System.Drawing.Size(64, 64);
            this.UnirPdf.TabIndex = 64;
            this.UnirPdf.Click += new System.EventHandler(this.UnirPdf_Click);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(851, 0);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 11;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // ckbEliFut
            // 
            this.ckbEliFut.AutoSize = true;
            this.ckbEliFut.ForeColor = System.Drawing.Color.White;
            this.ckbEliFut.Location = new System.Drawing.Point(518, 52);
            this.ckbEliFut.Name = "ckbEliFut";
            this.ckbEliFut.Size = new System.Drawing.Size(94, 17);
            this.ckbEliFut.TabIndex = 63;
            this.ckbEliFut.Text = "Elimina futuros";
            this.ckbEliFut.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(718, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Elija un lunes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(515, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Elija el último sabado";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(758, 7);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(87, 20);
            this.dtpIni.TabIndex = 57;
            this.dtpIni.Value = new System.DateTime(2019, 1, 16, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(716, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Fecha:";
            // 
            // cmbIdGrupo
            // 
            this.cmbIdGrupo.DataSource = this.dsGrupos1;
            this.cmbIdGrupo.DisplayMember = "Grupo.Grupo";
            this.cmbIdGrupo.Location = new System.Drawing.Point(305, 7);
            this.cmbIdGrupo.Name = "cmbIdGrupo";
            this.cmbIdGrupo.Size = new System.Drawing.Size(202, 21);
            this.cmbIdGrupo.TabIndex = 1;
            this.cmbIdGrupo.ValueMember = "Grupo.IdGrupo";
            this.cmbIdGrupo.SelectedIndexChanged += new System.EventHandler(this.cmbIdGrupo_SelectedIndexChanged);
            // 
            // dsGrupos1
            // 
            this.dsGrupos1.DataSetName = "dsGrupos";
            this.dsGrupos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(557, 7);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(87, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(515, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(209, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Laboratorio inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grafica de eficiencia";
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDAGrupos
            // 
            this.sqlDAGrupos.SelectCommand = this.sqlCommand2;
            this.sqlDAGrupos.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Grupo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdGrupo", "IdGrupo"),
                        new System.Data.Common.DataColumnMapping("Grupo", "Grupo")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "SELECT     IdGrupo, Grupo\r\nFROM         Grupo\r\nWHERE     (CEILING(IdGrupo) = IdGr" +
    "upo)\r\nORDER BY Grupo";
            this.sqlCommand2.Connection = this.sqlConn;
            // 
            // sqlDAGraGrupos
            // 
            this.sqlDAGraGrupos.SelectCommand = this.sqlCommand1;
            this.sqlDAGraGrupos.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Grupo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdGrupo", "IdGrupo"),
                        new System.Data.Common.DataColumnMapping("Grupo", "Grupo")})});
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "GraGrupos";
            this.sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand1.Connection = this.sqlConn;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdGrupo", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(1)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Mes", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Cual", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // crvInfProd
            // 
            this.crvInfProd.ActiveViewIndex = -1;
            this.crvInfProd.AutoScroll = true;
            this.crvInfProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInfProd.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInfProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInfProd.Location = new System.Drawing.Point(0, 72);
            this.crvInfProd.Name = "crvInfProd";
            this.crvInfProd.ReuseParameterValuesOnRefresh = true;
            this.crvInfProd.ShowCloseButton = false;
            this.crvInfProd.ShowGroupTreeButton = false;
            this.crvInfProd.ShowLogo = false;
            this.crvInfProd.ShowPageNavigateButtons = false;
            this.crvInfProd.Size = new System.Drawing.Size(1005, 501);
            this.crvInfProd.TabIndex = 14;
            this.crvInfProd.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(194, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(616, 392);
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // sqlDAVivienda
            // 
            this.sqlDAVivienda.SelectCommand = this.sqlCommand3;
            this.sqlDAVivienda.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Grupo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdGrupo", "IdGrupo"),
                        new System.Data.Common.DataColumnMapping("Grupo", "Grupo")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "GraVivienda";
            this.sqlCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand3.Connection = this.sqlConn;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdGrupo", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(1)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Mes", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlDAGrupo
            // 
            this.sqlDAGrupo.SelectCommand = this.sqlCommand4;
            this.sqlDAGrupo.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Grupo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdGrupo", "IdGrupo"),
                        new System.Data.Common.DataColumnMapping("Grupo", "Grupo")})});
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "SELECT     IdGrupo, Grupo\r\nFROM         Grupo\r\nWHERE     (ROUND(IdGrupo, 0) = @Id" +
    "Grupo) AND (ROUND(IdGrupo, 0) - IdGrupo < 0)\r\nORDER BY IdGrupo";
            this.sqlCommand4.Connection = this.sqlConn;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdGrupo", System.Data.SqlDbType.Decimal)});
            // 
            // sqlComEficiencia
            // 
            this.sqlComEficiencia.CommandText = "insertProd";
            this.sqlComEficiencia.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComEficiencia.Connection = this.sqlConn;
            this.sqlComEficiencia.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6),
            new System.Data.SqlClient.SqlParameter("@FecIni", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@FecFin", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@EliFut", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlDADuracion
            // 
            this.sqlDADuracion.SelectCommand = this.sqlCommand5;
            this.sqlDADuracion.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Grupo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdGrupo", "IdGrupo"),
                        new System.Data.Common.DataColumnMapping("Grupo", "Grupo")})});
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "GraDuracion";
            this.sqlCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand5.Connection = this.sqlConn;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdGrupo", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(1)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Primero", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlDASolicitud
            // 
            this.sqlDASolicitud.SelectCommand = this.sqlCommand6;
            this.sqlDASolicitud.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Grupo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdGrupo", "IdGrupo"),
                        new System.Data.Common.DataColumnMapping("Grupo", "Grupo")})});
            // 
            // sqlCommand6
            // 
            this.sqlCommand6.CommandText = resources.GetString("sqlCommand6.CommandText");
            this.sqlCommand6.Connection = this.sqlConn;
            this.sqlCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // sqlDASFestivo
            // 
            this.sqlDASFestivo.SelectCommand = this.sqlSelectCommand1;
            this.sqlDASFestivo.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SFestivo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Año", "Año"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Dias", "Dias")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        Año, Semana, Dias\r\nFROM            SFestivo\r\nWHERE        (Año = @A" +
    "ño) AND (Semana BETWEEN @Si AND @Sf) OR\r\n                         (Año > @Año)\r\n" +
    "ORDER BY Año DESC, Semana DESC";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 2, "Año"),
            new System.Data.SqlClient.SqlParameter("@Si", System.Data.SqlDbType.SmallInt, 2, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Sf", System.Data.SqlDbType.SmallInt, 2, "Semana")});
            // 
            // dsSFestivo1
            // 
            this.dsSFestivo1.DataSetName = "dsSFestivo";
            this.dsSFestivo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAVivIni
            // 
            this.sqlDAVivIni.SelectCommand = this.sqlCommand7;
            this.sqlDAVivIni.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Grupo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdGrupo", "IdGrupo"),
                        new System.Data.Common.DataColumnMapping("Grupo", "Grupo")})});
            // 
            // sqlCommand7
            // 
            this.sqlCommand7.CommandText = "GraVivIni";
            this.sqlCommand7.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand7.Connection = this.sqlConn;
            this.sqlCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdGrupo", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(1)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Mes", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // dsGraduracion1
            // 
            this.dsGraduracion1.DataSetName = "dsGraduracion";
            this.dsGraduracion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InfProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 573);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.crvInfProd);
            this.Controls.Add(this.panel1);
            this.Name = "InfProd";
            this.Text = "InfProd";
            this.Load += new System.EventHandler(this.InfProd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSFestivo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGraduracion1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private System.Windows.Forms.ComboBox cmbIdGrupo;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlConnection sqlConn;
        public System.Data.SqlClient.SqlDataAdapter sqlDAGrupos;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private dsGrupos dsGrupos1;
        public System.Data.SqlClient.SqlDataAdapter sqlDAGraGrupos;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInfProd;
        private CryGraGrupos cryGraGrupos1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Data.SqlClient.SqlDataAdapter sqlDAVivienda;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        public System.Data.SqlClient.SqlDataAdapter sqlDAGrupo;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        protected Soluciones2000.Tools.WinLib.tbBtn tbBtn1;
        private System.Data.SqlClient.SqlCommand sqlComEficiencia;
        public System.Data.SqlClient.SqlDataAdapter sqlDADuracion;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpIni;
        private System.Windows.Forms.Label label3;
        public System.Data.SqlClient.SqlDataAdapter sqlDASolicitud;
        private System.Data.SqlClient.SqlCommand sqlCommand6;
        private System.Data.SqlClient.SqlDataAdapter sqlDASFestivo;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private dsSFestivo dsSFestivo1;
        private System.Windows.Forms.CheckBox ckbEliFut;
        public System.Data.SqlClient.SqlDataAdapter sqlDAVivIni;
        private System.Data.SqlClient.SqlCommand sqlCommand7;
        protected Soluciones2000.Tools.WinLib.tbBtn UnirPdf;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private dsGraduracion dsGraduracion1;
    }
}