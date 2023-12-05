using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

public interface ICarService
{
    List<Car> GetALl();
    List<Car> GetAllByColorId(string colorId);
    List<Car> GetAllByBrandId(string brandId);

    List<CarDetailDto> getCarDetails();
}