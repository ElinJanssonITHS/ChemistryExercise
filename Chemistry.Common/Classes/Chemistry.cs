
using Chemistry.Common.Enums;
using Chemistry.Common.Interfaces;
using Chemistry.Common.Records;

namespace Chemistry.Common.Classes;

public class Chemistry
{
    public List<ISubstance> Substances { get; } = new();
    public string[] StateNames { get; } = Enum.GetNames(typeof(States));
    public States GetStateValue(string name) => (States)Enum.Parse(typeof(States), name);
    public Chemistry()
    {
        AddSubstance(new Solid("Ice", 0.9));
        AddSubstance(new Gas("Air", 0.1));
        AddSubstance(new Plasma("Lightning", 0.01));
        AddSubstance(new Liquid("Water", 1.0));
    }
    public ISubstance CreateSubstance(string substanceName, double mass, string state) => GetStateValue(state) switch
    {
        States.Liquid => new Liquid(substanceName, mass),
        States.Gas => new Gas(substanceName, mass),
        States.Solid => new Solid(substanceName, mass),
        States.Plasma => new Plasma(substanceName, mass),
        _ => throw new ArgumentException("State does not exist.", nameof(state))
    };

    public void AddSubstance (string substanceName, double mass, string state)
    {
        try
        {
            ISubstance substance = CreateSubstance(substanceName, mass, state);
            AddSubstance(substance);
        }
        catch { throw; }

    }
    public void AddSubstance(ISubstance substance) => Substances.Add(substance);
    public List<ISubstance> GetSubstances() => Substances;
    public List<ISubstance> GetSubstances(Func<ISubstance, bool> expression) => Substances.Where(expression).ToList();


}
