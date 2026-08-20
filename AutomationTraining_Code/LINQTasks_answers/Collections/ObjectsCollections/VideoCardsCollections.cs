namespace LINQTasks_answers.Collections.ObjectsCollections
{
    public class VideoCard
    {
        public int Id { get; set; }
        public Company Company { get; set; }
        public Model Model { get; set; }

        public VideoCard(int id, Company company, Model model)
        {
            Id = id;
            Company = company;
            Model = model;
        }
    }

    public enum Company
    {
        Nvidia,
        AMD
    }

    public enum Model
    {
        Iris,
        RTX3060,
        RTX3070Ti,
        Vega,
        RX560
    }

}
