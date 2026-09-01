using System;
using System.Diagnostics;

namespace Engine
{
    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
    internal sealed class NativeAnnotationAttribute : Attribute
    {
        private readonly string _annotation;
        
        public NativeAnnotationAttribute(string annotation)
        {
            _annotation = annotation;
        }
        
        public string Annotation => _annotation;
    }
}

