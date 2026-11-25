using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDisenoLavadero
{
    public partial class frmLavados : Form
    {

        public frmLavados()
        {
            InitializeComponent();
            btnRegistrar.Click += btnRegistrar_Click;
        }

        private void grbImporte_Enter(object sender, EventArgs e)
        {

        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            int cantidad;
            decimal subtotal;
            decimal recargo = 0;
            decimal descuento;
            decimal total;
            int porcentajeDescuento = 0;

            // 1. VALIDAR NOMBRE
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del cliente");
                txtNombre.Focus();
                return;
            }

            // 2. VALIDAR PATENTE
            if (txtPatente.Text.Length < 6 ||
                txtPatente.Text.Length > 7)
            {
                MessageBox.Show("La patente debe tener 6 o 7 caracteres");
                txtPatente.Focus();
                return;
            }

            // 3. VALIDAR SERVICIO
            if (cboServicio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un servicio");
                cboServicio.Focus();
                return;
            }

            // 4. VALIDAR CANTIDAD
            if (cboCantidad.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad de vehículos");
                cboCantidad.Focus();
                return;
            }

            if (!int.TryParse(cboCantidad.Text, out cantidad) ||
                cantidad < 1 || cantidad > 5)
            {
                MessageBox.Show("La cantidad debe estar entre 1 y 5");
                cboCantidad.Focus();
                return;
            }

            // 5. VALIDAR ENTREGA
            if (!rdbNormal.Checked && !rdbExpress.Checked)
            {
                MessageBox.Show("Seleccione el tipo de entrega");
                return;
            }

            // 6. OBTENER PRECIO SEGUN SERVICIO
            switch (cboServicio.Text)
            {
                case "Lavado exterior ($ 8.000)":
                    precio = 8000;
                    break;

                case "Lavado completo ($ 14.000)":
                    precio = 14000;
                    break;

                case "Lavado con encerado ($ 20.000)":
                    precio = 20000;
                    break;

                default:
                    MessageBox.Show("Servicio no válido");
                    cboServicio.Focus();
                    return;
            }

            // 7. CALCULAR SUBTOTAL
            subtotal = precio * cantidad;

            // 8. CALCULAR RECARGO EXPRESS DEL 25%
            if (rdbExpress.Checked)
            {
                recargo = subtotal * 0.25m;
            }

            // 9. CALCULAR DESCUENTO POR CANTIDAD
            if (cantidad >= 2 && cantidad <= 3)
            {
                porcentajeDescuento = 10;
            }
            else if (cantidad >= 4 && cantidad <= 5)
            {
                porcentajeDescuento = 15;
            }

            // 10. DESCUENTO CLIENTE FRECUENTE DEL 5%
            if (chkCliente.Checked)
            {
                porcentajeDescuento += 5;
            }

            // 11. CALCULAR IMPORTE DEL DESCUENTO
            descuento = subtotal * porcentajeDescuento / 100;

            // 12. CALCULAR TOTAL
            total = subtotal + recargo - descuento;

            // 13. MOSTRAR RESULTADOS
            lblSubtotal.Text = subtotal.ToString("N2");
            lblRecargo.Text = recargo.ToString("N2");

            lblDescuento.Text = porcentajeDescuento +
                "% - " + descuento.ToString("N2");

            lblTotal.Text = total.ToString("N2");




        }

        private void cboServicio_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Verificar que se haya calculado el importe
            if (lblTotal.Text == "" || lblTotal.Text == "Total")
            {
                MessageBox.Show("Primero debe calcular el lavado");
                return;
            }

            string entrega;
            string frecuente;

            if (rdbExpress.Checked)
                entrega = "Express";
            else
                entrega = "Normal";

            if (chkCliente.Checked)
                frecuente = "Sí";
            else
                frecuente = "No";

            // Agregar los datos al ListBox
            lstLavados.Items.Add(
                "Cliente: " + txtNombre.Text +
                " | Patente: " + txtPatente.Text +
                " | Servicio: " + cboServicio.Text +
                " | Cantidad: " + cboCantidad.Text +
                " | Entrega: " + entrega +
                " | Frecuente: " + frecuente +
                " | Recargo: " + lblRecargo.Text +
                " | Descuento: " + lblDescuento.Text +
                " | Total: " + lblTotal.Text
            );

            MessageBox.Show("Lavado registrado correctamente");
        }

        private void frmLavados_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar datos del cliente
            txtNombre.Clear();
            txtPatente.Clear();

            // Limpiar selecciones
            cboServicio.SelectedIndex = -1;
            cboCantidad.SelectedIndex = -1;

            // Desmarcar opciones
            rdbNormal.Checked = false;
            rdbExpress.Checked = false;
            chkCliente.Checked = false;

            // Limpiar importes
            lblSubtotal.Text = "0,00";
            lblRecargo.Text = "0,00";
            lblDescuento.Text = "0,00";
            lblTotal.Text = "0,00";

            // Volver al campo nombre
            txtNombre.Focus();
        }
    }
}
