using Proyecto_Final_V2._1.Models;
using System.Collections.Generic;

namespace Proyecto_Final_V2._1.Controllers
{
    public class MesaController
    {
        private List<Mesa> mesas;
        private DataController dataController;

        public MesaController()
        {
            dataController = new DataController();
            mesas = dataController.CargarMesas();
            if (mesas == null || mesas.Count < 15)
            {
                mesas = new List<Mesa>();
                for (int i = 1; i <= 15; i++)
                {
                    mesas.Add(new Mesa { Id = i, Estado = "Disponible" });
                }
                dataController.GuardarMesas(mesas);
            }
        }

        public List<Mesa> ObtenerMesas()
        {
            return dataController.CargarMesas();
        }

        public void CambiarEstadoMesa(int id, string nuevoEstado)
        {

            mesas = dataController.CargarMesas();

            var mesa = mesas.Find(m => m.Id == id);
            if (mesa != null)
            {
                mesa.Estado = nuevoEstado;
                dataController.GuardarMesas(mesas);
            }

        }

        public void AsignarClienteAMesa(int id, string nombreCliente)
        {
            mesas = dataController.CargarMesas();

            var mesa = mesas.Find(m => m.Id == id);
            if (mesa != null)
            {
                mesa.NombreCliente = nombreCliente;
                dataController.GuardarMesas(mesas);
            }

        }
    }
}
