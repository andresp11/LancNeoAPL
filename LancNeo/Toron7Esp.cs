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
	/// Descripción breve de Toron7Esp.
	/// </summary>
	public class Toron7Esp : CatalogoGenerico
	{
        private string IdUsuario;

        private System.Data.SqlClient.SqlDataAdapter sqlDATorom7Esp;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Windows.Forms.Panel panel2;
		private Soluciones2000.Tools.WinLib.BuscaBtn buscaBtn1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox txtNominal;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtSepara;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtAlarga;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtEsMax;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtEsLE;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtmasa;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEspec;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Label label1;
		private LancNeo.dsAcero dsAcero1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAAcero;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private LancNeo.dsToron7Esp dsToron7Esp2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private LancNeo.dsToron7Esp dsToron7Esp1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		private System.Data.SqlClient.SqlDataAdapter sqlDATorom7Res;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label12;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private DataGridViewTextBoxColumn especificaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn muestraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn metodoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diametroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn masaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pasoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diamProDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diamAlaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diferenciaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargaDefDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargaMaxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargaFluDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn esfuerzoMaxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alargamientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rompieronDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coladaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remesaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private DataGridView dgToron7Ens;
        private DataGridViewTextBoxColumn fOLIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn especificaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn muestraDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn metodoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn diametroDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn masaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pasoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn diamProDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn diamAlaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn diferenciaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cargaDefDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cargaMaxDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cargaFluDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn esfuerzoMaxDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn alargamientoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn rompieronDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn coladaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn remesaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn1;
        private TextBox txtUsrMov;
        private Label label28;

        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public Toron7Esp()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toron7Esp));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sqlDATorom7Esp = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buscaBtn1 = new Soluciones2000.Tools.WinLib.BuscaBtn();
            this.dsToron7Esp1 = new LancNeo.dsToron7Esp();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtNominal = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSepara = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAlarga = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEsMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEsLE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmasa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEspec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dsAcero1 = new LancNeo.dsAcero();
            this.sqlDAAcero = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDATorom7Res = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.especificaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muestraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diametroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diamProDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diamAlaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diferenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaDefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaFluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esfuerzoMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alargamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rompieronDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coladaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgToron7Ens = new System.Windows.Forms.DataGridView();
            this.fOLIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especificaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muestraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diametroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diamProDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diamAlaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diferenciaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaDefDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaMaxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaFluDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esfuerzoMaxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alargamientoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rompieronDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coladaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remesaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUsrMov = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panelToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsToron7Esp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgToron7Ens)).BeginInit();
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
            // sqlDATorom7Esp
            // 
            this.sqlDATorom7Esp.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDATorom7Esp.InsertCommand = this.sqlInsertCommand1;
            this.sqlDATorom7Esp.SelectCommand = this.sqlSelectCommand1;
            this.sqlDATorom7Esp.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Torom7Esp", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("Especifica", "Especifica"),
                        new System.Data.Common.DataColumnMapping("Metodo", "Metodo"),
                        new System.Data.Common.DataColumnMapping("Diametro1", "Diametro1"),
                        new System.Data.Common.DataColumnMapping("Diametro2", "Diametro2"),
                        new System.Data.Common.DataColumnMapping("Paso1", "Paso1"),
                        new System.Data.Common.DataColumnMapping("Paso2", "Paso2"),
                        new System.Data.Common.DataColumnMapping("Diferencia", "Diferencia"),
                        new System.Data.Common.DataColumnMapping("Carga1", "Carga1"),
                        new System.Data.Common.DataColumnMapping("CargaMax", "CargaMax"),
                        new System.Data.Common.DataColumnMapping("Alargamiento", "Alargamiento"),
                        new System.Data.Common.DataColumnMapping("Marca", "Marca"),
                        new System.Data.Common.DataColumnMapping("Procedencia", "Procedencia"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("Masa", "Masa"),
                        new System.Data.Common.DataColumnMapping("IdUsuario", "IdUsuario")})});
            this.sqlDATorom7Esp.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Metodo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Metodo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Metodo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Metodo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Diametro1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Diametro1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Diametro1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diametro1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Diametro2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Diametro2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Diametro2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diametro2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Paso1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Paso1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Paso1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Paso1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Paso2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Paso2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Paso2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Paso2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Diferencia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Diferencia", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Diferencia", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "Diferencia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Carga1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Carga1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Carga1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(8)), ((byte)(3)), "Carga1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CargaMax", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CargaMax", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CargaMax", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(8)), ((byte)(3)), "CargaMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Alargamiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Alargamiento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Marca", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Marca", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Marca", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Marca", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Procedencia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Procedencia", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Procedencia", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Procedencia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tipo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Masa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Masa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Original, null),
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
            new System.Data.SqlClient.SqlParameter("@Metodo", System.Data.SqlDbType.NVarChar, 0, "Metodo"),
            new System.Data.SqlClient.SqlParameter("@Diametro1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diametro1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Diametro2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diametro2", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Paso1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Paso1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Paso2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Paso2", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Diferencia", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "Diferencia", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Carga1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(8)), ((byte)(3)), "Carga1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaMax", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(8)), ((byte)(3)), "CargaMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Marca", System.Data.SqlDbType.VarChar, 0, "Marca"),
            new System.Data.SqlClient.SqlParameter("@Procedencia", System.Data.SqlDbType.VarChar, 0, "Procedencia"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 0, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Current, null),
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
            new System.Data.SqlClient.SqlParameter("@Metodo", System.Data.SqlDbType.NVarChar, 0, "Metodo"),
            new System.Data.SqlClient.SqlParameter("@Diametro1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diametro1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Diametro2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diametro2", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Paso1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Paso1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Paso2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Paso2", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Diferencia", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "Diferencia", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Carga1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(8)), ((byte)(3)), "Carga1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaMax", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(8)), ((byte)(3)), "CargaMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Marca", System.Data.SqlDbType.VarChar, 0, "Marca"),
            new System.Data.SqlClient.SqlParameter("@Procedencia", System.Data.SqlDbType.VarChar, 0, "Procedencia"),
            new System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 0, "Tipo"),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 0, "IdUsuario"),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Metodo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Metodo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Metodo", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Metodo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Diametro1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Diametro1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Diametro1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diametro1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Diametro2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Diametro2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Diametro2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diametro2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Paso1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Paso1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Paso1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Paso1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Paso2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Paso2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Paso2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Paso2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Diferencia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Diferencia", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Diferencia", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(3)), "Diferencia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Carga1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Carga1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Carga1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(8)), ((byte)(3)), "Carga1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CargaMax", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CargaMax", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CargaMax", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(8)), ((byte)(3)), "CargaMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Alargamiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Alargamiento", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Marca", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Marca", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Marca", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Marca", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Procedencia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Procedencia", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Procedencia", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Procedencia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Tipo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tipo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Masa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Masa", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IdUsuario", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IdUsuario", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdUsuario", System.Data.DataRowVersion.Original, null)});
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buscaBtn1);
            this.panel2.Controls.Add(this.txtUsrMov);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.txtNominal);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtSepara);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtAlarga);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtEsMax);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtEsLE);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtmasa);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtEspec);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtFolio);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-4, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 96);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buscaBtn1
            // 
            this.buscaBtn1.AnchoColTit = true;
            this.buscaBtn1.AnchoDlgBusq = 675;
            this.buscaBtn1.BackColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Datos = this.dsToron7Esp1.Torom7Esp;
            this.buscaBtn1.ForeColor = System.Drawing.Color.Transparent;
            this.buscaBtn1.Icon = ((System.Drawing.Icon)(resources.GetObject("buscaBtn1.Icon")));
            this.buscaBtn1.Location = new System.Drawing.Point(98, 0);
            this.buscaBtn1.Name = "buscaBtn1";
            this.buscaBtn1.Size = new System.Drawing.Size(64, 64);
            this.buscaBtn1.TabIndex = 41;
            // 
            // dsToron7Esp1
            // 
            this.dsToron7Esp1.DataSetName = "dsToron7Esp";
            this.dsToron7Esp1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsToron7Esp1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsToron7Esp1, "Torom7Esp.Masa", true));
            this.textBox7.Location = new System.Drawing.Point(78, 68);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(80, 20);
            this.textBox7.TabIndex = 48;
            this.textBox7.Text = "textBox7";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Masa:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsToron7Esp1, "Torom7Esp.Metodo", true));
            this.textBox6.Location = new System.Drawing.Point(338, 24);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(80, 20);
            this.textBox6.TabIndex = 4;
            this.textBox6.Text = "textBox6";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsToron7Esp1, "Torom7Esp.Tipo", true));
            this.textBox5.Location = new System.Drawing.Point(728, 69);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(48, 20);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "textBox4";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsToron7Esp1, "Torom7Esp.Alargamiento", true));
            this.textBox4.Location = new System.Drawing.Point(434, 69);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(48, 20);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "textBox4";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsToron7Esp1, "Torom7Esp.Marca", true));
            this.textBox2.Location = new System.Drawing.Point(528, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "textBox2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(490, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Marca:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(700, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Tipo:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsToron7Esp1, "Torom7Esp.Procedencia", true));
            this.textBox3.Location = new System.Drawing.Point(654, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(44, 20);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "textBox8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(586, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Procedenciax:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsToron7Esp1, "Torom7Esp.Carga1", true));
            this.textBox1.Location = new System.Drawing.Point(208, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "textBox1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(170, 72);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 13);
            this.label24.TabIndex = 38;
            this.label24.Text = "Carga1";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNominal
            // 
            this.txtNominal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsToron7Esp1, "Torom7Esp.Diametro2", true));
            this.txtNominal.Location = new System.Drawing.Point(598, 24);
            this.txtNominal.Name = "txtNominal";
            this.txtNominal.Size = new System.Drawing.Size(64, 20);
            this.txtNominal.TabIndex = 6;
            this.txtNominal.Text = "textBox3";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(528, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 13);
            this.label23.TabIndex = 36;
            this.label23.Text = "Diametro2:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Gold;
            this.label22.Location = new System.Drawing.Point(194, -4);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(144, 20);
            this.label22.TabIndex = 35;
            this.label22.Text = "Especificación";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(368, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Alargamiento:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSepara
            // 
            this.txtSepara.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsToron7Esp1, "Torom7Esp.CargaMax", true));
            this.txtSepara.Location = new System.Drawing.Point(322, 69);
            this.txtSepara.Name = "txtSepara";
            this.txtSepara.Size = new System.Drawing.Size(44, 20);
            this.txtSepara.TabIndex = 11;
            this.txtSepara.Text = "textBox8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(266, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Carga Max:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAlarga
            // 
            this.txtAlarga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsToron7Esp1, "Torom7Esp.Diferencia", true));
            this.txtAlarga.Location = new System.Drawing.Point(904, 24);
            this.txtAlarga.Name = "txtAlarga";
            this.txtAlarga.Size = new System.Drawing.Size(38, 20);
            this.txtAlarga.TabIndex = 9;
            this.txtAlarga.Text = "textBox7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(852, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Diferencia:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEsMax
            // 
            this.txtEsMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsToron7Esp1, "Torom7Esp.Paso2", true));
            this.txtEsMax.Location = new System.Drawing.Point(792, 24);
            this.txtEsMax.Name = "txtEsMax";
            this.txtEsMax.Size = new System.Drawing.Size(56, 20);
            this.txtEsMax.TabIndex = 8;
            this.txtEsMax.Text = "textBox6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(756, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Paso2:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEsLE
            // 
            this.txtEsLE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsToron7Esp1, "Torom7Esp.Paso1", true));
            this.txtEsLE.Location = new System.Drawing.Point(698, 24);
            this.txtEsLE.Name = "txtEsLE";
            this.txtEsLE.Size = new System.Drawing.Size(56, 20);
            this.txtEsLE.TabIndex = 7;
            this.txtEsLE.Text = "textBox5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(664, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Paso1:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtmasa
            // 
            this.txtmasa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsToron7Esp1, "Torom7Esp.Diametro1", true));
            this.txtmasa.Location = new System.Drawing.Point(476, 24);
            this.txtmasa.Name = "txtmasa";
            this.txtmasa.Size = new System.Drawing.Size(48, 20);
            this.txtmasa.TabIndex = 5;
            this.txtmasa.Text = "textBox4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Diametro1:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Metodo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEspec
            // 
            this.txtEspec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsToron7Esp1, "Torom7Esp.Especifica", true));
            this.txtEspec.Location = new System.Drawing.Point(264, 24);
            this.txtEspec.Name = "txtEspec";
            this.txtEspec.Size = new System.Drawing.Size(24, 20);
            this.txtEspec.TabIndex = 2;
            this.txtEspec.Text = "textBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N° Especificación:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFolio
            // 
            this.txtFolio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsToron7Esp1, "Torom7Esp.FOLIO", true));
            this.txtFolio.Location = new System.Drawing.Point(48, 24);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(48, 20);
            this.txtFolio.TabIndex = 1;
            this.txtFolio.Text = "textBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOLIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dsAcero1
            // 
            this.dsAcero1.DataSetName = "dsAcero";
            this.dsAcero1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsAcero1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sqlDATorom7Res
            // 
            this.sqlDATorom7Res.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDATorom7Res.InsertCommand = this.sqlInsertCommand2;
            this.sqlDATorom7Res.SelectCommand = this.sqlSelectCommand3;
            this.sqlDATorom7Res.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Toron7Res", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("FOLIO", "FOLIO"),
                        new System.Data.Common.DataColumnMapping("Especifica", "Especifica"),
                        new System.Data.Common.DataColumnMapping("Muestra", "Muestra"),
                        new System.Data.Common.DataColumnMapping("Metodo", "Metodo"),
                        new System.Data.Common.DataColumnMapping("Diametro", "Diametro"),
                        new System.Data.Common.DataColumnMapping("Masa", "Masa"),
                        new System.Data.Common.DataColumnMapping("Area", "Area"),
                        new System.Data.Common.DataColumnMapping("Paso", "Paso"),
                        new System.Data.Common.DataColumnMapping("DiamPro", "DiamPro"),
                        new System.Data.Common.DataColumnMapping("DiamAla", "DiamAla"),
                        new System.Data.Common.DataColumnMapping("Diferencia", "Diferencia"),
                        new System.Data.Common.DataColumnMapping("CargaDef", "CargaDef"),
                        new System.Data.Common.DataColumnMapping("CargaMax", "CargaMax"),
                        new System.Data.Common.DataColumnMapping("CargaFlu", "CargaFlu"),
                        new System.Data.Common.DataColumnMapping("EsfuerzoMax", "EsfuerzoMax"),
                        new System.Data.Common.DataColumnMapping("Alargamiento", "Alargamiento"),
                        new System.Data.Common.DataColumnMapping("Rompieron", "Rompieron"),
                        new System.Data.Common.DataColumnMapping("Colada", "Colada"),
                        new System.Data.Common.DataColumnMapping("Remesa", "Remesa"),
                        new System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})});
            this.sqlDATorom7Res.UpdateCommand = this.sqlUpdateCommand2;
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
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaDef", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaDef", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaFlu", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaFlu", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Colada", System.Data.SqlDbType.NVarChar, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Colada", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DiamAla", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "DiamAla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DiamPro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "DiamPro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Diametro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diametro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Diferencia", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diferencia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "EsfuerzoMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Metodo", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Metodo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Paso", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(2)), "Paso", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Remesa", System.Data.SqlDbType.NVarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Remesa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Rompieron", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Rompieron", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConn;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Especifica", System.Data.SqlDbType.SmallInt, 2, "Especifica"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.SmallInt, 2, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@Metodo", System.Data.SqlDbType.NVarChar, 15, "Metodo"),
            new System.Data.SqlClient.SqlParameter("@Diametro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diametro", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Paso", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(2)), "Paso", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@DiamPro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "DiamPro", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@DiamAla", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "DiamAla", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Diferencia", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diferencia", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaDef", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaDef", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaFlu", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaFlu", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "EsfuerzoMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Rompieron", System.Data.SqlDbType.Int, 4, "Rompieron"),
            new System.Data.SqlClient.SqlParameter("@Colada", System.Data.SqlDbType.NVarChar, 8, "Colada"),
            new System.Data.SqlClient.SqlParameter("@Remesa", System.Data.SqlDbType.NVarChar, 12, "Remesa"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 50, "Observaciones")});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = resources.GetString("sqlSelectCommand3.CommandText");
            this.sqlSelectCommand3.Connection = this.sqlConn;
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConn;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FOLIO", System.Data.SqlDbType.VarChar, 10, "FOLIO"),
            new System.Data.SqlClient.SqlParameter("@Especifica", System.Data.SqlDbType.SmallInt, 2, "Especifica"),
            new System.Data.SqlClient.SqlParameter("@Muestra", System.Data.SqlDbType.SmallInt, 2, "Muestra"),
            new System.Data.SqlClient.SqlParameter("@Metodo", System.Data.SqlDbType.NVarChar, 15, "Metodo"),
            new System.Data.SqlClient.SqlParameter("@Diametro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diametro", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Masa", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Area", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Paso", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(2)), "Paso", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@DiamPro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "DiamPro", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@DiamAla", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "DiamAla", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Diferencia", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diferencia", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaDef", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaDef", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CargaFlu", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaFlu", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@EsfuerzoMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "EsfuerzoMax", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Alargamiento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Rompieron", System.Data.SqlDbType.Int, 4, "Rompieron"),
            new System.Data.SqlClient.SqlParameter("@Colada", System.Data.SqlDbType.NVarChar, 8, "Colada"),
            new System.Data.SqlClient.SqlParameter("@Remesa", System.Data.SqlDbType.NVarChar, 12, "Remesa"),
            new System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.NVarChar, 50, "Observaciones"),
            new System.Data.SqlClient.SqlParameter("@Original_Especifica", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Especifica", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FOLIO", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FOLIO", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Muestra", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Muestra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Alargamiento", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(4)), ((byte)(1)), "Alargamiento", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Area", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Area", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaDef", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaDef", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaFlu", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaFlu", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CargaMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "CargaMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Colada", System.Data.SqlDbType.NVarChar, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Colada", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DiamAla", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "DiamAla", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DiamPro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "DiamPro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Diametro", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diametro", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Diferencia", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(6)), ((byte)(2)), "Diferencia", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EsfuerzoMax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "EsfuerzoMax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Masa", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(3)), "Masa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Metodo", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Metodo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Observaciones", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Paso", System.Data.SqlDbType.Decimal, 5, System.Data.ParameterDirection.Input, false, ((byte)(7)), ((byte)(2)), "Paso", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Remesa", System.Data.SqlDbType.NVarChar, 12, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Remesa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Rompieron", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Rompieron", System.Data.DataRowVersion.Original, null)});
            // 
            // especificaDataGridViewTextBoxColumn
            // 
            this.especificaDataGridViewTextBoxColumn.DataPropertyName = "Especifica";
            this.especificaDataGridViewTextBoxColumn.HeaderText = "Especifica";
            this.especificaDataGridViewTextBoxColumn.Name = "especificaDataGridViewTextBoxColumn";
            // 
            // muestraDataGridViewTextBoxColumn
            // 
            this.muestraDataGridViewTextBoxColumn.DataPropertyName = "Muestra";
            this.muestraDataGridViewTextBoxColumn.HeaderText = "Muestra";
            this.muestraDataGridViewTextBoxColumn.Name = "muestraDataGridViewTextBoxColumn";
            // 
            // metodoDataGridViewTextBoxColumn
            // 
            this.metodoDataGridViewTextBoxColumn.DataPropertyName = "Metodo";
            this.metodoDataGridViewTextBoxColumn.HeaderText = "Metodo";
            this.metodoDataGridViewTextBoxColumn.Name = "metodoDataGridViewTextBoxColumn";
            // 
            // diametroDataGridViewTextBoxColumn
            // 
            this.diametroDataGridViewTextBoxColumn.DataPropertyName = "Diametro";
            this.diametroDataGridViewTextBoxColumn.HeaderText = "Diametro";
            this.diametroDataGridViewTextBoxColumn.Name = "diametroDataGridViewTextBoxColumn";
            // 
            // masaDataGridViewTextBoxColumn
            // 
            this.masaDataGridViewTextBoxColumn.DataPropertyName = "Masa";
            this.masaDataGridViewTextBoxColumn.HeaderText = "Masa";
            this.masaDataGridViewTextBoxColumn.Name = "masaDataGridViewTextBoxColumn";
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            // 
            // pasoDataGridViewTextBoxColumn
            // 
            this.pasoDataGridViewTextBoxColumn.DataPropertyName = "Paso";
            this.pasoDataGridViewTextBoxColumn.HeaderText = "Paso";
            this.pasoDataGridViewTextBoxColumn.Name = "pasoDataGridViewTextBoxColumn";
            // 
            // diamProDataGridViewTextBoxColumn
            // 
            this.diamProDataGridViewTextBoxColumn.DataPropertyName = "DiamPro";
            this.diamProDataGridViewTextBoxColumn.HeaderText = "DiamPro";
            this.diamProDataGridViewTextBoxColumn.Name = "diamProDataGridViewTextBoxColumn";
            // 
            // diamAlaDataGridViewTextBoxColumn
            // 
            this.diamAlaDataGridViewTextBoxColumn.DataPropertyName = "DiamAla";
            this.diamAlaDataGridViewTextBoxColumn.HeaderText = "DiamAla";
            this.diamAlaDataGridViewTextBoxColumn.Name = "diamAlaDataGridViewTextBoxColumn";
            // 
            // diferenciaDataGridViewTextBoxColumn
            // 
            this.diferenciaDataGridViewTextBoxColumn.DataPropertyName = "Diferencia";
            this.diferenciaDataGridViewTextBoxColumn.HeaderText = "Diferencia";
            this.diferenciaDataGridViewTextBoxColumn.Name = "diferenciaDataGridViewTextBoxColumn";
            // 
            // cargaDefDataGridViewTextBoxColumn
            // 
            this.cargaDefDataGridViewTextBoxColumn.DataPropertyName = "CargaDef";
            this.cargaDefDataGridViewTextBoxColumn.HeaderText = "CargaDef";
            this.cargaDefDataGridViewTextBoxColumn.Name = "cargaDefDataGridViewTextBoxColumn";
            // 
            // cargaMaxDataGridViewTextBoxColumn
            // 
            this.cargaMaxDataGridViewTextBoxColumn.DataPropertyName = "CargaMax";
            this.cargaMaxDataGridViewTextBoxColumn.HeaderText = "CargaMax";
            this.cargaMaxDataGridViewTextBoxColumn.Name = "cargaMaxDataGridViewTextBoxColumn";
            // 
            // cargaFluDataGridViewTextBoxColumn
            // 
            this.cargaFluDataGridViewTextBoxColumn.DataPropertyName = "CargaFlu";
            this.cargaFluDataGridViewTextBoxColumn.HeaderText = "CargaFlu";
            this.cargaFluDataGridViewTextBoxColumn.Name = "cargaFluDataGridViewTextBoxColumn";
            // 
            // esfuerzoMaxDataGridViewTextBoxColumn
            // 
            this.esfuerzoMaxDataGridViewTextBoxColumn.DataPropertyName = "EsfuerzoMax";
            this.esfuerzoMaxDataGridViewTextBoxColumn.HeaderText = "EsfuerzoMax";
            this.esfuerzoMaxDataGridViewTextBoxColumn.Name = "esfuerzoMaxDataGridViewTextBoxColumn";
            // 
            // alargamientoDataGridViewTextBoxColumn
            // 
            this.alargamientoDataGridViewTextBoxColumn.DataPropertyName = "Alargamiento";
            this.alargamientoDataGridViewTextBoxColumn.HeaderText = "Alargamiento";
            this.alargamientoDataGridViewTextBoxColumn.Name = "alargamientoDataGridViewTextBoxColumn";
            // 
            // rompieronDataGridViewTextBoxColumn
            // 
            this.rompieronDataGridViewTextBoxColumn.DataPropertyName = "Rompieron";
            this.rompieronDataGridViewTextBoxColumn.HeaderText = "Rompieron";
            this.rompieronDataGridViewTextBoxColumn.Name = "rompieronDataGridViewTextBoxColumn";
            // 
            // coladaDataGridViewTextBoxColumn
            // 
            this.coladaDataGridViewTextBoxColumn.DataPropertyName = "Colada";
            this.coladaDataGridViewTextBoxColumn.HeaderText = "Colada";
            this.coladaDataGridViewTextBoxColumn.Name = "coladaDataGridViewTextBoxColumn";
            // 
            // remesaDataGridViewTextBoxColumn
            // 
            this.remesaDataGridViewTextBoxColumn.DataPropertyName = "Remesa";
            this.remesaDataGridViewTextBoxColumn.HeaderText = "Remesa";
            this.remesaDataGridViewTextBoxColumn.Name = "remesaDataGridViewTextBoxColumn";
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            // 
            // dgToron7Ens
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgToron7Ens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgToron7Ens.AutoGenerateColumns = false;
            this.dgToron7Ens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgToron7Ens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fOLIODataGridViewTextBoxColumn,
            this.especificaDataGridViewTextBoxColumn1,
            this.muestraDataGridViewTextBoxColumn1,
            this.metodoDataGridViewTextBoxColumn1,
            this.diametroDataGridViewTextBoxColumn1,
            this.masaDataGridViewTextBoxColumn1,
            this.areaDataGridViewTextBoxColumn1,
            this.pasoDataGridViewTextBoxColumn1,
            this.diamProDataGridViewTextBoxColumn1,
            this.diamAlaDataGridViewTextBoxColumn1,
            this.diferenciaDataGridViewTextBoxColumn1,
            this.cargaDefDataGridViewTextBoxColumn1,
            this.cargaMaxDataGridViewTextBoxColumn1,
            this.cargaFluDataGridViewTextBoxColumn1,
            this.esfuerzoMaxDataGridViewTextBoxColumn1,
            this.alargamientoDataGridViewTextBoxColumn1,
            this.rompieronDataGridViewTextBoxColumn1,
            this.coladaDataGridViewTextBoxColumn1,
            this.remesaDataGridViewTextBoxColumn1,
            this.observacionesDataGridViewTextBoxColumn1});
            this.dgToron7Ens.DataMember = "Torom7Esp.Toron7";
            this.dgToron7Ens.DataSource = this.dsToron7Esp1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgToron7Ens.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgToron7Ens.Location = new System.Drawing.Point(0, 168);
            this.dgToron7Ens.Name = "dgToron7Ens";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgToron7Ens.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgToron7Ens.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgToron7Ens.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgToron7Ens.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgToron7Ens.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgToron7Ens.Size = new System.Drawing.Size(1016, 336);
            this.dgToron7Ens.TabIndex = 7;
            // 
            // fOLIODataGridViewTextBoxColumn
            // 
            this.fOLIODataGridViewTextBoxColumn.DataPropertyName = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.HeaderText = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.Name = "fOLIODataGridViewTextBoxColumn";
            this.fOLIODataGridViewTextBoxColumn.Visible = false;
            // 
            // especificaDataGridViewTextBoxColumn1
            // 
            this.especificaDataGridViewTextBoxColumn1.DataPropertyName = "Especifica";
            this.especificaDataGridViewTextBoxColumn1.HeaderText = "Especifica";
            this.especificaDataGridViewTextBoxColumn1.Name = "especificaDataGridViewTextBoxColumn1";
            this.especificaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // muestraDataGridViewTextBoxColumn1
            // 
            this.muestraDataGridViewTextBoxColumn1.DataPropertyName = "Muestra";
            this.muestraDataGridViewTextBoxColumn1.HeaderText = "Muestra";
            this.muestraDataGridViewTextBoxColumn1.Name = "muestraDataGridViewTextBoxColumn1";
            // 
            // metodoDataGridViewTextBoxColumn1
            // 
            this.metodoDataGridViewTextBoxColumn1.DataPropertyName = "Metodo";
            this.metodoDataGridViewTextBoxColumn1.HeaderText = "Metodo";
            this.metodoDataGridViewTextBoxColumn1.Name = "metodoDataGridViewTextBoxColumn1";
            // 
            // diametroDataGridViewTextBoxColumn1
            // 
            this.diametroDataGridViewTextBoxColumn1.DataPropertyName = "Diametro";
            this.diametroDataGridViewTextBoxColumn1.HeaderText = "Diametro";
            this.diametroDataGridViewTextBoxColumn1.Name = "diametroDataGridViewTextBoxColumn1";
            // 
            // masaDataGridViewTextBoxColumn1
            // 
            this.masaDataGridViewTextBoxColumn1.DataPropertyName = "Masa";
            this.masaDataGridViewTextBoxColumn1.HeaderText = "Masa";
            this.masaDataGridViewTextBoxColumn1.Name = "masaDataGridViewTextBoxColumn1";
            // 
            // areaDataGridViewTextBoxColumn1
            // 
            this.areaDataGridViewTextBoxColumn1.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn1.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn1.Name = "areaDataGridViewTextBoxColumn1";
            // 
            // pasoDataGridViewTextBoxColumn1
            // 
            this.pasoDataGridViewTextBoxColumn1.DataPropertyName = "Paso";
            this.pasoDataGridViewTextBoxColumn1.HeaderText = "Paso";
            this.pasoDataGridViewTextBoxColumn1.Name = "pasoDataGridViewTextBoxColumn1";
            // 
            // diamProDataGridViewTextBoxColumn1
            // 
            this.diamProDataGridViewTextBoxColumn1.DataPropertyName = "DiamPro";
            this.diamProDataGridViewTextBoxColumn1.HeaderText = "DiamPro";
            this.diamProDataGridViewTextBoxColumn1.Name = "diamProDataGridViewTextBoxColumn1";
            // 
            // diamAlaDataGridViewTextBoxColumn1
            // 
            this.diamAlaDataGridViewTextBoxColumn1.DataPropertyName = "DiamAla";
            this.diamAlaDataGridViewTextBoxColumn1.HeaderText = "DiamAla";
            this.diamAlaDataGridViewTextBoxColumn1.Name = "diamAlaDataGridViewTextBoxColumn1";
            // 
            // diferenciaDataGridViewTextBoxColumn1
            // 
            this.diferenciaDataGridViewTextBoxColumn1.DataPropertyName = "Diferencia";
            this.diferenciaDataGridViewTextBoxColumn1.HeaderText = "Diferencia";
            this.diferenciaDataGridViewTextBoxColumn1.Name = "diferenciaDataGridViewTextBoxColumn1";
            // 
            // cargaDefDataGridViewTextBoxColumn1
            // 
            this.cargaDefDataGridViewTextBoxColumn1.DataPropertyName = "CargaDef";
            this.cargaDefDataGridViewTextBoxColumn1.HeaderText = "CargaDef";
            this.cargaDefDataGridViewTextBoxColumn1.Name = "cargaDefDataGridViewTextBoxColumn1";
            // 
            // cargaMaxDataGridViewTextBoxColumn1
            // 
            this.cargaMaxDataGridViewTextBoxColumn1.DataPropertyName = "CargaMax";
            this.cargaMaxDataGridViewTextBoxColumn1.HeaderText = "CargaMax";
            this.cargaMaxDataGridViewTextBoxColumn1.Name = "cargaMaxDataGridViewTextBoxColumn1";
            // 
            // cargaFluDataGridViewTextBoxColumn1
            // 
            this.cargaFluDataGridViewTextBoxColumn1.DataPropertyName = "CargaFlu";
            this.cargaFluDataGridViewTextBoxColumn1.HeaderText = "CargaFlu";
            this.cargaFluDataGridViewTextBoxColumn1.Name = "cargaFluDataGridViewTextBoxColumn1";
            // 
            // esfuerzoMaxDataGridViewTextBoxColumn1
            // 
            this.esfuerzoMaxDataGridViewTextBoxColumn1.DataPropertyName = "EsfuerzoMax";
            this.esfuerzoMaxDataGridViewTextBoxColumn1.HeaderText = "EsfuerzoMax";
            this.esfuerzoMaxDataGridViewTextBoxColumn1.Name = "esfuerzoMaxDataGridViewTextBoxColumn1";
            // 
            // alargamientoDataGridViewTextBoxColumn1
            // 
            this.alargamientoDataGridViewTextBoxColumn1.DataPropertyName = "Alargamiento";
            this.alargamientoDataGridViewTextBoxColumn1.HeaderText = "Alargamiento";
            this.alargamientoDataGridViewTextBoxColumn1.Name = "alargamientoDataGridViewTextBoxColumn1";
            // 
            // rompieronDataGridViewTextBoxColumn1
            // 
            this.rompieronDataGridViewTextBoxColumn1.DataPropertyName = "Rompieron";
            this.rompieronDataGridViewTextBoxColumn1.HeaderText = "Rompieron";
            this.rompieronDataGridViewTextBoxColumn1.Name = "rompieronDataGridViewTextBoxColumn1";
            // 
            // coladaDataGridViewTextBoxColumn1
            // 
            this.coladaDataGridViewTextBoxColumn1.DataPropertyName = "Colada";
            this.coladaDataGridViewTextBoxColumn1.HeaderText = "Colada";
            this.coladaDataGridViewTextBoxColumn1.Name = "coladaDataGridViewTextBoxColumn1";
            // 
            // remesaDataGridViewTextBoxColumn1
            // 
            this.remesaDataGridViewTextBoxColumn1.DataPropertyName = "Remesa";
            this.remesaDataGridViewTextBoxColumn1.HeaderText = "Remesa";
            this.remesaDataGridViewTextBoxColumn1.Name = "remesaDataGridViewTextBoxColumn1";
            // 
            // observacionesDataGridViewTextBoxColumn1
            // 
            this.observacionesDataGridViewTextBoxColumn1.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn1.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn1.Name = "observacionesDataGridViewTextBoxColumn1";
            // 
            // txtUsrMov
            // 
            this.txtUsrMov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsToron7Esp1, "Torom7Esp.IdUsuario", true));
            this.txtUsrMov.Location = new System.Drawing.Point(874, 67);
            this.txtUsrMov.Name = "txtUsrMov";
            this.txtUsrMov.ReadOnly = true;
            this.txtUsrMov.Size = new System.Drawing.Size(68, 20);
            this.txtUsrMov.TabIndex = 54;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(813, 71);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(54, 13);
            this.label28.TabIndex = 53;
            this.label28.Text = "Usuario:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Toron7Esp
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1016, 533);
            this.Controls.Add(this.dgToron7Ens);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDATorom7Esp;
            this.dsGeneral = this.dsToron7Esp1;
            this.Name = "Toron7Esp";
            this.NombreTabla = "torom7esp";
            this.Text = "Toron7Esp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Toron7Esp_Load);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgToron7Ens, 0);
            this.panelToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsToron7Esp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgToron7Ens)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Toron7Esp_Load(object sender, System.EventArgs e)
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


		protected override void btnGuardar_Click(object sender, System.EventArgs e)
		{
			try 
			{
                txtUsrMov.Text = IdUsuario;
                // Intente actualizar el origen de datos.
                base.BindingContext[dsToron7Esp1,"Torom7Esp"].Position = this.BindingContext[dsToron7Esp1,"Torom7Esp"].Position;
				this.UpdateDataSet1();
				base.dsGeneral_PositionChanged();
			}
			catch (System.Exception eUpdate) 
			{
				statusBar1.Panels[2].Text = eUpdate.Message;	
				statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
				statusBar1.Panels[2].ToolTipText = eUpdate.Message;
			}
			dsToron7Esp1.Tables["Toron7Res"].Clear();
			sqlDATorom7Res.Fill(dsToron7Esp1,"Toron7Res");
		}

		public override void LoadDataSet()
		{

			//			sqlDAMuestreador.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
			base.LoadDataSet();
			//dgToron7Ens.SetDataBinding(dsToron7Esp1, "Torom7Esp.Toron7");
			//string apl = dgToron7Ens.TableStyles.ToString();
			dsToron7Esp1.Tables["Toron7Res"].Clear();
			sqlDATorom7Res.Fill(dsToron7Esp1,"Toron7Res");
		}

		private void UpdateDataSet1()
		{
			// Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
			// original			DataSet objDataSetChanges = new DataSet();
			LancNeo.dsToron7Esp objDataSetChanges = new LancNeo.dsToron7Esp();
			// Detener las ediciones actuales.
			// original			this.BindingContext[dsgeneral].EndCurrentEdit();
			this.BindingContext[dsToron7Esp1,"Torom7Esp"].EndCurrentEdit();
			this.BindingContext[dsToron7Esp1,"Toron7Res"].EndCurrentEdit();

			// Obtener los cambios realizados en el conjunto de datos principal.
			// original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));

			objDataSetChanges = ((LancNeo.dsToron7Esp)(dsToron7Esp1.GetChanges()));

			// Comprobar si se han realizado cambios.
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
					// llamando al método de actualización y pasando el conjunto de datos y los parámetros.
					this.UpdateDataSource1(objDataSetChanges);
					dsToron7Esp1.Merge(objDataSetChanges);
					dsToron7Esp1.AcceptChanges();
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
		private void UpdateDataSource1(LancNeo.dsToron7Esp ChangedRows)
		{
			try 
			{
				// Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
				if ((ChangedRows != null)) 
				{
					// Abra la conexión.
					this.sqlConn.Open();
					// Intente actualizar el origen de datos.
					sqlDATorom7Esp.Update(ChangedRows);
					sqlDATorom7Res.Update(ChangedRows);
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

		private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}
		 
	}
}
