namespace wDibujarLinea
{
    partial class frmDibujarLinea
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXI = new System.Windows.Forms.TextBox();
            this.txtXF = new System.Windows.Forms.TextBox();
            this.txtYF = new System.Windows.Forms.TextBox();
            this.txtYI = new System.Windows.Forms.TextBox();
            this.btnDibujarLinea = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xfinal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y inicial";
            // 
            // txtXI
            // 
            this.txtXI.Location = new System.Drawing.Point(210, 53);
            this.txtXI.Name = "txtXI";
            this.txtXI.Size = new System.Drawing.Size(132, 20);
            this.txtXI.TabIndex = 4;
            // 
            // txtXF
            // 
            this.txtXF.Location = new System.Drawing.Point(210, 93);
            this.txtXF.Name = "txtXF";
            this.txtXF.Size = new System.Drawing.Size(132, 20);
            this.txtXF.TabIndex = 5;
            // 
            // txtYF
            // 
            this.txtYF.Location = new System.Drawing.Point(432, 93);
            this.txtYF.Name = "txtYF";
            this.txtYF.Size = new System.Drawing.Size(132, 20);
            this.txtYF.TabIndex = 6;
            // 
            // txtYI
            // 
            this.txtYI.Location = new System.Drawing.Point(432, 51);
            this.txtYI.Name = "txtYI";
            this.txtYI.Size = new System.Drawing.Size(132, 20);
            this.txtYI.TabIndex = 7;
            // 
            // btnDibujarLinea
            // 
            this.btnDibujarLinea.Location = new System.Drawing.Point(337, 169);
            this.btnDibujarLinea.Name = "btnDibujarLinea";
            this.btnDibujarLinea.Size = new System.Drawing.Size(89, 52);
            this.btnDibujarLinea.TabIndex = 8;
            this.btnDibujarLinea.Text = "Dibujar Linea";
            this.btnDibujarLinea.UseVisualStyleBackColor = true;
            this.btnDibujarLinea.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad de lineas";
            // 
            // txtContar
            // 
            this.txtContar.Location = new System.Drawing.Point(323, 251);
            this.txtContar.Name = "txtContar";
            this.txtContar.Size = new System.Drawing.Size(120, 20);
            this.txtContar.TabIndex = 10;
            // 
            // frmDibujarLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtContar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDibujarLinea);
            this.Controls.Add(this.txtYI);
            this.Controls.Add(this.txtYF);
            this.Controls.Add(this.txtXF);
            this.Controls.Add(this.txtXI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDibujarLinea";
            this.Text = "DibujarLinea";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXI;
        private System.Windows.Forms.TextBox txtXF;
        private System.Windows.Forms.TextBox txtYF;
        private System.Windows.Forms.TextBox txtYI;
        private System.Windows.Forms.Button btnDibujarLinea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContar;
    }
}

