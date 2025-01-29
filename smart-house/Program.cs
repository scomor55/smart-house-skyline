using smart_house.Models;
using smart_house.Services;
using smart_house.Enums;

SmartLightService lightService = new SmartLightService();

SmartLight myLight = new SmartLight(1, "Living room");


Console.WriteLine($"Initial light status: {lightService.GetStatus(myLight)}");

lightService.TurnOn(myLight);
Console.WriteLine($"After turnOn(): {lightService.GetStatus(myLight)}");

lightService.SetBrightness(myLight, 80);
Console.WriteLine($"Brightness set to: {myLight.Brightness}");

lightService.changeColor(myLight, "blue");
Console.WriteLine($"Color changed to: {myLight.Color}");

lightService.TurnOff(myLight);
Console.WriteLine($"After turnOff(): {lightService.GetStatus(myLight)}");


Console.WriteLine("Thermostat test");

SmartThermostatService thermostatService = new SmartThermostatService();
SmartThermostat thermostat = new SmartThermostat(1, "Main thermostat");

Console.WriteLine($"Initial thermostat status: {thermostatService.GetStatus(thermostat)}");
thermostatService.TurnOn(thermostat);
Console.WriteLine($"After turnOn: {thermostatService.GetStatus(thermostat)}");
Console.WriteLine($"Default temperature: {thermostat.TargetTemperature}");

thermostatService.SetTemperature(thermostat, 22);
Console.WriteLine($"Target temperature: {thermostat.TargetTemperature}");
Console.WriteLine($"Initial mode: {thermostat.Mode}");
thermostatService.SwitchMode(thermostat, ThermostatMode.Heat);
Console.WriteLine($"Set mode: {thermostat.Mode}");

thermostatService.TurnOff(thermostat);
Console.WriteLine($"Thermostat status: {thermostatService.GetStatus(thermostat)}");


Console.WriteLine("Smart lock test ");

SmartLock smartLock = new SmartLock(1, "Front door");
SmartLockService smartLockService = new SmartLockService();

Console.WriteLine($"Initial lock status: {smartLockService.GetStatus(smartLock)}");
smartLockService.TurnOn(smartLock);
Console.WriteLine($"After turnOn: {smartLockService.GetStatus(smartLock)}");
Console.WriteLine($"Default lock status: { smartLock.IsLocked }");
smartLockService.Lock(smartLock);
Console.WriteLine($"New status: {smartLock.IsLocked}");
smartLockService.Unlock(smartLock,"0000");
Console.WriteLine($"New status: {smartLock.IsLocked}");
smartLockService.ChangePin(smartLock, "0000", "1111");
Console.WriteLine($"New PIN: {smartLock.PinCode}");
smartLockService.TurnOff(smartLock);
Console.WriteLine($"After turnOff: {smartLockService.GetStatus(smartLock)}");












