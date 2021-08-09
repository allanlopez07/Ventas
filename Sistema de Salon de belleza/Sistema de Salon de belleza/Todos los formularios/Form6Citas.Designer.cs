namespace Sistema_de_Salon_de_belleza
{
    partial class Form6Citas
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
            System.Windows.Forms.Label clienteLabel;
            System.Windows.Forms.Label empleadoLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label servicioLabel;
            System.Windows.Forms.Label fecha_CitaLabel;
            System.Windows.Forms.Label estatusLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6Citas));
            this.listaCitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaCitasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaCitasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.citasBL_CitasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.servicioTextBox = new System.Windows.Forms.TextBox();
            this.fecha_CitaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.estatusComboBox = new System.Windows.Forms.ComboBox();
            this.empleadoComboBox = new System.Windows.Forms.ComboBox();
            this.listaEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horaComboBox = new System.Windows.Forms.ComboBox();
            clienteLabel = new System.Windows.Forms.Label();
            empleadoLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            servicioLabel = new System.Windows.Forms.Label();
            fecha_CitaLabel = new System.Windows.Forms.Label();
            estatusLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitasBindingNavigator)).BeginInit();
            this.listaCitasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citasBL_CitasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.BackColor = System.Drawing.Color.Transparent;
            clienteLabel.Location = new System.Drawing.Point(2, 126);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(42, 13);
            clienteLabel.TabIndex = 15;
            clienteLabel.Text = "Cliente:";
            // 
            // empleadoLabel
            // 
            empleadoLabel.AutoSize = true;
            empleadoLabel.BackColor = System.Drawing.Color.Transparent;
            empleadoLabel.Location = new System.Drawing.Point(3, 163);
            empleadoLabel.Name = "empleadoLabel";
            empleadoLabel.Size = new System.Drawing.Size(57, 13);
            empleadoLabel.TabIndex = 17;
            empleadoLabel.Text = "Empleado:";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.BackColor = System.Drawing.Color.Transparent;
            horaLabel.Location = new System.Drawing.Point(3, 240);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(33, 13);
            horaLabel.TabIndex = 23;
            horaLabel.Text = "Hora:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.Transparent;
            idLabel.Location = new System.Drawing.Point(8, 91);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 25;
            idLabel.Text = "Id:";
            // 
            // servicioLabel
            // 
            servicioLabel.AutoSize = true;
            servicioLabel.BackColor = System.Drawing.Color.Transparent;
            servicioLabel.Location = new System.Drawing.Point(4, 290);
            servicioLabel.Name = "servicioLabel";
            servicioLabel.Size = new System.Drawing.Size(48, 13);
            servicioLabel.TabIndex = 27;
            servicioLabel.Text = "Servicio:";
            // 
            // fecha_CitaLabel
            // 
            fecha_CitaLabel.AutoSize = true;
            fecha_CitaLabel.BackColor = System.Drawing.Color.Transparent;
            fecha_CitaLabel.Location = new System.Drawing.Point(1, 331);
            fecha_CitaLabel.Name = "fecha_CitaLabel";
            fecha_CitaLabel.Size = new System.Drawing.Size(61, 13);
            fecha_CitaLabel.TabIndex = 30;
            fecha_CitaLabel.Text = "Fecha Cita:";
            // 
            // estatusLabel1
            // 
            estatusLabel1.AutoSize = true;
            estatusLabel1.BackColor = System.Drawing.Color.Transparent;
            estatusLabel1.Location = new System.Drawing.Point(4, 196);
            estatusLabel1.Name = "estatusLabel1";
            estatusLabel1.Size = new System.Drawing.Size(45, 13);
            estatusLabel1.TabIndex = 31;
            estatusLabel1.Text = "Estatus:";
            // 
            // listaCitasBindingSource
            // 
            this.listaCitasBindingSource.DataSource = typeof(BL.Rentas.CitasBL.Citas);
            // 
            // listaCitasBindingNavigator
            // 
            this.listaCitasBindingNavigator.AddNewItem = null;
            this.listaCitasBindingNavigator.BindingSource = this.listaCitasBindingSource;
            this.listaCitasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaCitasBindingNavigator.DeleteItem = null;
            this.listaCitasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaCitasBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaCitasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaCitasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaCitasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaCitasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaCitasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaCitasBindingNavigator.Name = "listaCitasBindingNavigator";
            this.listaCitasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaCitasBindingNavigator.Size = new System.Drawing.Size(916, 25);
            this.listaCitasBindingNavigator.TabIndex = 0;
            this.listaCitasBindingNavigator.Text = "bindingNavigator1";
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
            // listaCitasBindingNavigatorSaveItem
            // 
            this.listaCitasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaCitasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaCitasBindingNavigatorSaveItem.Image")));
            this.listaCitasBindingNavigatorSaveItem.Name = "listaCitasBindingNavigatorSaveItem";
            this.listaCitasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaCitasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaCitasBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaCitasBindingNavigatorSaveItem_Click);
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
            // citasBL_CitasDataGridView
            // 
            this.citasBL_CitasDataGridView.AutoGenerateColumns = false;
            this.citasBL_CitasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citasBL_CitasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.citasBL_CitasDataGridView.DataSource = this.listaCitasBindingSource;
            this.citasBL_CitasDataGridView.Location = new System.Drawing.Point(210, 53);
            this.citasBL_CitasDataGridView.Name = "citasBL_CitasDataGridView";
            this.citasBL_CitasDataGridView.Size = new System.Drawing.Size(669, 421);
            this.citasBL_CitasDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha_Cita";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha_Cita";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Hora";
            this.dataGridViewTextBoxColumn3.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cliente";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Empleado";
            this.dataGridViewTextBoxColumn5.HeaderText = "Empleado";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Servicio";
            this.dataGridViewTextBoxColumn6.HeaderText = "Servicio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Estatus";
            this.dataGridViewTextBoxColumn7.HeaderText = "Estatus";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCitasBindingSource, "Cliente", true));
            this.clienteTextBox.Location = new System.Drawing.Point(64, 122);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(142, 20);
            this.clienteTextBox.TabIndex = 16;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCitasBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(64, 88);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(142, 20);
            this.idTextBox.TabIndex = 26;
            // 
            // servicioTextBox
            // 
            this.servicioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCitasBindingSource, "Servicio", true));
            this.servicioTextBox.Location = new System.Drawing.Point(65, 283);
            this.servicioTextBox.Name = "servicioTextBox";
            this.servicioTextBox.Size = new System.Drawing.Size(141, 20);
            this.servicioTextBox.TabIndex = 28;
            // 
            // fecha_CitaDateTimePicker
            // 
            this.fecha_CitaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaCitasBindingSource, "Fecha_Cita", true));
            this.fecha_CitaDateTimePicker.Location = new System.Drawing.Point(64, 327);
            this.fecha_CitaDateTimePicker.Name = "fecha_CitaDateTimePicker";
            this.fecha_CitaDateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.fecha_CitaDateTimePicker.TabIndex = 31;
            // 
            // estatusComboBox
            // 
            this.estatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCitasBindingSource, "Estatus", true));
            this.estatusComboBox.FormattingEnabled = true;
            this.estatusComboBox.Items.AddRange(new object[] {
            "Programada",
            "En progreso"});
            this.estatusComboBox.Location = new System.Drawing.Point(64, 193);
            this.estatusComboBox.Name = "estatusComboBox";
            this.estatusComboBox.Size = new System.Drawing.Size(142, 21);
            this.estatusComboBox.TabIndex = 32;
            // 
            // empleadoComboBox
            // 
            this.empleadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCitasBindingSource, "Empleado", true));
            this.empleadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaCitasBindingSource, "Empleado", true));
            this.empleadoComboBox.DataSource = this.listaEmpleadosBindingSource;
            this.empleadoComboBox.DisplayMember = "Nombre";
            this.empleadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empleadoComboBox.FormattingEnabled = true;
            this.empleadoComboBox.Location = new System.Drawing.Point(66, 156);
            this.empleadoComboBox.Name = "empleadoComboBox";
            this.empleadoComboBox.Size = new System.Drawing.Size(138, 21);
            this.empleadoComboBox.TabIndex = 33;
            this.empleadoComboBox.ValueMember = "Id";
            // 
            // listaEmpleadosBindingSource
            // 
            this.listaEmpleadosBindingSource.DataSource = typeof(BL.Rentas.EmpleadosBL.Empleados);
            // 
            // horaComboBox
            // 
            this.horaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCitasBindingSource, "Hora", true));
            this.horaComboBox.FormattingEnabled = true;
            this.horaComboBox.Items.AddRange(new object[] {
            "09:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "01:00 PM",
            "02:00 PM",
            "03:00 PM"});
            this.horaComboBox.Location = new System.Drawing.Point(66, 232);
            this.horaComboBox.Name = "horaComboBox";
            this.horaComboBox.Size = new System.Drawing.Size(139, 21);
            this.horaComboBox.TabIndex = 34;
            // 
            // Form6Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(916, 503);
            this.Controls.Add(this.horaComboBox);
            this.Controls.Add(this.empleadoComboBox);
            this.Controls.Add(estatusLabel1);
            this.Controls.Add(this.estatusComboBox);
            this.Controls.Add(fecha_CitaLabel);
            this.Controls.Add(this.fecha_CitaDateTimePicker);
            this.Controls.Add(clienteLabel);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(empleadoLabel);
            this.Controls.Add(horaLabel);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(servicioLabel);
            this.Controls.Add(this.servicioTextBox);
            this.Controls.Add(this.citasBL_CitasDataGridView);
            this.Controls.Add(this.listaCitasBindingNavigator);
            this.Name = "Form6Citas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Form6Citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaCitasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitasBindingNavigator)).EndInit();
            this.listaCitasBindingNavigator.ResumeLayout(false);
            this.listaCitasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citasBL_CitasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmpleadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaCitasBindingSource;
        private System.Windows.Forms.BindingNavigator listaCitasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaCitasBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.DataGridView citasBL_CitasDataGridView;
       // private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox servicioTextBox;
        private System.Windows.Forms.DateTimePicker fecha_CitaDateTimePicker;
        private System.Windows.Forms.ComboBox estatusComboBox;
        private System.Windows.Forms.ComboBox empleadoComboBox;
        private System.Windows.Forms.BindingSource listaEmpleadosBindingSource;
        private System.Windows.Forms.ComboBox horaComboBox;
    }
}