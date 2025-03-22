using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Recipe_Management.Model
{
    public class Food
    {
        [Key]
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public int CategoryId { get;set; }
        public string Name { get; set; }
        public List<int> RequiredItems { get; set; }
        public string Recipe { get; set; }
        [NotNull]
        public bool IsDeleted { get; set; }
        [NotNull]
        public bool IsActive { get; set; }
    }
}
