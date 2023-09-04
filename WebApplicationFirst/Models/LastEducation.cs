namespace WebApplicationFirst.Models
{
    public class LastEducation
    {
        public LastEducation(int id, string titel,string image,string link, string description)
        {
            Id = id;
            Titel = titel;
            Image = image;
            Link = link;
            Description = description;
        }

        public int Id { get; set; }
        public string Titel { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
    }
}
