#### [DiGi\.GLTF\.Analytical](DiGi.GLTF.Analytical.Overview.md 'DiGi\.GLTF\.Analytical\.Overview')

## DiGi\.GLTF\.Analytical\.Enums Namespace
### Enums

<a name='DiGi.GLTF.Analytical.Enums.BuildingDisplayMode'></a>

## BuildingDisplayMode Enum

Defines how a building model is grouped into GLTF node instances\.

```csharp
public enum BuildingDisplayMode
```
### Fields

<a name='DiGi.GLTF.Analytical.Enums.BuildingDisplayMode.Component'></a>

`Component` 0

Each component \(wall, roof, floor, window\) becomes a separate selectable node\.

<a name='DiGi.GLTF.Analytical.Enums.BuildingDisplayMode.Envelope'></a>

`Envelope` 1

All components are merged into a single node per building, making the building selectable as a whole\.