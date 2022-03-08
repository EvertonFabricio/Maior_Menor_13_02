using System;

namespace Maior_Menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarar variavem 'num' com vetor de 15 numeros.
            float[] num = new float[15];          

            //laço de repetição pra ler os 15 numeros e guardar nos vetores da variavel num.
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite um número qualquer: ");
                num[i] = float.Parse(Console.ReadLine());
            }

            //Criar a variavel menor para receber o valor do primeiro vetor de 'num',
            float menor = num[0];
           
            //outro laço, aninhado com um if pra verificar se cada vetor da variavel 'num' é menor que o outro. 

            for (int i = 0; i < 15; i++)
            {
                if (num[i] < menor)                
                    menor = num[i];                               
            }

            //agora faz a mesma coisa que fez pro menor, só que pro maior. 

            float maior = num[0];
          
            for (int i = 0; i < 15; i++)
            {
                if (num[i] > maior)
                    maior = num[i];
            }

            //agora é só escrever a variavel maior e menor.

            Console.WriteLine($"O maior número digitado foi {maior}, e o menor número digitado foi {menor}.");

        }
    }
}
