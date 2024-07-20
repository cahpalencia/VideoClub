namespace Servidor
{
    partial class Encargado
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
            dtEncargados = new DataGridView();
            idEncargadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            identificacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaIngresoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            primerApellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            segundoApellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            encargadoDTOBindingSource1 = new BindingSource(components);
            btnAgregar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnSalir = new Button();
            encargadoBindingSource2 = new BindingSource(components);
            encargadoBindingSource = new BindingSource(components);
            encargadoBindingSource1 = new BindingSource(components);
            encargadoDTOBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtEncargados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)encargadoDTOBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)encargadoBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)encargadoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)encargadoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)encargadoDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtEncargados);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnSalir);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 426);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dtEncargados
            // 
            dtEncargados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtEncargados.AutoGenerateColumns = false;
            dtEncargados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtEncargados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtEncargados.Columns.AddRange(new DataGridViewColumn[] { idEncargadoDataGridViewTextBoxColumn, identificacionDataGridViewTextBoxColumn, fechaIngresoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, primerApellidoDataGridViewTextBoxColumn, segundoApellidoDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn });
            dtEncargados.DataSource = encargadoDTOBindingSource1;
            dtEncargados.Location = new Point(17, 56);
            dtEncargados.Name = "dtEncargados";
            dtEncargados.RowTemplate.Height = 25;
            dtEncargados.Size = new Size(875, 313);
            dtEncargados.TabIndex = 5;
            // 
            // idEncargadoDataGridViewTextBoxColumn
            // 
            idEncargadoDataGridViewTextBoxColumn.DataPropertyName = "IdEncargado";
            idEncargadoDataGridViewTextBoxColumn.HeaderText = "Id";
            idEncargadoDataGridViewTextBoxColumn.Name = "idEncargadoDataGridViewTextBoxColumn";
            // 
            // identificacionDataGridViewTextBoxColumn
            // 
            identificacionDataGridViewTextBoxColumn.DataPropertyName = "Identificacion";
            identificacionDataGridViewTextBoxColumn.HeaderText = "Identificación";
            identificacionDataGridViewTextBoxColumn.Name = "identificacionDataGridViewTextBoxColumn";
            // 
            // fechaIngresoDataGridViewTextBoxColumn
            // 
            fechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "FechaIngreso";
            fechaIngresoDataGridViewTextBoxColumn.HeaderText = "Fecha Ingreso";
            fechaIngresoDataGridViewTextBoxColumn.Name = "fechaIngresoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // primerApellidoDataGridViewTextBoxColumn
            // 
            primerApellidoDataGridViewTextBoxColumn.DataPropertyName = "PrimerApellido";
            primerApellidoDataGridViewTextBoxColumn.HeaderText = "Primer Apellido";
            primerApellidoDataGridViewTextBoxColumn.Name = "primerApellidoDataGridViewTextBoxColumn";
            // 
            // segundoApellidoDataGridViewTextBoxColumn
            // 
            segundoApellidoDataGridViewTextBoxColumn.DataPropertyName = "SegundoApellido";
            segundoApellidoDataGridViewTextBoxColumn.HeaderText = "Segundo Apellido";
            segundoApellidoDataGridViewTextBoxColumn.Name = "segundoApellidoDataGridViewTextBoxColumn";
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            // 
            // encargadoDTOBindingSource1
            // 
            encargadoDTOBindingSource1.DataSource = typeof(Core.DTOs.EncargadoDTO);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(817, 19);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(655, 383);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(736, 383);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(817, 383);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // encargadoBindingSource2
            // 
            encargadoBindingSource2.DataSource = typeof(Core.Entities.Encargado);
            // 
            // encargadoBindingSource
            // 
            encargadoBindingSource.DataSource = typeof(Core.Entities.Encargado);
            // 
            // encargadoBindingSource1
            // 
            encargadoBindingSource1.DataSource = typeof(Core.Entities.Encargado);
            // 
            // encargadoDTOBindingSource
            // 
            encargadoDTOBindingSource.DataSource = typeof(Core.DTOs.EncargadoDTO);
            // 
            // Encargado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Encargado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Encargado";
            Load += Encargado_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtEncargados).EndInit();
            ((System.ComponentModel.ISupportInitialize)encargadoDTOBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)encargadoBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)encargadoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)encargadoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)encargadoDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAgregar;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnSalir;
        private BindingSource encargadoBindingSource;
        private BindingSource encargadoBindingSource1;
        private BindingSource encargadoBindingSource2;
        private DataGridView dtEncargados;
        private DataGridViewTextBoxColumn idEncargadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn identificacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn primerApellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn segundoApellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private BindingSource encargadoDTOBindingSource1;
        private BindingSource encargadoDTOBindingSource;
    }
}