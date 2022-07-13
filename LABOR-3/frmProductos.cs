using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace LABOR_3
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }


        private void cargarGrid()
        {
            string[] datos = { "IdProducto", "descripcion", "precio"};
            DataTable informacionProducto = new DataTable();
            informacionProducto = consultar.consultaTodosElementos("productos", datos);
            dgvProducto.DataSource = informacionProducto;
        }


        private dynamic[] insertarDatos()
        {
            dynamic[] datos = new dynamic[3];
            try
            {
                int IdProduto = int.Parse(txtIdProducto.Text);
                string descripcion = txtDescripcion.Text;
                int precio = int.Parse(txtPrecio.Text);
                datos[0] = IdProduto;
                datos[1] = descripcion;
                datos[2] = precio;
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
            string info = consultar.insertar("productos", datos);
            if (info == "ok")
            {
                MessageBox.Show("Datos Ingresados...", "Aceptado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarGrid();
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
            txtIdProducto.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }
    }
}
