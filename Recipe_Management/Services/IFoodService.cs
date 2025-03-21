using Recipe_Management.Model;

namespace Recipe_Management.Services
{
    public interface IFoodService
    {
        IEnumerable<Food> GetFoods();
        Food GetFood(int id);
        void CreateFood (Food food);
        void UpdateFood (Food food);
        void DeleteFood (int id);
    }
}
