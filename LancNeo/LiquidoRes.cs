using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Soluciones2000.Tools.WinLib;

namespace LancNeo
{
    public partial class LiquidoRes : CatalogoGenerico
    {
        public LiquidoRes()
        {
            InitializeComponent();
        }

        private void LiquidoRes_Load(object sender, EventArgs e)
        {
            sqlDABusInforme.Fill(dsBusInf1, "InfMdor");
            
        }

        private void buscaBtn1_Click(object sender, EventArgs e)
        {
            txtFolio.Text = dsBusInf1.Tables[0].Rows[(buscaBtn1.RegistroSeleccionado)][0].ToString();
            txtObra.Text = dsBusInf1.Tables[0].Rows[(buscaBtn1.RegistroSeleccionado)][1].ToString();
            txtConsecutivo.Text = dsBusInf1.Tables[0].Rows[(buscaBtn1.RegistroSeleccionado)][2].ToString();
            txtFecha.Text = dsBusInf1.Tables[0].Rows[(buscaBtn1.RegistroSeleccionado)][3].ToString();
        }

        private void txtFolio_TextChanged(object sender, EventArgs e)
        {
            
            DataSet objDataSetChanges = ((LancNeo.dsLiquidoRes)(dsLiquidoRes1.GetChanges()));
            this.BindingContext[dsLiquidoRes1, "LiquidoRes"].EndCurrentEdit();
            if (objDataSetChanges != null)
              {
                  switch (MessageBox.Show("Desea Guardar los cambios ", "Existen cambios", System.Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                       case DialogResult.Yes:
                            btnGuardar_Click(sender, null);
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            dsLiquidoRes1.Clear();
            sqlDALiquidoRes.SelectCommand.Parameters["@IdFolio"].Value = txtFolio.Text;
            sqlDALiquidoRes.Fill(dsLiquidoRes1, "LiquidoRes");


        }
        public override void LoadDataSet()
        {
            sqlDALiquidoRes.SelectCommand.Parameters["@IdFolio"].Value = txtFolio.Text;
            base.LoadDataSet();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {


        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            int ren = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[ren].Cells[0].Value = txtFolio.Text;
        }
    }
}
