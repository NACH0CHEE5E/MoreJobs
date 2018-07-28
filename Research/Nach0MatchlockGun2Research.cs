using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
	[AutoLoadedResearchable]
	public class Nach0MatchlockGun2Research : BaseResearchable
	{
		public Nach0MatchlockGun2Research()
		{
			key = "Nach0MatchlockGun2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0MatchlockGun2Research.png";
            iterationCount = 50;
			AddIterationRequirement("leadbullet");
			AddIterationRequirement("gunpowderpouch");
			AddIterationRequirement("sciencebagmilitary");
			AddDependency("pipliz.baseresearch.matchlockgun");
            AddDependency("Nach0SecondJobsResearch");
        }

		public override void OnResearchComplete (ScienceManagerPlayer manager, EResearchCompletionReason reason)
		{
			RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.gunsmith2.matchlockgun", true, "Nach0GunSmith2Job");
		}
	}
}
