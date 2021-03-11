using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace LancNeo
{
	/// <summary>
	/// Descripción breve de Concreto.
	/// </summary>
	public class Concreto : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Data.SqlClient.SqlDataAdapter sqlDAConcreto;
		private System.Data.SqlClient.SqlConnection sqlConn;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private LancNeo.dsConcreto dsConcreto1;
        protected Soluciones2000.Tools.WinLib.tbBtn btnVistaPrevia;
        private DataGridView dgConcreto;
        private DataGridViewTextBoxColumn idObraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resistenciaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Tipo1;
        private DataGridViewTextBoxColumn tMADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn revDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idObraDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private dsConcreNew dsConcreNew1;
        private DataGridViewTextBoxColumn idObraDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn resistenciaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn tipo1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tMADataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn revDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn tADataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nMuestrasDataGridViewTextBoxColumn;
        private Label label5;
        private ComboBox cmbObra;
        private dsBuscaObra dsBuscaObra1;
        public System.Data.SqlClient.SqlDataAdapter sqlDABusObra;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label2;
        private TextBox txtMinimo;
        private CheckBox cbkPrefijo;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Concreto()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Concreto));
            System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVistaPrevia = new Soluciones2000.Tools.WinLib.tbBtn();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlDAConcreto = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.dsConcreto1 = new LancNeo.dsConcreto();
            this.idObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resistenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgConcreto = new System.Windows.Forms.DataGridView();
            this.dsConcreNew1 = new LancNeo.dsConcreNew();
            this.idObraDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resistenciaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMuestrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbObra = new System.Windows.Forms.ComboBox();
            this.sqlDABusObra = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dsBuscaObra1 = new LancNeo.dsBuscaObra();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.cbkPrefijo = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcreto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConcreto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcreNew1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 64);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.Transparent;
            this.btnVistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("btnVistaPrevia.Icon")));
            this.btnVistaPrevia.Location = new System.Drawing.Point(662, 0);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(64, 64);
            this.btnVistaPrevia.TabIndex = 42;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Consulta de concretos solicitado";
            // 
            // sqlDAConcreto
            // 
            this.sqlDAConcreto.SelectCommand = this.sqlSelectCommand1;
            this.sqlDAConcreto.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Muestras", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdObra", "IdObra"),
                        new System.Data.Common.DataColumnMapping("Resistencia", "Resistencia"),
                        new System.Data.Common.DataColumnMapping("Tipo", "Tipo"),
                        new System.Data.Common.DataColumnMapping("T.M.A.", "T.M.A."),
                        new System.Data.Common.DataColumnMapping("Rev.", "Rev."),
                        new System.Data.Common.DataColumnMapping("T. A.", "T. A.")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConn;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@IdObra", System.Data.SqlDbType.NVarChar, 6, "IdObra"),
            new System.Data.SqlClient.SqlParameter("@Cuantas", System.Data.SqlDbType.Decimal)});
            // 
            // sqlConn
            // 
            this.sqlConn.ConnectionString = ((string)(configurationAppSettings.GetValue("sqlConn.ConnectionString", typeof(string))));
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            // 
            // dsConcreto1
            // 
            this.dsConcreto1.DataSetName = "dsConcreto";
            this.dsConcreto1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsConcreto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idObraDataGridViewTextBoxColumn
            // 
            this.idObraDataGridViewTextBoxColumn.DataPropertyName = "IdObra";
            this.idObraDataGridViewTextBoxColumn.HeaderText = "IdObra";
            this.idObraDataGridViewTextBoxColumn.Name = "idObraDataGridViewTextBoxColumn";
            // 
            // resistenciaDataGridViewTextBoxColumn
            // 
            this.resistenciaDataGridViewTextBoxColumn.DataPropertyName = "Resistencia";
            this.resistenciaDataGridViewTextBoxColumn.HeaderText = "Resistencia";
            this.resistenciaDataGridViewTextBoxColumn.Name = "resistenciaDataGridViewTextBoxColumn";
            // 
            // Tipo1
            // 
            this.Tipo1.DataPropertyName = "Tipo1";
            this.Tipo1.HeaderText = "Tipo";
            this.Tipo1.Name = "Tipo1";
            // 
            // tMADataGridViewTextBoxColumn
            // 
            this.tMADataGridViewTextBoxColumn.DataPropertyName = "TMA";
            this.tMADataGridViewTextBoxColumn.HeaderText = "TMA";
            this.tMADataGridViewTextBoxColumn.Name = "tMADataGridViewTextBoxColumn";
            // 
            // revDataGridViewTextBoxColumn
            // 
            this.revDataGridViewTextBoxColumn.DataPropertyName = "Rev";
            this.revDataGridViewTextBoxColumn.HeaderText = "Rev";
            this.revDataGridViewTextBoxColumn.Name = "revDataGridViewTextBoxColumn";
            // 
            // tADataGridViewTextBoxColumn
            // 
            this.tADataGridViewTextBoxColumn.DataPropertyName = "TA";
            this.tADataGridViewTextBoxColumn.HeaderText = "TA";
            this.tADataGridViewTextBoxColumn.Name = "tADataGridViewTextBoxColumn";
            // 
            // idObraDataGridViewTextBoxColumn1
            // 
            this.idObraDataGridViewTextBoxColumn1.DataPropertyName = "IdObra";
            this.idObraDataGridViewTextBoxColumn1.HeaderText = "IdObra";
            this.idObraDataGridViewTextBoxColumn1.Name = "idObraDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tipo1";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tipo1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dgConcreto
            // 
            this.dgConcreto.AutoGenerateColumns = false;
            this.dgConcreto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConcreto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObraDataGridViewTextBoxColumn2,
            this.resistenciaDataGridViewTextBoxColumn1,
            this.tipo1DataGridViewTextBoxColumn,
            this.tMADataGridViewTextBoxColumn1,
            this.revDataGridViewTextBoxColumn1,
            this.tADataGridViewTextBoxColumn1,
            this.nMuestrasDataGridViewTextBoxColumn});
            this.dgConcreto.DataMember = "Muestras";
            this.dgConcreto.DataSource = this.dsConcreNew1;
            this.dgConcreto.Location = new System.Drawing.Point(0, 88);
            this.dgConcreto.Name = "dgConcreto";
            this.dgConcreto.Size = new System.Drawing.Size(771, 512);
            this.dgConcreto.TabIndex = 7;
            this.dgConcreto.Visible = false;
            // 
            // dsConcreNew1
            // 
            this.dsConcreNew1.DataSetName = "dsConcreNew";
            this.dsConcreNew1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idObraDataGridViewTextBoxColumn2
            // 
            this.idObraDataGridViewTextBoxColumn2.DataPropertyName = "IdObra";
            this.idObraDataGridViewTextBoxColumn2.HeaderText = "IdObra";
            this.idObraDataGridViewTextBoxColumn2.Name = "idObraDataGridViewTextBoxColumn2";
            // 
            // resistenciaDataGridViewTextBoxColumn1
            // 
            this.resistenciaDataGridViewTextBoxColumn1.DataPropertyName = "Resistencia";
            this.resistenciaDataGridViewTextBoxColumn1.HeaderText = "Resistencia";
            this.resistenciaDataGridViewTextBoxColumn1.Name = "resistenciaDataGridViewTextBoxColumn1";
            // 
            // tipo1DataGridViewTextBoxColumn
            // 
            this.tipo1DataGridViewTextBoxColumn.DataPropertyName = "Tipo1";
            this.tipo1DataGridViewTextBoxColumn.HeaderText = "Tipo1";
            this.tipo1DataGridViewTextBoxColumn.Name = "tipo1DataGridViewTextBoxColumn";
            // 
            // tMADataGridViewTextBoxColumn1
            // 
            this.tMADataGridViewTextBoxColumn1.DataPropertyName = "TMA";
            this.tMADataGridViewTextBoxColumn1.HeaderText = "TMA";
            this.tMADataGridViewTextBoxColumn1.Name = "tMADataGridViewTextBoxColumn1";
            // 
            // revDataGridViewTextBoxColumn1
            // 
            this.revDataGridViewTextBoxColumn1.DataPropertyName = "Rev";
            this.revDataGridViewTextBoxColumn1.HeaderText = "Rev";
            this.revDataGridViewTextBoxColumn1.Name = "revDataGridViewTextBoxColumn1";
            // 
            // tADataGridViewTextBoxColumn1
            // 
            this.tADataGridViewTextBoxColumn1.DataPropertyName = "TA";
            this.tADataGridViewTextBoxColumn1.HeaderText = "TA";
            this.tADataGridViewTextBoxColumn1.Name = "tADataGridViewTextBoxColumn1";
            // 
            // nMuestrasDataGridViewTextBoxColumn
            // 
            this.nMuestrasDataGridViewTextBoxColumn.DataPropertyName = "N° muestras";
            this.nMuestrasDataGridViewTextBoxColumn.HeaderText = "N° muestras";
            this.nMuestrasDataGridViewTextBoxColumn.Name = "nMuestrasDataGridViewTextBoxColumn";
            this.nMuestrasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Obra:";
            // 
            // cmbObra
            // 
            this.cmbObra.DataSource = this.dsBuscaObra1;
            this.cmbObra.DisplayMember = "Obra.Idobra";
            this.cmbObra.Location = new System.Drawing.Point(463, 6);
            this.cmbObra.Name = "cmbObra";
            this.cmbObra.Size = new System.Drawing.Size(80, 21);
            this.cmbObra.TabIndex = 49;
            this.cmbObra.ValueMember = "IdObra";
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
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConn;
            // 
            // dsBuscaObra1
            // 
            this.dsBuscaObra1.DataSetName = "dsBuscaObra";
            this.dsBuscaObra1.Locale = new System.Globalization.CultureInfo("es-MX");
            this.dsBuscaObra1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Minímo de muestras:";
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(463, 30);
            this.txtMinimo.MaxLength = 2;
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(80, 20);
            this.txtMinimo.TabIndex = 52;
            this.txtMinimo.Text = "10";
            // 
            // cbkPrefijo
            // 
            this.cbkPrefijo.Checked = true;
            this.cbkPrefijo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkPrefijo.Location = new System.Drawing.Point(463, 56);
            this.cbkPrefijo.Name = "cbkPrefijo";
            this.cbkPrefijo.Size = new System.Drawing.Size(74, 24);
            this.cbkPrefijo.TabIndex = 53;
            this.cbkPrefijo.Text = "No prefijo";
            // 
            // Concreto
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(772, 605);
            this.Controls.Add(this.btnVistaPrevia);
            this.Controls.Add(this.cbkPrefijo);
            this.Controls.Add(this.txtMinimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbObra);
            this.Controls.Add(this.dgConcreto);
            this.Controls.Add(this.panel2);
            this.Name = "Concreto";
            this.Text = "Concreto";
            this.Load += new System.EventHandler(this.Concreto_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsConcreto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgConcreto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConcreNew1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuscaObra1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void buscaBtn1_Click(object sender, System.EventArgs e)
		{
			sqlDAConcreto.Fill(dsConcreNew1,"Muestras");
			dgConcreto.Visible = true;
			btnVistaPrevia.Visible = false;

		}
		private void Concreto_Load(object sender, System.EventArgs e)
		{
            sqlDABusObra.Fill(dsBuscaObra1, "Obra");
		}

		private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void btnVistaPrevia_Click(object sender, System.EventArgs e)
		{
            dsConcreNew1.Clear();
            sqlDAConcreto.SelectCommand.Parameters["@IdObra"].Value = (cbkPrefijo.Checked ? cmbObra.SelectedValue.ToString().Trim() : cmbObra.SelectedValue.ToString().Trim() + "%");
            sqlDAConcreto.SelectCommand.Parameters["@Cuantas"].Value = txtMinimo.Text.Trim();
            sqlDAConcreto.Fill(dsConcreNew1,"Muestras");
			dgConcreto.Visible = true;
//			btnVistaPrevia.Visible = false;
		
		}
	}
}
