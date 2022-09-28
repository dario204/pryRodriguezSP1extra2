using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezSP1extra2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int intentos=0;
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text!="")
            {
                cboModulo.Enabled= true;
                lblModulo.Enabled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {//1
            if (txtUsuario.Text=="ADM" && txtContraseña.Text=="1@a")
            {
                if (cboModulo.Text=="ADM"||cboModulo.Text=="COM"||cboModulo.Text=="VTA")
                {
                    this.Hide();
                    frmBienvenido f = new frmBienvenido();
                    f.Text=txtUsuario.Text;
                    f.ShowDialog();
                    this.Show();

                }
                else
                {
                    
                    MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                    intentos++;
                    if (intentos==2)
                    {
                      
                        this.Close();
                    }
                }
            }
           //2
            if (txtUsuario.Text=="John"&& txtUsuario.Text=="*2b")
            {
                this.Hide();
                frmBienvenido f = new frmBienvenido();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                intentos++;
                if (intentos==2)
                {
                    this.Close();
                }
            }
            //3
            if (txtUsuario.Text=="Ceci" && txtContraseña.Text=="*@3c")
            {
                if (cboModulo.Text=="ADM"|| cboModulo.Text=="VTA")
                {
                    this.Hide();
                    frmBienvenido f = new frmBienvenido();
                    f.Text = txtUsuario.Text;
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                    intentos++;
                    if (intentos==2)
                    {
                        this.Close();
                    }
                }
            }
            //4
            if (txtUsuario.Text=="God"&&txtContraseña.Text=="*@#4d")
            {
                if (cboModulo.Text == "ADM" || cboModulo.Text == "COM" || cboModulo.Text == "VTA"||cboModulo.Text=="SIST")
                {
                    this.Hide();
                    frmBienvenido f = new frmBienvenido();
                    f.Text = txtUsuario.Text;
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                    intentos++;
                    if (intentos==2)
                    {
                        this.Close();
                    }
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
