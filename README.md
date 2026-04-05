# pbr2msfs

Yet another tool to generate PBR texture composites, etc. Mainly for MSFS.

It works for me, but no warranties.


![Capture.](/artwork/Capture.jpg)


# Usage:

-	Bake or export your base RGB, Alpha, non-inverted Y Normal, Ambient Occlusion, Metallic and Roughness textures with your favorite tool.
	Probably in a format directly supported by .NET. <br>
	>Not all of them are needed, of course.

	>It does nothing with the MSFS Emission texture, that's standalone.
-	Select the containing folder.
-	The program will try to identify each PBR texture based on the filename. It searches for the common tokens, namely:<br>
	- Albedo :"color", "diff", "albedo", "basecolor","base"
	- Alpha: "alpha", "mask", "opacity"
	- Ambient occlusion:  "ao"
	- Roughness:  "rough"
	- Metallic: "metal"
	- Normal: "nor"
	>Search is case insensitive and partial substring.

	>If it fails you can always hand select them individually. Always double check.
-	The ARM, NRM, RGB+Alpha and inverted Y Normal textures will be automatically generated and you can save them somewhere.
-	Now, for the MSFS workflow, go to Blender for example, and create an fs-material with the generated RGBA, ARM and inverted Normal textures, maybe Emission too.
	>You may need to activate Alpha Blend.

Contains Magick.NET nuggets to support the EXR format.
