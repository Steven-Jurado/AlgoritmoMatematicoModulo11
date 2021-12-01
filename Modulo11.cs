using System;

namespace AlgoritmoMatematicoModulo11
{
    public class Modulo11
    {
        public String InvertirCadena(String cadenaParaInvertir)
        {
            String cadenaInvertida = "";
            foreach (var cadena in cadenaParaInvertir)
            {
                cadenaInvertida = cadena + cadenaInvertida;
            }
            return cadenaInvertida;
        }

        public int ObtenerSumaPorDigitos(String cadenaInvertida)
        {
            int pivote = 2;
            int longitudCadena = cadenaInvertida.Length;
            int cantidadTotal = 0;
            int b = 1;

            for (int i = 0; i < longitudCadena; i++)
            {
                if (pivote == 8)
                {

                    pivote = 2;

                }

                int temporal = Convert.ToInt32("0" + cadenaInvertida.Substring(i, b));
                temporal *= pivote;
                pivote++;
                cantidadTotal += temporal;

            }

            cantidadTotal = 11 - cantidadTotal % 11;

            return cantidadTotal;

        }

    }
}
