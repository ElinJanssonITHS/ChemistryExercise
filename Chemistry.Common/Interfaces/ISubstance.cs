

using Chemistry.Common.Enums;

namespace Chemistry.Common.Interfaces;

public interface ISubstance
{
    string SubstanceName { get; }
    double Mass { get; }
    States State { get; }
    string GetShape(); // message how the substance behaves in its container
    string GetCompression (); // message if substance is compressible
    string ParticleMovement(); //message how the particles behave in its container


}
