using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces.Fruits
{
    public class Banana : IFruit
    {
        public string Name
        {
            get
            {
                return GetType().Name;
            }
        }
        public bool HasBeenPeeled { get; set; } = false;

        public string Peel()
        {
            HasBeenPeeled = true;
            return "Don't slip on it!";
        }
    }

    public class Orange : IFruit
    {
        public string Name
        {
            get
            {
                return "A tasty " + GetType().Name;
            }

        }
        public bool HasBeenPeeled { get; set; } = false;
        public bool HasBeenJuiced { get; set; } = false;
        public string Peel()
        {
            HasBeenPeeled = true;
            return "You have some orange peels now";
        }

        public string Squeeze()
        {
            return "OJ";
        }
    }
}
