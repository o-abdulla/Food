namespace Food.Models
{
    public class Menu
    {
        // properties
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }

        // constructor
        public Menu(string _name, float _price, string _description, string _img)
        {
            Name = _name;
            Price = _price;
            Description = _description;
            Img = _img;
        }
    }
}
