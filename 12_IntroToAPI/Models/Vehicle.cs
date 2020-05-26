using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_IntroToAPI.Models
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set;}
        public string Manufacturer { get; set; }
        public string Cost_In_Credits { get; set; }
        public string Vehicle_Class { get; set; }
        public List<string> Pilots { get; set; }
        public List<string> Films { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }
}
