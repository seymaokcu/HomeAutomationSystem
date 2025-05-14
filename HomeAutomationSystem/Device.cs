using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomationSystem
{
    public class Device
    {
        public string Name {  get; set; }
        public bool IsOn {  get; set; }

        public Device(string name)
        {
            Name = name;
            IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
        }
        public void TurnOff()
        {
            IsOn = false;
        }   
    }
}
