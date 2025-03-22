using Recipe_Management.Model;

namespace Recipe_Management.Services
{
    public interface IitemService
    {
        IEnumerable<Item> GetItems();
        Item GetItem(int Id);
        void CreateItem(Item item);
        void DeleteItem(int Id);
        void UpdateItem(Item item);
    }
}
