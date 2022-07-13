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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private dynamic[] insertarDatos()
        {
            dynamic[] datos = new dynamic[6];
            try
            {
                int IdCliente = int.Parse(txtIdCliente.Text);
                int cedula = int.Parse(txtCedula.Text);
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string sexo = txtSexo.Text;
                string fechaNacimiento = txtFechaNac.Text;
                datos[0] = IdCliente;
                datos[1] = cedula;
                datos[2] = nombre;
                datos[3] = apellido;
                datos[4] = sexo;
                datos[5] = fechaNacimiento;
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
            string info = consultar.insertar("clientes", datos);
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
            txtIdCliente.Clear();
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtSexo.Clear();
            txtFechaNac.Clear();
        }

        private void cargarGrid()
        {
            string[] datos = { "cedula", "nombre", "apellido","fechaNacimiento","sexo" };
            DataTable informacionClientes = new DataTable();
            informacionClientes = consultar.consultaTodosElementos("clientes", datos);
            dgvClientes.DataSource = informacionClientes;
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProductos ventaProductos = new frmProductos();
            ventaProductos.Visible = true;
        }

        private void ingresarComprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCompras ventaCompras = new frmCompras();
            ventaCompras.Visible = true;
        }
    }
}
