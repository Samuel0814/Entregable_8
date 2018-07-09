namespace RegistroLibros.UI.Consultas
{
    partial class ConsultaTiposLibros
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
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.Criteriolabel = new System.Windows.Forms.Label();
            this.Filtrolabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(12, 63);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.Size = new System.Drawing.Size(660, 302);
            this.ConsultadataGridView.TabIndex = 14;
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Image = global::RegistroLibros.Properties.Resources.icons8_Print_32;
            this.Imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imprimirbutton.Location = new System.Drawing.Point(12, 384);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(89, 48);
            this.Imprimirbutton.TabIndex = 13;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CriteriotextBox);
            this.groupBox1.Controls.Add(this.FiltrocomboBox);
            this.groupBox1.Controls.Add(this.Criteriolabel);
            this.groupBox1.Controls.Add(this.Filtrolabel);
            this.groupBox1.Location = new System.Drawing.Point(36, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 46);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(278, 17);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(327, 20);
            this.CriteriotextBox.TabIndex = 3;
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Location = new System.Drawing.Point(60, 14);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(155, 21);
            this.FiltrocomboBox.TabIndex = 2;
            // 
            // Criteriolabel
            // 
            this.Criteriolabel.AutoSize = true;
            this.Criteriolabel.Location = new System.Drawing.Point(233, 20);
            this.Criteriolabel.Name = "Criteriolabel";
            this.Criteriolabel.Size = new System.Drawing.Size(39, 13);
            this.Criteriolabel.TabIndex = 1;
            this.Criteriolabel.Text = "Criterio";
            // 
            // Filtrolabel
            // 
            this.Filtrolabel.AutoSize = true;
            this.Filtrolabel.Location = new System.Drawing.Point(7, 20);
            this.Filtrolabel.Name = "Filtrolabel";
            this.Filtrolabel.Size = new System.Drawing.Size(29, 13);
            this.Filtrolabel.TabIndex = 0;
            this.Filtrolabel.Text = "Filtro";
            // 
            // ConsultaTiposLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 443);
            this.Controls.Add(this.ConsultadataGridView);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultaTiposLibros";
            this.Text = "ConsultaTiposLibros";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Label Criteriolabel;
        private System.Windows.Forms.Label Filtrolabel;
    }
}