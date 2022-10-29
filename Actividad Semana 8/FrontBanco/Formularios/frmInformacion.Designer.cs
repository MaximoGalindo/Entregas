
namespace BancoSLN
{
    partial class frmInformacion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dgvCuentasClientes = new System.Windows.Forms.DataGridView();
            this.Col_CBU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimoMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_RetirarDinero = new System.Windows.Forms.Button();
            this.btn_ingresarDinero = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_NuevaCuenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewButtonColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(49, 228);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1034, 268);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "CBU";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Saldo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "TipoCuenta";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Ultimo Movimiento";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Acciones";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewButtonColumn1.Text = "Habilitar";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(860, 181);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(232, 24);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Text = "Mostrar Cuentas Desabilitadas";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dgvCuentasClientes
            // 
            this.dgvCuentasClientes.AllowDrop = true;
            this.dgvCuentasClientes.AllowUserToAddRows = false;
            this.dgvCuentasClientes.AllowUserToDeleteRows = false;
            this.dgvCuentasClientes.AllowUserToOrderColumns = true;
            this.dgvCuentasClientes.AllowUserToResizeColumns = false;
            this.dgvCuentasClientes.AllowUserToResizeRows = false;
            this.dgvCuentasClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCuentasClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuentasClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentasClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_CBU,
            this.Saldo,
            this.TipoCuenta,
            this.UltimoMov,
            this.Estado,
            this.Acciones});
            this.dgvCuentasClientes.Location = new System.Drawing.Point(51, 228);
            this.dgvCuentasClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCuentasClientes.Name = "dgvCuentasClientes";
            this.dgvCuentasClientes.RowHeadersVisible = false;
            this.dgvCuentasClientes.RowHeadersWidth = 51;
            this.dgvCuentasClientes.RowTemplate.Height = 24;
            this.dgvCuentasClientes.ShowCellErrors = false;
            this.dgvCuentasClientes.ShowCellToolTips = false;
            this.dgvCuentasClientes.ShowEditingIcon = false;
            this.dgvCuentasClientes.Size = new System.Drawing.Size(1034, 268);
            this.dgvCuentasClientes.TabIndex = 41;
            this.dgvCuentasClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentasClientes_CellContentClick);
            // 
            // Col_CBU
            // 
            this.Col_CBU.HeaderText = "CBU";
            this.Col_CBU.MinimumWidth = 6;
            this.Col_CBU.Name = "Col_CBU";
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.MinimumWidth = 6;
            this.Saldo.Name = "Saldo";
            // 
            // TipoCuenta
            // 
            this.TipoCuenta.HeaderText = "TipoCuenta";
            this.TipoCuenta.MinimumWidth = 6;
            this.TipoCuenta.Name = "TipoCuenta";
            // 
            // UltimoMov
            // 
            this.UltimoMov.HeaderText = "Ultimo Movimiento";
            this.UltimoMov.MinimumWidth = 6;
            this.UltimoMov.Name = "UltimoMov";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            // 
            // Acciones
            // 
            this.Acciones.HeaderText = "Acciones";
            this.Acciones.MinimumWidth = 6;
            this.Acciones.Name = "Acciones";
            this.Acciones.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Acciones.Text = "Desabilitar";
            this.Acciones.UseColumnTextForButtonValue = true;
            // 
            // btn_RetirarDinero
            // 
            this.btn_RetirarDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_RetirarDinero.Location = new System.Drawing.Point(377, 576);
            this.btn_RetirarDinero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_RetirarDinero.Name = "btn_RetirarDinero";
            this.btn_RetirarDinero.Size = new System.Drawing.Size(210, 50);
            this.btn_RetirarDinero.TabIndex = 39;
            this.btn_RetirarDinero.Text = "RETIRAR DINERO";
            this.btn_RetirarDinero.UseVisualStyleBackColor = true;
            this.btn_RetirarDinero.Click += new System.EventHandler(this.btn_RetirarDinero_Click);
            // 
            // btn_ingresarDinero
            // 
            this.btn_ingresarDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ingresarDinero.Location = new System.Drawing.Point(51, 576);
            this.btn_ingresarDinero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ingresarDinero.Name = "btn_ingresarDinero";
            this.btn_ingresarDinero.Size = new System.Drawing.Size(210, 50);
            this.btn_ingresarDinero.TabIndex = 38;
            this.btn_ingresarDinero.Text = "INGRESAR DINERO";
            this.btn_ingresarDinero.UseVisualStyleBackColor = true;
            this.btn_ingresarDinero.Click += new System.EventHandler(this.btn_ingresarDinero_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(316, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 36);
            this.label4.TabIndex = 45;
            this.label4.Text = "Informacion Clientes";
            // 
            // BTN_NuevaCuenta
            // 
            this.BTN_NuevaCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_NuevaCuenta.Location = new System.Drawing.Point(701, 576);
            this.BTN_NuevaCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_NuevaCuenta.Name = "BTN_NuevaCuenta";
            this.BTN_NuevaCuenta.Size = new System.Drawing.Size(169, 50);
            this.BTN_NuevaCuenta.TabIndex = 36;
            this.BTN_NuevaCuenta.Text = "NUEVA CUENTA";
            this.BTN_NuevaCuenta.UseVisualStyleBackColor = true;
            this.BTN_NuevaCuenta.Click += new System.EventHandler(this.BTN_NuevaCuenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(985, 576);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 50);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(46, 139);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(146, 25);
            this.lblInfo.TabIndex = 44;
            this.lblInfo.Text = "Informacion de:";
            // 
            // frmInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 709);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dgvCuentasClientes);
            this.Controls.Add(this.btn_RetirarDinero);
            this.Controls.Add(this.btn_ingresarDinero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_NuevaCuenta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInformacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion Cliente";
            this.Load += new System.EventHandler(this.frmInformacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dgvCuentasClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CBU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimoMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn Acciones;
        private System.Windows.Forms.Button btn_RetirarDinero;
        private System.Windows.Forms.Button btn_ingresarDinero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_NuevaCuenta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblInfo;
    }
}