using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ReCapProject // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine(item.CarId+" "+item.BrandName+" "+item.ColorName+" "+item.DailyPrice+" "+item.Description);
            }
        }
    }
}