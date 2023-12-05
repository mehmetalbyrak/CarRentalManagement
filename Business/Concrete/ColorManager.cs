using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ColorManager:IColorService
{
    IColorDal _colorDal;

    public ColorManager(IColorDal colorDal)
    {
        _colorDal = colorDal;
    }

    public List<Color> GetALl()
    {
        return _colorDal.GetAll();
    }

    public Color GetById(string colorId)
    {
        return _colorDal.Get(c => c.ColorId == colorId);
    }
}