using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
	[AutoLoadedResearchable]
	public class Nach0ScienceBagAdvanced2Research : BaseResearchable
	{
		public Nach0ScienceBagAdvanced2Research()
		{
			key = "Nach0ScienceBagAdvanced2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0ScienceBagAdvanced2Research.png";
            iterationCount = 10;
			AddIterationRequirement("steelparts");
			AddIterationRequirement("gunpowderpouch");
			AddIterationRequirement("silveringot");
			AddIterationRequirement("linenbag");
			AddDependency("pipliz.baseresearch.sciencebagadvanced");
            AddDependency("Nach0SecondJobsResearch");
        }

		public override void OnResearchComplete (ScienceManagerPlayer manager, EResearchCompletionReason reason)
		{
			RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.technologist2.sciencebagadvanced", true, "Nach0Technologist2Job");
		}
	}
}
