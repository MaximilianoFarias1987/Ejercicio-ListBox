using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColeccionesEjercicio3
{
    public partial class Colecciones3 : Form
    {
        public Colecciones3()
        {
            InitializeComponent();
        }

        private void Colecciones3_Load(object sender, EventArgs e)
        {
            Empleados empleado = new Empleados();
            //string[] Empleados = new string[4];
            //Empleados[0] = "Martin";
            //Empleados[1] = "Juan";
            //Empleados[2] = "Julia";
            //Empleados[3] = "Martina";

            for (int i = 0; i < empleado.Empleado1.Length; i++)
            {
                lstEmpleados.Items.Add(empleado.Empleado1[i]);
                lblCountEmpleados.Text = lstEmpleados.Items.Count.ToString();
            }


            //double[] Sueldos = new double[10] { 1000, 1200, 1300, 1400, 1500, 1600, 1700, 1800, 1900, 2000 };

            for (int i = 0; i < empleado.Sueldo1.Length; i++)
            {
                lstSueldos.Items.Add(empleado.Sueldo1[i]);
                lblCountSueldos.Text = lstSueldos.Items.Count.ToString();
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtEmpleado.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un Empleado");
                txtEmpleado.Focus();
            }
            else
            {
                lstEmpleados.Items.Add(txtEmpleado.Text);
                lblCountEmpleados.Text = lstEmpleados.Items.Count.ToString();
                txtEmpleado.Clear();
                txtEmpleado.Focus();
            }
        }

        private void label3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lstEmpleados.SelectedIndex >= 0)
            {
                lstEmpleados.Items.RemoveAt(lstEmpleados.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Debe seleccionar el Empleado que desea Quitar");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblCountEmpleados.Text) == 0 && int.Parse(lblCountSueldos.Text) == 0 && int.Parse(lblCountNuevo.Text) == 0)
            {
                MessageBox.Show("Las listas estan vacias");
                txtEmpleado.Focus();
            }
            else 
            {
                lstEmpleados.Items.Clear();
                lstSueldos.Items.Clear();
                lstNuevoSueldo.Items.Clear();
                lblCountEmpleados.Text = lstEmpleados.Items.Count.ToString();
                lblCountSueldos.Text = lstSueldos.Items.Count.ToString();
                lblCountNuevo.Text = lstNuevoSueldo.Items.Count.ToString();
                label3.ForeColor = Color.Black;
                txtEmpleado.Focus();
            }
        }

        private void btnAumento_Click(object sender, EventArgs e)
        {
            
            if (lstEmpleados.SelectedIndex >= 0 && lstSueldos.SelectedIndex >= 0)
            {
                double aumento;
                double ListaSueldos = Convert.ToDouble(lstSueldos.SelectedItem);
                aumento = ListaSueldos * 1.25;

                lstNuevoSueldo.Items.Add(lstEmpleados.SelectedItem + " " + aumento.ToString());
                lblCountNuevo.Text = lstNuevoSueldo.Items.Count.ToString();
                label3.ForeColor = Color.Green;
                lstNuevoSueldo.SelectedItem = false;
                txtEmpleado.Focus();
            }
            else
            {
                MessageBox.Show("No hay elementos seleccionados");
            }
        }

        private void txtEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter) btnAgregar.PerformClick();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
