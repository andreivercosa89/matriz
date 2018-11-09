using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string [3, 3];


            string texto = "";
            string pedido = "";
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    if (coluna % 2 == 0)
                    {
                        pedido = "Nome";
                    }else{
                        pedido = "Sobrenome";
                    }
                        Console.WriteLine("Informe {0}:", pedido);
                    matriz[linha, coluna] = Console.ReadLine();
                }
                texto = "\n";
            }

            Console.Clear();
            texto = "";
            for (int linha = 0; linha < 3;linha++){
                for (int coluna = 0; coluna < 2;coluna++){

                    texto += matriz [linha, coluna]+" ";
                }
                texto += "\n";
            }

            Console.WriteLine(texto.ToUpper());

        }
    }
}
