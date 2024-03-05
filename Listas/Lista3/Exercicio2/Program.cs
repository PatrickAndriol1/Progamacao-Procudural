using System;
class Program
{
    static void Main(string[]args)
    {
        Console.Write("Digite a quantidade de produtos comprados: ");
        int numeroProdutos = Convert.ToInt32(Console.ReadLine());

        double precoFinal = 0;
        const int FRETE_GRATIS = 150;

        int contador = 1;

        while (contador <= numeroProdutos)
        {
            Console.Write("Insira o valor do " + contador + "° produto: ");
            double valorProduto = Convert.ToDouble(Console.ReadLine());

            precoFinal += valorProduto;

            contador++;
        }

        if (precoFinal > FRETE_GRATIS)
        {
            Console.WriteLine("Parabéns! Você ganhou frete grátis em sua compra de valor " 
                + precoFinal);
        }
        else
        {
            Console.WriteLine("A compra não possui frete grátis");
        }
    }
}
