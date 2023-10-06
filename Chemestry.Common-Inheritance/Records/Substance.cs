
using Chemistry.Common_Inheritance.Enums;

namespace Chemistry.Common_Inheritance.Records;

public abstract record Substance : IEquatable<Substance>
{
    public int Id { get; }
    public string SubstanceName { get; }
    public double Mass { get; }
    public abstract States State { get; }

    protected Substance (int id, string name, double mass) => (Id, SubstanceName, Mass) = (id, name, mass);

    protected States GetState(string name) => (States)Enum.Parse(typeof(States), name);
    public abstract string GetShape(); // message how the substance behaves in its container
    public abstract string GetCompression(); // message if substance is compressible
    public abstract string ParticleMovement(); //message how the particles behave in its container

    public virtual string GetData() => $"{SubstanceName} {Mass} {State}";

    public virtual bool Equals(Substance other)
    {
        if (other == null || GetType() != other.GetType()) return false;

        if (State == other.State) return true;

        return false;
    }
    public override int GetHashCode() => base.GetHashCode();
}
