#### [DiGi\.GLTF\.Analytical](DiGi.GLTF.Analytical.Overview.md 'DiGi\.GLTF\.Analytical\.Overview')

## DiGi\.GLTF\.Analytical Namespace
### Classes

<a name='DiGi.GLTF.Analytical.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.GLTF.Analytical.Convert.ToGLTF_GLTFNodes(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Core.Interfaces.IReference,double,DiGi.Analytical.Building.Enums.BuildingModelDetailLevel)'></a>

## Convert\.ToGLTF\_GLTFNodes\(this BuildingModel, IReference, double, BuildingModelDetailLevel\) Method

Converts all components of the specified [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') \(walls, roofs, floors and other components with surface geometry\) into [DiGi\.GLTF\.Classes\.GLTFNode](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnode 'DiGi\.GLTF\.Classes\.GLTFNode') instances\.

```csharp
public static System.Collections.Generic.List<DiGi.GLTF.Classes.GLTFNode>? ToGLTF_GLTFNodes(this DiGi.Analytical.Building.Classes.BuildingModel? buildingModel, DiGi.Core.Interfaces.IReference? reference=null, double tolerance=1E-06, DiGi.Analytical.Building.Enums.BuildingModelDetailLevel buildingModelDetailLevel=DiGi.Analytical.Building.Enums.BuildingModelDetailLevel.Component);
```
#### Parameters

<a name='DiGi.GLTF.Analytical.Convert.ToGLTF_GLTFNodes(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Core.Interfaces.IReference,double,DiGi.Analytical.Building.Enums.BuildingModelDetailLevel).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') to be converted\. This value can be null\.

<a name='DiGi.GLTF.Analytical.Convert.ToGLTF_GLTFNodes(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Core.Interfaces.IReference,double,DiGi.Analytical.Building.Enums.BuildingModelDetailLevel).reference'></a>

`reference` [DiGi\.Core\.Interfaces\.IReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireference 'DiGi\.Core\.Interfaces\.IReference')

