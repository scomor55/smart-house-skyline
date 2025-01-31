﻿using smart_house.Models;
using smart_house.Services;
using smart_house.Enums;
using System.Net.WebSockets;

SmartLightService lightService = new SmartLightService();
SmartLight myLight = new SmartLight(1, "Living room");


SmartThermostatService thermostatService = new SmartThermostatService();
SmartThermostat thermostat = new SmartThermostat(2, "Main thermostat");


SmartLock smartLock = new SmartLock(3, "Front door");
SmartLockService lockService = new SmartLockService();


SmartBlind smartBlind = new SmartBlind(4, "Blind 1");
SmartBlindService blindService = new SmartBlindService();

List<IDevice> deviceList = new List<IDevice>();

deviceList.Add(myLight);
deviceList.Add(thermostat);
deviceList.Add(smartLock);
deviceList.Add(smartBlind);

foreach (var device in deviceList)
{
    Console.WriteLine($"| {device.Id} {device.Name} ({device.GetType().Name})");
}
while (true)
{
    Console.WriteLine("Select an option: ");
    Console.WriteLine("1. Show device status ");
    Console.WriteLine("2. Turn on / off device ");
    Console.WriteLine("3. Manage device device ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Enter device id: ");
            string deviceId1 = Console.ReadLine();
            var device1 = deviceList.FirstOrDefault(d => d.Id.ToString() == deviceId1);

            if(device1 != null)
            {
                string status = "";
                if (device1 is SmartLight) status = lightService.GetStatus((SmartLight)device1);
                else if (device1 is SmartBlind ) status = blindService.GetStatus((SmartBlind)device1);
                else if (device1 is SmartThermostat ) status = thermostatService.GetStatus((SmartThermostat)device1);
                else if (device1 is SmartLock ) status = lockService.GetStatus((SmartLock)device1);

                Console.WriteLine($"Device : {device1.Name} , Status : {status}");
            }
            else
            {
                Console.WriteLine("Device not found");
            }

            break;
        case "2":
            Console.WriteLine("Enter device id: ");
            string deviceId2 = Console.ReadLine();
            var device2 = deviceList.FirstOrDefault(d => d.Id.ToString() == deviceId2);
            if(device2 != null)
            {

                Console.WriteLine($"Selected: {device2.Name } ");
                Console.WriteLine("");
                Console.WriteLine("1 - Turn device on ");
                Console.WriteLine("2 - Turn device off ");

                string action = Console.ReadLine();
                bool result = false;
                if(action == "1")
                {
                    if(device2 is SmartLight) result = lightService.TurnOn((SmartLight)device2);
                    if (device2 is SmartLock) result = lockService.TurnOn((SmartLock)device2);
                    if (device2 is SmartThermostat) result = thermostatService.TurnOn((SmartThermostat)device2);
                    if (device2 is SmartBlind) result = blindService.TurnOn((SmartBlind)device2);

                    if (result) Console.WriteLine("Device turned on succesfully");
                }else if (action == "2")
                {
                    if (device2 is SmartLight) result = lightService.TurnOff((SmartLight)device2);
                    if (device2 is SmartLock) result = lockService.TurnOff((SmartLock)device2);
                    if (device2 is SmartThermostat) result = thermostatService.TurnOff((SmartThermostat)device2);
                    if (device2 is SmartBlind) result = blindService.TurnOff((SmartBlind)device2);
                    if (result) Console.WriteLine("Defice turned off sucesfully");
                }
            }
            else
            {
                Console.WriteLine("Device not found");
            }

            break;
        case "3":
            Console.WriteLine("Enter device id: ");
            string deviceId3 = Console.ReadLine();
            var device3 = deviceList.FirstOrDefault(d => d.Id.ToString() == deviceId3);
            if(device3 != null)
            {
                if(device3 is SmartLight)
                {
                    Console.WriteLine($"Selected: {device3.Name} ");
                    Console.WriteLine("");
                    Console.WriteLine("1 - Set brightness");
                    Console.WriteLine("2 - Change color ");
                    string manageLight = Console.ReadLine();

                    if(manageLight == "1")
                    {
                        Console.WriteLine("Enter brightness level");
                        string brightnessLevel = Console.ReadLine();

                        lightService.SetBrightness((SmartLight)device3, int.Parse(brightnessLevel));
                    }else if (manageLight == "2")
                    {
                        Console.WriteLine("Enter new color:");
                        string color = Console.ReadLine();

                        lightService.ChangeColor((SmartLight)device3,color);

                    }
                }
            }
            break;
        case "4":
            return;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
}





















