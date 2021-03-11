namespace LancNeo
{
    partial class CatServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatServicios));
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDACatServicios = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblIdBascula = new System.Windows.Forms.Label();
            this.lblBascula = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dsCatServicios1 = new LancNeo.dsCatServicios();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCatServicios1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 440);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(592, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(592, 64);
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDACatServicios
            // 
            this.sqlDACatServicios.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDACatServicios.InsertCommand = this.sqlInsertCommand1;
            this.sqlDACatServicios.SelectCommand = this.sqlSelectCommand1;
            this.sqlDACatServicios.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CatServicios", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdServicio", "IdServicio"),
                        new System.Data.Common.DataColumnMapping("Descripción", "Descripción")})});
            this.sqlDACatServicios.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [CatServicios] WHERE (([IdServicio] = @Original_IdServicio) AND ([Des" +
    "cripción] = @Original_Descripción))";
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdServicio", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdServicio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Descripción", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Descripción", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [CatServicios] ([IdServicio], [Descripción]) VALUES (@IdServicio, @De" +
    "scripción);\r\nSELECT IdServicio, Descripción FROM CatServicios WHERE (IdServicio " +
    "= @IdServicio) ORDER BY IdServicio";
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdServicio", System.Data.SqlDbType.SmallInt, 0, "IdServicio"),
            new System.Data.SqlClient.SqlParameter("@Descripción", System.Data.SqlDbType.NChar, 0, "Descripción")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     IdServicio, Descripción\r\nFROM         CatServicios\r\nORDER BY IdServici" +
    "o";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdServicio", System.Data.SqlDbType.SmallInt, 0, "IdServicio"),
            new System.Data.SqlClient.SqlParameter("@Descripción", System.Data.SqlDbType.NChar, 0, "Descripción"),
            new System.Data.SqlClient.SqlParameter("@Original_IdServicio", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdServicio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Descripción", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Descripción", System.Data.DataRowVersion.Original, null)});
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.lblIdBascula);
            this.panel2.Controls.Add(this.lblBascula);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(74, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 186);
            this.panel2.TabIndex = 4;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 0;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsCatServicios1.CatServicios;
            this.buscaBtn1.ForeColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(181, 7);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 10;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCatServicios1, "CatServicios.Descripción", true));
            this.textBox2.Location = new System.Drawing.Point(117, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "textBox1";
            // 
            // lblIdBascula
            // 
            this.lblIdBascula.Location = new System.Drawing.Point(37, 39);
            this.lblIdBascula.Name = "lblIdBascula";
            this.lblIdBascula.Size = new System.Drawing.Size(72, 23);
            this.lblIdBascula.TabIndex = 7;
            this.lblIdBascula.Text = "Id servicio:";
            this.lblIdBascula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBascula
            // 
            this.lblBascula.Location = new System.Drawing.Point(37, 79);
            this.lblBascula.Name = "lblBascula";
            this.lblBascula.Size = new System.Drawing.Size(72, 23);
            this.lblBascula.TabIndex = 6;
            this.lblBascula.Text = "Servicio:";
            this.lblBascula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCatServicios1, "CatServicios.IdServicio", true));
            this.textBox1.Location = new System.Drawing.Point(117, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "textBox1";
            // 
            // dsCatServicios1
            // 
            this.dsCatServicios1.DataSetName = "dsCatServicios";
            this.dsCatServicios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CatServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 462);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDACatServicios;
            this.dsGeneral = this.dsCatServicios1;
            this.Name = "CatServicios";
            this.NombreTabla = "CaTServicios";
            this.Text = "CatServicios";
            this.Load += new System.EventHandler(this.CatServicios_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCatServicios1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConn;
        private System.Data.SqlClient.SqlDataAdapter sqlDACatServicios;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Windows.Forms.Panel panel2;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblIdBascula;
        private System.Windows.Forms.Label lblBascula;
        private System.Windows.Forms.TextBox textBox1;
        private dsCatServicios dsCatServicios1;
    }
}