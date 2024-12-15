using IKM724NetBasics.Entities.Sensors;
using IKM724NetBasics.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities
{
    public class WaterTreatmentSystem
    {
        public List<Sensor> Sensors { get; set; }
        public FiltrationSystem Filtration { get; set; }
        public MixingSystem Mixing { get; set; }
        public AerationSystem Aeration { get; set; }

        public WaterTreatmentSystem()
        {
            Sensors = new List<Sensor>();
            Filtration = new FiltrationSystem();
            Mixing = new MixingSystem();
            Aeration = new AerationSystem();
        }

        public void Monitor()
        {
            foreach (var sensor in Sensors) 
            { 
                sensor.ReadValue(); 
            }
        }
    }
}