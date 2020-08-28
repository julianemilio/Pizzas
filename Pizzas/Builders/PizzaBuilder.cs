using Pizzas.Models;

namespace Pizzas.Builders
{
 public abstract class PizzaBuilder
  {
    // Protected para que las clases que implementen puedan acceder
    protected Pizza _pizza;


    public Pizza ObtenerPizza() { return _pizza; }

    // Un paso para cada una de las propiedades
    public virtual void PasoPrepararMasa()
    {

    }

    public virtual void PasoAñadirSalsa()
    {

    }

    public virtual void PasoPrepararRelleno()
    {

    }

    public virtual void PasoDoblarPoizza()
    {

    }

  }
}
