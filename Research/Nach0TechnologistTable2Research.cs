using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
    [AutoLoadedResearchable]
    public class Nach0TechnologistTable2Research : BaseResearchable
    {
        public Nach0TechnologistTable2Research()
        {
            key = "Nach0TechnologistTable2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0TechnologistTable2.png";
            iterationCount = 6;
            AddIterationRequirement("coatedplanks");
            AddIterationRequirement("bronzeplate", 2);
            AddIterationRequirement("coppernails");
            AddIterationRequirement("technologisttable");
            AddDependency("pipliz.baseresearch.technologisttable");
            AddDependency("Nach0SecondJobsResearch");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter.technologisttable2", true, "Nach0Crafter2Job");
        }
    }
}
