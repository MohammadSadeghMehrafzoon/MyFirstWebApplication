namespace WebApplicationFirst.Models
{
    public class Projects
    {
        public Projects(int id, string name, string description, string image, string link )
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Link = link;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }

    
    }


   
    



}
