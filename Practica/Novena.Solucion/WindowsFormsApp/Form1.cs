using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public string PathCurrent { get; set; }


        public Form1()
        {
            InitializeComponent();
            AsignarAtajosDeTeclado();
        }

        private void AsignarAtajosDeTeclado()
        {
            // Asignar atajos de teclado para las opciones del menú
            abrirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            guardarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            guardarComoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia de OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configurar las propiedades del cuadro de diálogo
            openFileDialog.InitialDirectory = "Escritorio"; // Directorio inicial

            // Filtro para que abra solo archivos .txt
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"; // Filtros de archivo
            //openFileDialog1.FilterIndex = 1; // Índice del filtro predeterminado

            // Mostrar el cuadro de diálogo y comprobar si el usuario hace clic en "Aceptar"
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                PathCurrent = openFileDialog.FileName;

                // Inicializamos un objeto StreamReader
                StreamReader reader = new StreamReader(PathCurrent, true);

                // Leemos y guardamos todo el contenido del .txt
                string content = reader.ReadToEnd();

                // Mostramos en el richTextBox el contenido del archivo
                richTextBox1.Text = content;
           
            }

        }


        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Al hacer click sobre "Guardar", se deberá guardar en el último archivo guardado
            //o abierto desde la interfaz.En el caso que no haya ningún "último archivo", se
            //comportará igual que la opción "Guardar como...".Reutilizar código.
            if (string.IsNullOrEmpty(PathCurrent))
            {
                GuardarComo();
            }
            else
            {
                GuardarArchivo(PathCurrent);
            }




        }

        private void GuardarArchivo(string pathCurrent) 
        {
            try
            {
                // Obtenemos el contenido del richTextBox
                string content = richTextBox1.Text;

                // Guardamos el contenido en el archivo
                File.WriteAllText(pathCurrent, content);

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }

        private void GuardarComo() 
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de texto |.txt";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtenemos la ruta del archivo guardado
                string path = saveFileDialog.FileName;

                // Obtenemos el contenido del richTextBox
                string content = richTextBox1.Text;

                // Guardamos el contenido en el archivo
                File.WriteAllText(path, content);

            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
