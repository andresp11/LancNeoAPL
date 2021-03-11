namespace LancNeo
{
    partial class ClaveCob
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClaveCob));
            this.dGVHoja = new System.Windows.Forms.DataGridView();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDAHoja = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsHoja1 = new LancNeo.dsHoja();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.claveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHoja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoja1)).BeginInit();
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
            // dGVHoja
            // 
            this.dGVHoja.AutoGenerateColumns = false;
            this.dGVHoja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHoja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claveDataGridViewTextBoxColumn,
            this.obraDataGridViewTextBoxColumn});
            this.dGVHoja.DataMember = "Hoja1$";
            this.dGVHoja.DataSource = this.dsHoja1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVHoja.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGVHoja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVHoja.Location = new System.Drawing.Point(0, 64);
            this.dGVHoja.Name = "dGVHoja";
            this.dGVHoja.Size = new System.Drawing.Size(613, 537);
            this.dGVHoja.TabIndex = 4;
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDAHoja
            // 
            this.sqlDAHoja.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAHoja.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAHoja.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAHoja.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Hoja1$", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Clave", "Clave"),
                        new System.Data.Common.DataColumnMapping("Obra", "Obra")})});
            this.sqlDAHoja.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [Hoja1$] WHERE (([Clave] = @Original_Clave) AND ((@IsNull_Obra = 1 AN" +
    "D [Obra] IS NULL) OR ([Obra] = @Original_Obra)))";
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Clave", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Clave", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Obra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Obra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Obra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Obra", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [Hoja1$] ([Clave], [Obra]) VALUES (@Clave, @Obra);\r\nSELECT Clave, Obr" +
    "a FROM Hoja1$ WHERE (Clave = @Clave) ORDER BY Clave, Obra";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Clave", System.Data.SqlDbType.NVarChar, 0, "Clave"),
            new System.Data.SqlClient.SqlParameter("@Obra", System.Data.SqlDbType.NVarChar, 0, "Obra")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     Clave, Obra\r\nFROM         Hoja1$\r\nORDER BY Clave, Obra";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Clave", System.Data.SqlDbType.NVarChar, 0, "Clave"),
            new System.Data.SqlClient.SqlParameter("@Obra", System.Data.SqlDbType.NVarChar, 0, "Obra"),
            new System.Data.SqlClient.SqlParameter("@Original_Clave", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Clave", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Obra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Obra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Obra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Obra", System.Data.DataRowVersion.Original, null)});
            // 
            // dsHoja1
            // 
            this.dsHoja1.DataSetName = "dsHoja";
            this.dsHoja1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // claveDataGridViewTextBoxColumn
            // 
            this.claveDataGridViewTextBoxColumn.DataPropertyName = "Clave";
            this.claveDataGridViewTextBoxColumn.HeaderText = "Clave";
            this.claveDataGridViewTextBoxColumn.Name = "claveDataGridViewTextBoxColumn";
            // 
            // obraDataGridViewTextBoxColumn
            // 
            this.obraDataGridViewTextBoxColumn.DataPropertyName = "Obra";
            this.obraDataGridViewTextBoxColumn.DataSource = this.dsBusObra1;
            this.obraDataGridViewTextBoxColumn.DisplayMember = "Obra.Idobra";
            this.obraDataGridViewTextBoxColumn.HeaderText = "Obra";
            this.obraDataGridViewTextBoxColumn.Name = "obraDataGridViewTextBoxColumn";
            this.obraDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.obraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.obraDataGridViewTextBoxColumn.ValueMember = "Obra.Idobra";
            // 
            // ClaveCob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 623);
            this.Controls.Add(this.dGVHoja);
            this.DAGeneral = this.sqlDAHoja;
            this.dsGeneral = this.dsHoja1;
            this.Name = "ClaveCob";
            this.NombreTabla = "Hoja1$";
            this.Text = "ClaveCob";
            this.Load += new System.EventHandler(this.ClaveCob_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.dGVHoja, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVHoja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoja1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVHoja;
        public System.Data.SqlClient.SqlConnection sqlConn;
        private System.Data.SqlClient.SqlDataAdapter sqlDAHoja;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private dsHoja dsHoja1;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn obraDataGridViewTextBoxColumn;
        private dsBusObra dsBusObra1;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
    }
}