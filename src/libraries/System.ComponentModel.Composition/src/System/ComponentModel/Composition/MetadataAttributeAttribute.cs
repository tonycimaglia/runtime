// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.ComponentModel.Composition
{
    /// <summary>
    ///     Specifies that an attribute can be used to provide metadata for a type, property, field,
    ///     or method marked with the <see cref="ExportAttribute"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class MetadataAttributeAttribute : Attribute
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MetadataAttributeAttribute"/> class.
        /// </summary>
        public MetadataAttributeAttribute()
        {
        }
    }
}
