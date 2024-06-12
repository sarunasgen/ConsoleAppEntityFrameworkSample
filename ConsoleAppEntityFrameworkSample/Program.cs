using ConsoleAppEntityFrameworkSample.Repositories;
using System;

namespace ConsoleAppEntityFrameworkSample;

public class Program
{
    public static void Main(string[] args)
    {
        IDatabaseRepository databaseRepository = new DatabaseRepository();
        databaseRepository.AddCar(new Models.Car { Marke = "Audi", Modelis = "RS6", PirmRegData = DateTime.Now - TimeSpan.FromDays(9000) });
        var carList = databaseRepository.GetCarList();
        var carListById = databaseRepository.GetCarListById(2);

        carList = carList;

    }
}