using Core.Entities;

namespace Entities.Concrete;

public class Brand: IEntity
{
    public string BrandId { get; set; } // PK
    public string BrandName { get; set; }
}