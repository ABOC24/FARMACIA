using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Caja
    {
        //Atributos
        private string capitalDisponible;
        private string personalEncargado;

        //Propiedades
        public string CapitalDisponible { get => capitalDisponible; set => capitalDisponible = value; }
        public string PersonalEncargado { get => personalEncargado; set => personalEncargado = value; }

        //Metodos
        public string Cobrar()
        {
            return "El metodo no esta implementado";
        }
        public string Ingresos()
        {
            return "El metodo no esta implementado";
        }
        public string LlevarCuentas()
        {
            return "El metodo no esta implementado";
        }
    }
}
