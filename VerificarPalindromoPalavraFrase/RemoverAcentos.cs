using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarPalindromoPalavraFrase
{
    internal class RemoverAcentos
    {
        public string RemoverAcentosFrase(string texto)
        {
            string textoSemAcento = texto;

            string[] vogaisAcentuadas = {
                "á", "à", "â", "ã",
                "é", "è", "ê",
                "í", "ì", "î",
                "ó", "ò", "ô", "õ",
                "ú", "ù", "û",
                "ç"
            };

            for (int i = 0; i < vogaisAcentuadas.Length; i++)
            {
                if (textoSemAcento.Contains(vogaisAcentuadas[i]))
                {
                    if (i >= 0 && i <= 3)
                    {
                        textoSemAcento = textoSemAcento.Replace(vogaisAcentuadas[i], "a");
                    }
                    else if (i >= 4 && i <= 6)
                    {
                        textoSemAcento = textoSemAcento.Replace(vogaisAcentuadas[i], "e");
                    }
                    else if (i >= 7 && i <= 9)
                    {
                        textoSemAcento = textoSemAcento.Replace(vogaisAcentuadas[i], "i");
                    }
                    else if (i >= 10 && i <= 13)
                    {
                        textoSemAcento = textoSemAcento.Replace(vogaisAcentuadas[i], "o");
                    }
                    else if (i >= 14 && i <= 16)
                    {
                        textoSemAcento = textoSemAcento.Replace(vogaisAcentuadas[i], "u");
                    }
                    else if (i == 17)
                    {
                        textoSemAcento = textoSemAcento.Replace(vogaisAcentuadas[i], "c");
                    }
                }
            }

            return textoSemAcento;
        }

    }
}
