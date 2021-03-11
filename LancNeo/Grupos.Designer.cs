namespace LancNeo
{
    partial class Grupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grupos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDAGrupo = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsGruposR1 = new LancNeo.dsGruposR();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrupos = new System.Windows.Forms.TextBox();
            this.lblIdBascula = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sqlDAGrObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dGVObras = new System.Windows.Forms.DataGridView();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.idGrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGruposR1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVObras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 601);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(613, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(613, 64);
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDAGrupo
            // 
            this.sqlDAGrupo.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAGrupo.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAGrupo.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAGrupo.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Grupo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdGrupo", "IdGrupo"),
                        new System.Data.Common.DataColumnMapping("Grupo", "Grupo")})});
            this.sqlDAGrupo.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [Grupo] WHERE (([IdGrupo] = @Original_IdGrupo) AND ((@IsNull_Grupo = " +
    "1 AND [Grupo] IS NULL) OR ([Grupo] = @Original_Grupo)))";
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdGrupo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(1)), "IdGrupo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grupo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grupo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grupo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grupo", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [Grupo] ([IdGrupo], [Grupo]) VALUES (@IdGrupo, @Grupo);\r\nSELECT IdGru" +
    "po, Grupo FROM Grupo WHERE (IdGrupo = @IdGrupo) ORDER BY IdGrupo";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdGrupo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(1)), "IdGrupo", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Grupo", System.Data.SqlDbType.NVarChar, 0, "Grupo")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     IdGrupo, Grupo\r\nFROM         Grupo\r\nORDER BY IdGrupo";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdGrupo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(1)), "IdGrupo", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Grupo", System.Data.SqlDbType.NVarChar, 0, "Grupo"),
            new System.Data.SqlClient.SqlParameter("@Original_IdGrupo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(1)), "IdGrupo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grupo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grupo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grupo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grupo", System.Data.DataRowVersion.Original, null)});
            // 
            // dsGruposR1
            // 
            this.dsGruposR1.DataSetName = "dsGruposR";
            this.dsGruposR1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtGrupos);
            this.panel2.Controls.Add(this.lblIdBascula);
            this.panel2.Controls.Add(this.txtGrupo);
            this.panel2.Location = new System.Drawing.Point(13, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 65);
            this.panel2.TabIndex = 4;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 750;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsGruposR1.Grupo;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(308, 3);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Grupo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGrupos
            // 
            this.txtGrupos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGruposR1, "Grupo.Grupo", true));
            this.txtGrupos.Location = new System.Drawing.Point(77, 27);
            this.txtGrupos.MaxLength = 50;
            this.txtGrupos.Name = "txtGrupos";
            this.txtGrupos.Size = new System.Drawing.Size(225, 20);
            this.txtGrupos.TabIndex = 100;
            this.txtGrupos.Text = "textBox2";
            // 
            // lblIdBascula
            // 
            this.lblIdBascula.AutoSize = true;
            this.lblIdBascula.Location = new System.Drawing.Point(28, 8);
            this.lblIdBascula.Name = "lblIdBascula";
            this.lblIdBascula.Size = new System.Drawing.Size(48, 13);
            this.lblIdBascula.TabIndex = 97;
            this.lblIdBascula.Text = "IdGrupo:";
            this.lblIdBascula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGrupo
            // 
            this.txtGrupo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGruposR1, "Grupo.IdGrupo", true));
            this.txtGrupo.Location = new System.Drawing.Point(77, 4);
            this.txtGrupo.MaxLength = 5;
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(56, 20);
            this.txtGrupo.TabIndex = 98;
            this.txtGrupo.Text = "textBox1";
            this.txtGrupo.TextChanged += new System.EventHandler(this.txtGrupo_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dGVObras);
            this.panel3.Location = new System.Drawing.Point(13, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 453);
            this.panel3.TabIndex = 5;
            // 
            // sqlDAGrObra
            // 
            this.sqlDAGrObra.DeleteCommand = this.sqlCommand1;
            this.sqlDAGrObra.InsertCommand = this.sqlCommand2;
            this.sqlDAGrObra.SelectCommand = this.sqlCommand3;
            this.sqlDAGrObra.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "GrupoObra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdGrupo", "IdGrupo"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra")})});
            this.sqlDAGrObra.UpdateCommand = this.sqlCommand4;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "DELETE FROM [GrupoObra] WHERE (([IdGrupo] = @Original_IdGrupo) AND ([IdObra] = @O" +
    "riginal_IdObra))";
            this.sqlCommand1.Connection = this.sqlConn;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdGrupo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(1)), "IdGrupo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "INSERT INTO [GrupoObra] ([IdGrupo], [IdObra]) VALUES (@IdGrupo, @IdObra);\r\nSELECT" +
    " IdGrupo, IdObra FROM GrupoObra WHERE (IdGrupo = @IdGrupo) AND (IdObra = @IdObra" +
    ") ORDER BY IdGrupo";
            this.sqlCommand2.Connection = this.sqlConn;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdGrupo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(1)), "IdGrupo", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra")});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "SELECT     IdGrupo, IdObra\r\nFROM         GrupoObra\r\nWHERE     (IdGrupo = @IdGrupo" +
    ")\r\nORDER BY IdGrupo";
            this.sqlCommand3.Connection = this.sqlConn;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdGrupo", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(1)), "IdGrupo", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = resources.GetString("sqlCommand4.CommandText");
            this.sqlCommand4.Connection = this.sqlConn;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdGrupo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(1)), "IdGrupo", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Original_IdGrupo", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(1)), "IdGrupo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null)});
            // 
            // dGVObras
            // 
            this.dGVObras.AutoGenerateColumns = false;
            this.dGVObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVObras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGrupoDataGridViewTextBoxColumn,
            this.idObraDataGridViewTextBoxColumn});
            this.dGVObras.DataMember = "Grupo.Grupo_GrupoObra";
            this.dGVObras.DataSource = this.dsGruposR1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVObras.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGVObras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVObras.Location = new System.Drawing.Point(0, 0);
            this.dGVObras.Name = "dGVObras";
            this.dGVObras.Size = new System.Drawing.Size(575, 449);
            this.dGVObras.TabIndex = 0;
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDABusObra
            // 
            this.sqlDABusObra.SelectCommand = this.sqlCommand5;
            this.sqlDABusObra.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SELECT Obra.Idobra, Obra.Ubicacion, Obra.RFC, Razonsocial.Facturar FROM Obra LEFT" +
    " OUTER JOIN Razonsocial ON Obra.IdCliente = Razonsocial.IdCliente AND Obra.RFC =" +
    " Razonsocial.RFC ORDER BY Obra.Idobra";
            this.sqlCommand5.Connection = this.sqlConn;
            // 
            // idGrupoDataGridViewTextBoxColumn
            // 
            this.idGrupoDataGridViewTextBoxColumn.DataPropertyName = "IdGrupo";
            this.idGrupoDataGridViewTextBoxColumn.HeaderText = "IdGrupo";
            this.idGrupoDataGridViewTextBoxColumn.Name = "idGrupoDataGridViewTextBoxColumn";
            this.idGrupoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idObraDataGridViewTextBoxColumn
            // 
            this.idObraDataGridViewTextBoxColumn.DataPropertyName = "IdObra";
            this.idObraDataGridViewTextBoxColumn.DataSource = this.dsBusObra1;
            this.idObraDataGridViewTextBoxColumn.DisplayMember = "Obra.Idobra";
            this.idObraDataGridViewTextBoxColumn.HeaderText = "IdObra";
            this.idObraDataGridViewTextBoxColumn.Name = "idObraDataGridViewTextBoxColumn";
            this.idObraDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idObraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idObraDataGridViewTextBoxColumn.ValueMember = "Obra.Idobra";
            this.idObraDataGridViewTextBoxColumn.Width = 120;
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 623);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAGrupo;
            this.dsGeneral = this.dsGruposR1;
            this.Name = "Grupos";
            this.NombreTabla = "Grupo";
            this.Text = "Grupos";
            this.Load += new System.EventHandler(this.Grupos_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsGruposR1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVObras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Data.SqlClient.SqlConnection sqlConn;
        private System.Data.SqlClient.SqlDataAdapter sqlDAGrupo;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private dsGruposR dsGruposR1;
        private System.Windows.Forms.Panel panel2;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrupos;
        private System.Windows.Forms.Label lblIdBascula;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Panel panel3;
        private System.Data.SqlClient.SqlDataAdapter sqlDAGrObra;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Windows.Forms.DataGridView dGVObras;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idObraDataGridViewTextBoxColumn;
        private dsBusObra dsBusObra1;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
    }
}