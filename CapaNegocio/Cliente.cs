using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Cliente
    {
        private string apellidos;
        private string nombres;
        private int edad;
        private string enfermedad;
        private string sexo;

        //Propiedades: Como partes de clase que permite acceder a tributos
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Enfermedad { get => enfermedad; set => enfermedad = value; }
        public string Sexo { get => sexo; set => sexo = value; }

        //Metodos
        public string Comprar()
        {
            return "Metodo comprar no esta implementado";
        }
        public string GenerarGananciaEmpresa()
        {
            return "Metodo generar ganancias a la empresa no esta implementado";
        }
        public string Pagar()
        {
            return "Metodo pagar no esta implementado";
        }
        public string RecogerProducto()
        {
            return "Metodo recoger producto no esta implementado";
        }
    }
}
