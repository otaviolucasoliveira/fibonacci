using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número:");

        // Lê a entrada do usuário e tenta converter para inteiro
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
           
            int a = 0;
            int b = 1;

            
            bool pertence = false;

            
            while (a <= numero)
            {
                if (a == numero)
                {
                    pertence = true; 
                    break; 
                }

                // Calcula o próximo número da sequência de Fibonacci
                int proximo = a + b;
                a = b; // Move para o próximo número
                b = proximo; // Atualiza b com o próximo número
            }

           
            if (pertence)
        
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            
            else
            
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
            
        }
        else
        
            Console.WriteLine("Por favor, insira um número válido.");
        
    }
}
