using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
    [AutoLoadedResearchable]
    public class Nach0BronzeAnvil2Research : BaseResearchable
    {
        public Nach0BronzeAnvil2Research()
        {
            key = "Nach0BronzeAnvil2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0BronzeAnvil2.png";
            iterationCount = 6;
            AddIterationRequirement("bronzeingot");
            AddIterationRequirement("coppertools");
            AddIterationRequirement("coppernails");
            AddIterationRequirement("bronzeanvil");
            AddDependency("pipliz.baseresearch.bronzeanvil");
            AddDependency("Nach0SecondJobsResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter.bronzeanvil2", true, "pipliz.crafter");
        }
    }
}
