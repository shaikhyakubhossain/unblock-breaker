// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class unBlockBreaker : ModuleRules
{
	public unBlockBreaker(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		privateIncludePaths.AddRange(new string[] { "unBlockBreaker/Private" });

		PublicIncludePaths.AddRange(new string[] { "unBlockBreaker/Public" });

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
