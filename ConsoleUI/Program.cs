using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI;

// solid
// open closed principle
internal abstract class Program
{
    public static void Main(string[] args)
    {
        CarTest();
        //ColorTest();
    }

    private static void ColorTest()
    {
        ColorManager colorManager = new ColorManager(new EfColorDal());
        foreach (var color in colorManager.GetALl())
        {
            Console.WriteLine(color.ColorName);
        }
    }

    private static void CarTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());

        foreach (var car in carManager.getCarDetails())
        {
            Console.WriteLine(car.BrandId + "/" + car.ColorName);
            //at here i wanna see brandId + colorName on screen sideby side so i am using DTO
        }
    }
}
