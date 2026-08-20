namespace LINQTasks_answers.Collections.ObjectsCollections
{
    public static class CarsCollections
    {
        public static List<Car> CarsWithTheSameCarType = new()
        {
             new Car(1, Marks.Audi, "A6", CarType.Sedan, Color.Yellow, 1560, 250),
             new Car(4, Marks.VW, "Passat", CarType.Sedan, Color.Green, 1590, 262),
             new Car(6, Marks.Toyota, "Camry", CarType.Sedan, Color.Green, 1530, 180),
             new Car(7, Marks.Skoda, "Superb", CarType.Sedan, Color.Red, weight: null),
        };

        public static List<Car> CarsWithDifferentCarTypes = new()
        {
            new Car(1, Marks.Audi, "A6", CarType.Sedan, Color.Yellow, 1560, 250),
            new Car(2, Marks.Mercedes, "GLE", CarType.Crossover, Color.White, 2150, 260),
            new Car(3, Marks.Mercedes, "Actros", CarType.Truck, Color.Red, 12000, 120),
            new Car(4, Marks.VW, "Passat", CarType.Sedan, Color.Green, 1590, 262),
            new Car(5, Marks.BMW, "X3", CarType.Crossover, Color.Blue, 1640, 270),
            new Car(6, Marks.Toyota, "Camry", CarType.Sedan, Color.Green, 1530, 180),
            new Car(7, Marks.Skoda, "Superb", CarType.Sedan, Color.Red),
            new Car(8, Marks.VW, "Crafter", CarType.Truck, Color.White, maxSpeed: 150),
            new Car(9, Marks.Peterbilt, "357", CarType.Truck, Color.Blue, weight: 15000),
            new Car(10, Marks.Citroen, "CX4", CarType.Crossover, Color.Yellow, maxSpeed: 220)

        };

        public static List<Car> CarsOwnedByOneUser = new()
        {
                new Car(1, Marks.Audi, "A6", CarType.Sedan, Color.Yellow, 1560, 250, UsersCollections.Adam.Name),
                new Car(2, Marks.Mercedes, "GLE", CarType.Crossover, Color.White, 2150, 260, UsersCollections.Petr.Name),
                new Car(4, Marks.VW, "Passat", CarType.Sedan, Color.Green, 1590, 262, UsersCollections.Olga.Name),
                new Car(6, Marks.Toyota, "Camry", CarType.Sedan, Color.Green, 1530, 180, UsersCollections.Adam.Name),
                new Car(7, Marks.Skoda, "Superb", CarType.Sedan, Color.Red, owner: UsersCollections.Elen.Name),
                new Car(8, Marks.VW, "Crafter", CarType.Truck, Color.White, maxSpeed : 150, owner : UsersCollections.Adam.Name),
                new Car(10, Marks.Citroen, "CX4", CarType.Crossover, Color.Yellow, maxSpeed : 220, owner : UsersCollections.Elgy.Name)
        };
    }

    public class Car
    {
        public int Id { get; set; }
        public Marks Mark { get; set; }
        public string Model { get; set; }
        public CarType CarType { get; set; }
        public int? Weight { get; set; }
        public int? MaxSpeed { get; set; }
        public Color Color { get; set; }
        public string? Owner { get; set; }

        public Car(int id, Marks mark, string model, CarType carType, Color color, int? weight = null, int? maxSpeed = null, string? owner = null)
        {
            Id = id;
            Mark = mark;
            Model = model;
            CarType = carType;
            Weight = weight;
            MaxSpeed = maxSpeed;
            Color = color;
            Owner = owner;
        }
    }

    public enum CarType
    {
        Sedan,
        Crossover,
        Truck
    }

    public enum Color
    {
        Red,
        Green,
        Blue,
        White,
        Yellow
    }

    public enum Marks
    {
        Audi,
        BMW,
        VW,
        Mercedes,
        Skoda,
        Citroen,
        Man,
        Toyota,
        Peterbilt
    }

}
