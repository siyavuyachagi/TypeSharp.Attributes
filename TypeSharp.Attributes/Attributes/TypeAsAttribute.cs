using System;
using System.Collections.Generic;
using System.Text;

namespace TypeSharp.Attributes
{
    /// <summary>
    /// Overrides the inferred TypeScript type for this property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class TypeAsAttribute(string tsType) : Attribute
    {
        public string TsType { get; } = tsType;
    }
}
