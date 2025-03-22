using Recipe_Management.Model;

namespace Recipe_Management.Repositories
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAll();
        Item GetById(int id);
        void Add(Item item);
        void Update(Item item);
        void Delete(int id);
    }
}
