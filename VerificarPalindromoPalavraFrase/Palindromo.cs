using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarPalindromoPalavraFrase
{
    internal class Palindromo
    {
        public bool VerificarPalindromo(string texto, string textoInvertido)
        {
            char[] textoArray = texto.ToCharArray();
            char[] textoInvertidoArray = textoInvertido.ToCharArray();

            for (int i = 0; i < textoArray.Length; i++)
            {
                if (textoInvertidoArray[i] != textoArray[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
