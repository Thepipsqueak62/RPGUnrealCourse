// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RPGUnrealCourse : ModuleRules
{
	public RPGUnrealCourse(ReadOnlyTargetRules Target) : base(Target)
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
			"RPGUnrealCourse",
			"RPGUnrealCourse/Variant_Platforming",
			"RPGUnrealCourse/Variant_Platforming/Animation",
			"RPGUnrealCourse/Variant_Combat",
			"RPGUnrealCourse/Variant_Combat/AI",
			"RPGUnrealCourse/Variant_Combat/Animation",
			"RPGUnrealCourse/Variant_Combat/Gameplay",
			"RPGUnrealCourse/Variant_Combat/Interfaces",
			"RPGUnrealCourse/Variant_Combat/UI",
			"RPGUnrealCourse/Variant_SideScrolling",
			"RPGUnrealCourse/Variant_SideScrolling/AI",
			"RPGUnrealCourse/Variant_SideScrolling/Gameplay",
			"RPGUnrealCourse/Variant_SideScrolling/Interfaces",
			"RPGUnrealCourse/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
