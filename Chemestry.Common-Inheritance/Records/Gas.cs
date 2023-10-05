
using Chemistry.Common_Inheritance.Enums;


namespace Chemistry.Common_Inheritance.Records;

public record Gas : Substance
{
    public override States State => GetState(GetType().Name);

    public Gas(int id, string substanceName, double mass) : base(id, substanceName, mass) { }

    public override string GetCompression()
        => $"{SubstanceName} ({State}): is compressible";

    public override string GetShape()
        => $"{SubstanceName} ({State}): assumes the shape and volume of its container";

    public override string ParticleMovement()
        => $"{SubstanceName} ({State}): particles can move past one another";
}
