namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lblIngrese = new System.Windows.Forms.Label();
            this.btnObtenerLiquido = new System.Windows.Forms.Button();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIngrese
            // 
            this.lblIngrese.AutoSize = true;
            this.lblIngrese.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrese.Location = new System.Drawing.Point(28, 56);
            this.lblIngrese.Name = "lblIngrese";
            this.lblIngrese.Size = new System.Drawing.Size(246, 29);
            this.lblIngrese.TabIndex = 0;
            this.lblIngrese.Text = "Ingrese Sueldo Bruto:";
            this.lblIngrese.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnObtenerLiquido
            // 
            this.btnObtenerLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtenerLiquido.Location = new System.Drawing.Point(33, 135);
            this.btnObtenerLiquido.Name = "btnObtenerLiquido";
            this.btnObtenerLiquido.Size = new System.Drawing.Size(451, 50);
            this.btnObtenerLiquido.TabIndex = 1;
            this.btnObtenerLiquido.Text = "Sueldo Liquido";
            this.btnObtenerLiquido.UseVisualStyleBackColor = true;
            this.btnObtenerLiquido.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.Location = new System.Drawing.Point(266, 56);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(245, 35);
            this.txtSueldo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 373);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.btnObtenerLiquido);
            this.Controls.Add(this.lblIngrese);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngrese;
        private System.Windows.Forms.Button btnObtenerLiquido;
        private System.Windows.Forms.TextBox txtSueldo;
    }
}

