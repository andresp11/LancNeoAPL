namespace LancNeo
{
    partial class EspPro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EspPro));
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsEspPro1 = new LancNeo.dsEspPro();
            this.dgEspPro = new System.Windows.Forms.DataGridView();
            this.sqlDAEspecimen = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.idObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consecutivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEspecimenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEnsayeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fensayeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vapor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLaboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoEco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPrueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsEspPro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEspPro)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 580);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(672, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(672, 64);
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsEspPro1
            // 
            this.dsEspPro1.DataSetName = "dsEspPro";
            this.dsEspPro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgEspPro
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgEspPro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEspPro.AutoGenerateColumns = false;
            this.dgEspPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEspPro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObraDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.consecutivoDataGridViewTextBoxColumn,
            this.idEspecimenDataGridViewTextBoxColumn,
            this.diaDataGridViewTextBoxColumn,
            this.idEnsayeDataGridViewTextBoxColumn,
            this.fensayeDataGridViewTextBoxColumn,
            this.Vapor,
            this.IdLaboratorio,
            this.NoEco,
            this.IdPrueba,
            this.IdDiam});
            this.dgEspPro.DataMember = "Especimen";
            this.dgEspPro.DataSource = this.dsEspPro1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEspPro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgEspPro.Location = new System.Drawing.Point(7, 70);
            this.dgEspPro.Name = "dgEspPro";
            this.dgEspPro.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgEspPro.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgEspPro.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgEspPro.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgEspPro.Size = new System.Drawing.Size(653, 504);
            this.dgEspPro.TabIndex = 4;
            this.dgEspPro.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEspPro_CellValueChanged);
            this.dgEspPro.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgEspPro_DefaultValuesNeeded);
            // 
            // sqlDAEspecimen
            // 
            this.sqlDAEspecimen.DeleteCommand = this.sqlDeleteCommand;
            this.sqlDAEspecimen.InsertCommand = this.sqlInsertCommand;
            this.sqlDAEspecimen.SelectCommand = this.sqlSelectCommand5;
            this.sqlDAEspecimen.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Especimen", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Consecutivo", "Consecutivo"),
                        new System.Data.Common.DataColumnMapping("IdEspecimen", "IdEspecimen"),
                        new System.Data.Common.DataColumnMapping("Dia", "Dia"),
                        new System.Data.Common.DataColumnMapping("Vapor", "Vapor"),
                        new System.Data.Common.DataColumnMapping("IdLaboratorio", "IdLaboratorio"),
                        new System.Data.Common.DataColumnMapping("NoEco", "NoEco"),
                        new System.Data.Common.DataColumnMapping("IdPrueba", "IdPrueba"),
                        new System.Data.Common.DataColumnMapping("IdDiam", "IdDiam"),
                        new System.Data.Common.DataColumnMapping("IdEnsaye", "IdEnsaye"),
                        new System.Data.Common.DataColumnMapping("Fensaye", "Fensaye")})});
            this.sqlDAEspecimen.UpdateCommand = this.sqlUpdateCommand;
            // 
            // sqlDeleteCommand
            // 
            this.sqlDeleteCommand.CommandText = resources.GetString("sqlDeleteCommand.CommandText");
            this.sqlDeleteCommand.Connection = this.sqlConn;
            this.sqlDeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Consecutivo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdEspecimen", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdEspecimen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Dia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Vapor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vapor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdPrueba", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPrueba", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdDiam", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdDiam", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdEnsaye", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdEnsaye", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdEnsaye", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdEnsaye", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fensaye", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fensaye", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fensaye", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fensaye", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand
            // 
            this.sqlInsertCommand.CommandText = resources.GetString("sqlInsertCommand.CommandText");
            this.sqlInsertCommand.Connection = this.sqlConn;
            this.sqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@Consecutivo", System.Data.SqlDbType.SmallInt, 0, "Consecutivo"),
            new System.Data.SqlClient.SqlParameter("@IdEspecimen", System.Data.SqlDbType.SmallInt, 0, "IdEspecimen"),
            new System.Data.SqlClient.SqlParameter("@Dia", System.Data.SqlDbType.Int, 0, "Dia"),
            new System.Data.SqlClient.SqlParameter("@Vapor", System.Data.SqlDbType.Int, 0, "Vapor"),
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, "IdLaboratorio"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@IdPrueba", System.Data.SqlDbType.SmallInt, 0, "IdPrueba"),
            new System.Data.SqlClient.SqlParameter("@IdDiam", System.Data.SqlDbType.SmallInt, 0, "IdDiam"),
            new System.Data.SqlClient.SqlParameter("@IdEnsaye", System.Data.SqlDbType.SmallInt, 0, "IdEnsaye"),
            new System.Data.SqlClient.SqlParameter("@Fensaye", System.Data.SqlDbType.SmallDateTime, 0, "Fensaye")});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = resources.GetString("sqlSelectCommand5.CommandText");
            this.sqlSelectCommand5.Connection = this.sqlConn;
            this.sqlSelectCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha")});
            // 
            // sqlUpdateCommand
            // 
            this.sqlUpdateCommand.CommandText = resources.GetString("sqlUpdateCommand.CommandText");
            this.sqlUpdateCommand.Connection = this.sqlConn;
            this.sqlUpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"),
            new System.Data.SqlClient.SqlParameter("@Consecutivo", System.Data.SqlDbType.SmallInt, 0, "Consecutivo"),
            new System.Data.SqlClient.SqlParameter("@IdEspecimen", System.Data.SqlDbType.SmallInt, 0, "IdEspecimen"),
            new System.Data.SqlClient.SqlParameter("@Dia", System.Data.SqlDbType.Int, 0, "Dia"),
            new System.Data.SqlClient.SqlParameter("@Vapor", System.Data.SqlDbType.Int, 0, "Vapor"),
            new System.Data.SqlClient.SqlParameter("@IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, "IdLaboratorio"),
            new System.Data.SqlClient.SqlParameter("@NoEco", System.Data.SqlDbType.SmallInt, 0, "NoEco"),
            new System.Data.SqlClient.SqlParameter("@IdPrueba", System.Data.SqlDbType.SmallInt, 0, "IdPrueba"),
            new System.Data.SqlClient.SqlParameter("@IdDiam", System.Data.SqlDbType.SmallInt, 0, "IdDiam"),
            new System.Data.SqlClient.SqlParameter("@IdEnsaye", System.Data.SqlDbType.SmallInt, 0, "IdEnsaye"),
            new System.Data.SqlClient.SqlParameter("@Fensaye", System.Data.SqlDbType.SmallDateTime, 0, "Fensaye"),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Consecutivo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdEspecimen", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdEspecimen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Dia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Dia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Vapor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vapor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdLaboratorio", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdLaboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_NoEco", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoEco", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdPrueba", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPrueba", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdDiam", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdDiam", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdEnsaye", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdEnsaye", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdEnsaye", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdEnsaye", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fensaye", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fensaye", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fensaye", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fensaye", System.Data.DataRowVersion.Original, null)});
            // 
            // idObraDataGridViewTextBoxColumn
            // 
            this.idObraDataGridViewTextBoxColumn.DataPropertyName = "IdObra";
            this.idObraDataGridViewTextBoxColumn.HeaderText = "IdObra";
            this.idObraDataGridViewTextBoxColumn.MaxInputLength = 18;
            this.idObraDataGridViewTextBoxColumn.Name = "idObraDataGridViewTextBoxColumn";
            this.idObraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idObraDataGridViewTextBoxColumn.Width = 60;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 70;
            // 
            // consecutivoDataGridViewTextBoxColumn
            // 
            this.consecutivoDataGridViewTextBoxColumn.DataPropertyName = "Consecutivo";
            this.consecutivoDataGridViewTextBoxColumn.HeaderText = "Consecutivo";
            this.consecutivoDataGridViewTextBoxColumn.MaxInputLength = 5;
            this.consecutivoDataGridViewTextBoxColumn.Name = "consecutivoDataGridViewTextBoxColumn";
            this.consecutivoDataGridViewTextBoxColumn.Width = 70;
            // 
            // idEspecimenDataGridViewTextBoxColumn
            // 
            this.idEspecimenDataGridViewTextBoxColumn.DataPropertyName = "IdEspecimen";
            this.idEspecimenDataGridViewTextBoxColumn.HeaderText = "IdEspecimen";
            this.idEspecimenDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.idEspecimenDataGridViewTextBoxColumn.Name = "idEspecimenDataGridViewTextBoxColumn";
            this.idEspecimenDataGridViewTextBoxColumn.Width = 70;
            // 
            // diaDataGridViewTextBoxColumn
            // 
            this.diaDataGridViewTextBoxColumn.DataPropertyName = "Dia";
            this.diaDataGridViewTextBoxColumn.HeaderText = "Día";
            this.diaDataGridViewTextBoxColumn.MaxInputLength = 3;
            this.diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            this.diaDataGridViewTextBoxColumn.Width = 35;
            // 
            // idEnsayeDataGridViewTextBoxColumn
            // 
            this.idEnsayeDataGridViewTextBoxColumn.DataPropertyName = "IdEnsaye";
            this.idEnsayeDataGridViewTextBoxColumn.HeaderText = "IdEnsaye";
            this.idEnsayeDataGridViewTextBoxColumn.MaxInputLength = 2;
            this.idEnsayeDataGridViewTextBoxColumn.Name = "idEnsayeDataGridViewTextBoxColumn";
            this.idEnsayeDataGridViewTextBoxColumn.Width = 55;
            // 
            // fensayeDataGridViewTextBoxColumn
            // 
            this.fensayeDataGridViewTextBoxColumn.DataPropertyName = "Fensaye";
            this.fensayeDataGridViewTextBoxColumn.HeaderText = "Fensaye";
            this.fensayeDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.fensayeDataGridViewTextBoxColumn.Name = "fensayeDataGridViewTextBoxColumn";
            this.fensayeDataGridViewTextBoxColumn.Width = 70;
            // 
            // Vapor
            // 
            this.Vapor.DataPropertyName = "Vapor";
            this.Vapor.HeaderText = "Vapor";
            this.Vapor.Name = "Vapor";
            this.Vapor.Visible = false;
            // 
            // IdLaboratorio
            // 
            this.IdLaboratorio.DataPropertyName = "IdLaboratorio";
            this.IdLaboratorio.HeaderText = "IdLaboratorio";
            this.IdLaboratorio.MaxInputLength = 6;
            this.IdLaboratorio.Name = "IdLaboratorio";
            this.IdLaboratorio.Width = 70;
            // 
            // NoEco
            // 
            this.NoEco.DataPropertyName = "NoEco";
            this.NoEco.HeaderText = "Laboratorista";
            this.NoEco.MaxInputLength = 6;
            this.NoEco.Name = "NoEco";
            this.NoEco.Width = 70;
            // 
            // IdPrueba
            // 
            this.IdPrueba.DataPropertyName = "IdPrueba";
            this.IdPrueba.HeaderText = "IdPrueba";
            this.IdPrueba.Name = "IdPrueba";
            this.IdPrueba.Visible = false;
            // 
            // IdDiam
            // 
            this.IdDiam.DataPropertyName = "IdDiam";
            this.IdDiam.HeaderText = "IdDiam";
            this.IdDiam.Name = "IdDiam";
            this.IdDiam.Visible = false;
            // 
            // EspPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 602);
            this.Controls.Add(this.dgEspPro);
            this.DAGeneral = this.sqlDAEspecimen;
            this.dsGeneral = this.dsEspPro1;
            this.Name = "EspPro";
            this.NombreTabla = "Especimen";
            this.Text = "EspPro";
            this.Load += new System.EventHandler(this.EspPro_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.dgEspPro, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsEspPro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEspPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConn;
        private dsEspPro dsEspPro1;
        private System.Windows.Forms.DataGridView dgEspPro;
        private System.Data.SqlClient.SqlDataAdapter sqlDAEspecimen;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consecutivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEspecimenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEnsayeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fensayeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vapor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLaboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoEco;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPrueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDiam;
    }
}