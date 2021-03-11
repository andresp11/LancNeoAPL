namespace LancNeo
{
    partial class InfoPD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoPD));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.sqlDABusImagen = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.dsBusImagen1 = new LancNeo.dsBusImagen();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPROCESO = new Soluciones2000.Tools.WinLib.tbBtn();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.txtUsrMov = new System.Windows.Forms.TextBox();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.folioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoInf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fmuestreoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Archivo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusImagen1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDABusImagen
            // 
            this.sqlDABusImagen.SelectCommand = this.sqlSelectCommand1;
            this.sqlDABusImagen.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Imagen", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Folio", "Folio"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("Fmuestreo", "Fmuestreo"),
                        new System.Data.Common.DataColumnMapping("TipoInf", "TipoInf"),
                        new System.Data.Common.DataColumnMapping("Archivo", "Archivo"),
                        new System.Data.Common.DataColumnMapping("Imagen", "Imagen")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
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
            // dsBusImagen1
            // 
            this.dsBusImagen1.DataSetName = "dsBusImagen";
            this.dsBusImagen1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnPROCESO);
            this.panel2.Controls.Add(this.btnVistaPrevia);
            this.panel2.Controls.Add(this.txtUsrMov);
            this.panel2.Controls.Add(this.cmbIdObra);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 95);
            this.panel2.TabIndex = 9;
            // 
            // btnPROCESO
            // 
            this.btnPROCESO.BackColor = System.Drawing.Color.Transparent;
            this.btnPROCESO.Icon = ((System.Drawing.Icon)(resources.GetObject("btnPROCESO.Icon")));
            this.btnPROCESO.Location = new System.Drawing.Point(464, 3);
            this.btnPROCESO.Name = "btnPROCESO";
            this.btnPROCESO.Size = new System.Drawing.Size(64, 64);
            this.btnPROCESO.TabIndex = 60;
            this.btnPROCESO.Visible = false;
            this.btnPROCESO.Click += new System.EventHandler(this.btnPROCESO_Click);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(346, 1);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 63);
            this.btnVistaPrevia.TabIndex = 59;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // txtUsrMov
            // 
            this.txtUsrMov.Location = new System.Drawing.Point(66, 60);
            this.txtUsrMov.Name = "txtUsrMov";
            this.txtUsrMov.Size = new System.Drawing.Size(56, 20);
            this.txtUsrMov.TabIndex = 102;
            this.txtUsrMov.Visible = false;
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(250, 13);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObra.TabIndex = 57;
            this.cmbIdObra.ValueMember = "IdObra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(217, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Obra:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 56);
            this.label4.TabIndex = 54;
            this.label4.Text = "Pruebas no destructivas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folioDataGridViewTextBoxColumn,
            this.TipoInf,
            this.consObraDataGridViewTextBoxColumn,
            this.fmuestreoDataGridViewTextBoxColumn,
            this.Archivo});
            this.dataGridView1.DataMember = "Imagen";
            this.dataGridView1.DataSource = this.dsBusImagen1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 95);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(613, 229);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // folioDataGridViewTextBoxColumn
            // 
            this.folioDataGridViewTextBoxColumn.DataPropertyName = "Folio";
            this.folioDataGridViewTextBoxColumn.HeaderText = "Folio";
            this.folioDataGridViewTextBoxColumn.Name = "folioDataGridViewTextBoxColumn";
            this.folioDataGridViewTextBoxColumn.ReadOnly = true;
            this.folioDataGridViewTextBoxColumn.Width = 70;
            // 
            // TipoInf
            // 
            this.TipoInf.DataPropertyName = "TipoInf";
            this.TipoInf.HeaderText = "TipoInf";
            this.TipoInf.Name = "TipoInf";
            this.TipoInf.ReadOnly = true;
            this.TipoInf.Width = 200;
            // 
            // consObraDataGridViewTextBoxColumn
            // 
            this.consObraDataGridViewTextBoxColumn.DataPropertyName = "ConsObra";
            this.consObraDataGridViewTextBoxColumn.HeaderText = "Consecutivo";
            this.consObraDataGridViewTextBoxColumn.Name = "consObraDataGridViewTextBoxColumn";
            this.consObraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fmuestreoDataGridViewTextBoxColumn
            // 
            this.fmuestreoDataGridViewTextBoxColumn.DataPropertyName = "Fmuestreo";
            this.fmuestreoDataGridViewTextBoxColumn.HeaderText = "Fmuestreo";
            this.fmuestreoDataGridViewTextBoxColumn.Name = "fmuestreoDataGridViewTextBoxColumn";
            this.fmuestreoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fmuestreoDataGridViewTextBoxColumn.Width = 70;
            // 
            // Archivo
            // 
            this.Archivo.DataPropertyName = "Archivo";
            this.Archivo.HeaderText = "Archivo";
            this.Archivo.Name = "Archivo";
            this.Archivo.ReadOnly = true;
            this.Archivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Archivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // InfoPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 324);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "InfoPD";
            this.Text = "InfoPD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InfoPD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusImagen1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlDataAdapter sqlDABusImagen;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private dsBusObra dsBusObra1;
        private dsBusImagen dsBusImagen1;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Panel panel2;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private System.Windows.Forms.ComboBox cmbIdObra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoInf;
        private System.Windows.Forms.DataGridViewTextBoxColumn consObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fmuestreoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Archivo;
        private System.Data.SqlClient.SqlConnection sqlConn;
        protected Soluciones2000.Tools.WinLib.tbBtn btnPROCESO;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtUsrMov;
    }
}