using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final_V2._1.Models;

namespace Proyecto_Final_V2._1.Controllers
{
    public class ClienteController
    {
        private List<Cliente> clientes;
        private DataController dataController;

        public ClienteController()
        {
            dataController = new DataController();
            try
            {
                clientes = dataController.CargarClientes();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones al cargar los clientes
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clientes = new List<Cliente>();
            }
        }

        public List<Cliente> ObtenerClientes()
        {
            return clientes;
        }

        public void AgregarCliente(Cliente cliente)
        {
            if (cliente == null || string.IsNullOrWhiteSpace(cliente.Nombre) || string.IsNullOrWhiteSpace(cliente.Apellido))
            {
                throw new ArgumentException("El cliente debe tener un nombre y apellido válidos.");
            }

            // Generar un ID único para el nuevo cliente
            cliente.Id = clientes.Any() ? clientes.Max(c => c.Id) + 1 : 1;

            clientes.Add(cliente);
            GuardarClientes();
        }

        public void EliminarCliente(int id)
        {
            var cliente = clientes.Find(c => c.Id == id);
            if (cliente != null)
            {
                clientes.Remove(cliente);
                GuardarClientes();
            }
        }

        public void ModificarCliente(Cliente clienteModificado)
        {
            if (clienteModificado == null || string.IsNullOrWhiteSpace(clienteModificado.Nombre) || string.IsNullOrWhiteSpace(clienteModificado.Apellido))
            {
                throw new ArgumentException("El cliente debe tener un nombre y apellido válidos.");
            }

            var cliente = clientes.Find(c => c.Id == clienteModificado.Id);
            if (cliente != null)
            {
                cliente.Nombre = clienteModificado.Nombre;
                cliente.Apellido = clienteModificado.Apellido;
                cliente.Telefono = clienteModificado.Telefono;
                GuardarClientes();
            }
        }

        public void GuardarClientes()
        {
            try
            {
                dataController.GuardarClientes(clientes);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones al guardar los clientes
                MessageBox.Show($"Error al guardar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
