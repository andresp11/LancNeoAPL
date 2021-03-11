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
    public partial class Actividad : CatalogoGenerico
    {
        public Actividad()
        {
            InitializeComponent();
        }

        private void Actividad_Load(object sender, EventArgs e)
        {
            dsGenerico1.Generico.AddGenericoRow("m²", "m²");
            dsGenerico1.Generico.AddGenericoRow("vivienda", "vivienda");
            sqlDABusActividad.Fill(dsBusActividad1, "Actividad");
            this.buscaBtn1.Catalogo = this;
            sqlDAIntensidad.Fill(dsIntensidad1, "Intensidad");
        }

        private void tbBtn2_Click(object sender, EventArgs e)
        {
            string IdObras = txtIdObra.Text;
            int registro = this.BindingContext[dsActividad1, "Actividad"].Position;
            try
            {
                sqlConn.Open();
                sqlComActividad.Parameters["@IdObra"].Value = txtIdObra.Text;
                int error = sqlComActividad.ExecuteNonQuery();
                MessageBox.Show("Proceso terminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
            base.LoadDataSet();
            base.BindingContext[dsActividad1, "Actividad"].Position = registro;
            base.UpdateDataSet();
            base.dsGeneral_PositionChanged();


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


    }
}
