using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Research
{
    [AutoLoadedResearchable]
    public class Nach0SecondJobsResearch : BaseResearchable
    {
        public Nach0SecondJobsResearch()
        {
            key = "Nach0Archery2Research";
            icon = "gamedata/mods/NACH0/MoreJobs/gamedata/textures/icons/Nach0SecondJobsResearch.png";
            iterationCount = 100;
            AddIterationRequirement("sciencebagadvanced", 10);
            AddDependency("pipliz.baseresearch.sciencebagadvanced");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
        }
    }
}
