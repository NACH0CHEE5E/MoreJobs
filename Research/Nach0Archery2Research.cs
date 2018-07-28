using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
    [AutoLoadedResearchable]
    public class Nach0Archery2Research : BaseResearchable
    {
        public Nach0Archery2Research()
        {
            key = "Nach0Archery2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0Archery2Research.png";
            iterationCount = 6;
            AddIterationRequirement("bronzearrow", 3);
            AddIterationRequirement("bowstring");
            AddDependency("pipliz.baseresearch.archery");
            AddDependency("Nach0SecondJobsResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter2.bow", true, "Nach0Crafter2Job");
        }
    }
}
