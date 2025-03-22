using Recipe_Management.Model;
using Recipe_Management.Repositories;

namespace Recipe_Management.Services
{
    public class ItemService : IitemService
    {
        private readonly IItemRepository _itemRepository;
        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public IEnumerable<Item> GetItems()
        {
            return _itemRepository.GetAll();
        }
        public Item GetItem(int Id)
        {
            return _itemRepository.GetById(Id);
        }

        public void CreateItem(Item item)
        {
            try
            {
                _itemRepository.Add(item);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteItem(int Id)
        {
            try
            {
                _itemRepository.Delete(Id);
            }catch(Exception ex)
            {
                throw ex;
            }
        }


        public void UpdateItem(Item item)
        {
            try
            {
                _itemRepository.Update(item);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
