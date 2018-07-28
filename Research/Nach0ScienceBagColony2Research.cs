using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
	[AutoLoadedResearchable]
	public class Nach0ScienceBagColony2Research : BaseResearchable
	{
		public Nach0ScienceBagColony2Research()
		{
			key = "Nach0ScienceBagColony2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0ScienceBagBasic2Research.png";
            iterationCount = 10;
			AddIterationRequirement("bronzeanvil");
			AddIterationRequirement("fineryforge");
			AddIterationRequirement("matchlockgun");
			AddIterationRequirement("linenbag");
            AddDependency("Nach0SecondJobsResearch");
            AddDependency("pipliz.baseresearch.sciencebagcolony");
		}

		public override void OnResearchComplete (ScienceManagerPlayer manager, EResearchCompletionReason reason)
		{
			RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.technologist2.sciencebagcolony", true, "Nach0Technologist2Job");
		}
	}
}
