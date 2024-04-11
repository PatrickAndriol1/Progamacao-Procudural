using System;

struct Produto
{
    public int Id;
    public String nome;
    public double preco;
    public bool disponivelEmEstoque;
}
class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 4;
        Produto[] produtos = new Produto[TAMANHO_MATRIZ];
        PreencherMatriz(produtos);
        MostrarProdutosDisponiveis(produtos);
    }

    static void PreencherMatriz(Produto[] produtos)
    {
        for(int i = 0; i < produtos.Length; i++)
        {
            produtos[i].Id = Convert.ToInt32(Console.ReadLine());
            produtos[i].nome = Console.ReadLine();
            produtos[i].preco = Convert.ToDouble(Console.ReadLine());
            produtos[i].disponivelEmEstoque = Convert.ToBoolean(Console.ReadLine());
        }
    }

    static void MostrarProdutosDisponiveis(Produto[] produtos)
    {
        for(int i = 0; i < produtos.Length; i++)
        {
            if(produtos[i].disponivelEmEstoque == true)
            {
                System.Console.WriteLine(produtos[i].nome);
                System.Console.WriteLine(produtos[i].preco);
            }
        }
    }
}