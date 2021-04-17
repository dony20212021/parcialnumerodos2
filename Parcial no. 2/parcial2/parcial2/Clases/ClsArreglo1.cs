using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2.Clases
{
    class ClsArreglo1
    {
        private int[] ArregloTemporal;
        private int[] datos;
        private int i, j, datoTemporal;
        private int tamanoArreglo = 0;

        public int TamañoArreglo()
        {
            return datos.Length;
        }
        public ClsArreglo1(int[] arreglo)
        {
            datos = arreglo;
            tamanoArreglo = datos.Length; // numero de datos
        }

        public int[] MetodoBurbuja()
        {
            ArregloTemporal = datos;

            for (i = 0; i < tamanoArreglo - 1; i++) 
            {
                for (j = i + 1; j < tamanoArreglo; j++)
                {
                    if (ArregloTemporal[i] > ArregloTemporal[j])
                    {
                        datoTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datoTemporal;
                    }
                }
            }
            return ArregloTemporal;
        }
    }
}
