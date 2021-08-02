namespace Sistema_de_Salon_de_belleza
{
    partial class FormReportedeProductos
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
            System.Windows.Forms.Label estatusLabel;
            System.Windows.Forms.Label fecha_CitaLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label servicioLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportedeProductos));
            this.listaCitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaCitasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listaCitasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.listaCitasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.estatusComboBox = new System.Windows.Forms.ComboBox();
            this.horaComboBox = new System.Windows.Forms.ComboBox();
            this.servicioTextBox = new System.Windows.Forms.TextBox();
            this.fecha_CitaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            clienteLabel = new System.Windows.Forms.Label();
            empleadoLabel = new System.Windows.Forms.Label();
            estatusLabel = new System.Windows.Forms.Label();
            fecha_CitaLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            servicioLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitasBindingNavigator)).BeginInit();
            this.listaCitasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.BackColor = System.Drawing.Color.Transparent;
            clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clienteLabel.Location = new System.Drawing.Point(5, 126);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(62, 20);
            clienteLabel.TabIndex = 2;
            clienteLabel.Text = "Cliente:";
            // 
            // empleadoLabel
            // 
            empleadoLabel.AutoSize = true;
            empleadoLabel.BackColor = System.Drawing.Color.Transparent;
            empleadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            empleadoLabel.Location = new System.Drawing.Point(5, 163);
            empleadoLabel.Name = "empleadoLabel";
            empleadoLabel.Size = new System.Drawing.Size(85, 20);
            empleadoLabel.TabIndex = 4;
            empleadoLabel.Text = "Empleado:";
            // 
            // estatusLabel
            // 
            estatusLabel.AutoSize = true;
            estatusLabel.BackColor = System.Drawing.Color.Transparent;
            estatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estatusLabel.Location = new System.Drawing.Point(5, 199);
            estatusLabel.Name = "estatusLabel";
            estatusLabel.Size = new System.Drawing.Size(68, 20);
            estatusLabel.TabIndex = 6;
            estatusLabel.Text = "Estatus:";
            // 
            // fecha_CitaLabel
            // 
            fecha_CitaLabel.AutoSize = true;
            fecha_CitaLabel.BackColor = System.Drawing.Color.Transparent;
            fecha_CitaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fecha_CitaLabel.Location = new System.Drawing.Point(5, 302);
            fecha_CitaLabel.Name = "fecha_CitaLabel";
            fecha_CitaLabel.Size = new System.Drawing.Size(90, 20);
            fecha_CitaLabel.TabIndex = 8;
            fecha_CitaLabel.Text = "Fecha Cita:";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.BackColor = System.Drawing.Color.Transparent;
            horaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horaLabel.Location = new System.Drawing.Point(5, 232);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(48, 20);
            horaLabel.TabIndex = 10;
            horaLabel.Text = "Hora:";
            // 
            // servicioLabel
            // 
            servicioLabel.AutoSize = true;
            servicioLabel.BackColor = System.Drawing.Color.Transparent;
            servicioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            servicioLabel.Location = new System.Drawing.Point(5, 265);
            servicioLabel.Name = "servicioLabel";
            servicioLabel.Size = new System.Drawing.Size(68, 20);
            servicioLabel.TabIndex = 12;
            servicioLabel.Text = "Servicio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(5, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(23, 20);
            label1.TabIndex = 35;
            label1.Text = "Id";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listaCitasBindingSource
            // 
            this.listaCitasBindingSource.DataSource = typeof(BL.Rentas.CitasBL.Citas);
            // 
            // listaCitasBindingNavigator
            // 
            this.listaCitasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaCitasBindingNavigator.BindingSource = this.listaCitasBindingSource;
            this.listaCitasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaCitasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.listaCitasBindingNavigator.Size = new System.Drawing.Size(934, 25);
            this.listaCitasBindingNavigator.TabIndex = 0;
            this.listaCitasBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // listaCitasBindingNavigatorSaveItem
            // 
            this.listaCitasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaCitasBindingNavigatorSaveItem.Enabled = false;
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
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // listaCitasDataGridView
            // 
            this.listaCitasDataGridView.AutoGenerateColumns = false;
            this.listaCitasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCitasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.listaCitasDataGridView.DataSource = this.listaCitasBindingSource;
            this.listaCitasDataGridView.Location = new System.Drawing.Point(262, 46);
            this.listaCitasDataGridView.Name = "listaCitasDataGridView";
            this.listaCitasDataGridView.Size = new System.Drawing.Size(642, 359);
            this.listaCitasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Fecha_Cita";
            this.dataGridViewTextBoxColumn1.HeaderText = "Fecha_Cita";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Hora";
            this.dataGridViewTextBoxColumn2.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Empleado";
            this.dataGridViewTextBoxColumn4.HeaderText = "Empleado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Servicio";
            this.dataGridViewTextBoxColumn5.HeaderText = "Servicio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Estatus";
            this.dataGridViewTextBoxColumn6.HeaderText = "Estatus";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCitasBindingSource, "Id", true));
            this.textBox1.Location = new System.Drawing.Point(107, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 37;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCitasBindingSource, "Cliente", true));
            this.textBox2.Location = new System.Drawing.Point(107, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 38;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCitasBindingSource, "Empleado", true));
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.ValueMember = "Id";
            // 
            // estatusComboBox
            // 
            this.estatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCitasBindingSource, "Estatus", true));
            this.estatusComboBox.FormattingEnabled = true;
            this.estatusComboBox.Items.AddRange(new object[] {
            "Programada",
            "En progreso"});
            this.estatusComboBox.Location = new System.Drawing.Point(107, 198);
            this.estatusComboBox.Name = "estatusComboBox";
            this.estatusComboBox.Size = new System.Drawing.Size(142, 21);
            this.estatusComboBox.TabIndex = 40;
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
            this.horaComboBox.Location = new System.Drawing.Point(107, 231);
            this.horaComboBox.Name = "horaComboBox";
            this.horaComboBox.Size = new System.Drawing.Size(142, 21);
            this.horaComboBox.TabIndex = 41;
            // 
            // servicioTextBox
            // 
            this.servicioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCitasBindingSource, "Servicio", true));
            this.servicioTextBox.Location = new System.Drawing.Point(107, 265);
            this.servicioTextBox.Name = "servicioTextBox";
            this.servicioTextBox.Size = new System.Drawing.Size(141, 20);
            this.servicioTextBox.TabIndex = 42;
            // 
            // fecha_CitaDateTimePicker
            // 
            this.fecha_CitaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaCitasBindingSource, "Fecha_Cita", true));
            this.fecha_CitaDateTimePicker.Location = new System.Drawing.Point(107, 302);
            this.fecha_CitaDateTimePicker.Name = "fecha_CitaDateTimePicker";
            this.fecha_CitaDateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.fecha_CitaDateTimePicker.TabIndex = 43;
            // 
            // Form6Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 457);
            this.Controls.Add(this.fecha_CitaDateTimePicker);
            this.Controls.Add(this.servicioTextBox);
            this.Controls.Add(this.horaComboBox);
            this.Controls.Add(this.estatusComboBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label1);
            this.Controls.Add(clienteLabel);
            this.Controls.Add(empleadoLabel);
            this.Controls.Add(estatusLabel);
            this.Controls.Add(fecha_CitaLabel);
            this.Controls.Add(horaLabel);
            this.Controls.Add(servicioLabel);
            this.Controls.Add(this.listaCitasDataGridView);
            this.Controls.Add(this.listaCitasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form6Citas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Form6Citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaCitasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitasBindingNavigator)).EndInit();
            this.listaCitasBindingNavigator.ResumeLayout(false);
            this.listaCitasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitasDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView listaCitasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox estatusComboBox;
        private System.Windows.Forms.ComboBox horaComboBox;
        private System.Windows.Forms.TextBox servicioTextBox;
        private System.Windows.Forms.DateTimePicker fecha_CitaDateTimePicker;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
    }
}