using IKM724NetBasics.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities.Sensors
{
    public class AciditySensor : Sensor
    {
        public override SensorType Type => SensorType.Acidity;

        public AciditySensor(string name, string description)
            : base (name, description){}

        public override void ReadValue()
        {
            Value = Math.Round(new Random().NextDouble() * 14, 2);
            Console.WriteLine($"{Name} Acidity: {Value} pH");
        }
    }
}