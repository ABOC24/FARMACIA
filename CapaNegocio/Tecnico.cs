using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Tecnico
    {
        // Derfinir atributos de la clase
        private string apellidos;
        private string nombres;
        private string experienciaLaboral;
        private string estudios;
        private string domicilio;

        //Propiedades: Como partes de clase que permite acceder a tributos
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string ExperienciaLaboral { get => experienciaLaboral; set => experienciaLaboral = value; }
        public string Estudios { get => estudios; set => estudios = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }

        //Metodos
        public string ControlarVentas()
        {
            return "Metodo controlar ventas no esta implementado";
        }
        public string AtenderVentas()
        {
            return "Metodo atender ventas no esta implementado";
        }
        public double BalanceDiario()
        {
            return 0;
        }
    }
}
