using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
    [AutoLoadedResearchable]
    public class Nach0FineryForge2Research : BaseResearchable
    {
        public Nach0FineryForge2Research()
        {
            key = "Nach0FineryForge2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0FineryForge2.png";
            iterationCount = 100;
            AddIterationRequirement("sciencebagbasic");
            AddIterationRequirement("ironwrought");
            AddIterationRequirement("fineryforge");
            AddDependency("pipliz.baseresearch.fineryforge");
            AddDependency("Nach0SecondJobsResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter.fineryforge2", true, "pipliz.metalsmithjob");
        }
    }
}
