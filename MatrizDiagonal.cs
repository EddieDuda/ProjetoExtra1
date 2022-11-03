using System;
class HelloWorld {
  // criando um modulo para verificar se a escolha de linhas e colunas está dentre os nossos requisitos  
  static int escolhald(int tamanho){
    while(tamanho < 2 || tamanho > 16){
        if(tamanho < 2){
            Console.WriteLine("Não haverá diagonal, escolha outro número entre 2 e 16");
            tamanho = int.Parse(Console.ReadLine());
        }else if(tamanho > 16){
            Console.WriteLine("A matriz ficara difícil de visualizar, escolha outro número entre 2 e 16");
            tamanho = int.Parse(Console.ReadLine());            
        }
    }
    return tamanho;
  }
  //criando um modulo para prenchera matriz 
  //ela será preenchida com valores aleatórios 
  static void matriz(int[,] a, int tamanho){
    Random rnd = new Random();
    for (int i = 0; i < tamanho; i++){
        for (int j = 0; j < tamanho; j++){
            if(i == j){
                a[i, j] = rnd.Next(100); 
            }else{
                a[i, j] = 0;
            }
        }
    }
  }
  //criando um modulo para imprimir a matriz
  static void imprimir_a_matriz(int[,] a, int tamanho){
    Console.WriteLine("Sua Matriz diagonal é essa:");
        for (int i = 0; i < tamanho; i++){
            for (int j = 0; j < tamanho; j++){
                Console.Write("\t{0}", a[i, j]);
            }
            Console.WriteLine();
        }
  }
  static void Main() {
    int tamanho;
    int[,] a = new int[16,16];
        
    //Pedindo para o usuário determinar os numeros de linhas e colunas
    Console.WriteLine("Olá usuário, por favor informe o dado a seguir.");
    Console.WriteLine("Digite um numero entre 2 a 16 para ser o tamanho de linhas e colunas da matriz:");
    tamanho = int.Parse(Console.ReadLine());
        
    //Chamando o modulo deverificação do tamanho
    //Para verificar o valor colocado pelo usuário
    tamanho = escolhald(tamanho);
        
    //Criando a matriz com o tamanho dado pelo usuário    
    matriz(a, tamanho);
            
    //Imprimindo a matriz    
    imprimir_a_matriz(a, tamanho);
    }
}
