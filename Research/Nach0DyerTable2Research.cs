using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
    [AutoLoadedResearchable]
    public class Nach0DyerTable2Research : BaseResearchable
    {
        public Nach0DyerTable2Research()
        {
            key = "Nach0DyerTable2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0DyerTable2.png";
            iterationCount = 20;
            AddIterationRequirement("sciencebagbasic");
            AddIterationRequirement("hollyhock");
            AddIterationRequirement("dyertable");
            AddDependency("pipliz.baseresearch.dyertable");
            AddDependency("Nach0SecondJobsResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter.dyertable2", true, "Nach0Crafter2Job");
        }
    }
}
