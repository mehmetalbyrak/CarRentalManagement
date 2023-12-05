using Core.Entities;

namespace Entities.DTOs;

public class CarDetailDto: IDto
{
    
    public string Id { get; set; }
    public string BrandId { get; set; }
    public string ColorName { get; set; }
}