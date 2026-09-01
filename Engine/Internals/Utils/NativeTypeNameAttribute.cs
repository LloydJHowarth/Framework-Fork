using System;
using System.Diagnostics;

namespace Engine
{
    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
    internal sealed class NativeTypeNameAttribute : Attribute
    {
        private readonly string _name;

        public NativeTypeNameAttribute(string name)
        {
            _name = name;
        }
        
        public string Name => _name;
    }
}