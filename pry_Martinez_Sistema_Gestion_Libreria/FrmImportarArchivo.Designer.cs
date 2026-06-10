namespace pry_Martinez_Sistema_Gestion_Libreria
{
    partial class FrmImportarProducto
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
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(25, 34);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(121, 28);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Seleccionar archivo";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(214, 37);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(103, 25);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar ";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // FrmImportarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(360, 342);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnSelecionar);
            this.Name = "FrmImportarProducto";
            this.Text = "Importar Producto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnImportar;
    }
}