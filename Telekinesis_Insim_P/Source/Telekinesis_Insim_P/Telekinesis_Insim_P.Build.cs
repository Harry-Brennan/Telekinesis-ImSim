// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Telekinesis_Insim_P : ModuleRules
{
	public Telekinesis_Insim_P(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
