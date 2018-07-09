namespace RegistroLibros.UI.Registros
{
    partial class RegistroTiposLibros
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
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.TipoIDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.TipoIDlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TipoIDnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(101, 77);
            this.DescripciontextBox.Multiline = true;
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(201, 41);
            this.DescripciontextBox.TabIndex = 10;
            // 
            // TipoIDnumericUpDown
            // 
            this.TipoIDnumericUpDown.Location = new System.Drawing.Point(101, 31);
            this.TipoIDnumericUpDown.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.TipoIDnumericUpDown.Name = "TipoIDnumericUpDown";
            this.TipoIDnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.TipoIDnumericUpDown.TabIndex = 8;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::RegistroLibros.Properties.Resources.icons8_Delete_File_32;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(218, 124);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(84, 54);
            this.Eliminarbutton.TabIndex = 13;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::RegistroLibros.Properties.Resources.icons8_Save_All_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(115, 124);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(94, 54);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::RegistroLibros.Properties.Resources.icons8_Create_32;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(15, 124);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(94, 54);
            this.Nuevobutton.TabIndex = 12;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::RegistroLibros.Properties.Resources.icons8_Search_Property_32;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(227, 17);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 54);
            this.Buscarbutton.TabIndex = 9;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.Location = new System.Drawing.Point(12, 80);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(63, 13);
            this.Descripcionlabel.TabIndex = 14;
            this.Descripcionlabel.Text = "Descripcion";
            // 
            // TipoIDlabel
            // 
            this.TipoIDlabel.AutoSize = true;
            this.TipoIDlabel.Location = new System.Drawing.Point(12, 38);
            this.TipoIDlabel.Name = "TipoIDlabel";
            this.TipoIDlabel.Size = new System.Drawing.Size(42, 13);
            this.TipoIDlabel.TabIndex = 15;
            this.TipoIDlabel.Text = "Tipo ID";
            // 
            // RegistroTiposLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 193);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.TipoIDnumericUpDown);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Descripcionlabel);
            this.Controls.Add(this.TipoIDlabel);
            this.Name = "RegistroTiposLibros";
            this.Text = "RegistroTiposLibros";
            ((System.ComponentModel.ISupportInitialize)(this.TipoIDnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.NumericUpDown TipoIDnumericUpDown;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label Descripcionlabel;
        private System.Windows.Forms.Label TipoIDlabel;
    }
}