namespace Agua
{
    partial class AgregarUsuarios
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
            System.Windows.Forms.Label BtnCancelar;
            System.Windows.Forms.Label idUsuarioLabel1;
            System.Windows.Forms.Label documentoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label rolLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label BtnAgregar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUsuarios));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAUSalir = new System.Windows.Forms.Button();
            this.BtnAddUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.idUsuarioTextBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Nombres = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Roles = new System.Windows.Forms.ComboBox();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Cedula = new System.Windows.Forms.TextBox();
            this.Notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.dataSet = new Agua.DataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Agua.DataSetTableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new Agua.DataSetTableAdapters.TableAdapterManager();
            BtnCancelar = new System.Windows.Forms.Label();
            idUsuarioLabel1 = new System.Windows.Forms.Label();
            documentoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            rolLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            BtnAgregar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.AutoSize = true;
            BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BtnCancelar.ForeColor = System.Drawing.Color.Green;
            BtnCancelar.Location = new System.Drawing.Point(220, 213);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new System.Drawing.Size(57, 13);
            BtnCancelar.TabIndex = 8;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.Click += new System.EventHandler(this.label1_Click);
            // 
            // idUsuarioLabel1
            // 
            idUsuarioLabel1.AutoSize = true;
            idUsuarioLabel1.Location = new System.Drawing.Point(6, 51);
            idUsuarioLabel1.Name = "idUsuarioLabel1";
            idUsuarioLabel1.Size = new System.Drawing.Size(58, 13);
            idUsuarioLabel1.TabIndex = 35;
            idUsuarioLabel1.Text = "Id Usuario:";
            // 
            // documentoLabel
            // 
            documentoLabel.AutoSize = true;
            documentoLabel.Location = new System.Drawing.Point(15, 57);
            documentoLabel.Name = "documentoLabel";
            documentoLabel.Size = new System.Drawing.Size(65, 13);
            documentoLabel.TabIndex = 39;
            documentoLabel.Text = "Documento:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(15, 83);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 41;
            nombreLabel.Text = "Nombre:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(15, 109);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 43;
            usuarioLabel.Text = "Usuario:";
            // 
            // rolLabel
            // 
            rolLabel.AutoSize = true;
            rolLabel.Location = new System.Drawing.Point(15, 135);
            rolLabel.Name = "rolLabel";
            rolLabel.Size = new System.Drawing.Size(26, 13);
            rolLabel.TabIndex = 45;
            rolLabel.Text = "Rol:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(15, 162);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 47;
            passwordLabel.Text = "Password:";
            // 
            // BtnAgregar
            // 
            BtnAgregar.AutoSize = true;
            BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BtnAgregar.ForeColor = System.Drawing.Color.Green;
            BtnAgregar.Location = new System.Drawing.Point(29, 213);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new System.Drawing.Size(51, 13);
            BtnAgregar.TabIndex = 48;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(330, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(277, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.BtnAUSalir);
            this.panel1.Controls.Add(this.BtnAddUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 31);
            this.panel1.TabIndex = 16;
            // 
            // BtnAUSalir
            // 
            this.BtnAUSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAUSalir.FlatAppearance.BorderSize = 0;
            this.BtnAUSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAUSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAUSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAUSalir.Location = new System.Drawing.Point(529, 4);
            this.BtnAUSalir.Name = "BtnAUSalir";
            this.BtnAUSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnAUSalir.TabIndex = 9;
            this.BtnAUSalir.Text = "Regresar";
            this.BtnAUSalir.UseVisualStyleBackColor = true;
            this.BtnAUSalir.Click += new System.EventHandler(this.BtnAUSalir_Click);
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.AutoSize = true;
            this.BtnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddUser.ForeColor = System.Drawing.Color.White;
            this.BtnAddUser.Location = new System.Drawing.Point(12, 8);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(111, 15);
            this.BtnAddUser.TabIndex = 3;
            this.BtnAddUser.Text = "Agregar Usuario";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(idUsuarioLabel1);
            this.panel2.Controls.Add(this.idUsuarioTextBox1);
            this.panel2.Location = new System.Drawing.Point(86, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 10);
            this.panel2.TabIndex = 31;
            // 
            // idUsuarioTextBox1
            // 
            this.idUsuarioTextBox1.Enabled = false;
            this.idUsuarioTextBox1.Location = new System.Drawing.Point(70, 48);
            this.idUsuarioTextBox1.Name = "idUsuarioTextBox1";
            this.idUsuarioTextBox1.Size = new System.Drawing.Size(121, 20);
            this.idUsuarioTextBox1.TabIndex = 36;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Nombres
            // 
            this.Nombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Nombres.Location = new System.Drawing.Point(86, 80);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(194, 20);
            this.Nombres.TabIndex = 2;
            this.Nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombres_KeyPress);
            // 
            // Usuario
            // 
            this.Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Usuario.Location = new System.Drawing.Point(86, 106);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(194, 20);
            this.Usuario.TabIndex = 3;
            // 
            // Roles
            // 
            this.Roles.FormattingEnabled = true;
            this.Roles.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "FACTURADOR",
            "GRABADOR"});
            this.Roles.Location = new System.Drawing.Point(86, 132);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(194, 21);
            this.Roles.TabIndex = 4;
            this.Roles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rolComboBox_KeyPress_1);
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(86, 159);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PasswordChar = 'o';
            this.Contraseña.Size = new System.Drawing.Size(194, 20);
            this.Contraseña.TabIndex = 5;
            // 
            // Cedula
            // 
            this.Cedula.Location = new System.Drawing.Point(86, 54);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(194, 20);
            this.Cedula.TabIndex = 1;
            this.Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cedula_KeyPress);
            // 
            // Notificacion
            // 
            this.Notificacion.Text = "El registro se ha guardado exitosamente";
            this.Notificacion.Visible = true;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // AgregarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 235);
            this.Controls.Add(BtnAgregar);
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
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarUsuarios";
            this.Load += new System.EventHandler(this.AgregarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAUSalir;
        private System.Windows.Forms.Label BtnAddUser;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox idUsuarioTextBox1;
        private DataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox Nombres;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.ComboBox Roles;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.TextBox Cedula;
        private System.Windows.Forms.NotifyIcon Notificacion;
    }
}