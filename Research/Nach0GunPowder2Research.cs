using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
	[AutoLoadedResearchable]
	public class Nach0GunPowder2Research : BaseResearchable
	{
		public Nach0GunPowder2Research()
		{
			key = "Nach0GunPowder2Research";
			icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0GunPowder2Research.png";
			iterationCount = 50;
			AddIterationRequirement("salpeter");
			AddIterationRequirement("sciencebagmilitary");
			AddDependency("pipliz.baseresearch.gunpowder");
            AddDependency("Nach0SecondJobsResearch");
        }

		public override void OnResearchComplete (ScienceManagerPlayer manager, EResearchCompletionReason reason)
		{
			RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.gunsmith2.gunpowder", true, "Nach0GunSmith2Job");
			RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.gunsmith2.gunpowderpouch", true, "Nach0GunSmith2Job");
		}
	}
}
