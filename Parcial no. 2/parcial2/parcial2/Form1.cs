using parcial2.Clases;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial2
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonArreglo_Click(object sender, EventArgs e)
        {
            int[] arreglo = new int[5];
            arreglo[0] = 10;
            arreglo[1] = 8;
            arreglo[2] = 16;
            arreglo[3] = 36;
            arreglo[4] = 1;

            ClsArreglo1 ObjArreglo = new ClsArreglo1(arreglo);
            int[] resultado = ObjArreglo.MetodoBurbuja();
            
            for (int indice=0; indice < arreglo.Length; indice++)
            {
                // listBoxResultado.Items.Add(arreglo[indice]);
                //listBoxResultado.Items.Add($"valor ={resultado[indice]} Pos={indice}");
                listBox1.Items.Add($"{resultado[indice]}");
            }
         
            //foreach (int r in arreglo)
            //{
             //   listBoxResultado.Items.Add($"valor ={r} Pos={");
            //}

        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "selecciona tu archivo plano";
            ofd.InitialDirectory = @"C:\Users\TF039\Downloads\Telegram Desktop";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String resultado = ar.LeerTodoArchivo(archivo);

                ArregloNotas = ar.LeerArchivo(archivo); // regresa arreglo 
                
                textBoxcontenido.Text = resultado;

            }
        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {


            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(',');
                listBoxNombres.Items.Add(datos[1]);
            }
           
        }
        private void buttonParcial1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int promedio, acumulador;
            acumulador = 0;

            int[] ordenParcial = new int[ArregloNotas.Length - 1];

            foreach (string linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(',');
                    listBox1.Items.Add(datos[2]);
                    acumulador = acumulador + Convert.ToInt32(datos[2]);
                    ordenParcial[contador - 1] = Convert.ToInt32(datos[3]);
                }
                contador++;
            }
            ClsArreglo1 funcArreglos = new ClsArreglo1(ordenParcial);
            ordenParcial = funcArreglos.MetodoBurbuja();
            int min = ordenParcial[0];
            int max = ordenParcial[ordenParcial.Length - 1];
            promedio = acumulador / contador - 1;
            MessageBox.Show($"El promedio es {promedio}\nmin={min}\nmax={max}");
        }

        private void buttonP2_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int promedio, acumulador;
            acumulador = 0;

            int[] ordenParcial = new int[ArregloNotas.Length - 1];

            foreach (string linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(',');
                    listBox2.Items.Add(datos[3]);
                    acumulador = acumulador + Convert.ToInt32(datos[3]);
                    ordenParcial[contador - 1] = Convert.ToInt32(datos[3]);
                }
                contador++;
            }
            ClsArreglo1 funcArreglos = new ClsArreglo1(ordenParcial);
            ordenParcial = funcArreglos.MetodoBurbuja();
            int min = ordenParcial[0];
            int max = ordenParcial[ordenParcial.Length - 1];
            promedio = acumulador / contador - 1;
            MessageBox.Show($"El promedio es {promedio}\nmin={min}\nmax={max}");
        }

        private void buttonParcial3_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int promedio, acumulador;
            acumulador = 0;

            int[] ordenParcial = new int[ArregloNotas.Length -1];

            foreach (string linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(',');
                    listBox3.Items.Add(datos[4]);
                    acumulador = acumulador + Convert.ToInt32(datos[4]);
                    ordenParcial[contador -1] = Convert.ToInt32(datos[4]);
                }
                contador++;
            }
            ClsArreglo1 funcArreglos = new ClsArreglo1(ordenParcial);
            ordenParcial = funcArreglos.MetodoBurbuja();
            int min = ordenParcial[0];
            int max = ordenParcial[ordenParcial.Length - 1];
            promedio = acumulador / contador - 1;
            MessageBox.Show($"El promedio es {promedio}\nmin={min}\nmax={max}");
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            textBoxcontenido.Text = ""; 
        }
    }
}
