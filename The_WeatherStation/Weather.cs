using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_WeatherStation
{
    
    public class Weather
    {
        
        public string Name { get; set; }
        public int Temp { get; set; }
        
        public override string ToString()
        {

            string Message = Name + ": " + Temp + "°C ";
            return Message;
        }
        public Weather(string _name, int _temp)
        {
            Name = _name;
            Temp = _temp;
        }
        
        
        
        

    }
        

}



