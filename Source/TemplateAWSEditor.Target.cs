

using UnrealBuildTool;
using System.Collections.Generic;

public class TemplateAWSEditorTarget : TargetRules
{
	public TemplateAWSEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "TemplateAWS" } );
	}
}
