using System.IO;
using PhentrixGames.NewColonyAPI.Helpers;
using System.Collections.Generic;
using PhentrixGames.NewColonyAPI.Managers;

namespace MoreJobs
{
    [ModLoader.ModManager]
    public static class MoreJobs
    {
        public static string ModFolder = "gamedata/mods/NACH0/MoreJobs/";
        public static string ModGamedata = "gamedata/mods/NACH0/MoreJobs/gamedata/";
        public static string LocaleFolder = "gamedata/mods/NACH0/MoreJobs/gamedata/locale/";
        public static string ModKey = "NACH0.MoreJobs";

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnAssemblyLoaded, "NACH0.MoreJobs.assemblyload")]
        public static void OnAssemblyLoaded(string path)
        {
            ModFolder = Path.GetDirectoryName(path);
    
            ModGamedata = Path.Combine(Path.GetDirectoryName(path), "gamedata/").Replace("\\", "/");

            LocaleFolder = Path.Combine(Path.GetDirectoryName(path), "gamedata/locale/").Replace("\\", "/");

            Utilities.CreateLogs("MoreJobs");
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterModsLoaded, "NACH0.MoreJobs.AfterModsLoaded")]
        [ModLoader.ModCallbackProvidesFor("phentrixgames.newcolonyapi.AfterModsLoaded")]
        public static void AfterStartup(List<ModLoader.ModDescription> a)
        {
            ModManager.RegisterMod("MoreJobs", ModFolder);
            LocalizationManager.Localize("MoreJobs", LocaleFolder);
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, "NACH0.MoreJobs.RegisterJobs")]
        [ModLoader.ModCallbackProvidesFor("pipliz.apiprovider.jobs.resolvetypes")]
        public static void AfterDefiningNPCTypes()
        {
            JobManager.RegisterJob<Jobs.Nach0Baker2Job>("Nach0Oven2", "Nach0Baker2Job");
            JobManager.RegisterJob<Jobs.Nach0Baker2Job>("Nach0Oven2X-", "Nach0Baker2Job");
            JobManager.RegisterJob<Jobs.Nach0Baker2Job>("Nach0Oven2X+", "Nach0Baker2Job");
            JobManager.RegisterJob<Jobs.Nach0Baker2Job>("Nach0Oven2Z-", "Nach0Baker2Job");
            JobManager.RegisterJob<Jobs.Nach0Baker2Job>("Nach0Oven2Z+", "Nach0Baker2Job");

            JobManager.RegisterJob<Jobs.Nach0Bloomery2Job>("Nach0Bloomery2", "Nach0Bloomery2Job");
            JobManager.RegisterJob<Jobs.Nach0Bloomery2Job>("Nach0Bloomery2X-", "Nach0Bloomery2Job");
            JobManager.RegisterJob<Jobs.Nach0Bloomery2Job>("Nach0Bloomery2X+", "Nach0Bloomery2Job");
            JobManager.RegisterJob<Jobs.Nach0Bloomery2Job>("Nach0Bloomery2Z-", "Nach0Bloomery2Job");
            JobManager.RegisterJob<Jobs.Nach0Bloomery2Job>("Nach0Bloomery2Z+", "Nach0Bloomery2Job");

            JobManager.RegisterJob<Jobs.Nach0Crafter2Job>("Nach0Workbench2", "Nach0Crafter2Job");

            JobManager.RegisterJob<Jobs.Nach0Dyer2Job>("Nach0Dyer2", "Nach0Dyer2Job");

            JobManager.RegisterJob<Jobs.Nach0FineryForge2Job>("Nach0FineryForge2", "Nach0FineryForge2Job");
            JobManager.RegisterJob<Jobs.Nach0FineryForge2Job>("Nach0FineryForge2X-", "Nach0FineryForge2Job");
            JobManager.RegisterJob<Jobs.Nach0FineryForge2Job>("Nach0FineryForge2X+", "Nach0FineryForge2Job");
            JobManager.RegisterJob<Jobs.Nach0FineryForge2Job>("Nach0FineryForge2Z-", "Nach0FineryForge2Job");
            JobManager.RegisterJob<Jobs.Nach0FineryForge2Job>("Nach0FineryForge2Z+", "Nach0FineryForge2Job");

            JobManager.RegisterJob<Jobs.Nach0Grinder2Job>("Nach0Grindstone2", "Nach0Grinder2Job");

            JobManager.RegisterJob<Jobs.Nach0GunSmither2Job>("Nach0GunSmith2", "Nach0GunSmither2Job");

            JobManager.RegisterJob<Jobs.Nach0Kiln2Job>("Nach0Kiln2", "Nach0Kiln2Job");
            JobManager.RegisterJob<Jobs.Nach0Kiln2Job>("Nach0Kiln2X-", "Nach0Kiln2Job");
            JobManager.RegisterJob<Jobs.Nach0Kiln2Job>("Nach0Kiln2X+", "Nach0Kiln2Job");
            JobManager.RegisterJob<Jobs.Nach0Kiln2Job>("Nach0Kiln2Z-", "Nach0Kiln2Job");
            JobManager.RegisterJob<Jobs.Nach0Kiln2Job>("Nach0Kiln2Z+", "Nach0Kiln2Job");

            JobManager.RegisterJob<Jobs.Nach0Merchant2Job>("Nach0Shop2", "Nach0Merchant2Job");

            JobManager.RegisterJob<Jobs.Nach0MetalSmithJ2Job>("Nach0Anvil2", "Nach0MetalSmithJ2Job");

            JobManager.RegisterJob<Jobs.Nach0Minter2Job>("Nach0Mint2", "Nach0Minter2Job");

            JobManager.RegisterJob<Jobs.Nach0Smelter2Job>("Nach0Furnace2", "Nach0Smelter2Job");
            JobManager.RegisterJob<Jobs.Nach0Smelter2Job>("Nach0Furnace2X-", "Nach0Smelter2Job");
            JobManager.RegisterJob<Jobs.Nach0Smelter2Job>("Nach0Furnace2X+", "Nach0Smelter2Job");
            JobManager.RegisterJob<Jobs.Nach0Smelter2Job>("Nach0Furnace2Z-", "Nach0Smelter2Job");
            JobManager.RegisterJob<Jobs.Nach0Smelter2Job>("Nach0Furnace2Z+", "Nach0Smelter2Job");

            JobManager.RegisterJob<Jobs.Nach0StoneCutter2Job>("Nach0Mason2", "Nach0StoneCutter2Job");

            JobManager.RegisterJob<Jobs.Nach0Tailor2Job>("Nach0Tailor2", "Nach0Tailor2Job");

            JobManager.RegisterJob<Jobs.Nach0Technologist2Job>("Nach0TechnologistTable2", "Nach0Technologist2Job");

            JobManager.RegisterJob<Jobs.Nach0WoodCutter2Job>("Nach0CoppingBlock2", "Nach0WoodCutter2Job");
        }
    }
}