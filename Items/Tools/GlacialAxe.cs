using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;
using Aerothyte.Projectiles.GlacialQuartzP;
using System;

namespace Aerothyte.Items.Tools
{
    public class GlacialAxe : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.damage = 10;
            item.useStyle = ItemUseStyleID.Swing;
            item.useAnimation = 20;
            item.useTime = 20;
            item.pick = 20;
            item.axe = 50;

        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glacial Axe");
            Tooltip.SetDefault("I guess this can be used offensively.");
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.Frostburn, 5);
        }
    }
}