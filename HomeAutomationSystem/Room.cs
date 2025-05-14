using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomationSystem
{
    public class Room
    {
        public string RoomName {  get; set; }
        public Device Light {  get; set; }
        public Device Heater { get; set; }
        public int Temperature {  get; set; }

        public Room(string roomName)
        {
            RoomName = roomName;
            Light = new Device("Light");
            Heater = new Device("Heater");
            Temperature = 22;
        }

        public void IncreaseTemperature()
        {
            Temperature++;
        }
        public void DecreaseTepmerature()
        {
            Temperature--;
        }
        public void AutoControl(bool isNight)
        {
            if (Temperature < 20)
                Heater.TurnOn();
            else if (Temperature > 25)
                Heater.TurnOff();

            if (isNight)
            {
                Light.TurnOn();
            }
            else
                Light.TurnOff();
        }
    }
}
