using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;
using Aerothyte.NPCs.Testing;

namespace Aerothyte.Items.Dev
{
    public class DevSpawner : ModItem
    {
        public override void SetDefaults()
        {
            item.height = 16;
            item.width = 16;
            item.useStyle = ItemUseStyleID.Swing;
            item.noMelee = true;
        }
        public override bool UseItem(Player player)
        {
            NPC.NewNPC((int)Main.MouseWorld.X, (int)Main.MouseWorld.Y, ModContent.NPCType<TestTarget>());
            return true;
        }
    }
}
