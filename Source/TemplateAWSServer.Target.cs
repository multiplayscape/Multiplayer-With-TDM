

using UnrealBuildTool;
using System.Collections.Generic;

public class TemplateAWSServerTarget : TargetRules
{
	public TemplateAWSServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "TemplateAWS" } );
	}
}
