using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class BrandManager: IBrandService
{
    IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public List<Brand> GetALl()
    {
        return _brandDal.GetAll();
    }

    public Brand GetById(string brandId)
    {
        return _brandDal.Get(b => b.BrandId == brandId);
    }
}