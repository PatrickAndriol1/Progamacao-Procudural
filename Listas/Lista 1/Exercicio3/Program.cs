﻿using System;

class Program
{
  static void Main (string[] args)
  {

    Console.Write("Quantidade de moedas de 1 centavo: ");
    int moedas = int.Parse(Console.ReadLine());

    int reais = moedas / 100;

    int centavos = moedas % 100;

    Console.WriteLine("O total em dinheiro é " + reais + " reais e " + centavos + " centavos.");
    
  }
}