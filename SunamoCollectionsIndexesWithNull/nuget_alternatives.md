# NuGet Alternatives to SunamoCollectionsIndexesWithNull

This document lists popular NuGet packages that provide similar functionality to SunamoCollectionsIndexesWithNull.

## Overview

Collections with nullable index support

## Alternative Packages

### System.Collections.Generic.Dictionary
- **NuGet**: System.Collections
- **Purpose**: Key-value pairs with null support
- **Key Features**: Nullable keys/values, O(1) lookup

### LanguageExt
- **NuGet**: LanguageExt.Core
- **Purpose**: Functional programming library
- **Key Features**: Option<T> for null safety, functional collections

### System.Nullable
- **NuGet**: System.Runtime
- **Purpose**: Built-in nullable types
- **Key Features**: Nullable value types, null-coalescing operators

## Comparison Notes

Modern C# nullable reference types combined with Dictionary<TKey?, TValue?> handle most cases.

## Choosing an Alternative

Consider these alternatives based on your specific needs:
- **System.Collections.Generic.Dictionary**: Key-value pairs with null support
- **LanguageExt**: Functional programming library
- **System.Nullable**: Built-in nullable types
