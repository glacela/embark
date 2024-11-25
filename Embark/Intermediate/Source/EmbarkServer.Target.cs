using UnrealBuildTool;

public class EmbarkServerTarget : TargetRules
{
	public EmbarkServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Embark");
	}
}
