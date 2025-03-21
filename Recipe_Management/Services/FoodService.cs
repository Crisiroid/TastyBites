using Recipe_Management.Model;
using Recipe_Management.Repositories;

namespace Recipe_Management.Services
{
    public class FoodService : IFoodService
    {
        private readonly IFoodRepository _foodRepository;

        public FoodService(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public void CreateFood(Food food)
        {
            _foodRepository.Add(food);
        }

        public void DeleteFood(int id)
        {
            _foodRepository.Delete(id);
        }

        public Food GetFood(int id)
        {
            return _foodRepository.GetById(id);
        }

        public IEnumerable<Food> GetFoods()
        {
            return _foodRepository.GetAll();
        }

        public void UpdateFood(Food food)
        {
            _foodRepository.Update(food);
        }
    }
}
