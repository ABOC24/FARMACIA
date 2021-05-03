using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Producto
    {
        private string nombre;
        private string precio;
        private string presentacion;
        private DateTime fechaVencimiento;
        private DateTime fechaFabricacion;

        //Propiedades: Como parte de clase que permite acceder a los atributos

        public string Nombre { get => nombre; set => nombre = value; }
        public string Precio { get => precio; set => precio = value; }
        public string Presentacion { get => presentacion; set => presentacion = value; }
        public DateTime FechaVencimiento { get => this.fechaVencimiento; set => this.fechaVencimiento = value; }
        public DateTime FechaFabricacion { get => this.fechaFabricacion; set => this.fechaFabricacion = value; }

        //Metodos
        public string Caducar()
        {
            return "Metodo Caducar no esta implementado";
        }
        public string Curar()
        {
            return "Metodo Curar no esta implementado";
        }
    }
}
