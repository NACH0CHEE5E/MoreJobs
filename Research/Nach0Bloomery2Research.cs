using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
    [AutoLoadedResearchable]
    public class Nach0Bloomery2Research : BaseResearchable
    {
        public Nach0Bloomery2Research()
        {
            key = "Nach0Bloomery2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0Bloomery2.png";
            iterationCount = 20;
            AddIterationRequirement("sciencebagbasic");
            AddIterationRequirement("bloomery");
            AddDependency("pipliz.baseresearch.bloomery");
            AddDependency("Nach0SecondJobsResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter.bloomery2", true, "pipliz.crafter");
        }
    }
}
