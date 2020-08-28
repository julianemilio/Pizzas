using Pizzas.Models;

namespace Pizzas.Director
{
  //Director
  class Cocina
  {
    private Builders.PizzaBuilder _pizzaBuilder;

    public void RecepcionarProximaPizza(Builders.PizzaBuilder pizzaBuilder)
    {
      _pizzaBuilder = pizzaBuilder;
    }

    public void CocinarPizzaPasoAPaso()
    {
      _pizzaBuilder.PasoPrepararMasa();
      _pizzaBuilder.PasoAñadirSalsa();
      _pizzaBuilder.PasoPrepararRelleno();
    }

    public Pizza PizzaPreparada
    {
      get { return _pizzaBuilder.ObtenerPizza(); }
    }
  }
}
