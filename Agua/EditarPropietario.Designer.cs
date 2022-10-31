
namespace Agua
{
    partial class EditarPropietario
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
            this.BtnEditar = new System.Windows.Forms.Label();
            this.documentoLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.celularLabel = new System.Windows.Forms.Label();
            this.correLabel = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Label();
            this.idpropietarioLabel = new System.Windows.Forms.Label();
            this.documentoTextBox = new System.Windows.Forms.TextBox();
            this.dataSet = new Agua.DataSet();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnEPSalir = new System.Windows.Forms.Button();
            this.BtnEditUser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.idPropietarioTextBox = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new Agua.DataSetTableAdapters.TableAdapterManager();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.propietariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propietariosTableAdapter = new Agua.DataSetTableAdapters.PropietariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propietariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEditar
            // 
            this.BtnEditar.AutoSize = true;
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnEditar.Location = new System.Drawing.Point(24, 197);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(105, 13);
            this.BtnEditar.TabIndex = 66;
            this.BtnEditar.Text = "Editar Propietario";
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // documentoLabel
            // 
            this.documentoLabel.AutoSize = true;
            this.documentoLabel.Location = new System.Drawing.Point(12, 62);
            this.documentoLabel.Name = "documentoLabel";
            this.documentoLabel.Size = new System.Drawing.Size(65, 13);
            this.documentoLabel.TabIndex = 61;
            this.documentoLabel.Text = "Documento:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(12, 88);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(47, 13);
            this.nombreLabel.TabIndex = 62;
            this.nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(12, 114);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(55, 13);
            this.direccionLabel.TabIndex = 63;
            this.direccionLabel.Text = "Dirección:";
            // 
            // celularLabel
            // 
            this.celularLabel.AutoSize = true;
            this.celularLabel.Location = new System.Drawing.Point(12, 140);
            this.celularLabel.Name = "celularLabel";
            this.celularLabel.Size = new System.Drawing.Size(42, 13);
            this.celularLabel.TabIndex = 64;
            this.celularLabel.Text = "Celular:";
            // 
            // correLabel
            // 
            this.correLabel.AutoSize = true;
            this.correLabel.Location = new System.Drawing.Point(12, 167);
            this.correLabel.Name = "correLabel";
            this.correLabel.Size = new System.Drawing.Size(35, 13);
            this.correLabel.TabIndex = 65;
            this.correLabel.Text = "Corre:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AutoSize = true;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnCancelar.Location = new System.Drawing.Point(226, 197);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(57, 13);
            this.BtnCancelar.TabIndex = 55;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // idpropietarioLabel
            // 
            this.idpropietarioLabel.AutoSize = true;
            this.idpropietarioLabel.Location = new System.Drawing.Point(8, 17);
            this.idpropietarioLabel.Name = "idpropietarioLabel";
            this.idpropietarioLabel.Size = new System.Drawing.Size(72, 13);
            this.idpropietarioLabel.TabIndex = 69;
            this.idpropietarioLabel.Text = "Id Propietario:";
            // 
            // documentoTextBox
            // 
            this.documentoTextBox.Location = new System.Drawing.Point(83, 59);
            this.documentoTextBox.Name = "documentoTextBox";
            this.documentoTextBox.Size = new System.Drawing.Size(194, 20);
            this.documentoTextBox.TabIndex = 49;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.Location = new System.Drawing.Point(83, 85);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(194, 20);
            this.nombreTextBox.TabIndex = 50;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.direccionTextBox.Location = new System.Drawing.Point(83, 111);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(194, 20);
            this.direccionTextBox.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.BtnEPSalir);
            this.panel1.Controls.Add(this.BtnEditUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 31);
            this.panel1.TabIndex = 58;
            // 
            // BtnEPSalir
            // 
            this.BtnEPSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEPSalir.FlatAppearance.BorderSize = 0;
            this.BtnEPSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEPSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEPSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEPSalir.Location = new System.Drawing.Point(569, 4);
            this.BtnEPSalir.Name = "BtnEPSalir";
            this.BtnEPSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnEPSalir.TabIndex = 9;
            this.BtnEPSalir.Text = "Regresar";
            this.BtnEPSalir.UseVisualStyleBackColor = true;
            this.BtnEPSalir.Click += new System.EventHandler(this.BtnEPSalir_Click);
            // 
            // BtnEditUser
            // 
            this.BtnEditUser.AutoSize = true;
            this.BtnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditUser.ForeColor = System.Drawing.Color.White;
            this.BtnEditUser.Location = new System.Drawing.Point(12, 8);
            this.BtnEditUser.Name = "BtnEditUser";
            this.BtnEditUser.Size = new System.Drawing.Size(120, 15);
            this.BtnEditUser.TabIndex = 3;
            this.BtnEditUser.Text = "Editar Propietario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(350, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(277, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.idpropietarioLabel);
            this.panel2.Controls.Add(this.idPropietarioTextBox);
            this.panel2.Location = new System.Drawing.Point(83, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 10);
            this.panel2.TabIndex = 69;
            // 
            // idPropietarioTextBox
            // 
            this.idPropietarioTextBox.Enabled = false;
            this.idPropietarioTextBox.Location = new System.Drawing.Point(86, 14);
            this.idPropietarioTextBox.Name = "idPropietarioTextBox";
            this.idPropietarioTextBox.Size = new System.Drawing.Size(121, 20);
            this.idPropietarioTextBox.TabIndex = 70;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PropietariosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Agua.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // correoTextBox
            // 
            this.correoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.correoTextBox.Location = new System.Drawing.Point(83, 167);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(194, 20);
            this.correoTextBox.TabIndex = 70;
            // 
            // celularTextBox
            // 
            this.celularTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.celularTextBox.Location = new System.Drawing.Point(83, 140);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(194, 20);
            this.celularTextBox.TabIndex = 71;
            // 
            // propietariosBindingSource
            // 
            this.propietariosBindingSource.DataMember = "Propietarios";
            this.propietariosBindingSource.DataSource = this.dataSet;
            // 
            // propietariosTableAdapter
            // 
            this.propietariosTableAdapter.ClearBeforeFill = true;
            // 
            // EditarPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(647, 374);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.documentoTextBox);
            this.Controls.Add(this.documentoLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.celularLabel);
            this.Controls.Add(this.correLabel);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarPropietario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.EditarPropietario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propietariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox documentoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnEPSalir;
        private System.Windows.Forms.Label BtnEditUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DataSet dataSet;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox idPropietarioTextBox;
        private System.Windows.Forms.Label BtnEditar;
        private System.Windows.Forms.Label documentoLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.Label celularLabel;
        private System.Windows.Forms.Label correLabel;
        private System.Windows.Forms.Label BtnCancelar;
        private System.Windows.Forms.Label idpropietarioLabel;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.BindingSource propietariosBindingSource;
        private DataSetTableAdapters.PropietariosTableAdapter propietariosTableAdapter;
    }


       

    }
