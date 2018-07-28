using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
	[AutoLoadedResearchable]
	public class Nach0ScienceBagMilitary2Research : BaseResearchable
	{
		public Nach0ScienceBagMilitary2Research()
		{
			key = "Nach0ScienceBagMilitary2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0ScienceBagMilitary2Research.png";
            iterationCount = 6;
			AddIterationRequirement("ironsword");
			AddIterationRequirement("bronzearrow", 3);
			AddIterationRequirement("bow");
			AddIterationRequirement("linenbag");
			AddDependency("pipliz.baseresearch.sciencebagmilitary");
            AddDependency("Nach0SecondJobsResearch");
        }

		public override void OnResearchComplete (ScienceManagerPlayer manager, EResearchCompletionReason reason)
		{
			RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.technologist2.sciencebagmilitary", true, "Nach0Technologist2Job");
		}
	}
}
