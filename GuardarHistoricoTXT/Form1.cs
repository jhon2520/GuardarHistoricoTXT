using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardarHistoricoTXT
{
    public partial class Form1 : Form
    {
        private string ruta = @"C:\Users\Jhon Romero\Desktop\Historico.txt";

        public Form1()
        {
            InitializeComponent();
        }

        #region Codigo

        #region Guardar Datos

        //Se crea el archivo plano y se escribe una primer linea
        private void CrearTxt(string ruta)
        {
            //si hay un archivo plano ya con datos diferentes en la misma ruta, este método suscribe el archivo
            using (StreamWriter streamWriter = File.CreateText(ruta))
            {
                streamWriter.WriteLine("Histórico base de prueba");
            }
        }

        //Se crea un método que una en un string todas las variables que se van a guardar
        private string UnirVariables()
        {
            string union = string.Join(";", this.dtpFecha.Value.ToString("dd/MM/yyyy"), this.tbxNombre.Text, this.tbxTelefono.Text, this.tbxEdad.Text, this.tbxCarrera.Text);
            return union;
        }
        //Se guardar la linea que se creó en el método anterior en una nueva linea del plano
        private void AgregarLinea(string ruta)
        {
            using (StreamWriter streamWriter = File.AppendText(ruta))
            {
                streamWriter.WriteLine(UnirVariables());
            }
        }

        #endregion

        #region TraerDatos

        //se valida que exista una dato con la fecha que se desa traer
        private string ValidarFecha(string ruta)
        {
            string fecha = this.dtpFecha.Value.ToString("d/MM/yyyy");
            string linea = (from dato in File.ReadLines(ruta) where dato.StartsWith(fecha) select dato).FirstOrDefault();

            if (linea == null)
            {
                MessageBox.Show($"No hay datos almacenado para la fecha {fecha}");
                linea = "N/A;N/A;N/A;N/A;N/A";
            }

            return linea;
        }
        //se crea un arreglo cortando la linea que el método anterior trajo
        private string[] RecortarLinea(string linea)
        {
            string[] arreglo = linea.Split(';');
            return arreglo;
        }
        //Se agregan los valores a cada uno de los tbx
        private void DesglozarLista(string[] array)
        {
            this.tbxFecha.Text = array[0];
            this.tbxNombre.Text = array[1];
            this.tbxTelefono.Text = array[2];
            this.tbxEdad.Text = array[3];
            this.tbxCarrera.Text = array[4];
        }

        #endregion

        #region Codigo Auxiliar
        private void LimpiarForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }

            }
        }
        #endregion

        #endregion

        #region Eventos

        private void btnCrearTXT_Click(object sender, EventArgs e)
        {
            CrearTxt(ruta);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarLinea(ruta);
                MessageBox.Show("Linea agregada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnTraerDatos_Click(object sender, EventArgs e)
        {
            try
            {
                DesglozarLista(RecortarLinea(ValidarFecha(ruta)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            this.tbxFecha.Text = this.dtpFecha.Value.ToString("dd/MM/yyyy");
        }
        #endregion


    }
}
