#### [DiGi\.GLTF\.Analytical](DiGi.GLTF.Analytical.Overview.md 'DiGi\.GLTF\.Analytical\.Overview')

## DiGi\.GLTF\.Analytical\.Classes Namespace
### Classes

<a name='DiGi.GLTF.Analytical.Classes.BuildingModelGLTFNodeConverter'></a>

## BuildingModelGLTFNodeConverter Class

Converts a [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') into [DiGi\.GLTF\.Classes\.GLTFNode](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnode 'DiGi\.GLTF\.Classes\.GLTFNode') instances by converting all of its components \(see [ToGLTF\_GLTFNodes\(this BuildingModel, double, BuildingDisplayMode\)](DiGi.GLTF.Analytical.md#DiGi.GLTF.Analytical.Convert.ToGLTF_GLTFNodes(thisDiGi.Analytical.Building.Classes.BuildingModel,double,DiGi.GLTF.Analytical.Enums.BuildingDisplayMode) 'DiGi\.GLTF\.Analytical\.Convert\.ToGLTF\_GLTFNodes\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel, double, DiGi\.GLTF\.Analytical\.Enums\.BuildingDisplayMode\)')\)\.

Registered automatically with the generic DiGi.GLTF engine by assembly scanning (see [Register\(\)](DiGi.GLTF.Analytical.md#DiGi.GLTF.Analytical.Modify.Register() 'DiGi\.GLTF\.Analytical\.Modify\.Register\(\)')).

```csharp
public class BuildingModelGLTFNodeConverter : DiGi.GLTF.Classes.GLTFNodeConverter<DiGi.Analytical.Building.Classes.BuildingModel>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GLTF\.Classes\.GLTFNodeConverter&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnodeconverter-1 'DiGi\.GLTF\.Classes\.GLTFNodeConverter\`1')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnodeconverter-1 'DiGi\.GLTF\.Classes\.GLTFNodeConverter\`1') → BuildingModelGLTFNodeConverter
### Methods

<a name='DiGi.GLTF.Analytical.Classes.BuildingModelGLTFNodeConverter.Convert(DiGi.Analytical.Building.Classes.BuildingModel,double)'></a>

## BuildingModelGLTFNodeConverter\.Convert\(BuildingModel, double\) Method

Converts the specified [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') into [DiGi\.GLTF\.Classes\.GLTFNode](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnode 'DiGi\.GLTF\.Classes\.GLTFNode') instances holding geometry in world coordinates\.

```csharp
public override System.Collections.Generic.List<DiGi.GLTF.Classes.GLTFNode>? Convert(DiGi.Analytical.Building.Classes.BuildingModel serializableObject, double tolerance);
```
#### Parameters

<a name='DiGi.GLTF.Analytical.Classes.BuildingModelGLTFNodeConverter.Convert(DiGi.Analytical.Building.Classes.BuildingModel,double).serializableObject'></a>

`serializableObject` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') to be converted\.

<a name='DiGi.GLTF.Analytical.Classes.BuildingModelGLTFNodeConverter.Convert(DiGi.Analytical.Building.Classes.BuildingModel,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during triangulation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.GLTF\.Classes\.GLTFNode](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnode 'DiGi\.GLTF\.Classes\.GLTFNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.GLTF\.Classes\.GLTFNode](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnode 'DiGi\.GLTF\.Classes\.GLTFNode') instances, or null if the model has no convertible components\.

<a name='DiGi.GLTF.Analytical.Classes.ComponentGLTFNodeConverter'></a>

## ComponentGLTFNodeConverter Class

Converts a standalone building [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent') \(for example a wall or a roof\) into [DiGi\.GLTF\.Classes\.GLTFNode](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnode 'DiGi\.GLTF\.Classes\.GLTFNode') instances using its surface representation \(see [ToGLTF\_GLTFNodes\(this IComponent, double\)](DiGi.GLTF.Analytical.md#DiGi.GLTF.Analytical.Convert.ToGLTF_GLTFNodes(thisDiGi.Analytical.Building.Interfaces.IComponent,double) 'DiGi\.GLTF\.Analytical\.Convert\.ToGLTF\_GLTFNodes\(this DiGi\.Analytical\.Building\.Interfaces\.IComponent, double\)')\)\.

Implemented against [DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.interfaces.igltfnodeconverter 'DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter') directly because [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent') is an interface matched by type test rather than a concrete serializable class. Registered automatically with the generic DiGi.GLTF engine by assembly scanning (see [Register\(\)](DiGi.GLTF.Analytical.md#DiGi.GLTF.Analytical.Modify.Register() 'DiGi\.GLTF\.Analytical\.Modify\.Register\(\)')).

```csharp
public class ComponentGLTFNodeConverter : DiGi.GLTF.Interfaces.IGLTFNodeConverter, DiGi.GLTF.Interfaces.IGLTFObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → ComponentGLTFNodeConverter

Implements [DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.interfaces.igltfnodeconverter 'DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter'), [DiGi\.GLTF\.Interfaces\.IGLTFObject](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.interfaces.igltfobject 'DiGi\.GLTF\.Interfaces\.IGLTFObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Methods

<a name='DiGi.GLTF.Analytical.Classes.ComponentGLTFNodeConverter.CanConvert(DiGi.Core.Interfaces.ISerializableObject)'></a>

## ComponentGLTFNodeConverter\.CanConvert\(ISerializableObject\) Method

Determines whether this converter can convert the specified object\.

```csharp
public bool CanConvert(DiGi.Core.Interfaces.ISerializableObject serializableObject);
```
#### Parameters

<a name='DiGi.GLTF.Analytical.Classes.ComponentGLTFNodeConverter.CanConvert(DiGi.Core.Interfaces.ISerializableObject).serializableObject'></a>

`serializableObject` [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The domain object to be checked\.

Implements [CanConvert\(ISerializableObject\)](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.interfaces.igltfnodeconverter.canconvert#digi-gltf-interfaces-igltfnodeconverter-canconvert(digi-core-interfaces-iserializableobject) 'DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter\.CanConvert\(DiGi\.Core\.Interfaces\.ISerializableObject\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object is an [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent'); otherwise, false\.

<a name='DiGi.GLTF.Analytical.Classes.ComponentGLTFNodeConverter.Convert(DiGi.Core.Interfaces.ISerializableObject,double)'></a>

## ComponentGLTFNodeConverter\.Convert\(ISerializableObject, double\) Method

Converts the specified building component into [DiGi\.GLTF\.Classes\.GLTFNode](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnode 'DiGi\.GLTF\.Classes\.GLTFNode') instances holding geometry in world coordinates\.

```csharp
public System.Collections.Generic.List<DiGi.GLTF.Classes.GLTFNode>? Convert(DiGi.Core.Interfaces.ISerializableObject serializableObject, double tolerance);
```
#### Parameters

<a name='DiGi.GLTF.Analytical.Classes.ComponentGLTFNodeConverter.Convert(DiGi.Core.Interfaces.ISerializableObject,double).serializableObject'></a>

`serializableObject` [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent') to be converted\.

<a name='DiGi.GLTF.Analytical.Classes.ComponentGLTFNodeConverter.Convert(DiGi.Core.Interfaces.ISerializableObject,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during triangulation\.

Implements [Convert\(ISerializableObject, double\)](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.interfaces.igltfnodeconverter.convert#digi-gltf-interfaces-igltfnodeconverter-convert(digi-core-interfaces-iserializableobject-system-double) 'DiGi\.GLTF\.Interfaces\.IGLTFNodeConverter\.Convert\(DiGi\.Core\.Interfaces\.ISerializableObject,System\.Double\)')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.GLTF\.Classes\.GLTFNode](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnode 'DiGi\.GLTF\.Classes\.GLTFNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.GLTF\.Classes\.GLTFNode](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnode 'DiGi\.GLTF\.Classes\.GLTFNode') instances, or null if the component has no supported surface geometry\.

<a name='DiGi.GLTF.Analytical.Classes.UrbanModelGLTFNodeConverter'></a>

## UrbanModelGLTFNodeConverter Class

Converts an [DiGi\.Analytical\.Urban\.Classes\.UrbanModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.urban.classes.urbanmodel 'DiGi\.Analytical\.Urban\.Classes\.UrbanModel') into [DiGi\.GLTF\.Classes\.GLTFNode](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnode 'DiGi\.GLTF\.Classes\.GLTFNode') instances by converting all contained building models \(see [ToGLTF\_GLTFNodes\(this UrbanModel, double\)](DiGi.GLTF.Analytical.md#DiGi.GLTF.Analytical.Convert.ToGLTF_GLTFNodes(thisDiGi.Analytical.Urban.Classes.UrbanModel,double) 'DiGi\.GLTF\.Analytical\.Convert\.ToGLTF\_GLTFNodes\(this DiGi\.Analytical\.Urban\.Classes\.UrbanModel, double\)')\)\.

Registered automatically with the generic DiGi.GLTF engine by assembly scanning (see [Register\(\)](DiGi.GLTF.Analytical.md#DiGi.GLTF.Analytical.Modify.Register() 'DiGi\.GLTF\.Analytical\.Modify\.Register\(\)')).

```csharp
public class UrbanModelGLTFNodeConverter : DiGi.GLTF.Classes.GLTFNodeConverter<DiGi.Analytical.Urban.Classes.UrbanModel>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.GLTF\.Classes\.GLTFNodeConverter&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnodeconverter-1 'DiGi\.GLTF\.Classes\.GLTFNodeConverter\`1')[DiGi\.Analytical\.Urban\.Classes\.UrbanModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.urban.classes.urbanmodel 'DiGi\.Analytical\.Urban\.Classes\.UrbanModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnodeconverter-1 'DiGi\.GLTF\.Classes\.GLTFNodeConverter\`1') → UrbanModelGLTFNodeConverter
### Methods

<a name='DiGi.GLTF.Analytical.Classes.UrbanModelGLTFNodeConverter.Convert(DiGi.Analytical.Urban.Classes.UrbanModel,double)'></a>

## UrbanModelGLTFNodeConverter\.Convert\(UrbanModel, double\) Method

Converts the specified [DiGi\.Analytical\.Urban\.Classes\.UrbanModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.urban.classes.urbanmodel 'DiGi\.Analytical\.Urban\.Classes\.UrbanModel') into [DiGi\.GLTF\.Classes\.GLTFNode](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnode 'DiGi\.GLTF\.Classes\.GLTFNode') instances holding geometry in world coordinates\.

```csharp
public override System.Collections.Generic.List<DiGi.GLTF.Classes.GLTFNode>? Convert(DiGi.Analytical.Urban.Classes.UrbanModel serializableObject, double tolerance);
```
#### Parameters

<a name='DiGi.GLTF.Analytical.Classes.UrbanModelGLTFNodeConverter.Convert(DiGi.Analytical.Urban.Classes.UrbanModel,double).serializableObject'></a>

`serializableObject` [DiGi\.Analytical\.Urban\.Classes\.UrbanModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.urban.classes.urbanmodel 'DiGi\.Analytical\.Urban\.Classes\.UrbanModel')

The [DiGi\.Analytical\.Urban\.Classes\.UrbanModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.urban.classes.urbanmodel 'DiGi\.Analytical\.Urban\.Classes\.UrbanModel') to be converted\.

<a name='DiGi.GLTF.Analytical.Classes.UrbanModelGLTFNodeConverter.Convert(DiGi.Analytical.Urban.Classes.UrbanModel,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used during triangulation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.GLTF\.Classes\.GLTFNode](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnode 'DiGi\.GLTF\.Classes\.GLTFNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.GLTF\.Classes\.GLTFNode](https://learn.microsoft.com/en-us/dotnet/api/digi.gltf.classes.gltfnode 'DiGi\.GLTF\.Classes\.GLTFNode') instances, or null if the model is empty\.