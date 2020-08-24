using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using static Terraria.World;
using Terraria.ModLoader.IO;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;
using System;
using System.Threading.Tasks;

namespace Aerothyte
{
    public enum OceanSide : byte
    {
        Left,
        Right,
        CalamEnabled,
        ThorEnabled
    }
    public struct SaltwaterMineInfo
    {
        public Vector2 Size { get; set; }
        public OceanSide OceanSide;
        public bool BossDefeated { get; set; }
        public bool Hardmode { get; set; }
        public SaltwaterMineInfo(Vector2 Creationsize, OceanSide oceanside, bool bossDowned, bool hard)
        {
            Size = Creationsize;
            // 1 for left ocean, 2 for right ocean
            OceanSide = oceanside;
            BossDefeated = bossDowned;
            Hardmode = hard;
        }
    }
    public partial class AerothyteWorld : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight) {
        }
        /**
        TagCompound savedata = new TagCompound();
        SaltwaterMineInfo worldSaltwaterMineInfo;
        public override TagCompound Save()
        {
            return savedata;
        }
        public override void Load(TagCompound tag)
        {
            worldSaltwaterMineInfo = tag.Get<SaltwaterMineInfo>("swm");
        }
        #region saltwatermines biome
        public bool InSaltwaterMine = false;
        private void SaveSWM() { savedata.Add("swm", worldSaltwaterMineInfo); }
        public override void PreWorldGen()
        {
            OceanSide GetRandomOceanside()
            {
                //implement calthor support later
                if (Main.rand.NextBool() == true)
                    return OceanSide.Left;
                else 
                    return OceanSide.Right;
            }
            worldSaltwaterMineInfo = new SaltwaterMineInfo(new Vector2(Main.rand.Next(200,500), Main.rand.Next(200,500)), GetRandomOceanside(), false, false);
            SaveSWM();
        }
        public override void Initialize()
        {

        }
        public override void ModifyWorldGenTasks(List<Terraria.WorldBuilding.GenPass> tasks, ref float totalWeight)
        {
            base.ModifyWorldGenTasks(tasks, ref totalWeight);
        }
        public override void ModifyHardmodeTasks(List<GenPass> list)
        {
        }
        public override void TileCountsAvailable(int[] tileCounts)
        {
            if (tileCounts[TileID.LivingWood] == 50) //replace with TileType<SaltwaterMineTile1 || SaltwaterMineTile2 || etc>()
            {

            }
        }
        #endregion
    **/
    }
}
