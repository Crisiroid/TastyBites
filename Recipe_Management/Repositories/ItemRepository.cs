using Recipe_Management.Data;
using Recipe_Management.Model;

namespace Recipe_Management.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly FoodRecipeDbContext _context; 
        public ItemRepository(FoodRecipeDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Item> GetAll()
        {
            return _context.Items;
        }

        public Item GetById(int id)
        {
            return _context.Items.FirstOrDefault(x => x.Id == id && x.IsActive && !x.IsDeleted);
        }

        public async void Add(Item item)
        {
            try
            {
                _context.Items.Add(item);
                await _context.SaveChangesAsync();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async void Delete(int id)
        {
            try
            {
                var item = _context.Items.FirstOrDefault(x => x.Id == id && x.IsActive && !x.IsDeleted);
                item.IsDeleted = true;
                item.IsActive = false;
                _context.Items.Update(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async void Update(Item item)
        {
            try
            {
                _context.Items.Update(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
