﻿using Pipliz.Mods.APIProvider.Jobs;
using Server.NPCs;

namespace Jobs
{
    public class Nach0StoneMason2Job : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public static float StaticCraftingCooldown = 8f;
        public override string NPCTypeKey => "Nach0StoneMason2Job";
        public override float CraftingCooldown { get => Nach0StoneMason2Job.StaticCraftingCooldown; set => Nach0StoneMason2Job.StaticCraftingCooldown = value; }
        public override int MaxRecipeCraftsPerHaul => 5;

        public new NPCTypeStandardSettings GetNPCTypeDefinition()
        {
            return new NPCTypeStandardSettings()
            {
                keyName = NPCTypeKey,
                printName = "2nd Stone Mason",
                maskColor1 = new UnityEngine.Color32(0, 0, 0, 0),
                type = NPCTypeID.GetNextID()
            };
        }
    }
}