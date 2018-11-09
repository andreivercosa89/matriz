using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 2]; //criando matriz com 3 linhas e 2 colunas
            int[,] matriz_ = {{1,2}, { 1, 2 }, { 1, 2 }, { 1, 2 }};//criando matriz com 4 linhas e 2 colunas, inicializando os valores

            matriz[0, 0] = 1; // primeiro numero refere-se a linha e o segundo a coluna
            matriz[0, 1] = 2;

            matriz[1, 0] = 3;
            matriz[1, 1] = 4;

            matriz[2, 0] = 5;
            matriz[2, 1] = 6;

            string texto = "";
            for (int linha = 0; linha < 3;linha++){
                for (int coluna = 0; coluna < 2;coluna++){

                    texto += matriz [linha, coluna]+" ";
                }
                texto += "\n";
            }

            Console.WriteLine(texto);

        }
    }
}
