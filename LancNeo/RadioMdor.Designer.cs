namespace LancNeo
{
    partial class RadioMdor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadioMdor));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsRadioMdor1 = new LancNeo.dsRadioMdor();
            this.txtNoP = new System.Windows.Forms.TextBox();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.txtIQI = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtNorma = new System.Windows.Forms.TextBox();
            this.txtProc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTecnicaE = new System.Windows.Forms.TextBox();
            this.txtTecnicaP = new System.Windows.Forms.TextBox();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDPF = new System.Windows.Forms.TextBox();
            this.txtPF = new System.Windows.Forms.TextBox();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.txtFuente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFmuestreo = new System.Windows.Forms.DateTimePicker();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDARadioMdor = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadioMdor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 379);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(668, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(668, 64);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.txtNoP);
            this.panel2.Controls.Add(this.txtDis);
            this.panel2.Controls.Add(this.txtIQI);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtMaterial);
            this.panel2.Controls.Add(this.txtNorma);
            this.panel2.Controls.Add(this.txtProc);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtTecnicaE);
            this.panel2.Controls.Add(this.txtTecnicaP);
            this.panel2.Controls.Add(this.txtPantalla);
            this.panel2.Controls.Add(this.txtTipo);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtDPF);
            this.panel2.Controls.Add(this.txtPF);
            this.panel2.Controls.Add(this.txtActividad);
            this.panel2.Controls.Add(this.txtFuente);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpFmuestreo);
            this.panel2.Controls.Add(this.txtConsecutivo);
            this.panel2.Controls.Add(this.cmbIdObra);
            this.panel2.Controls.Add(this.txtFolio);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(11, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 279);
            this.panel2.TabIndex = 6;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 675;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsRadioMdor1.RadioMdor;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(202, 6);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 20;
            // 
            // dsRadioMdor1
            // 
            this.dsRadioMdor1.DataSetName = "dsRadioMdor";
            this.dsRadioMdor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNoP
            // 
            this.txtNoP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRadioMdor1, "RadioMdor.NoPeliculas", true));
            this.txtNoP.Location = new System.Drawing.Point(432, 228);
            this.txtNoP.Name = "txtNoP";
            this.txtNoP.Size = new System.Drawing.Size(190, 20);
            this.txtNoP.TabIndex = 48;
            // 
            // txtDis
            // 
            this.txtDis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRadioMdor1, "RadioMdor.Diseño", true));
            this.txtDis.Location = new System.Drawing.Point(432, 202);
            this.txtDis.Name = "txtDis";
            this.txtDis.Size = new System.Drawing.Size(190, 20);
            this.txtDis.TabIndex = 47;
            // 
            // txtIQI
            // 
            this.txtIQI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRadioMdor1, "RadioMdor.IQIU", true));
            this.txtIQI.Location = new System.Drawing.Point(432, 176);
            this.txtIQI.Name = "txtIQI";
            this.txtIQI.Size = new System.Drawing.Size(190, 20);
            this.txtIQI.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "No. de películas:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(333, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Diseño de la junta:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(348, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "I. Q. I. utilizado:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaterial
            // 
            this.txtMaterial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRadioMdor1, "RadioMdor.Material", true));
            this.txtMaterial.Location = new System.Drawing.Point(126, 228);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(177, 20);
            this.txtMaterial.TabIndex = 42;
            // 
            // txtNorma
            // 
            this.txtNorma.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRadioMdor1, "RadioMdor.Norma", true));
            this.txtNorma.Location = new System.Drawing.Point(126, 202);
            this.txtNorma.Name = "txtNorma";
            this.txtNorma.Size = new System.Drawing.Size(177, 20);
            this.txtNorma.TabIndex = 41;
            // 
            // txtProc
            // 
            this.txtProc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRadioMdor1, "RadioMdor.Proc", true));
            this.txtProc.Location = new System.Drawing.Point(126, 176);
            this.txtProc.Name = "txtProc";
            this.txtProc.Size = new System.Drawing.Size(177, 20);
            this.txtProc.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(78, 235);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Material:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(2, 209);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Norma de interpretación:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(37, 183);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "ProcedimientNo.:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTecnicaE
            // 
            this.txtTecnicaE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRadioMdor1, "RadioMdor.Tecnicae", true));
            this.txtTecnicaE.Location = new System.Drawing.Point(432, 150);
            this.txtTecnicaE.Name = "txtTecnicaE";
            this.txtTecnicaE.Size = new System.Drawing.Size(190, 20);
            this.txtTecnicaE.TabIndex = 36;
            // 
            // txtTecnicaP
            // 
            this.txtTecnicaP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRadioMdor1, "RadioMdor.TecnicaP", true));
            this.txtTecnicaP.Location = new System.Drawing.Point(432, 124);
            this.txtTecnicaP.Name = "txtTecnicaP";
            this.txtTecnicaP.Size = new System.Drawing.Size(190, 20);
            this.txtTecnicaP.TabIndex = 35;
            // 
            // txtPantalla
            // 
            this.txtPantalla.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRadioMdor1, "RadioMdor.Pantalla", true));
            this.txtPantalla.Location = new System.Drawing.Point(432, 98);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.Size = new System.Drawing.Size(190, 20);
            this.txtPantalla.TabIndex = 34;
            // 
            // txtTipo
            // 
            this.txtTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRadioMdor1, "RadioMdor.TipoP", true));
            this.txtTipo.Location = new System.Drawing.Point(432, 72);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(190, 20);
            this.txtTipo.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Técnica exposición:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(323, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Técnica de película:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(375, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Pantallas:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(341, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Tipo de película:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDPF
            // 
            this.txtDPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRadioMdor1, "RadioMdor.DFP", true));
            this.txtDPF.Location = new System.Drawing.Point(126, 150);
            this.txtDPF.Name = "txtDPF";
            this.txtDPF.Size = new System.Drawing.Size(177, 20);
            this.txtDPF.TabIndex = 28;
            // 
            // txtPF
            // 
            this.txtPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRadioMdor1, "RadioMdor.PFocal", true));
            this.txtPF.Location = new System.Drawing.Point(126, 124);
            this.txtPF.Name = "txtPF";
            this.txtPF.Size = new System.Drawing.Size(177, 20);
            this.txtPF.TabIndex = 27;
            // 
            // txtActividad
            // 
            this.txtActividad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRadioMdor1, "RadioMdor.Actividad", true));
            this.txtActividad.Location = new System.Drawing.Point(126, 98);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(177, 20);
            this.txtActividad.TabIndex = 26;
            // 
            // txtFuente
            // 
            this.txtFuente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRadioMdor1, "RadioMdor.Fuente", true));
            this.txtFuente.Location = new System.Drawing.Point(126, 72);
            this.txtFuente.Name = "txtFuente";
            this.txtFuente.Size = new System.Drawing.Size(177, 20);
            this.txtFuente.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Distancia F.P. (mm):";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Punto Focal:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Actividad:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fuente:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFmuestreo
            // 
            this.dtpFmuestreo.CustomFormat = "dd/MM/yyyy";
            this.dtpFmuestreo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRadioMdor1, "RadioMdor.Fmuestreo", true));
            this.dtpFmuestreo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFmuestreo.Location = new System.Drawing.Point(432, 41);
            this.dtpFmuestreo.Name = "dtpFmuestreo";
            this.dtpFmuestreo.Size = new System.Drawing.Size(84, 20);
            this.dtpFmuestreo.TabIndex = 13;
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRadioMdor1, "RadioMdor.ConsObra", true));
            this.txtConsecutivo.Location = new System.Drawing.Point(432, 17);
            this.txtConsecutivo.MaxLength = 4;
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(66, 20);
            this.txtConsecutivo.TabIndex = 12;
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsRadioMdor1, "RadioMdor.IdObra", true));
            this.cmbIdObra.DataSource = this.dsBusObra1;
            this.cmbIdObra.DisplayMember = "Obra.Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(126, 46);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(66, 21);
            this.cmbIdObra.TabIndex = 11;
            this.cmbIdObra.ValueMember = "Obra.Idobra";
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtFolio
            // 
            this.txtFolio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsRadioMdor1, "RadioMdor.FOLIO", true));
            this.txtFolio.Location = new System.Drawing.Point(126, 22);
            this.txtFolio.MaxLength = 10;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(64, 20);
            this.txtFolio.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de muestreo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Consecutivo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Obra:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOLIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.Char, 0, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@ConsObra", System.Data.SqlDbType.SmallInt, 0, "ConsObra"),
            new System.Data.SqlClient.SqlParameter("@Fmuestreo", System.Data.SqlDbType.SmallDateTime, 0, "Fmuestreo"),
            new System.Data.SqlClient.SqlParameter("@Fuente", System.Data.SqlDbType.NVarChar, 0, "Fuente"),
            new System.Data.SqlClient.SqlParameter("@Actividad", System.Data.SqlDbType.NVarChar, 0, "Actividad"),
            new System.Data.SqlClient.SqlParameter("@PFocal", System.Data.SqlDbType.NVarChar, 0, "PFocal"),
            new System.Data.SqlClient.SqlParameter("@DFP", System.Data.SqlDbType.NVarChar, 0, "DFP"),
            new System.Data.SqlClient.SqlParameter("@TipoP", System.Data.SqlDbType.NVarChar, 0, "TipoP"),
            new System.Data.SqlClient.SqlParameter("@Pantalla", System.Data.SqlDbType.NVarChar, 0, "Pantalla"),
            new System.Data.SqlClient.SqlParameter("@TecnicaP", System.Data.SqlDbType.NVarChar, 0, "TecnicaP"),
            new System.Data.SqlClient.SqlParameter("@Tecnicae", System.Data.SqlDbType.NVarChar, 0, "Tecnicae"),
            new System.Data.SqlClient.SqlParameter("@Proc", System.Data.SqlDbType.NVarChar, 0, "Proc"),
            new System.Data.SqlClient.SqlParameter("@Norma", System.Data.SqlDbType.NVarChar, 0, "Norma"),
            new System.Data.SqlClient.SqlParameter("@Material", System.Data.SqlDbType.NVarChar, 0, "Material"),
            new System.Data.SqlClient.SqlParameter("@IQIU", System.Data.SqlDbType.NVarChar, 0, "IQIU"),
            new System.Data.SqlClient.SqlParameter("@Diseño", System.Data.SqlDbType.NVarChar, 0, "Diseño"),
            new System.Data.SqlClient.SqlParameter("@NoPeliculas", System.Data.SqlDbType.NVarChar, 0, "NoPeliculas")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.Char, 0, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@ConsObra", System.Data.SqlDbType.SmallInt, 0, "ConsObra"),
            new System.Data.SqlClient.SqlParameter("@Fmuestreo", System.Data.SqlDbType.SmallDateTime, 0, "Fmuestreo"),
            new System.Data.SqlClient.SqlParameter("@Fuente", System.Data.SqlDbType.NVarChar, 0, "Fuente"),
            new System.Data.SqlClient.SqlParameter("@Actividad", System.Data.SqlDbType.NVarChar, 0, "Actividad"),
            new System.Data.SqlClient.SqlParameter("@PFocal", System.Data.SqlDbType.NVarChar, 0, "PFocal"),
            new System.Data.SqlClient.SqlParameter("@DFP", System.Data.SqlDbType.NVarChar, 0, "DFP"),
            new System.Data.SqlClient.SqlParameter("@TipoP", System.Data.SqlDbType.NVarChar, 0, "TipoP"),
            new System.Data.SqlClient.SqlParameter("@Pantalla", System.Data.SqlDbType.NVarChar, 0, "Pantalla"),
            new System.Data.SqlClient.SqlParameter("@TecnicaP", System.Data.SqlDbType.NVarChar, 0, "TecnicaP"),
            new System.Data.SqlClient.SqlParameter("@Tecnicae", System.Data.SqlDbType.NVarChar, 0, "Tecnicae"),
            new System.Data.SqlClient.SqlParameter("@Proc", System.Data.SqlDbType.NVarChar, 0, "Proc"),
            new System.Data.SqlClient.SqlParameter("@Norma", System.Data.SqlDbType.NVarChar, 0, "Norma"),
            new System.Data.SqlClient.SqlParameter("@Material", System.Data.SqlDbType.NVarChar, 0, "Material"),
            new System.Data.SqlClient.SqlParameter("@IQIU", System.Data.SqlDbType.NVarChar, 0, "IQIU"),
            new System.Data.SqlClient.SqlParameter("@Diseño", System.Data.SqlDbType.NVarChar, 0, "Diseño"),
            new System.Data.SqlClient.SqlParameter("@NoPeliculas", System.Data.SqlDbType.NVarChar, 0, "NoPeliculas"),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ConsObra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ConsObra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fmuestreo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fmuestreo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fmuestreo", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fmuestreo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fuente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fuente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fuente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fuente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Actividad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Actividad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Actividad", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Actividad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PFocal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PFocal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PFocal", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PFocal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DFP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DFP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DFP", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DFP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TipoP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TipoP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TipoP", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TipoP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Pantalla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Pantalla", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Pantalla", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pantalla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TecnicaP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TecnicaP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TecnicaP", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TecnicaP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tecnicae", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tecnicae", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tecnicae", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tecnicae", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Proc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Proc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Proc", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Proc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Norma", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Norma", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Norma", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Norma", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Material", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Material", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Material", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Material", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IQIU", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IQIU", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IQIU", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IQIU", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Diseño", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Diseño", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Diseño", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Diseño", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NoPeliculas", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NoPeliculas", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NoPeliculas", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoPeliculas", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ConsObra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ConsObra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConsObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fmuestreo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fmuestreo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fmuestreo", System.Data.SqlDbType.SmallDateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fmuestreo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fuente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fuente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fuente", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fuente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Actividad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Actividad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Actividad", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Actividad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_PFocal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PFocal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_PFocal", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PFocal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DFP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DFP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DFP", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DFP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TipoP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TipoP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TipoP", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TipoP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Pantalla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Pantalla", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Pantalla", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pantalla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TecnicaP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TecnicaP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TecnicaP", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TecnicaP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tecnicae", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tecnicae", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tecnicae", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tecnicae", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Proc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Proc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Proc", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Proc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Norma", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Norma", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Norma", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Norma", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Material", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Material", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Material", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Material", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IQIU", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IQIU", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IQIU", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IQIU", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Diseño", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Diseño", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Diseño", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Diseño", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NoPeliculas", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NoPeliculas", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NoPeliculas", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NoPeliculas", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDARadioMdor
            // 
            this.sqlDARadioMdor.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDARadioMdor.InsertCommand = this.sqlInsertCommand1;
            this.sqlDARadioMdor.SelectCommand = this.sqlSelectCommand1;
            this.sqlDARadioMdor.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "RadioMdor", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("ConsObra", "ConsObra"),
                        new System.Data.Common.DataColumnMapping("Fmuestreo", "Fmuestreo"),
                        new System.Data.Common.DataColumnMapping("Fuente", "Fuente"),
                        new System.Data.Common.DataColumnMapping("Actividad", "Actividad"),
                        new System.Data.Common.DataColumnMapping("PFocal", "PFocal"),
                        new System.Data.Common.DataColumnMapping("DFP", "DFP"),
                        new System.Data.Common.DataColumnMapping("TipoP", "TipoP"),
                        new System.Data.Common.DataColumnMapping("Pantalla", "Pantalla"),
                        new System.Data.Common.DataColumnMapping("TecnicaP", "TecnicaP"),
                        new System.Data.Common.DataColumnMapping("Tecnicae", "Tecnicae"),
                        new System.Data.Common.DataColumnMapping("Proc", "Proc"),
                        new System.Data.Common.DataColumnMapping("Norma", "Norma"),
                        new System.Data.Common.DataColumnMapping("Material", "Material"),
                        new System.Data.Common.DataColumnMapping("IQIU", "IQIU"),
                        new System.Data.Common.DataColumnMapping("Diseño", "Diseño"),
                        new System.Data.Common.DataColumnMapping("NoPeliculas", "NoPeliculas")})});
            this.sqlDARadioMdor.UpdateCommand = this.sqlUpdateCommand1;
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
            this.sqlCommand1.CommandText = "SELECT Obra.Idobra, Obra.Ubicacion, Obra.RFC, Razonsocial.Facturar FROM Obra LEFT" +
                " OUTER JOIN Razonsocial ON Obra.IdCliente = Razonsocial.IdCliente AND Obra.RFC =" +
                " Razonsocial.RFC ORDER BY Obra.Idobra";
            this.sqlCommand1.Connection = this.sqlConn;
            // 
            // RadioMdor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 401);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDARadioMdor;
            this.dsGeneral = this.dsRadioMdor1;
            this.Name = "RadioMdor";
            this.NombreTabla = "RadioMdor";
            this.Text = "RadioMdor";
            this.Load += new System.EventHandler(this.RadioMdor_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRadioMdor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
        private System.Windows.Forms.DateTimePicker dtpFmuestreo;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.ComboBox cmbIdObra;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlConnection sqlConn;
        private System.Windows.Forms.TextBox txtNoP;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.TextBox txtIQI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.TextBox txtNorma;
        private System.Windows.Forms.TextBox txtProc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTecnicaE;
        private System.Windows.Forms.TextBox txtTecnicaP;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDPF;
        private System.Windows.Forms.TextBox txtPF;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.TextBox txtFuente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDARadioMdor;
        private dsRadioMdor dsRadioMdor1;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private dsBusObra dsBusObra1;
    }
}