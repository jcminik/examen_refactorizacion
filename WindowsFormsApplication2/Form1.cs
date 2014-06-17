using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExamenRefactorizacion
{
    public partial class Form1 : Form
    {

        alumno alu = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLimpiarDatos_Click(object sender, EventArgs e)
        {
            
            VaciarTextBox();
            
            ActivarEscrituraEnDatosAlumno(true);

            alu = null;
        }

        private void ActivarEscrituraEnDatosAlumno(bool activar)
        {
            textBoxNombreAlumno.Enabled = activar;
            textBoxApellido1.Enabled = activar;
            textBoxApellido2.Enabled = activar;
        }

        private void VaciarTextBox()
        {
            textBoxNombreAlumno.Text = "";
            textBoxApellido1.Text = "";
            textBoxApellido2.Text = "";
            textBoxResultados.Text = "";
            VaciarTextBoxCalificacion();
            
        }

        private void VaciarTextBoxCalificacion()
        {
            textBoxMateria.Text = "";
            textBoxNota.Text = "";
        }

        private bool ValidarTextBoxDatosAlumno()
        {
            if (textBoxNombreAlumno.Text + textBoxApellido1.Text + textBoxApellido2.Text == "")
            {
                MessageBox.Show("Los datos de alumno se deben rellenar");

                return false;
            }
            else
                return true;
        }

        private void buttonAlmacenarCalificacion_Click(object sender, EventArgs e)
        {

            if (ValidarTextBoxDatosAlumno())
            {
                if ( AlumnoNoHaSidoCreado() )
                {
                    alu = new alumno(textBoxNombreAlumno.Text, textBoxApellido1.Text, textBoxApellido2.Text);
                    ActivarEscrituraEnDatosAlumno(false);
                }

                if (ValidarTextBoxMateriaNota())
                    if (alu.expedientealumno.ExpedienteLleno())
                        MessageBox.Show("Los cálculos son como mucho sobre " + expediente.Num_max_asignaturas + " asignaturas");
                    else
                        alu.expedientealumno.AddCalificacion(textBoxMateria.Text, Double.Parse(textBoxNota.Text));

                VaciarTextBoxCalificacion();

            }
            else
            {
                VaciarTextBox();
                ActivarEscrituraEnDatosAlumno(true);
            }
        }

        private bool AlumnoNoHaSidoCreado()
        {
            return alu == null;
        }

        private bool ValidarTextBoxMateriaNota()
        {
            
            //No se admiten datos vacíos en materia y nota
            if (textBoxMateria.Text == "" || textBoxNota.Text == "")
            {
                MessageBox.Show("Los datos de materia y nota se deben rellenar");
                return false;
            }

            //Comprobando que la nota es un número
            double nota;
            if (!Double.TryParse(textBoxNota.Text, out nota))
            {
                MessageBox.Show("La nota no es un número válido");
                return false;
            }


            return true;
        }

        private void buttonMostrarResultados_Click(object sender, EventArgs e)
        {
            if( ! AlumnoNoHaSidoCreado() )
                textBoxResultados.Text = alu.Mostrar();

        }
    }
}
