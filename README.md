# DiGi.GLTF.Analytical

Bridge library converting the DiGi.Analytical object model (BuildingModel, UrbanModel, building components such as walls, floors and roofs) into generic DiGi.GLTF nodes.

The library keeps the generic DiGi.GLTF engine and the DiGi.GLTF.WebAPI extension free of domain references: it plugs the DiGi.Analytical conversions into the engine through the `IGLTFNodeConverter` registry. Consuming applications reference this library and call `DiGi.GLTF.Analytical.Modify.Register()` at startup to enable the converters.
