using Business.Concrete;
using DataAccsess.Concrete.EntityFramework;
using DataAccsess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCarDetails();
            //AddCar();
        }

        private static void AddCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.Add(new Car
            {
                ModelYear = 2020,
                BrandId = 1,
                ColorId = 2,
                DailyPrice = 2000,
                Description = "2020 Model araba"

            });
            Console.WriteLine(result.Message);
        }

        private static void GetCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " / " + car.CarName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
                Console.WriteLine(result.Message);
            }
            
            
                
            
            
            
            
        }
    }
}
