namespace Models;

    public class Category
    {
        public short CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string CategoryNameEn { get; set; } = null!;
        public string DescriptionEn { get; set; } = null!;
    }
