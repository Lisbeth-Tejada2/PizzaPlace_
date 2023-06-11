namespace PizzaPlace_.Shared
{
    public class CestasDeCompras
    {
        public Clientes Clientes { get; set; } = new Clientes();

        public List<int> Pedidos { get; set; } = new List<int>();

        public bool Pago { get; set; }

        public void Agregar(int pizzaId)
        => Pedidos.Add(pizzaId);

        public void RemoveAt(int pos)
        => Pedidos.RemoveAt(pos);
    }
}