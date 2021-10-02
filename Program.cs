using System;

namespace KgCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Problema:\nUna tienda al por mayor de manzanas hace descuentos mientras mas compres. \nSi compras menos de 100 kilos, e kilo sale a $4. \nSi compras entre 100-500 kilos, el kilo sale a $3. \nSi compras entre 500-1000 kilos, el kilo sale en $2. \nSi compras mas de 1000 kilos, el kilo sale a $1. \nHaz un programa que calcule el precio segun los kilos que compres.");
      Console.WriteLine("Problem: \nA store offers discounts if you buy more. For example, this store is offering discount to customers who purchase more apples.\n");
      Console.WriteLine(@"OPTIONS:
        1. 100 kg of apples for $4.
        2. 100-500 kg of apples for $3.
        3. 500-1000 kg of apples for $2.
        4. 1000+ kg of apples for $1.
      ");
      //define a variable to keep track of the amount apples the customer will purchase
      Console.WriteLine("How many apples is the customer buying?: ");
      int kilograms = Convert.ToInt32(Console.ReadLine());
      int price = 0;
      if(kilograms < 100){
        price = kilograms * 4;
        Console.WriteLine($"The price for {kilograms}kg, is: {price}");
      }
      else if(kilograms <500){
        price = kilograms * 3;
        Console.WriteLine($"The price for {kilograms}kg, is: {price}.");
      }
      else if(kilograms <1000){
        price = kilograms * 4;
        Console.WriteLine($"The price for {kilograms}kg, is: {price}.");}
      else{price = 1;}
    }//end of Main method
  }
}
