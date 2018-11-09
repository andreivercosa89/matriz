using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string [3,3];


            string texto = "";
            string informacao = "";
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    if (coluna % 2 == 0)
                    {
                        informacao = "Nome";
                    }else{
                        informacao = "Sobrenome";
                    }
                        Console.WriteLine("Informe {0}:", informacao);
                    matriz[linha, coluna] = Console.ReadLine();
                }
                texto = "\n";
            }

            Console.Clear();
            texto = "";
            for (int linha = 0; linha < 3;linha++){
                for (int coluna = 0; coluna < 3;coluna++){

                    texto += matriz [linha, coluna]+" ";
                }
                texto += "\n";
            }

            Console.WriteLine(texto.ToUpper());

        }
    }
}
