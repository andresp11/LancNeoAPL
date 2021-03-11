namespace LancNeo
{
    partial class Intensidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intensidad));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dsIntensidad1 = new LancNeo.dsIntensidad();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSeparación = new System.Windows.Forms.TextBox();
            this.txtAlargamiento = new System.Windows.Forms.TextBox();
            this.textEsfuerzoMAX = new System.Windows.Forms.TextBox();
            this.lblSeparacion = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblEsfuerzoMax = new System.Windows.Forms.Label();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.txtEsfuerzoLE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEsfuerzoLE = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMilimetros = new System.Windows.Forms.TextBox();
            this.txtNominal = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDAIntensidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsIntensidad1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(697, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(697, 64);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.txtSeparación);
            this.panel2.Controls.Add(this.txtAlargamiento);
            this.panel2.Controls.Add(this.textEsfuerzoMAX);
            this.panel2.Controls.Add(this.lblSeparacion);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblEsfuerzoMax);
            this.panel2.Controls.Add(this.txtMasa);
            this.panel2.Controls.Add(this.txtGrado);
            this.panel2.Controls.Add(this.txtEsfuerzoLE);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblEsfuerzoLE);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMilimetros);
            this.panel2.Controls.Add(this.txtNominal);
            this.panel2.Controls.Add(this.txtNumero);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 310);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 700;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsIntensidad1.Intensidad;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(247, 29);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 36;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Buscar");
            this.buscaBtn1.Load += new System.EventHandler(this.buscaBtn1_Load);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsIntensidad1, "Intensidad.Mortero", true));
            this.textBox2.Location = new System.Drawing.Point(124, 270);
            this.textBox2.MaxLength = 30;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 20);
            this.textBox2.TabIndex = 38;
            this.textBox2.Text = "textBox2";
            // 
            // dsIntensidad1
            // 
            this.dsIntensidad1.DataSetName = "dsIntensidad";
            this.dsIntensidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Mortero:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsIntensidad1, "Intensidad.Acero", true));
            this.textBox1.Location = new System.Drawing.Point(126, 95);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 37;
            this.textBox1.Text = "textBox1";
            // 
            // txtSeparación
            // 
            this.txtSeparación.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsIntensidad1, "Intensidad.Calas", true));
            this.txtSeparación.Location = new System.Drawing.Point(124, 244);
            this.txtSeparación.MaxLength = 30;
            this.txtSeparación.Name = "txtSeparación";
            this.txtSeparación.Size = new System.Drawing.Size(80, 20);
            this.txtSeparación.TabIndex = 15;
            this.txtSeparación.Text = "textBox2";
            // 
            // txtAlargamiento
            // 
            this.txtAlargamiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsIntensidad1, "Intensidad.Laboratorio", true));
            this.txtAlargamiento.Location = new System.Drawing.Point(124, 220);
            this.txtAlargamiento.MaxLength = 100;
            this.txtAlargamiento.Name = "txtAlargamiento";
            this.txtAlargamiento.Size = new System.Drawing.Size(427, 20);
            this.txtAlargamiento.TabIndex = 14;
            this.txtAlargamiento.Text = "textBox1";
            // 
            // textEsfuerzoMAX
            // 
            this.textEsfuerzoMAX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsIntensidad1, "Intensidad.Croquis", true));
            this.textEsfuerzoMAX.Location = new System.Drawing.Point(124, 193);
            this.textEsfuerzoMAX.MaxLength = 100;
            this.textEsfuerzoMAX.Name = "textEsfuerzoMAX";
            this.textEsfuerzoMAX.Size = new System.Drawing.Size(427, 20);
            this.textEsfuerzoMAX.TabIndex = 13;
            this.textEsfuerzoMAX.Text = "textBox1";
            // 
            // lblSeparacion
            // 
            this.lblSeparacion.AutoSize = true;
            this.lblSeparacion.Location = new System.Drawing.Point(88, 248);
            this.lblSeparacion.Name = "lblSeparacion";
            this.lblSeparacion.Size = new System.Drawing.Size(36, 13);
            this.lblSeparacion.TabIndex = 19;
            this.lblSeparacion.Text = "Calas:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(61, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Laboratorio:";
            // 
            // lblEsfuerzoMax
            // 
            this.lblEsfuerzoMax.AutoSize = true;
            this.lblEsfuerzoMax.Location = new System.Drawing.Point(79, 197);
            this.lblEsfuerzoMax.Name = "lblEsfuerzoMax";
            this.lblEsfuerzoMax.Size = new System.Drawing.Size(45, 13);
            this.lblEsfuerzoMax.TabIndex = 17;
            this.lblEsfuerzoMax.Text = "Croquis:";
            // 
            // txtMasa
            // 
            this.txtMasa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsIntensidad1, "Intensidad.Prefabircados", true));
            this.txtMasa.Location = new System.Drawing.Point(124, 145);
            this.txtMasa.MaxLength = 30;
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(80, 20);
            this.txtMasa.TabIndex = 10;
            this.txtMasa.Text = "textBox2";
            // 
            // txtGrado
            // 
            this.txtGrado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsIntensidad1, "Intensidad.AceroRem", true));
            this.txtGrado.Location = new System.Drawing.Point(124, 119);
            this.txtGrado.MaxLength = 100;
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(427, 20);
            this.txtGrado.TabIndex = 9;
            this.txtGrado.Text = "textBox1";
            // 
            // txtEsfuerzoLE
            // 
            this.txtEsfuerzoLE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsIntensidad1, "Intensidad.revenimiento", true));
            this.txtEsfuerzoLE.Location = new System.Drawing.Point(124, 169);
            this.txtEsfuerzoLE.MaxLength = 30;
            this.txtEsfuerzoLE.Name = "txtEsfuerzoLE";
            this.txtEsfuerzoLE.Size = new System.Drawing.Size(80, 20);
            this.txtEsfuerzoLE.TabIndex = 12;
            this.txtEsfuerzoLE.Text = "textBox1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Prefabricados millares:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Remesas menores:";
            // 
            // lblEsfuerzoLE
            // 
            this.lblEsfuerzoLE.AutoSize = true;
            this.lblEsfuerzoLE.Location = new System.Drawing.Point(49, 173);
            this.lblEsfuerzoLE.Name = "lblEsfuerzoLE";
            this.lblEsfuerzoLE.Size = new System.Drawing.Size(75, 13);
            this.lblEsfuerzoLE.TabIndex = 9;
            this.lblEsfuerzoLE.Text = "Revenimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Acero (t):";
            // 
            // txtMilimetros
            // 
            this.txtMilimetros.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsIntensidad1, "Intensidad.Adicionales", true));
            this.txtMilimetros.Location = new System.Drawing.Point(126, 73);
            this.txtMilimetros.MaxLength = 30;
            this.txtMilimetros.Name = "txtMilimetros";
            this.txtMilimetros.Size = new System.Drawing.Size(80, 20);
            this.txtMilimetros.TabIndex = 5;
            this.txtMilimetros.Text = "textBox2";
            // 
            // txtNominal
            // 
            this.txtNominal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsIntensidad1, "Intensidad.Inferiores", true));
            this.txtNominal.Location = new System.Drawing.Point(126, 50);
            this.txtNominal.MaxLength = 30;
            this.txtNominal.Name = "txtNominal";
            this.txtNominal.Size = new System.Drawing.Size(80, 20);
            this.txtNominal.TabIndex = 4;
            this.txtNominal.Text = "textBox1";
            // 
            // txtNumero
            // 
            this.txtNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsIntensidad1, "Intensidad.IdIntensidad", true));
            this.txtNumero.Location = new System.Drawing.Point(126, 26);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(80, 20);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.Text = "textBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Colados adicionales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Colados inferiores:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdIntensidad:";
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDAIntensidad
            // 
            this.sqlDAIntensidad.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAIntensidad.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAIntensidad.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAIntensidad.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Intensidad", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdIntensidad", "IdIntensidad"),
                        new System.Data.Common.DataColumnMapping("Inferiores", "Inferiores"),
                        new System.Data.Common.DataColumnMapping("Adicionales", "Adicionales"),
                        new System.Data.Common.DataColumnMapping("Acero", "Acero"),
                        new System.Data.Common.DataColumnMapping("AceroRem", "AceroRem"),
                        new System.Data.Common.DataColumnMapping("Prefabircados", "Prefabircados"),
                        new System.Data.Common.DataColumnMapping("revenimiento", "revenimiento"),
                        new System.Data.Common.DataColumnMapping("Croquis", "Croquis"),
                        new System.Data.Common.DataColumnMapping("Laboratorio", "Laboratorio"),
                        new System.Data.Common.DataColumnMapping("Calas", "Calas"),
                        new System.Data.Common.DataColumnMapping("Mortero", "Mortero")})});
            this.sqlDAIntensidad.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdIntensidad", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdIntensidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Inferiores", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Inferiores", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Inferiores", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Inferiores", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Adicionales", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Adicionales", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Adicionales", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adicionales", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Acero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Acero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Acero", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Acero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AceroRem", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AceroRem", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AceroRem", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AceroRem", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Prefabircados", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Prefabircados", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Prefabircados", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prefabircados", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_revenimiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "revenimiento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_revenimiento", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "revenimiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Croquis", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Croquis", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Croquis", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Croquis", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Laboratorio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Laboratorio", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Laboratorio", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Laboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Calas", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Calas", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Calas", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Calas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Mortero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Mortero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Mortero", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mortero", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdIntensidad", System.Data.SqlDbType.NVarChar, 0, "IdIntensidad"),
            new System.Data.SqlClient.SqlParameter("@Inferiores", System.Data.SqlDbType.NVarChar, 0, "Inferiores"),
            new System.Data.SqlClient.SqlParameter("@Adicionales", System.Data.SqlDbType.NVarChar, 0, "Adicionales"),
            new System.Data.SqlClient.SqlParameter("@Acero", System.Data.SqlDbType.NVarChar, 0, "Acero"),
            new System.Data.SqlClient.SqlParameter("@AceroRem", System.Data.SqlDbType.NVarChar, 0, "AceroRem"),
            new System.Data.SqlClient.SqlParameter("@Prefabircados", System.Data.SqlDbType.NVarChar, 0, "Prefabircados"),
            new System.Data.SqlClient.SqlParameter("@revenimiento", System.Data.SqlDbType.NVarChar, 0, "revenimiento"),
            new System.Data.SqlClient.SqlParameter("@Croquis", System.Data.SqlDbType.NVarChar, 0, "Croquis"),
            new System.Data.SqlClient.SqlParameter("@Laboratorio", System.Data.SqlDbType.NVarChar, 0, "Laboratorio"),
            new System.Data.SqlClient.SqlParameter("@Calas", System.Data.SqlDbType.NVarChar, 0, "Calas"),
            new System.Data.SqlClient.SqlParameter("@Mortero", System.Data.SqlDbType.NVarChar, 0, "Mortero")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     IdIntensidad, Inferiores, Adicionales, Acero, AceroRem, Prefabircados," +
    " revenimiento, Croquis, Laboratorio, Calas, Mortero\r\nFROM         Intensidad";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdIntensidad", System.Data.SqlDbType.NVarChar, 0, "IdIntensidad"),
            new System.Data.SqlClient.SqlParameter("@Inferiores", System.Data.SqlDbType.NVarChar, 0, "Inferiores"),
            new System.Data.SqlClient.SqlParameter("@Adicionales", System.Data.SqlDbType.NVarChar, 0, "Adicionales"),
            new System.Data.SqlClient.SqlParameter("@Acero", System.Data.SqlDbType.NVarChar, 0, "Acero"),
            new System.Data.SqlClient.SqlParameter("@AceroRem", System.Data.SqlDbType.NVarChar, 0, "AceroRem"),
            new System.Data.SqlClient.SqlParameter("@Prefabircados", System.Data.SqlDbType.NVarChar, 0, "Prefabircados"),
            new System.Data.SqlClient.SqlParameter("@revenimiento", System.Data.SqlDbType.NVarChar, 0, "revenimiento"),
            new System.Data.SqlClient.SqlParameter("@Croquis", System.Data.SqlDbType.NVarChar, 0, "Croquis"),
            new System.Data.SqlClient.SqlParameter("@Laboratorio", System.Data.SqlDbType.NVarChar, 0, "Laboratorio"),
            new System.Data.SqlClient.SqlParameter("@Calas", System.Data.SqlDbType.NVarChar, 0, "Calas"),
            new System.Data.SqlClient.SqlParameter("@Mortero", System.Data.SqlDbType.NVarChar, 0, "Mortero"),
            new System.Data.SqlClient.SqlParameter("@Original_IdIntensidad", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdIntensidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Inferiores", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Inferiores", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Inferiores", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Inferiores", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Adicionales", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Adicionales", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Adicionales", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adicionales", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Acero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Acero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Acero", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Acero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AceroRem", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AceroRem", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AceroRem", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AceroRem", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Prefabircados", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Prefabircados", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Prefabircados", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prefabircados", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_revenimiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "revenimiento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_revenimiento", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "revenimiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Croquis", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Croquis", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Croquis", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Croquis", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Laboratorio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Laboratorio", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Laboratorio", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Laboratorio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Calas", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Calas", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Calas", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Calas", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Mortero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Mortero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Mortero", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mortero", System.Data.DataRowVersion.Original, null)});
            // 
            // Intensidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 423);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAIntensidad;
            this.dsGeneral = this.dsIntensidad1;
            this.Name = "Intensidad";
            this.NombreTabla = "Intensidad";
            this.Text = "Intensidad";
            this.Load += new System.EventHandler(this.Intensidad_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsIntensidad1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
        private System.Windows.Forms.TextBox txtSeparación;
        private System.Windows.Forms.TextBox txtAlargamiento;
        private System.Windows.Forms.TextBox textEsfuerzoMAX;
        private System.Windows.Forms.Label lblSeparacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblEsfuerzoMax;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.TextBox txtEsfuerzoLE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEsfuerzoLE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMilimetros;
        private System.Windows.Forms.TextBox txtNominal;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlConnection sqlConn;
        private System.Data.SqlClient.SqlDataAdapter sqlDAIntensidad;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private dsIntensidad dsIntensidad1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}