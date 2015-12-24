﻿using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace TypeProviders.CSharp
{
    class HierarchicalDataEntry
    {
        public TypeSyntax PropertyType { get; }
        public string PropertyName { get; }
        public TypeSyntax EntryType { get; }
        public IReadOnlyCollection<HierarchicalDataEntry> Children { get; }

        public HierarchicalDataEntry(TypeSyntax propertyType, string propertyName, TypeSyntax entryType, IEnumerable<HierarchicalDataEntry> children)
        {
            PropertyType = propertyType;
            PropertyName = propertyName;
            EntryType = entryType;
            Children = children.ToList();
        }
    }
}