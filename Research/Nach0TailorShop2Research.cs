using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
    [AutoLoadedResearchable]
    public class Nach0TailorShop2Research : BaseResearchable
    {
        public Nach0TailorShop2Research()
        {
            key = "Nach0TailorShop2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0TailorShop2.png";
            iterationCount = 6;
            AddIterationRequirement("coatedplanks");
            AddIterationRequirement("flax");
            AddIterationRequirement("coppertools");
            AddIterationRequirement("tailorshop");
            AddDependency("pipliz.baseresearch.tailorshop");
            AddDependency("Nach0SecondJobsResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter.tailorshop2", true, "Nach0Crafter2Job");
        }
    }
}
