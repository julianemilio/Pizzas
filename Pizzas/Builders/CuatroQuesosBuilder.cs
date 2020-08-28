
using Pizzas.Models;

namespace Pizzas.Builders
{
  public class CuatroQuesosBuilder : PizzaBuilder
  {
    public CuatroQuesosBuilder(string tamaño)
    {
      _pizza = new Pizza
      {
        Tamaño = tamaño
      };
    }
    public override void PasoPrepararMasa()
    {
      _pizza.Masa = "Cocido";
    }

    public override void PasoAñadirSalsa()
    {
      _pizza.Salsa = "Roquefort";
    }

    public override void PasoPrepararRelleno()
    {
      _pizza.Relleno = "mozzarela+gorgonzola+parmesano+ricotta";
    }
  }
}
