using Microsoft.Win32;
using System.CodeDom;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practico5
{
    public partial class Form1 : Form
    {
        private string imagePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void BFotos_Click(object sender, EventArgs e)
        {
            using (openFileDialog1)
            {
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagePath);
                    TxtFotos.Text = openFileDialog1.FileName;
                }
            }
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                TxtNombre.Text = char.ToUpper(TxtNombre.Text[0]) + TxtNombre.Text.Substring(1).ToLower();
            }
        }

        private void TxtApellido_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtApellido.Text))
            {
                TxtApellido.Text = char.ToUpper(TxtApellido.Text[0]) + TxtApellido.Text.Substring(1).ToLower();
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox  
            string apellido = TxtApellido.Text;
            string nombre = TxtNombre.Text;
            string saldo = TxtSaldo.Text;
            string ruta = TxtFotos.Text;
            DateTime fecha = dateTimePickerFechaNac.Value;
            string sexo;

            if (RBHombre.Checked)
            {
                sexo = "Hombre";
            }
            else
            {
                sexo = "Mujer";
            }

            if (string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(saldo) || (RBHombre.Checked == false && RBMujer.Checked == false)
                || string.IsNullOrEmpty(imagePath) || string.IsNullOrWhiteSpace(saldo))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que el saldo solo contenga números  
            if (!long.TryParse(saldo, out _))
            {
                MessageBox.Show("El saldo debe contener solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de que el apellido y nombre solo contengan letras  
            if (!apellido.All(char.IsLetter) || !nombre.All(char.IsLetter))
            {
                MessageBox.Show("El Apellido y el Nombre deben contener solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.Rows.Add(apellido, nombre, fecha, sexo, "Eliminar", saldo, pictureBox1.Image, ruta);
            TxtApellido.Clear();
            TxtNombre.Clear();
            TxtSaldo.Clear();
            pictureBox1.Image = null;
            TxtFotos.Clear(); ; // Limpiar la ruta de la imagen  

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            // Verifica si hay una fila seleccionada en el DataGridView  
            if (e.ColumnIndex == 4)
            {
                // Obtiene el registro que se va a eliminar (puedes personalizarlo según tus necesidades)
                var result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                              "Confirmar eliminación",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                // Si el usuario selecciona "Sí", procede a eliminar  
                if (result == DialogResult.Yes)
                {
                    // Eliminar la fila  
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                    // Aquí puedes agregar la lógica para eliminar el registro de tu base de datos si es necesario  
                    MessageBox.Show("Registro eliminado con éxito.");
                }
            }
            }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica que la columna sea la de saldo (por ejemplo, columna índice 2)
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Saldo")
            {
                // Asegúrate de que la celda no sea nula  
                if (e.Value != null && e.Value is string saldoString)
                {
                    // Intenta convertir el string a decimal  
                    if (decimal.TryParse(saldoString, out decimal saldo))
                    {
                        // Cambia el color de fondo si el saldo es menor a $50  
                        if (saldo < 50)
                        {
                            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        }
                        else
                        {
                            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White; // O el color por defecto  
                        }
                    }
                    else
                    {
                        // Opcionalmente puedes manejar el caso en que la conversión falle  
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White; // O el color por defecto  
                    }
                }
            }
        }
    }
}
