using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Local
    {
        private string ubicacion;
        private string gananciaPorMes;
        private string nroPersonal;
        private string tamaño;
        //Propiedades
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string GananciaPorMes { get => gananciaPorMes; set => gananciaPorMes = value; }
        public string NroPersonal { get => nroPersonal; set => nroPersonal = value; }
        public string Tamaño { get => tamaño; set => tamaño = value; }
        //Metodos
        public string Venta()
        {
            return "El metodo no esta implementado";
        }
        public string LlamaClientela()
        {
            return "El metodo no esta implementado";
        }
        public string DarTrabajo()
        {
            return "El metodo no esta implementado";
        }
    }
}
