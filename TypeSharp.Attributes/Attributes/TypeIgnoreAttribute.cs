using System;
using System.Collections.Generic;
using System.Text;

namespace TypeSharp.Attributes.Attributes
{
    /// <summary>
    /// Excludes this property from TypeSharp TypeScript generation.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class TypeIgnoreAttribute : Attribute { }
}
