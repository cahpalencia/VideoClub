namespace Servidor
{
    partial class Pelicula
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
            dtPeliculas = new DataGridView();
            idPeliculaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tituloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anioLanzamientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idiomaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            peliculaBindingSource = new BindingSource(components);
            cboCategorias = new ComboBox();
            categoriaPeliculaBindingSource = new BindingSource(components);
            panel1 = new Panel();
            label1 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtPeliculas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peliculaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaPeliculaBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtPeliculas
            // 
            dtPeliculas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtPeliculas.AutoGenerateColumns = false;
            dtPeliculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtPeliculas.Columns.AddRange(new DataGridViewColumn[] { idPeliculaDataGridViewTextBoxColumn, tituloDataGridViewTextBoxColumn, anioLanzamientoDataGridViewTextBoxColumn, idiomaDataGridViewTextBoxColumn });
            dtPeliculas.DataSource = peliculaBindingSource;
            dtPeliculas.Location = new Point(13, 73);
            dtPeliculas.Name = "dtPeliculas";
            dtPeliculas.RowTemplate.Height = 25;
            dtPeliculas.Size = new Size(747, 279);
            dtPeliculas.TabIndex = 0;
            // 
            // idPeliculaDataGridViewTextBoxColumn
            // 
            idPeliculaDataGridViewTextBoxColumn.DataPropertyName = "IdPelicula";
            idPeliculaDataGridViewTextBoxColumn.HeaderText = "Id";
            idPeliculaDataGridViewTextBoxColumn.Name = "idPeliculaDataGridViewTextBoxColumn";
            idPeliculaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // anioLanzamientoDataGridViewTextBoxColumn
            // 
            anioLanzamientoDataGridViewTextBoxColumn.DataPropertyName = "AnioLanzamiento";
            anioLanzamientoDataGridViewTextBoxColumn.HeaderText = "Año";
            anioLanzamientoDataGridViewTextBoxColumn.Name = "anioLanzamientoDataGridViewTextBoxColumn";
            // 
            // idiomaDataGridViewTextBoxColumn
            // 
            idiomaDataGridViewTextBoxColumn.DataPropertyName = "Idioma";
            idiomaDataGridViewTextBoxColumn.HeaderText = "Idioma";
            idiomaDataGridViewTextBoxColumn.Name = "idiomaDataGridViewTextBoxColumn";
            // 
            // peliculaBindingSource
            // 
            peliculaBindingSource.DataSource = typeof(Core.Entities.Pelicula);
            // 
            // cboCategorias
            // 
            cboCategorias.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboCategorias.DataSource = categoriaPeliculaBindingSource;
            cboCategorias.DisplayMember = "NombreCategoria";
            cboCategorias.FormattingEnabled = true;
            cboCategorias.Location = new Point(13, 44);
            cboCategorias.Name = "cboCategorias";
            cboCategorias.Size = new Size(267, 23);
            cboCategorias.TabIndex = 1;
            cboCategorias.ValueMember = "IdCategoria";
            cboCategorias.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            cboCategorias.SelectedValueChanged += cboCategorias_SelectedValueChanged;
            // 
            // categoriaPeliculaBindingSource
            // 
            categoriaPeliculaBindingSource.DataSource = typeof(Core.Entities.CategoriaPelicula);
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(cboCategorias);
            panel1.Controls.Add(dtPeliculas);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 410);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 21);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 6;
            label1.Text = "Categoria";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(523, 370);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(604, 370);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(685, 370);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(685, 43);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Pelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 432);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Pelicula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pelicula";
            Load += Pelicula_Load;
            ((System.ComponentModel.ISupportInitialize)dtPeliculas).EndInit();
            ((System.ComponentModel.ISupportInitialize)peliculaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaPeliculaBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtPeliculas;
        private ComboBox cboCategorias;
        private Panel panel1;
        private Label label1;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnSalir;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn idPeliculaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anioLanzamientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idiomaDataGridViewTextBoxColumn;
        private BindingSource peliculaBindingSource;
        private BindingSource categoriaPeliculaBindingSource;
    }
}