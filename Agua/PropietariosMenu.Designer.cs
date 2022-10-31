namespace Agua
{
    partial class PropietariosMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropietariosMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.propietariosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnAgrePropietario = new System.Windows.Forms.ToolStripButton();
            this.BtnEditPropietario = new System.Windows.Forms.ToolStripButton();
            this.BtnElimPropietario = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BuscarPropietario = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ImprimirPropietarios = new System.Windows.Forms.ToolStripButton();
            this.propietariosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propietariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Agua.DataSet();
            this.propietariosTableAdapter = new Agua.DataSetTableAdapters.PropietariosTableAdapter();
            this.tableAdapterManager = new Agua.DataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propietariosBindingNavigator)).BeginInit();
            this.propietariosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propietariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propietariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 25);
            this.panel1.TabIndex = 1;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(577, 1);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(66, 23);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Regresar";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Propietarios";
            // 
            // propietariosBindingNavigator
            // 
            this.propietariosBindingNavigator.AddNewItem = null;
            this.propietariosBindingNavigator.BindingSource = this.propietariosBindingSource;
            this.propietariosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.propietariosBindingNavigator.DeleteItem = null;
            this.propietariosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.BtnAgrePropietario,
            this.BtnEditPropietario,
            this.BtnElimPropietario,
            this.toolStripSeparator1,
            this.BuscarPropietario,
            this.toolStripSeparator2,
            this.ImprimirPropietarios});
            this.propietariosBindingNavigator.Location = new System.Drawing.Point(0, 25);
            this.propietariosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.propietariosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.propietariosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.propietariosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.propietariosBindingNavigator.Name = "propietariosBindingNavigator";
            this.propietariosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.propietariosBindingNavigator.Size = new System.Drawing.Size(643, 25);
            this.propietariosBindingNavigator.TabIndex = 2;
            this.propietariosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnAgrePropietario
            // 
            this.BtnAgrePropietario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAgrePropietario.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgrePropietario.Image")));
            this.BtnAgrePropietario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAgrePropietario.Name = "BtnAgrePropietario";
            this.BtnAgrePropietario.Size = new System.Drawing.Size(23, 22);
            this.BtnAgrePropietario.Text = "Agregar Usuario";
            this.BtnAgrePropietario.Click += new System.EventHandler(this.BtnAgrePropietario_Click);
            // 
            // BtnEditPropietario
            // 
            this.BtnEditPropietario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEditPropietario.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditPropietario.Image")));
            this.BtnEditPropietario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditPropietario.Name = "BtnEditPropietario";
            this.BtnEditPropietario.Size = new System.Drawing.Size(23, 22);
            this.BtnEditPropietario.Text = "Editar Usuario";
            this.BtnEditPropietario.Click += new System.EventHandler(this.BtnEditPropietario_Click);
            // 
            // BtnElimPropietario
            // 
            this.BtnElimPropietario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnElimPropietario.Image = ((System.Drawing.Image)(resources.GetObject("BtnElimPropietario.Image")));
            this.BtnElimPropietario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnElimPropietario.Name = "BtnElimPropietario";
            this.BtnElimPropietario.Size = new System.Drawing.Size(23, 22);
            this.BtnElimPropietario.Text = "Eliminar Usuario";
            this.BtnElimPropietario.Click += new System.EventHandler(this.BtnElimPropietario_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BuscarPropietario
            // 
            this.BuscarPropietario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BuscarPropietario.Name = "BuscarPropietario";
            this.BuscarPropietario.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ImprimirPropietarios
            // 
            this.ImprimirPropietarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ImprimirPropietarios.Image = ((System.Drawing.Image)(resources.GetObject("ImprimirPropietarios.Image")));
            this.ImprimirPropietarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImprimirPropietarios.Name = "ImprimirPropietarios";
            this.ImprimirPropietarios.Size = new System.Drawing.Size(23, 22);
            this.ImprimirPropietarios.Text = "Imprimir";
            // 
            // propietariosDataGridView
            // 
            this.propietariosDataGridView.AutoGenerateColumns = false;
            this.propietariosDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.propietariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propietariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.propietariosDataGridView.DataSource = this.propietariosBindingSource;
            this.propietariosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propietariosDataGridView.Location = new System.Drawing.Point(0, 50);
            this.propietariosDataGridView.Name = "propietariosDataGridView";
            this.propietariosDataGridView.Size = new System.Drawing.Size(643, 286);
            this.propietariosDataGridView.TabIndex = 2;
            //this.propietariosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.propietariosDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdPropietario";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdPropietario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Documento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Documento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Celular";
            this.dataGridViewTextBoxColumn5.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // propietariosBindingSource
            // 
            this.propietariosBindingSource.DataMember = "Propietarios";
            this.propietariosBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propietariosTableAdapter
            // 
            this.propietariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PropietariosTableAdapter = this.propietariosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Agua.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // PropietariosMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(643, 336);
            this.Controls.Add(this.propietariosDataGridView);
            this.Controls.Add(this.propietariosBindingNavigator);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropietariosMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PropietariosMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propietariosBindingNavigator)).EndInit();
            this.propietariosBindingNavigator.ResumeLayout(false);
            this.propietariosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propietariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propietariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource propietariosBindingSource;
        private DataSetTableAdapters.PropietariosTableAdapter propietariosTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator propietariosBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView propietariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripButton BtnAgrePropietario;
        private System.Windows.Forms.ToolStripButton BtnEditPropietario;
        private System.Windows.Forms.ToolStripButton BtnElimPropietario;
        private System.Windows.Forms.ToolStripTextBox BuscarPropietario;
        private System.Windows.Forms.ToolStripButton ImprimirPropietarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}