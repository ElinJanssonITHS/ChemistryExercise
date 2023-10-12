
using Chemistry.Common_Inheritance.Enums;
using Chemistry.Common_Inheritance.Records;
//using Chemestry.Common_Inheritance.Classes;

namespace Chemistry.Common_Inheritance.Classes;

public class Chemistry
{
    List<Substance> Substances { get; } = new();
    public string[] StateNames => Enum.GetNames(typeof(States));
    public States GetStateValue(string name) => (States)Enum.Parse(typeof(States), name);
    public Chemistry()
    {
        Add(new Solid(1, "Ice", 0.9));
        Add(new Gas(2, "Air", 0.1));
        Add(new Plasma(3, "Lightning", 0.01));
        Add(new Liquid(4, "Water", 1.0));
    }
    public Substance CreateSubstance(int id, string substanceName, double mass, string state) => GetStateValue(state) switch
    {
        States.Liquid => new Liquid(id, substanceName, mass),
        States.Gas => new Gas(id, substanceName, mass),
        States.Solid => new Solid(id, substanceName, mass),
        States.Plasma => new Plasma(id, substanceName, mass),
        _ => throw new ArgumentException("State does not exist.", nameof(state))
    };

    public void Add(string name, int mass, string state)
    {
        try
        {
            Substance substance = CreateSubstance(Substances.Count + 1, name, mass, state);
            Add(substance);
        }
        catch
        {
            throw;
        }
    }
    public void Add(Substance substance) => Substances.Add(substance);
    public List<Substance> Get() => Substances;
    public List<Substance> Get(Func<Substance, bool> expression) =>
        Substances.Where(expression).ToList();


}
