// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PracticasPresenciale : ModuleRules
{
	public PracticasPresenciale(ReadOnlyTargetRules Target) : base(Target)
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
			"PracticasPresenciale",
			"PracticasPresenciale/Variant_Platforming",
			"PracticasPresenciale/Variant_Platforming/Animation",
			"PracticasPresenciale/Variant_Combat",
			"PracticasPresenciale/Variant_Combat/AI",
			"PracticasPresenciale/Variant_Combat/Animation",
			"PracticasPresenciale/Variant_Combat/Gameplay",
			"PracticasPresenciale/Variant_Combat/Interfaces",
			"PracticasPresenciale/Variant_Combat/UI",
			"PracticasPresenciale/Variant_SideScrolling",
			"PracticasPresenciale/Variant_SideScrolling/AI",
			"PracticasPresenciale/Variant_SideScrolling/Gameplay",
			"PracticasPresenciale/Variant_SideScrolling/Interfaces",
			"PracticasPresenciale/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
