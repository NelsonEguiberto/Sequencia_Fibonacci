using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Solicita ao usuário para inserir o número a ser verificado
        Console.WriteLine("Digite um número para verificar se pertence à sequência de Fibonacci:");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Variáveis para armazenar os dois números anteriores da sequência
        int anterior = 0;
        int atual = 1;

        // Loop para gerar a sequência até ultrapassar o número fornecido
        while (atual < numero)
        {
            int proximo = anterior + atual;
            anterior = atual;
            atual = proximo;
        }

        // Verifica se o número fornecido está na sequência de Fibonacci
        if (atual == numero)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }

        Console.ReadLine(); // Aguarda o usuário pressionar Enter antes de fechar a janela
    }
}
