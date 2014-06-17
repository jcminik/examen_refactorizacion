using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenRefactorizacion
{
    public class calificacion
    {
        private string asignatura;
        private double nota;

        public calificacion()
        {
            asignatura = "";
            nota = 0;
        }

        public calificacion(string nombreasignatura, double notaobtenida)
        {
            asignatura = nombreasignatura;
            nota = notaobtenida;
        }

        public double Nota
        {
            get { return nota; }
        }


        public string Mostrar()
        {
            return asignatura + ": " + nota;
        }
    }
}
