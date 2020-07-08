using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;
using Aerothyte.Projectiles.GlacialQuartzP;
using System;

namespace Aerothyte.Items.Accessories
{
    public class Infuser : ModItem
    {
        public override void SetDefaults()
        {
            item.accessory = true;
            item.height = 42;
            item.width = 30;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Infuser");
            Tooltip.SetDefault("Sucks to suck\nChance to fire a magical bolt at nearby enemies; uses a LOT of mana.");
        }
        public override void UpdateEquip(Player player)
        {
            player.GetModPlayer<AerothytePlayer>().InfuserEquip = true;
        }
        public override void AddRecipes()
        {
           // add Glacial Quartz later; material soon?
        }
    }
}
