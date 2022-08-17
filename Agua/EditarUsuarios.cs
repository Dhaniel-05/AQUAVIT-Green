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
    public partial class EditarUsuarios : Form
    {
        public EditarUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void EditarUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.BuscarPorDocumento(this.dataSet.Usuarios, Globalidad.DocUsuario);
            this.Contraseña.Text = Globalidad.Desencriptar(this.Contraseña.Text);

            //Esta línea hace que retorne el documento original en caso de borrar accidentalmente

            Globalidad.DocActual = this.Cedula.Text;

        }

        private void BtnAUSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Roles_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BtnElimFoto_Click(object sender, EventArgs e)
        {
            this.Fotografia.Image = null;
        }

        private void BtnBuscarFoto_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Imagenes|*.jpg;* .jpeg;* .png;* .gif;* .tif";
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            else
            {
                this.Fotografia.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            string doc = (string)this.usuariosTableAdapter.ValidarDocumento(this.Cedula.Text);

            if (string.IsNullOrEmpty(doc) || this.Cedula.Text == Globalidad.DocActual)
            {
                if (Fotografia.Image == null)
                {
                    MessageBox.Show("Agrege una foto", "Notificación");

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
                    try
                    {
                        this.Contraseña.Text = Globalidad.Encriptar(this.Contraseña.Text);

                        this.usuariosTableAdapter.EditarUsuarios(Globalidad.Convertir_Imagen_Bytes(this.Fotografia.Image),
                            this.Cedula.Text, this.Nombres.Text, this.Usuario.Text, this.Roles.Text, this.Contraseña.Text,
                            Convert.ToInt32(this.idUsuarioTextBox1.Text));

                        Globalidad.DocUsuario = string.Empty;
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El registro no se puede guardar", "Notificación");
                    }

                }
            }



            else
            {
                MessageBox.Show("El número de documento ya existe", "Notificación");
                this.Cedula.Text = Globalidad.DocActual;
                this.Cedula.Focus();
            }
        }
    }
}



