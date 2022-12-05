using System.Diagnostics.Contracts;

namespace MadisonPizzeria.Models
{
    public class Ingredient
    {
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Sauce { get; set; }
        public string Cheese { get; set; }
		public string Meat { get; set; }
        public string Topping { get; set; }
		public bool Extra { get; set; }
        public float Cost { get; set; }
        
    }
}
