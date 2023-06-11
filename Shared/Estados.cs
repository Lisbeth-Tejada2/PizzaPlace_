using PizzaPlace_.Shared;

namespace PizzaPlace_.Shared
{
    public class Estados
    {
        public Menu Menu { get; } = new Menu();

        public CestasDeCompras Cestas { get; } = new CestasDeCompras();

        public Interfaces Interfaces { get; set; } = new Interfaces();

        public decimal Montotal
        => Cestas.Pedidos.Sum(id => Menu.GetPizza(id)!.Precio);
    }
}