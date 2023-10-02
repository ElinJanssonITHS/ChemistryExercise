
using Chemistry.Common.Enums;
using Chemistry.Common.Interfaces;

namespace Chemistry.Common.Records;

public record Liquid : ISubstance
{
    public string SubstanceName { get; } = string.Empty;

    public double Mass { get; }

    public States State => States.Liquid;

    public Liquid(string substanceName, double mass)
        => (SubstanceName, Mass) = (substanceName, mass);

    public string GetCompression()
        => $"{SubstanceName} ({State}): does not compress easily";

    public string GetShape()
        => $"{SubstanceName} ({State}): assumes the shape of the part of the container which it occupies"; 

    public string ParticleMovement()
        => $"{SubstanceName} ({State}): particles can move/slide past one another";
}
