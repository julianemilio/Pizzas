using Pizzas.Builders;
using Pizzas.Director;
using System;

namespace PizzaBuilder
{
  class Program
  {
    static void Main(string[] args)
    {
      var cocina = new Cocina();

      // un cliente pide una Pizza cuatro quesos familiar
      cocina.RecepcionarProximaPizza(new CuatroQuesosBuilder("Familiar"));
      cocina.CocinarPizzaPasoAPaso();
      var pizzaCuatroQuesos = cocina.PizzaPreparada;
      Console.WriteLine($"Pizza Cuatro quesos: {pizzaCuatroQuesos}");

      // otro cliente pide una Hawaiana
      cocina.RecepcionarProximaPizza(new HawaianaBuilder("Mediana"));
      cocina.CocinarPizzaPasoAPaso();
      var pizzaHawaiana = cocina.PizzaPreparada;
      Console.WriteLine($"Pizza Hawaianna: {pizzaHawaiana}");
      Console.ReadLine();

    }
  }
}