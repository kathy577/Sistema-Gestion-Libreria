namespace pry_Martinez_Sistema_Gestion_Libreria
{
    partial class frmHistorialVentas
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
            this.gbHistorial = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblVentastotales = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHistorial
            // 
            this.gbHistorial.Controls.Add(this.label1);
            this.gbHistorial.Controls.Add(this.lblVentastotales);
            this.gbHistorial.Controls.Add(this.dataGridView2);
            this.gbHistorial.Controls.Add(this.dataGridView1);
            this.gbHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHistorial.Location = new System.Drawing.Point(12, 12);
            this.gbHistorial.Name = "gbHistorial";
            this.gbHistorial.Size = new System.Drawing.Size(373, 328);
            this.gbHistorial.TabIndex = 0;
            this.gbHistorial.TabStop = false;
            this.gbHistorial.Text = "Historial de Ventas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(360, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 251);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(358, 51);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // lblVentastotales
            // 
            this.lblVentastotales.AutoSize = true;
            this.lblVentastotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentastotales.Location = new System.Drawing.Point(6, 29);
            this.lblVentastotales.Name = "lblVentastotales";
            this.lblVentastotales.Size = new System.Drawing.Size(115, 18);
            this.lblVentastotales.TabIndex = 2;
            this.lblVentastotales.Text = "Ventas totales";
            this.lblVentastotales.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ventas seleccionada";
            // 
            // frmHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(397, 355);
            this.Controls.Add(this.gbHistorial);
            this.Name = "frmHistorialVentas";
            this.Text = "Historial de Ventas";
            this.Load += new System.EventHandler(this.frmHistorialVentas_Load);
            this.gbHistorial.ResumeLayout(false);
            this.gbHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHistorial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblVentastotales;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
    }
}