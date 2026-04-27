namespace TypeSharp.Attributes
{
    /// <summary>
    /// Overrides the property name in the generated TypeScript output.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class TypeNameAttribute(string name) : Attribute
    {
        public string Name { get; } = name;
    }
}
