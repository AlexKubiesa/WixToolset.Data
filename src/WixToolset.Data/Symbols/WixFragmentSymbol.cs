// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Data
{
    using WixToolset.Data.Symbols;

    public static partial class SymbolDefinitions
    {
        public static readonly IntermediateSymbolDefinition WixFragment = new IntermediateSymbolDefinition(
            SymbolDefinitionType.WixFragment,
            new IntermediateFieldDefinition[]
            {
            },
            typeof(WixFragmentSymbol));
    }
}

namespace WixToolset.Data.Symbols
{
    public enum WixFragmentSymbolFields
    {
    }

    public class WixFragmentSymbol : IntermediateSymbol
    {
        public WixFragmentSymbol() : base(SymbolDefinitions.WixFragment, null, null)
        {
        }

        public WixFragmentSymbol(SourceLineNumber sourceLineNumber, Identifier id = null) : base(SymbolDefinitions.WixFragment, sourceLineNumber, id)
        {
        }

        public IntermediateField this[WixFragmentSymbolFields index] => this.Fields[(int)index];
    }
}