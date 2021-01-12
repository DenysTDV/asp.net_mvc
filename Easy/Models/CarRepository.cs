using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Easy.Models
{
    public class CarRepository : ICarRepository
    {
        private List<Car> cars = new List<Car>();
        private int _nextId = 1;
        public IEnumerable<Car> GetAll()
        {
            return cars;
        }

        public Car Get(int id)
        {
            return cars.Find(p => p.ID == id);
        }

        public Car Add(Car item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.ID = _nextId++;
            cars.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            cars.RemoveAll(p => p.ID == id);
        }

        public bool Update(Car item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = cars.FindIndex(p => p.ID == item.ID);
            if (index == -1)
            {
                return false;
            }
            cars.RemoveAt(index);
            cars.Add(item);
            return true;
        }
    }
}