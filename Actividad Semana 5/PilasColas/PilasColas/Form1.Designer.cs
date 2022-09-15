
namespace PilasColas
{
    partial class frmPrincipal
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
            this.ltsPilas = new System.Windows.Forms.ListBox();
            this.btnMasPilas = new System.Windows.Forms.Button();
            this.btnMenosPilas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMenosColas = new System.Windows.Forms.Button();
            this.btnMasColas = new System.Windows.Forms.Button();
            this.lstColas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ltsPilas
            // 
            this.ltsPilas.FormattingEnabled = true;
            this.ltsPilas.ItemHeight = 16;
            this.ltsPilas.Location = new System.Drawing.Point(79, 123);
            this.ltsPilas.Name = "ltsPilas";
            this.ltsPilas.Size = new System.Drawing.Size(170, 244);
            this.ltsPilas.TabIndex = 0;
            // 
            // btnMasPilas
            // 
            this.btnMasPilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasPilas.Location = new System.Drawing.Point(198, 12);
            this.btnMasPilas.Name = "btnMasPilas";
            this.btnMasPilas.Size = new System.Drawing.Size(51, 36);
            this.btnMasPilas.TabIndex = 1;
            this.btnMasPilas.Text = "+";
            this.btnMasPilas.UseVisualStyleBackColor = true;
            this.btnMasPilas.Click += new System.EventHandler(this.btnMasPilas_Click);
            // 
            // btnMenosPilas
            // 
            this.btnMenosPilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenosPilas.Location = new System.Drawing.Point(198, 72);
            this.btnMenosPilas.Name = "btnMenosPilas";
            this.btnMenosPilas.Size = new System.Drawing.Size(51, 36);
            this.btnMenosPilas.TabIndex = 2;
            this.btnMenosPilas.Text = "-";
            this.btnMenosPilas.UseVisualStyleBackColor = true;
            this.btnMenosPilas.Click += new System.EventHandler(this.btnMenosPilas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pilas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Colas";
            // 
            // btnMenosColas
            // 
            this.btnMenosColas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenosColas.Location = new System.Drawing.Point(477, 72);
            this.btnMenosColas.Name = "btnMenosColas";
            this.btnMenosColas.Size = new System.Drawing.Size(51, 36);
            this.btnMenosColas.TabIndex = 6;
            this.btnMenosColas.Text = "-";
            this.btnMenosColas.UseVisualStyleBackColor = true;
            this.btnMenosColas.Click += new System.EventHandler(this.btnMenosColas_Click);
            // 
            // btnMasColas
            // 
            this.btnMasColas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasColas.Location = new System.Drawing.Point(477, 12);
            this.btnMasColas.Name = "btnMasColas";
            this.btnMasColas.Size = new System.Drawing.Size(51, 36);
            this.btnMasColas.TabIndex = 5;
            this.btnMasColas.Text = "+";
            this.btnMasColas.UseVisualStyleBackColor = true;
            this.btnMasColas.Click += new System.EventHandler(this.btnMasColas_Click);
            // 
            // lstColas
            // 
            this.lstColas.FormattingEnabled = true;
            this.lstColas.ItemHeight = 16;
            this.lstColas.Location = new System.Drawing.Point(358, 123);
            this.lstColas.Name = "lstColas";
            this.lstColas.Size = new System.Drawing.Size(170, 244);
            this.lstColas.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMenosColas);
            this.Controls.Add(this.btnMasColas);
            this.Controls.Add(this.lstColas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenosPilas);
            this.Controls.Add(this.btnMasPilas);
            this.Controls.Add(this.ltsPilas);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltsPilas;
        private System.Windows.Forms.Button btnMasPilas;
        private System.Windows.Forms.Button btnMenosPilas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMenosColas;
        private System.Windows.Forms.Button btnMasColas;
        private System.Windows.Forms.ListBox lstColas;
    }
}

