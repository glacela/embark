using UnrealBuildTool;

public class EmbarkTarget : TargetRules
{
	public EmbarkTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Embark");
	}
}
