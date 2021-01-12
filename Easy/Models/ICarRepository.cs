using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAll();
        Car Get(int id);
        Car Add(Car item);
        void Remove(int id);
        bool Update(Car item);
    }
}
