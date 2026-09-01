using System.Diagnostics;
using System;

namespace Engine
{
    [Conditional("DEBUG")]
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
    internal sealed class NativeAnnotationAttribute : Attribute
    {
        public NativeAnnotationAttribute(string annotation)
        {
            Annotation = annotation;
        }
        
        public string Annotation { get; }
    }
}

