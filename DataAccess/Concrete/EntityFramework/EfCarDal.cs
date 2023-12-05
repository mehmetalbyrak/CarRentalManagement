using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;


// NuGet
public class EfCarDal: EfEntityRepositoryBase<Car, CarRentalManagementContext>, ICarDal
{
    public List<CarDetailDto> getCarDetails()
    {
        using (CarRentalManagementContext context = new CarRentalManagementContext())
        {
            var result = from ca in context.Cars
                                              join c in context.Colors
                                               on ca.ColorId equals c.ColorId
                                               
                select new CarDetailDto { Id = ca.Id, BrandId = ca.BrandId, ColorName = c.ColorName };
            return result.ToList();
            
        }
    }
}