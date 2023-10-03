
using Chemestry.Common_Inheritance.Enums;
using Chemestry.Common_Inheritance.Records;
//using Chemestry.Common_Inheritance.Classes;

namespace Chemestry.Common_Inheritance.Classes;

public class Chemistry
{
    public List<Substance> Substances { get; } = new();
    public string[] StateNames { get; } = Enum.GetNames(typeof(States));
    public States GetStateValue(string name) => (States)Enum.Parse(typeof(States), name);
    public Chemistry()
    {
        AddSubstance(new Solid("Ice", 0.9));
        AddSubstance(new Gas("Air", 0.1));
        AddSubstance(new Plasma("Lightning", 0.01));
        AddSubstance(new Liquid("Water", 1.0));
    }
    public Substance CreateSubstance(string substanceName, double mass, string state) => GetStateValue(state) switch
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
            Substance substance = CreateSubstance(substanceName, mass, state);
            AddSubstance(substance);
        }
        catch { throw; }

    }
    public void AddSubstance(Substance substance) => Substances.Add(substance);
    public List<Substance> GetSubstances() => Substances;
    public List<Substance> GetSubstances(Func<Substance, bool> expression) => Substances.Where(expression).ToList();


}
