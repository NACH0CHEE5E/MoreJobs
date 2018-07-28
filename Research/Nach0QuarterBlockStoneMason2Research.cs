using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
	[AutoLoadedResearchable]
	public class Nach0QuarterBlockStoneMason2Research : BaseResearchable
	{
		public Nach0QuarterBlockStoneMason2Research()
		{
			key = "Nach0QuarterBlockStoneMason2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0QuarterBlockStoneMason2Research.png";
            iterationCount = 20;
			AddIterationRequirement("sciencebagbasic");
			AddDependency("pipliz.baseresearch.quarterblockstonemason");
            AddDependency("Nach0SecondJobsResearch");
        }

		public override void OnResearchComplete (ScienceManagerPlayer manager, EResearchCompletionReason reason)
		{
			var storage = RecipeStorage.GetPlayerStorage(manager.Player);
			storage.SetRecipeAvailability("pipliz.stonemason2.quarterblockgrey", true, "Nach0StoneMason2Job");
		}
	}
}
