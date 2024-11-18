namespace Proyecto_Final_V2._1.Views
{
    partial class ModificarCliente
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
            btnAgregarCliente = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            mxtTelefono = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(70, 263);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(75, 23);
            btnAgregarCliente.TabIndex = 0;
            btnAgregarCliente.Text = "Agregar";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(204, 263);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 31);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 116);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 199);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefóno:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(132, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(147, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(132, 116);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(147, 23);
            txtApellido.TabIndex = 6;
            // 
            // mxtTelefono
            // 
            mxtTelefono.Location = new Point(132, 196);
            mxtTelefono.Mask = "0000-0000";
            mxtTelefono.Name = "mxtTelefono";
            mxtTelefono.Size = new Size(67, 23);
            mxtTelefono.TabIndex = 7;
            // 
            // ModificarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 299);
            Controls.Add(mxtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregarCliente);
            Name = "ModificarCliente";
            Text = "ModificarCliente";
            FormClosed += ModificarCliente_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarCliente;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private MaskedTextBox mxtTelefono;
    }
}