﻿using System;

class Program
{
  static void Main (string[] args)
  {

    Console.Write("Nota 1° Bimestre: ");
    double nota1 = double.Parse(Console.ReadLine());

    Console.Write("Nota 2° Bimestre: ");
    double nota2 = double.Parse(Console.ReadLine());

    Console.Write("Nota 3° Bimestre: ");
    double nota3 = double.Parse(Console.ReadLine());

    Console.Write("Nota 4° Bimestre: ");
    double nota4 = double.Parse(Console.ReadLine());

    double media = (nota1 + nota2 + nota3 + nota4) / 4.0;

    Console.WriteLine("\nMédia Final: " + media);
    
  }
   
}
