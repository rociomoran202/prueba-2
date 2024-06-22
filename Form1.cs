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
            // Crear una lista para almacenar los alumnos (simulación de base de datos)
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

            // Evento de clic para el botón de registro de alumno
            private void btnRegistrar_Click(object sender, EventArgs e)
            {
                // Obtener datos del formulario
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string curso = txtCurso.Text;

                // Validar datos
                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(curso))
                {
                    MessageBox.Show("Por favor completa todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Mostrar mensaje de éxito
                MessageBox.Show("Alumno registrado correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Evento de clic para el botón de actualización de alumno
            private void btnActualizar_Click(object sender, EventArgs e)
            {
                // Obtener datos del formulario
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string curso = txtCurso.Text;

                // Obtener índice seleccionado en la lista de alumnos (simulación)
                int indice = ObtenerIndiceAlumnoSeleccionado();

                // Validar índice
                if (indice == -1)
                {
                    MessageBox.Show("Selecciona un alumno de la lista.", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Actualizar datos del alumno seleccionado
                alumnos[indice].Nombre = nombre;
                alumnos[indice].Apellido = apellido;
                alumnos[indice].Curso = curso;

                // Limpiar campos
                LimpiarCampos();

                // Mostrar mensaje de éxito
                MessageBox.Show("Alumno actualizado correctamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Evento de clic para el botón de eliminación de alumno
            private void btnEliminar_Click(object sender, EventArgs e)
            {
                // Obtener índice seleccionado en la lista de alumnos (simulación)
                int indice = ObtenerIndiceAlumnoSeleccionado();

                // Validar índice
                if (indice == -1)
                {
                    MessageBox.Show("Selecciona un alumno de la lista.", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Eliminar alumno de la lista
                alumnos.RemoveAt(indice);

                // Limpiar campos
                LimpiarCampos();

                // Mostrar mensaje de éxito
                MessageBox.Show("Alumno eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Método para limpiar los campos del formulario
            private void LimpiarCampos()
            {
                txtNombre.Clear();
                txtApellido.Clear();
                txtCurso.Clear();
            }

            // Método para obtener el índice del alumno seleccionado en la lista (simulación)
            private int ObtenerIndiceAlumnoSeleccionado()
            {
               
                return 0; // Cambia esto según tu implementación real
            }
        }
    }

}
    }
}
