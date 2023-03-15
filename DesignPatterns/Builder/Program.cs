// See https://aka.ms/new-console-template for more information
using Builder;

Console.WriteLine("Hello, World!");

VehicleBuilder builder = new VehicleBuilder();
Director director = new Director(builder);

director.BuildSportCar();

Console.WriteLine();

director.BuildSUV();

