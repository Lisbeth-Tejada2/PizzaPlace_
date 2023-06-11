using PizzaPlace_.Shared;

namespace PizzaPlace_.Shared
{
    public class Pizzas
    {
        public Pizzas(int id, string nombre, decimal precio, Picantes picantes)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Picante = picantes;
        }
        public int Id { get; }
        public string Nombre { get; }
        public decimal Precio { get; }
        public Picantes Picante { get; }
    }
}