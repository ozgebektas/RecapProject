﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=2, DailyPrice=10000, ModelYear=2015, Description="2.el otomatik" },
                new Car{Id=2, BrandId=1, ColorId=1, DailyPrice=15000, ModelYear=2016, Description="2.el sağ arka cam değişti" },
                new Car{Id=3, BrandId=2, ColorId=5, DailyPrice=56121, ModelYear=2018, Description="1.el orjinal " },
                new Car{Id=4, BrandId=5, ColorId=2, DailyPrice=76541, ModelYear=2013, Description="2.el çatlaklar giderildi" },
                new Car{Id=5, BrandId=3, ColorId=3, DailyPrice=15644, ModelYear=1998, Description="3.el " }
            };

        }
        public void Add(Car t)
        {
            _cars.Add(t);
        }

        public void Delete(Car t)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == t.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }
        //aşağıda markanın id sine göre car listelensin 
        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car t)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == t.Id);
            carToUpdate.BrandId = t.BrandId;
            carToUpdate.ColorId = t.ColorId;
            carToUpdate.DailyPrice = t.DailyPrice;
            carToUpdate.Description = t.Description;
            carToUpdate.ModelYear = t.ModelYear;
        }
    }
}
