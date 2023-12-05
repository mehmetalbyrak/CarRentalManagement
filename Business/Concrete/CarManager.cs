using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete;

public class CarManager: ICarService
{
    ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }


    public List<Car> GetALl()
    {
        // business code
        // authorization
        return _carDal.GetAll();
    }

    

    public List<Car> GetAllByColorId(string colorId)
    {
        return _carDal.GetAll(car =>car.ColorId == colorId);
    }

    public List<Car> GetAllByBrandId(string brandId)
    {
        return _carDal.GetAll(car =>car.BrandId == brandId);
    }

    public List<CarDetailDto> getCarDetails()
    {
        return _carDal.getCarDetails();
    }
}