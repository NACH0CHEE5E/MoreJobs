using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
	[AutoLoadedResearchable]
	public class Nach0CrossBowBolt2Research : BaseResearchable
	{
		public Nach0CrossBowBolt2Research()
		{
			key = "Nach0CrossBowBolt2Research";
			icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0CrossBowBolt2Research.png";
			iterationCount = 20;
			AddIterationRequirement("sciencebagbasic");
			AddIterationRequirement("sciencebagmilitary");
			AddDependency("pipliz.baseresearch.crossbowbolt");
            AddDependency("Nach0SecondJobsResearch");
        }

		public override void OnResearchComplete (ScienceManagerPlayer manager, EResearchCompletionReason reason)
		{
			RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.metalsmith2.crossbowbolt", true, "Nach0MetalSmith2Job");
		}
	}
}
