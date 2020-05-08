using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces.Fruits
{
    public interface IFruit
    {
        // Template for classes
        // Defines what properties and methods
        //    that a type of class requires
        string Name { get; }
        bool HasBeenPeeled { get; }
        string Peel();
    }
}
