using UnrealBuildTool;

public class DataTableSearch : ModuleRules
{
    public DataTableSearch(ReadOnlyTargetRules Target) : base(Target)
    {
        PublicDependencyModuleNames.AddRange(
            new string[] {
                "Core"
            });

        PrivateDependencyModuleNames.AddRange(
            new string[] {
                "AssetRegistry",
            });
    }
}