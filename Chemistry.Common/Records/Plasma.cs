
using Chemistry.Common.Enums;
using Chemistry.Common.Interfaces;

namespace Chemistry.Common.Records;

public record Plasma : ISubstance
{
    public string SubstanceName { get; } = string.Empty;

    public double Mass { get; }

    public States State => States.Plasma;

    public Plasma(string substanceName, double mass)
        => (SubstanceName, Mass) = (substanceName, mass);

    public string GetCompression()
        => $"{SubstanceName} ({State}): is compressible";

    public string GetShape()
        => $"{SubstanceName} ({State}): doesn’t have a shape or volume";

    public string ParticleMovement()
        => $"{SubstanceName} ({State}):particles are spread out and move randomly; contain some free ions and electrons, which gives plasma its ability to conduct electricity";

}
