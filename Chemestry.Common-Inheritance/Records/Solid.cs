
using Chemistry.Common_Inheritance.Enums;

namespace Chemistry.Common_Inheritance.Records;

public record Solid : Substance
{

    public override States State => GetState(GetType().Name);

    public Solid(int id, string substanceName, double mass) : base(id, substanceName, mass) { }

    public override string GetCompression() => $"{SubstanceName} ({State}): doesn’t compress easily";
    public override string GetShape() => $"{SubstanceName} ({State}): retains a fixed volume and shape";
    public override string ParticleMovement() => $"{SubstanceName} ({State}):  rigid - particles cannot move/slide past one another";
    public sealed override string GetData() => $"{SubstanceName} {Mass} This is a solid.";
}
