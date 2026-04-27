namespace TypeSharp.Attributes
{
    /// <summary>
    /// Overrides the inferred TypeScript type for this property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class TypeAsAttribute(string tsType) : Attribute
    {
        public string TsType { get; } = tsType;
    }
}