The optional root [DiGi\.Core\.Interfaces\.IReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireference 'DiGi\.Core\.Interfaces\.IReference') of the building model \(for example a county \+ building [DiGi\.Core\.Classes\.ComplexReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.complexreference 'DiGi\.Core\.Classes\.ComplexReference')\)\. Node references extend it \(component step appended per node\) and node names are derived from its last step \(see [Name\(this IReference\)](DiGi.GLTF.Analytical.md#DiGi.GLTF.Analytical.Query.Name(thisDiGi.Core.Interfaces.IReference) 'DiGi\.GLTF\.Analytical\.Query\.Name\(this DiGi\.Core\.Interfaces\.IReference\)')\)\.

<a name='DiGi.GLTF.Analytical.Convert.ToGLTF_GLTFNodes(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Core.Interfaces.IReference,double,DiGi.Analytical.Building.Enums.BuildingModelDetailLevel).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during triangulation\.

<a name='DiGi.GLTF.Analytical.Convert.ToGLTF_GLTFNodes(thisDiGi.Analytical.Building.Classes.BuildingModel,DiGi.Core.Interfaces.IReference,double,DiGi.Analytical.Building.Enums.BuildingModelDetailLevel).buildingModelDetailLevel'></a>

`buildingModelDetailLevel` [DiGi\.Analytical\.Building\.Enums\.BuildingModelDetailLevel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.enums.buildingmodeldetaillevel 'DiGi\.Analytical\.Building\.Enums\.BuildingModelDetailLevel')

The [DiGi\.Analytical\.Building\.Enums\.BuildingModelDetailLevel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.enums.buildingmodeldetaillevel 'DiGi\.Analytical\.Building\.Enums\.BuildingModelDetailLevel') that determines whether components become individual nodes or are merged into a single envelope node per building\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.GLTF\.Classes\.GLTFNode](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnode 'DiGi\.GLTF\.Classes\.GLTFNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.GLTF\.Classes\.GLTFNode](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnode 'DiGi\.GLTF\.Classes\.GLTFNode') instances for all convertible components, or null if the building model is null or has no components\.

<a name='DiGi.GLTF.Analytical.Convert.ToGLTF_GLTFNodes(thisDiGi.Analytical.Building.Interfaces.IComponent,DiGi.Core.Interfaces.IReference,double)'></a>

## Convert\.ToGLTF\_GLTFNodes\(this IComponent, IReference, double\) Method

Converts the specified building [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent') \(for example a wall, a floor or a roof\) into [DiGi\.GLTF\.Classes\.GLTFNode](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnode 'DiGi\.GLTF\.Classes\.GLTFNode') instances using its surface representation \(see [DiGi\.Analytical\.Building\.Query\.Surface3D\(DiGi\.Analytical\.Building\.Interfaces\.IComponent\)](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.query.surface3d#digi-analytical-building-query-surface3d(digi-analytical-building-interfaces-icomponent) 'DiGi\.Analytical\.Building\.Query\.Surface3D\(DiGi\.Analytical\.Building\.Interfaces\.IComponent\)')\) and default component styling\.

```csharp
public static System.Collections.Generic.List<DiGi.GLTF.Classes.GLTFNode>? ToGLTF_GLTFNodes(this DiGi.Analytical.Building.Interfaces.IComponent? component, DiGi.Core.Interfaces.IReference? reference=null, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.GLTF.Analytical.Convert.ToGLTF_GLTFNodes(thisDiGi.Analytical.Building.Interfaces.IComponent,DiGi.Core.Interfaces.IReference,double).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The building component to be converted\. This value can be null\.

<a name='DiGi.GLTF.Analytical.Convert.ToGLTF_GLTFNodes(thisDiGi.Analytical.Building.Interfaces.IComponent,DiGi.Core.Interfaces.IReference,double).reference'></a>

`reference` [DiGi\.Core\.Interfaces\.IReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireference 'DiGi\.Core\.Interfaces\.IReference')

The optional [DiGi\.Core\.Interfaces\.IReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireference 'DiGi\.Core\.Interfaces\.IReference') identifying the component \(for example a county \+ building \+ component [DiGi\.Core\.Classes\.ComplexReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.complexreference 'DiGi\.Core\.Classes\.ComplexReference')\)\. Its string form becomes the node reference and its last step becomes the node name \(see [Name\(this IReference\)](DiGi.GLTF.Analytical.md#DiGi.GLTF.Analytical.Query.Name(thisDiGi.Core.Interfaces.IReference) 'DiGi\.GLTF\.Analytical\.Query\.Name\(this DiGi\.Core\.Interfaces\.IReference\)')\)\.

<a name='DiGi.GLTF.Analytical.Convert.ToGLTF_GLTFNodes(thisDiGi.Analytical.Building.Interfaces.IComponent,DiGi.Core.Interfaces.IReference,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during triangulation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.GLTF\.Classes\.GLTFNode](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnode 'DiGi\.GLTF\.Classes\.GLTFNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list with a single [DiGi\.GLTF\.Classes\.GLTFNode](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnode 'DiGi\.GLTF\.Classes\.GLTFNode') representing the component, or null if the component has no supported surface geometry\.

<a name='DiGi.GLTF.Analytical.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.GLTF.Analytical.Modify.Register()'></a>

## Modify\.Register\(\) Method

Registers all [DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.interfaces.igltfnodeconverter 'DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter') implementations of this assembly \(the DiGi\.Analytical converters under /Classes/Converter\) with the generic DiGi\.GLTF engine\.

Consuming applications call this method once at startup to enable the conversion of DiGi.Analytical objects by the generic DiGi.GLTF endpoints and scene factories.

```csharp
public static void Register();
```

<a name='DiGi.GLTF.Analytical.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.GLTF.Analytical.Query.Color(thisDiGi.Core.Interfaces.ISerializableObject)'></a>

## Query\.Color\(this ISerializableObject\) Method

Gets the default display [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color') for the specified building component \(for example a wall, a floor or a roof\)\.

```csharp
public static DiGi.Core.Classes.Color? Color(this DiGi.Core.Interfaces.ISerializableObject? serializableObject);
```
#### Parameters

<a name='DiGi.GLTF.Analytical.Query.Color(thisDiGi.Core.Interfaces.ISerializableObject).serializableObject'></a>

`serializableObject` [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The building component to be styled\. This value can be null\.

#### Returns
[DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color')  
A [DiGi\.Core\.Classes\.Color](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.color 'DiGi\.Core\.Classes\.Color') representing the default styling of the component, or null if no default styling is defined\.

<a name='DiGi.GLTF.Analytical.Query.Name(thisDiGi.Core.Interfaces.IReference)'></a>

## Query\.Name\(this IReference\) Method

Gets the display name for the specified [DiGi\.Core\.Interfaces\.IReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireference 'DiGi\.Core\.Interfaces\.IReference'): the last step of a [DiGi\.Core\.Classes\.ComplexReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.complexreference 'DiGi\.Core\.Classes\.ComplexReference') chain \(or the reference itself\) rendered as FullTypeName::UniqueId\.

```csharp
public static string? Name(this DiGi.Core.Interfaces.IReference? reference);
```
#### Parameters

<a name='DiGi.GLTF.Analytical.Query.Name(thisDiGi.Core.Interfaces.IReference).reference'></a>

`reference` [DiGi\.Core\.Interfaces\.IReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.ireference 'DiGi\.Core\.Interfaces\.IReference')

The reference to be named\. This value can be null\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The display name in the FullTypeName::UniqueId format, or null if the reference does not resolve to an [DiGi\.Core\.Interfaces\.IUniqueReference](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniquereference 'DiGi\.Core\.Interfaces\.IUniqueReference') with a type and a unique identifier\.