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
    public partial class Solicitud : CatalogoGenerico
    {
        private int cambia = 0;
        private int regist = 2;
        private string IdUsuario;
        public Solicitud()
        {
            InitializeComponent();
        }

        private void Solicitud_Load(object sender, EventArgs e)
        {
            Control MyControl;
            foreach (Control l in this.MdiParent.Controls)
            {
                MyControl = (Control)l;
                if (MyControl.Name == "txtUsr")
                    IdUsuario = MyControl.Text;
            }
            sqlDABusSolicitud.Fill(dsBusSolicitud1, "Solicitud");
            this.buscaBtn1.Catalogo = this;
            cambia = 1;
            sqlDACaracObra.Fill(dsCaracObra1, "CaracObra");
            sqlDAIntensidad.Fill(dsIntensidad1, "Intensidad");
            sqlDAServicios.Fill(dsCatServicios1, "CatServicios");
            sqlDAPrecio.Fill(dsPrecioIncorporado1, "PrecioDet");
            EstableceVistaPrevia();
            this.dgPre.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        protected override void btnNuevo_Click(object sender, System.EventArgs e)
        {
            base.btnNuevo_Click(sender, e);
            cmbZona.SelectedIndex = 0;
            txtAño.Text = (DateTime.Now.Year - 2000).ToString();
            dtpFecha.Value = DateTime.Today.AddDays(1);
            dtpFecha.Value = DateTime.Today;
            dGServicios.Visible = false;
            dGServicios.Enabled = false;
            dgCar.Visible = false;
            dgCar.Enabled = false;
            dgPre.Visible = false;
            dgPre.Enabled = false;
            txtVersion.Text = "1";
            txtFormaPago.Text = "Se requiere un pago inicial  de $99,999.99 + IVA, como aprobación del presupuesto. Debera enviar comprobante de pago a: aclientes@laboratorioslanc.mx. \n Las facturas catorcenales serán enviadas vía correo electrónico y deberán liquidarse a la semana de su presentación.";
            txtMensualidad.Text = "0";
            txtm.Text = "0";
            txts.Text = "0";
            txtp.Text = "0";
        }

        protected override void btnGuardar_Click(object sender, System.EventArgs e)
        {
            txtUsrMov.Text = IdUsuario;
            int nuevo = 0;
            if (txtSolicitud.Text == "")
            {
                nuevo = 1;
                try
                {
                    sqlConn.Open();
                    sqlComSolicitud.Parameters["@Año"].Value = txtAño.Text; ;
                    txtSolicitud.Text = sqlComSolicitud.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                sqlConn.Close();
            }
            try
            {
                // Intente actualizar el origen de datos.
                base.BindingContext[dsSolicitud1, "Solicitud"].Position = this.BindingContext[dsSolicitud1, "Solicitud"].Position;
                this.UpdateDataSet1();
                base.dsGeneral_PositionChanged();
            }
            catch (System.Exception eUpdate)
            {
                statusBar1.Panels[2].Text = eUpdate.Message;
                statusBar1.Panels[2].Icon = this.statusBar1.Panels[2].Icon;
                statusBar1.Panels[2].ToolTipText = eUpdate.Message;
            }

            EstableceVistaPrevia();
            dGServicios.Visible = true;
            dGServicios.Enabled = true;
            dgCar.Visible = true;
            dgCar.Enabled = true;
            dgPre.Visible = true;
            dgPre.Enabled = true;
            if (nuevo == 1)
            {
                dGServicios.Visible = true;
                dGServicios.Enabled = true;
                dgCar.Visible = true;
                dgCar.Enabled = true;
                dgPre.Visible = true;
                dgPre.Enabled = true;
                InsertaCarac();
            }
            else
            {
                txtSolicitud_TextChanged( sender, null);
            }
        }

        private void EstableceVistaPrevia()
        {
            DataSet dsVP = new DataSet();
            dsBusSolicitud1.Clear();
            sqlDABusSolicitud.Fill(dsBusSolicitud1, "Solicitud");
            dsVistaPrevia = dsBusSolicitud1;//dsVP;
        }

        public override void LoadDataSet()
        {

            base.LoadDataSet();

            dsSolicitud1.SolicitudCar.Clear();
            dsSolicitud1.SolicitudSer.Clear();
            dsSolicitudVer1.Clear();
            sqlDAVersion.SelectCommand.Parameters["@IdSolicitud"].Value = txtSolicitud.Text;
            sqlDAVersion.SelectCommand.Parameters["@Año"].Value = txtAño.Text;
            sqlDAVersion.Fill(dsSolicitudVer1, "CatServicios");
            sqlDASolicitudSer.SelectCommand.Parameters["@IdSolicitud"].Value = txtSolicitud.Text;
            sqlDASolicitudSer.SelectCommand.Parameters["@Año"].Value = txtAño.Text;
            sqlDASolicitudSer.Fill(dsSolicitud1, "SolicitudSer");
            sqlDASolicitudCar.SelectCommand.Parameters["@IdSolicitud"].Value = txtSolicitud.Text;
            sqlDASolicitudCar.SelectCommand.Parameters["@Año"].Value = txtAño.Text;
            sqlDASolicitudCar.Fill(dsSolicitud1, "SolicitudCar");
            cmbVersion.SelectedIndex = 0;
            if (cmbVersion.SelectedValue == null)
                sqlDASolicitudPre.SelectCommand.Parameters["@Version"].Value = 1;
            else
                sqlDASolicitudPre.SelectCommand.Parameters["@Version"].Value = cmbVersion.SelectedValue;
            dsSolicitud1.SolicitudPre.Clear();
            sqlDASolicitudPre.SelectCommand.Parameters["@IdSolicitud"].Value = txtSolicitud.Text;
            sqlDASolicitudPre.SelectCommand.Parameters["@Año"].Value = txtAño.Text;
            sqlDASolicitudPre.Fill(dsSolicitud1, "SolicitudPre");
            //Calculos();
        }

        private void UpdateDataSet1()
        {
            // Crear un conjunto de datos para alojar los cambios realizados en el conjunto de datos principal.
            // original			DataSet objDataSetChanges = new DataSet();
            LancNeo.dsSolicitud objDataSetChanges = new LancNeo.dsSolicitud();
            // Detener las ediciones actuales.
            // original			this.BindingContext[dsgeneral].EndCurrentEdit();
            this.BindingContext[dsSolicitud1, "Solicitud"].EndCurrentEdit();
//            this.BindingContext[dsCatServicios1, "CatServicios"].EndCurrentEdit();
//            this.BindingContext[dsCatServicios1, "CatServicios"].EndCurrentEdit();

            // Obtener los cambios realizados en el conjunto de datos principal.
            // original			objDataSetChanges = ((DataSet)(dsgeneral.GetChanges()));

            objDataSetChanges = ((LancNeo.dsSolicitud)(dsSolicitud1.GetChanges()));

           // Comprobar si se han realizado cambios.
            if ((objDataSetChanges != null))
            {
                try
                {
                    // Hay cambios que necesitan aplicarse, por tanto, intente actualizar el origen de datos
                    // llamando al método de actualización y pasando el conjunto de datos y los parámetros.
                    this.UpdateDataSource1(objDataSetChanges);
                    dsSolicitud1.Merge(objDataSetChanges);
                    dsSolicitud1.AcceptChanges();
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
        private void UpdateDataSource1(LancNeo.dsSolicitud ChangedRows)
        {
            try
            {
                // Sólo es necesario actualizar el origen de datos si hay cambios pendientes.
                if ((ChangedRows != null))
                {
                    // Abra la conexión.
                    this.sqlConn.Open();
                    // Intente actualizar el origen de datos.
                    sqlDASolicitud.Update(ChangedRows);
                    sqlDASolicitudSer.Update(ChangedRows);
                    sqlDASolicitudCar.Update(ChangedRows);
                    sqlDASolicitudPre.Update(ChangedRows);
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
        private void InsertaCarac()
        {
            int soldadura = 0;
            for (int i = 0; i < dsSolicitud1.SolicitudSer.Rows.Count; i++)
                if (int.Parse(dsSolicitud1.SolicitudSer.Rows[i][4].ToString()) >= 220 && int.Parse(dsSolicitud1.SolicitudSer.Rows[i][4].ToString()) <= 290)
                    soldadura = 1;
            for (int i = 0; i < dsCaracObra1.CaracObra.Rows.Count; i++)
            {
                dsSolicitud1.SolicitudCar.Rows.Add(txtSolicitud.Text, txtAño.Text, dsCaracObra1.CaracObra.Rows[i][0].ToString().Trim(), dsCaracObra1.CaracObra.Rows[i][1].ToString().Trim(), dsCaracObra1.CaracObra.Rows[i][2].ToString().Trim(), 0, 0);
            }
            txtVersion.Text = "1";
                string buscaID = "1.";
                DataRow filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 10, txtVersion.Text, "1.", 0, filas[2].ToString(), filas[3].ToString(),(regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));
                buscaID = "1.2.00.";
                filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 20, txtVersion.Text, "1.2.00.", 0, "0" , " ", (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));
                buscaID = "1.2.01.";
                filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 30, txtVersion.Text, "1.2.01.", 0, filas[2].ToString(), filas[3].ToString(), (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));
                buscaID = "1.2.02.";
                filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 40, txtVersion.Text, "1.2.02.", 0, filas[2].ToString(), filas[3].ToString(), (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));
                buscaID = "1.2.03.";
                filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 50, txtVersion.Text, "1.2.03.", 0, filas[2].ToString(), filas[3].ToString(), (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));
                buscaID = "1.2.04.";
                filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 60, txtVersion.Text, "1.2.04.", 0, filas[2].ToString(), filas[3].ToString(), (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));
                //buscaID = "1.2.20.";
                //filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                //dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 70, txtVersion.Text, "1.2.20.", 0, filas[2].ToString(), filas[3].ToString(), (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));
                buscaID = "1.2.09.";
                filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 80, txtVersion.Text, "1.2.09.", 0, filas[2].ToString(), filas[3].ToString(), (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));
                buscaID = "1.2.15.";
                filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 90, txtVersion.Text, "1.2.15.", 0, filas[2].ToString(), filas[3].ToString(), (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));
                buscaID = "1.2.17.";
                filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                if (filas != null) 
                    dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 100, txtVersion.Text, "1.2.17.", 0, filas[2].ToString(), filas[3].ToString(), (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));
                buscaID = "1.2.21.";
                filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                if (filas != null)
                    dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 105, txtVersion.Text, "1.2.21.", 0, filas[2].ToString(), filas[3].ToString(), (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));

                if (soldadura == 1)
                {
                    buscaID = "8.1.04.";
                    filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                    if (filas != null)
                        dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 300, txtVersion.Text, "8.1.04.", 0, filas[2].ToString(), filas[3].ToString(), (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));
                }

                buscaID = "0.";
                filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 110, txtVersion.Text, "0.", 0, filas[2].ToString(), filas[3].ToString(), (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));
                buscaID = "3.";
                filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 120, txtVersion.Text, "3.", 0, filas[2].ToString(), filas[3].ToString(), (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));
                buscaID = "3.1.01.";
                filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 130, txtVersion.Text, "3.1.01.", 0, filas[2].ToString(), filas[3].ToString(), (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));
                buscaID = "3.1.02.";
                filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 140, txtVersion.Text, "3.1.02.", 0, filas[2].ToString(), filas[3].ToString(), (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));
                buscaID = "3.1.03.";
                filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 150, txtVersion.Text, "3.1.03.", 0, filas[2].ToString(), filas[3].ToString(), (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));
                buscaID = "3.1.04.";
                filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 160, txtVersion.Text, "3.1.04.", 0, filas[2].ToString(), filas[3].ToString(), (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));
                buscaID = "0.";
                filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                dsSolicitud1.SolicitudPre.Rows.Add(txtSolicitud.Text, txtAño.Text, 170, txtVersion.Text, "0.", 0, filas[2].ToString(), filas[3].ToString(), (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())));
                dsSolicitud1.SolicitudSer.Rows.Add(txtSolicitud.Text, txtAño.Text, 10, 10);
                dsSolicitud1.SolicitudSer.Rows.Add(txtSolicitud.Text, txtAño.Text, 20, 20);
                dsSolicitud1.SolicitudSer.Rows.Add(txtSolicitud.Text, txtAño.Text, 30, 30);
                dsSolicitud1.SolicitudSer.Rows.Add(txtSolicitud.Text, txtAño.Text, 40, 40);
        }

        private void dgPre_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (((e.ColumnIndex != 4) && (e.ColumnIndex != 2)) || (cambia == 0)) return;

            txtVersion.Text = (txtVersion.Text == "" ? "1" : txtVersion.Text);

            if ((e.ColumnIndex == 4))
            {
                string buscaID = dgPre[4, e.RowIndex].Value.ToString();
                DataRow filas = dsPrecioIncorporado1.Tables[0].Rows.Find(buscaID);
                dgPre[5, e.RowIndex].Value = (regist == 1 ? filas[4].ToString() : (regist == 2 ? filas[7].ToString() : filas[8].ToString())) ;
                dgPre[6, e.RowIndex].Value = filas[3].ToString();
                dgPre[7, e.RowIndex].Value = filas[2].ToString();
            }
            else if((e.ColumnIndex == 2))
                dgPre[3, e.RowIndex].Value = txtVersion.Text;
        }

        private void tbBtn1_Click(object sender, EventArgs e)
        {
            if (cmbVersion.Items.Count > 0)
            {
                txtVersion.Text = (int.Parse(dsSolicitudVer1.CatServicios[0][2].ToString()) + 1).ToString();
                int renglones = dgPre.Rows.Count - 1;
                for (int i = 0; i < renglones; i++)
                    if (dgPre[2, i].Value.ToString() != "")
                        dsSolicitud1.SolicitudPre.Rows.Add(dgPre[0, i].Value.ToString().Trim(), dgPre[1, i].Value, dgPre[2, i].Value,
                                                           txtVersion.Text, dgPre[4, i].Value.ToString().Trim(), dgPre[8, i].Value,
                                                           dgPre[7, i].Value, dgPre[6, i].Value.ToString(), dgPre[5, i].Value.ToString());
            }
        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVersion.Items.Count > 0)
            {
                dsSolicitud1.SolicitudPre.Rows.Clear();
                if (cmbVersion.SelectedValue == null)
                    sqlDASolicitudPre.SelectCommand.Parameters["@Version"].Value = 1;
                else
                    sqlDASolicitudPre.SelectCommand.Parameters["@Version"].Value = cmbVersion.SelectedValue;
                sqlDASolicitudPre.Fill(dsSolicitud1, "SolicitudPre");
            }
            else
            {
                txtVersion.Text = "1";
            }
        }

        private void txtSolicitud_TextChanged(object sender, EventArgs e)
        {
            if (txtSolicitud.Text != "")
            {
                dsSolicitudVer1.Clear();
                sqlDAVersion.SelectCommand.Parameters["@IdSolicitud"].Value = txtSolicitud.Text;
                sqlDAVersion.SelectCommand.Parameters["@Año"].Value = txtAño.Text;
                sqlDAVersion.Fill(dsSolicitudVer1, "CatServicios");
                if (cmbVersion.Items.Count == 0 || cmbVersion.SelectedValue == null )
                    {
                        sqlDASolicitudPre.SelectCommand.Parameters["@Version"].Value = 1;
                        txtVersion.Text = "1";
                    }
                    else
                    {
                        sqlDASolicitudPre.SelectCommand.Parameters["@Version"].Value = cmbVersion.SelectedValue;
                        txtVersion.Text = cmbVersion.SelectedValue.ToString();
                    }
                    dsSolicitud1.SolicitudPre.Clear();
                    sqlDASolicitudPre.SelectCommand.Parameters["@IdSolicitud"].Value = txtSolicitud.Text;
                    sqlDASolicitudPre.SelectCommand.Parameters["@Año"].Value = txtAño.Text;
                    sqlDASolicitudPre.Fill(dsSolicitud1, "SolicitudPre");
                    dsSolicitud1.SolicitudCar.Clear();
                    sqlDASolicitudCar.SelectCommand.Parameters["@IdSolicitud"].Value = txtSolicitud.Text;
                    sqlDASolicitudCar.SelectCommand.Parameters["@Año"].Value = txtAño.Text;
                    sqlDASolicitudCar.Fill(dsSolicitud1, "SolicitudCar");
                    dsSolicitud1.SolicitudSer.Clear();
                    sqlDASolicitudSer.SelectCommand.Parameters["@IdSolicitud"].Value = txtSolicitud.Text;
                    sqlDASolicitudSer.SelectCommand.Parameters["@Año"].Value = txtAño.Text;
                    sqlDASolicitudSer.Fill(dsSolicitud1, "SolicitudSer");
                    //if (txtVersion.Text == "")
                    //    txtVersion.Text = "1";
                    Calculos();
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void tbBtn2_Click(object sender, EventArgs e)
        {
            InsertaCarac();
        }

        private void dgCar_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCar.Rows.Count > 3)
            {
                if (((e.ColumnIndex != 5) || (cambia == 0))) return;

                if (dgCar[2, e.RowIndex].Value.ToString().Trim() == "30")
                    txtm.Text = dgCar[5, e.RowIndex].Value.ToString().Trim();

                if (dgCar[2, e.RowIndex].Value.ToString().Trim() == "100")
                    txts.Text = dgCar[5, e.RowIndex].Value.ToString().Trim();
            }
        }

        private void txtm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtm.Text != "" && txtm.Text != "0")
                    txtp.Text = (double.Parse(txtm.Text) / double.Parse(txts.Text)).ToString();
            }
            catch (Exception ex) { }

        }

        private void txts_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtm.Text != "" && txtm.Text != "0")
                    txtp.Text = (double.Parse(txtm.Text) / double.Parse(txts.Text)).ToString();
            }
            catch (Exception ex) { }
        }

        private void Calculos()
        {
            double mensualidad = 0;
            txtMensualidad.Text = "0";
            for (int i = 0; i < dsSolicitud1.SolicitudCar.Rows.Count; i++)
            {
                if (dsSolicitud1.SolicitudCar.Rows[i][2].ToString().Trim() == "30")
                    txtm.Text = dsSolicitud1.SolicitudCar.Rows[i][5].ToString().Trim();
                if (dsSolicitud1.SolicitudCar.Rows[i][2].ToString().Trim() == "100")
                    txts.Text = dsSolicitud1.SolicitudCar.Rows[i][5].ToString().Trim();
            }
            try
            {
                if (double.Parse(txtPQT.Text) > 0)
                {
                    mensualidad = (double.Parse(txtCantidad.Text) * double.Parse(txtPQT.Text)) / (double.Parse(txts.Text) / 4.33) ;
                    txtMensualidad.Text = mensualidad.ToString();
                }
            }
            catch (Exception ex) { }
        }

        private void rbtSe_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtLp.Checked) regist = 1;
            if (rbtSe.Checked) regist = 2;
            if (rbtRz.Checked) regist = 3;
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            //DateTime? value = DBNull.Value;
            //DateTime prueba ;
            //if (dateTimePicker1.Checked == false)
            //    dateTimePicker1.Value = Convert.ToDateTime(value);
        }

        private void dgPre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.Format = DateTimePickerFormat.Custom;

            if (dateTimePicker3.Checked == false)
            {
                dateTimePicker3.CustomFormat = " ";
            }
            else
            {
                dateTimePicker3.CustomFormat = "dd/MM/yyyy";
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            dtpFecha.Format = DateTimePickerFormat.Custom;

            if (dtpFecha.Checked == false)
            {
                dtpFecha.CustomFormat = " ";
            }
            else
            {
                dtpFecha.CustomFormat = "dd/MM/yyyy";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            if (dateTimePicker1.Checked == false)
            {
                dateTimePicker1.CustomFormat = " ";
            }
            else
            {
                dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

            if (dateTimePicker2.Checked == false)
            {
                dateTimePicker2.CustomFormat = " ";
            }
            else
            {
                dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            }

        }

        private void tbBtn3_Click(object sender, EventArgs e)
        {
            txtInformes.Text = "INSTALACIONES:\n";
            txtInformes.Text += "Se ha considerado la instalación de un laboratorio de campo con dimensiones " + textBox3.Text.Trim();
            txtInformes.Text += " m aproximadamente, éste deberá ser proporcionado por ustedes, cercano a las descargas de las ollas con área para desperdicios, pileta con agua y corriente eléctrica, para la conservación de las muestras. Esto evitará el movimiento de cilindros a edades tempranas y el riesgo de su maltrato.";
        }
    }
}
