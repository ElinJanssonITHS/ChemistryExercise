

using Chemistry.Common_Inheritance.Enums;

namespace Chemistry.Common_Inheritance.Interfaces;

public interface Substance
{
    string SubstanceName { get; }
    double Mass { get; }
    States State { get; }
    string GetShape(); // message how the substance behaves in its container
    string GetCompression (); // message if substance is compressible
    string ParticleMovement(); //message how the particles behave in its container

}
