
using Chemistry.Common_Inheritance.Enums;
using Chemistry.Common_Inheritance.Records;
//using Chemestry.Common_Inheritance.Classes;

namespace Chemistry.Common_Inheritance.Classes;

public class Chemistry
{
    public List<Substance> Substances { get; } = new();
    public string[] StateNames { get; } = Enum.GetNames(typeof(States));
    public States GetStateValue(string name) => (States)Enum.Parse(typeof(States), name);
    public Chemistry()
    {
        AddSubstance(new Solid(1, "Ice", 0.9));
        AddSubstance(new Gas(2, "Air", 0.1));
        AddSubstance(new Plasma(3, "Lightning", 0.01));
        AddSubstance(new Liquid(4, "Water", 1.0));
    }
    public Substance CreateSubstance(int id, string substanceName, double mass, string state) => GetStateValue(state) switch
    {
        States.Liquid => new Liquid(id, substanceName, mass),
        States.Gas => new Gas(id, substanceName, mass),
        States.Solid => new Solid(id, substanceName, mass),
        States.Plasma => new Plasma(id, substanceName, mass),
        _ => throw new ArgumentException("State does not exist.", nameof(state))
    };

    public void AddSubstance (string substanceName, double mass, string state)
    {
        try
        {
            Substance substance = CreateSubstance(Substances.Count + 1, substanceName, mass, state);
            AddSubstance(substance);
        }
        catch { throw; }

    }
    public void AddSubstance(Substance substance) => Substances.Add(substance);
    public List<Substance> GetSubstances() => Substances;
    public List<Substance> GetSubstances(Func<Substance, bool> expression) => Substances.Where(expression).ToList();


}
