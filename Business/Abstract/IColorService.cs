using Entities.Concrete;

namespace Business.Abstract;

public interface IColorService
{
    List<Color> GetALl();
    Color GetById(string colorId);
}