using System;
class HelloWorld {
  static void Main() {
         Console.WriteLine("Olá úsuario, por favor informe os dados a seguir.");
        
        int i, j, linhas, colunas;
        int[,] a = new int[20, 20];
        {
            Console.WriteLine("Digite o número de Linhas desejado:");
            linhas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de Colunas desejado:");
            colunas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os números que irão ficar na Diagonal da Matriz:");
            for (i = 1; i <= linhas; i++)
            {
                for (j = 1; j <= colunas; j++)
                {
                    if(i == j)
                    {
                        
                    a[i, j] = int.Parse(Console.ReadLine());
                   
                    }
                   
                    else
                    {
                        
                    a[i, j] = 0;
                    
                        
                    }
                }
            }
            //imprimir a matriz
            Console.WriteLine("Sua Matriz diagonal é essa:");
            for (i = 1; i <= linhas; i++)
            {
                for (j = 1; j <= colunas; j++)
                {
                    Console.Write("\t{0}", a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
