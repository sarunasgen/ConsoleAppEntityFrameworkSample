using ConsoleAppEntityFrameworkSample.Database;
using ConsoleAppEntityFrameworkSample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFrameworkSample.Repositories
{
    public class DatabaseRepository : IDatabaseRepository
    {
        private CarsDbContext _dbContext;
        public DatabaseRepository()
        {
            _dbContext = new CarsDbContext();
        }

        public void AddCar(Car car)
        {
            _dbContext.Cars.Add(car);
            _dbContext.SaveChanges();
        }
        public List<Car> GetCarList()
        {
            return _dbContext.Cars.ToList();
        }

        public List<Car> GetCarListById(int id)
        {
            return _dbContext.Cars.Where(x => x.Id == id).ToList();
        }
    }
}
