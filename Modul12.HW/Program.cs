using Modul12.HW;
using System;

class Program
{
    static void Main(string[] args)
    {
        RaceGame raceGame = new RaceGame();

        SportsCar sportsCar = new SportsCar("Спортивный автомобиль");
        SedanCar sedanCar = new SedanCar("Легковой автомобиль");
        Truck truck = new Truck("Грузовик");
        Bus bus = new Bus("Автобус");

        raceGame.StartRace += sportsCar.Move;
        raceGame.StartRace += sedanCar.Move;
        raceGame.StartRace += truck.Move;
        raceGame.StartRace += bus.Move;

        sportsCar.Finish += raceGame.WinnerInfo;
        sedanCar.Finish += raceGame.WinnerInfo;
        truck.Finish += raceGame.WinnerInfo;
        bus.Finish += raceGame.WinnerInfo;

        raceGame.StartRace += () => Console.WriteLine("Гонка началась!");

        while (sportsCar.Position < 100 && sedanCar.Position < 100 && truck.Position < 100 && bus.Position < 100)
        {
            raceGame.Start();
            Console.WriteLine($"Положение спортивного автомобиля: {sportsCar.Position}");
            Console.WriteLine($"Положение легкового автомобиля: {sedanCar.Position}");
            Console.WriteLine($"Положение грузовика: {truck.Position}");
            Console.WriteLine($"Положение автобуса: {bus.Position}");
            Console.WriteLine("-----------------------------");
        }
    }
}
