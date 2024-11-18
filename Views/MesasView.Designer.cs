namespace Proyecto_Final_V2._1.Views
{
    partial class MesasView
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
            dgvMesasView = new DataGridView();
            btnActualizarMesas = new Button();
            cmbEstado = new ComboBox();
            btnAsignarCliente = new Button();
            btnRealizarPedido = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMesasView).BeginInit();
            SuspendLayout();
            // 
            // dgvMesasView
            // 
            dgvMesasView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMesasView.Location = new Point(0, -1);
            dgvMesasView.Name = "dgvMesasView";
            dgvMesasView.Size = new Size(799, 386);
            dgvMesasView.TabIndex = 0;
            // 
            // btnActualizarMesas
            // 
            btnActualizarMesas.Location = new Point(12, 391);
            btnActualizarMesas.Name = "btnActualizarMesas";
            btnActualizarMesas.Size = new Size(108, 23);
            btnActualizarMesas.TabIndex = 1;
            btnActualizarMesas.Text = "Actualizar Mesas";
            btnActualizarMesas.UseVisualStyleBackColor = true;
            btnActualizarMesas.Click += btnActualizarMesas_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(126, 392);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 2;
            // 
            // btnAsignarCliente
            // 
            btnAsignarCliente.Location = new Point(253, 391);
            btnAsignarCliente.Name = "btnAsignarCliente";
            btnAsignarCliente.Size = new Size(96, 23);
            btnAsignarCliente.TabIndex = 3;
            btnAsignarCliente.Text = "Asignar Cliente";
            btnAsignarCliente.UseVisualStyleBackColor = true;
            btnAsignarCliente.Click += btnAsignarCliente_Click;
            // 
            // btnRealizarPedido
            // 
            btnRealizarPedido.Location = new Point(355, 392);
            btnRealizarPedido.Name = "btnRealizarPedido";
            btnRealizarPedido.Size = new Size(96, 23);
            btnRealizarPedido.TabIndex = 4;
            btnRealizarPedido.Text = "Realizar Pedido";
            btnRealizarPedido.UseVisualStyleBackColor = true;
            btnRealizarPedido.Click += btnRealizarPedido_Click;
            // 
            // MesasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRealizarPedido);
            Controls.Add(btnAsignarCliente);
            Controls.Add(cmbEstado);
            Controls.Add(btnActualizarMesas);
            Controls.Add(dgvMesasView);
            Name = "MesasView";
            Text = "MesasView";
            ((System.ComponentModel.ISupportInitialize)dgvMesasView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMesasView;
        private Button btnActualizarMesas;
        private ComboBox cmbEstado;
        private Button btnAsignarCliente;
        private Button btnRealizarPedido;
    }
}