using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca1.WinApp
{
    public class Forca
    {
        public string mensagemFinal;
        private string palavraSecreta;
        public List<char> letrasEncontradas;
        private int erros;

        public Forca()
        {
            mensagemFinal = "";
            palavraSecreta = ObterPalavraSecreta();
            letrasEncontradas = PopularLetrasEncontradas(palavraSecreta.Length);

            erros = 0;
        }

        public bool JogadorAcertou(char palpite)
        {
            bool letraFoiEncontrada = false;

            for (int i = 0; i < palavraSecreta.Length; i++)
            {
                if (palpite == palavraSecreta[i])
                {
                    letrasEncontradas[i] = palpite;
                    letraFoiEncontrada = true;
                }
            }

            if (letraFoiEncontrada == false)
                erros++;

            bool jogadorAcertou = new string(letrasEncontradas.ToArray()) == palavraSecreta;

            if (jogadorAcertou)
                mensagemFinal = $"Você acertou a palavra {palavraSecreta}, parabéns!";

            else if (JogadorPerdeu())
                mensagemFinal = "Você perdeu! Tente novamente...";

            return jogadorAcertou;
        }

        public bool JogadorPerdeu()
        {
            return erros == 5;
        }

        private string ObterPalavraSecreta()
        {
            List<string> palavras = new List<string> 
            {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "ABACATE",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
            };

            int indiceAleatorio = new Random().Next(palavras.Count);

            return palavras[indiceAleatorio];
        }

        private List<char> PopularLetrasEncontradas(int tamanho)
        {
            List<char> letrasEncontradas = new List<char>();

            for (int carectere = 0; carectere < tamanho; carectere++)
                letrasEncontradas.Add('_');

            return letrasEncontradas;
        }

    }
}
