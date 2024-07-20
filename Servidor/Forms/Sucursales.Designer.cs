namespace Servidor
{
    partial class Sucursales
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            dtSucursales = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewComboBoxColumn();
            encargadoDTOBindingSource1 = new BindingSource(components);
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            sucursalBindingSource3 = new BindingSource(components);
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            encargadoDTOBindingSource = new BindingSource(components);
            sucursalBindingSource2 = new BindingSource(components);
            sucursalBindingSource = new BindingSource(components);
            encargadoBindingSource = new BindingSource(components);
            sucursalBindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtSucursales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)encargadoDTOBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sucursalBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)encargadoDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sucursalBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sucursalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)encargadoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sucursalBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtSucursales);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnAgregar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // dtSucursales
            // 
            dtSucursales.AutoGenerateColumns = false;
            dtSucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtSucursales.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, nombreDataGridViewTextBoxColumn, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, estadoDataGridViewTextBoxColumn });
            dtSucursales.DataSource = sucursalBindingSource3;
            dtSucursales.Location = new Point(17, 61);
            dtSucursales.Name = "dtSucursales";
            dtSucursales.RowTemplate.Height = 25;
            dtSucursales.Size = new Size(740, 315);
            dtSucursales.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "IdSucursal";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "IdEncargado";
            dataGridViewTextBoxColumn2.DataSource = encargadoDTOBindingSource1;
            dataGridViewTextBoxColumn2.DisplayMember = "Nombre";
            dataGridViewTextBoxColumn2.HeaderText = "Encargado";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewTextBoxColumn2.ValueMember = "IdEncargado";
            // 
            // encargadoDTOBindingSource1
            // 
            encargadoDTOBindingSource1.DataSource = typeof(Core.DTOs.EncargadoDTO);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Direccion";
            dataGridViewTextBoxColumn3.HeaderText = "Dirección";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Telefono";
            dataGridViewTextBoxColumn4.HeaderText = "Teléfono";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.Items.AddRange(new object[] { "Activo", "Inactivo" });
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            estadoDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // sucursalBindingSource3
            // 
            sucursalBindingSource3.DataSource = typeof(Core.Entities.Sucursal);
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(520, 389);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(601, 389);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(682, 389);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(682, 27);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // encargadoDTOBindingSource
            // 
            encargadoDTOBindingSource.DataSource = typeof(Core.DTOs.EncargadoDTO);
            // 
            // sucursalBindingSource2
            // 
            sucursalBindingSource2.DataSource = typeof(Core.Entities.Sucursal);
            // 
            // sucursalBindingSource
            // 
            sucursalBindingSource.DataSource = typeof(Core.Entities.Sucursal);
            // 
            // encargadoBindingSource
            // 
            encargadoBindingSource.DataSource = typeof(Core.Entities.Encargado);
            // 
            // sucursalBindingSource1
            // 
            sucursalBindingSource1.DataSource = typeof(Core.Entities.Sucursal);
            // 
            // Sucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Sucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sucursales";
            Load += Sucursales_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtSucursales).EndInit();
            ((System.ComponentModel.ISupportInitialize)encargadoDTOBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sucursalBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)encargadoDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)sucursalBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)sucursalBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)encargadoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)sucursalBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridViewTextBoxColumn idSucursalDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn idEncargadoDataGridViewTextBoxColumn;
        private BindingSource encargadoBindingSource;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private BindingSource sucursalBindingSource;
        private BindingSource encargadoDTOBindingSource;
        private BindingSource sucursalBindingSource2;
        private BindingSource sucursalBindingSource1;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnSalir;
        private Button btnAgregar;
        private DataGridView dtSucursales;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private BindingSource encargadoDTOBindingSource1;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewComboBoxColumn estadoDataGridViewTextBoxColumn;
        private BindingSource sucursalBindingSource3;
    }
}