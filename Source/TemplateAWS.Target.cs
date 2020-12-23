

using UnrealBuildTool;
using System.Collections.Generic;

public class TemplateAWSTarget : TargetRules
{
	public TemplateAWSTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "TemplateAWS" } );
	}
}
