using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Proyecto_Final_V2._1.Controllers;
using Proyecto_Final_V2._1.Models;

namespace Proyecto_Final_V2._1.Views
{
    public partial class MesasView : Form
    {
        private MesaController mesaController;

        public MesasView()
        {
            InitializeComponent();
            mesaController = new MesaController();
            InicializarComboBox();
            ConfigurarDataGridView();
            CargarMesas();
        }

        private void InicializarComboBox()
        {
            cmbEstado.Items.Add("Disponible");
            cmbEstado.Items.Add("Ocupada");
            cmbEstado.Items.Add("Reservada");
            cmbEstado.SelectedIndex = 0; // Selecciona el primer estado por defecto
        }

        private void ConfigurarDataGridView()
        {
            dgvMesasView.AutoGenerateColumns = false;
            dgvMesasView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Name = "Id" // Asegúrate de que el nombre de la columna sea "Id"
            });
            dgvMesasView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado",
                Name = "Estado" // Asegúrate de que el nombre de la columna sea "Estado"
            });
            dgvMesasView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreCliente",
                HeaderText = "Cliente",
                Name = "NombreCliente" // Asegúrate de que el nombre de la columna sea "NombreCliente"
            });
        }

        private void CargarMesas()
        {
            var mesas = mesaController.ObtenerMesas();
            dgvMesasView.DataSource = null; // Limpiar la fuente de datos
            dgvMesasView.DataSource = mesas; // Asignar la nueva fuente de datos
        }

        private void btnActualizarMesas_Click(object sender, EventArgs e)
        {
            if (dgvMesasView.SelectedRows.Count > 0)
            {
                int id = (int)dgvMesasView.SelectedRows[0].Cells["Id"].Value;
                string nuevoEstado = cmbEstado.SelectedItem.ToString();
                mesaController.CambiarEstadoMesa(id, nuevoEstado);
                CargarMesas();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una mesa para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAsignarCliente_Click(object sender, EventArgs e)
        {
            if (dgvMesasView.SelectedRows.Count > 0)
            {
                int id = (int)dgvMesasView.SelectedRows[0].Cells["Id"].Value;
                AsignarClienteView asignarClienteView = new AsignarClienteView(id);
                asignarClienteView.ShowDialog();
                CargarMesas(); // Asegúrate de que este método se llame después de cerrar el formulario
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una mesa para asignar un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            if (dgvMesasView.SelectedRows.Count > 0)
            {
                int id = (int)dgvMesasView.SelectedRows[0].Cells["Id"].Value;
                // Lógica para realizar pedido en la mesa
                MessageBox.Show($"Realizar pedido en la mesa {id}", "Realizar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una mesa para realizar un pedido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
