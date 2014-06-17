using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenRefactorizacion
{
    public class expediente
    {
        private static int num_max_asignaturas = 20;
        private int numeroasignaturascursadas;
        private calificacion[] calificaciones;

        public expediente()
        {
            calificaciones = new calificacion[num_max_asignaturas];
            numeroasignaturascursadas = 0;
        }


        public static int Num_max_asignaturas
        {
            get { return expediente.num_max_asignaturas; }
        }


        public bool ExpedienteLleno()
        {
            if (numeroasignaturascursadas < num_max_asignaturas)
                return false;
            else
                return true;
        }

        public void AddCalificacion(calificacion nuevacalificacion)
        {
            if ( ! ExpedienteLleno() )
            {
                calificaciones[numeroasignaturascursadas] = nuevacalificacion;
                numeroasignaturascursadas++;
            }
        }

        public void AddCalificacion(string nomasignatura, double notaasignatura)
        {
            calificacion nuevacalificacion = new calificacion(nomasignatura, notaasignatura);
            AddCalificacion(nuevacalificacion);

        }

        public double NotaMedia()
        {
            if ( numeroasignaturascursadas == 0)
                return 0;
            else
            {
                double acumulador = 0;
                for (int i = 0; i < numeroasignaturascursadas; i++)
                    acumulador += calificaciones[i].Nota;
                return acumulador / numeroasignaturascursadas;
            }
        }

        public string Mostrar()
        {
            string textocalificaciones = "";
            for (int i = 0; i < numeroasignaturascursadas; i++)
                textocalificaciones = textocalificaciones + calificaciones[i].Mostrar() + "; ";

            StringBuilder textoadevolver = new StringBuilder();
            textoadevolver.AppendLine("Número de Asignaturas: " + numeroasignaturascursadas);
            textoadevolver.AppendLine("Nota media: " + NotaMedia());
            textoadevolver.AppendLine(textocalificaciones);
            return textoadevolver.ToString();
            

        }

    }
}
