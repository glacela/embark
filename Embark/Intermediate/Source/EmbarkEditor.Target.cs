using UnrealBuildTool;

public class EmbarkEditorTarget : TargetRules
{
	public EmbarkEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Embark");
	}
}
