namespace pry_Martinez_Sistema_Gestion_Libreria
{
    partial class frmClientesRegistrado
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
            this.dgvClientesR = new System.Windows.Forms.DataGridView();
            this.btnCargarReporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesR)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientesR
            // 
            this.dgvClientesR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesR.Location = new System.Drawing.Point(13, 42);
            this.dgvClientesR.Name = "dgvClientesR";
            this.dgvClientesR.Size = new System.Drawing.Size(343, 217);
            this.dgvClientesR.TabIndex = 0;
            this.dgvClientesR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCargarReporte
            // 
            this.btnCargarReporte.Location = new System.Drawing.Point(239, 275);
            this.btnCargarReporte.Name = "btnCargarReporte";
            this.btnCargarReporte.Size = new System.Drawing.Size(99, 27);
            this.btnCargarReporte.TabIndex = 1;
            this.btnCargarReporte.Text = "Cargar reporte";
            this.btnCargarReporte.UseVisualStyleBackColor = true;
            this.btnCargarReporte.Click += new System.EventHandler(this.btnCargarReporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte de Clientes Registrados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmClientesRegistrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(368, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarReporte);
            this.Controls.Add(this.dgvClientesR);
            this.Name = "frmClientesRegistrado";
            this.Text = "Reporte de Clientes Registrados";
            this.Load += new System.EventHandler(this.frmClientesRegistrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientesR;
        private System.Windows.Forms.Button btnCargarReporte;
        private System.Windows.Forms.Label label1;
    }
}