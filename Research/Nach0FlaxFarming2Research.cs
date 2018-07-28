using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
	[AutoLoadedResearchable]
	public class Nach0FlaxFarming2Research : BaseResearchable
	{
		public Nach0FlaxFarming2Research()
		{
			key = "Nach0FlaxFarming2Research";
			icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0FlaxFarming2Research.png";
			iterationCount = 6;
			AddIterationRequirement("berry", 3);
			AddIterationRequirement("coppernails");
            AddDependency("pipliz.baseresearch.flaxfarming");
            AddDependency("Nach0SecondJobsResearch");
        }

		public override void OnResearchComplete (ScienceManagerPlayer manager, EResearchCompletionReason reason)
		{
			RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter2.linseedoil", true, "Nach0Crafter2Job");
			RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter2.coatedplanks", true, "Nach0Crafter2Job");
			RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter2.adobe", true, "Nach0Crafter2Job");
			RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter2.bowstring", true, "Nach0Crafter2Job");

		}
	}
}
