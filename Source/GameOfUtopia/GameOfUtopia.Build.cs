// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GameOfUtopia : ModuleRules
{
	public GameOfUtopia(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
