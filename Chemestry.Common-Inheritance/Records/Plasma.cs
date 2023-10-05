
using Chemistry.Common_Inheritance.Enums;

namespace Chemistry.Common_Inheritance.Records;

public record Plasma : Substance
{

    public override States State => GetState(GetType().Name);

    public Plasma(int id, string substanceName, double mass) : base(id, substanceName, mass) { }

    public override string GetCompression()
        => $"{SubstanceName} ({State}): is compressible";

    public override string GetShape()
        => $"{SubstanceName} ({State}): doesn’t have a shape or volume";

    public override string ParticleMovement()
        => $"{SubstanceName} ({State}):particles are spread out and move randomly; contain some free ions and electrons, which gives plasma its ability to conduct electricity";

}
