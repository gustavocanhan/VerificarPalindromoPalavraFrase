using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarPalindromoPalavraFrase
{
    internal class InverterTexto
    {
        public string Inverter(string texto)
        {
            char[] textoArray = texto.ToCharArray();
            char[] textoInvertidoArray = new char[textoArray.Length];

            int contador = 0;

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                textoInvertidoArray[contador] = textoArray[i];
                contador++;
            }

            return string.Join("", textoInvertidoArray);
        }
    }
}
