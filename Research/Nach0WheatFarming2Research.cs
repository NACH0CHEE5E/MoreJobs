using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
    [AutoLoadedResearchable]
    public class Nach0WheatFarming2Research : BaseResearchable
    {
        public Nach0WheatFarming2Research()
        {
            key = "Nach0WheatFarming2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0WheatFarming2Research.png";
            iterationCount = 10;
            AddIterationRequirement("berry", 10);
            AddIterationRequirement("copperparts", 2);
            AddIterationRequirement("coppertools");
            AddIterationRequirement("oven");
            AddIterationRequirement("grindstone");
            AddDependency("pipliz.baseresearch.wheatfarming");
            AddDependency("Nach0SecondJobsResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter.oven2", true, "Nach0Crafter2Job");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter.grindstone2", true, "Nach0Crafter2Job");
        }
    }
}
