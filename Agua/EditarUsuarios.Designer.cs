namespace Agua
{
    partial class EditarUsuarios
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
            System.Windows.Forms.Label BtnEditar;
            System.Windows.Forms.Label documentoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label rolLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label BtnCancelar;
            System.Windows.Forms.Label idUsuarioLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUsuarios));
            this.Cedula = new System.Windows.Forms.TextBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Agua.DataSet();
            this.Nombres = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Roles = new System.Windows.Forms.ComboBox();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAUSalir = new System.Windows.Forms.Button();
            this.BtnEditUser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usuariosTableAdapter = new Agua.DataSetTableAdapters.UsuariosTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.idUsuarioTextBox1 = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new Agua.DataSetTableAdapters.TableAdapterManager();
            BtnEditar = new System.Windows.Forms.Label();
            documentoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            rolLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            BtnCancelar = new System.Windows.Forms.Label();
            idUsuarioLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEditar
            // 
            BtnEditar.AutoSize = true;
            BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BtnEditar.ForeColor = System.Drawing.Color.RoyalBlue;
            BtnEditar.Location = new System.Drawing.Point(24, 197);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new System.Drawing.Size(87, 13);
            BtnEditar.TabIndex = 66;
            BtnEditar.Text = "Editar Usuario";
            BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // documentoLabel
            // 
            documentoLabel.AutoSize = true;
            documentoLabel.Location = new System.Drawing.Point(12, 62);
            documentoLabel.Name = "documentoLabel";
            documentoLabel.Size = new System.Drawing.Size(65, 13);
            documentoLabel.TabIndex = 61;
            documentoLabel.Text = "Documento:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 88);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 62;
            nombreLabel.Text = "Nombre:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(12, 114);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 63;
            usuarioLabel.Text = "Usuario:";
            // 
            // rolLabel
            // 
            rolLabel.AutoSize = true;
            rolLabel.Location = new System.Drawing.Point(12, 140);
            rolLabel.Name = "rolLabel";
            rolLabel.Size = new System.Drawing.Size(26, 13);
            rolLabel.TabIndex = 64;
            rolLabel.Text = "Rol:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(12, 167);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 65;
            passwordLabel.Text = "Password:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.AutoSize = true;
            BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BtnCancelar.ForeColor = System.Drawing.Color.RoyalBlue;
            BtnCancelar.Location = new System.Drawing.Point(226, 197);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new System.Drawing.Size(57, 13);
            BtnCancelar.TabIndex = 55;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // idUsuarioLabel1
            // 
            idUsuarioLabel1.AutoSize = true;
            idUsuarioLabel1.Location = new System.Drawing.Point(8, 17);
            idUsuarioLabel1.Name = "idUsuarioLabel1";
            idUsuarioLabel1.Size = new System.Drawing.Size(58, 13);
            idUsuarioLabel1.TabIndex = 69;
            idUsuarioLabel1.Text = "Id Usuario:";
            // 
            // Cedula
            // 
            this.Cedula.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Documento", true));
            this.Cedula.Location = new System.Drawing.Point(83, 59);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(194, 20);
            this.Cedula.TabIndex = 49;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Nombres
            // 
            this.Nombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Nombres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Nombre", true));
            this.Nombres.Location = new System.Drawing.Point(83, 85);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(194, 20);
            this.Nombres.TabIndex = 50;
            // 
            // Usuario
            // 
            this.Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Usuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Usuario", true));
            this.Usuario.Location = new System.Drawing.Point(83, 111);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(194, 20);
            this.Usuario.TabIndex = 51;
            // 
            // Roles
            // 
            this.Roles.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Rol", true));
            this.Roles.FormattingEnabled = true;
            this.Roles.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "FACTURADOR",
            "GRABADOR"});
            this.Roles.Location = new System.Drawing.Point(83, 137);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(194, 21);
            this.Roles.TabIndex = 52;
            this.Roles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Roles_KeyPress);
            // 
            // Contraseña
            // 
            this.Contraseña.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Password", true));
            this.Contraseña.Location = new System.Drawing.Point(83, 164);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PasswordChar = 'o';
            this.Contraseña.Size = new System.Drawing.Size(194, 20);
            this.Contraseña.TabIndex = 53;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.BtnAUSalir);
            this.panel1.Controls.Add(this.BtnEditUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 31);
            this.panel1.TabIndex = 58;
            // 
            // BtnAUSalir
            // 
            this.BtnAUSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAUSalir.FlatAppearance.BorderSize = 0;
            this.BtnAUSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAUSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAUSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAUSalir.Location = new System.Drawing.Point(549, 4);
            this.BtnAUSalir.Name = "BtnAUSalir";
            this.BtnAUSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnAUSalir.TabIndex = 9;
            this.BtnAUSalir.Text = "Regresar";
            this.BtnAUSalir.UseVisualStyleBackColor = true;
            this.BtnAUSalir.Click += new System.EventHandler(this.BtnAUSalir_Click);
            // 
            // BtnEditUser
            // 
            this.BtnEditUser.AutoSize = true;
            this.BtnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditUser.ForeColor = System.Drawing.Color.White;
            this.BtnEditUser.Location = new System.Drawing.Point(12, 8);
            this.BtnEditUser.Name = "BtnEditUser";
            this.BtnEditUser.Size = new System.Drawing.Size(99, 15);
            this.BtnEditUser.TabIndex = 3;
            this.BtnEditUser.Text = "Editar Usuario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(350, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(277, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(idUsuarioLabel1);
            this.panel2.Controls.Add(this.idUsuarioTextBox1);
            this.panel2.Location = new System.Drawing.Point(83, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 13);
            this.panel2.TabIndex = 69;
            // 
            // idUsuarioTextBox1
            // 
            this.idUsuarioTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "IdUsuario", true));
            this.idUsuarioTextBox1.Enabled = false;
            this.idUsuarioTextBox1.Location = new System.Drawing.Point(72, 14);
            this.idUsuarioTextBox1.Name = "idUsuarioTextBox1";
            this.idUsuarioTextBox1.Size = new System.Drawing.Size(121, 20);
            this.idUsuarioTextBox1.TabIndex = 70;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Agua.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // EditarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(627, 229);
            this.Controls.Add(this.panel2);
            this.Controls.Add(BtnEditar);
            this.Controls.Add(this.Cedula);
            this.Controls.Add(documentoLabel);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(rolLabel);
            this.Controls.Add(this.Roles);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(BtnCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.EditarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cedula;
        private System.Windows.Forms.TextBox Nombres;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.ComboBox Roles;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAUSalir;
        private System.Windows.Forms.Label BtnEditUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox idUsuarioTextBox1;
    }
}