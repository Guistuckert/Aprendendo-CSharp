using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o pojeto 8 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char) (65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Crursos de tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';

        string cursos = @"Cursos disponiveis:
- GO 
- C# 
- Python 
- Java";

        Console.WriteLine(cursos);

        string saudacao = "Olá, meu nome é ";
        string nome = "Rômulo ";
        string continuacao = "e minha idade é ";
        int idade = 100;
        Console.WriteLine(saudacao + nome + continuacao + idade);

        Console.WriteLine("tecle enter para fechar...");
        Console.ReadLine();
    }

}