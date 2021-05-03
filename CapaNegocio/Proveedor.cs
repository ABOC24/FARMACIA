using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Proveedor
    {
        // Derfinir atributos de la clase
        private string nombres;
        private string calidad;
        private string reconocimento;

        //Propiedades: Como partes de clase que permite acceder a tributos
        public string Nombres { get => nombres; set => nombres = value; }
        public string Calidad { get => calidad; set => calidad = value; }
        public string Reconocimento { get => reconocimento; set => reconocimento = value; }

        //Metodos
        public string Abastecer()
        {
            return "Metodo abastecer no esta implementado";
        }
        public string GenerarGastoEconomico()
        {
            return "Metodo Generar Gasto Economico no esta implementado";
        }
    }
}
