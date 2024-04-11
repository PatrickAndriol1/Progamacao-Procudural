using System;

struct Pizza
{
    public int Id;
    public String Sabor;
    public double Preco;
}
class Program
{
    static void Main(string[] args)
    {
        Pizza pizza1;
        pizza1.Id = Convert.ToInt32(Console.ReadLine());
        pizza1.Sabor = Console.ReadLine();
        pizza1.Preco = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine(pizza1.Id);
        System.Console.WriteLine(pizza1.Sabor);
        System.Console.WriteLine(pizza1.Preco);
    }
}