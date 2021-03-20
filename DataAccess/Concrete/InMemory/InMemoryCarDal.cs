using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId=1,BrandId=1,ColorId=1,ModelYear=2012,DailyPrice=35,Description="Renault Clio"},
                new Car {CarId=2,BrandId=2,ColorId=4,ModelYear=2018,DailyPrice=125,Description="Bmw 5.20"},
                new Car {CarId=3,BrandId=3,ColorId=2,ModelYear=2015,DailyPrice=95,Description="Mercedes C180"},
                new Car {CarId=4,BrandId=4,ColorId=1,ModelYear=2016,DailyPrice=30,Description="Hyundai i20"},
                new Car {CarId=5,BrandId=1,ColorId=1,ModelYear=2012,DailyPrice=35,Description="Renault Megane"},
                new Car {CarId=6,BrandId=2,ColorId=2,ModelYear=2014,DailyPrice=75,Description="Bmw 3.20"},
                new Car {CarId=7,BrandId=5,ColorId=4,ModelYear=2012,DailyPrice=85,Description="Mazda Rx-8"},
            };

       
    }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

    }
}
