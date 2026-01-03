// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CKGameProject : ModuleRules
{
	public CKGameProject(ReadOnlyTargetRules Target) : base(Target)
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
			"CKGameProject",
			"CKGameProject/Variant_Platforming",
			"CKGameProject/Variant_Platforming/Animation",
			"CKGameProject/Variant_Combat",
			"CKGameProject/Variant_Combat/AI",
			"CKGameProject/Variant_Combat/Animation",
			"CKGameProject/Variant_Combat/Gameplay",
			"CKGameProject/Variant_Combat/Interfaces",
			"CKGameProject/Variant_Combat/UI",
			"CKGameProject/Variant_SideScrolling",
			"CKGameProject/Variant_SideScrolling/AI",
			"CKGameProject/Variant_SideScrolling/Gameplay",
			"CKGameProject/Variant_SideScrolling/Interfaces",
			"CKGameProject/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
