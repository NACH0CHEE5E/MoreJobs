using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
	[AutoLoadedResearchable]
	public class Nach0CrossBow2Research : BaseResearchable
	{
		public Nach0CrossBow2Research()
		{
			key = "Nach0CrossBow2Research";
			icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0CrossBow2Research.png";
			iterationCount = 50;
			AddIterationRequirement("sciencebagbasic");
			AddIterationRequirement("sciencebagmilitary");
			AddDependency("pipliz.baseresearch.crossbow");
            AddDependency("Nach0SecondJobsResearch");
        }

		public override void OnResearchComplete (ScienceManagerPlayer manager, EResearchCompletionReason reason)
		{
			RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.metalsmith2.crossbow", true, "Nach0MetalSmith2Job");
		}
	}
}
