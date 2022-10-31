
namespace Agua
{
    partial class AgregarPropietario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPropietario));
            this.BtnCancelarProp = new System.Windows.Forms.Label();
            this.idPropietarioLabel = new System.Windows.Forms.Label();
            this.documentoLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.celularLabel = new System.Windows.Forms.Label();
            this.correoLabel = new System.Windows.Forms.Label();
            this.BtnAgregarProp = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.propietariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Agua.DataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAPSalir = new System.Windows.Forms.Button();
            this.BtnAddProp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.idPropietarioTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.documentoTextBox = new System.Windows.Forms.TextBox();
            this.Notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Agua.DataSetTableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new Agua.DataSetTableAdapters.TableAdapterManager();
            this.propietariosTableAdapter = new Agua.DataSetTableAdapters.PropietariosTableAdapter();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propietariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelarProp
            // 
            this.BtnCancelarProp.AutoSize = true;
            this.BtnCancelarProp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelarProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarProp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnCancelarProp.Location = new System.Drawing.Point(220, 213);
            this.BtnCancelarProp.Name = "BtnCancelarProp";
            this.BtnCancelarProp.Size = new System.Drawing.Size(57, 13);
            this.BtnCancelarProp.TabIndex = 8;
            this.BtnCancelarProp.Text = "Cancelar";
            this.BtnCancelarProp.Click += new System.EventHandler(this.BtnCancelarProp_Click);
            // 
            // idPropietarioLabel
            // 
            this.idPropietarioLabel.AutoSize = true;
            this.idPropietarioLabel.Location = new System.Drawing.Point(6, 51);
            this.idPropietarioLabel.Name = "idPropietarioLabel";
            this.idPropietarioLabel.Size = new System.Drawing.Size(72, 13);
            this.idPropietarioLabel.TabIndex = 35;
            this.idPropietarioLabel.Text = "Id Propietario:";
            // 
            // documentoLabel
            // 
            this.documentoLabel.AutoSize = true;
            this.documentoLabel.Location = new System.Drawing.Point(15, 57);
            this.documentoLabel.Name = "documentoLabel";
            this.documentoLabel.Size = new System.Drawing.Size(65, 13);
            this.documentoLabel.TabIndex = 39;
            this.documentoLabel.Text = "Documento:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(15, 83);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 41;
            this.nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(15, 109);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(55, 13);
            this.direccionLabel.TabIndex = 43;
            this.direccionLabel.Text = "Dirección:";
            // 
            // celularLabel
            // 
            this.celularLabel.AutoSize = true;
            this.celularLabel.Location = new System.Drawing.Point(15, 135);
            this.celularLabel.Name = "celularLabel";
            this.celularLabel.Size = new System.Drawing.Size(42, 13);
            this.celularLabel.TabIndex = 45;
            this.celularLabel.Text = "Celular:";
            // 
            // correoLabel
            // 
            this.correoLabel.AutoSize = true;
            this.correoLabel.Location = new System.Drawing.Point(15, 162);
            this.correoLabel.Name = "correoLabel";
            this.correoLabel.Size = new System.Drawing.Size(41, 13);
            this.correoLabel.TabIndex = 47;
            this.correoLabel.Text = "Correo:";
            // 
            // BtnAgregarProp
            // 
            this.BtnAgregarProp.AutoSize = true;
            this.BtnAgregarProp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarProp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnAgregarProp.Location = new System.Drawing.Point(29, 213);
            this.BtnAgregarProp.Name = "BtnAgregarProp";
            this.BtnAgregarProp.Size = new System.Drawing.Size(51, 13);
            this.BtnAgregarProp.TabIndex = 48;
            this.BtnAgregarProp.Text = "Agregar";
            this.BtnAgregarProp.Click += new System.EventHandler(this.BtnAgregarProp_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.propietariosBindingSource, "IdPropietario", true));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(330, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(277, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.BtnAPSalir);
            this.panel1.Controls.Add(this.BtnAddProp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 31);
            this.panel1.TabIndex = 16;
            // 
            // BtnAPSalir
            // 
            this.BtnAPSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAPSalir.FlatAppearance.BorderSize = 0;
            this.BtnAPSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAPSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAPSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAPSalir.Location = new System.Drawing.Point(529, 4);
            this.BtnAPSalir.Name = "BtnAPSalir";
            this.BtnAPSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnAPSalir.TabIndex = 9;
            this.BtnAPSalir.Text = "Regresar";
            this.BtnAPSalir.UseVisualStyleBackColor = true;
            this.BtnAPSalir.Click += new System.EventHandler(this.BtnAPSalir_Click);
            // 
            // BtnAddProp
            // 
            this.BtnAddProp.AutoSize = true;
            this.BtnAddProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddProp.ForeColor = System.Drawing.Color.White;
            this.BtnAddProp.Location = new System.Drawing.Point(12, 8);
            this.BtnAddProp.Name = "BtnAddProp";
            this.BtnAddProp.Size = new System.Drawing.Size(132, 15);
            this.BtnAddProp.TabIndex = 3;
            this.BtnAddProp.Text = "Agregar Propietario";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.idPropietarioLabel);
            this.panel2.Controls.Add(this.idPropietarioTextBox);
            this.panel2.Location = new System.Drawing.Point(86, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 10);
            this.panel2.TabIndex = 31;
            // 
            // idPropietarioTextBox
            // 
            this.idPropietarioTextBox.Enabled = false;
            this.idPropietarioTextBox.Location = new System.Drawing.Point(84, 48);
            this.idPropietarioTextBox.Name = "idPropietarioTextBox";
            this.idPropietarioTextBox.Size = new System.Drawing.Size(121, 20);
            this.idPropietarioTextBox.TabIndex = 36;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.Location = new System.Drawing.Point(86, 80);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(194, 20);
            this.nombreTextBox.TabIndex = 2;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.direccionTextBox.Location = new System.Drawing.Point(86, 106);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(194, 20);
            this.direccionTextBox.TabIndex = 3;
            // 
            // documentoTextBox
            // 
            this.documentoTextBox.Location = new System.Drawing.Point(86, 54);
            this.documentoTextBox.Name = "documentoTextBox";
            this.documentoTextBox.Size = new System.Drawing.Size(194, 20);
            this.documentoTextBox.TabIndex = 1;
            // 
            // Notificacion
            // 
            this.Notificacion.Text = "El registro se ha guardado exitosamente";
            this.Notificacion.Visible = true;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.dataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PropietariosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Agua.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // propietariosTableAdapter
            // 
            this.propietariosTableAdapter.ClearBeforeFill = true;
            // 
            // celularTextBox
            // 
            this.celularTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.celularTextBox.Location = new System.Drawing.Point(86, 132);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(194, 20);
            this.celularTextBox.TabIndex = 49;
            // 
            // correoTextBox
            // 
            this.correoTextBox.Location = new System.Drawing.Point(86, 159);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(194, 20);
            this.correoTextBox.TabIndex = 50;
            // 
            // AgregarPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 235);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(this.BtnAgregarProp);
            this.Controls.Add(this.documentoTextBox);
            this.Controls.Add(this.documentoLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.celularLabel);
            this.Controls.Add(this.correoLabel);
            this.Controls.Add(this.BtnCancelarProp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarPropietario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarUsuarios";
            this.Load += new System.EventHandler(this.AgregarPropietario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propietariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAPSalir;
        private System.Windows.Forms.Label BtnAddProp;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox idPropietarioTextBox;
        private DataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox documentoTextBox;
        private System.Windows.Forms.NotifyIcon Notificacion;
        private System.Windows.Forms.Label BtnCancelarProp;
        private System.Windows.Forms.Label idPropietarioLabel;
        private System.Windows.Forms.Label documentoLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.Label celularLabel;
        private System.Windows.Forms.Label correoLabel;
        private System.Windows.Forms.Label BtnAgregarProp;
        private System.Windows.Forms.BindingSource propietariosBindingSource;
        private DataSetTableAdapters.PropietariosTableAdapter propietariosTableAdapter;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
    }
}