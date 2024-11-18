using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final_V2._1.Controllers;
using Proyecto_Final_V2._1.Models;

namespace Proyecto_Final_V2._1.Views
{
    public partial class ModificarCliente : Form
    {
        private ClienteController clienteController;
        private Cliente cliente;

        public ModificarCliente(Cliente cliente)
        {
            InitializeComponent();
            clienteController = new ClienteController();
            this.cliente = cliente;
            CargarDatosCliente();
        }

        private void CargarDatosCliente()
        {
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            mxtTelefono.Text = cliente.Telefono;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Telefono = mxtTelefono.Text;

            try
            {
                clienteController.ModificarCliente(cliente);
                MessageBox.Show("Cliente modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner is AsignarClienteView asignarClienteView)
            {
                asignarClienteView.CargarClientes();
                asignarClienteView.ActualizarMesa();
            }
        }

        // Evento FormClosed para notificar a AsignarClienteView

    }
}
