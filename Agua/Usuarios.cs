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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.TodosLosRegistros(this.dataSet.Usuarios);

        }

        private void BtnAgreUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuarios AU = new AgregarUsuarios();
            AU.ShowDialog();
            this.usuariosTableAdapter.TodosLosRegistros(this.dataSet.Usuarios);
        }

        private void BtnElimUsuario_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Globalidad.DocUsuario))
            {
                MessageBox.Show("Seleccione el registro a eliminar", "Notificación");
            }
            else
            {
                if(MessageBox.Show("¿Desea eliminar este registro?", "Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    usuariosTableAdapter.EliminarUsuarios(Globalidad.DocUsuario);
                    MessageBox.Show("El registro se ha eliminado satisfactoriamente", "Notificación");
                }
                Globalidad.DocUsuario = string.Empty;
                this.usuariosTableAdapter.TodosLosRegistros(this.dataSet.Usuarios);
            }
        }

        private void usuariosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Globalidad.DocUsuario = (usuariosDataGridView.Rows[e.RowIndex].Cells[2].Value).ToString();
        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            usuariosTableAdapter.BusquedaIndexada(this.dataSet.Usuarios, this.Buscar.Text, this.Buscar.Text);
        }

        private void BtnEditUsuario_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Globalidad.DocUsuario))
            {
                MessageBox.Show("Seleccione el registro a editar", "Notificación");
            }
            else
            {
                EditarUsuarios eu = new EditarUsuarios();
                eu.ShowDialog();
                this.usuariosTableAdapter.TodosLosRegistros(this.dataSet.Usuarios);
            }
            Globalidad.DocUsuario = string.Empty;
        }

        private void ImprimirUsuarios_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            //Crea una instancia del reporte de crystal 
            CrystalUsuarios reporte = new CrystalUsuarios();

            //Llenamos el table Adapter con la propiedad fill
            this.usuariosTableAdapter.TodosLosRegistros(this.dataSet.Usuarios);

            //Asignamos los datos al reporte a través del método SetDataSource()
            reporte.SetDataSource(this.dataSet);

            Cursor.Current = Cursors.Default;

            //Asignamos reporte al crystal report view
            ReportPrint rp = new ReportPrint();
            rp.crystalReportViewer1.ReportSource = reporte;
            rp.ShowDialog();
            rp.Close();
            
        }
    }
}
