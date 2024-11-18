using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_V2._1.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int MesaId { get; set; }
        public List<Producto> Productos { get; set; }
        public string Estado { get; set; }
    }
}
