using Recipe_Management.Data;
using Recipe_Management.Model;

namespace Recipe_Management.Repositories
{
    public class FoodRepository : IFoodRepository
    {
        private readonly FoodRecipeDbContext _context;

        public FoodRepository(FoodRecipeDbContext context)
        {
            _context = context;
        }

        public async void Add(Food food)
        {
            _context.Add(food);
            await _context.SaveChangesAsync();
        }

        public async void Delete(int id)
        {
            var food =  _context.Foods.FirstOrDefault(x => x.Id == id);
            if(food!= null)
            {
                _context.Remove(food);
                await _context.SaveChangesAsync();
            }
        }

        public IEnumerable<Food> GetAll() => _context.Foods.ToList();

        public Food? GetById(int id) => _context.Foods.FirstOrDefault(x => x.Id == id);

        public async void Update(Food food)
        {
            _context.Update(food);
            await _context.SaveChangesAsync();
        }
    }
}
