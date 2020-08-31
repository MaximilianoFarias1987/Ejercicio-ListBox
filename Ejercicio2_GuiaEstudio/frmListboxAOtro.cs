using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_GuiaEstudio
{
    public partial class frmListboxAOtro : Form
    {

        
        public frmListboxAOtro()
        {
            InitializeComponent();
        }
        
        
        //Metodo para indicar que ya se ah ingresado los 12 registros

        public void RegistrosCompletos()
        {
            if (lstMeses1.Items.Count > 12)
            {
                lblCont1.Text = 12.ToString();
                lstMeses1.Items.RemoveAt(12);
                MessageBox.Show("Ha completado los 12 registros");
            }
        }

        //Metodo que utilizo para que todos los botones esten deshabilitados cuando las listas esten vacias 
        public void DeshabilitarBotones()
        {
            btnPasarTodosList2.Enabled = false;
            btnPasarTodosList1.Enabled = false;
            btnPasar1list2.Enabled = false;
            btnPasar1List1.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //if (chkSeptiembre.Checked) lstMeses1.Items.Add(chkSeptiembre.Text);
            if (this.txtMeses.Text == "") //Si txtMeses esta vacio, mostrar mensaje
            {
                MessageBox.Show("Ingrese un Mes");
                txtMeses.Focus();
            }
            else
            {
                
                this.lstMeses1.Items.Add(txtMeses.Text);
                this.lblCont1.Text = this.lstMeses1.Items.Count.ToString();
                this.lblCont1.ForeColor = Color.Green;
                this.btnPasarTodosList2.ForeColor = Color.Green;
                this.btnPasarTodosList2.Enabled = true;
                this.btnLimpiar.Enabled = true;
                this.lblCont2.ForeColor = Color.Red;
                this.txtMeses.Clear();
                this.txtMeses.Focus();
                this.RegistrosCompletos();
                
            }
            
        }

        private void frmListboxAOtro_Load(object sender, EventArgs e)
        {
            txtMeses.Focus();
            this.DeshabilitarBotones();
        }

        private void btnPasarTodosList2_Click(object sender, EventArgs e)
        {
            this.lstMeses2.Items.AddRange(this.lstMeses1.Items);
            this.lblCont2.Text = this.lstMeses2.Items.Count.ToString();
            this.lblCont2.ForeColor = Color.Green;
            this.btnPasarTodosList2.Enabled = false;
            this.btnPasarTodosList1.Enabled = true;
            this.lstMeses1.Items.Clear();
            this.lblCont1.Text = this.lstMeses1.Items.Count.ToString();
            this.lblCont1.ForeColor = Color.Red;
            this.btnPasarTodosList1.ForeColor = Color.Green;
        }

        private void btnPasar1list2_Click(object sender, EventArgs e)
        {
            if (this.lstMeses1.SelectedIndex >= 0) //Si hay un item seleccionado, hacer lo siguiente.
            {
                this.lstMeses2.Items.Add(this.lstMeses1.SelectedItem);
                this.lblCont2.Text = this.lstMeses2.Items.Count.ToString();
                this.lblCont2.ForeColor = Color.Green;
                this.lstMeses1.Items.RemoveAt(this.lstMeses1.SelectedIndex);
                this.lblCont1.Text = this.lstMeses1.Items.Count.ToString();
                this.btnPasar1list2.Enabled = false; //despues de pasar q vuelva a quedar deshabilitado
                this.btnPasarTodosList1.Enabled = true;
                this.btnPasarTodosList1.ForeColor = Color.Green;
                //Ahora condicion si la lista de meses 1 no contienen ningun item, deshabilitar el boton para pasar todo a la lista 2.
                if (lstMeses1.Items.Count == 0)
                {
                    btnPasarTodosList2.Enabled = false;
                    lblCont1.ForeColor = Color.Red;
                }
                    
            }
            else
            {
                MessageBox.Show("Seleccione un Mes de la Lista 1");
            }
        }

        private void btnPasar1List1_Click(object sender, EventArgs e)
        {
            if (this.lstMeses2.SelectedIndex >= 0)
            {
                this.lstMeses1.Items.Add(this.lstMeses2.SelectedItem);
                this.lblCont1.Text = this.lstMeses1.Items.Count.ToString();
                lblCont1.ForeColor = Color.Green;
                this.lstMeses2.Items.RemoveAt(this.lstMeses2.SelectedIndex);
                this.lblCont2.Text = this.lstMeses2.Items.Count.ToString();
                this.btnPasar1List1.Enabled = false;
                this.btnPasarTodosList2.Enabled = true;
                this.btnPasarTodosList2.ForeColor = Color.Green;
                if (lstMeses2.Items.Count == 0)
                {
                    btnPasarTodosList1.Enabled = false;
                    lblCont2.ForeColor = Color.Red;
                }
                    
            }
            else
            {
                MessageBox.Show("Seleccione un Mes de la Lista 2");
            }
        }

        private void btnPasarTodosList1_Click(object sender, EventArgs e)
        {
            this.lstMeses1.Items.AddRange(this.lstMeses2.Items);
            this.lblCont1.Text = this.lstMeses1.Items.Count.ToString();
            this.lblCont1.ForeColor = Color.Green;
            this.btnPasarTodosList1.Enabled = false;
            this.btnPasarTodosList2.Enabled = true;
            this.lstMeses2.Items.Clear();
            this.lblCont2.Text = this.lstMeses2.Items.Count.ToString();
            this.lblCont2.ForeColor = Color.Red;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (this.lstMeses1.Items.Count > 0 || this.lstMeses2.Items.Count > 0)
            {
                this.lstMeses1.Items.Clear();
                this.lstMeses2.Items.Clear();
                this.lblCont1.Text = this.lstMeses1.Items.Count.ToString();
                this.lblCont1.ForeColor = Color.Red;
                this.lblCont2.Text = this.lstMeses2.Items.Count.ToString();
                this.lblCont2.ForeColor = Color.Red;
                this.DeshabilitarBotones();
            }
            else
            {
                MessageBox.Show("Las listas estan vacias");
            }
            
        }

        private void txtMeses_KeyDown(object sender, KeyEventArgs e)
        {
            
                if (e.KeyCode == Keys.Enter) btnAgregar.PerformClick();
            
        }

        private void lstMeses1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMeses1.SelectedIndex >= 0)
            {
                btnPasar1list2.Enabled = true;
                btnPasar1list2.ForeColor = Color.Green;
            }
        }

        private void lstMeses2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMeses2.SelectedIndex >= 0)
            {
                btnPasar1List1.Enabled = true;
                btnPasar1List1.ForeColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             lstMeses1.Items.Remove(lstMeses1.SelectedItem);
             lstMeses2.Items.Remove(lstMeses2.SelectedItem);
        }
    }
}
