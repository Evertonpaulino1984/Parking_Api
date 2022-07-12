using ParkingApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApi.Core.Interface
{
    public interface ICarService
    {
        Car CreateCar(Car car);
        Car UpdateCar(Car car);
        string DeleteCar(string carkey);
        Car GetCarByKey(string carkey);
        List<Car> GetCars();
    }
}
