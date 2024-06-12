using ConsoleAppEntityFrameworkSample.Models;

namespace ConsoleAppEntityFrameworkSample.Repositories
{
    public interface IDatabaseRepository
    {
        void AddCar(Car car);
        List<Car> GetCarList();
        List<Car> GetCarListById(int id);
    }
}