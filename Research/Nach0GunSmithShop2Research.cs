using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
    [AutoLoadedResearchable]
    public class Nach0GunSmithShop2Research : BaseResearchable
    {
        public Nach0GunSmithShop2Research()
        {
            key = "Nach0GunSmithShop2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0GunSmithShop2.png";
            iterationCount = 50;
            AddIterationRequirement("lead");
            AddIterationRequirement("sciencebagmilitary");
            AddIterationRequirement("gunsmithshop");
            AddDependency("pipliz.baseresearch.gunsmithshop");
            AddDependency("Nach0SecondJobsResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter.gunsmithshop2", true, "pipliz.crafter");
        }
    }
}
