using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;
using System.Data;
using System.Data.SqlClient;
//using DataGridExtensions;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Presupuesto.
	/// </summary>
	public class Presupuesto : CatalogoGenerico
	{
		private System.Data.SqlClient.SqlDataAdapter sqlDAPresupuesto;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private LancNeo.dsPresupuesto dsPresupuesto1;
		private System.Windows.Forms.Panel panel2;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcepto;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private LancNeo.dsBusObra dsBusObra1;
		private LancNeo.dsConcepto dsConcepto1;
		private System.Windows.Forms.Label label1;
		public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.ComboBox cmbIdObra;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Windows.Forms.TextBox txtIdObra;
        private DataGridView dgPresupuestos;
        private DataGridViewTextBoxColumn idObraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn renglonDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn idConceptoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Presupuesto()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presupuesto));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sqlDAPresupuesto = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsPresupuesto1 = new LancNeo.dsPresupuesto();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbIdObra = new System.Windows.Forms.ComboBox();
            this.dsBusObra1 = new LancNeo.dsBusObra();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdObra = new System.Windows.Forms.TextBox();
            this.dsConcepto1 = new LancNeo.dsConcepto();
            this.sqlDAConcepto = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dgPresupuestos = new System.Windows.Forms.DataGridView();
            this.idObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renglonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idConceptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcepto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPresupuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 441);
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(578, 22);
            // 
            // panelToolBar
            // 
            this.panelToolBar.Size = new System.Drawing.Size(578, 64);
            // 
            // sqlDAPresupuesto
            // 
            this.sqlDAPresupuesto.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDAPresupuesto.InsertCommand = this.sqlInsertCommand1;
            this.sqlDAPresupuesto.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAPresupuesto.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Presupuesto", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Renglon", "Renglon"),
                        new System.Data.Common.DataColumnMapping("IdConcepto", "IdConcepto"),
                        new System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"),
                        new System.Data.Common.DataColumnMapping("importe", "importe")})});
            this.sqlDAPresupuesto.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Renglon", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Renglon", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(4)), "Cantidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdConcepto", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdConcepto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_importe", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "importe", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Renglon", System.Data.SqlDbType.Int, 4, "Renglon"),
            new System.Data.SqlClient.SqlParameter("@IdConcepto", System.Data.SqlDbType.SmallInt, 2, "IdConcepto"),
            new System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(4)), "Cantidad", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@importe", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "importe", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT IdObra, Renglon, IdConcepto, Cantidad, importe FROM Presupuesto WHERE (IdO" +
                "bra = @IdObra) ORDER BY IdObra, IdConcepto";
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Renglon", System.Data.SqlDbType.Int, 4, "Renglon"),
            new System.Data.SqlClient.SqlParameter("@IdConcepto", System.Data.SqlDbType.SmallInt, 2, "IdConcepto"),
            new System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(4)), "Cantidad", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@importe", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "importe", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdObra", System.Data.SqlDbType.NVarChar, 6, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdObra", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Renglon", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Renglon", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(4)), "Cantidad", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_IdConcepto", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdConcepto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_importe", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(2)), "importe", System.Data.DataRowVersion.Original, null)});
            // 
            // dsPresupuesto1
            // 
            this.dsPresupuesto1.DataSetName = "dsPresupuesto";
            this.dsPresupuesto1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsPresupuesto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cmbIdObra);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtIdObra);
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 32);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cmbIdObra
            // 
            this.cmbIdObra.DataSource = this.dsBusObra1.Obra;
            this.cmbIdObra.DisplayMember = "Idobra";
            this.cmbIdObra.Location = new System.Drawing.Point(128, 2);
            this.cmbIdObra.Name = "cmbIdObra";
            this.cmbIdObra.Size = new System.Drawing.Size(64, 21);
            this.cmbIdObra.TabIndex = 3;
            this.cmbIdObra.ValueMember = "Idobra";
            this.cmbIdObra.SelectedIndexChanged += new System.EventHandler(this.cmbIdObra_SelectedIndexChanged);
            // 
            // dsBusObra1
            // 
            this.dsBusObra1.DataSetName = "dsBusObra";
            this.dsBusObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBusObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idobra:";
            // 
            // txtIdObra
            // 
            this.txtIdObra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPresupuesto1, "Presupuesto.IdObra", true));
            this.txtIdObra.Location = new System.Drawing.Point(130, 2);
            this.txtIdObra.Name = "txtIdObra";
            this.txtIdObra.Size = new System.Drawing.Size(48, 20);
            this.txtIdObra.TabIndex = 7;
            this.txtIdObra.Text = "textBox1";
            // 
            // dsConcepto1
            // 
            this.dsConcepto1.DataSetName = "dsConcepto";
            this.dsConcepto1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcepto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDAConcepto
            // 
            this.sqlDAConcepto.SelectCommand = this.sqlSelectCommand3;
            this.sqlDAConcepto.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Concepto", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdConcepto", "IdConcepto"),
                        new System.Data.Common.DataColumnMapping("Concepto", "Concepto")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT IdConcepto, Concepto FROM Concepto ORDER BY Concepto";
            this.sqlSelectCommand3.Connection = this.sqlConn;
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
            // dgPresupuestos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgPresupuestos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPresupuestos.AutoGenerateColumns = false;
            this.dgPresupuestos.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPresupuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObraDataGridViewTextBoxColumn,
            this.renglonDataGridViewTextBoxColumn,
            this.idConceptoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn});
            this.dgPresupuestos.DataMember = "Presupuesto";
            this.dgPresupuestos.DataSource = this.dsPresupuesto1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPresupuestos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPresupuestos.Location = new System.Drawing.Point(2, 108);
            this.dgPresupuestos.Name = "dgPresupuestos";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgPresupuestos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPresupuestos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgPresupuestos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgPresupuestos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgPresupuestos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgPresupuestos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgPresupuestos.Size = new System.Drawing.Size(570, 328);
            this.dgPresupuestos.TabIndex = 6;
            // 
            // idObraDataGridViewTextBoxColumn
            // 
            this.idObraDataGridViewTextBoxColumn.DataPropertyName = "IdObra";
            this.idObraDataGridViewTextBoxColumn.HeaderText = "IdObra";
            this.idObraDataGridViewTextBoxColumn.Name = "idObraDataGridViewTextBoxColumn";
            this.idObraDataGridViewTextBoxColumn.Visible = false;
            this.idObraDataGridViewTextBoxColumn.Width = 5;
            // 
            // renglonDataGridViewTextBoxColumn
            // 
            this.renglonDataGridViewTextBoxColumn.DataPropertyName = "Renglon";
            this.renglonDataGridViewTextBoxColumn.HeaderText = "Renglon";
            this.renglonDataGridViewTextBoxColumn.Name = "renglonDataGridViewTextBoxColumn";
            this.renglonDataGridViewTextBoxColumn.Width = 60;
            // 
            // idConceptoDataGridViewTextBoxColumn
            // 
            this.idConceptoDataGridViewTextBoxColumn.DataPropertyName = "IdConcepto";
            this.idConceptoDataGridViewTextBoxColumn.DataSource = this.dsConcepto1;
            this.idConceptoDataGridViewTextBoxColumn.DisplayMember = "Concepto.Concepto";
            this.idConceptoDataGridViewTextBoxColumn.HeaderText = "IdConcepto";
            this.idConceptoDataGridViewTextBoxColumn.Name = "idConceptoDataGridViewTextBoxColumn";
            this.idConceptoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idConceptoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idConceptoDataGridViewTextBoxColumn.ValueMember = "Concepto.IdConcepto";
            this.idConceptoDataGridViewTextBoxColumn.Width = 300;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 75;
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            this.importeDataGridViewTextBoxColumn.Width = 75;
            // 
            // Presupuesto
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(578, 463);
            this.Controls.Add(this.dgPresupuestos);
            this.Controls.Add(this.panel2);
            this.DAGeneral = this.sqlDAPresupuesto;
            this.dsGeneral = this.dsPresupuesto1;
            this.Name = "Presupuesto";
            this.NombreTabla = "Presupuesto";
            this.Text = "Presupuesto";
            this.Load += new System.EventHandler(this.Presupuesto_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.statusBar1, 0);
            this.Controls.SetChildIndex(this.panelToolBar, 0);
            this.Controls.SetChildIndex(this.dgPresupuestos, 0);
            this.panelToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBusObra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcepto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPresupuestos)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Presupuesto_Load(object sender, System.EventArgs e)
		{
//			buscaBtn1.Catalogo = this;
			sqlDABusObra.Fill(dsBusObra1, "Obra");        
			sqlDAConcepto.Fill(dsConcepto1, "Concepto");
		}

		protected override void btnNuevo_Click(object sender, System.EventArgs e)
		{
			base.btnNuevo_Click(sender, e);
			txtIdObra.Text = cmbIdObra.SelectedValue.ToString();
		}

		private void cmbIdObra_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			txtIdObra.Text = cmbIdObra.SelectedValue.ToString();
			DataSet objDataSetChanges = ((LancNeo.dsPresupuesto)(dsPresupuesto1.GetChanges()));
			this.BindingContext[dsPresupuesto1,"Presupuesto"].EndCurrentEdit();
			if ((objDataSetChanges != null)) 
			{
				switch(MessageBox.Show("Desea Guardar los cambios ", "Existen cambios", System.Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Question))
				{
					case DialogResult.Yes:
						btnGuardar_Click(sender,null);
						break;
					case DialogResult.No:
						break;
				}
			}
//			this.LoadDataSet();
            dsPresupuesto1.Clear();
			sqlDAPresupuesto.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue.ToString();
			sqlDAPresupuesto.Fill(dsPresupuesto1, "Presupuesto");
//			dgPresupuesto.Enabled = true;
//			dgPresupuesto.Visible = true;
		}

		private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}
		public override void LoadDataSet()
		{
			sqlDAPresupuesto.SelectCommand.Parameters["@IdObra"].Value = cmbIdObra.SelectedValue;
			base.LoadDataSet();
		}
	}
}
