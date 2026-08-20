namespace LINQTasks_answers.Collections.ObjectsCollections
{
    public static class LaptopsCollection
    {
        public static List<Laptop> Laptops = new()
        {
            new Laptop (1, LaptopNames.HP, new string[] {UsersCollections.Adam.Name, UsersCollections.Olga.Name }),
            new Laptop (2, LaptopNames.Acer, new string[] { }),
            new Laptop (3, LaptopNames.Acer, new string[] {UsersCollections.Elgy.Name}),
            new Laptop (4, LaptopNames.Lenovo, new string[] {UsersCollections.Elen.Name}),
            new Laptop (7, LaptopNames.HP, new string[] {UsersCollections.Adam.Name})
        };

        public static List<Laptop> LaptopsWithVideoCards = new()
        {
            new Laptop (2, LaptopNames.Acer, new List<VideoCard> { new VideoCard(1, Company.Nvidia, Model.Iris), new VideoCard(2, Company.AMD, Model.RX560)}),
            new Laptop (3, LaptopNames.Acer, new List<VideoCard> { new VideoCard(1, Company.AMD, Model.Vega), new VideoCard(2, Company.Nvidia, Model.RTX3070Ti)}),
            new Laptop (4, LaptopNames.Lenovo, new List<VideoCard> { new VideoCard(2, Company.Nvidia, Model.RTX3060)}),
            new Laptop (10, LaptopNames.HP, new List<VideoCard> { new VideoCard(1, Company.AMD, Model.Vega), new VideoCard(2, Company.AMD, Model.RX560)}),
            new Laptop (7, LaptopNames.HP, new List<VideoCard> { new VideoCard(1, Company.AMD, Model.Vega)})
        };
    }

    public class Laptop
    {
        public int Id { get; set; }
        public LaptopNames Name { get; set; }
        public string[] Owners { get; set; }
        public List<VideoCard> VideoCards { get; set; }

        public Laptop(int id, LaptopNames name, string[] user)
        {
            Id = id;
            Name = name;
            Owners = user;
        }

        public Laptop(int id, LaptopNames name, List<VideoCard> videoCards)
        {
            Id = id;
            Name = name;
            VideoCards = videoCards;
        }
    }

    public enum LaptopNames
    {
        Acer,
        HP,
        Lenovo,
    }
}
