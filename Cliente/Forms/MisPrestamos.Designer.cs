namespace Cliente.Forms
{
    partial class MisPrestamos
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
            prestamosDTOBindingSource = new BindingSource(components);
            btnAceptar = new Button();
            dtPrestamos = new DataGridView();
            prestamosDTOBindingSource1 = new BindingSource(components);
            idPrestamoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            peliculaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sucursalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaPrestamoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            devueltoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)prestamosDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtPrestamos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prestamosDTOBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // prestamosDTOBindingSource
            // 
            prestamosDTOBindingSource.DataSource = typeof(Core.DTOs.PrestamosDTO);
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(713, 397);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dtPrestamos
            // 
            dtPrestamos.AutoGenerateColumns = false;
            dtPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtPrestamos.Columns.AddRange(new DataGridViewColumn[] { idPrestamoDataGridViewTextBoxColumn, idClienteDataGridViewTextBoxColumn, peliculaDataGridViewTextBoxColumn, categoriaDataGridViewTextBoxColumn, sucursalDataGridViewTextBoxColumn, fechaPrestamoDataGridViewTextBoxColumn, devueltoDataGridViewCheckBoxColumn });
            dtPrestamos.DataSource = prestamosDTOBindingSource1;
            dtPrestamos.Location = new Point(12, 12);
            dtPrestamos.Name = "dtPrestamos";
            dtPrestamos.RowTemplate.Height = 25;
            dtPrestamos.Size = new Size(776, 379);
            dtPrestamos.TabIndex = 2;
            // 
            // prestamosDTOBindingSource1
            // 
            prestamosDTOBindingSource1.DataSource = typeof(Core.DTOs.PrestamosDTO);
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
            devueltoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // MisPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 429);
            Controls.Add(dtPrestamos);
            Controls.Add(btnAceptar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MisPrestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MisPrestamos";
            Load += MisPrestamos_Load;
            ((System.ComponentModel.ISupportInitialize)prestamosDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtPrestamos).EndInit();
            ((System.ComponentModel.ISupportInitialize)prestamosDTOBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAceptar;
        private BindingSource prestamosDTOBindingSource;
        private DataGridView dtPrestamos;
        private BindingSource prestamosDTOBindingSource1;
        private DataGridViewTextBoxColumn idPrestamoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn peliculaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaPrestamoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn devueltoDataGridViewCheckBoxColumn;
    }
}