using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenRefactorizacion
{
    class alumno
    {
        string nombre;
        string apellido1;
        string apellido2;
        public expediente expedientealumno;


        public alumno(string nom, string ape1, string ape2)
        {
            nombre = nom;
            apellido1 = ape1;
            apellido2 = ape2;
            expedientealumno = new expediente();
        }

        public string MostrarDatosPersonales()
        {
            StringBuilder resultados = new StringBuilder();
            resultados.AppendLine("Nombre: " + nombre);
            resultados.AppendLine("Apellidos: " + apellido1 + " " + apellido2);
            return resultados.ToString();
        }

        public string Mostrar()
        {
            StringBuilder texto= new StringBuilder();
            texto.AppendLine(MostrarDatosPersonales());
            texto.AppendLine(expedientealumno.Mostrar());
            return texto.ToString();
        }

    }
}
