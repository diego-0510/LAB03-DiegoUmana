using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace LABOR_3
{
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        private dynamic[] insertarDatos()
        {
            dynamic[] datos = new dynamic[3];
            try
            {
                int idCliente = int.Parse(txtIdCliente.Text);
                int idProduto = int.Parse(txtIdProducto.Text);
                string fechaCompra = txtFechaCompra.Text;
                datos[0] = idCliente;
                datos[1] = idProduto;
                datos[2] = fechaCompra;
                MessageBox.Show("Datos Correctos...", "Aceptado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Datos Incorrectos...", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            dynamic[] datos = insertarDatos();
            string info = consultar.insertar("compras", datos);
            if (info == "ok")
            {
                MessageBox.Show("Datos Ingresados...", "Aceptado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (info == "error")
            {
                MessageBox.Show("Datos No Ingresados...", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtIdCliente.Clear();
            txtIdProducto.Clear();
            txtFechaCompra.Clear();
        }

        private void cargarInformacion(DataTable informacionCompra)
        {
            //txtidClienteBuscar.Text = informacionCompra.Rows[0]["idCliente"].ToString();
            txtIdProductoBuscado.Text = informacionCompra.Rows[0]["idProducto"].ToString();
            txtFechaBuscada.Text = informacionCompra.Rows[0]["fechaCompra"].ToString();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (txtidClienteBuscar.Text == "")
            {
                MessageBox.Show("Agregar Codigo...", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] datos = {"idProducto", "fechaCompra" };
                string condicion = " where idCliente= " + txtidClienteBuscar.Text;
                DataTable informacionCompra = new DataTable();
                informacionCompra = consultar.consultaTodosElementosWhere("compras", datos, condicion);
                cargarInformacion(informacionCompra);
            }
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            
            


        }
    }
}
