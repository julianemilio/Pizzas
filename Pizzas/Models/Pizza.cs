namespace Pizzas.Models
{
  public class Pizza
  {

    public string Masa { get; set; }
    public string Salsa { get; set; }
    public string Relleno { get; set; }
    public string Tamaño { get; set; }
    public bool EstaDoblada { get; set; }

    public override string ToString()
    {
      return $"{Masa}, {Salsa}, {Relleno}, {Tamaño}, {EstaDoblada}";
    }
  }
}
