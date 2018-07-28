using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
	[AutoLoadedResearchable]
	public class Nach0ScienceBagBasic2Research : BaseResearchable
	{
		public Nach0ScienceBagBasic2Research()
		{
			key = "Nach0ScienceBagBasic2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0ScienceBagBasic2Research.png";
            iterationCount = 6;
			AddIterationRequirement("linenbag");
			AddIterationRequirement("coppertools");
			AddIterationRequirement("bronzeplate");
			AddIterationRequirement("bricks", 3);
			AddDependency("pipliz.baseresearch.sciencebagbasic");
            AddDependency("Nach0SecondJobsResearch");
        }

		public override void OnResearchComplete (ScienceManagerPlayer manager, EResearchCompletionReason reason)
		{
			RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.technologist2.sciencebagbasic", true, "Nach0Technologist2Job");
		}
	}
}
