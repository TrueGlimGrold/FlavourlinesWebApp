namespace FlavourlinesWebApp.Models
{
    public class Category
    {

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }


        // Default Constructor
        public Category() { }

        // Parameterized Constructor
        public Category(int categoryId, string name, string image, string description)
        {
            CategoryId = categoryId;
            Name = name;
            Image = image;
            Description = description;
        }

    }
}
