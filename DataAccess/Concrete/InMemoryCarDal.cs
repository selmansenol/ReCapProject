using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=10,ColorId=100,ModelYear=2010,DailyPrice=280,Description="Sedan"},
                new Car{CarId=2,BrandId=20,ColorId=200,ModelYear=2011,DailyPrice=280,Description="HatchBack"},
                new Car{CarId=3,BrandId=30,ColorId=300,ModelYear=2012,DailyPrice=280,Description="Station Wagon"},
                new Car{CarId=4,BrandId=40,ColorId=400,ModelYear=2013,DailyPrice=280,Description="SUV"},
                new Car{CarId=5,BrandId=50,ColorId=500,ModelYear=2014,DailyPrice=280,Description="Couple"}
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

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
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
