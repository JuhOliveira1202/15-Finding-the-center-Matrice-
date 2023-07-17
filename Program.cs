using System;

class Program
{
    public static void Main(string[] args)
    {
        int a = 0, b = 0;
        System.Console.WriteLine("Insira o nº de linhas da matriz:");
        a = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Insira o nº de colunas da matriz:");
        b = Convert.ToInt32(Console.ReadLine());

        int[,] func = new int[a, b];

        for (int l = 0; l < a; l++)
        {
            for (int c = 0; c < b; c++)
            {
                System.Console.WriteLine("Posição {0},{1}:", l + 1, c + 1);
                func[l, c] = Convert.ToInt32(Console.ReadLine());
            }
        }
        System.Console.WriteLine("--- CENTRO DA MATRIZ ---");
        bool lPar = false, cPar = false;

        if (a % 2 == 0)
        {
            lPar = true;
        }

        if (b % 2 == 0)
        {
            cPar = true;
        }

        for (int l = 0; l < a; l++)
        {
            for (int c = 0; c < b; c++)
            {
                if (cPar == false && lPar == false)
                {
                    if (l == a / 2 && c == b / 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
                else if (cPar == false && lPar == true)
                {

                    if ((l == a / 2 || l == (a / 2) - 1) && (c == (b - 1) / 2))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
                else if (cPar == true && lPar == false)
                {
                    if ((l == (a - 1) / 2) && (c == (b / 2) || c == (b / 2) - 1))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
                else if (lPar == true && cPar == true)
                {

                    if ((l == (a / 2) || l == (a / 2) - 1) && (c == (b / 2) || c == (b / 2) - 1))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }

                System.Console.Write("[{0}] ", func[l, c]);
                Console.ResetColor();
            }
            System.Console.WriteLine();
        }

    }

}
