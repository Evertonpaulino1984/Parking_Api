using MongoDB.Driver;
using ParkingApi.Domain;
using ParkingApi.Repository.Interface;
using System;
using System.Collections.Generic;

namespace ParkingApi.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly IMongoCollection<Car> _collectionCar;
        public CarRepository()
        {
            var client = new MongoClient(@"mongodb://localhost:27017");
            var database = client.GetDatabase("DBCRUD");
            _collectionCar = database.GetCollection<Car>("Car");
        }

        public Car CreateCar(Car car)
        {
            _collectionCar.InsertOne(car);

            return car;
        }

        public string DeleteCar(string carkey)
        {
            _collectionCar.DeleteOne(carkey);

            return carkey;
        }

        public Car GetCarByKey(string carkey)
        {
            var car = _collectionCar.Find(p => p.Key == carkey).FirstOrDefault();

            return car;
        }

        public List<Car> GetCars()
        {
            var cars = _collectionCar.Find(b => b.IsActive).ToList();

            return cars;
        }

        public Car UpdateCar(Car car)
        {
            _collectionCar.ReplaceOneAsync(c => c.Key == car.Key, car);

            return car;
        }
    }
}
