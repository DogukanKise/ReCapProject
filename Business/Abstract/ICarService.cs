using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        void AddCar(Car car);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColor(int colorId);
        List<CarDetailDto> GetCarDetails();
    }
}
