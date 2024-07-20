namespace Servidor
{
    partial class Categoria
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
            dtCategorias = new DataGridView();
            idCategoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreCategoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaPeliculaBindingSource = new BindingSource(components);
            panel1 = new Panel();
            btnAgregar = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaPeliculaBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtCategorias
            // 
            dtCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtCategorias.AutoGenerateColumns = false;
            dtCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtCategorias.Columns.AddRange(new DataGridViewColumn[] { idCategoriaDataGridViewTextBoxColumn, nombreCategoriaDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn });
            dtCategorias.DataSource = categoriaPeliculaBindingSource;
            dtCategorias.Location = new Point(10, 43);
            dtCategorias.Name = "dtCategorias";
            dtCategorias.RowTemplate.Height = 25;
            dtCategorias.Size = new Size(762, 292);
            dtCategorias.TabIndex = 0;
            dtCategorias.CellContentClick += dtCategorias_CellContentClick;
            dtCategorias.UserAddedRow += dtCategorias_UserAddedRow;
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "IdCategoria";
            idCategoriaDataGridViewTextBoxColumn.HeaderText = "Id";
            idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            idCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreCategoriaDataGridViewTextBoxColumn
            // 
            nombreCategoriaDataGridViewTextBoxColumn.DataPropertyName = "NombreCategoria";
            nombreCategoriaDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreCategoriaDataGridViewTextBoxColumn.Name = "nombreCategoriaDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.Width = 94;
            // 
            // categoriaPeliculaBindingSource
            // 
            categoriaPeliculaBindingSource.DataSource = typeof(Core.Entities.CategoriaPelicula);
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(dtCategorias);
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 357);
            panel1.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(697, 14);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(618, 383);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(537, 383);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(699, 383);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Categoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 418);
            Controls.Add(btnSalir);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Categoria";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categoria";
            Load += Categoria_Load;
            ((System.ComponentModel.ISupportInitialize)dtCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaPeliculaBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtCategorias;
        private BindingSource categoriaPeliculaBindingSource;
        private Panel panel1;
        private Button btnAgregar;
        private Button btnCancel;
        private Button btnSave;
        private DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private Button btnSalir;
    }
}