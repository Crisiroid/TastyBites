using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Recipe_Management.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [NotNull]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; } = 0;
        [NotNull]
        public bool IsDeleted { get; set; }
        [NotNull]
        public bool IsActive { get; set; }
        [NotNull]
        public bool IsFree { get; set; }
    }
}
