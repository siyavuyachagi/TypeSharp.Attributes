namespace TypeSharp.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum, AllowMultiple = false)]
    public class TypeSharpAttribute(string? typeName = null) : Attribute
    {
        public string? TypeName { get; } = typeName;
    }
}
