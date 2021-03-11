using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de ParamTipos.
	/// </summary>
	public class ParamTipos : CatalogoGenerico
	{
		private System.Data.SqlClient.SqlDataAdapter sqlDAParamTipos;
		public System.Data.SqlClient.SqlConnection sqlConn;
        private LancNeo.dsTipo dsTipo1;
		private System.Data.SqlClient.SqlDataAdapter sqlDATipo;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand11;
        private LancNeo.dsTipoPrueba dsTipoPrueba1;
        private LancNeo.dsDiametro dsDiametro1;
		private System.Data.SqlClient.SqlDataAdapter sqlDADiametro;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlDataAdapter sqlDAPrueba;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlDataAdapter sqlDATempranos;
        private LancNeo.dsTempranos dsTempranos1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbDiam;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbTempranos;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbPrueba;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtDesParam;
		private System.Windows.Forms.TextBox txtEspA;
		private System.Windows.Forms.TextBox txtDiaA;
		private System.Windows.Forms.TextBox txtEdadA;
		private System.Windows.Forms.TextBox txtOGA;
		private System.Windows.Forms.TextBox txtEdadB;
		private System.Windows.Forms.TextBox txtDiaB;
		private System.Windows.Forms.TextBox txtEspB;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtOGB;
		private System.Windows.Forms.TextBox TxtDiaC;
		private System.Windows.Forms.TextBox txtEspC;
		private System.Windows.Forms.TextBox txtOGC;
		private System.Windows.Forms.TextBox txtEdadC;
		private System.Windows.Forms.TextBox txtEdadD;
		private System.Windows.Forms.TextBox txtDiaD;
		private System.Windows.Forms.TextBox txtEspD;
		private System.Windows.Forms.TextBox txtOGD;
		private System.Windows.Forms.TextBox txtEspE;
		private System.Windows.Forms.TextBox txtEdadE;
		private System.Windows.Forms.TextBox txtDiaE;
		private System.Windows.Forms.TextBox txtOGE;
		private System.Data.SqlClient.SqlDataAdapter sqlDABusParTip;
        private LancNeo.dsBusParTip dsBusParTip1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private dsParamTipos dsParamTipos1;
        private dsVapor dsVapor1;
        private Label label16;
        private ComboBox comboBox1;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private dsVapor dsVapor5;
        private dsVapor dsVapor4;
        private dsVapor dsVapor3;
        private dsVapor dsVapor2;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ParamTipos()
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
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParamTipos));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.sqlDAParamTipos = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsTipo1 = new LancNeo.dsTipo();
            this.sqlDATipo = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand11 = new System.Data.SqlClient.SqlCommand();
            this.dsTipoPrueba1 = new LancNeo.dsTipoPrueba();
            this.dsDiametro1 = new LancNeo.dsDiametro();
            this.sqlDADiametro = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAPrueba = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDATempranos = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.dsTempranos1 = new LancNeo.dsTempranos();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsBusParTip1 = new LancNeo.dsBusParTip();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPrueba = new System.Windows.Forms.ComboBox();
            this.dsParamTipos1 = new LancNeo.dsParamTipos();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTempranos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDiam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtDesParam = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOGE = new System.Windows.Forms.TextBox();
            this.txtEdadE = new System.Windows.Forms.TextBox();
            this.txtDiaE = new System.Windows.Forms.TextBox();
            this.txtEspE = new System.Windows.Forms.TextBox();
            this.txtOGD = new System.Windows.Forms.TextBox();
            this.txtEdadD = new System.Windows.Forms.TextBox();
            this.txtDiaD = new System.Windows.Forms.TextBox();
            this.txtEspD = new System.Windows.Forms.TextBox();
            this.txtOGC = new System.Windows.Forms.TextBox();
            this.txtEdadC = new System.Windows.Forms.TextBox();
            this.TxtDiaC = new System.Windows.Forms.TextBox();
            this.txtEspC = new System.Windows.Forms.TextBox();
            this.txtOGB = new System.Windows.Forms.TextBox();
            this.txtEdadB = new System.Windows.Forms.TextBox();
            this.txtDiaB = new System.Windows.Forms.TextBox();
            this.txtEspB = new System.Windows.Forms.TextBox();
            this.txtOGA = new System.Windows.Forms.TextBox();
            this.txtEdadA = new System.Windows.Forms.TextBox();
            this.txtDiaA = new System.Windows.Forms.TextBox();
            this.txtEspA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sqlDABusParTip = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.dsVapor1 = new LancNeo.dsVapor();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.dsVapor2 = new LancNeo.dsVapor();
            this.dsVapor3 = new LancNeo.dsVapor();
            this.dsVapor4 = new LancNeo.dsVapor();
            this.dsVapor5 = new LancNeo.dsVapor();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTempranos1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusParTip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParamTipos1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsVapor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVapor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVapor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVapor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVapor5)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 395);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(580, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(580, 64);
            // 
            // sqlDAParamTipos
            // 
            this.sqlDAParamTipos.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAParamTipos.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAParamTipos.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAParamTipos.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ParamTipos", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdTipo", "IdTipo"),
                        new System.Data.Common.DataColumnMapping("IdDiam", "IdDiam"),
                        new System.Data.Common.DataColumnMapping("IdTempranos", "IdTempranos"),
                        new System.Data.Common.DataColumnMapping("IdPrueba", "IdPrueba"),
                        new System.Data.Common.DataColumnMapping("DesPar", "DesPar"),
                        new System.Data.Common.DataColumnMapping("EspecimenA", "EspecimenA"),
                        new System.Data.Common.DataColumnMapping("DiaA", "DiaA"),
                        new System.Data.Common.DataColumnMapping("EdadA", "EdadA"),
                        new System.Data.Common.DataColumnMapping("OrdenGraA", "OrdenGraA"),
                        new System.Data.Common.DataColumnMapping("EspecimenB", "EspecimenB"),
                        new System.Data.Common.DataColumnMapping("DiaB", "DiaB"),
                        new System.Data.Common.DataColumnMapping("EdadB", "EdadB"),
                        new System.Data.Common.DataColumnMapping("OrdenGraB", "OrdenGraB"),
                        new System.Data.Common.DataColumnMapping("EspecimenC", "EspecimenC"),
                        new System.Data.Common.DataColumnMapping("DiaC", "DiaC"),
                        new System.Data.Common.DataColumnMapping("EdadC", "EdadC"),
                        new System.Data.Common.DataColumnMapping("OrdenGraC", "OrdenGraC"),
                        new System.Data.Common.DataColumnMapping("EspecimenD", "EspecimenD"),
                        new System.Data.Common.DataColumnMapping("DiaD", "DiaD"),
                        new System.Data.Common.DataColumnMapping("EdadD", "EdadD"),
                        new System.Data.Common.DataColumnMapping("OrdenGraD", "OrdenGraD"),
                        new System.Data.Common.DataColumnMapping("EspecimenE", "EspecimenE"),
                        new System.Data.Common.DataColumnMapping("DiaE", "DiaE"),
                        new System.Data.Common.DataColumnMapping("EdadE", "EdadE"),
                        new System.Data.Common.DataColumnMapping("OrdenGraE", "OrdenGraE"),
                        new System.Data.Common.DataColumnMapping("VaporA", "VaporA"),
                        new System.Data.Common.DataColumnMapping("VaporB", "VaporB"),
                        new System.Data.Common.DataColumnMapping("VaporC", "VaporC"),
                        new System.Data.Common.DataColumnMapping("VaporD", "VaporD"),
                        new System.Data.Common.DataColumnMapping("VaporE", "VaporE")})});
            this.sqlDAParamTipos.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdTipo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdTipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdDiam", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdDiam", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdTempranos", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdTempranos", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdPrueba", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPrueba", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DesPar", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DesPar", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EspecimenA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EspecimenA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EspecimenA", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EspecimenA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DiaA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DiaA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DiaA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DiaA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EdadA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EdadA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EdadA", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EdadA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OrdenGraA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OrdenGraA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OrdenGraA", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrdenGraA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EspecimenB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EspecimenB", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EspecimenB", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EspecimenB", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DiaB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DiaB", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DiaB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DiaB", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EdadB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EdadB", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EdadB", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EdadB", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OrdenGraB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OrdenGraB", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OrdenGraB", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrdenGraB", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EspecimenC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EspecimenC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EspecimenC", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EspecimenC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DiaC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DiaC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DiaC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DiaC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EdadC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EdadC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EdadC", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EdadC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OrdenGraC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OrdenGraC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OrdenGraC", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrdenGraC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EspecimenD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EspecimenD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EspecimenD", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EspecimenD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DiaD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DiaD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DiaD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DiaD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EdadD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EdadD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EdadD", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EdadD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OrdenGraD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OrdenGraD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OrdenGraD", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrdenGraD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EspecimenE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EspecimenE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EspecimenE", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EspecimenE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DiaE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DiaE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DiaE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DiaE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EdadE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EdadE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EdadE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EdadE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OrdenGraE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OrdenGraE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OrdenGraE", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrdenGraE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VaporA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VaporA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VaporA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VaporA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VaporB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VaporB", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VaporB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VaporB", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VaporC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VaporC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VaporC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VaporC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VaporD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VaporD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VaporD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VaporD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VaporE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VaporE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VaporE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VaporE", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdTipo", System.Data.SqlDbType.Int, 0, "IdTipo"),
            new System.Data.SqlClient.SqlParameter("@IdDiam", System.Data.SqlDbType.SmallInt, 0, "IdDiam"),
            new System.Data.SqlClient.SqlParameter("@IdTempranos", System.Data.SqlDbType.SmallInt, 0, "IdTempranos"),
            new System.Data.SqlClient.SqlParameter("@IdPrueba", System.Data.SqlDbType.SmallInt, 0, "IdPrueba"),
            new System.Data.SqlClient.SqlParameter("@DesPar", System.Data.SqlDbType.VarChar, 0, "DesPar"),
            new System.Data.SqlClient.SqlParameter("@EspecimenA", System.Data.SqlDbType.SmallInt, 0, "EspecimenA"),
            new System.Data.SqlClient.SqlParameter("@DiaA", System.Data.SqlDbType.Int, 0, "DiaA"),
            new System.Data.SqlClient.SqlParameter("@EdadA", System.Data.SqlDbType.VarChar, 0, "EdadA"),
            new System.Data.SqlClient.SqlParameter("@OrdenGraA", System.Data.SqlDbType.SmallInt, 0, "OrdenGraA"),
            new System.Data.SqlClient.SqlParameter("@EspecimenB", System.Data.SqlDbType.SmallInt, 0, "EspecimenB"),
            new System.Data.SqlClient.SqlParameter("@DiaB", System.Data.SqlDbType.Int, 0, "DiaB"),
            new System.Data.SqlClient.SqlParameter("@EdadB", System.Data.SqlDbType.VarChar, 0, "EdadB"),
            new System.Data.SqlClient.SqlParameter("@OrdenGraB", System.Data.SqlDbType.SmallInt, 0, "OrdenGraB"),
            new System.Data.SqlClient.SqlParameter("@EspecimenC", System.Data.SqlDbType.SmallInt, 0, "EspecimenC"),
            new System.Data.SqlClient.SqlParameter("@DiaC", System.Data.SqlDbType.Int, 0, "DiaC"),
            new System.Data.SqlClient.SqlParameter("@EdadC", System.Data.SqlDbType.VarChar, 0, "EdadC"),
            new System.Data.SqlClient.SqlParameter("@OrdenGraC", System.Data.SqlDbType.SmallInt, 0, "OrdenGraC"),
            new System.Data.SqlClient.SqlParameter("@EspecimenD", System.Data.SqlDbType.SmallInt, 0, "EspecimenD"),
            new System.Data.SqlClient.SqlParameter("@DiaD", System.Data.SqlDbType.Int, 0, "DiaD"),
            new System.Data.SqlClient.SqlParameter("@EdadD", System.Data.SqlDbType.VarChar, 0, "EdadD"),
            new System.Data.SqlClient.SqlParameter("@OrdenGraD", System.Data.SqlDbType.SmallInt, 0, "OrdenGraD"),
            new System.Data.SqlClient.SqlParameter("@EspecimenE", System.Data.SqlDbType.SmallInt, 0, "EspecimenE"),
            new System.Data.SqlClient.SqlParameter("@DiaE", System.Data.SqlDbType.Int, 0, "DiaE"),
            new System.Data.SqlClient.SqlParameter("@EdadE", System.Data.SqlDbType.VarChar, 0, "EdadE"),
            new System.Data.SqlClient.SqlParameter("@OrdenGraE", System.Data.SqlDbType.SmallInt, 0, "OrdenGraE"),
            new System.Data.SqlClient.SqlParameter("@VaporA", System.Data.SqlDbType.Int, 0, "VaporA"),
            new System.Data.SqlClient.SqlParameter("@VaporB", System.Data.SqlDbType.Int, 0, "VaporB"),
            new System.Data.SqlClient.SqlParameter("@VaporC", System.Data.SqlDbType.Int, 0, "VaporC"),
            new System.Data.SqlClient.SqlParameter("@VaporD", System.Data.SqlDbType.Int, 0, "VaporD"),
            new System.Data.SqlClient.SqlParameter("@VaporE", System.Data.SqlDbType.Int, 0, "VaporE")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdTipo", System.Data.SqlDbType.Int, 0, "IdTipo"),
            new System.Data.SqlClient.SqlParameter("@IdDiam", System.Data.SqlDbType.SmallInt, 0, "IdDiam"),
            new System.Data.SqlClient.SqlParameter("@IdTempranos", System.Data.SqlDbType.SmallInt, 0, "IdTempranos"),
            new System.Data.SqlClient.SqlParameter("@IdPrueba", System.Data.SqlDbType.SmallInt, 0, "IdPrueba"),
            new System.Data.SqlClient.SqlParameter("@DesPar", System.Data.SqlDbType.VarChar, 0, "DesPar"),
            new System.Data.SqlClient.SqlParameter("@EspecimenA", System.Data.SqlDbType.SmallInt, 0, "EspecimenA"),
            new System.Data.SqlClient.SqlParameter("@DiaA", System.Data.SqlDbType.Int, 0, "DiaA"),
            new System.Data.SqlClient.SqlParameter("@EdadA", System.Data.SqlDbType.VarChar, 0, "EdadA"),
            new System.Data.SqlClient.SqlParameter("@OrdenGraA", System.Data.SqlDbType.SmallInt, 0, "OrdenGraA"),
            new System.Data.SqlClient.SqlParameter("@EspecimenB", System.Data.SqlDbType.SmallInt, 0, "EspecimenB"),
            new System.Data.SqlClient.SqlParameter("@DiaB", System.Data.SqlDbType.Int, 0, "DiaB"),
            new System.Data.SqlClient.SqlParameter("@EdadB", System.Data.SqlDbType.VarChar, 0, "EdadB"),
            new System.Data.SqlClient.SqlParameter("@OrdenGraB", System.Data.SqlDbType.SmallInt, 0, "OrdenGraB"),
            new System.Data.SqlClient.SqlParameter("@EspecimenC", System.Data.SqlDbType.SmallInt, 0, "EspecimenC"),
            new System.Data.SqlClient.SqlParameter("@DiaC", System.Data.SqlDbType.Int, 0, "DiaC"),
            new System.Data.SqlClient.SqlParameter("@EdadC", System.Data.SqlDbType.VarChar, 0, "EdadC"),
            new System.Data.SqlClient.SqlParameter("@OrdenGraC", System.Data.SqlDbType.SmallInt, 0, "OrdenGraC"),
            new System.Data.SqlClient.SqlParameter("@EspecimenD", System.Data.SqlDbType.SmallInt, 0, "EspecimenD"),
            new System.Data.SqlClient.SqlParameter("@DiaD", System.Data.SqlDbType.Int, 0, "DiaD"),
            new System.Data.SqlClient.SqlParameter("@EdadD", System.Data.SqlDbType.VarChar, 0, "EdadD"),
            new System.Data.SqlClient.SqlParameter("@OrdenGraD", System.Data.SqlDbType.SmallInt, 0, "OrdenGraD"),
            new System.Data.SqlClient.SqlParameter("@EspecimenE", System.Data.SqlDbType.SmallInt, 0, "EspecimenE"),
            new System.Data.SqlClient.SqlParameter("@DiaE", System.Data.SqlDbType.Int, 0, "DiaE"),
            new System.Data.SqlClient.SqlParameter("@EdadE", System.Data.SqlDbType.VarChar, 0, "EdadE"),
            new System.Data.SqlClient.SqlParameter("@OrdenGraE", System.Data.SqlDbType.SmallInt, 0, "OrdenGraE"),
            new System.Data.SqlClient.SqlParameter("@VaporA", System.Data.SqlDbType.Int, 0, "VaporA"),
            new System.Data.SqlClient.SqlParameter("@VaporB", System.Data.SqlDbType.Int, 0, "VaporB"),
            new System.Data.SqlClient.SqlParameter("@VaporC", System.Data.SqlDbType.Int, 0, "VaporC"),
            new System.Data.SqlClient.SqlParameter("@VaporD", System.Data.SqlDbType.Int, 0, "VaporD"),
            new System.Data.SqlClient.SqlParameter("@VaporE", System.Data.SqlDbType.Int, 0, "VaporE"),
            new System.Data.SqlClient.SqlParameter("@Original_IdTipo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdTipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdDiam", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdDiam", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdTempranos", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdTempranos", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdPrueba", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdPrueba", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DesPar", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DesPar", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EspecimenA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EspecimenA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EspecimenA", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EspecimenA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DiaA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DiaA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DiaA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DiaA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EdadA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EdadA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EdadA", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EdadA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OrdenGraA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OrdenGraA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OrdenGraA", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrdenGraA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EspecimenB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EspecimenB", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EspecimenB", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EspecimenB", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DiaB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DiaB", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DiaB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DiaB", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EdadB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EdadB", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EdadB", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EdadB", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OrdenGraB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OrdenGraB", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OrdenGraB", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrdenGraB", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EspecimenC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EspecimenC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EspecimenC", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EspecimenC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DiaC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DiaC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DiaC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DiaC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EdadC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EdadC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EdadC", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EdadC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OrdenGraC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OrdenGraC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OrdenGraC", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrdenGraC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EspecimenD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EspecimenD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EspecimenD", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EspecimenD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DiaD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DiaD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DiaD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DiaD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EdadD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EdadD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EdadD", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EdadD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OrdenGraD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OrdenGraD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OrdenGraD", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrdenGraD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EspecimenE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EspecimenE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EspecimenE", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EspecimenE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DiaE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DiaE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DiaE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DiaE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EdadE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EdadE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EdadE", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EdadE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OrdenGraE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OrdenGraE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OrdenGraE", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrdenGraE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VaporA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VaporA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VaporA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VaporA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VaporB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VaporB", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VaporB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VaporB", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VaporC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VaporC", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VaporC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VaporC", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VaporD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VaporD", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VaporD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VaporD", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_VaporE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "VaporE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_VaporE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VaporE", System.Data.DataRowVersion.Original, null)});
            // 
            // dsTipo1
            // 
            this.dsTipo1.DataSetName = "dsTipo";
            this.dsTipo1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTipo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDATipo
            // 
            this.sqlDATipo.SelectCommand = this.sqlSelectCommand11;
            this.sqlDATipo.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Tipo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("DesTipo", "DesTipo")})});
            // 
            // sqlSelectCommand11
            // 
            this.sqlSelectCommand11.CommandText = "SELECT Tipo, DesTipo FROM Tipo ORDER BY Tipo";
            this.sqlSelectCommand11.Connection = this.sqlConn;
            // 
            // dsTipoPrueba1
            // 
            this.dsTipoPrueba1.DataSetName = "dsTipoPrueba";
            this.dsTipoPrueba1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTipoPrueba1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsDiametro1
            // 
            this.dsDiametro1.DataSetName = "dsDiametro";
            this.dsDiametro1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsDiametro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDADiametro
            // 
            this.sqlDADiametro.SelectCommand = this.sqlSelectCommand3;
            this.sqlDADiametro.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Diametro", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdDiam", "IdDiam"),
                        new System.Data.Common.DataColumnMapping("Diametro", "Diametro")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT IdDiam, Diametro, Figura FROM Diametro";
            this.sqlSelectCommand3.Connection = this.sqlConn;
            // 
            // sqlDAPrueba
            // 
            this.sqlDAPrueba.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAPrueba.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Tipoprueba", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdPrueba", "IdPrueba"),
                        new System.Data.Common.DataColumnMapping("Prueba", "Prueba")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT IdPrueba, Prueba FROM Tipoprueba";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            // 
            // sqlDATempranos
            // 
            this.sqlDATempranos.SelectCommand = this.sqlSelectCommand5;
            this.sqlDATempranos.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Tempranos", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdTempranos", "IdTempranos"),
                        new System.Data.Common.DataColumnMapping("Tempranos", "Tempranos")})});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "SELECT IdTempranos, Tempranos FROM Tempranos";
            this.sqlSelectCommand5.Connection = this.sqlConn;
            // 
            // dsTempranos1
            // 
            this.dsTempranos1.DataSetName = "dsTempranos";
            this.dsTempranos1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsTempranos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbPrueba);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbTempranos);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbDiam);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbTipo);
            this.panel2.Controls.Add(this.txtDesParam);
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 120);
            this.panel2.TabIndex = 4;
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoDlgBusq = 600;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsBusParTip1.ParamTipos;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(288, 16);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 8;
            this.toolTip1.SetToolTip(this.buscaBtn1, "Busca");
            // 
            // dsBusParTip1
            // 
            this.dsBusParTip1.DataSetName = "dsBusParTip";
            this.dsBusParTip1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusParTip1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(304, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descipción:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(76, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prueba:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPrueba
            // 
            this.cmbPrueba.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsParamTipos1, "ParamTipos.IdPrueba", true));
            this.cmbPrueba.DataSource = this.dsTipoPrueba1.Tipoprueba;
            this.cmbPrueba.DisplayMember = "Prueba";
            this.cmbPrueba.Location = new System.Drawing.Point(148, 89);
            this.cmbPrueba.Name = "cmbPrueba";
            this.cmbPrueba.Size = new System.Drawing.Size(121, 21);
            this.cmbPrueba.TabIndex = 6;
            this.cmbPrueba.ValueMember = "IdPrueba";
            // 
            // dsParamTipos1
            // 
            this.dsParamTipos1.DataSetName = "dsParamTipos";
            this.dsParamTipos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(76, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tempranos:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTempranos
            // 
            this.cmbTempranos.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsParamTipos1, "ParamTipos.IdTempranos", true));
            this.cmbTempranos.DataSource = this.dsTempranos1.Tempranos;
            this.cmbTempranos.DisplayMember = "Tempranos";
            this.cmbTempranos.Location = new System.Drawing.Point(148, 65);
            this.cmbTempranos.Name = "cmbTempranos";
            this.cmbTempranos.Size = new System.Drawing.Size(121, 21);
            this.cmbTempranos.TabIndex = 4;
            this.cmbTempranos.ValueMember = "IdTempranos";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(84, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Diametro:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbDiam
            // 
            this.cmbDiam.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsParamTipos1, "ParamTipos.IdDiam", true));
            this.cmbDiam.DataSource = this.dsDiametro1.Diametro;
            this.cmbDiam.DisplayMember = "Figura";
            this.cmbDiam.Location = new System.Drawing.Point(148, 41);
            this.cmbDiam.Name = "cmbDiam";
            this.cmbDiam.Size = new System.Drawing.Size(121, 21);
            this.cmbDiam.TabIndex = 2;
            this.cmbDiam.ValueMember = "IdDiam";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(92, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsParamTipos1, "ParamTipos.IdTipo", true));
            this.cmbTipo.DataSource = this.dsTipo1.Tipo;
            this.cmbTipo.DisplayMember = "DesTipo";
            this.cmbTipo.Location = new System.Drawing.Point(148, 16);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 0;
            this.cmbTipo.ValueMember = "Tipo";
            // 
            // txtDesParam
            // 
            this.txtDesParam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.DesPar", true));
            this.txtDesParam.Location = new System.Drawing.Point(376, 89);
            this.txtDesParam.Name = "txtDesParam";
            this.txtDesParam.Size = new System.Drawing.Size(156, 20);
            this.txtDesParam.TabIndex = 0;
            this.txtDesParam.Text = "textBox1";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.comboBox5);
            this.panel3.Controls.Add(this.comboBox4);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtOGE);
            this.panel3.Controls.Add(this.txtEdadE);
            this.panel3.Controls.Add(this.txtDiaE);
            this.panel3.Controls.Add(this.txtEspE);
            this.panel3.Controls.Add(this.txtOGD);
            this.panel3.Controls.Add(this.txtEdadD);
            this.panel3.Controls.Add(this.txtDiaD);
            this.panel3.Controls.Add(this.txtEspD);
            this.panel3.Controls.Add(this.txtOGC);
            this.panel3.Controls.Add(this.txtEdadC);
            this.panel3.Controls.Add(this.TxtDiaC);
            this.panel3.Controls.Add(this.txtEspC);
            this.panel3.Controls.Add(this.txtOGB);
            this.panel3.Controls.Add(this.txtEdadB);
            this.panel3.Controls.Add(this.txtDiaB);
            this.panel3.Controls.Add(this.txtEspB);
            this.panel3.Controls.Add(this.txtOGA);
            this.panel3.Controls.Add(this.txtEdadA);
            this.panel3.Controls.Add(this.txtDiaA);
            this.panel3.Controls.Add(this.txtEspA);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(0, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 204);
            this.panel3.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(272, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 16);
            this.label15.TabIndex = 28;
            this.label15.Text = "<<Especificado>>";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(272, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 23);
            this.label13.TabIndex = 25;
            this.label13.Text = "( C ):";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(372, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 23);
            this.label12.TabIndex = 26;
            this.label12.Text = "( D ):";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(468, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 23);
            this.label14.TabIndex = 27;
            this.label14.Text = "( E ):";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(176, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 23);
            this.label11.TabIndex = 24;
            this.label11.Text = "( B ):";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(84, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "( A ):";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Orden grafica:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Edad:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Día:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOGE
            // 
            this.txtOGE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.OrdenGraE", true));
            this.txtOGE.Location = new System.Drawing.Point(468, 165);
            this.txtOGE.Name = "txtOGE";
            this.txtOGE.Size = new System.Drawing.Size(64, 20);
            this.txtOGE.TabIndex = 19;
            this.txtOGE.Text = "textBox18";
            // 
            // txtEdadE
            // 
            this.txtEdadE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.EdadE", true));
            this.txtEdadE.Location = new System.Drawing.Point(468, 104);
            this.txtEdadE.Name = "txtEdadE";
            this.txtEdadE.Size = new System.Drawing.Size(64, 20);
            this.txtEdadE.TabIndex = 18;
            this.txtEdadE.Text = "textBox19";
            // 
            // txtDiaE
            // 
            this.txtDiaE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.DiaE", true));
            this.txtDiaE.Location = new System.Drawing.Point(468, 76);
            this.txtDiaE.Name = "txtDiaE";
            this.txtDiaE.Size = new System.Drawing.Size(64, 20);
            this.txtDiaE.TabIndex = 17;
            this.txtDiaE.Text = "textBox20";
            // 
            // txtEspE
            // 
            this.txtEspE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.EspecimenE", true));
            this.txtEspE.Location = new System.Drawing.Point(468, 48);
            this.txtEspE.Name = "txtEspE";
            this.txtEspE.Size = new System.Drawing.Size(64, 20);
            this.txtEspE.TabIndex = 16;
            this.txtEspE.Text = "textBox21";
            // 
            // txtOGD
            // 
            this.txtOGD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.OrdenGraD", true));
            this.txtOGD.Location = new System.Drawing.Point(372, 165);
            this.txtOGD.Name = "txtOGD";
            this.txtOGD.Size = new System.Drawing.Size(64, 20);
            this.txtOGD.TabIndex = 15;
            this.txtOGD.Text = "textBox14";
            // 
            // txtEdadD
            // 
            this.txtEdadD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.EdadD", true));
            this.txtEdadD.Location = new System.Drawing.Point(372, 104);
            this.txtEdadD.Name = "txtEdadD";
            this.txtEdadD.Size = new System.Drawing.Size(64, 20);
            this.txtEdadD.TabIndex = 14;
            this.txtEdadD.Text = "textBox15";
            // 
            // txtDiaD
            // 
            this.txtDiaD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.DiaD", true));
            this.txtDiaD.Location = new System.Drawing.Point(372, 76);
            this.txtDiaD.Name = "txtDiaD";
            this.txtDiaD.Size = new System.Drawing.Size(64, 20);
            this.txtDiaD.TabIndex = 13;
            this.txtDiaD.Text = "textBox16";
            // 
            // txtEspD
            // 
            this.txtEspD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.EspecimenD", true));
            this.txtEspD.Location = new System.Drawing.Point(372, 48);
            this.txtEspD.Name = "txtEspD";
            this.txtEspD.Size = new System.Drawing.Size(64, 20);
            this.txtEspD.TabIndex = 12;
            this.txtEspD.Text = "textBox17";
            // 
            // txtOGC
            // 
            this.txtOGC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.OrdenGraC", true));
            this.txtOGC.Location = new System.Drawing.Point(272, 165);
            this.txtOGC.Name = "txtOGC";
            this.txtOGC.Size = new System.Drawing.Size(64, 20);
            this.txtOGC.TabIndex = 11;
            this.txtOGC.Text = "textBox10";
            // 
            // txtEdadC
            // 
            this.txtEdadC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.EdadC", true));
            this.txtEdadC.Location = new System.Drawing.Point(272, 104);
            this.txtEdadC.Name = "txtEdadC";
            this.txtEdadC.Size = new System.Drawing.Size(64, 20);
            this.txtEdadC.TabIndex = 10;
            this.txtEdadC.Text = "textBox11";
            // 
            // TxtDiaC
            // 
            this.TxtDiaC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.DiaC", true));
            this.TxtDiaC.Location = new System.Drawing.Point(272, 76);
            this.TxtDiaC.Name = "TxtDiaC";
            this.TxtDiaC.Size = new System.Drawing.Size(64, 20);
            this.TxtDiaC.TabIndex = 9;
            this.TxtDiaC.Text = "textBox12";
            // 
            // txtEspC
            // 
            this.txtEspC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.EspecimenC", true));
            this.txtEspC.Location = new System.Drawing.Point(272, 48);
            this.txtEspC.Name = "txtEspC";
            this.txtEspC.Size = new System.Drawing.Size(64, 20);
            this.txtEspC.TabIndex = 8;
            this.txtEspC.Text = "textBox13";
            // 
            // txtOGB
            // 
            this.txtOGB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.OrdenGraB", true));
            this.txtOGB.Location = new System.Drawing.Point(176, 165);
            this.txtOGB.Name = "txtOGB";
            this.txtOGB.Size = new System.Drawing.Size(64, 20);
            this.txtOGB.TabIndex = 7;
            this.txtOGB.Text = "textBox6";
            // 
            // txtEdadB
            // 
            this.txtEdadB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.EdadB", true));
            this.txtEdadB.Location = new System.Drawing.Point(176, 104);
            this.txtEdadB.Name = "txtEdadB";
            this.txtEdadB.Size = new System.Drawing.Size(64, 20);
            this.txtEdadB.TabIndex = 6;
            this.txtEdadB.Text = "textBox7";
            // 
            // txtDiaB
            // 
            this.txtDiaB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.DiaB", true));
            this.txtDiaB.Location = new System.Drawing.Point(176, 76);
            this.txtDiaB.Name = "txtDiaB";
            this.txtDiaB.Size = new System.Drawing.Size(64, 20);
            this.txtDiaB.TabIndex = 5;
            this.txtDiaB.Text = "textBox8";
            // 
            // txtEspB
            // 
            this.txtEspB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.EspecimenB", true));
            this.txtEspB.Location = new System.Drawing.Point(176, 48);
            this.txtEspB.Name = "txtEspB";
            this.txtEspB.Size = new System.Drawing.Size(64, 20);
            this.txtEspB.TabIndex = 4;
            this.txtEspB.Text = "textBox9";
            // 
            // txtOGA
            // 
            this.txtOGA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.OrdenGraA", true));
            this.txtOGA.Location = new System.Drawing.Point(84, 165);
            this.txtOGA.Name = "txtOGA";
            this.txtOGA.Size = new System.Drawing.Size(64, 20);
            this.txtOGA.TabIndex = 3;
            this.txtOGA.Text = "textBox5";
            // 
            // txtEdadA
            // 
            this.txtEdadA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.EdadA", true));
            this.txtEdadA.Location = new System.Drawing.Point(84, 104);
            this.txtEdadA.Name = "txtEdadA";
            this.txtEdadA.Size = new System.Drawing.Size(64, 20);
            this.txtEdadA.TabIndex = 2;
            this.txtEdadA.Text = "textBox4";
            // 
            // txtDiaA
            // 
            this.txtDiaA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.DiaA", true));
            this.txtDiaA.Location = new System.Drawing.Point(84, 76);
            this.txtDiaA.Name = "txtDiaA";
            this.txtDiaA.Size = new System.Drawing.Size(64, 20);
            this.txtDiaA.TabIndex = 1;
            this.txtDiaA.Text = "textBox3";
            // 
            // txtEspA
            // 
            this.txtEspA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsParamTipos1, "ParamTipos.EspecimenA", true));
            this.txtEspA.Location = new System.Drawing.Point(84, 48);
            this.txtEspA.Name = "txtEspA";
            this.txtEspA.Size = new System.Drawing.Size(64, 20);
            this.txtEspA.TabIndex = 0;
            this.txtEspA.Text = "textBox2";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Especimen:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sqlDABusParTip
            // 
            this.sqlDABusParTip.SelectCommand = this.sqlSelectCommand4;
            this.sqlDABusParTip.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ParamTipos", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("DesTipo", "DesTipo"),
                        new System.Data.Common.DataColumnMapping("Diametro", "Diametro"),
                        new System.Data.Common.DataColumnMapping("Figura", "Figura"),
                        new System.Data.Common.DataColumnMapping("Tempranos", "Tempranos"),
                        new System.Data.Common.DataColumnMapping("Prueba", "Prueba"),
                        new System.Data.Common.DataColumnMapping("DesPar", "DesPar")})});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = resources.GetString("sqlSelectCommand4.CommandText");
            this.sqlSelectCommand4.Connection = this.sqlConn;
            // 
            // dsVapor1
            // 
            this.dsVapor1.DataSetName = "dsVapor";
            this.dsVapor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsParamTipos1, "ParamTipos.VaporA", true));
            this.comboBox1.DataSource = this.dsVapor1;
            this.comboBox1.DisplayMember = "Vapor.Vapor";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.ValueMember = "Vapor.IdVapor";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(10, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 23);
            this.label16.TabIndex = 30;
            this.label16.Text = "Vapor:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsParamTipos1, "ParamTipos.VaporB", true));
            this.comboBox2.DataSource = this.dsVapor2;
            this.comboBox2.DisplayMember = "Vapor.Vapor";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(176, 130);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 21);
            this.comboBox2.TabIndex = 31;
            this.comboBox2.ValueMember = "Vapor.IdVapor";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsParamTipos1, "ParamTipos.VaporC", true));
            this.comboBox3.DataSource = this.dsVapor3;
            this.comboBox3.DisplayMember = "Vapor.Vapor";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(272, 130);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(80, 21);
            this.comboBox3.TabIndex = 32;
            this.comboBox3.ValueMember = "Vapor.IdVapor";
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsParamTipos1, "ParamTipos.VaporD", true));
            this.comboBox4.DataSource = this.dsVapor4;
            this.comboBox4.DisplayMember = "Vapor.Vapor";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(372, 130);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(80, 21);
            this.comboBox4.TabIndex = 33;
            this.comboBox4.ValueMember = "Vapor.IdVapor";
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsParamTipos1, "ParamTipos.VaporE", true));
            this.comboBox5.DataSource = this.dsVapor5;
            this.comboBox5.DisplayMember = "Vapor.Vapor";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(468, 130);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(80, 21);
            this.comboBox5.TabIndex = 34;
            this.comboBox5.ValueMember = "Vapor.IdVapor";
            // 
            // dsVapor2
            // 
            this.dsVapor2.DataSetName = "dsVapor";
            this.dsVapor2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsVapor3
            // 
            this.dsVapor3.DataSetName = "dsVapor";
            this.dsVapor3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsVapor4
            // 
            this.dsVapor4.DataSetName = "dsVapor";
            this.dsVapor4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsVapor5
            // 
            this.dsVapor5.DataSetName = "dsVapor";
            this.dsVapor5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ParamTipos
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(580, 417);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAParamTipos;
            this.dsGeneral = this.dsParamTipos1;
            this.Name = "ParamTipos";
            this.NombreTabla = "ParamTipos";
            this.Text = "ParamTipos";
            this.Load += new System.EventHandler(this.ParamTipos_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsTipo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTipoPrueba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiametro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTempranos1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusParTip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsParamTipos1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsVapor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVapor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVapor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVapor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVapor5)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void ParamTipos_Load(object sender, System.EventArgs e)
		{
            dsVapor1.Vapor.AddVaporRow(1, "Normal");
            dsVapor1.Vapor.AddVaporRow(2, "Vapor");
            dsVapor2.Vapor.AddVaporRow(1, "Normal");
            dsVapor2.Vapor.AddVaporRow(2, "Vapor");
            dsVapor3.Vapor.AddVaporRow(1, "Normal");
            dsVapor3.Vapor.AddVaporRow(2, "Vapor");
            dsVapor4.Vapor.AddVaporRow(1, "Normal");
            dsVapor4.Vapor.AddVaporRow(2, "Vapor");
            dsVapor5.Vapor.AddVaporRow(1, "Normal");
            dsVapor5.Vapor.AddVaporRow(2, "Vapor");
            sqlDABusParTip.Fill(dsBusParTip1, "ParamTipos");
			sqlDAParamTipos.Fill(dsParamTipos1, "ParamTipos");
			sqlDATipo.Fill(dsTipo1,"Tipo");
			sqlDADiametro.Fill(dsDiametro1, "Diametro");
			sqlDATempranos.Fill(dsTempranos1, "Tempranos");
			sqlDAPrueba.Fill(dsTipoPrueba1, "TipoPrueba");
			this.buscaBtn1.Catalogo = this;
		}

        private void label16_Click(object sender, EventArgs e)
        {

        }


	}
}
