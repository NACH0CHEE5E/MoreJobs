using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
	[AutoLoadedResearchable]
	public class Nach0Lantern2Research : BaseResearchable
	{
		public Nach0Lantern2Research()
		{
			key = "Nach0Lantern2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0Lantern2Research.png";
            iterationCount = 10;
			AddIterationRequirement("sciencebagbasic", 5);
			AddIterationRequirement("ironrivet");
			AddIterationRequirement("crystal");
			AddDependency("pipliz.baseresearch.lantern");
            AddDependency("Nach0SecondJobsResearch");
        }

		public override void OnResearchComplete (ScienceManagerPlayer manager, EResearchCompletionReason reason)
		{
			var storage = RecipeStorage.GetPlayerStorage(manager.Player);
			storage.SetRecipeAvailability("pipliz.metalsmith2.lanternyellow", true, "Nach0MetalSmith2Job");
			storage.SetRecipeAvailability("pipliz.dyer2.lanternwhite", true, "Nach0Dyer2Job");
			storage.SetRecipeAvailability("pipliz.dyer2.lanterngreen", true, "Nach0Dyer2Job");
			storage.SetRecipeAvailability("pipliz.dyer2.lanternblue", true, "Nach0Dyer2Job");
			storage.SetRecipeAvailability("pipliz.dyer2.lanternred", true, "Nach0Dyer2Job");
			storage.SetRecipeAvailability("pipliz.dyer2.lanternorange", true, "Nach0Dyer2Job");
			storage.SetRecipeAvailability("pipliz.dyer2.lanterncyan", true, "Nach0Dyer2Job");
			storage.SetRecipeAvailability("pipliz.dyer2.lanternpink", true, "Nach0Dyer2Job");

		}
	}
}
