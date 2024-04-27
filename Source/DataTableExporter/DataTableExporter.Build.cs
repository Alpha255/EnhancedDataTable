using UnrealBuildTool;

public class DataTableExporter : ModuleRules
{
    public DataTableExporter(ReadOnlyTargetRules Target) : base(Target)
    {
        PublicDependencyModuleNames.AddRange(
            new string[] {
                "Core"
            });
    }
}