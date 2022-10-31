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
    public partial class AgregarPropietario : Form
    {
        public AgregarPropietario()
        {
            InitializeComponent();
        }

        private void BtnAPSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregarProp_Click(object sender, EventArgs e)
        {
            if ((this.propietariosTableAdapter.BuscarPorDocumento(this.dataSet.Propietarios,this.documentoTextBox.Text) != 0))
            {
                MessageBox.Show("El No. Documento ya existe", "Notificación");
                this.documentoTextBox.Focus();
            }
            else
            {

                if (string.IsNullOrEmpty(this.documentoTextBox.Text))
                {
                    MessageBox.Show("Documento requerido", "Notificación");
                    this.documentoTextBox.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.nombreTextBox.Text))
                    {
                        MessageBox.Show("Nombre requerido", "Notificación");
                        this.nombreTextBox.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.direccionTextBox.Text))
                        {
                            MessageBox.Show("Dirección requerida", "Notificación");
                            this.direccionTextBox.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(this.celularTextBox.Text))
                            {
                                MessageBox.Show("Celular requerido", "Notificación");
                                this.celularTextBox.Focus();
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(this.correoTextBox.Text))
                                {
                                    MessageBox.Show("Correo requerido", "Notificación");
                                    this.correoTextBox.Focus();
                                }
                                else
                                {
                                    try
                                    {
                                        this.propietariosTableAdapter.InsertarPropietarios(this.documentoTextBox.Text, this.nombreTextBox.Text, this.direccionTextBox.Text, this.celularTextBox.Text, this.correoTextBox.Text);
                                        this.Close();
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("El registro no se puede guardar en la base de datos", "Notificación");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void AgregarPropietario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Propietarios' Puede moverla o quitarla según sea necesario.
            this.propietariosTableAdapter.TodosLosRegistros(this.dataSet.Propietarios);

        }

        private void BtnCancelarProp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
