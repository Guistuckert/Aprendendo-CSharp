using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 11 - Condicionais 2");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = false;

        if (idadeJoao >= 18 || grupo)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }
        

        Console.WriteLine("tecle enter para fechar...");
        Console.ReadLine();
    }

}