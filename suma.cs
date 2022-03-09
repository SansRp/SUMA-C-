using System;
using System.Collections.Generic;
using System.Text; 

namespace Calculadora
{
 class Calculadora
 {
  static void Main(string[] args)
 {
 int suma = 0; 
 int contador = 0;
 
 while(contador < 10)
  {
   contador  = contador  + 1;
   suma = contador + suma;
   
  }
   System.Console.WriteLine( contador); 
   System.Console.WriteLine( suma);
  }
 }
}