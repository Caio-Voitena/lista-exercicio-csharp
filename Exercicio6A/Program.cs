// Desenvolver um algoritmo para receber 1000 valores automaticamente dentro de um vetor e ordenar do menor para o maior.
// 1. Desenvolver o algoritmo de ordenação (Bubble Sort);
// 2. Utilizar uma função em C# para ordenação;

using System.Runtime.InteropServices;

int[] vetor = new int[100];

Random r = new Random();

for(int i = 0; i < vetor.Length; i++)
{
    vetor[i] = r.Next(1000);
}
for(int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

bool troca = false;
int tam_vetor = vetor.Length - 1;

do{
    troca = false;
    for(int i = 0; i < tam_vetor; i++)
    {
        if(vetor[i] > vetor[i + 1])
        {
            int aux = vetor[i];
            vetor[i] = vetor[i + 1];
            vetor[i + 1] = aux;
            troca = true;
            tam_vetor--;
        }
    }
}while(troca == true);

Console.WriteLine("\n");
for(int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}