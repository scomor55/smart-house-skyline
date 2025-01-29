using smart_house.Models;
using smart_house.Services;

Console.WriteLine("Hello, World!");

SmartLightService lightService = new SmartLightService();

SmartLight myLight = new SmartLight(1, "Living room");


Console.WriteLine($"Initial Status: {lightService.getStatus(myLight)}");

lightService.turnOn(myLight);
Console.WriteLine($"After turnOn(): {lightService.getStatus(myLight)}");

lightService.setBrightness(myLight, 80);
Console.WriteLine($"Brightness set to: {myLight.brightness}");

lightService.changeColor(myLight, "blue");
Console.WriteLine($"Color changed to: {myLight.color}");

lightService.turnOff(myLight);
Console.WriteLine($"After turnOff(): {lightService.getStatus(myLight)}");