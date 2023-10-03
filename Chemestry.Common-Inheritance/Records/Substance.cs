
using Chemestry.Common_Inheritance.Enums;

namespace Chemestry.Common_Inheritance.Records;

public abstract record Substance
{
    public string SubstanceName { get; }
    public double Mass { get; }
    public abstract States State { get; }
    protected Substance (string name, double mass) 
        => (SubstanceName, Mass) = (name, mass);
    protected States GetState(string name) => (States)Enum.Parse(typeof(States), name);
    public abstract string GetShape(); // message how the substance behaves in its container
    public abstract string GetCompression(); // message if substance is compressible
    public abstract string ParticleMovement(); //message how the particles behave in its container
    public virtual string GetData() => $"{SubstanceName} {Mass} {State}";
}
