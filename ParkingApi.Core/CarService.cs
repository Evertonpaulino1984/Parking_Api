using ParkingApi.Core.Interface;
using ParkingApi.Domain;
using ParkingApi.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApi.Core
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public Car CreateCar(Car car)
        {
            return _carRepository.CreateCar(car);
        }

        public string DeleteCar(string carkey)
        {
            throw new NotImplementedException();
        }

        public Car GetCarByKey(string carkey)
        {
            var car = _carRepository.GetCarByKey(carkey);

            return car;
        }

        public List<Car> GetCars()
        {
            var cars = _carRepository.GetCars();

            return cars;
        }

        public Car UpdateCar(Car car)
        {
            return _carRepository.UpdateCar(car);
        }

    }
}
