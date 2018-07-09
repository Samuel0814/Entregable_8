namespace RegistroLibros
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosDeTipoDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeTiposDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeLibrosToolStripMenuItem,
            this.registrosDeTipoDeLibrosToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registroDeLibrosToolStripMenuItem
            // 
            this.registroDeLibrosToolStripMenuItem.Name = "registroDeLibrosToolStripMenuItem";
            this.registroDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.registroDeLibrosToolStripMenuItem.Text = "Registro de libros";
            this.registroDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.registroDeLibrosToolStripMenuItem_Click);
            // 
            // registrosDeTipoDeLibrosToolStripMenuItem
            // 
            this.registrosDeTipoDeLibrosToolStripMenuItem.Name = "registrosDeTipoDeLibrosToolStripMenuItem";
            this.registrosDeTipoDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.registrosDeTipoDeLibrosToolStripMenuItem.Text = "Registros de tipo de libros";
            this.registrosDeTipoDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.registrosDeTipoDeLibrosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeLibrosToolStripMenuItem,
            this.consultaDeTiposDeLibrosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaDeLibrosToolStripMenuItem
            // 
            this.consultaDeLibrosToolStripMenuItem.Name = "consultaDeLibrosToolStripMenuItem";
            this.consultaDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.consultaDeLibrosToolStripMenuItem.Text = "Consulta de libros";
            this.consultaDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeLibrosToolStripMenuItem_Click);
            // 
            // consultaDeTiposDeLibrosToolStripMenuItem
            // 
            this.consultaDeTiposDeLibrosToolStripMenuItem.Name = "consultaDeTiposDeLibrosToolStripMenuItem";
            this.consultaDeTiposDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.consultaDeTiposDeLibrosToolStripMenuItem.Text = "Consulta de tipos de libros";
            this.consultaDeTiposDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeTiposDeLibrosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroLibros.Properties.Resources.SARD_400x200;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosDeTipoDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeTiposDeLibrosToolStripMenuItem;
    }
}

