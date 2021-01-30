using UnrealBuildTool;

public class IVTarget : TargetRules
{
	public IVTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("IV");
	}
}
