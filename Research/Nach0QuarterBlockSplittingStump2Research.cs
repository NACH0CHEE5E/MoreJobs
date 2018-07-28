using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
	[AutoLoadedResearchable]
	public class Nach0QuarterBlockSplittingStump2Research : BaseResearchable
	{
		public Nach0QuarterBlockSplittingStump2Research()
		{
			key = "Nach0QuarterBlockSplittingStump2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0QuarterBlockSplittingStump2Research.png";
            iterationCount = 20;
			AddIterationRequirement("sciencebagbasic");
			AddDependency("pipliz.baseresearch.quarterblocksplittingstump");
            AddDependency("Nach0SecondJobsResearch");
        }

		public override void OnResearchComplete (ScienceManagerPlayer manager, EResearchCompletionReason reason)
		{
			var storage = RecipeStorage.GetPlayerStorage(manager.Player);
			storage.SetRecipeAvailability("pipliz.woodcutter2.quarterblockbrowndark", true, "Nach0WoodCutter2Job");
			storage.SetRecipeAvailability("pipliz.woodcutter2.quarterblockbrownlight", true, "Nach0WoodCutter2Job");
		}
	}
}
