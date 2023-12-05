using Core.Entities;

namespace Entities.Concrete;

public class Color: IEntity
{
    public string ColorId { get; set; } // PK
    public string ColorName { get; set; }
}