using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Recipe_Management.Model
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public int FoodId { get;set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Unit { get; set; }
        [NotNull]
        public bool IsDeleted { get; set; }
        [NotNull]
        public bool IsActive { get; set; }
    }
}
