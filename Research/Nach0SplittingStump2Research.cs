using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
    [AutoLoadedResearchable]
    public class Nach0SplittingStump2Research : BaseResearchable
    {
        public Nach0SplittingStump2Research()
        {
            key = "Nach0SplittingStump2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0SplittingStump2.png";
            iterationCount = 6;
            AddIterationRequirement("bronzeingot");
            AddIterationRequirement("coppertools");
            AddIterationRequirement("coppernails");
            AddIterationRequirement("splittingstump");
            AddDependency("pipliz.baseresearch.splittingstump");
            AddDependency("Nach0SecondJobsResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter.splittingstumptaiga2", true, "Nach0Crafter2Job");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter.splittingstumptemperate2", true, "Nach0Crafter2Job");
        }
    }
}
