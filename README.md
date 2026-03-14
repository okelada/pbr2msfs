# pbr2msfs

Yet another tool to generate PBR texture composites, etc. Mainly for MSFS.

It works for me, but no warranties.

# Usage:

-	Bake or export your base RGB, Alpha, non-inverted Y normal, Ambient Occlusion, Metallic and Roughness textures with your favorite tool.
	Probably in a format directly supported by .NET. <br>
	>Not all of them are needed, of course.
-	Select the containing folder.
-	The program will try to identify each PBR texture based on the filename. It searches for the common tokens, you know which ones.<br>
	>If it fails you can always hand correct it. Always double check.
-	The ARM, NRM, RGB+Alpha and inverted Y normal textures will be generated and you can save them somewhere.

Needs Magick.NET to support EXR format.
