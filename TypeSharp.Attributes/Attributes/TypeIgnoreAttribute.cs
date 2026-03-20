namespace TypeSharp.Attributes
{
    /// <summary>
    /// Excludes this property from TypeSharp TypeScript generation.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class TypeIgnoreAttribute : Attribute { }
}
