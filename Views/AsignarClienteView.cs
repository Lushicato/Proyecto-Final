using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Proyecto_Final_V2._1.Controllers;
using Proyecto_Final_V2._1.Models;

namespace Proyecto_Final_V2._1.Views
{
    public partial class AsignarClienteView : Form
    {
        private ClienteController clienteController;
        private MesaController mesaController;
        private int mesaId;

        public AsignarClienteView(int mesaId)
        {
            InitializeComponent();
            clienteController = new ClienteController();
            mesaController = new MesaController();
            this.mesaId = mesaId;
            CargarClientes();
        }

        public void CargarClientes()
        {
            var clientes = clienteController.ObtenerClientes();
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientes;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int clienteId = (int)dgvClientes.SelectedRows[0].Cells["Id"].Value;
                var cliente = clienteController.ObtenerClientes().Find(c => c.Id == clienteId);
                if (cliente != null)
                {
                    string nombreCliente = $"{cliente.Nombre} {cliente.Apellido}";
                    mesaController.AsignarClienteAMesa(mesaId, nombreCliente);
                    MessageBox.Show("Cliente asignado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarMesa(); // Asegúrate de actualizar la mesa después de asignar el cliente
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para asignar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoCliente = new Cliente
            {
                Nombre = "Nuevo",
                Apellido = "Cliente",
                Telefono = "0000000000"
            };
            clienteController.AgregarCliente(nuevoCliente);
            CargarClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int clienteId = (int)dgvClientes.SelectedRows[0].Cells["Id"].Value;
                var cliente = clienteController.ObtenerClientes().Find(c => c.Id == clienteId);
                if (cliente != null)
                {
                    clienteController.EliminarCliente(clienteId);
                    CargarClientes();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int clienteId = (int)dgvClientes.SelectedRows[0].Cells["Id"].Value;
                var cliente = clienteController.ObtenerClientes().Find(c => c.Id == clienteId);
                if (cliente != null)
                {
                    // Abrir el formulario ModificarCliente y pasar el cliente seleccionado
                    using (var modificarClienteForm = new ModificarCliente(cliente))
                    {
                        modificarClienteForm.Owner = this; // Establecer el propietario del formulario
                        modificarClienteForm.FormClosed += new FormClosedEventHandler(ModificarCliente_FormClosed);
                        modificarClienteForm.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Evento FormClosed para actualizar la lista de clientes y la mesa
        private void ModificarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Guardar los cambios en los clientes antes de actualizar la mesa
            clienteController.GuardarClientes();
            CargarClientes();
            ActualizarMesa();
        }

        public void ActualizarMesa()
        {
            var mesa = mesaController.ObtenerMesas().Find(m => m.Id == mesaId);
            if (mesa != null)
            {
                // Actualizar el estado de la mesa y el nombre del cliente
                mesaController.CambiarEstadoMesa(mesaId, mesa.Estado); // Asumiendo que este método guarda los cambios
            }
            // Refrescar la interfaz de usuario para reflejar los cambios
            CargarMesas();
        }

        public void CargarMesas()
        {
            var mesas = mesaController.ObtenerMesas();
            // Aquí puedes actualizar cualquier control de la interfaz de usuario que muestre la lista de mesas
            // Por ejemplo, si tienes un DataGridView para mostrar las mesas, puedes actualizar su DataSource
            // dgvMesas.DataSource = null;
            // dgvMesas.DataSource = mesas;
        }
    }
}