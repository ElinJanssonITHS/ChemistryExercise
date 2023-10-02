
using Chemistry.Common.Enums;
using Chemistry.Common.Interfaces;

namespace Chemistry.Common.Records;

public record Gas : ISubstance
{
    public string SubstanceName { get; } = string.Empty;

    public double Mass { get; }

    public States State => States.Gas;

    public Gas(string substanceName, double mass)
        => (SubstanceName, Mass) = (substanceName, mass);

    public string GetCompression()
        => $"{SubstanceName} ({State}): is compressible";

    public string GetShape()
        => $"{SubstanceName} ({State}): assumes the shape and volume of its container";

    public string ParticleMovement()
        => $"{SubstanceName} ({State}): particles can move past\r\none another";
}
