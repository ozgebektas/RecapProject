﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (MsSqlContext context = new MsSqlContext())
            {
                var addedEntity = context.Entry(entity);//referans aldın
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (MsSqlContext context = new MsSqlContext())
            {
                var deletedEntity = context.Entry(entity);//referans aldın
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (MsSqlContext context=new MsSqlContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (MsSqlContext context = new MsSqlContext())
            {
                return filter == null ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (MsSqlContext context = new MsSqlContext())
            {
                var updatedEntity = context.Entry(entity);//referans aldın
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
