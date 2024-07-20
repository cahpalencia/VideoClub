namespace Cliente.Forms
{
    partial class NuevoPrestamo
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
            label1 = new Label();
            btnGuardar = new Button();
            btnSalir = new Button();
            cboSucursal = new ComboBox();
            sucursalBindingSource = new BindingSource(components);
            peliculaPrestamoDTOBindingSource = new BindingSource(components);
            panel1 = new Panel();
            dtPeliculas = new DataGridView();
            peliculaPrestamoDTOBindingSource3 = new BindingSource(components);
            peliculaPrestamoDTOBindingSource1 = new BindingSource(components);
            peliculaPrestamoDTOBindingSource2 = new BindingSource(components);
            idPeliculaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idSucursalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tituloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            existenciasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)sucursalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peliculaPrestamoDTOBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtPeliculas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peliculaPrestamoDTOBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peliculaPrestamoDTOBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peliculaPrestamoDTOBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 21);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Sucursal";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(506, 367);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Solicitar Prestamo";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(624, 367);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // cboSucursal
            // 
            cboSucursal.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboSucursal.DataSource = sucursalBindingSource;
            cboSucursal.DisplayMember = "Nombre";
            cboSucursal.FormattingEnabled = true;
            cboSucursal.Location = new Point(13, 44);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(267, 23);
            cboSucursal.TabIndex = 1;
            cboSucursal.ValueMember = "IdSucursal";
            cboSucursal.SelectedIndexChanged += cboSucursal_SelectedIndexChanged;
            // 
            // sucursalBindingSource
            // 
            sucursalBindingSource.DataSource = typeof(Core.Entities.Sucursal);
            // 
            // peliculaPrestamoDTOBindingSource
            // 
            peliculaPrestamoDTOBindingSource.DataSource = typeof(Core.DTOs.PeliculaPrestamoDTO);
            // 
            // panel1
            // 
            panel1.Controls.Add(dtPeliculas);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(cboSucursal);
            panel1.Location = new Point(12, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 410);
            panel1.TabIndex = 3;
            // 
            // dtPeliculas
            // 
            dtPeliculas.AutoGenerateColumns = false;
            dtPeliculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtPeliculas.Columns.AddRange(new DataGridViewColumn[] { idPeliculaDataGridViewTextBoxColumn, idSucursalDataGridViewTextBoxColumn, tituloDataGridViewTextBoxColumn, categoriaDataGridViewTextBoxColumn, existenciasDataGridViewTextBoxColumn });
            dtPeliculas.DataSource = peliculaPrestamoDTOBindingSource3;
            dtPeliculas.Location = new Point(13, 85);
            dtPeliculas.MultiSelect = false;
            dtPeliculas.Name = "dtPeliculas";
            dtPeliculas.RowTemplate.Height = 25;
            dtPeliculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtPeliculas.Size = new Size(686, 276);
            dtPeliculas.TabIndex = 7;
            // 
            // peliculaPrestamoDTOBindingSource3
            // 
            peliculaPrestamoDTOBindingSource3.DataSource = typeof(Core.DTOs.PeliculaPrestamoDTO);
            // 
            // peliculaPrestamoDTOBindingSource1
            // 
            peliculaPrestamoDTOBindingSource1.DataSource = typeof(Core.DTOs.PeliculaPrestamoDTO);
            // 
            // peliculaPrestamoDTOBindingSource2
            // 
            peliculaPrestamoDTOBindingSource2.DataSource = typeof(Core.DTOs.PeliculaPrestamoDTO);
            // 
            // idPeliculaDataGridViewTextBoxColumn
            // 
            idPeliculaDataGridViewTextBoxColumn.DataPropertyName = "IdPelicula";
            idPeliculaDataGridViewTextBoxColumn.HeaderText = "Id";
            idPeliculaDataGridViewTextBoxColumn.Name = "idPeliculaDataGridViewTextBoxColumn";
            idPeliculaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSucursalDataGridViewTextBoxColumn
            // 
            idSucursalDataGridViewTextBoxColumn.DataPropertyName = "idSucursal";
            idSucursalDataGridViewTextBoxColumn.HeaderText = "idSucursal";
            idSucursalDataGridViewTextBoxColumn.Name = "idSucursalDataGridViewTextBoxColumn";
            idSucursalDataGridViewTextBoxColumn.ReadOnly = true;
            idSucursalDataGridViewTextBoxColumn.Visible = false;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            tituloDataGridViewTextBoxColumn.HeaderText = "Título";
            tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            categoriaDataGridViewTextBoxColumn.HeaderText = "Categoría";
            categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // existenciasDataGridViewTextBoxColumn
            // 
            existenciasDataGridViewTextBoxColumn.DataPropertyName = "Existencias";
            existenciasDataGridViewTextBoxColumn.HeaderText = "Existencias";
            existenciasDataGridViewTextBoxColumn.Name = "existenciasDataGridViewTextBoxColumn";
            existenciasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NuevoPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NuevoPrestamo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevoPrestamo";
            Load += NuevoPrestamo_Load;
            ((System.ComponentModel.ISupportInitialize)sucursalBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)peliculaPrestamoDTOBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtPeliculas).EndInit();
            ((System.ComponentModel.ISupportInitialize)peliculaPrestamoDTOBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)peliculaPrestamoDTOBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)peliculaPrestamoDTOBindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnGuardar;
        private Button btnSalir;
        private ComboBox cboSucursal;
        private Panel panel1;
        private BindingSource peliculaPrestamoDTOBindingSource;
        private BindingSource sucursalBindingSource;
        private DataGridView dtPeliculas;
        private BindingSource peliculaPrestamoDTOBindingSource3;
        private BindingSource peliculaPrestamoDTOBindingSource1;
        private BindingSource peliculaPrestamoDTOBindingSource2;
        private DataGridViewTextBoxColumn idPeliculaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idSucursalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn existenciasDataGridViewTextBoxColumn;
    }
}