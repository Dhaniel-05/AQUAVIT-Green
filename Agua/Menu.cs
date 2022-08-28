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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }

        private void AbrirFormHijo(object formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0) // se crea una condicional con el nombre del panel contenedor, que es donde está el logo grande
                this.PanelContenedor.Controls.RemoveAt(0); // en estas líneas de código se pregunta si existen controles en el panel contenedor, si es así se elimina pues si no, no funciona
            Form fh = formhijo as Form; // en esta línea se creo un formulario con el nombre fh, el cual va a ser igual al objeto que recibe la función y a este objeto lo convertimos en formulario con la palabra as.
            fh.TopLevel = false; // con esto decimos que no es un formulario de nivel superior, sino que es un formulario secundario.
            fh.Dock = DockStyle.Fill; // con esto hacemos que se acomple a todo el panel contenedor.
            this.PanelContenedor.Controls.Add(fh); // aquí se agrega al panel contenedor.
            this.PanelContenedor.Tag = fh; // se establece la instancia como contenedor de datos del panel.
            fh.Show(); // con esto traemos o monstramos el formulario.
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Usuarios());
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            // AbrirFormHijo(new EditarUsuarios()); llamar el formulario clientes y borrar editar usuarios

        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Propietario());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Acerca());
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (this.PanelMenuVertical.Width == 137) //Aquí se juega con el ancho del PanelMenuVertical
            {
                this.PanelMenuVertical.Width = 45;
                this.pictureBox1.Visible = false;
            }
            else
            {
                this.PanelMenuVertical.Width = 137;
                this.pictureBox1.Visible = true; 
            }
        }
    }
}
