namespace Servidor.Forms
{
    partial class SucursalPelicula
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
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            dtPeliculasSucursal = new DataGridView();
            idSucursalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idPeliculaDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            peliculaBindingSource = new BindingSource(components);
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            peliculasSucursalBindingSource = new BindingSource(components);
            label1 = new Label();
            cboSucursal = new ComboBox();
            sucursalBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtPeliculasSucursal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peliculaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peliculasSucursalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sucursalBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(dtPeliculasSucursal);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboSucursal);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(519, 388);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(600, 388);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(681, 388);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(681, 27);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dtPeliculasSucursal
            // 
            dtPeliculasSucursal.AutoGenerateColumns = false;
            dtPeliculasSucursal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtPeliculasSucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtPeliculasSucursal.Columns.AddRange(new DataGridViewColumn[] { idSucursalDataGridViewTextBoxColumn, idPeliculaDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn });
            dtPeliculasSucursal.DataSource = peliculasSucursalBindingSource;
            dtPeliculasSucursal.Location = new Point(19, 67);
            dtPeliculasSucursal.Name = "dtPeliculasSucursal";
            dtPeliculasSucursal.RowTemplate.Height = 25;
            dtPeliculasSucursal.Size = new Size(737, 306);
            dtPeliculasSucursal.TabIndex = 2;
            // 
            // idSucursalDataGridViewTextBoxColumn
            // 
            idSucursalDataGridViewTextBoxColumn.DataPropertyName = "IdSucursal";
            idSucursalDataGridViewTextBoxColumn.HeaderText = "IdSucursal";
            idSucursalDataGridViewTextBoxColumn.Name = "idSucursalDataGridViewTextBoxColumn";
            idSucursalDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPeliculaDataGridViewTextBoxColumn
            // 
            idPeliculaDataGridViewTextBoxColumn.DataPropertyName = "IdPelicula";
            idPeliculaDataGridViewTextBoxColumn.DataSource = peliculaBindingSource;
            idPeliculaDataGridViewTextBoxColumn.DisplayMember = "Titulo";
            idPeliculaDataGridViewTextBoxColumn.HeaderText = "Pelicula";
            idPeliculaDataGridViewTextBoxColumn.Name = "idPeliculaDataGridViewTextBoxColumn";
            idPeliculaDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            idPeliculaDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            idPeliculaDataGridViewTextBoxColumn.ValueMember = "IdPelicula";
            // 
            // peliculaBindingSource
            // 
            peliculaBindingSource.DataSource = typeof(Core.Entities.Pelicula);
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // peliculasSucursalBindingSource
            // 
            peliculasSucursalBindingSource.DataSource = typeof(Core.Entities.PeliculasSucursal);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Sucursal";
            label1.Click += label1_Click;
            // 
            // cboSucursal
            // 
            cboSucursal.DataSource = sucursalBindingSource;
            cboSucursal.DisplayMember = "Nombre";
            cboSucursal.FormattingEnabled = true;
            cboSucursal.Location = new Point(19, 27);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(190, 23);
            cboSucursal.TabIndex = 0;
            cboSucursal.ValueMember = "IdSucursal";
            cboSucursal.SelectedIndexChanged += cboSucursal_SelectedIndexChanged;
            // 
            // sucursalBindingSource
            // 
            sucursalBindingSource.DataSource = typeof(Core.Entities.Sucursal);
            // 
            // SucursalPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SucursalPelicula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SucursalPelicula";
            Load += SucursalPelicula_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtPeliculasSucursal).EndInit();
            ((System.ComponentModel.ISupportInitialize)peliculaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)peliculasSucursalBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)sucursalBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox cboSucursal;
        private Button btnAgregar;
        private DataGridView dtPeliculasSucursal;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn idSucursalDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn idPeliculaDataGridViewTextBoxColumn;
        private BindingSource peliculaBindingSource;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private BindingSource peliculasSucursalBindingSource;
        private BindingSource sucursalBindingSource;
    }
}