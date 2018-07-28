using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
    [AutoLoadedResearchable]
    public class Nach0BronzeMinting2Research : BaseResearchable
    {
        public Nach0BronzeMinting2Research()
        {
            key = "Nach0BronzeMinting2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0BronzeMinting2Research.png";
            iterationCount = 20;
            AddIterationRequirement("sciencebagbasic");
            AddIterationRequirement("bronzeingot");
            AddIterationRequirement("mint");
            AddIterationRequirement("shop");
            AddDependency("pipliz.baseresearch.bronzeminting");
            AddDependency("Nach0SecondJobsResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter.shop2", true, "pipliz.crafter");
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter.mint2", true, "pipliz.crafter");
        }
    }
}
