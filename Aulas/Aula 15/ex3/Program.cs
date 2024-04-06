using System;

struct Heroi
{
  public int id;
  public String nome;
  public int level;
}

class Program
{
  static void Main(string[] args)
  {
    const int TAMANHO_VETOR = 3;
    Heroi[] herois = new Heroi[TAMANHO_VETOR];
    PreencherVetor(herois);
    GroupLevelUp(herois);
    ImprimirVetor(herois);
  }

  static void PreencherVetor(Heroi[] herois)
  {
    for(int i = 0; i < herois.Length; i++)
    {
      herois[i].id = Convert.ToInt32(Console.ReadLine());
      herois[i].nome = Console.ReadLine();
      herois[i].level = Convert.ToInt32(Console.ReadLine());
    }
  }
  
  static void GroupLevelUp(Heroi[] herois)
  {
    for(int i = 0; i < herois.Length; i++)
    {
      herois[i].level += 1;
    }
  }

  static void ImprimirVetor(Heroi[] herois)
  {
    for(int i = 0; i < herois.Length; i++)
    {
      System.Console.WriteLine(herois[i].id);
      System.Console.WriteLine(herois[i].nome);
      System.Console.WriteLine(herois[i].level);
    }
  }
}