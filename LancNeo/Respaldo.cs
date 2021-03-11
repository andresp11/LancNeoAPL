using System;
using System.IO;
using System.Configuration;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Media;
using System.Text;
using System.Threading;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;




namespace LancNeo
{
    /// <summary>
    /// Descripción breve de Respaldo.
    /// </summary>
    public class Respaldo : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Data.SqlClient.SqlConnection sqlConn;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObraO;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObraD;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.ComboBox cmbIdObraO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        protected Soluciones2000.Tools.WinLib.tbBtn tbBtn1;
        private LancNeo.dsRespaldoObra dsRespaldoObra1;
        private LancNeo.dsRespaldoObra dsRespaldoObra2;
        private System.Windows.Forms.Panel panel3;
        protected Soluciones2000.Tools.WinLib.tbBtn tbBtn2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Data.SqlClient.SqlCommand sqlComRespaldo;
        private System.Data.SqlClient.SqlCommand sqlComRestaura;
        private System.Data.SqlClient.SqlCommand sqlComBorra;
        private System.Data.SqlClient.SqlCommand sqlComBorracnal;
        private SaveFileDialog saveFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private CheckBox cBExportar;
        private CheckBox cBEliminar;
        private OpenFileDialog openFileDialog1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label1;
        private Label label10;
        private TextBox txtObra;
        private SqlConnection sqlConnM;
        private Label label11;
        private TextBox txtEliTrabajo;
        private Label label12;
        private TextBox txtNomObra;
        private Label label13;
        private CachedCryTarjeta cachedCryTarjeta1;
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Respaldo()
        {
            //
            // Necesario para admitir el Diseñador de Windows Forms
            //
            InitializeComponent();

            //
            // TODO: agregar código de constructor después de llamar a InitializeComponent
            //
        }

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms
        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Respaldo));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBExportar = new System.Windows.Forms.CheckBox();
            this.cBEliminar = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIdObraO = new System.Windows.Forms.ComboBox();
            this.dsRespaldoObra1 = new LancNeo.dsRespaldoObra();
            this.dsRespaldoObra2 = new LancNeo.dsRespaldoObra();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDABusObraO = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusObraD = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlComRespaldo = new System.Data.SqlClient.SqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbBtn1 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNomObra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtObra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbBtn2 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.txtEliTrabajo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sqlComRestaura = new System.Data.SqlClient.SqlCommand();
            this.sqlComBorra = new System.Data.SqlClient.SqlCommand();
            this.sqlComBorracnal = new System.Data.SqlClient.SqlCommand();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sqlConnM = new System.Data.SqlClient.SqlConnection();
            this.cachedCryTarjeta1 = new LancNeo.CachedCryTarjeta();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRespaldoObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRespaldoObra2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cBExportar);
            this.panel1.Controls.Add(this.cBEliminar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbIdObraO);
            this.panel1.ForeColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 124);
            this.panel1.TabIndex = 0;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(478, 4);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 13;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(211, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 48;
            // 
            // cBExportar
            // 
            this.cBExportar.AutoSize = true;
            this.cBExportar.Checked = true;
            this.cBExportar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBExportar.Location = new System.Drawing.Point(11, 80);
            this.cBExportar.Name = "cBExportar";
            this.cBExportar.Size = new System.Drawing.Size(102, 17);
            this.cBExportar.TabIndex = 20;
            this.cBExportar.Text = "Exportar a excel";
            this.cBExportar.UseVisualStyleBackColor = true;
            // 
            // cBEliminar
            // 
            this.cBEliminar.AutoSize = true;
            this.cBEliminar.Enabled = false;
            this.cBEliminar.Location = new System.Drawing.Point(11, 50);
            this.cBEliminar.Name = "cBEliminar";
            this.cBEliminar.Size = new System.Drawing.Size(158, 17);
            this.cBEliminar.TabIndex = 19;
            this.cBEliminar.Text = "Eliminar de la base de datos";
            this.cBEliminar.UseVisualStyleBackColor = true;
            this.cBEliminar.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Respaldo de obras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Obra a respaldar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbIdObraO
            // 
            this.cmbIdObraO.DataSource = this.dsRespaldoObra1.Obra;
            this.cmbIdObraO.DisplayMember = "Idobra";
            this.cmbIdObraO.Location = new System.Drawing.Point(347, 14);
            this.cmbIdObraO.Name = "cmbIdObraO";
            this.cmbIdObraO.Size = new System.Drawing.Size(80, 21);
            this.cmbIdObraO.TabIndex = 9;
            this.cmbIdObraO.ValueMember = "IdObra";
            this.cmbIdObraO.SelectedIndexChanged += new System.EventHandler(this.cmbIdObraO_SelectedIndexChanged);
            // 
            // dsRespaldoObra1
            // 
            this.dsRespaldoObra1.DataSetName = "dsRespaldoObra";
            this.dsRespaldoObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsRespaldoObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsRespaldoObra2
            // 
            this.dsRespaldoObra2.DataSetName = "dsRespaldoObra";
            this.dsRespaldoObra2.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsRespaldoObra2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDABusObraO
            // 
            this.sqlDABusObraO.SelectCommand = this.sqlCommand1;
            this.sqlDABusObraO.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT Idobra, Ubicacion, RFC FROM Obra ORDER BY Idobra";
            this.sqlCommand1.Connection = this.sqlConn;
            // 
            // sqlDABusObraD
            // 
            this.sqlDABusObraD.SelectCommand = this.sqlCommand2;
            this.sqlDABusObraD.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Obra", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Idobra", "Idobra"),
                        new System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"),
                        new System.Data.Common.DataColumnMapping("RFC", "RFC"),
                        new System.Data.Common.DataColumnMapping("Facturar", "Facturar")})});
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "SELECT Idobra, Ubicacion, RFC FROM cnal.dbo.Obra ORDER BY Idobra";
            this.sqlCommand2.Connection = this.sqlConn;
            // 
            // sqlComRespaldo
            // 
            this.sqlComRespaldo.CommandText = "[respaldo]";
            this.sqlComRespaldo.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComRespaldo.Connection = this.sqlConn;
            this.sqlComRespaldo.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6)});
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tbBtn1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtNomObra);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtObra);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Enabled = false;
            this.panel2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(0, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 90);
            this.panel2.TabIndex = 1;
            // 
            // tbBtn1
            // 
            this.tbBtn1.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn1.Enabled = false;
            this.tbBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn1.Icon")));
            this.tbBtn1.Location = new System.Drawing.Point(478, -2);
            this.tbBtn1.Name = "tbBtn1";
            this.tbBtn1.Size = new System.Drawing.Size(64, 64);
            this.tbBtn1.TabIndex = 43;
            this.tbBtn1.Click += new System.EventHandler(this.tbBtn1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(432, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 13);
            this.label13.TabIndex = 48;
            this.label13.Text = "Solo para cuando la obra usa / o -";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(270, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Nombre obra:";
            // 
            // txtNomObra
            // 
            this.txtNomObra.Location = new System.Drawing.Point(347, 54);
            this.txtNomObra.Name = "txtNomObra";
            this.txtNomObra.Size = new System.Drawing.Size(80, 20);
            this.txtNomObra.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(224, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Nombre base de datos:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtObra
            // 
            this.txtObra.Location = new System.Drawing.Point(347, 31);
            this.txtObra.Name = "txtObra";
            this.txtObra.Size = new System.Drawing.Size(80, 20);
            this.txtObra.TabIndex = 44;
            this.txtObra.TextChanged += new System.EventHandler(this.txtObra_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Restauración de obras";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.tbBtn2);
            this.panel3.Controls.Add(this.txtEliTrabajo);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Enabled = false;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(0, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 119);
            this.panel3.TabIndex = 2;
            // 
            // tbBtn2
            // 
            this.tbBtn2.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn2.Enabled = false;
            this.tbBtn2.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn2.Icon")));
            this.tbBtn2.Location = new System.Drawing.Point(478, 4);
            this.tbBtn2.Name = "tbBtn2";
            this.tbBtn2.Size = new System.Drawing.Size(64, 64);
            this.tbBtn2.TabIndex = 43;
            this.tbBtn2.Load += new System.EventHandler(this.tbBtn2_Load);
            this.tbBtn2.Click += new System.EventHandler(this.tbBtn2_Click);
            // 
            // txtEliTrabajo
            // 
            this.txtEliTrabajo.Location = new System.Drawing.Point(347, 40);
            this.txtEliTrabajo.Name = "txtEliTrabajo";
            this.txtEliTrabajo.Size = new System.Drawing.Size(80, 20);
            this.txtEliTrabajo.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(473, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Eliminación de obras en base de datos de trabajo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Obra a eliminar:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sqlComRestaura
            // 
            this.sqlComRestaura.CommandText = "[restaura]";
            this.sqlComRestaura.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComRestaura.Connection = this.sqlConn;
            this.sqlComRestaura.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6)});
            // 
            // sqlComBorra
            // 
            this.sqlComBorra.CommandText = "[Borra]";
            this.sqlComBorra.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComBorra.Connection = this.sqlConn;
            this.sqlComBorra.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6)});
            // 
            // sqlComBorracnal
            // 
            this.sqlComBorracnal.CommandText = "[borracnal]";
            this.sqlComBorracnal.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComBorracnal.Connection = this.sqlConn;
            this.sqlComBorracnal.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6)});
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sqlConnM
            // 
            this.sqlConnM.ConnectionString = "Data Source=SQL5015.site4now.net;Initial Catalog=master;Persist Security Info=Tru" +
    "e;User ID=DB_A4EBAF_lanc_admin;Password=L4Sql2km";
            this.sqlConnM.FireInfoMessageEventOnUserErrors = false;
            // 
            // Respaldo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(608, 334);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Respaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Respaldo";
            this.Load += new System.EventHandler(this.Respaldo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRespaldoObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRespaldoObra2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private void Respaldo_Load(object sender, System.EventArgs e)
        {
            sqlDABusObraO.Fill(dsRespaldoObra1, "Obra");
            //			sqlDABusObraD.Fill(dsRespaldoObra2, "Obra");
        }

        private void btnVistaPrevia_Click(object sender, System.EventArgs e)
        {
            int x = (cBExportar.Checked ? 1 : 0);
            int y = (cBEliminar.Checked ? 1 : 0);
            string cadena1 = "En caso de confirmar se le enviara un correo al Ingeniero Marco Faradji";
            string cadena2 = "¿Confirmas eliminar la obra de la base de datos?";
            string asunto = "Advertencia eliminación de la base ";
            string cuerpo = "El correo tiene como finalidad informar que la obra ";
            string idobra;
            cuerpo += txtEliTrabajo.Text + " ";
            string ruta = "";
            try
            {

                idobra = cmbIdObraO.SelectedValue.ToString().Trim();
                idobra = idobra.Replace("/", "_");
                idobra = idobra.Replace("-", "_");
                idobra = idobra.Replace("\\", "_");
                folderBrowserDialog1.SelectedPath = @"c:\sqlobras";
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    label11.Text = "Inicia a las: ";
                    label1.Text = DateTime.Now.ToShortTimeString();
                    if (cBEliminar.Checked)
                    {

                        if (MessageBox.Show(cadena1, cadena2, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            y = 0;
                            cBEliminar.Checked = false;
                        }
                    }
                    //string strsql = "IF EXISTS (SELECT name FROM sys.databases WHERE name = 'obra') DROP DATABASE [obra]";
                    //sqlConnM.Open();
                    //SqlCommand sqlcmdBO = new SqlCommand(strsql, sqlConnM);
                    //int error = sqlcmdBO.ExecuteNonQuery();
                    //sqlConnM.Close();

                    //strsql = "IF  EXISTS (SELECT name FROM sys.databases WHERE name = '" + idobra + "') DROP DATABASE [" + idobra + "] "; //create database [Obra]
                    //sqlConn.Open();
                    //SqlCommand sqlcmd = new SqlCommand(strsql, sqlConn);
                    //error = sqlcmd.ExecuteNonQuery();
                    //sqlConn.Close();
                    //sqlConnM.Open();
                    //strsql = "CREATE DATABASE [obra] ";
                    //strsql += "ON ( NAME = obra_dat, FILENAME = '" + folderBrowserDialog1.SelectedPath.ToString() + "\\" + idobra + ".mdf', SIZE = 10, MAXSIZE = 200, FILEGROWTH = 5 ) ";
                    //strsql += "LOG ON ( NAME = obra_log, FILENAME = '" + folderBrowserDialog1.SelectedPath.ToString() + "\\" + idobra + "log.ldf', SIZE = 5MB, MAXSIZE = 25MB, FILEGROWTH = 5MB )";
                    //SqlCommand sqlcmda = new SqlCommand(strsql, sqlConnM);
                    //error = sqlcmda.ExecuteNonQuery();
                    //sqlConnM.Close();
                    //sqlConnM.Open();
                    ////                    strsql = "USE MASTER; ";
                    //strsql = "create table [obra].[dbo].[pruebaAPL] (idp int)";
                    //SqlCommand sqlcmdb = new SqlCommand(strsql, sqlConnM);
                    //error = sqlcmdb.ExecuteNonQuery();
                    //sqlConnM.Close();


                    //using (SqlDataAdapter Cmd = new SqlDataAdapter("lanc.dbo.respaldo2016", sqlConnM))
                    //{
                    //    DataSet ds = new DataSet();
                    //    Cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //    Cmd.SelectCommand.Parameters.Add("@IdObra", SqlDbType.NVarChar, 6).Value = cmbIdObraO.SelectedValue.ToString();
                    //    Cmd.Fill(ds);
                    //}
                    //SP Exporta
                    if (cBExportar.Checked)
                    {
                        DataSet ds = new DataSet();
                        using (SqlDataAdapter Cmd = new SqlDataAdapter("Migracion2016", sqlConn))
                        {
                            Cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                            Cmd.SelectCommand.Parameters.Add("@IdObra", SqlDbType.NVarChar, 6).Value = cmbIdObraO.SelectedValue.ToString();
                            Cmd.Fill(ds);
                        }

                        //                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        ruta = folderBrowserDialog1.SelectedPath.ToString() + "\\" + idobra;
                        ExportDatasetToExcel(ds, ruta);
                    }
                    string strsql;
                    int error;
                    //SP Eliminar
                    if (cBEliminar.Checked)
                    {
                        strsql = "exec Eliminar2016 '" + cmbIdObraO.SelectedValue.ToString() + "'";
                        sqlConn.Open();
                        SqlCommand sqlcmd3 = new SqlCommand(strsql, sqlConn);
                        error = sqlcmd3.ExecuteNonQuery();
                        sqlConn.Close();
                        cadena1 = "Eliminación terminado";
                        cadena2 = "Proceso terminado exitosamente";
                        MessageBox.Show(cadena1, cadena2, MessageBoxButtons.OK, MessageBoxIcon.None);
                    }

                    //strsql = "Exec sp_renamedb 'Obra', '"+idobra+"'";// Alter Database Obra Modify Name = " + idobra;
                    //sqlConnM.Open();
                    //SqlCommand sqlcmd2 = new SqlCommand(strsql, sqlConnM);
                    //error = sqlcmd2.ExecuteNonQuery();
                    //sqlConnM.Close();
                    //strsql = "exec sp_detach_db '" + idobra + "'";
                    //sqlConnM.Open();
                    //SqlCommand sqlcmd4 = new SqlCommand(strsql, sqlConnM);
                    //error = sqlcmd4.ExecuteNonQuery();
                    //sqlConnM.Close();
                    ////sqlConnM.Open();
                    ////strsql = "DBCC SHRINKDATABASE (LANC, TRUNCATEONLY)";
                    ////SqlCommand sqlcmd5 = new SqlCommand(strsql, sqlConnM);
                    ////error = sqlcmd5.ExecuteNonQuery();
                    ////sqlConnM.Close();
                    ////sqlConn.Open();
                    ////strsql = "DBCC SHRINKFILE (LANC_LOG, 1)";
                    ////SqlCommand sqlcmd6 = new SqlCommand(strsql, sqlConn);
                    ////error = sqlcmd6.ExecuteNonQuery();
                    ////sqlConn.Close();

                    cadena1 = "Respaldo terminado";
                    cadena2 = "Proceso terminado exitosamente";
                    MessageBox.Show(cadena1, cadena2, MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                if (cBEliminar.Checked && cBExportar.Checked)
                {
                    cuerpo += "ha sido respaldada en una base de datos independiente con nombre ";
                    cuerpo += idobra + " ademas de que fue eliminada de la base de datos de produccion y respaldada a un archivo de excel ";
                    cuerpo += "en la siguiente direccion: " + ruta + ". Para cualquier duda o comentario favor de contactar a Andrés Ponce de León Cortes";
                }
                else if (cBEliminar.Checked && !cBExportar.Checked)
                {
                    cuerpo += "ha sido respaldada en una base de datos independiente con nombre ";
                    cuerpo += idobra + " ademas de que fue eliminada de la base de datos de produccion";
                    cuerpo += ". Para cualquier duda o comentario favor de contactar a Andrés Ponce de León Cortes";
                }
                else if (cBExportar.Checked && !cBEliminar.Checked)
                {
                    cuerpo += "ha sido respaldada en archivo de excel en la siguiente direccion: ";
                    cuerpo += ruta + ". Para cualquier duda o comentario favor de contactar a Andrés Ponce de León Cortes";
                }
                else if (!cBEliminar.Checked && !cBExportar.Checked)
                {
                    cuerpo += "ha sido respaldada en una base de datos independiente con nombre ";
                    cuerpo += idobra + ". Para cualquier duda o comentario favor de contactar a Andrés Ponce de León Cortes";
                }
                enviacorreo(cuerpo, asunto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                label7.Text = DateTime.Now.ToShortTimeString();
                if (sqlConn.State == ConnectionState.Open)
                    sqlConn.Close();
//                if (sqlConn1.State == ConnectionState.Open)
//                    sqlConn1.Close();
                if (sqlConnM.State == ConnectionState.Open)
                    sqlConnM.Close();
                dsRespaldoObra1.Clear();
                //                dsRespaldoObra2.Clear();
                sqlDABusObraO.Fill(dsRespaldoObra1, "Obra");
                //                sqlDABusObraD.Fill(dsRespaldoObra2, "Obra");
            }
        }

        private void tbBtn1_Click(object sender, System.EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                using (SqlDataAdapter Cmd = new SqlDataAdapter("verificaBD", sqlConn))
                {
                    Cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Cmd.SelectCommand.Parameters.Add("@IdObra", SqlDbType.NVarChar, 6).Value = txtObra.Text;
                    Cmd.Fill(ds);
                }
                string obra;
                obra = txtObra.Text;
                Valida(ds, obra);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void label7_Click(object sender, System.EventArgs e)
        {

        }

        private void tbBtn2_Click(object sender, System.EventArgs e)
        {
            try
            {

                string cadena1 = "En caso de confirmar se le enviara un correo al Ingeniero Marco Faradji";
                string cadena2 = "¿Confirmas eliminar la obra de la base de datos?";
                string asunto = "Advertencia eliminación de la base ";
                string cuerpo = "El correo tiene como finalidad informar que la obra ";
                cuerpo += txtEliTrabajo.Text + " ha sido eliminada de la base de datos de producción";
                if (MessageBox.Show(cadena1, cadena2, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string strsql = "exec Eliminar2016 '" + txtEliTrabajo.Text + "'";
                    sqlConn.Open();
                    SqlCommand sqlcmd3 = new SqlCommand(strsql, sqlConn);
                    int error = sqlcmd3.ExecuteNonQuery();
                    sqlConn.Close();
                    cadena1 = "Eliminación terminado";
                    cadena2 = "Proceso terminado exitosamente";
                    MessageBox.Show(cadena1, cadena2, MessageBoxButtons.OK, MessageBoxIcon.None);
                    asunto += txtEliTrabajo.Text;
                    enviacorreo(cuerpo, asunto);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbBtn2_Load(object sender, EventArgs e)
        {

        }

        private void tbBtn1_Load(object sender, EventArgs e)
        {

        }
        private void enviacorreo(String cuerpo, string asunto)
        {
            if (cBEliminar.Checked)
            {
                SmtpClient client = new SmtpClient("mail.aec.mx");
                var mail = new MailMessage();
                mail.From = new MailAddress("artbot@aec.mx");
                mail.To.Add("marcofar@laboratorioslanc.mx");
                mail.CC.Add("ariw@laboratorioslanc.mx");
                mail.Bcc.Add("apl_mx@hotmail.com");
                //            mail.To.Add("a.ponce@aec.mx");
                mail.Subject = asunto + " " + txtEliTrabajo.Text;
                mail.IsBodyHtml = true;
                mail.Body = cuerpo;
                client.Port = 8889;
                client.UseDefaultCredentials = true;
                client.Credentials = new System.Net.NetworkCredential("artbot@aec.mx", "4rtB0t_M");
                client.EnableSsl = false;
                client.Send(mail);
            }
        }
        private void ExportDatasetToExcel(DataSet ds, String strPath)
        {
            ds.Tables[0].TableName = "AceroMdor";
            ds.Tables[1].TableName = "ProbetaEsp";
            ds.Tables[2].TableName = "ProbetaRes";
            ds.Tables[3].TableName = "Agregados";
            ds.Tables[4].TableName = "AgregadosMal";
            ds.Tables[5].TableName = "Asfaltico";
            ds.Tables[6].TableName = "AsfalticoMal";
            ds.Tables[7].TableName = "Cemento";
            ds.Tables[8].TableName = "CompactaMdor";
            ds.Tables[9].TableName = "CompactaRes";
            ds.Tables[10].TableName = "Conecmdor";
            ds.Tables[11].TableName = "ConecEsp";
            ds.Tables[12].TableName = "ConceRes";
            ds.Tables[13].TableName = "DetCon";
            ds.Tables[14].TableName = "Especimen";
            ds.Tables[15].TableName = "Experiencia";
            ds.Tables[16].TableName = "Externos";
            ds.Tables[17].TableName = "Gra60Mdor";
            ds.Tables[18].TableName = "Gra60ESP";
            ds.Tables[19].TableName = "Gra60Res";
            ds.Tables[20].TableName = "Grad50Mdor";
            ds.Tables[21].TableName = "Grad50Esp";
            ds.Tables[22].TableName = "Grad50Res";
            ds.Tables[23].TableName = "Imagen";
            ds.Tables[24].TableName = "LabAdic";
            ds.Tables[25].TableName = "LiquidoMdor";
            ds.Tables[26].TableName = "LiquidoRes";
            ds.Tables[27].TableName = "Materiales";
            ds.Tables[28].TableName = "MaterialesMal";
            ds.Tables[29].TableName = "Muestras";
            ds.Tables[30].TableName = "Muestreador";
            ds.Tables[31].TableName = "Obra";
            ds.Tables[32].TableName = "PermisoEmpresa";
            ds.Tables[33].TableName = "PlacAceMdor";
            ds.Tables[34].TableName = "PlacAceEsp";
            ds.Tables[35].TableName = "PlacAceRes";
            ds.Tables[36].TableName = "Presupuesto";
            ds.Tables[37].TableName = "RadioMdor";
            ds.Tables[38].TableName = "RadioRes";
            ds.Tables[39].TableName = "Registro";
            ds.Tables[40].TableName = "Secante";
            ds.Tables[41].TableName = "SecanteRes";
            ds.Tables[42].TableName = "SecantePro";
            ds.Tables[43].TableName = "SoldaMdor";
            ds.Tables[44].TableName = "SoldaEsp";
            ds.Tables[45].TableName = "SoldaRes";
            ds.Tables[46].TableName = "TabiqueMdor";
            ds.Tables[47].TableName = "TabiqueRes";
            ds.Tables[48].TableName = "Toron7AlamMdor";
            ds.Tables[49].TableName = "Torom7Esp";
            ds.Tables[50].TableName = "Toron7Res";
            ds.Tables[51].TableName = "Volumetrico";
            ds.Tables[52].TableName = "VolumetricoRes";
            System.Reflection.Missing Default = System.Reflection.Missing.Value;
            //Create Excel File
            strPath += ".xlsx";
            ExportDataSet(ds, strPath);
            MessageBox.Show("Archivo de Excel generado exitosamente \n como " + strPath);
        }


        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} Envio Cancelado", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("El correo ha sido enviado exitosamente", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Restaura(string obra)
        {
            string strsql;
            //strsql = "Alter Database " + obra + " Modify Name 'Obra'";
            //sqlConn.Open();
            SqlCommand sqlcmd = new SqlCommand();
            int error;
            //sqlConn.Close();
            try
            {
                strsql = "exec Restauracion2016 '" + txtNomObra.Text + "'";
                sqlConn.Open();
                sqlcmd = new SqlCommand(strsql, sqlConn);
                error = sqlcmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConn.Close();
            }
            finally
            {
                strsql = "exec sp_detach_db 'respaldo'";
                sqlConn.Open();
                sqlcmd = new SqlCommand(strsql, sqlConn);
                error = sqlcmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            MessageBox.Show("Proceso de restauración terminado", "Atención",MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void Valida(DataSet ds, string obra)
        {
            string rutaO = @"c:\SqlObras\" + txtObra.Text + ".mdf";
            string ruta1 = "";
            string ruta2 = "";
            string strsql = "";
            string cadena1 = "Error";
            string cadena2 = "El nombre de la obra a Restaurar no coincide";
            int Valid;
            Valid = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            if (Valid == 0)
            {
                openFileDialog1.InitialDirectory = @"c:\\SqlObras\\";
                openFileDialog1.DefaultExt = ".mdf";
                openFileDialog1.Filter = "MDF|*.mdf";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ruta1 = openFileDialog1.FileName.ToString();
                    openFileDialog1.DefaultExt = ".ldf";
                    openFileDialog1.Filter = "LDF|*.ldf";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        ruta2 = openFileDialog1.FileName.ToString();
                    }
                    if (ruta1.ToUpper() == rutaO.ToUpper())
                    {
                        strsql = "exec sp_attach_db @dbname = N'Respaldo', @filename1 = N" + "'" + ruta1 + "', @filename2 =N'" + ruta2 + "'";
                        sqlConn.Open();
                        SqlCommand sqlcmd = new SqlCommand(strsql, sqlConn);
                        int error = sqlcmd.ExecuteNonQuery();
                        sqlConn.Close();
                        Restaura(obra);
                    }
                    else
                    {
                        MessageBox.Show(cadena1, cadena2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Valida(ds, obra);
                    }

                }

            }
            else if (Valid == 1)
            {
                Restaura(obra);
            }

        }

        private void cmbIdObraO_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEliTrabajo.Text = cmbIdObraO.SelectedText;
        }

        private void txtObra_TextChanged(object sender, EventArgs e)
        {
            txtNomObra.Text = txtObra.Text;
        }

        private void ExportDataSet(DataSet ds, string destination)
        {
            using (var workbook = SpreadsheetDocument.Create(destination, DocumentFormat.OpenXml.SpreadsheetDocumentType.Workbook))
            {
                var workbookPart = workbook.AddWorkbookPart();

                workbook.WorkbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

                workbook.WorkbookPart.Workbook.Sheets = new DocumentFormat.OpenXml.Spreadsheet.Sheets();
                uint sheetId = 1;

                foreach (System.Data.DataTable table in ds.Tables)
                {
                    label8.Text = table.TableName.ToString();
                    label9.Text = table.Rows.Count.ToString();
                    var sheetPart = workbook.WorkbookPart.AddNewPart<WorksheetPart>();
                    var sheetData = new DocumentFormat.OpenXml.Spreadsheet.SheetData();
                    sheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet(sheetData);

                    DocumentFormat.OpenXml.Spreadsheet.Sheets sheets = workbook.WorkbookPart.Workbook.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>();
                    string relationshipId = workbook.WorkbookPart.GetIdOfPart(sheetPart);

                    sheetId = sheetId + 1;
                    //if (sheets.Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Count() > 0)
                    //{
                    //    sheetId =
                    //        sheets.Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Select(s => s.SheetId.Value).Max() + 1;
                    //}

                    DocumentFormat.OpenXml.Spreadsheet.Sheet sheet = new DocumentFormat.OpenXml.Spreadsheet.Sheet() { Id = relationshipId, SheetId = sheetId, Name = table.TableName };
                    sheets.Append(sheet);

                    DocumentFormat.OpenXml.Spreadsheet.Row headerRow = new DocumentFormat.OpenXml.Spreadsheet.Row();

                    List<String> columns = new List<string>();
                    foreach (System.Data.DataColumn column in table.Columns)
                    {
                        columns.Add(column.ColumnName);

                        DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                        cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                        cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(column.ColumnName);
                        headerRow.AppendChild(cell);
                    }


                    sheetData.AppendChild(headerRow);

                    foreach (System.Data.DataRow dsrow in table.Rows)
                    {
                        DocumentFormat.OpenXml.Spreadsheet.Row newRow = new DocumentFormat.OpenXml.Spreadsheet.Row();
                        foreach (String col in columns)
                        {
                            DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                            cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                            cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(dsrow[col].ToString()); //
                            newRow.AppendChild(cell);
                        }

                        sheetData.AppendChild(newRow);
                    }

                }
            }
        }
    }
}

