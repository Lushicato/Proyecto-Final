using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Proyecto_Final_V2._1.Models;

namespace Proyecto_Final_V2._1.Controllers
{
    public class DataController
    {
        private const string FilePath = "mesas.json";
        private const string ClientesFilePath = "clientes.json";

        public void GuardarMesas(List<Mesa> mesas)
        {
            var json = JsonSerializer.Serialize(mesas);
            File.WriteAllText(FilePath, json);
        }

        public List<Mesa> CargarMesas()
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<Mesa>>(json);
            }
            return new List<Mesa>();
        }
        public void GuardarClientes(List<Cliente> clientes)
        {
            var json = JsonSerializer.Serialize(clientes);
            File.WriteAllText(ClientesFilePath, json);
        }

        public List<Cliente> CargarClientes()
        {
            if (File.Exists(ClientesFilePath))
            {
                var json = File.ReadAllText(ClientesFilePath);
                return JsonSerializer.Deserialize<List<Cliente>>(json);
            }
            return new List<Cliente>();
        }
    }

}
