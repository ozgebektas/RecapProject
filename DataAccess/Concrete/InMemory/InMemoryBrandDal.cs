using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;

        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
                {
                    new Brand{ Id=1, BrandName="Ford"},
                    new Brand{ Id=2, BrandName="Audi"},
                    new Brand{ Id=3, BrandName="BMW"},
                    new Brand{ Id=4, BrandName="Hyundai"},
                    new Brand{ Id=5, BrandName="Mercedes"},
                    new Brand{ Id=6, BrandName="Renault"},
                    new Brand{ Id=7, BrandName="Toyota"},
                    new Brand{ Id=8, BrandName="Volvo"}
                };
        }

        public void Add(Brand t)
        {
            _brands.Add(t);
        }

        public void Delete(Brand t)
        {
            Brand brandToDelete = _brands.SingleOrDefault(b => b.Id == t.Id);
            _brands.Remove(brandToDelete);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand t)
        {
            //gönderilen marka idsine sahip olan markayı bul
            Brand brandToUpdate = _brands.SingleOrDefault(b => b.Id == t.Id);
            brandToUpdate.BrandName = t.BrandName;

        }
    }
}
