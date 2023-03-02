using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
  public interface ICarDal : IGenericDal<Car>
    {

        //marka id sine bağlı arabalar listelenecek
        List<Car> GetById(int brandId);

    }
}
