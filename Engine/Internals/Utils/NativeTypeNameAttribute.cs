using System.Diagnostics;
using System;

namespace Engine
{
    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
    internal sealed class NativeTypeNameAttribute : Attribute
    {
        public NativeTypeNameAttribute(string name)
        {
            Name = name;
        }
        
        public string Name { get; }
    }
}