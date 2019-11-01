using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class FormCompras : FormProceso
    {
        public FormCompras()
        {
            InitializeComponent();           
        }

        public static int Cont_filas = 0;
        public static int Cant_exi = 0;
        public static double total = 0;

        private void FormCompras_Load(object sender, EventArgs e)
        {
            txt_usuario.Text = Utilidades.Utilidades.Usuario;
        }

        private void txt_codsup_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txt_codsup.Text.Trim()) == false)
                {
                    String CMD = String.Format("Select * FROM Suplidores where  CodSup = '{0}'", txt_codsup.Text.Trim());
                    DS = Utilidades.Utilidades.Ejecutar(CMD);
                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        txt_nomsup.Text = DS.Tables[0].Rows[0]["NomSup"].ToString();
                    }
                    else
                    {
                        txt_nomsup.Text = "";
                    }
                }
                else
                {
                    txt_nomsup.Text = "";
                }

            }
            catch (Exception w) { }
        }

        private void btn_ConsSup_Click(object sender, EventArgs e)
        {
            ConsSup obj = new ConsSup();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                txt_nomsup.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                txt_codsup.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btn_ConsArt_Click(object sender, EventArgs e)
        {
            ConsArt obj = new ConsArt();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                txt_CodArt.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txt_NomArt.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                txt_PreVen.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
                Cant_exi = 0;
                Cant_exi = Convert.ToInt16(obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString());
                txt_disponibles.Text = "Existente: " + obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[7].Value.ToString();
            }
            else
            {
                txt_disponibles.Text = "";
            }
        }

        private void txt_CodArt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txt_CodArt.Text.Trim()) == false)
                {
                    String CMD = String.Format("Select * FROM Articulos where  CodArt = '{0}'", txt_CodArt.Text.Trim());
                    DS = Utilidades.Utilidades.Ejecutar(CMD);
                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        txt_NomArt.Text = DS.Tables[0].Rows[0]["NomArt"].ToString();
                        txt_PreVen.Text = DS.Tables[0].Rows[0]["PreCom"].ToString();
                        Cant_exi = 0;
                        Cant_exi = Convert.ToInt16(DS.Tables[0].Rows[0]["CanExi"].ToString());
                        txt_disponibles.Text = "Existente: " + DS.Tables[0].Rows[0]["CanExi"].ToString();
                    }
                    else
                    {
                        txt_NomArt.Text = "";
                        txt_PreVen.Text = "";
                        txt_disponibles.Text = "";
                    }
                }
                else
                {
                    txt_disponibles.Text = "";
                    txt_NomArt.Text = "";
                    txt_PreVen.Text = "";
                }

            }
            catch (Exception w) { }
        }

        public override void Salvar()
        {
            if (Utilidades.Utilidades.ValidarForm(this, errorProvider1) == false)
            {
                try
                {
                    int num_filas = 0;
                    bool existe = false;

                    if (Cont_filas == 0)
                    {
                        dataGridView1.Rows.Add(txt_CodArt.Text.Trim(), txt_NomArt.Text.Trim(), txt_PreVen.Text.Trim(), txt_Cant.Text.Trim());
                        double importe = Convert.ToDouble(dataGridView1.Rows[Cont_filas].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[Cont_filas].Cells[3].Value);
                        dataGridView1.Rows[Cont_filas].Cells[4].Value = importe;
                        Cont_filas++;
                    }

                    else
                    {
                        foreach (DataGridViewRow Fila in dataGridView1.Rows)
                        {
                            if (Fila.Cells[0].Value.ToString().Equals(txt_CodArt.Text))
                            {
                                existe = true;
                                num_filas = Fila.Index;
                            }
                        }

                        if (existe == true)
                        {
                                dataGridView1.Rows[num_filas].Cells[3].Value = (Convert.ToDouble(txt_Cant.Text) + Convert.ToDouble(dataGridView1.Rows[num_filas].Cells[3].Value)).ToString();
                                double importe = Convert.ToDouble(dataGridView1.Rows[num_filas].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[num_filas].Cells[3].Value);
                                dataGridView1.Rows[num_filas].Cells[4].Value = importe;
                        }
                        else
                        {
                            dataGridView1.Rows.Add(txt_CodArt.Text.Trim(), txt_NomArt.Text.Trim(), txt_PreVen.Text.Trim(), txt_Cant.Text.Trim());
                            double importe = Convert.ToDouble(dataGridView1.Rows[Cont_filas].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[Cont_filas].Cells[3].Value);
                            dataGridView1.Rows[Cont_filas].Cells[4].Value = importe;
                            Cont_filas++;
                        }

                    }
                    total = 0;
                    foreach (DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        double actual = Convert.ToDouble(Fila.Cells[4].Value.ToString());
                        total = total + actual;
                    }
                    txt_total.Text = total.ToString("N1", CultureInfo.InvariantCulture);
                    txt_Cant.Text = "";
                    txt_CodArt.Text = "";
                    txt_NomArt.Text = "";
                    txt_PreVen.Text = "";
                    txt_Cant.Focus();
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Error ! Campos vacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dataGridView1.Rows.Count > 0)
            {
                txt_codsup.Enabled = false;
                btn_ConsSup.Enabled = false;
            }
        }

        public override void Cancelar()
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar la venta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Nuevo();
            }
        }

        public override void Eliminar()
        {
            if (Cont_filas > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este articulo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    total = total - Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value);
                    txt_total.Text = total.ToString("N1", CultureInfo.InvariantCulture);
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                }
            }

        }

        public override void Imprimir()
        {
            if (dataGridView1.Rows.Count > 0 && MessageBox.Show("¿ Facturar compra ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    String CMD = String.Format("EXEC ActCompras '{0}'", txt_codsup.Text.Trim());
                    DS = Utilidades.Utilidades.Ejecutar(CMD);
                    String NumFac = DS.Tables[0].Rows[0]["NumFac"].ToString().Trim();
                    foreach (DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        CMD = string.Format("EXEC ActComprasD '{0}','{1}', {2}, {3}", NumFac.ToString().Trim(), Fila.Cells[0].Value.ToString(), Fila.Cells[3].Value.ToString(), Fila.Cells[2].Value.ToString().Replace(",", "."));
                        DS = Utilidades.Utilidades.Ejecutar(CMD);
                    }
                    CMD = "EXEC DatosFacturaCompra " + NumFac;
                    DS = Utilidades.Utilidades.Ejecutar(CMD);
                    Nuevo();
                    FacturaCompra obj = new FacturaCompra();
                    obj.reportViewer1.LocalReport.DataSources[0].Value = DS.Tables[0];
                    obj.ShowDialog();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione los articulos.");
                return;
            }
           
        }

        public override void Consultar()
        {
            ConsultarVentaCompra obj1 = new ConsultarVentaCompra("Compras");
            if (obj1.ShowDialog() == DialogResult.OK)
            {
                String NumFac = obj1.dataGridView1.Rows[obj1.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                String Codigo = obj1.dataGridView1.Rows[obj1.dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
                DS = Utilidades.Utilidades.Ejecutar(String.Format("Select * From Suplidores where CodSup = '{0}'", Codigo));
                Utilidades.Utilidades.email_destino = DS.Tables[0].Rows[0]["Email"].ToString().Trim();
                Utilidades.Utilidades.des_email = "Factura compra Warmer Market.";


                String CMD = "EXEC DatosFacturaCompra " + NumFac;
                DS = Utilidades.Utilidades.Ejecutar(CMD);
                FacturaCompra obj = new FacturaCompra();
                obj.reportViewer1.LocalReport.DataSources[0].Value = DS.Tables[0];
                obj.ShowDialog();
            }

        }

        void Nuevo()
        {
            total = 0;
            txt_codsup.Enabled = true;
            btn_ConsSup.Enabled = true;
            dataGridView1.Rows.Clear();
            Cont_filas = 0;
            txt_codsup.Text = "";
            txt_nomsup.Text = "";
            LimpiarCampos();
        }
        
        void LimpiarCampos()
        {
            txt_Cant.Text = "";
            txt_CodArt.Text = "";
            txt_NomArt.Text = "";
            txt_PreVen.Text = "";
            txt_total.Text = "0,00";
            txt_Cant.Text = "";
        }

        private void txt_Cant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Salvar();
            }
        }

        private void txt_Cant_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txt_Cant.Text.Length == 1)
                {
                    if (Convert.ToChar(txt_Cant.Text.ToString()) == '0')
                    {
                        txt_Cant.Text = "";
                    }
                }
            }
            catch (Exception a) { }
        }


    }
}
