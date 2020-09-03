using System;

namespace ArduinoMornitoring.Models
{
    public class SensorDataModel
    {
        public DateTime Date { get; set; }
        public ushort Value { get; set; }
    }
}
