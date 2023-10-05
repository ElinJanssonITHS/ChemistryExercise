
namespace Chemestry.Common_Inheritance.Classes;

public static class ChemistryExtensions
{
    public static bool SameState<T>(this T t1,T t2) where T : IEquatable<T>
        => t1.Equals(t2);
}
