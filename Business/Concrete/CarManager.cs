using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), "Cars Listed");
        }

        public IDataResult<List<CarDetailDto>> GetCarsByBrandId(int id)
        {
            var cars = _carDal.GetAll(x => x.BrandId == id).Select(car => new CarDetailDto()).ToList();
            return new SuccessDataResult<List<CarDetailDto>>(cars);
        }

        public IDataResult<List<CarDetailDto>> GetCarsByColorId(int id)
        {
            var cars = _carDal.GetAll(x => x.ColorId == id).Select(car => new CarDetailDto()).ToList();
            return new SuccessDataResult<List<CarDetailDto>>(cars);

        }

        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult("Adding Successful");
        }

        public IResult Update(Car car)
        {
            if (car.Description.Length <= 2 && car.DailyPrice < 0)
            {
                return new ErrorResult("Invalid update");
            }
            _carDal.Update(car);
            return new SuccessResult("Updating Successful");
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult("Delete Successful");
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }
    }
}
