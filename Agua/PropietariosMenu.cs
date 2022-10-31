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
    public partial class PropietariosMenu : Form
    {
        string cedulaProp;
        public PropietariosMenu()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void propietariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.propietariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void PropietariosMenu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Propietarios' Puede moverla o quitarla según sea necesario.
            this.propietariosTableAdapter.TodosLosRegistros(this.dataSet.Propietarios);

        }

        private void BtnAgrePropietario_Click(object sender, EventArgs e)
        {
            AgregarPropietario au = new AgregarPropietario();
            au.ShowDialog();
            this.propietariosTableAdapter.TodosLosRegistros(this.dataSet.Propietarios);
        }

        private void BtnEditPropietario_Click(object sender, EventArgs e)
        {
            EditarPropietario au = new EditarPropietario();
            au.ShowDialog();
            this.propietariosTableAdapter.TodosLosRegistros(this.dataSet.Propietarios);


            //if (string.IsNullOrEmpty(Globales.DocPropietario))
            //{
            //    MessageBox.Show("Por favor seleccione un registro", "Notificación");
            //}
            //else
            //{
            //    EditarPropietario eu = new EditarPropietario();
            //    eu.ShowDialog();
            //}
            //Globales.DocPropietario = string.Empty;
            //this.propietariosTableAdapter.TodosLosRegistros(this.dataSet.Propietarios);

        }

        private void BtnElimPropietario_Click(object sender, EventArgs e)
        {
        //    if (bindingNavigatorPositionItem.Text == cedulaProp)
        //    {
        //        propietariosTableAdapter.EliminarPropietarios(cedulaProp);
        //        MessageBox.Show("El registro se ha eliminado satisfactoriamente", "Notificación");
        //    }
           
        //}

        //private void propietariosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int posicion = propietariosDataGridView.CurrentRow.Index;

        //    cedulaProp = (propietariosDataGridView.CurrentRow.Cells[1].Value.ToString());

        }
    }
}
