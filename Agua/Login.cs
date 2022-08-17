using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agua
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Este cierra todo
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (this.TxtUsuario.Text == "Usuario")

                this.TxtUsuario.Text = string.Empty;
            this.TxtUsuario.ForeColor = Color.Blue;
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TxtUsuario.Text))
            {
                this.TxtUsuario.Text = "Usuario";
                this.TxtUsuario.ForeColor = Color.Blue;
            }
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {

            if (this.TxtContraseña.Text == "Contraseña")
            {
                this.TxtContraseña.Text = string.Empty;
                this.TxtContraseña.ForeColor = Color.Blue;
                this.TxtContraseña.UseSystemPasswordChar = true;
            }
        }


        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TxtContraseña.Text))
            {
                this.TxtContraseña.Text = "Contraseña";
                this.TxtContraseña.ForeColor = Color.Blue;
                this.TxtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.TxtUsuario.Text))
            {
                MessageBox.Show("Digite el usuario", "Notificación");
                this.TxtUsuario.Focus();
            }
            else
            {
                if(string.IsNullOrEmpty(this.TxtContraseña.Text))
                {
                    MessageBox.Show("Digite la contraseña", "Notificación");
                    this.TxtContraseña.Focus();
                }
                else
                {
                    Globalidad.RolLogin = (string)this.usuariosTableAdapter.BuscarRol(this.TxtUsuario.Text, Globalidad.Encriptar(this.TxtContraseña.Text));

                    if(string.IsNullOrEmpty(Globalidad.RolLogin))
                    {
                        MessageBox.Show("Usuario o Contraseña incorrecta", "Error");
                        this.TxtUsuario.Focus();
                    }

                    else
                    {
                        Globalidad.UsuarioActual = (string)this.usuariosTableAdapter.BuscarUsuario(this.TxtUsuario.Text, Globalidad.Encriptar(this.TxtContraseña.Text));

                        Menu m = new Menu();
                        m.ShowDialog();
                    }
                }

            }

        }

        

      
      


        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.TodosLosRegistros(this.dataSet.Usuarios);

        }
    }
}
