using Microsoft.AspNetCore.Mvc;
using ParkingApi.Core;
using ParkingApi.Core.Interface;
using ParkingApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking_Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] CarRequest car)
        {
            var carCreate = new Car();
            carCreate.Model = car.Model;
            carCreate.YearFabrication = car.YearFabrication;
            carCreate.Brand = car.Brand;
            carCreate.Color = car.Color;
            carCreate.Brazilian = car.Brazilian;
            
            var carResponse = _carService.CreateCar(carCreate);

            return Ok(carCreate);
        }
        [HttpGet]
        public IActionResult Get()
        {
            var car = _carService.GetCars();

            return Ok(car);

        }
        [HttpGet("{Key}")]
        public IActionResult GetByKey([FromRoute] string Key)
        {
            var car = _carService.GetCarByKey(Key);

            return Ok(car);
        }
        [HttpPut]
        public IActionResult Put([FromBody] CarUpdate carupdate)
        {
            var car = _carService.GetCarByKey(carupdate.Key);

            car.Key = carupdate.Key;
            car.IsActive = carupdate.IsActive;
            car.Update = DateTime.Now;
            car.YearFabrication = carupdate.YearFabrication;
            car.Brand = carupdate.Brand;
            car.Color = carupdate.Color;
            car.Brazilian = carupdate.Brazilian;
            
            var carresponse = _carService.UpdateCar(car);

            return Ok(carresponse);
        }

    }
}
