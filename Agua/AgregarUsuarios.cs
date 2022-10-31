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
    public partial class AgregarUsuarios : Form
    {
        public AgregarUsuarios()
        {
            InitializeComponent();
        }

        private void BtnAUSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void AgregarUsuarios_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'dataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            //this.usuariosTableAdapter.TodosLosRegistros(this.dataSet.Usuarios);

        }

        private void rolComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rolComboBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string x = (string)this.usuariosTableAdapter.ValidarDocumento(this.Cedula.Text);
            if(!(string.IsNullOrEmpty(x)))
            {
                MessageBox.Show("El número de documento ya existe", "Notificación");
            }
            else if (string.IsNullOrEmpty(this.Cedula.Text))
            {
                MessageBox.Show("Digite la cédula", "Notificación");
                this.Cedula.Focus();
            }
            else if (string.IsNullOrEmpty(Nombres.Text))
            {
                MessageBox.Show("Escriba los nombres completos", "Notificación");
                this.Nombres.Focus();
            }
            else if (string.IsNullOrEmpty(Usuario.Text))
            {
                MessageBox.Show("Digite el usuario o nickname", "Notificación");
                this.Usuario.Focus();
            }
            else if (string.IsNullOrEmpty(Roles.Text))
            {
                MessageBox.Show("Escoja el Rol", "Notificación");
                this.Roles.Focus();
            }
            else if (string.IsNullOrEmpty(Contraseña.Text))
            {
                MessageBox.Show("Digite la contraseña", "Notificación");
                this.Contraseña.Focus();
            }
            else
            {
               
                    this.Contraseña.Text = Globalidad.Encriptar(this.Contraseña.Text);
                    this.usuariosTableAdapter.InsertarUsuarios(this.Cedula.Text, this.Nombres.Text, this.Usuario.Text, this.Roles.Text, this.Contraseña.Text);
                    //Notificacion.ShowBalloonTip(500);
                    MessageBox.Show("Usuario creado con exito");
                
            }
        }

        private void Nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar);
        }
    }
}
