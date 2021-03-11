namespace LancNeo
{
    partial class Actividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actividad));
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlDAActividad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdObra = new System.Windows.Forms.TextBox();
            this.dsActividad1 = new LancNeo.dsActividad();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sqlDAIntensidad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand15 = new System.Data.SqlClient.SqlCommand();
            this.dsIntensidad1 = new LancNeo.dsIntensidad();
            this.cmbIntensiddad = new System.Windows.Forms.ComboBox();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsBusActividad1 = new LancNeo.dsBusActividad();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.checkBox33 = new System.Windows.Forms.CheckBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.checkBox32 = new System.Windows.Forms.CheckBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.checkBox31 = new System.Windows.Forms.CheckBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.checkBox30 = new System.Windows.Forms.CheckBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.checkBox29 = new System.Windows.Forms.CheckBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.checkBox28 = new System.Windows.Forms.CheckBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.checkBox27 = new System.Windows.Forms.CheckBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label46 = new System.Windows.Forms.Label();
            this.cmbMortero = new System.Windows.Forms.ComboBox();
            this.dsGenerico1 = new LancNeo.dsGenerico();
            this.label49 = new System.Windows.Forms.Label();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.checkBox35 = new System.Windows.Forms.CheckBox();
            this.checkBox34 = new System.Windows.Forms.CheckBox();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.checkBox37 = new System.Windows.Forms.CheckBox();
            this.checkBox36 = new System.Windows.Forms.CheckBox();
            this.label80 = new System.Windows.Forms.Label();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.sqlDABusActividad = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.tbBtn2 = new Soluciones2000.Tools.WinLib.tbBtn();
            this.sqlComActividad = new System.Data.SqlClient.SqlCommand();
            this.label66 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsActividad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIntensidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusActividad1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGenerico1)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 640);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1229, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Controls.Add(this.tbBtn2);
            this.panelToolBar.Size = new System.Drawing.Size(1229, 64);
            this.panelToolBar.Controls.SetChildIndex(this.tbBtn2, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnAnterior, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnNuevo, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnVistaPrevia, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnUltimo, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnCancelar, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnEliminar, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnGuardar, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnDeshacer, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnPrimero, 0);
            this.panelToolBar.Controls.SetChildIndex(this.btnSiguiente, 0);
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDAActividad
            // 
            this.sqlDAActividad.DeleteCommand = this.sqlDeleteCommand;
            this.sqlDAActividad.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAActividad.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAActividad.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Actividad", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("IdFormato", "IdFormato"),
                        new System.Data.Common.DataColumnMapping("IdIntensidad", "IdIntensidad"),
                        new System.Data.Common.DataColumnMapping("SPorVisita", "SPorVisita"),
                        new System.Data.Common.DataColumnMapping("SPorLab", "SPorLab"),
                        new System.Data.Common.DataColumnMapping("HastaVis", "HastaVis"),
                        new System.Data.Common.DataColumnMapping("HastaVis1", "HastaVis1"),
                        new System.Data.Common.DataColumnMapping("HastaLab1", "HastaLab1"),
                        new System.Data.Common.DataColumnMapping("HastaLab2", "HastaLab2"),
                        new System.Data.Common.DataColumnMapping("Concreto", "Concreto"),
                        new System.Data.Common.DataColumnMapping("Acero", "Acero"),
                        new System.Data.Common.DataColumnMapping("Tabique", "Tabique"),
                        new System.Data.Common.DataColumnMapping("Mortero", "Mortero"),
                        new System.Data.Common.DataColumnMapping("ProSolda", "ProSolda"),
                        new System.Data.Common.DataColumnMapping("AceroEs", "AceroEs"),
                        new System.Data.Common.DataColumnMapping("Cemento", "Cemento"),
                        new System.Data.Common.DataColumnMapping("HastaCem", "HastaCem"),
                        new System.Data.Common.DataColumnMapping("Tubo", "Tubo"),
                        new System.Data.Common.DataColumnMapping("Petreo", "Petreo"),
                        new System.Data.Common.DataColumnMapping("Corazon", "Corazon"),
                        new System.Data.Common.DataColumnMapping("Base", "Base"),
                        new System.Data.Common.DataColumnMapping("Asfalto", "Asfalto"),
                        new System.Data.Common.DataColumnMapping("Elastico", "Elastico"),
                        new System.Data.Common.DataColumnMapping("Carga", "Carga"),
                        new System.Data.Common.DataColumnMapping("HastaBase", "HastaBase"),
                        new System.Data.Common.DataColumnMapping("HastaCarga", "HastaCarga"),
                        new System.Data.Common.DataColumnMapping("VConcreto", "VConcreto"),
                        new System.Data.Common.DataColumnMapping("HastaVCon", "HastaVCon"),
                        new System.Data.Common.DataColumnMapping("VAgregado", "VAgregado"),
                        new System.Data.Common.DataColumnMapping("HastaVAgr", "HastaVAgr"),
                        new System.Data.Common.DataColumnMapping("ConPla", "ConPla"),
                        new System.Data.Common.DataColumnMapping("VTerra", "VTerra"),
                        new System.Data.Common.DataColumnMapping("VTasfalto", "VTasfalto"),
                        new System.Data.Common.DataColumnMapping("VRasfalto", "VRasfalto"),
                        new System.Data.Common.DataColumnMapping("VPavimento", "VPavimento"),
                        new System.Data.Common.DataColumnMapping("VSolVar", "VSolVar"),
                        new System.Data.Common.DataColumnMapping("VSolEst", "VSolEst"),
                        new System.Data.Common.DataColumnMapping("RVisual", "RVisual"),
                        new System.Data.Common.DataColumnMapping("HastaRVis", "HastaRVis"),
                        new System.Data.Common.DataColumnMapping("HastaRVisS", "HastaRVisS"),
                        new System.Data.Common.DataColumnMapping("RSolda", "RSolda"),
                        new System.Data.Common.DataColumnMapping("HastaRSol", "HastaRSol"),
                        new System.Data.Common.DataColumnMapping("HastaRSolS", "HastaRSolS"),
                        new System.Data.Common.DataColumnMapping("RRadio", "RRadio"),
                        new System.Data.Common.DataColumnMapping("HastaRRad", "HastaRRad"),
                        new System.Data.Common.DataColumnMapping("HastaRRadS", "HastaRRadS"),
                        new System.Data.Common.DataColumnMapping("RUltra", "RUltra"),
                        new System.Data.Common.DataColumnMapping("HastaRUlt", "HastaRUlt"),
                        new System.Data.Common.DataColumnMapping("HastaRUltS", "HastaRUltS"),
                        new System.Data.Common.DataColumnMapping("RLiq", "RLiq"),
                        new System.Data.Common.DataColumnMapping("HastaRLiq", "HastaRLiq"),
                        new System.Data.Common.DataColumnMapping("HastaRLiqS", "HastaRLiqS"),
                        new System.Data.Common.DataColumnMapping("RPar", "RPar"),
                        new System.Data.Common.DataColumnMapping("HastaRPar", "HastaRPar"),
                        new System.Data.Common.DataColumnMapping("HastaRParS", "HastaRParS"),
                        new System.Data.Common.DataColumnMapping("RProbeta", "RProbeta"),
                        new System.Data.Common.DataColumnMapping("HastaRProbeta", "HastaRProbeta"),
                        new System.Data.Common.DataColumnMapping("RTorque", "RTorque"),
                        new System.Data.Common.DataColumnMapping("HastaRTorque", "HastaRTorque"),
                        new System.Data.Common.DataColumnMapping("HastaRTorqueS", "HastaRTorqueS"),
                        new System.Data.Common.DataColumnMapping("Colados", "Colados"),
                        new System.Data.Common.DataColumnMapping("Excedente", "Excedente"),
                        new System.Data.Common.DataColumnMapping("MCilCol", "MCilCol"),
                        new System.Data.Common.DataColumnMapping("MCilExc", "MCilExc"),
                        new System.Data.Common.DataColumnMapping("MCilTipo", "MCilTipo"),
                        new System.Data.Common.DataColumnMapping("MCilObra", "MCilObra"),
                        new System.Data.Common.DataColumnMapping("MCilObrP", "MCilObrP"),
                        new System.Data.Common.DataColumnMapping("MCilObrT", "MCilObrT"),
                        new System.Data.Common.DataColumnMapping("Aton", "Aton"),
                        new System.Data.Common.DataColumnMapping("AtonM", "AtonM"),
                        new System.Data.Common.DataColumnMapping("AMen", "AMen"),
                        new System.Data.Common.DataColumnMapping("AmenM", "AmenM"),
                        new System.Data.Common.DataColumnMapping("AEton", "AEton"),
                        new System.Data.Common.DataColumnMapping("AEtonM", "AEtonM"),
                        new System.Data.Common.DataColumnMapping("HastaAcero", "HastaAcero"),
                        new System.Data.Common.DataColumnMapping("HastaAceroE", "HastaAceroE"),
                        new System.Data.Common.DataColumnMapping("TipoMor", "TipoMor"),
                        new System.Data.Common.DataColumnMapping("MorMin", "MorMin"),
                        new System.Data.Common.DataColumnMapping("MorMuMi", "MorMuMi"),
                        new System.Data.Common.DataColumnMapping("MorMueM2", "MorMueM2"),
                        new System.Data.Common.DataColumnMapping("MorMueCub", "MorMueCub"),
                        new System.Data.Common.DataColumnMapping("HastaMor", "HastaMor"),
                        new System.Data.Common.DataColumnMapping("TabCad", "TabCad"),
                        new System.Data.Common.DataColumnMapping("TabTip", "TabTip"),
                        new System.Data.Common.DataColumnMapping("TabPza", "TabPza"),
                        new System.Data.Common.DataColumnMapping("HastaTab", "HastaTab"),
                        new System.Data.Common.DataColumnMapping("TerIni", "TerIni"),
                        new System.Data.Common.DataColumnMapping("TerCad", "TerCad"),
                        new System.Data.Common.DataColumnMapping("TerMe3", "TerMe3"),
                        new System.Data.Common.DataColumnMapping("HastaTer", "HastaTer"),
                        new System.Data.Common.DataColumnMapping("CalCad", "CalCad"),
                        new System.Data.Common.DataColumnMapping("BasCad", "BasCad"),
                        new System.Data.Common.DataColumnMapping("AsfCad", "AsfCad"),
                        new System.Data.Common.DataColumnMapping("HastaAsf", "HastaAsf"),
                        new System.Data.Common.DataColumnMapping("NucCad", "NucCad"),
                        new System.Data.Common.DataColumnMapping("HastaNuc", "HastaNuc"),
                        new System.Data.Common.DataColumnMapping("EmuIni", "EmuIni"),
                        new System.Data.Common.DataColumnMapping("EmuCad", "EmuCad"),
                        new System.Data.Common.DataColumnMapping("EmuMe3", "EmuMe3"),
                        new System.Data.Common.DataColumnMapping("HastaEmu", "HastaEmu"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})});
            this.sqlDAActividad.UpdateCommand = this.sqlUpdateCommand;
            // 
            // sqlDeleteCommand
            // 
            this.sqlDeleteCommand.CommandText = resources.GetString("sqlDeleteCommand.CommandText");
            this.sqlDeleteCommand.Connection = this.sqlConn;
            this.sqlDeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdFormato", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdFormato", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdIntensidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdIntensidad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdIntensidad", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdIntensidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SPorVisita", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SPorVisita", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SPorVisita", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SPorVisita", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SPorLab", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SPorLab", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SPorLab", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SPorLab", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaVis", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaVis", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaVis", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaVis", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaVis1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaVis1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaVis1", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaVis1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaLab1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaLab1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaLab1", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaLab1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaLab2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaLab2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaLab2", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaLab2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Concreto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Concreto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Concreto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Concreto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Acero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Acero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Acero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Acero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tabique", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tabique", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tabique", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tabique", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Mortero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Mortero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Mortero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mortero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ProSolda", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProSolda", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ProSolda", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProSolda", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AceroEs", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AceroEs", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AceroEs", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AceroEs", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cemento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cemento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cemento", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cemento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaCem", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaCem", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaCem", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaCem", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tubo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tubo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tubo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tubo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Petreo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Petreo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Petreo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Petreo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Corazon", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Corazon", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Corazon", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Corazon", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Base", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Base", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Base", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Base", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Asfalto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Asfalto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Asfalto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Asfalto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Elastico", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Elastico", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Elastico", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Elastico", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Carga", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Carga", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Carga", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Carga", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaBase", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaBase", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaBase", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaBase", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaCarga", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaCarga", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaCarga", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaCarga", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VConcreto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VConcreto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VConcreto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VConcreto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaVCon", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaVCon", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaVCon", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaVCon", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VAgregado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VAgregado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VAgregado", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VAgregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaVAgr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaVAgr", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaVAgr", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaVAgr", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ConPla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ConPla", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ConPla", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConPla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VTerra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VTerra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VTerra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VTerra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VTasfalto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VTasfalto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VTasfalto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VTasfalto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VRasfalto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VRasfalto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VRasfalto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VRasfalto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VPavimento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VPavimento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VPavimento", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VPavimento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VSolVar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VSolVar", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VSolVar", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VSolVar", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VSolEst", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VSolEst", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VSolEst", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VSolEst", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RVisual", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RVisual", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RVisual", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RVisual", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRVis", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRVis", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRVis", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRVis", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRVisS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRVisS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRVisS", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRVisS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RSolda", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RSolda", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RSolda", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RSolda", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRSol", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRSol", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRSol", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRSol", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRSolS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRSolS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRSolS", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRSolS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RRadio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RRadio", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RRadio", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RRadio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRRad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRRad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRRad", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRRad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRRadS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRRadS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRRadS", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRRadS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RUltra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RUltra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RUltra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RUltra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRUlt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRUlt", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRUlt", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRUlt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRUltS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRUltS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRUltS", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRUltS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RLiq", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RLiq", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RLiq", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RLiq", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRLiq", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRLiq", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRLiq", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRLiq", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRLiqS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRLiqS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRLiqS", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRLiqS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RPar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RPar", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RPar", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RPar", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRPar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRPar", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRPar", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRPar", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRParS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRParS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRParS", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRParS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RProbeta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RProbeta", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RProbeta", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RProbeta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRProbeta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRProbeta", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRProbeta", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRProbeta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RTorque", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RTorque", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RTorque", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RTorque", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRTorque", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRTorque", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRTorque", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRTorque", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRTorqueS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRTorqueS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRTorqueS", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRTorqueS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Colados", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Colados", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Colados", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Colados", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Excedente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Excedente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Excedente", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Excedente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MCilCol", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MCilCol", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MCilCol", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MCilCol", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MCilExc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MCilExc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MCilExc", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MCilExc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MCilTipo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MCilTipo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MCilTipo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MCilTipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MCilObra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MCilObra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MCilObra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MCilObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MCilObrP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MCilObrP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MCilObrP", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MCilObrP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MCilObrT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MCilObrT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MCilObrT", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MCilObrT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Aton", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Aton", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Aton", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Aton", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AtonM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AtonM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AtonM", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AtonM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AMen", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AMen", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AMen", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AMen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AmenM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AmenM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AmenM", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AmenM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AEton", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AEton", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AEton", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AEton", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AEtonM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AEtonM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AEtonM", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AEtonM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaAcero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaAcero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaAcero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaAcero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaAceroE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaAceroE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaAceroE", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaAceroE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TipoMor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TipoMor", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TipoMor", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TipoMor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MorMin", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MorMin", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MorMin", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MorMin", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MorMuMi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MorMuMi", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MorMuMi", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MorMuMi", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MorMueM2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MorMueM2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MorMueM2", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MorMueM2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MorMueCub", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MorMueCub", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MorMueCub", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MorMueCub", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaMor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaMor", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaMor", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaMor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TabCad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TabCad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TabCad", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TabCad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TabTip", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TabTip", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TabTip", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TabTip", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TabPza", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TabPza", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TabPza", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TabPza", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaTab", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaTab", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaTab", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaTab", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TerIni", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TerIni", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TerIni", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TerIni", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TerCad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TerCad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TerCad", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TerCad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TerMe3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TerMe3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TerMe3", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TerMe3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaTer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaTer", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaTer", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaTer", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CalCad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CalCad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CalCad", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CalCad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BasCad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BasCad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BasCad", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BasCad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AsfCad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AsfCad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AsfCad", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AsfCad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaAsf", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaAsf", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaAsf", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaAsf", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NucCad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NucCad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NucCad", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NucCad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaNuc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaNuc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaNuc", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaNuc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EmuIni", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmuIni", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EmuIni", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmuIni", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EmuCad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmuCad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EmuCad", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmuCad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EmuMe3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmuMe3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EmuMe3", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmuMe3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaEmu", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaEmu", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaEmu", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaEmu", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Observaciones", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@IdFormato", System.Data.SqlDbType.SmallInt, 0, "IdFormato"),
            new System.Data.SqlClient.SqlParameter("@IdIntensidad", System.Data.SqlDbType.NVarChar, 0, "IdIntensidad"),
            new System.Data.SqlClient.SqlParameter("@SPorVisita", System.Data.SqlDbType.SmallInt, 0, "SPorVisita"),
            new System.Data.SqlClient.SqlParameter("@SPorLab", System.Data.SqlDbType.SmallInt, 0, "SPorLab"),
            new System.Data.SqlClient.SqlParameter("@HastaVis", System.Data.SqlDbType.SmallInt, 0, "HastaVis"),
            new System.Data.SqlClient.SqlParameter("@HastaVis1", System.Data.SqlDbType.SmallInt, 0, "HastaVis1"),
            new System.Data.SqlClient.SqlParameter("@HastaLab1", System.Data.SqlDbType.SmallInt, 0, "HastaLab1"),
            new System.Data.SqlClient.SqlParameter("@HastaLab2", System.Data.SqlDbType.SmallInt, 0, "HastaLab2"),
            new System.Data.SqlClient.SqlParameter("@Concreto", System.Data.SqlDbType.SmallInt, 0, "Concreto"),
            new System.Data.SqlClient.SqlParameter("@Acero", System.Data.SqlDbType.SmallInt, 0, "Acero"),
            new System.Data.SqlClient.SqlParameter("@Tabique", System.Data.SqlDbType.SmallInt, 0, "Tabique"),
            new System.Data.SqlClient.SqlParameter("@Mortero", System.Data.SqlDbType.SmallInt, 0, "Mortero"),
            new System.Data.SqlClient.SqlParameter("@ProSolda", System.Data.SqlDbType.SmallInt, 0, "ProSolda"),
            new System.Data.SqlClient.SqlParameter("@AceroEs", System.Data.SqlDbType.SmallInt, 0, "AceroEs"),
            new System.Data.SqlClient.SqlParameter("@Cemento", System.Data.SqlDbType.SmallInt, 0, "Cemento"),
            new System.Data.SqlClient.SqlParameter("@HastaCem", System.Data.SqlDbType.SmallInt, 0, "HastaCem"),
            new System.Data.SqlClient.SqlParameter("@Tubo", System.Data.SqlDbType.SmallInt, 0, "Tubo"),
            new System.Data.SqlClient.SqlParameter("@Petreo", System.Data.SqlDbType.SmallInt, 0, "Petreo"),
            new System.Data.SqlClient.SqlParameter("@Corazon", System.Data.SqlDbType.SmallInt, 0, "Corazon"),
            new System.Data.SqlClient.SqlParameter("@Base", System.Data.SqlDbType.SmallInt, 0, "Base"),
            new System.Data.SqlClient.SqlParameter("@Asfalto", System.Data.SqlDbType.SmallInt, 0, "Asfalto"),
            new System.Data.SqlClient.SqlParameter("@Elastico", System.Data.SqlDbType.SmallInt, 0, "Elastico"),
            new System.Data.SqlClient.SqlParameter("@Carga", System.Data.SqlDbType.SmallInt, 0, "Carga"),
            new System.Data.SqlClient.SqlParameter("@HastaBase", System.Data.SqlDbType.SmallInt, 0, "HastaBase"),
            new System.Data.SqlClient.SqlParameter("@HastaCarga", System.Data.SqlDbType.SmallInt, 0, "HastaCarga"),
            new System.Data.SqlClient.SqlParameter("@VConcreto", System.Data.SqlDbType.SmallInt, 0, "VConcreto"),
            new System.Data.SqlClient.SqlParameter("@HastaVCon", System.Data.SqlDbType.SmallInt, 0, "HastaVCon"),
            new System.Data.SqlClient.SqlParameter("@VAgregado", System.Data.SqlDbType.SmallInt, 0, "VAgregado"),
            new System.Data.SqlClient.SqlParameter("@HastaVAgr", System.Data.SqlDbType.SmallInt, 0, "HastaVAgr"),
            new System.Data.SqlClient.SqlParameter("@ConPla", System.Data.SqlDbType.SmallInt, 0, "ConPla"),
            new System.Data.SqlClient.SqlParameter("@VTerra", System.Data.SqlDbType.SmallInt, 0, "VTerra"),
            new System.Data.SqlClient.SqlParameter("@VTasfalto", System.Data.SqlDbType.SmallInt, 0, "VTasfalto"),
            new System.Data.SqlClient.SqlParameter("@VRasfalto", System.Data.SqlDbType.SmallInt, 0, "VRasfalto"),
            new System.Data.SqlClient.SqlParameter("@VPavimento", System.Data.SqlDbType.SmallInt, 0, "VPavimento"),
            new System.Data.SqlClient.SqlParameter("@VSolVar", System.Data.SqlDbType.SmallInt, 0, "VSolVar"),
            new System.Data.SqlClient.SqlParameter("@VSolEst", System.Data.SqlDbType.SmallInt, 0, "VSolEst"),
            new System.Data.SqlClient.SqlParameter("@RVisual", System.Data.SqlDbType.SmallInt, 0, "RVisual"),
            new System.Data.SqlClient.SqlParameter("@HastaRVis", System.Data.SqlDbType.SmallInt, 0, "HastaRVis"),
            new System.Data.SqlClient.SqlParameter("@HastaRVisS", System.Data.SqlDbType.SmallInt, 0, "HastaRVisS"),
            new System.Data.SqlClient.SqlParameter("@RSolda", System.Data.SqlDbType.SmallInt, 0, "RSolda"),
            new System.Data.SqlClient.SqlParameter("@HastaRSol", System.Data.SqlDbType.SmallInt, 0, "HastaRSol"),
            new System.Data.SqlClient.SqlParameter("@HastaRSolS", System.Data.SqlDbType.SmallInt, 0, "HastaRSolS"),
            new System.Data.SqlClient.SqlParameter("@RRadio", System.Data.SqlDbType.SmallInt, 0, "RRadio"),
            new System.Data.SqlClient.SqlParameter("@HastaRRad", System.Data.SqlDbType.SmallInt, 0, "HastaRRad"),
            new System.Data.SqlClient.SqlParameter("@HastaRRadS", System.Data.SqlDbType.SmallInt, 0, "HastaRRadS"),
            new System.Data.SqlClient.SqlParameter("@RUltra", System.Data.SqlDbType.SmallInt, 0, "RUltra"),
            new System.Data.SqlClient.SqlParameter("@HastaRUlt", System.Data.SqlDbType.SmallInt, 0, "HastaRUlt"),
            new System.Data.SqlClient.SqlParameter("@HastaRUltS", System.Data.SqlDbType.SmallInt, 0, "HastaRUltS"),
            new System.Data.SqlClient.SqlParameter("@RLiq", System.Data.SqlDbType.SmallInt, 0, "RLiq"),
            new System.Data.SqlClient.SqlParameter("@HastaRLiq", System.Data.SqlDbType.SmallInt, 0, "HastaRLiq"),
            new System.Data.SqlClient.SqlParameter("@HastaRLiqS", System.Data.SqlDbType.SmallInt, 0, "HastaRLiqS"),
            new System.Data.SqlClient.SqlParameter("@RPar", System.Data.SqlDbType.SmallInt, 0, "RPar"),
            new System.Data.SqlClient.SqlParameter("@HastaRPar", System.Data.SqlDbType.SmallInt, 0, "HastaRPar"),
            new System.Data.SqlClient.SqlParameter("@HastaRParS", System.Data.SqlDbType.SmallInt, 0, "HastaRParS"),
            new System.Data.SqlClient.SqlParameter("@RProbeta", System.Data.SqlDbType.SmallInt, 0, "RProbeta"),
            new System.Data.SqlClient.SqlParameter("@HastaRProbeta", System.Data.SqlDbType.SmallInt, 0, "HastaRProbeta"),
            new System.Data.SqlClient.SqlParameter("@RTorque", System.Data.SqlDbType.SmallInt, 0, "RTorque"),
            new System.Data.SqlClient.SqlParameter("@HastaRTorque", System.Data.SqlDbType.SmallInt, 0, "HastaRTorque"),
            new System.Data.SqlClient.SqlParameter("@HastaRTorqueS", System.Data.SqlDbType.SmallInt, 0, "HastaRTorqueS"),
            new System.Data.SqlClient.SqlParameter("@Colados", System.Data.SqlDbType.SmallInt, 0, "Colados"),
            new System.Data.SqlClient.SqlParameter("@Excedente", System.Data.SqlDbType.SmallInt, 0, "Excedente"),
            new System.Data.SqlClient.SqlParameter("@MCilCol", System.Data.SqlDbType.SmallInt, 0, "MCilCol"),
            new System.Data.SqlClient.SqlParameter("@MCilExc", System.Data.SqlDbType.SmallInt, 0, "MCilExc"),
            new System.Data.SqlClient.SqlParameter("@MCilTipo", System.Data.SqlDbType.SmallInt, 0, "MCilTipo"),
            new System.Data.SqlClient.SqlParameter("@MCilObra", System.Data.SqlDbType.SmallInt, 0, "MCilObra"),
            new System.Data.SqlClient.SqlParameter("@MCilObrP", System.Data.SqlDbType.SmallInt, 0, "MCilObrP"),
            new System.Data.SqlClient.SqlParameter("@MCilObrT", System.Data.SqlDbType.SmallInt, 0, "MCilObrT"),
            new System.Data.SqlClient.SqlParameter("@Aton", System.Data.SqlDbType.SmallInt, 0, "Aton"),
            new System.Data.SqlClient.SqlParameter("@AtonM", System.Data.SqlDbType.SmallInt, 0, "AtonM"),
            new System.Data.SqlClient.SqlParameter("@AMen", System.Data.SqlDbType.SmallInt, 0, "AMen"),
            new System.Data.SqlClient.SqlParameter("@AmenM", System.Data.SqlDbType.SmallInt, 0, "AmenM"),
            new System.Data.SqlClient.SqlParameter("@AEton", System.Data.SqlDbType.SmallInt, 0, "AEton"),
            new System.Data.SqlClient.SqlParameter("@AEtonM", System.Data.SqlDbType.SmallInt, 0, "AEtonM"),
            new System.Data.SqlClient.SqlParameter("@HastaAcero", System.Data.SqlDbType.SmallInt, 0, "HastaAcero"),
            new System.Data.SqlClient.SqlParameter("@HastaAceroE", System.Data.SqlDbType.SmallInt, 0, "HastaAceroE"),
            new System.Data.SqlClient.SqlParameter("@TipoMor", System.Data.SqlDbType.SmallInt, 0, "TipoMor"),
            new System.Data.SqlClient.SqlParameter("@MorMin", System.Data.SqlDbType.SmallInt, 0, "MorMin"),
            new System.Data.SqlClient.SqlParameter("@MorMuMi", System.Data.SqlDbType.SmallInt, 0, "MorMuMi"),
            new System.Data.SqlClient.SqlParameter("@MorMueM2", System.Data.SqlDbType.SmallInt, 0, "MorMueM2"),
            new System.Data.SqlClient.SqlParameter("@MorMueCub", System.Data.SqlDbType.NVarChar, 0, "MorMueCub"),
            new System.Data.SqlClient.SqlParameter("@HastaMor", System.Data.SqlDbType.SmallInt, 0, "HastaMor"),
            new System.Data.SqlClient.SqlParameter("@TabCad", System.Data.SqlDbType.SmallInt, 0, "TabCad"),
            new System.Data.SqlClient.SqlParameter("@TabTip", System.Data.SqlDbType.SmallInt, 0, "TabTip"),
            new System.Data.SqlClient.SqlParameter("@TabPza", System.Data.SqlDbType.SmallInt, 0, "TabPza"),
            new System.Data.SqlClient.SqlParameter("@HastaTab", System.Data.SqlDbType.SmallInt, 0, "HastaTab"),
            new System.Data.SqlClient.SqlParameter("@TerIni", System.Data.SqlDbType.SmallInt, 0, "TerIni"),
            new System.Data.SqlClient.SqlParameter("@TerCad", System.Data.SqlDbType.SmallInt, 0, "TerCad"),
            new System.Data.SqlClient.SqlParameter("@TerMe3", System.Data.SqlDbType.SmallInt, 0, "TerMe3"),
            new System.Data.SqlClient.SqlParameter("@HastaTer", System.Data.SqlDbType.SmallInt, 0, "HastaTer"),
            new System.Data.SqlClient.SqlParameter("@CalCad", System.Data.SqlDbType.SmallInt, 0, "CalCad"),
            new System.Data.SqlClient.SqlParameter("@BasCad", System.Data.SqlDbType.SmallInt, 0, "BasCad"),
            new System.Data.SqlClient.SqlParameter("@AsfCad", System.Data.SqlDbType.SmallInt, 0, "AsfCad"),
            new System.Data.SqlClient.SqlParameter("@HastaAsf", System.Data.SqlDbType.SmallInt, 0, "HastaAsf"),
            new System.Data.SqlClient.SqlParameter("@NucCad", System.Data.SqlDbType.SmallInt, 0, "NucCad"),
            new System.Data.SqlClient.SqlParameter("@HastaNuc", System.Data.SqlDbType.SmallInt, 0, "HastaNuc"),
            new System.Data.SqlClient.SqlParameter("@EmuIni", System.Data.SqlDbType.SmallInt, 0, "EmuIni"),
            new System.Data.SqlClient.SqlParameter("@EmuCad", System.Data.SqlDbType.SmallInt, 0, "EmuCad"),
            new System.Data.SqlClient.SqlParameter("@EmuMe3", System.Data.SqlDbType.SmallInt, 0, "EmuMe3"),
            new System.Data.SqlClient.SqlParameter("@HastaEmu", System.Data.SqlDbType.SmallInt, 0, "HastaEmu"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 0, "Observaciones")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand
            // 
            this.sqlUpdateCommand.CommandText = resources.GetString("sqlUpdateCommand.CommandText");
            this.sqlUpdateCommand.Connection = this.sqlConn;
            this.sqlUpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 0, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@IdFormato", System.Data.SqlDbType.SmallInt, 0, "IdFormato"),
            new System.Data.SqlClient.SqlParameter("@IdIntensidad", System.Data.SqlDbType.NVarChar, 0, "IdIntensidad"),
            new System.Data.SqlClient.SqlParameter("@SPorVisita", System.Data.SqlDbType.SmallInt, 0, "SPorVisita"),
            new System.Data.SqlClient.SqlParameter("@SPorLab", System.Data.SqlDbType.SmallInt, 0, "SPorLab"),
            new System.Data.SqlClient.SqlParameter("@HastaVis", System.Data.SqlDbType.SmallInt, 0, "HastaVis"),
            new System.Data.SqlClient.SqlParameter("@HastaVis1", System.Data.SqlDbType.SmallInt, 0, "HastaVis1"),
            new System.Data.SqlClient.SqlParameter("@HastaLab1", System.Data.SqlDbType.SmallInt, 0, "HastaLab1"),
            new System.Data.SqlClient.SqlParameter("@HastaLab2", System.Data.SqlDbType.SmallInt, 0, "HastaLab2"),
            new System.Data.SqlClient.SqlParameter("@Concreto", System.Data.SqlDbType.SmallInt, 0, "Concreto"),
            new System.Data.SqlClient.SqlParameter("@Acero", System.Data.SqlDbType.SmallInt, 0, "Acero"),
            new System.Data.SqlClient.SqlParameter("@Tabique", System.Data.SqlDbType.SmallInt, 0, "Tabique"),
            new System.Data.SqlClient.SqlParameter("@Mortero", System.Data.SqlDbType.SmallInt, 0, "Mortero"),
            new System.Data.SqlClient.SqlParameter("@ProSolda", System.Data.SqlDbType.SmallInt, 0, "ProSolda"),
            new System.Data.SqlClient.SqlParameter("@AceroEs", System.Data.SqlDbType.SmallInt, 0, "AceroEs"),
            new System.Data.SqlClient.SqlParameter("@Cemento", System.Data.SqlDbType.SmallInt, 0, "Cemento"),
            new System.Data.SqlClient.SqlParameter("@HastaCem", System.Data.SqlDbType.SmallInt, 0, "HastaCem"),
            new System.Data.SqlClient.SqlParameter("@Tubo", System.Data.SqlDbType.SmallInt, 0, "Tubo"),
            new System.Data.SqlClient.SqlParameter("@Petreo", System.Data.SqlDbType.SmallInt, 0, "Petreo"),
            new System.Data.SqlClient.SqlParameter("@Corazon", System.Data.SqlDbType.SmallInt, 0, "Corazon"),
            new System.Data.SqlClient.SqlParameter("@Base", System.Data.SqlDbType.SmallInt, 0, "Base"),
            new System.Data.SqlClient.SqlParameter("@Asfalto", System.Data.SqlDbType.SmallInt, 0, "Asfalto"),
            new System.Data.SqlClient.SqlParameter("@Elastico", System.Data.SqlDbType.SmallInt, 0, "Elastico"),
            new System.Data.SqlClient.SqlParameter("@Carga", System.Data.SqlDbType.SmallInt, 0, "Carga"),
            new System.Data.SqlClient.SqlParameter("@HastaBase", System.Data.SqlDbType.SmallInt, 0, "HastaBase"),
            new System.Data.SqlClient.SqlParameter("@HastaCarga", System.Data.SqlDbType.SmallInt, 0, "HastaCarga"),
            new System.Data.SqlClient.SqlParameter("@VConcreto", System.Data.SqlDbType.SmallInt, 0, "VConcreto"),
            new System.Data.SqlClient.SqlParameter("@HastaVCon", System.Data.SqlDbType.SmallInt, 0, "HastaVCon"),
            new System.Data.SqlClient.SqlParameter("@VAgregado", System.Data.SqlDbType.SmallInt, 0, "VAgregado"),
            new System.Data.SqlClient.SqlParameter("@HastaVAgr", System.Data.SqlDbType.SmallInt, 0, "HastaVAgr"),
            new System.Data.SqlClient.SqlParameter("@ConPla", System.Data.SqlDbType.SmallInt, 0, "ConPla"),
            new System.Data.SqlClient.SqlParameter("@VTerra", System.Data.SqlDbType.SmallInt, 0, "VTerra"),
            new System.Data.SqlClient.SqlParameter("@VTasfalto", System.Data.SqlDbType.SmallInt, 0, "VTasfalto"),
            new System.Data.SqlClient.SqlParameter("@VRasfalto", System.Data.SqlDbType.SmallInt, 0, "VRasfalto"),
            new System.Data.SqlClient.SqlParameter("@VPavimento", System.Data.SqlDbType.SmallInt, 0, "VPavimento"),
            new System.Data.SqlClient.SqlParameter("@VSolVar", System.Data.SqlDbType.SmallInt, 0, "VSolVar"),
            new System.Data.SqlClient.SqlParameter("@VSolEst", System.Data.SqlDbType.SmallInt, 0, "VSolEst"),
            new System.Data.SqlClient.SqlParameter("@RVisual", System.Data.SqlDbType.SmallInt, 0, "RVisual"),
            new System.Data.SqlClient.SqlParameter("@HastaRVis", System.Data.SqlDbType.SmallInt, 0, "HastaRVis"),
            new System.Data.SqlClient.SqlParameter("@HastaRVisS", System.Data.SqlDbType.SmallInt, 0, "HastaRVisS"),
            new System.Data.SqlClient.SqlParameter("@RSolda", System.Data.SqlDbType.SmallInt, 0, "RSolda"),
            new System.Data.SqlClient.SqlParameter("@HastaRSol", System.Data.SqlDbType.SmallInt, 0, "HastaRSol"),
            new System.Data.SqlClient.SqlParameter("@HastaRSolS", System.Data.SqlDbType.SmallInt, 0, "HastaRSolS"),
            new System.Data.SqlClient.SqlParameter("@RRadio", System.Data.SqlDbType.SmallInt, 0, "RRadio"),
            new System.Data.SqlClient.SqlParameter("@HastaRRad", System.Data.SqlDbType.SmallInt, 0, "HastaRRad"),
            new System.Data.SqlClient.SqlParameter("@HastaRRadS", System.Data.SqlDbType.SmallInt, 0, "HastaRRadS"),
            new System.Data.SqlClient.SqlParameter("@RUltra", System.Data.SqlDbType.SmallInt, 0, "RUltra"),
            new System.Data.SqlClient.SqlParameter("@HastaRUlt", System.Data.SqlDbType.SmallInt, 0, "HastaRUlt"),
            new System.Data.SqlClient.SqlParameter("@HastaRUltS", System.Data.SqlDbType.SmallInt, 0, "HastaRUltS"),
            new System.Data.SqlClient.SqlParameter("@RLiq", System.Data.SqlDbType.SmallInt, 0, "RLiq"),
            new System.Data.SqlClient.SqlParameter("@HastaRLiq", System.Data.SqlDbType.SmallInt, 0, "HastaRLiq"),
            new System.Data.SqlClient.SqlParameter("@HastaRLiqS", System.Data.SqlDbType.SmallInt, 0, "HastaRLiqS"),
            new System.Data.SqlClient.SqlParameter("@RPar", System.Data.SqlDbType.SmallInt, 0, "RPar"),
            new System.Data.SqlClient.SqlParameter("@HastaRPar", System.Data.SqlDbType.SmallInt, 0, "HastaRPar"),
            new System.Data.SqlClient.SqlParameter("@HastaRParS", System.Data.SqlDbType.SmallInt, 0, "HastaRParS"),
            new System.Data.SqlClient.SqlParameter("@RProbeta", System.Data.SqlDbType.SmallInt, 0, "RProbeta"),
            new System.Data.SqlClient.SqlParameter("@HastaRProbeta", System.Data.SqlDbType.SmallInt, 0, "HastaRProbeta"),
            new System.Data.SqlClient.SqlParameter("@RTorque", System.Data.SqlDbType.SmallInt, 0, "RTorque"),
            new System.Data.SqlClient.SqlParameter("@HastaRTorque", System.Data.SqlDbType.SmallInt, 0, "HastaRTorque"),
            new System.Data.SqlClient.SqlParameter("@HastaRTorqueS", System.Data.SqlDbType.SmallInt, 0, "HastaRTorqueS"),
            new System.Data.SqlClient.SqlParameter("@Colados", System.Data.SqlDbType.SmallInt, 0, "Colados"),
            new System.Data.SqlClient.SqlParameter("@Excedente", System.Data.SqlDbType.SmallInt, 0, "Excedente"),
            new System.Data.SqlClient.SqlParameter("@MCilCol", System.Data.SqlDbType.SmallInt, 0, "MCilCol"),
            new System.Data.SqlClient.SqlParameter("@MCilExc", System.Data.SqlDbType.SmallInt, 0, "MCilExc"),
            new System.Data.SqlClient.SqlParameter("@MCilTipo", System.Data.SqlDbType.SmallInt, 0, "MCilTipo"),
            new System.Data.SqlClient.SqlParameter("@MCilObra", System.Data.SqlDbType.SmallInt, 0, "MCilObra"),
            new System.Data.SqlClient.SqlParameter("@MCilObrP", System.Data.SqlDbType.SmallInt, 0, "MCilObrP"),
            new System.Data.SqlClient.SqlParameter("@MCilObrT", System.Data.SqlDbType.SmallInt, 0, "MCilObrT"),
            new System.Data.SqlClient.SqlParameter("@Aton", System.Data.SqlDbType.SmallInt, 0, "Aton"),
            new System.Data.SqlClient.SqlParameter("@AtonM", System.Data.SqlDbType.SmallInt, 0, "AtonM"),
            new System.Data.SqlClient.SqlParameter("@AMen", System.Data.SqlDbType.SmallInt, 0, "AMen"),
            new System.Data.SqlClient.SqlParameter("@AmenM", System.Data.SqlDbType.SmallInt, 0, "AmenM"),
            new System.Data.SqlClient.SqlParameter("@AEton", System.Data.SqlDbType.SmallInt, 0, "AEton"),
            new System.Data.SqlClient.SqlParameter("@AEtonM", System.Data.SqlDbType.SmallInt, 0, "AEtonM"),
            new System.Data.SqlClient.SqlParameter("@HastaAcero", System.Data.SqlDbType.SmallInt, 0, "HastaAcero"),
            new System.Data.SqlClient.SqlParameter("@HastaAceroE", System.Data.SqlDbType.SmallInt, 0, "HastaAceroE"),
            new System.Data.SqlClient.SqlParameter("@TipoMor", System.Data.SqlDbType.SmallInt, 0, "TipoMor"),
            new System.Data.SqlClient.SqlParameter("@MorMin", System.Data.SqlDbType.SmallInt, 0, "MorMin"),
            new System.Data.SqlClient.SqlParameter("@MorMuMi", System.Data.SqlDbType.SmallInt, 0, "MorMuMi"),
            new System.Data.SqlClient.SqlParameter("@MorMueM2", System.Data.SqlDbType.SmallInt, 0, "MorMueM2"),
            new System.Data.SqlClient.SqlParameter("@MorMueCub", System.Data.SqlDbType.NVarChar, 0, "MorMueCub"),
            new System.Data.SqlClient.SqlParameter("@HastaMor", System.Data.SqlDbType.SmallInt, 0, "HastaMor"),
            new System.Data.SqlClient.SqlParameter("@TabCad", System.Data.SqlDbType.SmallInt, 0, "TabCad"),
            new System.Data.SqlClient.SqlParameter("@TabTip", System.Data.SqlDbType.SmallInt, 0, "TabTip"),
            new System.Data.SqlClient.SqlParameter("@TabPza", System.Data.SqlDbType.SmallInt, 0, "TabPza"),
            new System.Data.SqlClient.SqlParameter("@HastaTab", System.Data.SqlDbType.SmallInt, 0, "HastaTab"),
            new System.Data.SqlClient.SqlParameter("@TerIni", System.Data.SqlDbType.SmallInt, 0, "TerIni"),
            new System.Data.SqlClient.SqlParameter("@TerCad", System.Data.SqlDbType.SmallInt, 0, "TerCad"),
            new System.Data.SqlClient.SqlParameter("@TerMe3", System.Data.SqlDbType.SmallInt, 0, "TerMe3"),
            new System.Data.SqlClient.SqlParameter("@HastaTer", System.Data.SqlDbType.SmallInt, 0, "HastaTer"),
            new System.Data.SqlClient.SqlParameter("@CalCad", System.Data.SqlDbType.SmallInt, 0, "CalCad"),
            new System.Data.SqlClient.SqlParameter("@BasCad", System.Data.SqlDbType.SmallInt, 0, "BasCad"),
            new System.Data.SqlClient.SqlParameter("@AsfCad", System.Data.SqlDbType.SmallInt, 0, "AsfCad"),
            new System.Data.SqlClient.SqlParameter("@HastaAsf", System.Data.SqlDbType.SmallInt, 0, "HastaAsf"),
            new System.Data.SqlClient.SqlParameter("@NucCad", System.Data.SqlDbType.SmallInt, 0, "NucCad"),
            new System.Data.SqlClient.SqlParameter("@HastaNuc", System.Data.SqlDbType.SmallInt, 0, "HastaNuc"),
            new System.Data.SqlClient.SqlParameter("@EmuIni", System.Data.SqlDbType.SmallInt, 0, "EmuIni"),
            new System.Data.SqlClient.SqlParameter("@EmuCad", System.Data.SqlDbType.SmallInt, 0, "EmuCad"),
            new System.Data.SqlClient.SqlParameter("@EmuMe3", System.Data.SqlDbType.SmallInt, 0, "EmuMe3"),
            new System.Data.SqlClient.SqlParameter("@HastaEmu", System.Data.SqlDbType.SmallInt, 0, "HastaEmu"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 0, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdFormato", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdFormato", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdIntensidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdIntensidad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdIntensidad", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdIntensidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SPorVisita", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SPorVisita", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SPorVisita", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SPorVisita", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_SPorLab", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SPorLab", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_SPorLab", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SPorLab", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaVis", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaVis", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaVis", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaVis", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaVis1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaVis1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaVis1", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaVis1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaLab1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaLab1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaLab1", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaLab1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaLab2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaLab2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaLab2", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaLab2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Concreto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Concreto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Concreto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Concreto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Acero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Acero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Acero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Acero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tabique", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tabique", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tabique", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tabique", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Mortero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Mortero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Mortero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mortero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ProSolda", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProSolda", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ProSolda", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProSolda", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AceroEs", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AceroEs", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AceroEs", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AceroEs", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Cemento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cemento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Cemento", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cemento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaCem", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaCem", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaCem", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaCem", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tubo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tubo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tubo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tubo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Petreo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Petreo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Petreo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Petreo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Corazon", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Corazon", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Corazon", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Corazon", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Base", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Base", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Base", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Base", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Asfalto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Asfalto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Asfalto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Asfalto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Elastico", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Elastico", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Elastico", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Elastico", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Carga", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Carga", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Carga", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Carga", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaBase", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaBase", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaBase", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaBase", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaCarga", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaCarga", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaCarga", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaCarga", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VConcreto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VConcreto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VConcreto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VConcreto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaVCon", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaVCon", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaVCon", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaVCon", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VAgregado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VAgregado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VAgregado", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VAgregado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaVAgr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaVAgr", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaVAgr", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaVAgr", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ConPla", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ConPla", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ConPla", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConPla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VTerra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VTerra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VTerra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VTerra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VTasfalto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VTasfalto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VTasfalto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VTasfalto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VRasfalto", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VRasfalto", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VRasfalto", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VRasfalto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VPavimento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VPavimento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VPavimento", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VPavimento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VSolVar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VSolVar", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VSolVar", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VSolVar", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VSolEst", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VSolEst", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VSolEst", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VSolEst", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RVisual", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RVisual", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RVisual", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RVisual", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRVis", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRVis", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRVis", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRVis", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRVisS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRVisS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRVisS", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRVisS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RSolda", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RSolda", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RSolda", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RSolda", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRSol", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRSol", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRSol", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRSol", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRSolS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRSolS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRSolS", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRSolS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RRadio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RRadio", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RRadio", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RRadio", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRRad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRRad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRRad", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRRad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRRadS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRRadS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRRadS", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRRadS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RUltra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RUltra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RUltra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RUltra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRUlt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRUlt", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRUlt", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRUlt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRUltS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRUltS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRUltS", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRUltS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RLiq", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RLiq", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RLiq", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RLiq", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRLiq", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRLiq", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRLiq", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRLiq", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRLiqS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRLiqS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRLiqS", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRLiqS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RPar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RPar", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RPar", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RPar", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRPar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRPar", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRPar", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRPar", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRParS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRParS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRParS", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRParS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RProbeta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RProbeta", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RProbeta", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RProbeta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRProbeta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRProbeta", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRProbeta", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRProbeta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_RTorque", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RTorque", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_RTorque", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RTorque", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRTorque", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRTorque", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRTorque", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRTorque", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaRTorqueS", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaRTorqueS", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaRTorqueS", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaRTorqueS", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Colados", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Colados", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Colados", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Colados", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Excedente", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Excedente", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Excedente", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Excedente", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MCilCol", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MCilCol", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MCilCol", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MCilCol", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MCilExc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MCilExc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MCilExc", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MCilExc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MCilTipo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MCilTipo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MCilTipo", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MCilTipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MCilObra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MCilObra", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MCilObra", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MCilObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MCilObrP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MCilObrP", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MCilObrP", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MCilObrP", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MCilObrT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MCilObrT", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MCilObrT", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MCilObrT", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Aton", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Aton", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Aton", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Aton", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AtonM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AtonM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AtonM", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AtonM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AMen", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AMen", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AMen", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AMen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AmenM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AmenM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AmenM", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AmenM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AEton", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AEton", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AEton", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AEton", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AEtonM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AEtonM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AEtonM", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AEtonM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaAcero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaAcero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaAcero", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaAcero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaAceroE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaAceroE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaAceroE", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaAceroE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TipoMor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TipoMor", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TipoMor", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TipoMor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MorMin", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MorMin", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MorMin", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MorMin", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MorMuMi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MorMuMi", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MorMuMi", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MorMuMi", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MorMueM2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MorMueM2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MorMueM2", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MorMueM2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_MorMueCub", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MorMueCub", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_MorMueCub", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MorMueCub", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaMor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaMor", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaMor", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaMor", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TabCad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TabCad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TabCad", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TabCad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TabTip", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TabTip", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TabTip", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TabTip", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TabPza", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TabPza", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TabPza", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TabPza", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaTab", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaTab", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaTab", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaTab", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TerIni", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TerIni", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TerIni", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TerIni", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TerCad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TerCad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TerCad", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TerCad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TerMe3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TerMe3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TerMe3", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TerMe3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaTer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaTer", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaTer", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaTer", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CalCad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CalCad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CalCad", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CalCad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_BasCad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BasCad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_BasCad", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BasCad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AsfCad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AsfCad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AsfCad", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AsfCad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaAsf", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaAsf", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaAsf", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaAsf", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_NucCad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NucCad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_NucCad", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NucCad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaNuc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaNuc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaNuc", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaNuc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EmuIni", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmuIni", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EmuIni", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmuIni", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EmuCad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmuCad", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EmuCad", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmuCad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EmuMe3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmuMe3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EmuMe3", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmuMe3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HastaEmu", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HastaEmu", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HastaEmu", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HastaEmu", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Observaciones", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null)});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Obra:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIdObra
            // 
            this.txtIdObra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.IdObra", true));
            this.txtIdObra.Location = new System.Drawing.Point(56, 92);
            this.txtIdObra.MaxLength = 6;
            this.txtIdObra.Name = "txtIdObra";
            this.txtIdObra.Size = new System.Drawing.Size(52, 20);
            this.txtIdObra.TabIndex = 5;
            // 
            // dsActividad1
            // 
            this.dsActividad1.DataSetName = "dsActividad";
            this.dsActividad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.IdFormato", true));
            this.textBox2.Location = new System.Drawing.Point(56, 118);
            this.textBox2.MaxLength = 1;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(24, 20);
            this.textBox2.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBox2, "Elija 1, 2, 3 o 4");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Formato:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sistema:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sqlDAIntensidad
            // 
            this.sqlDAIntensidad.SelectCommand = this.sqlCommand15;
            this.sqlDAIntensidad.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CatServicios", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdServicio", "IdServicio"),
                        new System.Data.Common.DataColumnMapping("Descripción", "Descripción")})});
            // 
            // sqlCommand15
            // 
            this.sqlCommand15.CommandText = "SELECT DISTINCT IdIntensidad, Inferiores, Adicionales, Acero, AceroRem, Prefabirc" +
    "ados, revenimiento, Croquis, Laboratorio, Calas, Mortero\r\nFROM         Intensida" +
    "d";
            this.sqlCommand15.Connection = this.sqlConn;
            // 
            // dsIntensidad1
            // 
            this.dsIntensidad1.DataSetName = "dsIntensidad";
            this.dsIntensidad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbIntensiddad
            // 
            this.cmbIntensiddad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsActividad1, "Actividad.IdIntensidad", true));
            this.cmbIntensiddad.DataSource = this.dsIntensidad1;
            this.cmbIntensiddad.DisplayMember = "Intensidad.IdIntensidad";
            this.cmbIntensiddad.FormattingEnabled = true;
            this.cmbIntensiddad.Location = new System.Drawing.Point(56, 144);
            this.cmbIntensiddad.Name = "cmbIntensiddad";
            this.cmbIntensiddad.Size = new System.Drawing.Size(52, 21);
            this.cmbIntensiddad.TabIndex = 86;
            this.cmbIntensiddad.ValueMember = "Intensidad.IdIntensidad";
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 450;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsBusActividad1.Actividad;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(131, 95);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 96;
            // 
            // dsBusActividad1
            // 
            this.dsBusActividad1.DataSetName = "dsBusActividad";
            this.dsBusActividad1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 97;
            this.label4.Text = "Tipo de servicio:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.SPorVisita", true));
            this.checkBox1.Location = new System.Drawing.Point(331, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 17);
            this.checkBox1.TabIndex = 98;
            this.checkBox1.Text = "Por visita muestreador";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "Hasta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaVis", true));
            this.textBox3.Location = new System.Drawing.Point(479, 83);
            this.textBox3.MaxLength = 3;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(32, 20);
            this.textBox3.TabIndex = 100;
            this.toolTip1.SetToolTip(this.textBox3, "Elija 1, 2, 3 o 4");
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaVis1", true));
            this.textBox4.Location = new System.Drawing.Point(528, 83);
            this.textBox4.MaxLength = 3;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(32, 20);
            this.textBox4.TabIndex = 101;
            this.toolTip1.SetToolTip(this.textBox4, "Elija 1, 2, 3 o 4");
            this.textBox4.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.SPorLab", true));
            this.checkBox2.Location = new System.Drawing.Point(588, 85);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 17);
            this.checkBox2.TabIndex = 102;
            this.checkBox2.Text = "Por semana";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaLab2", true));
            this.textBox5.Location = new System.Drawing.Point(929, 82);
            this.textBox5.MaxLength = 3;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(32, 20);
            this.textBox5.TabIndex = 104;
            this.toolTip1.SetToolTip(this.textBox5, "Elija 1, 2, 3 o 4");
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaLab1", true));
            this.textBox6.Location = new System.Drawing.Point(678, 82);
            this.textBox6.MaxLength = 3;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(32, 20);
            this.textBox6.TabIndex = 103;
            this.toolTip1.SetToolTip(this.textBox6, "Elija 1, 2, 3 o 4");
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(698, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 105;
            this.label6.Text = "Hasta";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 106;
            this.label7.Text = "Debe muestrearse:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.checkBox16);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.checkBox15);
            this.panel2.Controls.Add(this.checkBox14);
            this.panel2.Controls.Add(this.checkBox13);
            this.panel2.Controls.Add(this.checkBox12);
            this.panel2.Controls.Add(this.checkBox11);
            this.panel2.Controls.Add(this.checkBox10);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.checkBox9);
            this.panel2.Controls.Add(this.checkBox8);
            this.panel2.Controls.Add(this.checkBox7);
            this.panel2.Controls.Add(this.checkBox6);
            this.panel2.Controls.Add(this.checkBox5);
            this.panel2.Controls.Add(this.checkBox4);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Location = new System.Drawing.Point(331, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 89);
            this.panel2.TabIndex = 107;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaCarga", true));
            this.textBox9.Location = new System.Drawing.Point(417, 61);
            this.textBox9.MaxLength = 3;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(32, 20);
            this.textBox9.TabIndex = 121;
            this.toolTip1.SetToolTip(this.textBox9, "Elija 1, 2, 3 o 4");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(379, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 119;
            this.label10.Text = "hasta";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.Carga", true));
            this.checkBox16.Location = new System.Drawing.Point(268, 63);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(110, 17);
            this.checkBox16.TabIndex = 120;
            this.checkBox16.Text = "Pruebas de carga";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaBase", true));
            this.textBox8.Location = new System.Drawing.Point(148, 62);
            this.textBox8.MaxLength = 3;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(32, 20);
            this.textBox8.TabIndex = 118;
            this.toolTip1.SetToolTip(this.textBox8, "Elija 1, 2, 3 o 4");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 116;
            this.label9.Text = "hasta";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.Elastico", true));
            this.checkBox15.Location = new System.Drawing.Point(9, 64);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(100, 17);
            this.checkBox15.TabIndex = 117;
            this.checkBox15.Text = "Módulo elastico";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.Asfalto", true));
            this.checkBox14.Location = new System.Drawing.Point(428, 42);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(105, 17);
            this.checkBox14.TabIndex = 115;
            this.checkBox14.Text = "Material asfaltico";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.Base", true));
            this.checkBox13.Location = new System.Drawing.Point(428, 22);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(193, 17);
            this.checkBox13.TabIndex = 114;
            this.checkBox13.Text = "Material para base hid. y terracerias";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.Corazon", true));
            this.checkBox12.Location = new System.Drawing.Point(428, 5);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(76, 17);
            this.checkBox12.TabIndex = 113;
            this.checkBox12.Text = "Corazones";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.Petreo", true));
            this.checkBox11.Location = new System.Drawing.Point(268, 42);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(115, 17);
            this.checkBox11.TabIndex = 112;
            this.checkBox11.Text = "Agregados petreos";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.Tubo", true));
            this.checkBox10.Location = new System.Drawing.Point(268, 22);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(88, 17);
            this.checkBox10.TabIndex = 111;
            this.checkBox10.Text = "Tubo albañal";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaCem", true));
            this.textBox7.Location = new System.Drawing.Point(380, 1);
            this.textBox7.MaxLength = 3;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(32, 20);
            this.textBox7.TabIndex = 110;
            this.toolTip1.SetToolTip(this.textBox7, "Elija 1, 2, 3 o 4");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 108;
            this.label8.Text = "hasta";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.Cemento", true));
            this.checkBox9.Location = new System.Drawing.Point(268, 3);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(68, 17);
            this.checkBox9.TabIndex = 109;
            this.checkBox9.Text = "Cemento";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.AceroEs", true));
            this.checkBox8.Location = new System.Drawing.Point(146, 42);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(106, 17);
            this.checkBox8.TabIndex = 108;
            this.checkBox8.Text = "Acero estructural";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.ProSolda", true));
            this.checkBox7.Location = new System.Drawing.Point(146, 22);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(113, 17);
            this.checkBox7.TabIndex = 107;
            this.checkBox7.Text = "Probetas soldadas";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.Mortero", true));
            this.checkBox6.Location = new System.Drawing.Point(146, 3);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(62, 17);
            this.checkBox6.TabIndex = 106;
            this.checkBox6.Text = "Mortero";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.Tabique", true));
            this.checkBox5.Location = new System.Drawing.Point(9, 42);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(103, 17);
            this.checkBox5.TabIndex = 105;
            this.checkBox5.Text = "Tabique o block";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.Acero", true));
            this.checkBox4.Location = new System.Drawing.Point(9, 22);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(110, 17);
            this.checkBox4.TabIndex = 104;
            this.checkBox4.Text = "Acero de refuerzo";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.Concreto", true));
            this.checkBox3.Location = new System.Drawing.Point(9, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(69, 17);
            this.checkBox3.TabIndex = 103;
            this.checkBox3.Text = "Concreto";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.checkBox25);
            this.panel3.Controls.Add(this.checkBox24);
            this.panel3.Controls.Add(this.checkBox23);
            this.panel3.Controls.Add(this.checkBox22);
            this.panel3.Controls.Add(this.checkBox21);
            this.panel3.Controls.Add(this.checkBox20);
            this.panel3.Controls.Add(this.checkBox19);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.textBox11);
            this.panel3.Controls.Add(this.textBox10);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.checkBox18);
            this.panel3.Controls.Add(this.checkBox17);
            this.panel3.Location = new System.Drawing.Point(111, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(854, 52);
            this.panel3.TabIndex = 108;
            // 
            // checkBox25
            // 
            this.checkBox25.AutoSize = true;
            this.checkBox25.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.VSolEst", true));
            this.checkBox25.Location = new System.Drawing.Point(703, 4);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(139, 17);
            this.checkBox25.TabIndex = 133;
            this.checkBox25.Text = "Soldadura en estructura";
            this.checkBox25.UseVisualStyleBackColor = true;
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.VSolVar", true));
            this.checkBox24.Location = new System.Drawing.Point(546, 31);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(119, 17);
            this.checkBox24.TabIndex = 132;
            this.checkBox24.Text = "Soldadura en varilla";
            this.checkBox24.UseVisualStyleBackColor = true;
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.VPavimento", true));
            this.checkBox23.Location = new System.Drawing.Point(546, 4);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(147, 17);
            this.checkBox23.TabIndex = 131;
            this.checkBox23.Text = "Espesores en pavimentos";
            this.checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.VRasfalto", true));
            this.checkBox22.Location = new System.Drawing.Point(417, 31);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(106, 17);
            this.checkBox22.TabIndex = 130;
            this.checkBox22.Text = "Riegos asfalticos";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.VTasfalto", true));
            this.checkBox21.Location = new System.Drawing.Point(417, 4);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(107, 17);
            this.checkBox21.TabIndex = 129;
            this.checkBox21.Text = "Tendido asfaltico";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.VTerra", true));
            this.checkBox20.Location = new System.Drawing.Point(256, 29);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(152, 17);
            this.checkBox20.TabIndex = 128;
            this.checkBox20.Text = "Compacatión en terracería";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.ConPla", true));
            this.checkBox19.Location = new System.Drawing.Point(256, 6);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(106, 17);
            this.checkBox19.TabIndex = 127;
            this.checkBox19.Text = "Control de planta";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(162, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 126;
            this.label13.Text = "hasta";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaVAgr", true));
            this.textBox11.Location = new System.Drawing.Point(197, 27);
            this.textBox11.MaxLength = 3;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(32, 20);
            this.textBox11.TabIndex = 125;
            this.toolTip1.SetToolTip(this.textBox11, "Elija 1, 2, 3 o 4");
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaVCon", true));
            this.textBox10.Location = new System.Drawing.Point(197, 4);
            this.textBox10.MaxLength = 3;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(32, 20);
            this.textBox10.TabIndex = 124;
            this.toolTip1.SetToolTip(this.textBox10, "Elija 1, 2, 3 o 4");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(162, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 123;
            this.label12.Text = "hasta";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.VAgregado", true));
            this.checkBox18.Location = new System.Drawing.Point(12, 29);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(129, 17);
            this.checkBox18.TabIndex = 122;
            this.checkBox18.Text = "Calidad de agregados";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.VConcreto", true));
            this.checkBox17.Location = new System.Drawing.Point(12, 6);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(144, 17);
            this.checkBox17.TabIndex = 121;
            this.checkBox17.Text = "Dosificación de concreto";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 109;
            this.label11.Text = "Debe verificarse:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 293);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 110;
            this.label14.Text = "Debe realizarse:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.textBox25);
            this.panel4.Controls.Add(this.checkBox33);
            this.panel4.Controls.Add(this.textBox24);
            this.panel4.Controls.Add(this.checkBox32);
            this.panel4.Controls.Add(this.textBox22);
            this.panel4.Controls.Add(this.textBox23);
            this.panel4.Controls.Add(this.checkBox31);
            this.panel4.Controls.Add(this.textBox20);
            this.panel4.Controls.Add(this.textBox21);
            this.panel4.Controls.Add(this.checkBox30);
            this.panel4.Controls.Add(this.textBox18);
            this.panel4.Controls.Add(this.textBox19);
            this.panel4.Controls.Add(this.checkBox29);
            this.panel4.Controls.Add(this.textBox16);
            this.panel4.Controls.Add(this.textBox17);
            this.panel4.Controls.Add(this.checkBox28);
            this.panel4.Controls.Add(this.textBox14);
            this.panel4.Controls.Add(this.textBox15);
            this.panel4.Controls.Add(this.checkBox27);
            this.panel4.Controls.Add(this.textBox13);
            this.panel4.Controls.Add(this.textBox12);
            this.panel4.Controls.Add(this.checkBox26);
            this.panel4.Location = new System.Drawing.Point(111, 288);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(854, 73);
            this.panel4.TabIndex = 111;
            // 
            // textBox25
            // 
            this.textBox25.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaRTorque", true));
            this.textBox25.Location = new System.Drawing.Point(736, 23);
            this.textBox25.MaxLength = 3;
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(32, 20);
            this.textBox25.TabIndex = 155;
            this.toolTip1.SetToolTip(this.textBox25, "Elija 1, 2, 3 o 4");
            // 
            // checkBox33
            // 
            this.checkBox33.AutoSize = true;
            this.checkBox33.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.RTorque", true));
            this.checkBox33.Location = new System.Drawing.Point(587, 25);
            this.checkBox33.Name = "checkBox33";
            this.checkBox33.Size = new System.Drawing.Size(60, 17);
            this.checkBox33.TabIndex = 154;
            this.checkBox33.Text = "Torque";
            this.checkBox33.UseVisualStyleBackColor = true;
            // 
            // textBox24
            // 
            this.textBox24.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaRProbeta", true));
            this.textBox24.Location = new System.Drawing.Point(736, 1);
            this.textBox24.MaxLength = 3;
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(32, 20);
            this.textBox24.TabIndex = 153;
            this.toolTip1.SetToolTip(this.textBox24, "Elija 1, 2, 3 o 4");
            // 
            // checkBox32
            // 
            this.checkBox32.AutoSize = true;
            this.checkBox32.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.RProbeta", true));
            this.checkBox32.Location = new System.Drawing.Point(587, 3);
            this.checkBox32.Name = "checkBox32";
            this.checkBox32.Size = new System.Drawing.Size(113, 17);
            this.checkBox32.TabIndex = 152;
            this.checkBox32.Text = "Probetas soldadas";
            this.checkBox32.UseVisualStyleBackColor = true;
            // 
            // textBox22
            // 
            this.textBox22.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaRParS", true));
            this.textBox22.Location = new System.Drawing.Point(495, 46);
            this.textBox22.MaxLength = 3;
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(32, 20);
            this.textBox22.TabIndex = 151;
            this.toolTip1.SetToolTip(this.textBox22, "Elija 1, 2, 3 o 4");
            // 
            // textBox23
            // 
            this.textBox23.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaRPar", true));
            this.textBox23.Location = new System.Drawing.Point(444, 46);
            this.textBox23.MaxLength = 3;
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(32, 20);
            this.textBox23.TabIndex = 150;
            this.toolTip1.SetToolTip(this.textBox23, "Elija 1, 2, 3 o 4");
            // 
            // checkBox31
            // 
            this.checkBox31.AutoSize = true;
            this.checkBox31.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.RPar", true));
            this.checkBox31.Location = new System.Drawing.Point(295, 48);
            this.checkBox31.Name = "checkBox31";
            this.checkBox31.Size = new System.Drawing.Size(129, 17);
            this.checkBox31.TabIndex = 149;
            this.checkBox31.Text = "Particulas magenticas";
            this.checkBox31.UseVisualStyleBackColor = true;
            // 
            // textBox20
            // 
            this.textBox20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaRLiqS", true));
            this.textBox20.Location = new System.Drawing.Point(495, 23);
            this.textBox20.MaxLength = 3;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(32, 20);
            this.textBox20.TabIndex = 148;
            this.toolTip1.SetToolTip(this.textBox20, "Elija 1, 2, 3 o 4");
            // 
            // textBox21
            // 
            this.textBox21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaRLiq", true));
            this.textBox21.Location = new System.Drawing.Point(444, 23);
            this.textBox21.MaxLength = 3;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(32, 20);
            this.textBox21.TabIndex = 147;
            this.toolTip1.SetToolTip(this.textBox21, "Elija 1, 2, 3 o 4");
            // 
            // checkBox30
            // 
            this.checkBox30.AutoSize = true;
            this.checkBox30.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.RLiq", true));
            this.checkBox30.Location = new System.Drawing.Point(295, 25);
            this.checkBox30.Name = "checkBox30";
            this.checkBox30.Size = new System.Drawing.Size(124, 17);
            this.checkBox30.TabIndex = 146;
            this.checkBox30.Text = "Liquidos penetrantes";
            this.checkBox30.UseVisualStyleBackColor = true;
            // 
            // textBox18
            // 
            this.textBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaRUltS", true));
            this.textBox18.Location = new System.Drawing.Point(495, 1);
            this.textBox18.MaxLength = 3;
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(32, 20);
            this.textBox18.TabIndex = 145;
            this.toolTip1.SetToolTip(this.textBox18, "Elija 1, 2, 3 o 4");
            // 
            // textBox19
            // 
            this.textBox19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaRUlt", true));
            this.textBox19.Location = new System.Drawing.Point(444, 1);
            this.textBox19.MaxLength = 3;
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(32, 20);
            this.textBox19.TabIndex = 144;
            this.toolTip1.SetToolTip(this.textBox19, "Elija 1, 2, 3 o 4");
            // 
            // checkBox29
            // 
            this.checkBox29.AutoSize = true;
            this.checkBox29.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.RUltra", true));
            this.checkBox29.Location = new System.Drawing.Point(295, 3);
            this.checkBox29.Name = "checkBox29";
            this.checkBox29.Size = new System.Drawing.Size(132, 17);
            this.checkBox29.TabIndex = 143;
            this.checkBox29.Text = "Inspección ultrasonica";
            this.checkBox29.UseVisualStyleBackColor = true;
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaRRadS", true));
            this.textBox16.Location = new System.Drawing.Point(212, 46);
            this.textBox16.MaxLength = 3;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(32, 20);
            this.textBox16.TabIndex = 142;
            this.toolTip1.SetToolTip(this.textBox16, "Elija 1, 2, 3 o 4");
            // 
            // textBox17
            // 
            this.textBox17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaRRad", true));
            this.textBox17.Location = new System.Drawing.Point(161, 46);
            this.textBox17.MaxLength = 3;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(32, 20);
            this.textBox17.TabIndex = 141;
            this.toolTip1.SetToolTip(this.textBox17, "Elija 1, 2, 3 o 4");
            // 
            // checkBox28
            // 
            this.checkBox28.AutoSize = true;
            this.checkBox28.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.RRadio", true));
            this.checkBox28.Location = new System.Drawing.Point(12, 48);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(136, 17);
            this.checkBox28.TabIndex = 140;
            this.checkBox28.Text = "Inspección radiografica";
            this.checkBox28.UseVisualStyleBackColor = true;
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaRSolS", true));
            this.textBox14.Location = new System.Drawing.Point(212, 23);
            this.textBox14.MaxLength = 3;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(32, 20);
            this.textBox14.TabIndex = 139;
            this.toolTip1.SetToolTip(this.textBox14, "Elija 1, 2, 3 o 4");
            // 
            // textBox15
            // 
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaRSol", true));
            this.textBox15.Location = new System.Drawing.Point(161, 23);
            this.textBox15.MaxLength = 3;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(32, 20);
            this.textBox15.TabIndex = 138;
            this.toolTip1.SetToolTip(this.textBox15, "Elija 1, 2, 3 o 4");
            // 
            // checkBox27
            // 
            this.checkBox27.AutoSize = true;
            this.checkBox27.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.RSolda", true));
            this.checkBox27.Location = new System.Drawing.Point(12, 25);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(138, 17);
            this.checkBox27.TabIndex = 137;
            this.checkBox27.Text = "Calificación de soldador";
            this.checkBox27.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaRVisS", true));
            this.textBox13.Location = new System.Drawing.Point(212, 1);
            this.textBox13.MaxLength = 3;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(32, 20);
            this.textBox13.TabIndex = 136;
            this.toolTip1.SetToolTip(this.textBox13, "Elija 1, 2, 3 o 4");
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaRVis", true));
            this.textBox12.Location = new System.Drawing.Point(161, 1);
            this.textBox12.MaxLength = 3;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(32, 20);
            this.textBox12.TabIndex = 135;
            this.toolTip1.SetToolTip(this.textBox12, "Elija 1, 2, 3 o 4");
            // 
            // checkBox26
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.RVisual", true));
            this.checkBox26.Location = new System.Drawing.Point(12, 3);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(108, 17);
            this.checkBox26.TabIndex = 134;
            this.checkBox26.Text = "Inspección visual";
            this.checkBox26.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(300, 261);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 134;
            this.label15.Text = "hasta";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(275, 272);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 135;
            this.label16.Text = "visita";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(320, 272);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 136;
            this.label17.Text = "semana";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(603, 272);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 142;
            this.label18.Text = "semana";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(558, 272);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 141;
            this.label19.Text = "visita";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(583, 261);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 140;
            this.label20.Text = "hasta";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(848, 272);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 13);
            this.label21.TabIndex = 143;
            this.label21.Text = "hasta";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(48, 371);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 13);
            this.label22.TabIndex = 144;
            this.label22.Text = "Concreto:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label31);
            this.panel5.Controls.Add(this.label33);
            this.panel5.Controls.Add(this.textBox32);
            this.panel5.Controls.Add(this.label34);
            this.panel5.Controls.Add(this.textBox33);
            this.panel5.Controls.Add(this.label30);
            this.panel5.Controls.Add(this.label27);
            this.panel5.Controls.Add(this.textBox29);
            this.panel5.Controls.Add(this.label28);
            this.panel5.Controls.Add(this.textBox30);
            this.panel5.Controls.Add(this.label29);
            this.panel5.Controls.Add(this.textBox31);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.textBox28);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.textBox27);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.textBox26);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Location = new System.Drawing.Point(111, 371);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 73);
            this.panel5.TabIndex = 145;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(210, 53);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(64, 13);
            this.label31.TabIndex = 176;
            this.label31.Text = "muestras de";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label31.Visible = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(1, 52);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(130, 13);
            this.label33.TabIndex = 174;
            this.label33.Text = "Por cada tipo de concreto";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label33.Visible = false;
            // 
            // textBox32
            // 
            this.textBox32.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.MCilObrT", true));
            this.textBox32.Location = new System.Drawing.Point(274, 49);
            this.textBox32.MaxLength = 3;
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(18, 20);
            this.textBox32.TabIndex = 173;
            this.toolTip1.SetToolTip(this.textBox32, "Elija 1, 2, 3 o 4");
            this.textBox32.Visible = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(293, 53);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(45, 13);
            this.label34.TabIndex = 172;
            this.label34.Text = "cilindros";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label34.Visible = false;
            // 
            // textBox33
            // 
            this.textBox33.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.MCilTipo", true));
            this.textBox33.Location = new System.Drawing.Point(192, 49);
            this.textBox33.MaxLength = 3;
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(18, 20);
            this.textBox33.TabIndex = 171;
            this.toolTip1.SetToolTip(this.textBox33, "Elija 1, 2, 3 o 4");
            this.textBox33.Visible = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(210, 30);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(64, 13);
            this.label30.TabIndex = 170;
            this.label30.Text = "muestras de";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(112, 30);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(80, 13);
            this.label27.TabIndex = 169;
            this.label27.Text = "m³ o excedente";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox29
            // 
            this.textBox29.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.Excedente", true));
            this.textBox29.Location = new System.Drawing.Point(76, 26);
            this.textBox29.MaxLength = 3;
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(32, 20);
            this.textBox29.TabIndex = 168;
            this.toolTip1.SetToolTip(this.textBox29, "Elija 1, 2, 3 o 4");
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(1, 29);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(50, 13);
            this.label28.TabIndex = 167;
            this.label28.Text = "Por cada";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox30
            // 
            this.textBox30.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.MCilObrP", true));
            this.textBox30.Location = new System.Drawing.Point(274, 26);
            this.textBox30.MaxLength = 3;
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(18, 20);
            this.textBox30.TabIndex = 166;
            this.toolTip1.SetToolTip(this.textBox30, "Elija 1, 2, 3 o 4");
            this.textBox30.Visible = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(293, 30);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(45, 13);
            this.label29.TabIndex = 165;
            this.label29.Text = "cilindros";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label29.Visible = false;
            // 
            // textBox31
            // 
            this.textBox31.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.MCilExc", true));
            this.textBox31.Location = new System.Drawing.Point(192, 26);
            this.textBox31.MaxLength = 3;
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(18, 20);
            this.textBox31.TabIndex = 164;
            this.toolTip1.SetToolTip(this.textBox31, "Elija 1, 2, 3 o 4");
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(112, 6);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 13);
            this.label26.TabIndex = 163;
            this.label26.Text = "m³ o menores";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox28
            // 
            this.textBox28.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.Colados", true));
            this.textBox28.Location = new System.Drawing.Point(76, 2);
            this.textBox28.MaxLength = 3;
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(32, 20);
            this.textBox28.TabIndex = 162;
            this.toolTip1.SetToolTip(this.textBox28, "Elija 1, 2, 3 o 4");
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1, 5);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 13);
            this.label24.TabIndex = 161;
            this.label24.Text = "En colados de";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox27
            // 
            this.textBox27.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.MCilObra", true));
            this.textBox27.Location = new System.Drawing.Point(274, 2);
            this.textBox27.MaxLength = 3;
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(18, 20);
            this.textBox27.TabIndex = 160;
            this.toolTip1.SetToolTip(this.textBox27, "Elija 1, 2, 3 o 4");
            this.textBox27.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(293, 6);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 13);
            this.label23.TabIndex = 159;
            this.label23.Text = "cilindros";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label23.Visible = false;
            // 
            // textBox26
            // 
            this.textBox26.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.MCilCol", true));
            this.textBox26.Location = new System.Drawing.Point(192, 2);
            this.textBox26.MaxLength = 3;
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(18, 20);
            this.textBox26.TabIndex = 158;
            this.toolTip1.SetToolTip(this.textBox26, "Elija 1, 2, 3 o 4");
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(210, 6);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 13);
            this.label25.TabIndex = 157;
            this.label25.Text = "muestras de";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(516, 371);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(38, 13);
            this.label32.TabIndex = 146;
            this.label32.Text = "Acero:";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.textBox38);
            this.panel6.Controls.Add(this.label37);
            this.panel6.Controls.Add(this.textBox35);
            this.panel6.Controls.Add(this.textBox34);
            this.panel6.Controls.Add(this.label36);
            this.panel6.Controls.Add(this.label35);
            this.panel6.Location = new System.Drawing.Point(554, 368);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(411, 34);
            this.panel6.TabIndex = 147;
            // 
            // textBox38
            // 
            this.textBox38.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaAcero", true));
            this.textBox38.Location = new System.Drawing.Point(379, 2);
            this.textBox38.MaxLength = 3;
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(26, 20);
            this.textBox38.TabIndex = 178;
            this.toolTip1.SetToolTip(this.textBox38, "Elija 1, 2, 3 o 4");
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(249, 6);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(129, 13);
            this.label37.TabIndex = 177;
            this.label37.Text = "muestra 2 probetas  hasta";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox35
            // 
            this.textBox35.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.AtonM", true));
            this.textBox35.Location = new System.Drawing.Point(223, 2);
            this.textBox35.MaxLength = 3;
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(26, 20);
            this.textBox35.TabIndex = 176;
            this.toolTip1.SetToolTip(this.textBox35, "Elija 1, 2, 3 o 4");
            // 
            // textBox34
            // 
            this.textBox34.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.Aton", true));
            this.textBox34.Location = new System.Drawing.Point(51, 2);
            this.textBox34.MaxLength = 3;
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(26, 20);
            this.textBox34.TabIndex = 175;
            this.toolTip1.SetToolTip(this.textBox34, "Elija 1, 2, 3 o 4");
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(77, 6);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(145, 13);
            this.label36.TabIndex = 174;
            this.label36.Text = "t o fracción de cada diametro";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(1, 6);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(50, 13);
            this.label35.TabIndex = 162;
            this.label35.Text = "Por cada";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(491, 407);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(63, 31);
            this.label38.TabIndex = 148;
            this.label38.Text = "Acero estructural:";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.textBox39);
            this.panel7.Controls.Add(this.label39);
            this.panel7.Controls.Add(this.textBox36);
            this.panel7.Controls.Add(this.textBox37);
            this.panel7.Controls.Add(this.label40);
            this.panel7.Controls.Add(this.label41);
            this.panel7.Location = new System.Drawing.Point(554, 408);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(411, 34);
            this.panel7.TabIndex = 149;
            // 
            // textBox39
            // 
            this.textBox39.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaAceroE", true));
            this.textBox39.Location = new System.Drawing.Point(379, 5);
            this.textBox39.MaxLength = 3;
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(26, 20);
            this.textBox39.TabIndex = 179;
            this.toolTip1.SetToolTip(this.textBox39, "Elija 1, 2, 3 o 4");
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(249, 6);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(132, 13);
            this.label39.TabIndex = 177;
            this.label39.Text = "muestras                   hasta";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox36
            // 
            this.textBox36.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.AEtonM", true));
            this.textBox36.Location = new System.Drawing.Point(223, 2);
            this.textBox36.MaxLength = 3;
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(26, 20);
            this.textBox36.TabIndex = 176;
            this.toolTip1.SetToolTip(this.textBox36, "Elija 1, 2, 3 o 4");
            // 
            // textBox37
            // 
            this.textBox37.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.AEton", true));
            this.textBox37.Location = new System.Drawing.Point(51, 2);
            this.textBox37.MaxLength = 3;
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(26, 20);
            this.textBox37.TabIndex = 175;
            this.toolTip1.SetToolTip(this.textBox37, "Elija 1, 2, 3 o 4");
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(77, 6);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(127, 13);
            this.label40.TabIndex = 174;
            this.label40.Text = "t o fracción de cada perfil";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(1, 6);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(50, 13);
            this.label41.TabIndex = 162;
            this.label41.Text = "Por cada";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.textBox40);
            this.panel8.Controls.Add(this.label42);
            this.panel8.Controls.Add(this.textBox41);
            this.panel8.Controls.Add(this.textBox42);
            this.panel8.Controls.Add(this.label43);
            this.panel8.Controls.Add(this.label44);
            this.panel8.Location = new System.Drawing.Point(554, 408);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(411, 34);
            this.panel8.TabIndex = 149;
            // 
            // textBox40
            // 
            this.textBox40.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaAceroE", true));
            this.textBox40.Location = new System.Drawing.Point(379, 2);
            this.textBox40.MaxLength = 3;
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(26, 20);
            this.textBox40.TabIndex = 179;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(249, 6);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(123, 13);
            this.label42.TabIndex = 177;
            this.label42.Text = "muestras                hasta";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox41
            // 
            this.textBox41.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.AEtonM", true));
            this.textBox41.Location = new System.Drawing.Point(223, 2);
            this.textBox41.MaxLength = 3;
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(26, 20);
            this.textBox41.TabIndex = 176;
            // 
            // textBox42
            // 
            this.textBox42.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.AEton", true));
            this.textBox42.Location = new System.Drawing.Point(51, 2);
            this.textBox42.MaxLength = 3;
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(26, 20);
            this.textBox42.TabIndex = 175;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(77, 6);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(127, 13);
            this.label43.TabIndex = 174;
            this.label43.Text = "t o fracción de cada perfil";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(1, 6);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(50, 13);
            this.label44.TabIndex = 162;
            this.label44.Text = "Por cada";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.label46);
            this.panel9.Controls.Add(this.cmbMortero);
            this.panel9.Controls.Add(this.label49);
            this.panel9.Controls.Add(this.textBox46);
            this.panel9.Controls.Add(this.textBox43);
            this.panel9.Controls.Add(this.label45);
            this.panel9.Controls.Add(this.textBox44);
            this.panel9.Controls.Add(this.textBox45);
            this.panel9.Controls.Add(this.label47);
            this.panel9.Controls.Add(this.label50);
            this.panel9.Location = new System.Drawing.Point(110, 450);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(401, 30);
            this.panel9.TabIndex = 151;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(310, 6);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(33, 13);
            this.label46.TabIndex = 183;
            this.label46.Text = "hasta";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbMortero
            // 
            this.cmbMortero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.MorMueCub", true));
            this.cmbMortero.DataSource = this.dsGenerico1;
            this.cmbMortero.DisplayMember = "Generico.Descripción";
            this.cmbMortero.FormattingEnabled = true;
            this.cmbMortero.Location = new System.Drawing.Point(177, 2);
            this.cmbMortero.Name = "cmbMortero";
            this.cmbMortero.Size = new System.Drawing.Size(65, 21);
            this.cmbMortero.TabIndex = 182;
            this.cmbMortero.ValueMember = "Generico.Nombre";
            // 
            // dsGenerico1
            // 
            this.dsGenerico1.DataSetName = "dsGenerico";
            this.dsGenerico1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(272, 6);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(36, 13);
            this.label49.TabIndex = 181;
            this.label49.Text = "cubos";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox46
            // 
            this.textBox46.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.TipoMor", true));
            this.textBox46.Location = new System.Drawing.Point(245, 2);
            this.textBox46.MaxLength = 3;
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(26, 20);
            this.textBox46.TabIndex = 180;
            this.toolTip1.SetToolTip(this.textBox46, "Elija 1, 2, 3 o 4");
            // 
            // textBox43
            // 
            this.textBox43.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.MorMuMi", true));
            this.textBox43.Location = new System.Drawing.Point(140, 2);
            this.textBox43.MaxLength = 3;
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(26, 20);
            this.textBox43.TabIndex = 178;
            this.toolTip1.SetToolTip(this.textBox43, "Elija 1, 2, 3 o 4");
            this.textBox43.Visible = false;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(93, 6);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(49, 13);
            this.label45.TabIndex = 177;
            this.label45.Text = "muestras";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox44
            // 
            this.textBox44.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.MorMin", true));
            this.textBox44.Location = new System.Drawing.Point(67, 2);
            this.textBox44.MaxLength = 3;
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(26, 20);
            this.textBox44.TabIndex = 176;
            this.toolTip1.SetToolTip(this.textBox44, "Elija 1, 2, 3 o 4");
            // 
            // textBox45
            // 
            this.textBox45.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaMor", true));
            this.textBox45.Location = new System.Drawing.Point(343, 2);
            this.textBox45.MaxLength = 3;
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(45, 20);
            this.textBox45.TabIndex = 175;
            this.toolTip1.SetToolTip(this.textBox45, "Elija 1, 2, 3 o 4");
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(1, 6);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(63, 13);
            this.label47.TabIndex = 162;
            this.label47.Text = "Por semana";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(166, 6);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(12, 13);
            this.label50.TabIndex = 184;
            this.label50.Text = "x";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label50.Visible = false;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(55, 453);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(46, 13);
            this.label48.TabIndex = 150;
            this.label48.Text = "Mortero:";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label51
            // 
            this.label51.Location = new System.Drawing.Point(513, 449);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(33, 31);
            this.label51.TabIndex = 152;
            this.label51.Text = "Tabique:";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.label56);
            this.panel10.Controls.Add(this.label55);
            this.panel10.Controls.Add(this.textBox50);
            this.panel10.Controls.Add(this.textBox47);
            this.panel10.Controls.Add(this.label52);
            this.panel10.Controls.Add(this.textBox48);
            this.panel10.Controls.Add(this.textBox49);
            this.panel10.Controls.Add(this.label53);
            this.panel10.Controls.Add(this.label54);
            this.panel10.Location = new System.Drawing.Point(554, 450);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(411, 34);
            this.panel10.TabIndex = 153;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(284, 8);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(37, 13);
            this.label56.TabIndex = 185;
            this.label56.Text = "piezas";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(340, 6);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(33, 13);
            this.label55.TabIndex = 184;
            this.label55.Text = "hasta";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox50
            // 
            this.textBox50.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.TabPza", true));
            this.textBox50.Location = new System.Drawing.Point(252, 3);
            this.textBox50.MaxLength = 3;
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(26, 20);
            this.textBox50.TabIndex = 180;
            // 
            // textBox47
            // 
            this.textBox47.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaAceroE", true));
            this.textBox47.Location = new System.Drawing.Point(379, 2);
            this.textBox47.MaxLength = 3;
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(26, 20);
            this.textBox47.TabIndex = 179;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(183, 5);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(64, 13);
            this.label52.TabIndex = 177;
            this.label52.Text = "muestras de";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox48
            // 
            this.textBox48.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.TabTip", true));
            this.textBox48.Location = new System.Drawing.Point(157, 1);
            this.textBox48.MaxLength = 3;
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(26, 20);
            this.textBox48.TabIndex = 176;
            // 
            // textBox49
            // 
            this.textBox49.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.TabCad", true));
            this.textBox49.Location = new System.Drawing.Point(51, 2);
            this.textBox49.MaxLength = 3;
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(26, 20);
            this.textBox49.TabIndex = 175;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(77, 6);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(80, 13);
            this.label53.TabIndex = 174;
            this.label53.Text = "tabique o block";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(1, 6);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(50, 13);
            this.label54.TabIndex = 162;
            this.label54.Text = "Por cada";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.label57);
            this.panel11.Controls.Add(this.label58);
            this.panel11.Controls.Add(this.textBox51);
            this.panel11.Controls.Add(this.textBox52);
            this.panel11.Controls.Add(this.label59);
            this.panel11.Controls.Add(this.textBox53);
            this.panel11.Controls.Add(this.textBox54);
            this.panel11.Controls.Add(this.label60);
            this.panel11.Controls.Add(this.label61);
            this.panel11.Location = new System.Drawing.Point(554, 450);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(411, 34);
            this.panel11.TabIndex = 153;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(284, 6);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(37, 13);
            this.label57.TabIndex = 185;
            this.label57.Text = "piezas";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(340, 6);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(33, 13);
            this.label58.TabIndex = 184;
            this.label58.Text = "hasta";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox51
            // 
            this.textBox51.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.TabPza", true));
            this.textBox51.Location = new System.Drawing.Point(252, 2);
            this.textBox51.MaxLength = 3;
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(26, 20);
            this.textBox51.TabIndex = 180;
            // 
            // textBox52
            // 
            this.textBox52.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaTab", true));
            this.textBox52.Location = new System.Drawing.Point(379, 2);
            this.textBox52.MaxLength = 3;
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(26, 20);
            this.textBox52.TabIndex = 179;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(183, 6);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(64, 13);
            this.label59.TabIndex = 177;
            this.label59.Text = "muestras de";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox53
            // 
            this.textBox53.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.TabTip", true));
            this.textBox53.Location = new System.Drawing.Point(157, 2);
            this.textBox53.MaxLength = 3;
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(26, 20);
            this.textBox53.TabIndex = 176;
            // 
            // textBox54
            // 
            this.textBox54.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.TabCad", true));
            this.textBox54.Location = new System.Drawing.Point(52, 2);
            this.textBox54.MaxLength = 3;
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(26, 20);
            this.textBox54.TabIndex = 175;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(77, 6);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(80, 13);
            this.label60.TabIndex = 174;
            this.label60.Text = "tabique o block";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(1, 6);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(50, 13);
            this.label61.TabIndex = 162;
            this.label61.Text = "Por cada";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(38, 499);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(63, 13);
            this.label62.TabIndex = 154;
            this.label62.Text = "Terracerias:";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Controls.Add(this.checkBox35);
            this.panel12.Controls.Add(this.checkBox34);
            this.panel12.Controls.Add(this.textBox69);
            this.panel12.Controls.Add(this.label69);
            this.panel12.Controls.Add(this.textBox59);
            this.panel12.Controls.Add(this.label68);
            this.panel12.Controls.Add(this.label67);
            this.panel12.Controls.Add(this.textBox55);
            this.panel12.Controls.Add(this.label63);
            this.panel12.Controls.Add(this.label64);
            this.panel12.Controls.Add(this.textBox56);
            this.panel12.Controls.Add(this.label65);
            this.panel12.Location = new System.Drawing.Point(110, 486);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(381, 81);
            this.panel12.TabIndex = 155;
            // 
            // checkBox35
            // 
            this.checkBox35.AutoSize = true;
            this.checkBox35.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.TerCad", true));
            this.checkBox35.Location = new System.Drawing.Point(180, 4);
            this.checkBox35.Name = "checkBox35";
            this.checkBox35.Size = new System.Drawing.Size(50, 17);
            this.checkBox35.TabIndex = 193;
            this.checkBox35.Text = "cada";
            this.checkBox35.UseVisualStyleBackColor = true;
            // 
            // checkBox34
            // 
            this.checkBox34.AutoSize = true;
            this.checkBox34.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.TerIni", true));
            this.checkBox34.Location = new System.Drawing.Point(13, 4);
            this.checkBox34.Name = "checkBox34";
            this.checkBox34.Size = new System.Drawing.Size(162, 17);
            this.checkBox34.TabIndex = 192;
            this.checkBox34.Text = "Al inicio de cualquier material";
            this.checkBox34.UseVisualStyleBackColor = true;
            // 
            // textBox69
            // 
            this.textBox69.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.TerMe3", true));
            this.textBox69.Location = new System.Drawing.Point(240, 2);
            this.textBox69.MaxLength = 3;
            this.textBox69.Name = "textBox69";
            this.textBox69.Size = new System.Drawing.Size(26, 20);
            this.textBox69.TabIndex = 191;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(272, 56);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(66, 13);
            this.label69.TabIndex = 190;
            this.label69.Text = "cada 250 m²";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox59
            // 
            this.textBox59.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.BasCad", true));
            this.textBox59.Location = new System.Drawing.Point(240, 52);
            this.textBox59.MaxLength = 3;
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(26, 20);
            this.textBox59.TabIndex = 189;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(37, 56);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(84, 13);
            this.label68.TabIndex = 188;
            this.label68.Text = "base y sub-base";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(272, 31);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(66, 13);
            this.label67.TabIndex = 187;
            this.label67.Text = "cada 250 m²";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox55
            // 
            this.textBox55.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.CalCad", true));
            this.textBox55.Location = new System.Drawing.Point(240, 27);
            this.textBox55.MaxLength = 3;
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(26, 20);
            this.textBox55.TabIndex = 186;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(37, 31);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(66, 13);
            this.label63.TabIndex = 185;
            this.label63.Text = "Terracerrias ";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(301, 6);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(33, 13);
            this.label64.TabIndex = 184;
            this.label64.Text = "hasta";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox56
            // 
            this.textBox56.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaTer", true));
            this.textBox56.Location = new System.Drawing.Point(340, 2);
            this.textBox56.MaxLength = 3;
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(26, 20);
            this.textBox56.TabIndex = 179;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(272, 6);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(18, 13);
            this.label65.TabIndex = 177;
            this.label65.Text = "m³";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label70
            // 
            this.label70.Location = new System.Drawing.Point(491, 493);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(63, 42);
            this.label70.TabIndex = 156;
            this.label70.Text = "Carpeta de concreto asfáltico:";
            this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel13.Controls.Add(this.label83);
            this.panel13.Controls.Add(this.label82);
            this.panel13.Controls.Add(this.label78);
            this.panel13.Controls.Add(this.label77);
            this.panel13.Controls.Add(this.label66);
            this.panel13.Controls.Add(this.label80);
            this.panel13.Controls.Add(this.textBox67);
            this.panel13.Controls.Add(this.label79);
            this.panel13.Controls.Add(this.textBox66);
            this.panel13.Controls.Add(this.label72);
            this.panel13.Controls.Add(this.textBox61);
            this.panel13.Controls.Add(this.label74);
            this.panel13.Controls.Add(this.label75);
            this.panel13.Controls.Add(this.textBox62);
            this.panel13.Controls.Add(this.textBox63);
            this.panel13.Location = new System.Drawing.Point(556, 486);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(409, 114);
            this.panel13.TabIndex = 157;
            // 
            // checkBox37
            // 
            this.checkBox37.AutoSize = true;
            this.checkBox37.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.EmuCad", true));
            this.checkBox37.Location = new System.Drawing.Point(971, 513);
            this.checkBox37.Name = "checkBox37";
            this.checkBox37.Size = new System.Drawing.Size(50, 17);
            this.checkBox37.TabIndex = 198;
            this.checkBox37.Text = "cada";
            this.checkBox37.UseVisualStyleBackColor = true;
            this.checkBox37.Visible = false;
            // 
            // checkBox36
            // 
            this.checkBox36.AutoSize = true;
            this.checkBox36.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dsActividad1, "Actividad.EmuIni", true));
            this.checkBox36.Location = new System.Drawing.Point(971, 490);
            this.checkBox36.Name = "checkBox36";
            this.checkBox36.Size = new System.Drawing.Size(61, 17);
            this.checkBox36.TabIndex = 197;
            this.checkBox36.Text = "al inicio";
            this.checkBox36.UseVisualStyleBackColor = true;
            this.checkBox36.Visible = false;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(316, 90);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(33, 13);
            this.label80.TabIndex = 196;
            this.label80.Text = "hasta";
            this.label80.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox67
            // 
            this.textBox67.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaNuc", true));
            this.textBox67.Location = new System.Drawing.Point(355, 86);
            this.textBox67.MaxLength = 3;
            this.textBox67.Name = "textBox67";
            this.textBox67.Size = new System.Drawing.Size(26, 20);
            this.textBox67.TabIndex = 195;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(315, 26);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(33, 13);
            this.label79.TabIndex = 194;
            this.label79.Text = "hasta";
            this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox66
            // 
            this.textBox66.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaAsf", true));
            this.textBox66.Location = new System.Drawing.Point(355, 22);
            this.textBox66.MaxLength = 3;
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(26, 20);
            this.textBox66.TabIndex = 193;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(1003, 574);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(66, 13);
            this.label71.TabIndex = 190;
            this.label71.Text = "cada 250 m²";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label71.Visible = false;
            // 
            // textBox60
            // 
            this.textBox60.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.NucCad", true));
            this.textBox60.Location = new System.Drawing.Point(971, 570);
            this.textBox60.MaxLength = 3;
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(26, 20);
            this.textBox60.TabIndex = 189;
            this.textBox60.Visible = false;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(3, 90);
            this.label72.Name = "label72";
            this.label72.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label72.Size = new System.Drawing.Size(188, 13);
            this.label72.TabIndex = 188;
            this.label72.Text = "Compactación y espesor 10 cor 10 cm";
            this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(1012, 456);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(66, 13);
            this.label73.TabIndex = 187;
            this.label73.Text = "cada 250 m²";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label73.Visible = false;
            // 
            // textBox61
            // 
            this.textBox61.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.AsfCad", true));
            this.textBox61.Location = new System.Drawing.Point(355, 43);
            this.textBox61.MaxLength = 3;
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(26, 20);
            this.textBox61.TabIndex = 186;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(3, 26);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(178, 13);
            this.label74.TabIndex = 185;
            this.label74.Text = "Contenido de asfalto y granulometria";
            this.label74.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(315, 4);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(33, 13);
            this.label75.TabIndex = 184;
            this.label75.Text = "hasta";
            this.label75.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox62
            // 
            this.textBox62.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.HastaEmu", true));
            this.textBox62.Location = new System.Drawing.Point(355, 0);
            this.textBox62.MaxLength = 3;
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(26, 20);
            this.textBox62.TabIndex = 179;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(1012, 551);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(18, 13);
            this.label76.TabIndex = 177;
            this.label76.Text = "m³";
            this.label76.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label76.Visible = false;
            // 
            // textBox63
            // 
            this.textBox63.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.EmuMe3", true));
            this.textBox63.Location = new System.Drawing.Point(355, 64);
            this.textBox63.MaxLength = 3;
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(26, 20);
            this.textBox63.TabIndex = 176;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(20, 602);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(81, 13);
            this.label81.TabIndex = 158;
            this.label81.Text = "Observaciones:";
            this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox68
            // 
            this.textBox68.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsActividad1, "Actividad.Observaciones", true));
            this.textBox68.Location = new System.Drawing.Point(108, 602);
            this.textBox68.MaxLength = 200;
            this.textBox68.Multiline = true;
            this.textBox68.Name = "textBox68";
            this.textBox68.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox68.Size = new System.Drawing.Size(853, 34);
            this.textBox68.TabIndex = 159;
            // 
            // sqlDABusActividad
            // 
            this.sqlDABusActividad.SelectCommand = this.sqlCommand3;
            this.sqlDABusActividad.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Actividad", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("IdFormato", "IdFormato"),
                        new System.Data.Common.DataColumnMapping("IdIntensidad", "IdIntensidad")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "SELECT     IdObra, IdFormato, IdIntensidad\r\nFROM         Actividad\r\nORDER BY IdOb" +
    "ra";
            this.sqlCommand3.Connection = this.sqlConn;
            // 
            // tbBtn2
            // 
            this.tbBtn2.BackColor = System.Drawing.Color.Transparent;
            this.tbBtn2.Icon = ((System.Drawing.Icon)(resources.GetObject("tbBtn2.Icon")));
            this.tbBtn2.Location = new System.Drawing.Point(779, 3);
            this.tbBtn2.Name = "tbBtn2";
            this.tbBtn2.Size = new System.Drawing.Size(64, 64);
            this.tbBtn2.TabIndex = 59;
            this.toolTip1.SetToolTip(this.tbBtn2, "Inserta caracteristicas");
            this.tbBtn2.Click += new System.EventHandler(this.tbBtn2_Click);
            // 
            // sqlComActividad
            // 
            this.sqlComActividad.CommandText = "ActulizaActividad";
            this.sqlComActividad.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlComActividad.Connection = this.sqlConn;
            this.sqlComActividad.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6)});
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(3, 3);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(173, 13);
            this.label66.TabIndex = 197;
            this.label66.Text = "Calidad de la emulsión (lab externo)";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(3, 47);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(198, 13);
            this.label77.TabIndex = 198;
            this.label77.Text = "Visita de lab para temperaturas y tendido";
            this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(316, 47);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(33, 13);
            this.label78.TabIndex = 199;
            this.label78.Text = "hasta";
            this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(3, 68);
            this.label82.Name = "label82";
            this.label82.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label82.Size = new System.Drawing.Size(124, 13);
            this.label82.TabIndex = 200;
            this.label82.Text = "Prueba de permeabilidad";
            this.label82.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(316, 68);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(33, 13);
            this.label83.TabIndex = 201;
            this.label83.Text = "hasta";
            this.label83.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Actividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 662);
            this.Controls.Add(this.buscaBtn1);
            this.Controls.Add(this.checkBox37);
            this.Controls.Add(this.checkBox36);
            this.Controls.Add(this.textBox68);
            this.Controls.Add(this.label81);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.label73);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.textBox60);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label76);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIntensiddad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdObra);
            this.Controls.Add(this.label1);
            this.DAGeneral = this.sqlDAActividad;
            this.dsGeneral = this.dsActividad1;
            this.Name = "Actividad";
            this.NombreTabla = "Actividad";
            this.Text = "Actividad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Actividad_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtIdObra, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cmbIntensiddad, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            this.Controls.SetChildIndex(this.textBox4, 0);
            this.Controls.SetChildIndex(this.checkBox2, 0);
            this.Controls.SetChildIndex(this.textBox6, 0);
            this.Controls.SetChildIndex(this.textBox5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.label22, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.label32, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.label38, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.Controls.SetChildIndex(this.panel8, 0);
            this.Controls.SetChildIndex(this.label48, 0);
            this.Controls.SetChildIndex(this.label76, 0);
            this.Controls.SetChildIndex(this.panel9, 0);
            this.Controls.SetChildIndex(this.label51, 0);
            this.Controls.SetChildIndex(this.panel10, 0);
            this.Controls.SetChildIndex(this.panel11, 0);
            this.Controls.SetChildIndex(this.label62, 0);
            this.Controls.SetChildIndex(this.textBox60, 0);
            this.Controls.SetChildIndex(this.label71, 0);
            this.Controls.SetChildIndex(this.label73, 0);
            this.Controls.SetChildIndex(this.panel12, 0);
            this.Controls.SetChildIndex(this.label70, 0);
            this.Controls.SetChildIndex(this.panel13, 0);
            this.Controls.SetChildIndex(this.label81, 0);
            this.Controls.SetChildIndex(this.textBox68, 0);
            this.Controls.SetChildIndex(this.checkBox36, 0);
            this.Controls.SetChildIndex(this.checkBox37, 0);
            this.Controls.SetChildIndex(this.buscaBtn1, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsActividad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIntensidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusActividad1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGenerico1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConn;
        private System.Data.SqlClient.SqlDataAdapter sqlDAActividad;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdObra;
        private dsActividad dsActividad1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Data.SqlClient.SqlDataAdapter sqlDAIntensidad;
        private System.Data.SqlClient.SqlCommand sqlCommand15;
        private dsIntensidad dsIntensidad1;
        private System.Windows.Forms.ComboBox cmbIntensiddad;
        private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox25;
        private System.Windows.Forms.CheckBox checkBox24;
        private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.CheckBox checkBox28;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.CheckBox checkBox27;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.CheckBox checkBox26;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.CheckBox checkBox33;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.CheckBox checkBox32;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.CheckBox checkBox31;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.CheckBox checkBox30;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.CheckBox checkBox29;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.TextBox textBox45;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox textBox46;
        private System.Windows.Forms.ComboBox cmbMortero;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox textBox48;
        private System.Windows.Forms.TextBox textBox49;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox textBox51;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox textBox53;
        private System.Windows.Forms.TextBox textBox54;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox textBox59;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox textBox55;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox textBox56;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.TextBox textBox67;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.TextBox textBox66;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox textBox60;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.TextBox textBox61;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.TextBox textBox62;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.TextBox textBox63;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TextBox textBox68;
        private dsBusActividad dsBusActividad1;
        private System.Data.SqlClient.SqlDataAdapter sqlDABusActividad;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private dsGenerico dsGenerico1;
        private System.Windows.Forms.TextBox textBox69;
        protected Soluciones2000.Tools.WinLib.tbBtn tbBtn2;
        private System.Data.SqlClient.SqlCommand sqlComActividad;
        private System.Windows.Forms.CheckBox checkBox35;
        private System.Windows.Forms.CheckBox checkBox34;
        private System.Windows.Forms.CheckBox checkBox37;
        private System.Windows.Forms.CheckBox checkBox36;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label66;
    }
}