using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Prova_Logica_BNE_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("||||Desafio Tamanho do Edifício||||");
            Console.WriteLine();

            Console.WriteLine("Insira os Valores");
            Console.WriteLine("----------------------------");

            Console.Write("Altura do Andar: ");
            double andar = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------");

            Console.Write("Quantidates de Andares: ");
            int quant = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------");

            double tamanho = andar * quant;

            Console.WriteLine($"Tamanho do Edifício: {tamanho} Metros de Altura.");
            Console.WriteLine();
            Console.WriteLine("Digite Enter para Continuar");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("||||Desafio Maior, Menor e Média||||");
            Console.WriteLine();

            //###############################################################################

            int[] nuremos = new int [4];

            int maior = 0, menor = 0, soma = 0;
            
            Console.WriteLine("Insira os Valores");
            Console.WriteLine("----------------------------");

            for (int i = 0; i < nuremos.Length; i++)
            {
                
                Console.Write($"Digite o Valor do Index {i}: ");

                nuremos[i] = int.Parse(Console.ReadLine());

                soma += nuremos[i];

                if(i == 0)
                {
                    menor = nuremos[0];
                    maior = nuremos[0];
                }
                
                if (nuremos[i] < menor)
                {
                    menor = nuremos[i];
                }

                else if (nuremos[i] > maior)
                {
                    maior = nuremos[i];
                }

            }
            
            Console.WriteLine();
            int media = soma / 4;

            Console.WriteLine($"Maior Valor: {maior}");
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Menor Valor: {menor}");
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Média: {media}");
            Console.WriteLine("----------------------");
            Console.WriteLine("Digite Enter para Continuar");
            Console.ReadKey();
            Console.Clear();

            //###############################################################################
            Console.WriteLine();
            Console.WriteLine("||||Desafio Dois Arrays||||");
            Console.WriteLine();

            int[] values = { 1, 3, 35, 40, 85, 123, 121, 209, 200, 305, 350 };

            List<int> par = new List<int>();
            List<int> impar = new List<int>();
            
            int countPar = 0;
            int countImpar = 0;
            
            for (int i = 0; i < values.Length; i++)
            {
                
                if (values[i] % 2 == 0)
                {
                    par.Add(values[i]);
                    countPar++;
                }
                else if (values[i] % 2 != 0)
                {
                    impar.Add(values[i]);
                    countImpar++;
                }
            }
            
            for(int x = 0; x < countPar ; x++)
            {
                Console.WriteLine($"Numeros Pares: {par[x]}");
            }
            Console.WriteLine();
            for (int x = 0; x < countImpar; x++)
            {
                Console.WriteLine($"Numeros Impares: {impar[x]}");
            }
            Console.WriteLine();
            Console.WriteLine("Digite Enter para Continuar");
            Console.ReadKey();
            Console.Clear();

            //###############################################################################

            Console.WriteLine("||||Desafio Ordem Decrescente||||");
            Console.WriteLine();

            Console.WriteLine("Insira 5 Valores");
            Console.WriteLine("----------------------------");

            int[] num = new int[5];

            for(int i =0; i < num.Length; i++)
            {
                Console.Write($"Digite o Valor do Index {i}: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Array.Sort(num);
            foreach(int order in num)
            {
                Console.WriteLine($"Numeros Ordenados: {order}");
            }
            Console.WriteLine();

            Console.WriteLine("Digite Enter para Continuar");
            Console.ReadKey();
            Console.Clear();

            //###############################################################################

            Console.WriteLine("||||Desafio Quantidade de Vogais||||");
            Console.WriteLine();

            string texto;

            Console.WriteLine("Insira o Texto");

            texto = Console.ReadLine();

            Regex regex = new Regex("[aeiou]");

            int contVogais = regex.Matches(texto).Count;


            Console.WriteLine();
            Console.WriteLine($"Quantidade de Vogais: {contVogais}");
        }
    }
}
