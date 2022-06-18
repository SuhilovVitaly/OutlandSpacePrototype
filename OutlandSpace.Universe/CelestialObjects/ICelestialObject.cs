using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlandSpace.Universe.CelestialObjects;

public interface ICelestialObject
{
    int Id { get; set; }
    string Name { get; set; }
    double Direction { get; set; }
    double Speed { get; set; }
    double PositionX { get; set; }
    double PositionY { get; set; }

    double PreviousPositionX { get; set; }
    double PreviousPositionY { get; set; }

    CelestialObjectTypes Type { get; set; }
}

