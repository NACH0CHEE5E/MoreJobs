using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
	[AutoLoadedResearchable]
	public class Nach0HerbFarming2Research : BaseResearchable
	{
		public Nach0HerbFarming2Research()
		{
			key = "Nach0HerbFarming2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0HerbFarming2Research.png";
            iterationCount = 20;
			AddIterationRequirement("sciencebagbasic");
			AddDependency("pipliz.baseresearch.herbfarming");
            AddDependency("Nach0SecondJobsResearch");
        }

		public override void OnResearchComplete (ScienceManagerPlayer manager, EResearchCompletionReason reason)
		{
			RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.merchant2.alkanetseeds", true, "Nach0Merchant2Job");
			RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.merchant2.hollyhockseeds", true, "Nach0Merchant2Job");
			RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.merchant2.wolfsbaneseeds", true, "Nach0Merchant2Job");
		}
	}
}
