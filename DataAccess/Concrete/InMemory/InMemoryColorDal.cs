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
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color>
               {
                   new Color{ColorId=1,CarColor="mavi"},
                   new Color{ColorId=2,CarColor="sarı"},
                   new Color{ColorId=3,CarColor="beyaz"},
                   new Color{ColorId=4,CarColor="turuncu"},
               };
        }
        public void Add(Color t)
        {
            _colors.Add(t);
        }

        public void Delete(Color t)
        {
            Color colorToDelete = _colors.SingleOrDefault(c => c.ColorId == t.ColorId);
            _colors.Remove(colorToDelete);
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            return _colors;
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Color t)
        {
            Color colorToUpdate = _colors.SingleOrDefault(c => c.ColorId == t.ColorId);
            colorToUpdate.CarColor = t.CarColor;
        }
    }
}
