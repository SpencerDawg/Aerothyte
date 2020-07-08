using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using static Terraria.World;
using Terraria.ModLoader.IO;

namespace Aerothyte
{
    public class AerothyteWorld : ModWorld
    {
        public override TagCompound Save()
        {
            //save boss and npc stuff
                return base.Save();
        }
        public override void Load(TagCompound tag)
        {
            base.Load(tag);
        }
        #region saltwatermines biome
        public bool InSaltwaterMine = false;
        
        public override void Initialize()
        {
            
        }
        public override void ModifyWorldGenTasks(List<Terraria.WorldBuilding.GenPass> tasks, ref float totalWeight)
        {
            base.ModifyWorldGenTasks(tasks, ref totalWeight);
        }
        public override void TileCountsAvailable(int[] tileCounts)
        {
            if (tileCounts[TileID.LivingWood] == 50) //replace with TileType<SaltwaterMineTile1 || SaltwaterMineTile2 || etc>()
            {

            }
        }
        #endregion
    }
}
