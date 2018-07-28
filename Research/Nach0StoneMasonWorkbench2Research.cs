using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
    [AutoLoadedResearchable]
    public class Nach0StoneMasonWorkbench2Research : BaseResearchable
    {
        public Nach0StoneMasonWorkbench2Research()
        {
            key = "Nach0StoneMasonWorkbench2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0StoneMasonWorkbench2.png";
            iterationCount = 20;
            AddIterationRequirement("sciencebagbasic");
            AddIterationRequirement("stonemasonworkbench");
            AddDependency("pipliz.baseresearch.stonemasonworkbench");
            AddDependency("Nach0SecondJobsResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter.stonemasonworkbench2", true, "Nach0Crafter2Job");
        }
    }
}
