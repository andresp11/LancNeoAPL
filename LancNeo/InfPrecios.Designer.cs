namespace LancNeo
{
    partial class InfPrecios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfPrecios));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.chkRecortado = new System.Windows.Forms.CheckBox();
            this.chkOpciones = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtRz = new System.Windows.Forms.RadioButton();
            this.rbtSe = new System.Windows.Forms.RadioButton();
            this.rbtLp = new System.Windows.Forms.RadioButton();
            this.chechkTodos = new System.Windows.Forms.CheckBox();
            this.chkCaratula = new System.Windows.Forms.CheckBox();
            this.TxtVigenccia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDABusPrecio = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsBusPrecio1 = new LancNeo.dsBusPrecio();
            this.sqlDAInfPrecios = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAPreDet = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.crvInfPrecios = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.elegidoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idPrecioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsInfPrecios1 = new LancNeo.dsInfPrecios();
            this.cryInfPrecios1 = new LancNeo.CryInfPrecios();
            this.cryInfPreciosR1 = new LancNeo.CryInfPreciosR();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusPrecio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfPrecios1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnVistaPrevia);
            this.panel2.Controls.Add(this.chkActivo);
            this.panel2.Controls.Add(this.chkRecortado);
            this.panel2.Controls.Add(this.chkOpciones);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.chechkTodos);
            this.panel2.Controls.Add(this.chkCaratula);
            this.panel2.Controls.Add(this.TxtVigenccia);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 71);
            this.panel2.TabIndex = 10;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(839, 3);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 63);
            this.btnVistaPrevia.TabIndex = 59;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // chkRecortado
            // 
            this.chkRecortado.AutoSize = true;
            this.chkRecortado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRecortado.ForeColor = System.Drawing.Color.White;
            this.chkRecortado.Location = new System.Drawing.Point(341, 37);
            this.chkRecortado.Name = "chkRecortado";
            this.chkRecortado.Size = new System.Drawing.Size(85, 17);
            this.chkRecortado.TabIndex = 93;
            this.chkRecortado.Text = "Recortado";
            this.chkRecortado.UseVisualStyleBackColor = true;
            // 
            // chkOpciones
            // 
            this.chkOpciones.AutoSize = true;
            this.chkOpciones.Checked = true;
            this.chkOpciones.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOpciones.ForeColor = System.Drawing.Color.White;
            this.chkOpciones.Location = new System.Drawing.Point(14, 36);
            this.chkOpciones.Name = "chkOpciones";
            this.chkOpciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkOpciones.Size = new System.Drawing.Size(79, 17);
            this.chkOpciones.TabIndex = 92;
            this.chkOpciones.Text = "Opciones";
            this.chkOpciones.UseVisualStyleBackColor = true;
            this.chkOpciones.CheckedChanged += new System.EventHandler(this.chkOpciones_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtRz);
            this.groupBox1.Controls.Add(this.rbtSe);
            this.groupBox1.Controls.Add(this.rbtLp);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(557, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 54);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro presupuesto";
            // 
            // rbtRz
            // 
            this.rbtRz.AutoSize = true;
            this.rbtRz.Location = new System.Drawing.Point(180, 23);
            this.rbtRz.Name = "rbtRz";
            this.rbtRz.Size = new System.Drawing.Size(73, 17);
            this.rbtRz.TabIndex = 2;
            this.rbtRz.Text = "Reporte Z";
            this.rbtRz.UseVisualStyleBackColor = true;
            this.rbtRz.CheckedChanged += new System.EventHandler(this.rbtSe_CheckedChanged);
            // 
            // rbtSe
            // 
            this.rbtSe.AutoSize = true;
            this.rbtSe.Location = new System.Drawing.Point(106, 23);
            this.rbtSe.Name = "rbtSe";
            this.rbtSe.Size = new System.Drawing.Size(68, 17);
            this.rbtSe.TabIndex = 1;
            this.rbtSe.Text = "Servicios";
            this.rbtSe.UseVisualStyleBackColor = true;
            this.rbtSe.CheckedChanged += new System.EventHandler(this.rbtSe_CheckedChanged);
            // 
            // rbtLp
            // 
            this.rbtLp.AutoSize = true;
            this.rbtLp.Checked = true;
            this.rbtLp.Location = new System.Drawing.Point(6, 23);
            this.rbtLp.Name = "rbtLp";
            this.rbtLp.Size = new System.Drawing.Size(99, 17);
            this.rbtLp.TabIndex = 0;
            this.rbtLp.TabStop = true;
            this.rbtLp.Text = "Lista de precios";
            this.rbtLp.UseVisualStyleBackColor = true;
            this.rbtLp.CheckedChanged += new System.EventHandler(this.rbtSe_CheckedChanged);
            // 
            // chechkTodos
            // 
            this.chechkTodos.AutoSize = true;
            this.chechkTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chechkTodos.ForeColor = System.Drawing.Color.White;
            this.chechkTodos.Location = new System.Drawing.Point(230, 36);
            this.chechkTodos.Name = "chechkTodos";
            this.chechkTodos.Size = new System.Drawing.Size(104, 17);
            this.chechkTodos.TabIndex = 62;
            this.chechkTodos.Text = "Imprime todos";
            this.chechkTodos.UseVisualStyleBackColor = true;
            this.chechkTodos.CheckedChanged += new System.EventHandler(this.chechkTodos_CheckedChanged);
            // 
            // chkCaratula
            // 
            this.chkCaratula.AutoSize = true;
            this.chkCaratula.Checked = true;
            this.chkCaratula.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCaratula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCaratula.ForeColor = System.Drawing.Color.White;
            this.chkCaratula.Location = new System.Drawing.Point(105, 37);
            this.chkCaratula.Name = "chkCaratula";
            this.chkCaratula.Size = new System.Drawing.Size(119, 17);
            this.chkCaratula.TabIndex = 61;
            this.chkCaratula.Text = "Imprime caratula";
            this.chkCaratula.UseVisualStyleBackColor = true;
            // 
            // TxtVigenccia
            // 
            this.TxtVigenccia.Location = new System.Drawing.Point(188, 10);
            this.TxtVigenccia.Name = "TxtVigenccia";
            this.TxtVigenccia.Size = new System.Drawing.Size(254, 20);
            this.TxtVigenccia.TabIndex = 60;
            this.TxtVigenccia.Text = "VIGENCIA";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 24);
            this.label4.TabIndex = 54;
            this.label4.Text = "Lista de precios";
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDABusPrecio
            // 
            this.sqlDABusPrecio.SelectCommand = this.sqlSelectCommand1;
            this.sqlDABusPrecio.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Precio", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdPrecio", "IdPrecio"),
                        new System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"),
                        new System.Data.Common.DataColumnMapping("Elegido", "Elegido")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     IdPrecio, Descripcion, CONVERT(bit, \'1\') AS Elegido, Imprime\r\nFROM    " +
    "     Precio\r\nWHERE     (LEN(IdPrecio) < 4) AND (Imprime = 1)\r\nORDER BY CONVERT(d" +
    "ecimal, IdPrecio)";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // dsBusPrecio1
            // 
            this.dsBusPrecio1.DataSetName = "dsBusPrecio";
            this.dsBusPrecio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAInfPrecios
            // 
            this.sqlDAInfPrecios.SelectCommand = this.sqlCommand1;
            this.sqlDAInfPrecios.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Precio", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdPrecio", "IdPrecio"),
                        new System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("Metodo", "Metodo")})});
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "InfPrecios";
            this.sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand1.Connection = this.sqlConn;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Grupo", System.Data.SqlDbType.NVarChar, 3),
            new System.Data.SqlClient.SqlParameter("@Imprime", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@Descr", System.Data.SqlDbType.Int, 4)});
            // 
            // sqlDAPreDet
            // 
            this.sqlDAPreDet.SelectCommand = this.sqlCommand2;
            this.sqlDAPreDet.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Precio", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdPrecio", "IdPrecio"),
                        new System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"),
                        new System.Data.Common.DataColumnMapping("Unidad", "Unidad"),
                        new System.Data.Common.DataColumnMapping("Metodo", "Metodo")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = resources.GetString("sqlCommand2.CommandText");
            this.sqlCommand2.Connection = this.sqlConn;
            // 
            // crvInfPrecios
            // 
            this.crvInfPrecios.ActiveViewIndex = -1;
            this.crvInfPrecios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInfPrecios.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInfPrecios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInfPrecios.EnableRefresh = false;
            this.crvInfPrecios.Location = new System.Drawing.Point(0, 71);
            this.crvInfPrecios.Name = "crvInfPrecios";
            this.crvInfPrecios.ShowCloseButton = false;
            this.crvInfPrecios.ShowGroupTreeButton = false;
            this.crvInfPrecios.ShowLogo = false;
            this.crvInfPrecios.Size = new System.Drawing.Size(938, 401);
            this.crvInfPrecios.TabIndex = 13;
            this.crvInfPrecios.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvInfPrecios.ToolPanelWidth = 167;
            this.crvInfPrecios.Visible = false;
            this.crvInfPrecios.Load += new System.EventHandler(this.crvInfPrecios_Load);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.elegidoDataGridViewCheckBoxColumn,
            this.idPrecioDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Precio";
            this.dataGridView1.DataSource = this.dsInfPrecios1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 71);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(938, 401);
            this.dataGridView1.TabIndex = 11;
            // 
            // elegidoDataGridViewCheckBoxColumn
            // 
            this.elegidoDataGridViewCheckBoxColumn.DataPropertyName = "Elegido";
            this.elegidoDataGridViewCheckBoxColumn.HeaderText = "Elegido";
            this.elegidoDataGridViewCheckBoxColumn.Name = "elegidoDataGridViewCheckBoxColumn";
            // 
            // idPrecioDataGridViewTextBoxColumn
            // 
            this.idPrecioDataGridViewTextBoxColumn.DataPropertyName = "IdPrecio";
            this.idPrecioDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.idPrecioDataGridViewTextBoxColumn.Name = "idPrecioDataGridViewTextBoxColumn";
            this.idPrecioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 480;
            // 
            // dsInfPrecios1
            // 
            this.dsInfPrecios1.DataSetName = "dsInfPrecios";
            this.dsInfPrecios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.ForeColor = System.Drawing.Color.White;
            this.chkActivo.Location = new System.Drawing.Point(447, 36);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(62, 17);
            this.chkActivo.TabIndex = 94;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // InfPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 472);
            this.Controls.Add(this.crvInfPrecios);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "InfPrecios";
            this.Text = "InfPrecios";
            this.Load += new System.EventHandler(this.InfPrecios_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusPrecio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInfPrecios1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private System.Windows.Forms.Label label4;
        private System.Data.SqlClient.SqlConnection sqlConn;
        private System.Data.SqlClient.SqlDataAdapter sqlDABusPrecio;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private dsBusPrecio dsBusPrecio1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAInfPrecios;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAPreDet;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private dsInfPrecios dsInfPrecios1;
        private System.Windows.Forms.TextBox TxtVigenccia;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInfPrecios;
        private CryInfPrecios cryInfPrecios1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn elegidoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrecioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox chkCaratula;
        private System.Windows.Forms.CheckBox chechkTodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtRz;
        private System.Windows.Forms.RadioButton rbtSe;
        private System.Windows.Forms.RadioButton rbtLp;
        private System.Windows.Forms.CheckBox chkOpciones;
        private System.Windows.Forms.CheckBox chkRecortado;
        private CryInfPreciosR cryInfPreciosR1;
        private System.Windows.Forms.CheckBox chkActivo;
    }
}