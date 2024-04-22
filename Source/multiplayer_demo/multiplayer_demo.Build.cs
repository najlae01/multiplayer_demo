// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class multiplayer_demo : ModuleRules
{
	public multiplayer_demo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
