using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
	[AutoLoadedResearchable]
	public class Nach0ScienceBagLife2Research : BaseResearchable
	{
		public Nach0ScienceBagLife2Research()
		{
			key = "Nach0ScienceBagLife2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0ScienceBagLife2Research.png";
            iterationCount = 6;
			AddIterationRequirement("flour");
			AddIterationRequirement("berry", 5);
			AddIterationRequirement("clothing");
			AddIterationRequirement("linenbag");
			AddDependency("pipliz.baseresearch.sciencebaglife");
            AddDependency("Nach0SecondJobsResearch");
        }

		public override void OnResearchComplete (ScienceManagerPlayer manager, EResearchCompletionReason reason)
		{
			RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.technologist2.sciencebaglife", true, "Nach0Technologist2Job");
		}
	}
}
