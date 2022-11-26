using System;

class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("testando condicionais");

        int idade = 68;
        bool ehIdoso = idade >= 65;
        
        if (idade >= 65 )
        {
            Console.WriteLine(ehIdoso);
        }
        else
        {
            Console.WriteLine("infelizmente voce nao pode entrar");
        }
    }
}