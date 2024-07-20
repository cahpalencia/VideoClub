namespace Servidor.Forms
{
    partial class RecepcionPelicula
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
            panel2 = new Panel();
            lblApellido2 = new Label();
            lblApellido1 = new Label();
            lblNombre = new Label();
            btnGuardar = new Button();
            label1 = new Label();
            cboClientes = new ComboBox();
            clienteDTOBindingSource = new BindingSource(components);
            btnSalir = new Button();
            dtPrestamos = new DataGridView();
            idPrestamoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            peliculaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sucursalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaPrestamoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            devueltoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            prestamosDTOBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clienteDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtPrestamos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prestamosDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboClientes);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(dtPrestamos);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblApellido2);
            panel2.Controls.Add(lblApellido1);
            panel2.Controls.Add(lblNombre);
            panel2.Location = new Point(256, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(502, 50);
            panel2.TabIndex = 7;
            // 
            // lblApellido2
            // 
            lblApellido2.AutoSize = true;
            lblApellido2.Location = new Point(218, 27);
            lblApellido2.Name = "lblApellido2";
            lblApellido2.Size = new Size(104, 15);
            lblApellido2.TabIndex = 2;
            lblApellido2.Text = "Segundo Apellido:";
            // 
            // lblApellido1
            // 
            lblApellido1.AutoSize = true;
            lblApellido1.Location = new Point(15, 27);
            lblApellido1.Name = "lblApellido1";
            lblApellido1.Size = new Size(95, 15);
            lblApellido1.TabIndex = 1;
            lblApellido1.Text = "Primer Apellido: ";
            // 
            // lblNombre
            // 
            lblNombre.AccessibleRole = AccessibleRole.Outline;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(15, 7);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(602, 391);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 5);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 5;
            label1.Text = "Cliente";
            // 
            // cboClientes
            // 
            cboClientes.AutoCompleteMode = AutoCompleteMode.Append;
            cboClientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboClientes.DataSource = clienteDTOBindingSource;
            cboClientes.DisplayMember = "Identificacion";
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(20, 23);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(202, 23);
            cboClientes.TabIndex = 4;
            cboClientes.ValueMember = "IdCliente";
            cboClientes.SelectedIndexChanged += cboClientes_SelectedIndexChanged;
            // 
            // clienteDTOBindingSource
            // 
            clienteDTOBindingSource.DataSource = typeof(Core.DTOs.ClienteDTO);
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(683, 391);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dtPrestamos
            // 
            dtPrestamos.AutoGenerateColumns = false;
            dtPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtPrestamos.Columns.AddRange(new DataGridViewColumn[] { idPrestamoDataGridViewTextBoxColumn, idClienteDataGridViewTextBoxColumn, peliculaDataGridViewTextBoxColumn, categoriaDataGridViewTextBoxColumn, sucursalDataGridViewTextBoxColumn, fechaPrestamoDataGridViewTextBoxColumn, devueltoDataGridViewCheckBoxColumn });
            dtPrestamos.DataSource = prestamosDTOBindingSource;
            dtPrestamos.Location = new Point(20, 77);
            dtPrestamos.Name = "dtPrestamos";
            dtPrestamos.RowTemplate.Height = 25;
            dtPrestamos.Size = new Size(738, 303);
            dtPrestamos.TabIndex = 1;
            // 
            // idPrestamoDataGridViewTextBoxColumn
            // 
            idPrestamoDataGridViewTextBoxColumn.DataPropertyName = "idPrestamo";
            idPrestamoDataGridViewTextBoxColumn.HeaderText = "Nro Prestamo";
            idPrestamoDataGridViewTextBoxColumn.Name = "idPrestamoDataGridViewTextBoxColumn";
            idPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // peliculaDataGridViewTextBoxColumn
            // 
            peliculaDataGridViewTextBoxColumn.DataPropertyName = "Pelicula";
            peliculaDataGridViewTextBoxColumn.HeaderText = "Película";
            peliculaDataGridViewTextBoxColumn.Name = "peliculaDataGridViewTextBoxColumn";
            peliculaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            categoriaDataGridViewTextBoxColumn.HeaderText = "Categoría";
            categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sucursalDataGridViewTextBoxColumn
            // 
            sucursalDataGridViewTextBoxColumn.DataPropertyName = "Sucursal";
            sucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal";
            sucursalDataGridViewTextBoxColumn.Name = "sucursalDataGridViewTextBoxColumn";
            sucursalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaPrestamoDataGridViewTextBoxColumn
            // 
            fechaPrestamoDataGridViewTextBoxColumn.DataPropertyName = "FechaPrestamo";
            fechaPrestamoDataGridViewTextBoxColumn.HeaderText = "Fecha Prestamo";
            fechaPrestamoDataGridViewTextBoxColumn.Name = "fechaPrestamoDataGridViewTextBoxColumn";
            fechaPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // devueltoDataGridViewCheckBoxColumn
            // 
            devueltoDataGridViewCheckBoxColumn.DataPropertyName = "Devuelto";
            devueltoDataGridViewCheckBoxColumn.HeaderText = "Pendiente Devolución";
            devueltoDataGridViewCheckBoxColumn.Name = "devueltoDataGridViewCheckBoxColumn";
            // 
            // prestamosDTOBindingSource
            // 
            prestamosDTOBindingSource.DataSource = typeof(Core.DTOs.PrestamosDTO);
            // 
            // RecepcionPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RecepcionPelicula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecepcionPelicula";
            Load += RecepcionPelicula_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clienteDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtPrestamos).EndInit();
            ((System.ComponentModel.ISupportInitialize)prestamosDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cboClientes;
        private Button btnSalir;
        private DataGridView dtPrestamos;
        private BindingSource clienteDTOBindingSource;
        private DataGridViewTextBoxColumn idPrestamoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn peliculaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaPrestamoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn devueltoDataGridViewCheckBoxColumn;
        private BindingSource prestamosDTOBindingSource;
        private Button btnGuardar;
        private Panel panel2;
        private Label lblApellido2;
        private Label lblApellido1;
        private Label lblNombre;
    }
}