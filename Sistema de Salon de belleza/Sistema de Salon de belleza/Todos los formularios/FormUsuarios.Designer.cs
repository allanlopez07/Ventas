namespace Sistema_de_Salon_de_belleza.Todos_los_formularios
{
    partial class FormUsuarios
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
            System.Windows.Forms.Label fotoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            System.Windows.Forms.Label contrasenaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label tipoUsuarioLabel;
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listaUsuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.seguridadBl_UsuariosDBBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.listaUsuariosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.tipoUsuarioComboBox = new System.Windows.Forms.ComboBox();
            fotoLabel = new System.Windows.Forms.Label();
            contrasenaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            tipoUsuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingNavigator)).BeginInit();
            this.listaUsuariosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "jpg, png |*.jpg; *.png";
            // 
            // listaUsuariosBindingSource1
            // 
            this.listaUsuariosBindingSource1.DataSource = typeof(BL.Rentas.SeguridadBl.UsuariosDB);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(612, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 33);
            this.button2.TabIndex = 14;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.Color.Silver;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.listaUsuariosBindingSource1, "Foto", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.fotoPictureBox.Location = new System.Drawing.Point(483, 61);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(225, 169);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 11;
            this.fotoPictureBox.TabStop = false;
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.BackColor = System.Drawing.Color.Transparent;
            fotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fotoLabel.Location = new System.Drawing.Point(434, 57);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(46, 20);
            fotoLabel.TabIndex = 10;
            fotoLabel.Text = "Foto:";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // seguridadBl_UsuariosDBBindingNavigatorSaveItem
            // 
            this.seguridadBl_UsuariosDBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.seguridadBl_UsuariosDBBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("seguridadBl_UsuariosDBBindingNavigatorSaveItem.Image")));
            this.seguridadBl_UsuariosDBBindingNavigatorSaveItem.Name = "seguridadBl_UsuariosDBBindingNavigatorSaveItem";
            this.seguridadBl_UsuariosDBBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.seguridadBl_UsuariosDBBindingNavigatorSaveItem.Text = "Guardar datos";
            this.seguridadBl_UsuariosDBBindingNavigatorSaveItem.Click += new System.EventHandler(this.seguridadBl_UsuariosDBBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // listaUsuariosBindingNavigator
            // 
            this.listaUsuariosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaUsuariosBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.listaUsuariosBindingNavigator.BindingSource = this.listaUsuariosBindingSource1;
            this.listaUsuariosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaUsuariosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaUsuariosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.seguridadBl_UsuariosDBBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaUsuariosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaUsuariosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaUsuariosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaUsuariosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaUsuariosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaUsuariosBindingNavigator.Name = "listaUsuariosBindingNavigator";
            this.listaUsuariosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaUsuariosBindingNavigator.Size = new System.Drawing.Size(728, 25);
            this.listaUsuariosBindingNavigator.TabIndex = 0;
            this.listaUsuariosBindingNavigator.Text = "bindingNavigator1";
            this.listaUsuariosBindingNavigator.RefreshItems += new System.EventHandler(this.seguridadBl_UsuariosDBBindingNavigator_RefreshItems);
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.BackColor = System.Drawing.Color.Transparent;
            contrasenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contrasenaLabel.Location = new System.Drawing.Point(31, 152);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new System.Drawing.Size(96, 20);
            contrasenaLabel.TabIndex = 14;
            contrasenaLabel.Text = "Contrasena:";
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaUsuariosBindingSource1, "Contrasena", true));
            this.contrasenaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenaTextBox.Location = new System.Drawing.Point(167, 149);
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.Size = new System.Drawing.Size(258, 26);
            this.contrasenaTextBox.TabIndex = 15;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.Transparent;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(31, 58);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 18;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaUsuariosBindingSource1, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(167, 55);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(258, 26);
            this.idTextBox.TabIndex = 19;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(31, 107);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(69, 20);
            nombreLabel.TabIndex = 20;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaUsuariosBindingSource1, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(167, 104);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(258, 26);
            this.nombreTextBox.TabIndex = 21;
            // 
            // tipoUsuarioLabel
            // 
            tipoUsuarioLabel.AutoSize = true;
            tipoUsuarioLabel.BackColor = System.Drawing.Color.Transparent;
            tipoUsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoUsuarioLabel.Location = new System.Drawing.Point(31, 197);
            tipoUsuarioLabel.Name = "tipoUsuarioLabel";
            tipoUsuarioLabel.Size = new System.Drawing.Size(102, 20);
            tipoUsuarioLabel.TabIndex = 22;
            tipoUsuarioLabel.Text = "Tipo Usuario:";
            // 
            // tipoUsuarioComboBox
            // 
            this.tipoUsuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaUsuariosBindingSource1, "TipoUsuario", true));
            this.tipoUsuarioComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuarioComboBox.FormattingEnabled = true;
            this.tipoUsuarioComboBox.Items.AddRange(new object[] {
            "Administradores",
            "Usuarios Caja",
            "Usuario Vendedores"});
            this.tipoUsuarioComboBox.Location = new System.Drawing.Point(167, 194);
            this.tipoUsuarioComboBox.Name = "tipoUsuarioComboBox";
            this.tipoUsuarioComboBox.Size = new System.Drawing.Size(258, 28);
            this.tipoUsuarioComboBox.TabIndex = 23;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(728, 283);
            this.Controls.Add(contrasenaLabel);
            this.Controls.Add(this.contrasenaTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(tipoUsuarioLabel);
            this.Controls.Add(this.tipoUsuarioComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.listaUsuariosBindingNavigator);
            this.Name = "FormUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosBindingNavigator)).EndInit();
            this.listaUsuariosBindingNavigator.ResumeLayout(false);
            this.listaUsuariosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource listaUsuariosBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton seguridadBl_UsuariosDBBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.BindingNavigator listaUsuariosBindingNavigator;
        private System.Windows.Forms.TextBox contrasenaTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ComboBox tipoUsuarioComboBox;
    }
}