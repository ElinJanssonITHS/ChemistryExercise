
using Chemistry.Common.Enums;
using Chemistry.Common.Interfaces;

namespace Chemistry.Common.Records;

public record Solid : ISubstance
{
    public string SubstanceName { get; } = string.Empty;

    public double Mass { get; }

    public States State => States.Solid;

    public Solid(string substanceName, double mass)
        => (SubstanceName, Mass) = (substanceName, mass);

    public string GetCompression()
        => $"{SubstanceName} ({State}): doesn’t compress easily";

    public string GetShape()
        => $"{SubstanceName} ({State}): retains a fixed volume and shape";

    public string ParticleMovement()
        => $"{SubstanceName} ({State}):  rigid - particles cannot move/slide past one another";
}
