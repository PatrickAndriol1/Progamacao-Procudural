﻿using System;

class Program
{
  static void Main (string[] args)
  {
    
    Console.Write("Base do Triângulo: ");
    double baseTriangulo = double.Parse(Console.ReadLine());

    Console.Write("Altura do Triângulo: ");
    double alturaTriangulo = double.Parse(Console.ReadLine());

    double area = (baseTriangulo * alturaTriangulo) / 2.0;

    bool logica = area > 20;

    Console.WriteLine("A área do triângulo é maior que 20? " + logica);

  }
}
