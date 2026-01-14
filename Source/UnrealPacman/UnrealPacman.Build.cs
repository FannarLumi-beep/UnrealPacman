// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UnrealPacman : ModuleRules
{
	public UnrealPacman(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"UnrealPacman",
			"UnrealPacman/Variant_Platforming",
			"UnrealPacman/Variant_Platforming/Animation",
			"UnrealPacman/Variant_Combat",
			"UnrealPacman/Variant_Combat/AI",
			"UnrealPacman/Variant_Combat/Animation",
			"UnrealPacman/Variant_Combat/Gameplay",
			"UnrealPacman/Variant_Combat/Interfaces",
			"UnrealPacman/Variant_Combat/UI",
			"UnrealPacman/Variant_SideScrolling",
			"UnrealPacman/Variant_SideScrolling/AI",
			"UnrealPacman/Variant_SideScrolling/Gameplay",
			"UnrealPacman/Variant_SideScrolling/Interfaces",
			"UnrealPacman/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
