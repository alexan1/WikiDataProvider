namespace FSharp.Data.WikiDataProvider

open System
open System.Reflection
open FSharp.Core.CompilerServices
open FSharp.Quotations
open ProviderImplementation.ProvidedTypes


[<TypeProvider>]
type WikiDataTypeProvider(config: TypeProviderConfig) as this =
    inherit TypeProviderForNamespaces(config, assemblyReplacementMap=[ "FSharp.Data.DesignTime", "FSharp.Data" ])
