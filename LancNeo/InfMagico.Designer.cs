namespace LancNeo
{
    partial class InfMagico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfMagico));
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDAInfMagico = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.chkAbreviado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dTPHoy = new System.Windows.Forms.DateTimePicker();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdbContrato = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.crvRepTarjeta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dsInfMagico1 = new LancNeo.dsInfMagico();
            this.cryInfMagico1 = new LancNeo.CryInfMagico();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfMagico1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDAInfMagico
            // 
            this.sqlDAInfMagico.SelectCommand = this.sqlCommand2;
            this.sqlDAInfMagico.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "InfMagico";
            this.sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand2.Connection = this.sqlConn;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@TipoObra", System.Data.SqlDbType.Bit, 1),
            new System.Data.SqlClient.SqlParameter("@Dias", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@Hoy", System.Data.SqlDbType.SmallDateTime, 4),
            new System.Data.SqlClient.SqlParameter("@Abreviado", System.Data.SqlDbType.Bit, 1)});
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnVistaPrevia);
            this.panel2.Controls.Add(this.chkAbreviado);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dTPHoy);
            this.panel2.Controls.Add(this.txtDias);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 79);
            this.panel2.TabIndex = 12;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(751, 5);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 63);
            this.btnVistaPrevia.TabIndex = 59;
            this.btnVistaPrevia.Visible = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // chkAbreviado
            // 
            this.chkAbreviado.AutoSize = true;
            this.chkAbreviado.Checked = true;
            this.chkAbreviado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAbreviado.ForeColor = System.Drawing.Color.White;
            this.chkAbreviado.Location = new System.Drawing.Point(582, 19);
            this.chkAbreviado.Name = "chkAbreviado";
            this.chkAbreviado.Size = new System.Drawing.Size(74, 17);
            this.chkAbreviado.TabIndex = 64;
            this.chkAbreviado.Text = "Abreviado";
            this.chkAbreviado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(294, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Informe a:";
            // 
            // dTPHoy
            // 
            this.dTPHoy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPHoy.Location = new System.Drawing.Point(348, 51);
            this.dTPHoy.Name = "dTPHoy";
            this.dTPHoy.Size = new System.Drawing.Size(86, 20);
            this.dTPHoy.TabIndex = 62;
            this.dTPHoy.ValueChanged += new System.EventHandler(this.dTPHoy_ValueChanged);
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(515, 51);
            this.txtDias.MaxLength = 3;
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(32, 20);
            this.txtDias.TabIndex = 61;
            this.txtDias.Text = "30";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rdbContrato);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(348, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 37);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de obra";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(112, 15);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Mostrador";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdbContrato
            // 
            this.rdbContrato.AutoSize = true;
            this.rdbContrato.Checked = true;
            this.rdbContrato.Location = new System.Drawing.Point(13, 15);
            this.rdbContrato.Name = "rdbContrato";
            this.rdbContrato.Size = new System.Drawing.Size(65, 17);
            this.rdbContrato.TabIndex = 0;
            this.rdbContrato.TabStop = true;
            this.rdbContrato.Text = "Contrato";
            this.rdbContrato.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(436, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Días anteriores:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 56);
            this.label4.TabIndex = 54;
            this.label4.Text = "Informe concentrado de obras (Mágico)";
            // 
            // crvRepTarjeta
            // 
            this.crvRepTarjeta.ActiveViewIndex = -1;
            this.crvRepTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRepTarjeta.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRepTarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRepTarjeta.EnableRefresh = false;
            this.crvRepTarjeta.Location = new System.Drawing.Point(0, 79);
            this.crvRepTarjeta.Name = "crvRepTarjeta";
            this.crvRepTarjeta.ShowCloseButton = false;
            this.crvRepTarjeta.ShowGroupTreeButton = false;
            this.crvRepTarjeta.ShowLogo = false;
            this.crvRepTarjeta.Size = new System.Drawing.Size(920, 299);
            this.crvRepTarjeta.TabIndex = 14;
            this.crvRepTarjeta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvRepTarjeta.Visible = false;
            // 
            // dsInfMagico1
            // 
            this.dsInfMagico1.DataSetName = "dsInfMagico";
            this.dsInfMagico1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InfMagico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 378);
            this.Controls.Add(this.crvRepTarjeta);
            this.Controls.Add(this.panel2);
            this.Name = "InfMagico";
            this.Text = "InfMagico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfMagico1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConn;
        public System.Data.SqlClient.SqlDataAdapter sqlDAInfMagico;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.Panel panel2;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRepTarjeta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdbContrato;
        private System.Windows.Forms.TextBox txtDias;
        private dsInfMagico dsInfMagico1;
        private CryInfMagico cryInfMagico1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTPHoy;
        private System.Windows.Forms.CheckBox chkAbreviado;
    }
}