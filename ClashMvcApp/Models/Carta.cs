namespace ClashMvcApp.Models
{
    public class Carta
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Rarity { get; set; }

        //Constructor
        public Carta(int id, string name, string rarity)
        {
            Id = id;
            Name = name;
            Rarity = rarity;
        }
    }
}
