using Core.Entities;

namespace Entities.Concrete;

public class Car :IEntity
{
    public string Id { get; set; } // PK

    public string BrandId { get; set; } // FK
    //public Brand CarBrand { get; set; } // Navigation property

    public string ColorId { get; set; } // FK
    //public Color CarColor { get; set; } // Navigation property

    public DateTime ModelYear { get; set; }
    public decimal DailyPrice { get; set; }
    public string Description { get; set; }
}