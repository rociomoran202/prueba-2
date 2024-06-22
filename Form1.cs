namespace prueba_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void Form1_Load(object sender, EventArgs e)
        {
            using System;
            using System.Collections.Generic;
            using System.Windows.Forms;

namespace MiProyecto
    {
        public partial class Form1 : Form
        {
            // Crear una lista para almacenar los alumnos (simulaci�n de base de datos)
            private List<Alumno> alumnos = new List<Alumno>();

            public Form1()
            {
                object value = InitializeComponent();
            }

            // Clase para representar un alumno
            private class Alumno
            {
                public string Nombre { get; set; }
                public string Apellido { get; set; }
                public string Curso { get; set; }
            }

            // Evento de clic para el bot�n de registro de alumno
            private void btnRegistrar_Click(object sender, EventArgs e)
            {
                // Obtener datos del formulario
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string curso = txtCurso.Text;

                // Validar datos
                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(curso))
                {
                    MessageBox.Show("Por favor completa todos los campos.", "Error de validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear nuevo alumno y agregarlo a la lista
                Alumno nuevoAlumno = new Alumno
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Curso = curso
                };
                alumnos.Add(nuevoAlumno);

                // Limpiar campos
                LimpiarCampos();

                // Mostrar mensaje de �xito
                MessageBox.Show("Alumno registrado correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Evento de clic para el bot�n de actualizaci�n de alumno
            private void btnActualizar_Click(object sender, EventArgs e)
            {
                // Obtener datos del formulario
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string curso = txtCurso.Text;

                // Obtener �ndice seleccionado en la lista de alumnos (simulaci�n)
                int indice = ObtenerIndiceAlumnoSeleccionado();

                // Validar �ndice
                if (indice == -1)
                {
                    MessageBox.Show("Selecciona un alumno de la lista.", "Error de actualizaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Actualizar datos del alumno seleccionado
                alumnos[indice].Nombre = nombre;
                alumnos[indice].Apellido = apellido;
                alumnos[indice].Curso = curso;

                // Limpiar campos
                LimpiarCampos();

                // Mostrar mensaje de �xito
                MessageBox.Show("Alumno actualizado correctamente.", "Actualizaci�n exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Evento de clic para el bot�n de eliminaci�n de alumno
            private void btnEliminar_Click(object sender, EventArgs e)
            {
                // Obtener �ndice seleccionado en la lista de alumnos (simulaci�n)
                int indice = ObtenerIndiceAlumnoSeleccionado();

                // Validar �ndice
                if (indice == -1)
                {
                    MessageBox.Show("Selecciona un alumno de la lista.", "Error de eliminaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Eliminar alumno de la lista
                alumnos.RemoveAt(indice);

                // Limpiar campos
                LimpiarCampos();

                // Mostrar mensaje de �xito
                MessageBox.Show("Alumno eliminado correctamente.", "Eliminaci�n exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // M�todo para limpiar los campos del formulario
            private void LimpiarCampos()
            {
                txtNombre.Clear();
                txtApellido.Clear();
                txtCurso.Clear();
            }

            // M�todo para obtener el �ndice del alumno seleccionado en la lista (simulaci�n)
            private int ObtenerIndiceAlumnoSeleccionado()
            {
               
                return 0; // Cambia esto seg�n tu implementaci�n real
            }
        }
    }

}
    }
}
