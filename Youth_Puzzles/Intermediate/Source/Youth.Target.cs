using UnrealBuildTool;

public class YouthTarget : TargetRules
{
	public YouthTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Youth");
	}
}
