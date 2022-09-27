
namespace RecetasSLN.presentación
{
    partial class FrmNuevaReceta
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarReceta = new System.Windows.Forms.Button();
            this.lbltotal_ingredientes = new System.Windows.Forms.Label();
            this.dgvNuevaReceta = new System.Windows.Forms.DataGridView();
            this.IDIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.cboIngredientes = new System.Windows.Forms.ComboBox();
            this.cboTipoReceta = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroReceta = new System.Windows.Forms.Label();
            this.cboChef = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevaReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(388, 578);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarReceta
            // 
            this.btnAgregarReceta.Location = new System.Drawing.Point(280, 578);
            this.btnAgregarReceta.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarReceta.Name = "btnAgregarReceta";
            this.btnAgregarReceta.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarReceta.TabIndex = 6;
            this.btnAgregarReceta.Text = "Aceptar";
            this.btnAgregarReceta.UseVisualStyleBackColor = true;
            this.btnAgregarReceta.Click += new System.EventHandler(this.btnAgregarReceta_Click);
            // 
            // lbltotal_ingredientes
            // 
            this.lbltotal_ingredientes.AutoSize = true;
            this.lbltotal_ingredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal_ingredientes.Location = new System.Drawing.Point(538, 536);
            this.lbltotal_ingredientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal_ingredientes.Name = "lbltotal_ingredientes";
            this.lbltotal_ingredientes.Size = new System.Drawing.Size(146, 17);
            this.lbltotal_ingredientes.TabIndex = 26;
            this.lbltotal_ingredientes.Text = "Total de ingredientes:";
            // 
            // dgvNuevaReceta
            // 
            this.dgvNuevaReceta.AllowUserToAddRows = false;
            this.dgvNuevaReceta.AllowUserToDeleteRows = false;
            this.dgvNuevaReceta.AllowUserToOrderColumns = true;
            this.dgvNuevaReceta.AllowUserToResizeColumns = false;
            this.dgvNuevaReceta.AllowUserToResizeRows = false;
            this.dgvNuevaReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuevaReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDIngrediente,
            this.clmIngrediente,
            this.clmCantidad});
            this.dgvNuevaReceta.Location = new System.Drawing.Point(52, 331);
            this.dgvNuevaReceta.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNuevaReceta.Name = "dgvNuevaReceta";
            this.dgvNuevaReceta.RowHeadersWidth = 51;
            this.dgvNuevaReceta.Size = new System.Drawing.Size(679, 185);
            this.dgvNuevaReceta.TabIndex = 25;
            // 
            // IDIngrediente
            // 
            this.IDIngrediente.HeaderText = "IDING";
            this.IDIngrediente.MinimumWidth = 6;
            this.IDIngrediente.Name = "IDIngrediente";
            this.IDIngrediente.Visible = false;
            this.IDIngrediente.Width = 125;
            // 
            // clmIngrediente
            // 
            this.clmIngrediente.HeaderText = "Ingrediente";
            this.clmIngrediente.MinimumWidth = 6;
            this.clmIngrediente.Name = "clmIngrediente";
            this.clmIngrediente.Width = 150;
            // 
            // clmCantidad
            // 
            this.clmCantidad.HeaderText = "Cantidad";
            this.clmCantidad.MinimumWidth = 6;
            this.clmCantidad.Name = "clmCantidad";
            this.clmCantidad.Width = 150;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(586, 272);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(145, 28);
            this.btnAGREGAR.TabIndex = 5;
            this.btnAGREGAR.Text = "agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // cboIngredientes
            // 
            this.cboIngredientes.FormattingEnabled = true;
            this.cboIngredientes.Location = new System.Drawing.Point(52, 276);
            this.cboIngredientes.Margin = new System.Windows.Forms.Padding(4);
            this.cboIngredientes.Name = "cboIngredientes";
            this.cboIngredientes.Size = new System.Drawing.Size(206, 24);
            this.cboIngredientes.TabIndex = 3;
            // 
            // cboTipoReceta
            // 
            this.cboTipoReceta.FormattingEnabled = true;
            this.cboTipoReceta.Location = new System.Drawing.Point(148, 202);
            this.cboTipoReceta.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoReceta.Name = "cboTipoReceta";
            this.cboTipoReceta.Size = new System.Drawing.Size(327, 24);
            this.cboTipoReceta.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(143, 95);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(456, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tipo de receta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cheff:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre:";
            // 
            // lblNumeroReceta
            // 
            this.lblNumeroReceta.AutoSize = true;
            this.lblNumeroReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroReceta.Location = new System.Drawing.Point(47, 45);
            this.lblNumeroReceta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroReceta.Name = "lblNumeroReceta";
            this.lblNumeroReceta.Size = new System.Drawing.Size(104, 25);
            this.lblNumeroReceta.TabIndex = 15;
            this.lblNumeroReceta.Text = "Receta #:";
            // 
            // cboChef
            // 
            this.cboChef.FormattingEnabled = true;
            this.cboChef.Location = new System.Drawing.Point(148, 145);
            this.cboChef.Margin = new System.Windows.Forms.Padding(4);
            this.cboChef.Name = "cboChef";
            this.cboChef.Size = new System.Drawing.Size(327, 24);
            this.cboChef.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(289, 276);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(76, 27);
            this.txtCantidad.TabIndex = 4;
            // 
            // FrmNuevaReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 640);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cboChef);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarReceta);
            this.Controls.Add(this.lbltotal_ingredientes);
            this.Controls.Add(this.dgvNuevaReceta);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.cboIngredientes);
            this.Controls.Add(this.cboTipoReceta);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumeroReceta);
            this.Name = "FrmNuevaReceta";
            this.Text = "FrmNuevaReceta";
            this.Load += new System.EventHandler(this.FrmNuevaReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevaReceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarReceta;
        private System.Windows.Forms.Label lbltotal_ingredientes;
        private System.Windows.Forms.DataGridView dgvNuevaReceta;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.ComboBox cboIngredientes;
        private System.Windows.Forms.ComboBox cboTipoReceta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroReceta;
        private System.Windows.Forms.ComboBox cboChef;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
    }
}