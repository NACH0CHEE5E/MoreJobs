using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
	[AutoLoadedResearchable]
	public class Nach0QuarterBlockDyer2Research : BaseResearchable
	{
		public Nach0QuarterBlockDyer2Research()
		{
			key = "Nach0QuarterBlockDyer2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0QuarterBlockDyer2Research.png";
            iterationCount = 20;
			AddIterationRequirement("sciencebagbasic");
			AddIterationRequirement("gypsum");
			AddIterationRequirement("charcoal");
			AddDependency("pipliz.baseresearch.quarterblockdyer");
            AddDependency("Nach0SecondJobsResearch");
        }

		public override void OnResearchComplete (ScienceManagerPlayer manager, EResearchCompletionReason reason)
		{
			var storage = RecipeStorage.GetPlayerStorage(manager.Player);
			storage.SetRecipeAvailability("pipliz.dyer2.quarterblockblack", true, "Nach0Dyer2Job");
			storage.SetRecipeAvailability("pipliz.dyer2.quarterblockwhite", true, "Nach0Dyer2Job");
		}
	}
}
