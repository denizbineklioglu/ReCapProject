﻿using Business.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental { 
              CarID=3,
              CustomerID=3,
              RentDate= new DateTime(2021,2,12)
            });

        }
        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { BrandName = "Mercedes" });
            //brandManager.Delete(new Brand { BrandID = 6 });
            //brandManager.Update(new Brand { BrandID = 6, BrandName = "Rolls Royce" });
            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Purple" });
            colorManager.Delete(new Color { ColorID = 6 });
            var result = colorManager.GetAll();
            foreach (var color in result.Data)
            {
                Console.WriteLine(color.ColorName);
            }

        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                BrandID = 1,
                CarName = "HONDA",
                ColorID = 1,
                DailyPrice = 40000,
                Description = "Honda",
                ModelYear = 2000
            });
            carManager.Delete(new Car
            {
                CarID = 14
            });
            var result = carManager.GetAll();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName);
            }
            carManager.GetById(14);
            var resultt = carManager.GetCarDetailDtos();
            foreach (var car in resultt.Data)
            {
                Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName);
            }
        }
    }
}
