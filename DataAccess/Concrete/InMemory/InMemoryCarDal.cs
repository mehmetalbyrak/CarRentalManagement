using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCarDal: ICarDal
{
    
    List<Car> _cars;

    public InMemoryCarDal()
    {
        _cars = new List<Car>
        {
            new Car{ Id = "ABC123", BrandId = "BMW", ColorId = "Black",
                ModelYear = new DateTime(2023, 1, 1),
                DailyPrice = 5000000.00m, Description = "Business Car"},
            
            new Car{ Id = "ABC124", BrandId = "Mercedes", ColorId = "Gray",
                ModelYear = new DateTime(2024, 1, 1),
                DailyPrice = 7000000.00m, Description = "Personal Car"},
            
            new Car{ Id = "ABC125", BrandId = "Ferrari", ColorId = "Red",
                ModelYear = new DateTime(2022, 1, 1),
                DailyPrice = 8000000.00m, Description = "Race Car"}
        };
        
        
    }
    public List<Car> GetAll()
    {
        return _cars;
    }

    public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public Car Get(Expression<Func<Car, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public void Add(Car car)
    {
        _cars.Add(car);
    }

    public void Update(Car car)
    {
        Car carToUpdate = _cars.SingleOrDefault(c=>c.Id == car.Id);
        carToUpdate.BrandId = car.BrandId;
        carToUpdate.ColorId = car.ColorId;
        carToUpdate.ModelYear = car.ModelYear;
        carToUpdate.Description = car.Description;
        carToUpdate.DailyPrice = car.DailyPrice;
    }

    public void Delete(Car car)
    {
        // linq -- Language Integrated Query
        
        Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);

        _cars.Remove(carToDelete);
    }

    public List<CarDetailDto> getCarDetails()
    {
        throw new NotImplementedException();
    }

    public List<Car> GetAllById(string Id)
    {
        return _cars.Where(c => c.Id == Id).ToList();
    }
}