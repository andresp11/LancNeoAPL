using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;
using System.Data;
using System.Data.SqlClient;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de SoldaEns.
	/// </summary>
	public class SoldaEns : CatalogoGenerico
	{
        private string IdUsuario;

        private System.Data.SqlClient.SqlDataAdapter sqlDAEspecifica;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsSoldaEs dsSoldaEs1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtEspec;
		private System.Windows.Forms.TextBox txtFolio;
		private LancNeo.dsAcero dsAcero1;
		private System.Windows.Forms.TextBox txtAlarga;
		private System.Windows.Forms.TextBox txtEsMax;
		private System.Windows.Forms.TextBox txtEsLE;
		private System.Windows.Forms.TextBox txtGrado;
		private System.Windows.Forms.ComboBox cmbNumero;
		private System.Data.SqlClient.SqlDataAdapter sqlDAAcero;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
        private System.Data.SqlClient.SqlDataAdapter sqlDAResultado;
        private System.Windows.Forms.Label label22;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private DataGridView dgSoldaEns;
        private DataGridViewTextBoxColumn fOLIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn especificaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn muestraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargaLEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargaMaxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn esfuerzoLEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn esfuerzoMAXDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alargamientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tJuntaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rJuntaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private DataGridTextBoxColumn Observaciones;
        private DataGridTextBoxColumn RJunta;
        private DataGridTextBoxColumn TJunta;
        private DataGridTextBoxColumn Alargamiento;
        private DataGridTextBoxColumn EsfuerzoMAX;
        private DataGridTextBoxColumn EsfuerzoLE;
        private DataGridTextBoxColumn CargaMax;
        private DataGridTextBoxColumn CargaLE;
        private DataGridTextBoxColumn Area;
        private DataGridTextBoxColumn Muestra;
        private DataGridTextBoxColumn Especifica;
        private DataGridTextBoxColumn FOLIO;
        private TextBox txtUsrMov;
        private Label label25;

        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public SoldaEns()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoldaEns));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sqlDAEspecifica = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsSoldaEs1 = new LancNeo.dsSoldaEs();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAlarga = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEsMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEsLE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNumero = new System.Windows.Forms.ComboBox();
            this.dsAcero1 = new LancNeo.dsAcero();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEspec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlDAAcero = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDAResultado = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dgSoldaEns = new System.Windows.Forms.DataGridView();
            this.fOLIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especificaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muestraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esfuerzoLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esfuerzoMAXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alargamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tJuntaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rJuntaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridTextBoxColumn();
            this.RJunta = new System.Windows.Forms.DataGridTextBoxColumn();
            this.TJunta = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Alargamiento = new System.Windows.Forms.DataGridTextBoxColumn();
            this.EsfuerzoMAX = new System.Windows.Forms.DataGridTextBoxColumn();
            this.EsfuerzoLE = new System.Windows.Forms.DataGridTextBoxColumn();
            this.CargaMax = new System.Windows.Forms.DataGridTextBoxColumn();
            this.CargaLE = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Muestra = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Especifica = new System.Windows.Forms.DataGridTextBoxColumn();
            this.FOLIO = new System.Windows.Forms.DataGridTextBoxColumn();
            this.txtUsrMov = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSoldaEs1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoldaEns)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 511);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1016, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(1016, 64);
            // 
            // sqlDAEspecifica
            // 
            this.sqlDAEspecifica.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAEspecifica.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAEspecifica.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAEspecifica.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SoldaEsp", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("Especifica", "Especifica"),
                        new System.Data.Common.DataColumnMapping("Numero", "Numero"),
                        new System.Data.Common.DataColumnMapping("Grado", "Grado"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoLE", "EsfuerzoLE"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoMAX", "EsfuerzoMAX"),
                        new System.Data.Common.DataColumnMapping("Alargamiento", "Alargamiento"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoLEA", "EsfuerzoLEA"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoMAXA", "EsfuerzoMAXA"),
                        new System.Data.Common.DataColumnMapping("AlargamientoA", "AlargamientoA"),
                        new System.Data.Common.DataColumnMapping("Nominal", "Nominal"),
                        new System.Data.Common.DataColumnMapping("IdUsuario", "IdUsuario")})});
            this.sqlDAEspecifica.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Numero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Numero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Numero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoLE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoLE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoLE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EsfuerzoLE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoMAX", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMAX", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Alargamiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Alargamiento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoLEA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoLEA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoLEA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EsfuerzoLEA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoMAXA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoMAXA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMAXA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EsfuerzoMAXA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AlargamientoA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AlargamientoA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AlargamientoA", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "AlargamientoA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Nominal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nominal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Nominal", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Nominal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.Char, 0, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Especifica", System.Data.SqlDbType.SmallInt, 0, "Especifica"),
            new System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.Char, 0, "Numero"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 0, "Grado"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoLE", System.Data.SqlDbType.Int, 0, "EsfuerzoLE"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMAX", System.Data.SqlDbType.Int, 0, "EsfuerzoMAX"),
            new System.Data.SqlClient.SqlParameter("@Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoLEA", System.Data.SqlDbType.Int, 0, "EsfuerzoLEA"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMAXA", System.Data.SqlDbType.Int, 0, "EsfuerzoMAXA"),
            new System.Data.SqlClient.SqlParameter("@AlargamientoA", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "AlargamientoA", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Nominal", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Nominal", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario")});
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
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.Char, 0, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Especifica", System.Data.SqlDbType.SmallInt, 0, "Especifica"),
            new System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.Char, 0, "Numero"),
            new System.Data.SqlClient.SqlParameter("@Grado", System.Data.SqlDbType.NVarChar, 0, "Grado"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoLE", System.Data.SqlDbType.Int, 0, "EsfuerzoLE"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMAX", System.Data.SqlDbType.Int, 0, "EsfuerzoMAX"),
            new System.Data.SqlClient.SqlParameter("@Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoLEA", System.Data.SqlDbType.Int, 0, "EsfuerzoLEA"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMAXA", System.Data.SqlDbType.Int, 0, "EsfuerzoMAXA"),
            new System.Data.SqlClient.SqlParameter("@AlargamientoA", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "AlargamientoA", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Nominal", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Nominal", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario"),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Numero", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Numero", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Numero", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grado", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Grado", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoLE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoLE", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoLE", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EsfuerzoLE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoMAX", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMAX", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Alargamiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Alargamiento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoLEA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoLEA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoLEA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EsfuerzoLEA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EsfuerzoMAXA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EsfuerzoMAXA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMAXA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EsfuerzoMAXA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AlargamientoA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AlargamientoA", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AlargamientoA", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "AlargamientoA", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Nominal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nominal", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Nominal", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Nominal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
            // 
            // dsSoldaEs1
            // 
            this.dsSoldaEs1.DataSetName = "dsSoldaEs";
            this.dsSoldaEs1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsSoldaEs1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.txtUsrMov);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtAlarga);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtEsMax);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtEsLE);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtGrado);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbNumero);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtEspec);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtFolio);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 96);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 675;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsSoldaEs1.SoldaEsp;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(138, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gold;
            this.label18.Location = new System.Drawing.Point(90, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 18);
            this.label18.TabIndex = 46;
            this.label18.Text = "LANC";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Gold;
            this.label17.Location = new System.Drawing.Point(612, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 18);
            this.label17.TabIndex = 45;
            this.label17.Text = "ACI";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(970, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "(%)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(850, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = " (Kg/cm²)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(714, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = " (Kg/cm²)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSoldaEs1, "SoldaEsp.AlargamientoA", true));
            this.textBox1.Location = new System.Drawing.Point(966, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 41;
            this.textBox1.Text = "textBox7";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(900, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Alargamiento:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSoldaEs1, "SoldaEsp.EsfuerzoMAXA", true));
            this.textBox2.Location = new System.Drawing.Point(842, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 20);
            this.textBox2.TabIndex = 39;
            this.textBox2.Text = "textBox6";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(764, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Esfuerzo maximo:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSoldaEs1, "SoldaEsp.EsfuerzoLEA", true));
            this.textBox3.Location = new System.Drawing.Point(706, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(56, 20);
            this.textBox3.TabIndex = 37;
            this.textBox3.Text = "textBox5";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(646, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Esfuerzo LE:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Gold;
            this.label22.Location = new System.Drawing.Point(856, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(144, 20);
            this.label22.TabIndex = 35;
            this.label22.Text = "Especificación";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(462, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "(%)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(342, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = " (Kg/cm²)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(206, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = " (Kg/cm²)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAlarga
            // 
            this.txtAlarga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSoldaEs1, "SoldaEsp.Alargamiento", true));
            this.txtAlarga.Location = new System.Drawing.Point(458, 70);
            this.txtAlarga.Name = "txtAlarga";
            this.txtAlarga.Size = new System.Drawing.Size(32, 20);
            this.txtAlarga.TabIndex = 15;
            this.txtAlarga.Text = "textBox7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(392, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Alargamiento:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEsMax
            // 
            this.txtEsMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSoldaEs1, "SoldaEsp.EsfuerzoMAX", true));
            this.txtEsMax.Location = new System.Drawing.Point(334, 70);
            this.txtEsMax.Name = "txtEsMax";
            this.txtEsMax.Size = new System.Drawing.Size(56, 20);
            this.txtEsMax.TabIndex = 13;
            this.txtEsMax.Text = "textBox6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(256, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Esfuerzo maximo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEsLE
            // 
            this.txtEsLE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSoldaEs1, "SoldaEsp.EsfuerzoLE", true));
            this.txtEsLE.Location = new System.Drawing.Point(198, 70);
            this.txtEsLE.Name = "txtEsLE";
            this.txtEsLE.Size = new System.Drawing.Size(56, 20);
            this.txtEsLE.TabIndex = 11;
            this.txtEsLE.Text = "textBox5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Esfuerzo LE:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGrado
            // 
            this.txtGrado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSoldaEs1, "SoldaEsp.Grado", true));
            this.txtGrado.Location = new System.Drawing.Point(586, 16);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(64, 20);
            this.txtGrado.TabIndex = 7;
            this.txtGrado.Text = "textBox3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grado:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbNumero
            // 
            this.cmbNumero.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsSoldaEs1, "SoldaEsp.Numero", true));
            this.cmbNumero.DataSource = this.dsAcero1.Acero;
            this.cmbNumero.DisplayMember = "Numero";
            this.cmbNumero.Location = new System.Drawing.Point(454, 16);
            this.cmbNumero.Name = "cmbNumero";
            this.cmbNumero.Size = new System.Drawing.Size(80, 21);
            this.cmbNumero.TabIndex = 5;
            this.cmbNumero.ValueMember = "Numero";
            // 
            // dsAcero1
            // 
            this.dsAcero1.DataSetName = "dsAcero";
            this.dsAcero1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsAcero1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Diámetro:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEspec
            // 
            this.txtEspec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSoldaEs1, "SoldaEsp.Especifica", true));
            this.txtEspec.Location = new System.Drawing.Point(370, 16);
            this.txtEspec.Name = "txtEspec";
            this.txtEspec.Size = new System.Drawing.Size(24, 20);
            this.txtEspec.TabIndex = 3;
            this.txtEspec.Text = "textBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N° Especificación:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFolio
            // 
            this.txtFolio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSoldaEs1, "SoldaEsp.FOLIO", true));
            this.txtFolio.Location = new System.Drawing.Point(82, 14);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(48, 20);
            this.txtFolio.TabIndex = 1;
            this.txtFolio.Text = "textBox1";
            this.txtFolio.TextChanged += new System.EventHandler(this.txtFolio_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOLIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sqlDAAcero
            // 
            this.sqlDAAcero.SelectCommand = this.sqlSelectCommand2;
            this.sqlDAAcero.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Acero", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Numero", "Numero"),
                        new System.Data.Common.DataColumnMapping("Nominal", "Nominal"),
                        new System.Data.Common.DataColumnMapping("Milimetros", "Milimetros"),
                        new System.Data.Common.DataColumnMapping("Clasificacion", "Clasificacion")})});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT Numero, Nominal, Milimetros, Clasificacion FROM Acero ORDER BY Numero";
            this.sqlSelectCommand2.Connection = this.sqlConn;
            // 
            // sqlDAResultado
            // 
            this.sqlDAResultado.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDAResultado.InsertCommand = this.sqlInsertCommand2;
            this.sqlDAResultado.SelectCommand = this.sqlSelectCommand3;
            this.sqlDAResultado.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SoldaRes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("Especifica", "Especifica"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Area", "Area"),
                        new System.Data.Common.DataColumnMapping("CargaLE", "CargaLE"),
                        new System.Data.Common.DataColumnMapping("CargaMax", "CargaMax"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoLE", "EsfuerzoLE"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoMAX", "EsfuerzoMAX"),
                        new System.Data.Common.DataColumnMapping("Alargamiento", "Alargamiento"),
                        new System.Data.Common.DataColumnMapping("TJunta", "TJunta"),
                        new System.Data.Common.DataColumnMapping("RJunta", "RJunta"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})});
            this.sqlDAResultado.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConn;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaLE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CargaLE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaMax", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CargaMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoLE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EsfuerzoLE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMAX", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RJunta", System.Data.SqlDbType.VarChar, 128, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RJunta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_TJunta", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TJunta", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConn;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Especifica", System.Data.SqlDbType.SmallInt, 2, "Especifica"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.SmallInt, 2, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaLE", System.Data.SqlDbType.Int, 4, "CargaLE"),
            new System.Data.SqlClient.SqlParameter("@CargaMax", System.Data.SqlDbType.Int, 4, "CargaMax"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoLE", System.Data.SqlDbType.Int, 4, "EsfuerzoLE"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMAX", System.Data.SqlDbType.Int, 4, "EsfuerzoMAX"),
            new System.Data.SqlClient.SqlParameter("@Alargamiento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@TJunta", System.Data.SqlDbType.VarChar, 10, "TJunta"),
            new System.Data.SqlClient.SqlParameter("@RJunta", System.Data.SqlDbType.VarChar, 128, "RJunta"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 50, "Observaciones")});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = resources.GetString("sqlSelectCommand3.CommandText");
            this.sqlSelectCommand3.Connection = this.sqlConn;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdFolio", System.Data.SqlDbType.VarChar, 10, "FOLIO")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConn;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Especifica", System.Data.SqlDbType.SmallInt, 2, "Especifica"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.SmallInt, 2, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaLE", System.Data.SqlDbType.Int, 4, "CargaLE"),
            new System.Data.SqlClient.SqlParameter("@CargaMax", System.Data.SqlDbType.Int, 4, "CargaMax"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoLE", System.Data.SqlDbType.Int, 4, "EsfuerzoLE"),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMAX", System.Data.SqlDbType.Int, 4, "EsfuerzoMAX"),
            new System.Data.SqlClient.SqlParameter("@Alargamiento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@TJunta", System.Data.SqlDbType.VarChar, 10, "TJunta"),
            new System.Data.SqlClient.SqlParameter("@RJunta", System.Data.SqlDbType.VarChar, 128, "RJunta"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 50, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(3)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaLE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CargaLE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaMax", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CargaMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoLE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EsfuerzoLE", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMAX", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EsfuerzoMAX", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_RJunta", System.Data.SqlDbType.VarChar, 128, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RJunta", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_TJunta", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TJunta", System.Data.DataRowVersion.Original, null)});
            // 
            // dgSoldaEns
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgSoldaEns.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSoldaEns.AutoGenerateColumns = false;
            this.dgSoldaEns.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgSoldaEns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSoldaEns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fOLIODataGridViewTextBoxColumn,
            this.especificaDataGridViewTextBoxColumn,
            this.muestraDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.cargaLEDataGridViewTextBoxColumn,
            this.cargaMaxDataGridViewTextBoxColumn,
            this.esfuerzoLEDataGridViewTextBoxColumn,
            this.esfuerzoMAXDataGridViewTextBoxColumn,
            this.alargamientoDataGridViewTextBoxColumn,
            this.tJuntaDataGridViewTextBoxColumn,
            this.rJuntaDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dgSoldaEns.DataMember = "SoldaEsp.Solda";
            this.dgSoldaEns.DataSource = this.dsSoldaEs1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSoldaEns.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgSoldaEns.Location = new System.Drawing.Point(0, 168);
            this.dgSoldaEns.Name = "dgSoldaEns";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgSoldaEns.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgSoldaEns.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgSoldaEns.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgSoldaEns.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgSoldaEns.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgSoldaEns.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgSoldaEns.Size = new System.Drawing.Size(1016, 336);
            this.dgSoldaEns.TabIndex = 6;
            // 
            // fOLIODataGridViewTextBoxColumn
            // 
            this.fOLIODataGridViewTextBoxColumn.DataPropertyName = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.HeaderText = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.Name = "fOLIODataGridViewTextBoxColumn";
            this.fOLIODataGridViewTextBoxColumn.Visible = false;
            this.fOLIODataGridViewTextBoxColumn.Width = 5;
            // 
            // especificaDataGridViewTextBoxColumn
            // 
            this.especificaDataGridViewTextBoxColumn.DataPropertyName = "Especifica";
            this.especificaDataGridViewTextBoxColumn.HeaderText = "Especifica";
            this.especificaDataGridViewTextBoxColumn.Name = "especificaDataGridViewTextBoxColumn";
            this.especificaDataGridViewTextBoxColumn.Visible = false;
            this.especificaDataGridViewTextBoxColumn.Width = 5;
            // 
            // muestraDataGridViewTextBoxColumn
            // 
            this.muestraDataGridViewTextBoxColumn.DataPropertyName = "Muestra";
            this.muestraDataGridViewTextBoxColumn.HeaderText = "Muestra";
            this.muestraDataGridViewTextBoxColumn.Name = "muestraDataGridViewTextBoxColumn";
            this.muestraDataGridViewTextBoxColumn.Width = 50;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.Width = 50;
            // 
            // cargaLEDataGridViewTextBoxColumn
            // 
            this.cargaLEDataGridViewTextBoxColumn.DataPropertyName = "CargaLE";
            this.cargaLEDataGridViewTextBoxColumn.HeaderText = "CargaLE";
            this.cargaLEDataGridViewTextBoxColumn.Name = "cargaLEDataGridViewTextBoxColumn";
            this.cargaLEDataGridViewTextBoxColumn.Width = 55;
            // 
            // cargaMaxDataGridViewTextBoxColumn
            // 
            this.cargaMaxDataGridViewTextBoxColumn.DataPropertyName = "CargaMax";
            this.cargaMaxDataGridViewTextBoxColumn.HeaderText = "CargaMax";
            this.cargaMaxDataGridViewTextBoxColumn.Name = "cargaMaxDataGridViewTextBoxColumn";
            this.cargaMaxDataGridViewTextBoxColumn.Width = 65;
            // 
            // esfuerzoLEDataGridViewTextBoxColumn
            // 
            this.esfuerzoLEDataGridViewTextBoxColumn.DataPropertyName = "EsfuerzoLE";
            this.esfuerzoLEDataGridViewTextBoxColumn.HeaderText = "EsfuerzoLE";
            this.esfuerzoLEDataGridViewTextBoxColumn.Name = "esfuerzoLEDataGridViewTextBoxColumn";
            this.esfuerzoLEDataGridViewTextBoxColumn.Width = 75;
            // 
            // esfuerzoMAXDataGridViewTextBoxColumn
            // 
            this.esfuerzoMAXDataGridViewTextBoxColumn.DataPropertyName = "EsfuerzoMAX";
            this.esfuerzoMAXDataGridViewTextBoxColumn.HeaderText = "EsfuerzoMAX";
            this.esfuerzoMAXDataGridViewTextBoxColumn.Name = "esfuerzoMAXDataGridViewTextBoxColumn";
            this.esfuerzoMAXDataGridViewTextBoxColumn.Width = 80;
            // 
            // alargamientoDataGridViewTextBoxColumn
            // 
            this.alargamientoDataGridViewTextBoxColumn.DataPropertyName = "Alargamiento";
            this.alargamientoDataGridViewTextBoxColumn.HeaderText = "Alargamiento";
            this.alargamientoDataGridViewTextBoxColumn.Name = "alargamientoDataGridViewTextBoxColumn";
            this.alargamientoDataGridViewTextBoxColumn.Width = 75;
            // 
            // tJuntaDataGridViewTextBoxColumn
            // 
            this.tJuntaDataGridViewTextBoxColumn.DataPropertyName = "TJunta";
            this.tJuntaDataGridViewTextBoxColumn.HeaderText = "Tipo de Junta";
            this.tJuntaDataGridViewTextBoxColumn.Name = "tJuntaDataGridViewTextBoxColumn";
            this.tJuntaDataGridViewTextBoxColumn.Width = 75;
            // 
            // rJuntaDataGridViewTextBoxColumn
            // 
            this.rJuntaDataGridViewTextBoxColumn.DataPropertyName = "RJunta";
            this.rJuntaDataGridViewTextBoxColumn.HeaderText = "RJunta";
            this.rJuntaDataGridViewTextBoxColumn.Name = "rJuntaDataGridViewTextBoxColumn";
            this.rJuntaDataGridViewTextBoxColumn.Width = 300;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.Width = 145;
            // 
            // Observaciones
            // 
            this.Observaciones.Format = "";
            this.Observaciones.FormatInfo = null;
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.MappingName = "Observaciones";
            this.Observaciones.Width = 145;
            // 
            // RJunta
            // 
            this.RJunta.Format = "";
            this.RJunta.FormatInfo = null;
            this.RJunta.HeaderText = "Resultados";
            this.RJunta.MappingName = "RJunta";
            this.RJunta.Width = 300;
            // 
            // TJunta
            // 
            this.TJunta.Format = "";
            this.TJunta.FormatInfo = null;
            this.TJunta.HeaderText = "Tipo de junta.";
            this.TJunta.MappingName = "TJunta";
            this.TJunta.Width = 70;
            // 
            // Alargamiento
            // 
            this.Alargamiento.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.Alargamiento.Format = "";
            this.Alargamiento.FormatInfo = null;
            this.Alargamiento.HeaderText = "Alargamiento.";
            this.Alargamiento.MappingName = "Alargamiento";
            this.Alargamiento.Width = 75;
            // 
            // EsfuerzoMAX
            // 
            this.EsfuerzoMAX.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.EsfuerzoMAX.Format = "";
            this.EsfuerzoMAX.FormatInfo = null;
            this.EsfuerzoMAX.HeaderText = "Esfuerzo Max.";
            this.EsfuerzoMAX.MappingName = "EsfuerzoMAX";
            this.EsfuerzoMAX.Width = 80;
            // 
            // EsfuerzoLE
            // 
            this.EsfuerzoLE.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.EsfuerzoLE.Format = "";
            this.EsfuerzoLE.FormatInfo = null;
            this.EsfuerzoLE.HeaderText = "Esfuerzo LE.";
            this.EsfuerzoLE.MappingName = "EsfuerzoLE";
            this.EsfuerzoLE.Width = 75;
            // 
            // CargaMax
            // 
            this.CargaMax.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.CargaMax.Format = "";
            this.CargaMax.FormatInfo = null;
            this.CargaMax.HeaderText = "Carga Max.";
            this.CargaMax.MappingName = "CargaMax";
            this.CargaMax.Width = 65;
            // 
            // CargaLE
            // 
            this.CargaLE.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.CargaLE.Format = "";
            this.CargaLE.FormatInfo = null;
            this.CargaLE.HeaderText = "Carga LE.";
            this.CargaLE.MappingName = "CargaLE";
            this.CargaLE.Width = 55;
            // 
            // Area
            // 
            this.Area.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.Area.Format = "";
            this.Area.FormatInfo = null;
            this.Area.HeaderText = "Área.";
            this.Area.MappingName = "Area";
            this.Area.Width = 50;
            // 
            // Muestra
            // 
            this.Muestra.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.Muestra.Format = "";
            this.Muestra.FormatInfo = null;
            this.Muestra.HeaderText = "Muestra.";
            this.Muestra.MappingName = "Muestra";
            this.Muestra.Width = 50;
            // 
            // Especifica
            // 
            this.Especifica.Format = "";
            this.Especifica.FormatInfo = null;
            this.Especifica.MappingName = "Especifica";
            this.Especifica.ReadOnly = true;
            this.Especifica.Width = 0;
            // 
            // FOLIO
            // 
            this.FOLIO.Format = "";
            this.FOLIO.FormatInfo = null;
            this.FOLIO.MappingName = "FOLIO";
            this.FOLIO.ReadOnly = true;
            this.FOLIO.Width = 0;
            // 
            // txtUsrMov
            // 
            this.txtUsrMov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsSoldaEs1, "SoldaEsp.IdUsuario", true));
            this.txtUsrMov.Location = new System.Drawing.Point(745, 14);
            this.txtUsrMov.Name = "txtUsrMov";
            this.txtUsrMov.ReadOnly = true;
            this.txtUsrMov.Size = new System.Drawing.Size(68, 20);
            this.txtUsrMov.TabIndex = 48;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(684, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 13);
            this.label25.TabIndex = 47;
            this.label25.Text = "Usuario:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SoldaEns
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1016, 533);
            this.Controls.Add(this.dgSoldaEns);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAEspecifica;
            this.dsGeneral = this.dsSoldaEs1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SoldaEns";
            this.NombreTabla = "SoldaEsp";
            this.Text = "Soldadura ensaye a tensión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SoldaEns_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgSoldaEns, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSoldaEs1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoldaEns)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void SoldaEns_Load(object sender, System.EventArgs e)
		{
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    IdUsuario = MyControl.Text;
            }
            buscaBtn1.Catalogo = this;
			sqlDAAcero.Fill(dsAcero1,"Acero");
		}
		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			base.btnNuevo_Click(sender, e);
			cmbNumero.SelectedIndex = -1;
		}
		protected override void btnGuardar_Click(object sender, System.EventArgs e)
		{
			try 
			{
                txtUsrMov.Text = IdUsuario;
                // Intente actualizar el origen de datos.
                base.BindingContext[dsSoldaEs1,"SoldaEsp"].Position = this.BindingContext[dsSoldaEs1,"SoldaEsp"].Position;
				this.UpdateDataSet1();
				base.dsGeneral_PositionChanged();
			}
			catch (System.Exception eUpdate) 
			{
				statusBar1.Panels[2].Text = eUpdate.Message;	
				statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
				statusBar1.Panels[2].ToolTipText = eUpdate.Message;
			}
			dsSoldaEs1.Tables["SoldaRes"].Clear();
			sqlDAResultado.SelectCommand.Parameters["@IdFolio"].Value = txtFolio.Text;
			sqlDAResultado.Fill(dsSoldaEs1,"SoldaRes");
		}

		public override void LoadDataSet()
		{

//			sqlDAMuestreador.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
			base.LoadDataSet();
//			dgSoldaEns.SetDataBinding(dsSoldaEs1, "SoldaEsp.Solda");
//			string apl = dgSoldaEns.TableStyles.ToString();
			dsSoldaEs1.Tables["SoldaRes"].Clear();
			sqlDAResultado.SelectCommand.Parameters["@IdFolio"].Value = txtFolio.Text;
			sqlDAResultado.Fill(dsSoldaEs1,"SoldaRes");
		}

		private void UpdateDataSet1()
		{
			// Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
			// original			DataSet objDataSetChanges = new DataSet();
			LancNeo.dsSoldaEs objDataSetChanges = new LancNeo.dsSoldaEs();
			// Detener las ediciones actuales.
			// original			this.BindingContext[dsgeneral].EndCurrentEdit();
			this.BindingContext[dsSoldaEs1,"SoldaEsp"].EndCurrentEdit();
			this.BindingContext[dsSoldaEs1,"SoldaRes"].EndCurrentEdit();

			// Obtener los cambios realizados en el conjunto de datos principal.
			// original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));

			objDataSetChanges = ((LancNeo.dsSoldaEs)(dsSoldaEs1.GetChanges()));

			// Comprobar si se han realizado cambios.
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
					// llamando al método de actualización y pasando el conjunto de datos y los parámetros.
					this.UpdateDataSource1(objDataSetChanges);
					dsSoldaEs1.Merge(objDataSetChanges);
					dsSoldaEs1.AcceptChanges();
				}
				catch (System.Exception eUpdate) 
				{
					// Agregar aquí el código de control de errores.
					throw eUpdate;
				}
				// Agregar código para comprobar en el conjunto de datos devuelto los errores que se puedan haber
				// introducido en el error del objeto de fila.
			}

		}
		private void UpdateDataSource1(LancNeo.dsSoldaEs ChangedRows)
		{
			try 
			{
				// Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
				if ((ChangedRows != null)) 
				{
					// Abra la conexión.
					this.sqlConn.Open();
					// Intente actualizar el origen de datos.
					sqlDAEspecifica.Update(ChangedRows);
					sqlDAResultado.Update(ChangedRows);
				}
			}
			catch (System.Exception updateException) 
			{
				// Agregar aquí el código de control de errores.
				throw updateException;
			}
			finally 
			{
				// Cerrar la conexión independientemente de si se inició una excepción o no.
				this.sqlConn.Close();
			}
		}

		private void label18_Click(object sender, System.EventArgs e)
		{
		
		}

		private void txtFolio_TextChanged(object sender, System.EventArgs e)
		{
			dsSoldaEs1.Tables["SoldaRes"].Clear();
			sqlDAResultado.SelectCommand.Parameters["@IdFolio"].Value = txtFolio.Text;
			sqlDAResultado.Fill(dsSoldaEs1,"SoldaRes");
		}

	}
}
