using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
    [AutoLoadedResearchable]
    public class Nach0Kiln2Research : BaseResearchable
    {
        public Nach0Kiln2Research()
        {
            key = "Nach0Kiln2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0Kiln2.png";
            iterationCount = 6;
            AddIterationRequirement("sciencebagbasic");
            AddIterationRequirement("bronzeplate");
            AddIterationRequirement("kiln");
            AddDependency("pipliz.baseresearch.kiln");
            AddDependency("Nach0SecondJobsResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter.kiln2", true, "pipliz.crafter");
        }
    }
}
