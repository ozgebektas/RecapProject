using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{CarId=1, BrandId=1, ColorId=2, DailyPrice=10000, ModelYear=2015, Description="2.el otomatik" },
                new Car{CarId=2, BrandId=1, ColorId=1, DailyPrice=15000, ModelYear=2016, Description="2.el sağ arka cam değişti" },
                new Car{CarId=3, BrandId=2, ColorId=5, DailyPrice=56121, ModelYear=2018, Description="1.el orjinal " },
                new Car{CarId=4, BrandId=5, ColorId=2, DailyPrice=76541, ModelYear=2013, Description="2.el çatlaklar giderildi" },
                new Car{CarId=5, BrandId=3, ColorId=3, DailyPrice=15644, ModelYear=1998, Description="3.el " }
            };

        }
        public void Add(Car t)
        {
            _cars.Add(t);
        }

        public void Delete(Car t)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == t.CarId);
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

        //aşağıda markanın id sine göre car listelensin 
        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car t)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == t.CarId);
            carToUpdate.BrandId = t.BrandId;
            carToUpdate.ColorId = t.ColorId;
            carToUpdate.DailyPrice = t.DailyPrice;
            carToUpdate.Description = t.Description;
            carToUpdate.ModelYear = t.ModelYear;
        }
    }
}
