using UnrealBuildTool;

public class EmbarkClientTarget : TargetRules
{
	public EmbarkClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Embark");
	}
}
