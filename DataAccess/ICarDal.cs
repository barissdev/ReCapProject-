using Entities;
using System.Collections.Generic;

namespace DataAccess
{
    public interface ICarDal
    {
        List<Car> GetAll();
        Car GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
