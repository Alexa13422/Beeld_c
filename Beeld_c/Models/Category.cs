using System.Collections.Generic;

namespace Beeld_c.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string IconPath { get; set; }
        public List<Category> SubCategories { get; set; }
    }
}