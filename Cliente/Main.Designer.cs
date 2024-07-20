namespace Cliente
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new MenuStrip();
            prestamosToolStripMenuItem = new ToolStripMenuItem();
            nuevoPrestamoToolStripMenuItem = new ToolStripMenuItem();
            misPrestamosToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            conectarseToolStripMenuItem = new ToolStripMenuItem();
            desconectarseToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { prestamosToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // prestamosToolStripMenuItem
            // 
            prestamosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoPrestamoToolStripMenuItem, misPrestamosToolStripMenuItem });
            prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            prestamosToolStripMenuItem.Size = new Size(74, 20);
            prestamosToolStripMenuItem.Text = "Prestamos";
            // 
            // nuevoPrestamoToolStripMenuItem
            // 
            nuevoPrestamoToolStripMenuItem.Name = "nuevoPrestamoToolStripMenuItem";
            nuevoPrestamoToolStripMenuItem.Size = new Size(180, 22);
            nuevoPrestamoToolStripMenuItem.Text = "Nuevo Prestamo";
            nuevoPrestamoToolStripMenuItem.Click += nuevoPrestamoToolStripMenuItem_Click;
            // 
            // misPrestamosToolStripMenuItem
            // 
            misPrestamosToolStripMenuItem.Name = "misPrestamosToolStripMenuItem";
            misPrestamosToolStripMenuItem.Size = new Size(180, 22);
            misPrestamosToolStripMenuItem.Text = "Mis Prestamos";
            misPrestamosToolStripMenuItem.Click += misPrestamosToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripDropDownButton1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(64, 17);
            toolStripStatusLabel1.Text = "Conexión: ";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { conectarseToolStripMenuItem, desconectarseToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 20);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // conectarseToolStripMenuItem
            // 
            conectarseToolStripMenuItem.Name = "conectarseToolStripMenuItem";
            conectarseToolStripMenuItem.Size = new Size(150, 22);
            conectarseToolStripMenuItem.Text = "Conectarse";
            // 
            // desconectarseToolStripMenuItem
            // 
            desconectarseToolStripMenuItem.Name = "desconectarseToolStripMenuItem";
            desconectarseToolStripMenuItem.Size = new Size(150, 22);
            desconectarseToolStripMenuItem.Text = "Desconectarse";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            Name = "Main";
            Text = "Cliente - Videoteca de la Universidad Estatal a Distancia";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            MouseEnter += Main_MouseEnter;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem prestamosToolStripMenuItem;
        private ToolStripMenuItem nuevoPrestamoToolStripMenuItem;
        private ToolStripMenuItem misPrestamosToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem conectarseToolStripMenuItem;
        private ToolStripMenuItem desconectarseToolStripMenuItem;
    }
}
