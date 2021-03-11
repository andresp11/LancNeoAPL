namespace LancNeo
{
    partial class Vivienda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vivienda));
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.dGVVivienda = new System.Windows.Forms.DataGridView();
            this.idObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viviendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsVivienda1 = new LancNeo.dsVivienda();
            this.sqlDAVivienda = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.lblIdObra = new System.Windows.Forms.Label();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVVivienda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVivienda1)).BeginInit();
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
            // dGVVivienda
            // 
            this.dGVVivienda.AutoGenerateColumns = false;
            this.dGVVivienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVVivienda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObraDataGridViewTextBoxColumn,
            this.añoDataGridViewTextBoxColumn,
            this.semanaDataGridViewTextBoxColumn,
            this.viviendaDataGridViewTextBoxColumn});
            this.dGVVivienda.DataMember = "Vivienda";
            this.dGVVivienda.DataSource = this.dsVivienda1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVVivienda.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGVVivienda.Location = new System.Drawing.Point(0, 107);
            this.dGVVivienda.Name = "dGVVivienda";
            this.dGVVivienda.Size = new System.Drawing.Size(613, 444);
            this.dGVVivienda.TabIndex = 5;
            this.dGVVivienda.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dGVVivienda_DefaultValuesNeeded);
            // 
            // idObraDataGridViewTextBoxColumn
            // 
            this.idObraDataGridViewTextBoxColumn.DataPropertyName = "IdObra";
            this.idObraDataGridViewTextBoxColumn.HeaderText = "IdObra";
            this.idObraDataGridViewTextBoxColumn.Name = "idObraDataGridViewTextBoxColumn";
            this.idObraDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // añoDataGridViewTextBoxColumn
            // 
            this.añoDataGridViewTextBoxColumn.DataPropertyName = "Año";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.añoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.añoDataGridViewTextBoxColumn.HeaderText = "Año";
            this.añoDataGridViewTextBoxColumn.MaxInputLength = 4;
            this.añoDataGridViewTextBoxColumn.Name = "añoDataGridViewTextBoxColumn";
            // 
            // semanaDataGridViewTextBoxColumn
            // 
            this.semanaDataGridViewTextBoxColumn.DataPropertyName = "Semana";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.semanaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.semanaDataGridViewTextBoxColumn.HeaderText = "Semana";
            this.semanaDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.semanaDataGridViewTextBoxColumn.Name = "semanaDataGridViewTextBoxColumn";
            // 
            // viviendaDataGridViewTextBoxColumn
            // 
            this.viviendaDataGridViewTextBoxColumn.DataPropertyName = "Vivienda";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.viviendaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.viviendaDataGridViewTextBoxColumn.HeaderText = "Vivienda";
            this.viviendaDataGridViewTextBoxColumn.MaxInputLength = 5;
            this.viviendaDataGridViewTextBoxColumn.Name = "viviendaDataGridViewTextBoxColumn";
            // 
            // dsVivienda1
            // 
            this.dsVivienda1.DataSetName = "dsVivienda";
            this.dsVivienda1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAVivienda
            // 
            this.sqlDAVivienda.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAVivienda.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAVivienda.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAVivienda.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Vivienda", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Año", "Año"),
                        new System.Data.Common.DataColumnMapping("Semana", "Semana"),
                        new System.Data.Common.DataColumnMapping("Vivienda", "Vivienda")})});
            this.sqlDAVivienda.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Año", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Año", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Vivienda", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Vivienda", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Vivienda", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vivienda", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 0, "Año"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 0, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Vivienda", System.Data.SqlDbType.SmallInt, 0, "Vivienda")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     IdObra, Año, Semana, Vivienda\r\nFROM         Vivienda\r\nWHERE     (IdObr" +
    "a = @IdObra)\r\nORDER BY IdObra";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.SmallInt, 0, "Año"),
            new System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.SmallInt, 0, "Semana"),
            new System.Data.SqlClient.SqlParameter("@Vivienda", System.Data.SqlDbType.SmallInt, 0, "Vivienda"),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Año", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Año", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Semana", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Vivienda", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Vivienda", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Vivienda", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vivienda", System.Data.DataRowVersion.Original, null)});
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(102, 74);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(66, 21);
            this.cmbIdObra.TabIndex = 7;
            this.cmbIdObra.Tag = "";
            this.cmbIdObra.ValueMember = "Obra.Idobra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // lblIdObra
            // 
            this.lblIdObra.AutoSize = true;
            this.lblIdObra.Location = new System.Drawing.Point(58, 78);
            this.lblIdObra.Name = "lblIdObra";
            this.lblIdObra.Size = new System.Drawing.Size(42, 13);
            this.lblIdObra.TabIndex = 6;
            this.lblIdObra.Text = "IdObra:";
            this.lblIdObra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Vivienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 623);
            this.Controls.Add(this.cmbIdObra);
            this.Controls.Add(this.lblIdObra);
            this.Controls.Add(this.dGVVivienda);
            this.DAGeneral = this.sqlDAVivienda;
            this.dsGeneral = this.dsVivienda1;
            this.Name = "Vivienda";
            this.NombreTabla = "Vivienda";
            this.Text = "Vivienda";
            this.Load += new System.EventHandler(this.Vivienda_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.dGVVivienda, 0);
            this.Controls.SetChildIndex(this.lblIdObra, 0);
            this.Controls.SetChildIndex(this.cmbIdObra, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVVivienda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVivienda1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Data.SqlClient.SqlConnection sqlConn;
        private dsBusObra dsBusObra1;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
        private System.Windows.Forms.DataGridView dGVVivienda;
        private dsVivienda dsVivienda1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAVivienda;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Windows.Forms.ComboBox cmbIdObra;
        private System.Windows.Forms.Label lblIdObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viviendaDataGridViewTextBoxColumn;
    }
}