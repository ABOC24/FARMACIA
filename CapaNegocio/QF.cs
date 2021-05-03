using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class QF
    {
        private string apellidos;
        private string nombres;
        private string dni;
        private string estudios;
        private string especialidad;

        //Propiedades: Como parte de clase que permite acceder a los atributos

        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Estudios { get => estudios; set => estudios = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }

        //Metodos
        public string ControlCalidad()
        {
            return "Metodo Control de calidad no esta implementado";
        }
        public string ControlProcesos()
        {
            return "Metodo Control de procesos no esta implementado";
        }
        public string Preparacion()
        {
            return " Metodo Preparacion no esta implementado";
        }
        public string Produccion()
        {
            return " Metodo Produccion no esta implementado";
        }

    }
}
