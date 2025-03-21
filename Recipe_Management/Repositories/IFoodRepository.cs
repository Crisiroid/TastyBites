using Recipe_Management.Model;

namespace Recipe_Management.Repositories
{
    public interface IFoodRepository
    {
        IEnumerable<Food> GetAll();
        Food? GetById(int id);
        void Add(Food food);
        void Update(Food food);
        void Delete(int id);
    }
}
