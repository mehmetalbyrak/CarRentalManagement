using Entities.Concrete;

namespace Business.Abstract;

public interface IBrandService
{
    List<Brand> GetALl();
    Brand GetById(string brandId);
}