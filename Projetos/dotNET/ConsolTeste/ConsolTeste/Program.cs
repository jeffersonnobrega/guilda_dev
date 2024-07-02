using System;

class Estudando
{
    static void Main(string[] args)
    {
        /*//int a = Convert.ToInt32("s");
        //int b = int.Parse("l");
        //int inteiro = 5;
        //string c = inteiro.ToString();
        string letra = "5";
        int numero = 1;

        int.TryParse(letra, out numero);

        Console.WriteLine(numero);**/

        int Quantidade = 10;
        int QuantidadeEmEstroque = 14;

        if (QuantidadeEmEstroque >= Quantidade)
        {
            Console.WriteLine("Vendido");
        } else
        {
            Console.WriteLine("Não temos o produto");
        }

    }
}

