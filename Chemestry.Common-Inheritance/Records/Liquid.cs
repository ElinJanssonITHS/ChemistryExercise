
using Chemestry.Common_Inheritance.Enums;


namespace Chemestry.Common_Inheritance.Records;

public record Liquid : Substance
{

    public override States State => GetState(GetType().Name);

    public Liquid(string substanceName, double mass) : base(substanceName, mass) { }

    public override string GetCompression()
        => $"{SubstanceName} ({State}): does not compress easily";

    public override string GetShape()
        => $"{SubstanceName} ({State}): assumes the shape of the part of the container which it occupies"; 

    public override string ParticleMovement()
        => $"{SubstanceName} ({State}): particles can move/slide past one another";
}
